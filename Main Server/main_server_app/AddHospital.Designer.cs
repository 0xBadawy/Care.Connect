namespace MainServer
{
    partial class AddHospital
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
            Btn_Add = new Button();
            Hospital_ID = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            Hospital_Name = new TextBox();
            label3 = new Label();
            Hospital_Location = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Btn_Add
            // 
            Btn_Add.Location = new Point(438, 224);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(219, 30);
            Btn_Add.TabIndex = 0;
            Btn_Add.Text = "Add";
            Btn_Add.UseVisualStyleBackColor = true;
            Btn_Add.Click += Btn_Add_Click_1;
            // 
            // Hospital_ID
            // 
            Hospital_ID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Hospital_ID.Location = new Point(17, 93);
            Hospital_ID.Name = "Hospital_ID";
            Hospital_ID.Size = new Size(323, 31);
            Hospital_ID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Hospital ID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1154, 283);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(411, 63);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 5;
            label2.Text = "Hospital Name";
            // 
            // Hospital_Name
            // 
            Hospital_Name.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Hospital_Name.Location = new Point(416, 93);
            Hospital_Name.Name = "Hospital_Name";
            Hospital_Name.Size = new Size(323, 31);
            Hospital_Name.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(799, 63);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 7;
            label3.Text = "Hospital Location";
            // 
            // Hospital_Location
            // 
            Hospital_Location.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Hospital_Location.Location = new Point(804, 93);
            Hospital_Location.Name = "Hospital_Location";
            Hospital_Location.Size = new Size(323, 31);
            Hospital_Location.TabIndex = 6;
            // 
            // AddHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 555);
            Controls.Add(label3);
            Controls.Add(Hospital_Location);
            Controls.Add(label2);
            Controls.Add(Hospital_Name);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(Hospital_ID);
            Controls.Add(Btn_Add);
            Name = "AddHospital";
            Text = "AddHospital";
            Load += AddHospital_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Add;
        private TextBox Hospital_ID;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox Hospital_Name;
        private Label label3;
        private TextBox Hospital_Location;
    }
}