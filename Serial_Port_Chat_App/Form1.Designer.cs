namespace Serial_Port_Chat_App
{
    partial class ChatForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            textBox1 = new TextBox();
            Port_Box = new ComboBox();
            label1 = new Label();
            Connect_Button = new Button();
            Disconnect_Button = new Button();
            TextBox = new RichTextBox();
            Send_Button = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 389);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 4;
            // 
            // Port_Box
            // 
            Port_Box.FormattingEnabled = true;
            Port_Box.Location = new Point(43, 29);
            Port_Box.Name = "Port_Box";
            Port_Box.Size = new Size(103, 28);
            Port_Box.TabIndex = 0;
            Port_Box.SelectedIndexChanged += Port_Box_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 1;
            label1.Text = "Serial Port List";
            // 
            // Connect_Button
            // 
            Connect_Button.ForeColor = SystemColors.ControlText;
            Connect_Button.Location = new Point(162, 29);
            Connect_Button.Name = "Connect_Button";
            Connect_Button.Size = new Size(114, 29);
            Connect_Button.TabIndex = 2;
            Connect_Button.Text = "Connect";
            Connect_Button.UseVisualStyleBackColor = true;
            Connect_Button.Click += Connect_Button_Click;
            // 
            // Disconnect_Button
            // 
            Disconnect_Button.Location = new Point(291, 29);
            Disconnect_Button.Name = "Disconnect_Button";
            Disconnect_Button.Size = new Size(114, 29);
            Disconnect_Button.TabIndex = 3;
            Disconnect_Button.Text = "Disconnect";
            Disconnect_Button.UseVisualStyleBackColor = true;
            Disconnect_Button.Click += Disconnect_Button_Click;
            // 
            // TextBox
            // 
            TextBox.BackColor = SystemColors.Window;
            TextBox.Location = new Point(43, 97);
            TextBox.Name = "TextBox";
            TextBox.ReadOnly = true;
            TextBox.Size = new Size(362, 277);
            TextBox.TabIndex = 5;
            TextBox.Text = "";
            // 
            // Send_Button
            // 
            Send_Button.BackColor = Color.MediumSpringGreen;
            Send_Button.ImageAlign = ContentAlignment.MiddleRight;
            Send_Button.Location = new Point(291, 389);
            Send_Button.Name = "Send_Button";
            Send_Button.Size = new Size(114, 29);
            Send_Button.TabIndex = 6;
            Send_Button.Text = "Send";
            Send_Button.UseVisualStyleBackColor = false;
            Send_Button.Click += Send_Button_Click;
            // 
            // label2
            // 
            label2.AccessibleName = "";
            label2.AutoSize = true;
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(43, 74);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            label2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vga_yesil;
            pictureBox1.Location = new Point(117, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.vga_Red;
            pictureBox2.Location = new Point(137, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(452, 465);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(Send_Button);
            Controls.Add(TextBox);
            Controls.Add(textBox1);
            Controls.Add(Disconnect_Button);
            Controls.Add(Connect_Button);
            Controls.Add(label1);
            Controls.Add(Port_Box);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ChatForm";
            Text = "Serial Port Chat ";
            Load += ChatForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Port_Box;
        private Label label1;
        private Button Connect_Button;
        private Button Disconnect_Button;
        private TextBox textBox1;
        private RichTextBox TextBox;
        private Button Send_Button;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
