using System.IO.Ports;
using System.IO;
using System.Runtime.Versioning;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;

namespace Serial_Port_Chat_App
{
    public partial class ChatForm : Form
    {
        private SerialPort SerialPort1;
        public delegate void Datashw(string s);

        public void WriteTextBox(string s)
        {
            TextBox.Text += s;
            TextBox.AppendText(Environment.NewLine);

        }

        public ChatForm()
        {

            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            foreach (var port in SerialPort.GetPortNames())
            {
                Port_Box.Items.Add(port);
            }
            Port_Box.SelectedIndex = 0;
            Disconnect_Button.Enabled = false;
            Send_Button.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                string message = "User 1: " + textBox1.Text;
                SerialPort1.Write(textBox1.Text);
                WriteTextBox(message);
                textBox1.Clear();


            }
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {

            SerialPort1 = new SerialPort();

            SerialPort1.PortName = Port_Box.Text;
            SerialPort1.BaudRate = 9600;
            SerialPort1.DataBits = 8;
            SerialPort1.Parity = Parity.Even;
            SerialPort1.StopBits = StopBits.One;

            try
            {
                SerialPort1.Open();
                SerialPort1.DataReceived += SerialPort1_DataReceived;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Failed\n Error Cause : {ex.Message}", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            if (SerialPort1.IsOpen)
            {
                Connect_Button.Enabled = false;
                label2.Visible = true;
                label2.Text = "Connected";
                label2.ForeColor = Color.Green;
                Port_Box.Enabled = false;
                Disconnect_Button.Enabled = true;
                Send_Button.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

            }
        }

        private void Port_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Disconnect_Button_Click(object sender, EventArgs e)
        {

            if (SerialPort1.IsOpen)
            {
                SerialPort1.Close();
                Connect_Button.Enabled = true;
                Disconnect_Button.Enabled = false;
                Port_Box.Enabled = true;
                label2.Text = "Disconnected";
                label2.ForeColor = Color.Red;
                Send_Button.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;


            }
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string ReceivedData = SerialPort1.ReadExisting();
            string message = "User 2: " + ReceivedData;
            TextBox.Invoke(new Datashw(WriteTextBox), message);

        }

        
    }
}
