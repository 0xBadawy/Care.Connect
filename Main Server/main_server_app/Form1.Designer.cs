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
            label2 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            ClearBtn = new Button();
            panel3 = new Panel();
            label1 = new Label();
            AddNewHospital = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // StatusTextBox
            // 
            StatusTextBox.Dock = DockStyle.Fill;
            StatusTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            StatusTextBox.Location = new Point(0, 40);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(337, 630);
            StatusTextBox.TabIndex = 0;
            StatusTextBox.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1417, 44);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(589, 2);
            label2.Name = "label2";
            label2.Size = new Size(164, 37);
            label2.TabIndex = 0;
            label2.Text = "Main Server";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(StatusTextBox);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1080, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 670);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(ClearBtn);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 622);
            panel4.Name = "panel4";
            panel4.Size = new Size(337, 48);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 1;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(208, 6);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(83, 33);
            ClearBtn.TabIndex = 0;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 40);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(107, 7);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "Status";
            // 
            // AddNewHospital
            // 
            AddNewHospital.Location = new Point(12, 672);
            AddNewHospital.Name = "AddNewHospital";
            AddNewHospital.Size = new Size(179, 33);
            AddNewHospital.TabIndex = 3;
            AddNewHospital.Text = "Add New Hospital";
            AddNewHospital.UseVisualStyleBackColor = true;
            AddNewHospital.Click += AddNewHospital_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 714);
            Controls.Add(AddNewHospital);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
