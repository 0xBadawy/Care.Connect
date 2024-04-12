namespace WinFormsAppAPI_TEST
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
            button1 = new Button();
            textBox_From = new TextBox();
            textBox_To = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(435, 469);
            button1.Name = "button1";
            button1.Size = new Size(130, 32);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_From
            // 
            textBox_From.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_From.Location = new Point(23, 93);
            textBox_From.Name = "textBox_From";
            textBox_From.Size = new Size(456, 38);
            textBox_From.TabIndex = 1;
            // 
            // textBox_To
            // 
            textBox_To.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_To.Location = new Point(529, 93);
            textBox_To.Name = "textBox_To";
            textBox_To.Size = new Size(451, 38);
            textBox_To.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 2;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(529, 60);
            label2.Name = "label2";
            label2.Size = new Size(36, 30);
            label2.TabIndex = 2;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(190, 157);
            label3.Name = "label3";
            label3.Size = new Size(629, 35);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(190, 205);
            label4.Name = "label4";
            label4.Size = new Size(629, 35);
            label4.TabIndex = 2;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(190, 267);
            label5.Name = "label5";
            label5.Size = new Size(629, 35);
            label5.TabIndex = 2;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(190, 323);
            label6.Name = "label6";
            label6.Size = new Size(629, 35);
            label6.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 513);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_To);
            Controls.Add(textBox_From);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox_From;
        private TextBox textBox_To;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}