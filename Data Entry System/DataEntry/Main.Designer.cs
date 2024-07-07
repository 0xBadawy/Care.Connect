namespace DataEntry
{
    partial class Main
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
            this.Login_button = new System.Windows.Forms.Button();
            this.ShowUser_button = new System.Windows.Forms.Button();
            this.UserSSN_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold);
            this.Login_button.Location = new System.Drawing.Point(459, 555);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(239, 42);
            this.Login_button.TabIndex = 1;
            this.Login_button.Text = "Add New User";
            this.Login_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // ShowUser_button
            // 
            this.ShowUser_button.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold);
            this.ShowUser_button.Location = new System.Drawing.Point(459, 292);
            this.ShowUser_button.Name = "ShowUser_button";
            this.ShowUser_button.Size = new System.Drawing.Size(239, 42);
            this.ShowUser_button.TabIndex = 1;
            this.ShowUser_button.Text = "Show User";
            this.ShowUser_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowUser_button.UseVisualStyleBackColor = true;
            this.ShowUser_button.Click += new System.EventHandler(this.ShowUser_button_Click);
            // 
            // UserSSN_Number
            // 
            this.UserSSN_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.UserSSN_Number.Location = new System.Drawing.Point(349, 231);
            this.UserSSN_Number.Name = "UserSSN_Number";
            this.UserSSN_Number.Size = new System.Drawing.Size(458, 35);
            this.UserSSN_Number.TabIndex = 2;
            this.UserSSN_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(251, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "User SSN";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserSSN_Number);
            this.Controls.Add(this.ShowUser_button);
            this.Controls.Add(this.Login_button);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button ShowUser_button;
        private System.Windows.Forms.TextBox UserSSN_Number;
        private System.Windows.Forms.Label label1;
    }
}