namespace Server
{
    partial class Form1
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
            this.StatusTextBox = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(996, 48);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(499, 554);
            this.StatusTextBox.TabIndex = 0;
            this.StatusTextBox.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1125, 623);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "button1";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.BtnUpdate.Location = new System.Drawing.Point(675, 164);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "button1";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1526, 758);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.StatusTextBox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button UpadteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddNewHospital;
        private System.Windows.Forms.RichTextBox StatusTextBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button BtnUpdate;
    }
}

