namespace hospital_data_update_App
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            Input_HospitalID = new TextBox();
            Input_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Login = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 458);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Input_HospitalID
            // 
            Input_HospitalID.Font = new Font("Segoe UI Semibold", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            Input_HospitalID.Location = new Point(397, 168);
            Input_HospitalID.Name = "Input_HospitalID";
            Input_HospitalID.Size = new Size(320, 34);
            Input_HospitalID.TabIndex = 1;
            // 
            // Input_Password
            // 
            Input_Password.Font = new Font("Segoe UI Semibold", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            Input_Password.Location = new Point(397, 250);
            Input_Password.Name = "Input_Password";
            Input_Password.Size = new Size(320, 34);
            Input_Password.TabIndex = 2;
            Input_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(397, 135);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 3;
            label1.Text = "Hospital ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(397, 219);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(468, 36);
            label3.Name = "label3";
            label3.Size = new Size(191, 37);
            label3.TabIndex = 3;
            label3.Text = "Get Started";
            label3.Click += label3_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.CornflowerBlue;
            btn_Login.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.ButtonFace;
            btn_Login.Location = new Point(418, 351);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(283, 40);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Log in";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(532, 394);
            label4.Name = "label4";
            label4.Size = new Size(48, 30);
            label4.TabIndex = 3;
            label4.Text = "Exit";
            label4.Click += label4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(754, 456);
            Controls.Add(btn_Login);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Input_Password);
            Controls.Add(Input_HospitalID);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            Click += Login_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox Input_HospitalID;
        private TextBox Input_Password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Login;
        private Label label4;
    }
}