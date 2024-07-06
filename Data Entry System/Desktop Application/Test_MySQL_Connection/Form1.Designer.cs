namespace Test_MySQL_Connection
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
            dataGridView1 = new DataGridView();
            addData = new Button();
            textBox_ID = new TextBox();
            textBox_name = new TextBox();
            textBox_mail = new TextBox();
            textBox_Num = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Refrech = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(764, 150);
            dataGridView1.TabIndex = 0;
            // 
            // addData
            // 
            addData.Location = new Point(688, 62);
            addData.Name = "addData";
            addData.Size = new Size(75, 23);
            addData.TabIndex = 1;
            addData.Text = "insert";
            addData.UseVisualStyleBackColor = true;
            addData.Click += addData_Click;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(58, 62);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(100, 23);
            textBox_ID.TabIndex = 2;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(193, 62);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(100, 23);
            textBox_name.TabIndex = 2;
            // 
            // textBox_mail
            // 
            textBox_mail.Location = new Point(313, 62);
            textBox_mail.Name = "textBox_mail";
            textBox_mail.Size = new Size(100, 23);
            textBox_mail.TabIndex = 2;
            // 
            // textBox_Num
            // 
            textBox_Num.Location = new Point(434, 62);
            textBox_Num.Name = "textBox_Num";
            textBox_Num.Size = new Size(100, 23);
            textBox_Num.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 38);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 3;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(193, 38);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 3;
            label2.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(313, 38);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 3;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(434, 38);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 3;
            label4.Text = "num";
            // 
            // Refrech
            // 
            Refrech.Location = new Point(376, 394);
            Refrech.Name = "Refrech";
            Refrech.Size = new Size(75, 23);
            Refrech.TabIndex = 4;
            Refrech.Text = "Refrech";
            Refrech.UseVisualStyleBackColor = true;
            Refrech.Click += Refrech_Click;
            // 
            // button1
            // 
            button1.Location = new Point(193, 394);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Delet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Refrech);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Num);
            Controls.Add(textBox_mail);
            Controls.Add(textBox_name);
            Controls.Add(textBox_ID);
            Controls.Add(addData);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addData;
        private TextBox textBox_ID;
        private TextBox textBox_name;
        private TextBox textBox_mail;
        private TextBox textBox_Num;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Refrech;
        private Button button1;
    }
}