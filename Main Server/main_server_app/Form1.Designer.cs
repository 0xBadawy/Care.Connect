namespace MainServer
{
    partial class Form1
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
            StatusTextBox = new RichTextBox();
            panel1 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            ClearBtn = new Button();
            panel3 = new Panel();
            label1 = new Label();
            AddNewHospital = new Button();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // StatusTextBox
            // 
            StatusTextBox.BorderStyle = BorderStyle.FixedSingle;
            StatusTextBox.Dock = DockStyle.Fill;
            StatusTextBox.Font = new Font("Cascadia Code SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            StatusTextBox.Location = new Point(0, 34);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(337, 674);
            StatusTextBox.TabIndex = 0;
            StatusTextBox.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1416, 44);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(1379, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(34, 30);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-2, -7);
            label3.Name = "label3";
            label3.Size = new Size(36, 37);
            label3.TabIndex = 0;
            label3.Text = "×";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(622, 3);
            label2.Name = "label2";
            label2.Size = new Size(164, 37);
            label2.TabIndex = 0;
            label2.Text = "Main Server";
            // 
            // panel2
            // 
            panel2.Controls.Add(StatusTextBox);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1079, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 757);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(ClearBtn);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 708);
            panel4.Name = "panel4";
            panel4.Size = new Size(337, 49);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(57, 8);
            button1.Name = "button1";
            button1.Size = new Size(101, 34);
            button1.TabIndex = 1;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.Crimson;
            ClearBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.ButtonHighlight;
            ClearBtn.Location = new Point(183, 8);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(101, 34);
            ClearBtn.TabIndex = 0;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 34);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 3);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "Status";
            // 
            // AddNewHospital
            // 
            AddNewHospital.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddNewHospital.Location = new Point(383, 768);
            AddNewHospital.Name = "AddNewHospital";
            AddNewHospital.Size = new Size(179, 33);
            AddNewHospital.TabIndex = 3;
            AddNewHospital.Text = "Add New Hospital";
            AddNewHospital.UseVisualStyleBackColor = true;
            AddNewHospital.Click += AddNewHospital_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(635, 768);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(438, 23);
            progressBar1.TabIndex = 4;
            progressBar1.Value = 43;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1416, 801);
            Controls.Add(progressBar1);
            Controls.Add(AddNewHospital);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox StatusTextBox;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button ClearBtn;
        private Button AddNewHospital;
        private Button button1;
        private Panel panel5;
        private Label label3;
        private ProgressBar progressBar1;
    }
}
