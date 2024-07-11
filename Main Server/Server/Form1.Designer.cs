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
            this.components = new System.ComponentModel.Container();
            this.StatusTextBox = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Porgress1 = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.OMinus_ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.BMinus_ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.ABMinus_ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.AMinus_ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.OPlus_ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.BPlus_ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ABPlus_ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.APlus_ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.EORProgressBar = new CircularProgressBar.CircularProgressBar();
            this.ICUProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.IRProgressBar = new CircularProgressBar.CircularProgressBar();
            this.MEDProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusTextBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 13.25F, System.Drawing.FontStyle.Bold);
            this.StatusTextBox.ForeColor = System.Drawing.Color.White;
            this.StatusTextBox.Location = new System.Drawing.Point(0, 44);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.StatusTextBox.Size = new System.Drawing.Size(384, 691);
            this.StatusTextBox.TabIndex = 0;
            this.StatusTextBox.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(275, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(249)))));
            this.BtnUpdate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUpdate.Location = new System.Drawing.Point(172, 8);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(97, 34);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1526, 47);
            this.panel5.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 45);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1526, 2);
            this.panel9.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1484, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "×";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(575, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Server Dashboard";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.StatusTextBox);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1142, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(384, 787);
            this.panel6.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnClear);
            this.panel8.Controls.Add(this.BtnUpdate);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 735);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(384, 52);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(384, 44);
            this.panel7.TabIndex = 0;
            // 
            // Porgress1
            // 
            this.Porgress1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Porgress1.AnimationSpeed = 500;
            this.Porgress1.BackColor = System.Drawing.Color.Transparent;
            this.Porgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.25F, System.Drawing.FontStyle.Bold);
            this.Porgress1.ForeColor = System.Drawing.Color.White;
            this.Porgress1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Porgress1.InnerMargin = 2;
            this.Porgress1.InnerWidth = -1;
            this.Porgress1.Location = new System.Drawing.Point(621, 159);
            this.Porgress1.MarqueeAnimationSpeed = 2000;
            this.Porgress1.Name = "Porgress1";
            this.Porgress1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.Porgress1.OuterMargin = -25;
            this.Porgress1.OuterWidth = 26;
            this.Porgress1.ProgressColor = System.Drawing.Color.Snow;
            this.Porgress1.ProgressWidth = 15;
            this.Porgress1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Porgress1.Size = new System.Drawing.Size(190, 190);
            this.Porgress1.StartAngle = 270;
            this.Porgress1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Porgress1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Porgress1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Porgress1.SubscriptText = "";
            this.Porgress1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Porgress1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Porgress1.SuperscriptText = "";
            this.Porgress1.TabIndex = 5;
            this.Porgress1.Text = "1243";
            this.Porgress1.TextMargin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.Porgress1.Value = 79;
            this.Porgress1.Click += new System.EventHandler(this.Porgress1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.OMinus_ProgressBar);
            this.panel10.Controls.Add(this.BMinus_ProgressBar);
            this.panel10.Controls.Add(this.ABMinus_ProgressBar);
            this.panel10.Controls.Add(this.AMinus_ProgressBar);
            this.panel10.Controls.Add(this.OPlus_ProgressBar);
            this.panel10.Controls.Add(this.BPlus_ProgressBar);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.ABPlus_ProgressBar);
            this.panel10.Controls.Add(this.APlus_ProgressBar);
            this.panel10.Location = new System.Drawing.Point(24, 91);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(550, 349);
            this.panel10.TabIndex = 6;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 14.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(158, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 27);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total Number : 543";
            // 
            // OMinus_ProgressBar
            // 
            this.OMinus_ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.OMinus_ProgressBar.AnimationSpeed = 500;
            this.OMinus_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.OMinus_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.OMinus_ProgressBar.ForeColor = System.Drawing.Color.White;
            this.OMinus_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.OMinus_ProgressBar.InnerMargin = 2;
            this.OMinus_ProgressBar.InnerWidth = -1;
            this.OMinus_ProgressBar.Location = new System.Drawing.Point(402, 162);
            this.OMinus_ProgressBar.MarqueeAnimationSpeed = 2000;
            this.OMinus_ProgressBar.Name = "OMinus_ProgressBar";
            this.OMinus_ProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.OMinus_ProgressBar.OuterMargin = -25;
            this.OMinus_ProgressBar.OuterWidth = 26;
            this.OMinus_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OMinus_ProgressBar.ProgressWidth = 10;
            this.OMinus_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OMinus_ProgressBar.Size = new System.Drawing.Size(114, 115);
            this.OMinus_ProgressBar.StartAngle = 270;
            this.OMinus_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.OMinus_ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.OMinus_ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(0, 0, -19, 0);
            this.OMinus_ProgressBar.SubscriptText = "";
            this.OMinus_ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.OMinus_ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(8, 0, -7, 0);
            this.OMinus_ProgressBar.SuperscriptText = "";
            this.OMinus_ProgressBar.TabIndex = 11;
            this.OMinus_ProgressBar.Text = "20%";
            this.OMinus_ProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.OMinus_ProgressBar.Value = 20;
            // 
            // BMinus_ProgressBar
            // 
            this.BMinus_ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.BMinus_ProgressBar.AnimationSpeed = 500;
            this.BMinus_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.BMinus_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.BMinus_ProgressBar.ForeColor = System.Drawing.Color.White;
            this.BMinus_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.BMinus_ProgressBar.InnerMargin = 2;
            this.BMinus_ProgressBar.InnerWidth = -1;
            this.BMinus_ProgressBar.Location = new System.Drawing.Point(271, 162);
            this.BMinus_ProgressBar.MarqueeAnimationSpeed = 2000;
            this.BMinus_ProgressBar.Name = "BMinus_ProgressBar";
            this.BMinus_ProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.BMinus_ProgressBar.OuterMargin = -25;
            this.BMinus_ProgressBar.OuterWidth = 26;
            this.BMinus_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BMinus_ProgressBar.ProgressWidth = 10;
            this.BMinus_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BMinus_ProgressBar.Size = new System.Drawing.Size(114, 115);
            this.BMinus_ProgressBar.StartAngle = 270;
            this.BMinus_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BMinus_ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.BMinus_ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.BMinus_ProgressBar.SubscriptText = "";
            this.BMinus_ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.BMinus_ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.BMinus_ProgressBar.SuperscriptText = "";
            this.BMinus_ProgressBar.TabIndex = 12;
            this.BMinus_ProgressBar.Text = "2%";
            this.BMinus_ProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.BMinus_ProgressBar.Value = 2;
            // 
            // ABMinus_ProgressBar
            // 
            this.ABMinus_ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ABMinus_ProgressBar.AnimationSpeed = 500;
            this.ABMinus_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ABMinus_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.ABMinus_ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ABMinus_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ABMinus_ProgressBar.InnerMargin = 2;
            this.ABMinus_ProgressBar.InnerWidth = -1;
            this.ABMinus_ProgressBar.Location = new System.Drawing.Point(140, 162);
            this.ABMinus_ProgressBar.MarqueeAnimationSpeed = 2000;
            this.ABMinus_ProgressBar.Name = "ABMinus_ProgressBar";
            this.ABMinus_ProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.ABMinus_ProgressBar.OuterMargin = -25;
            this.ABMinus_ProgressBar.OuterWidth = 26;
            this.ABMinus_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ABMinus_ProgressBar.ProgressWidth = 10;
            this.ABMinus_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ABMinus_ProgressBar.Size = new System.Drawing.Size(114, 115);
            this.ABMinus_ProgressBar.StartAngle = 270;
            this.ABMinus_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ABMinus_ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ABMinus_ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ABMinus_ProgressBar.SubscriptText = "";
            this.ABMinus_ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ABMinus_ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ABMinus_ProgressBar.SuperscriptText = "";
            this.ABMinus_ProgressBar.TabIndex = 13;
            this.ABMinus_ProgressBar.Text = "15%";
            this.ABMinus_ProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.ABMinus_ProgressBar.Value = 15;
            // 
            // AMinus_ProgressBar
            // 
            this.AMinus_ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.AMinus_ProgressBar.AnimationSpeed = 500;
            this.AMinus_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.AMinus_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.AMinus_ProgressBar.ForeColor = System.Drawing.Color.White;
            this.AMinus_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.AMinus_ProgressBar.InnerMargin = 2;
            this.AMinus_ProgressBar.InnerWidth = -1;
            this.AMinus_ProgressBar.Location = new System.Drawing.Point(9, 162);
            this.AMinus_ProgressBar.MarqueeAnimationSpeed = 2000;
            this.AMinus_ProgressBar.Name = "AMinus_ProgressBar";
            this.AMinus_ProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.AMinus_ProgressBar.OuterMargin = -25;
            this.AMinus_ProgressBar.OuterWidth = 26;
            this.AMinus_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AMinus_ProgressBar.ProgressWidth = 10;
            this.AMinus_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AMinus_ProgressBar.Size = new System.Drawing.Size(114, 115);
            this.AMinus_ProgressBar.StartAngle = 270;
            this.AMinus_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.AMinus_ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.AMinus_ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.AMinus_ProgressBar.SubscriptText = "";
            this.AMinus_ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.AMinus_ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.AMinus_ProgressBar.SuperscriptText = "";
            this.AMinus_ProgressBar.TabIndex = 14;
            this.AMinus_ProgressBar.Text = "3%";
            this.AMinus_ProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.AMinus_ProgressBar.Value = 3;
            // 
            // OPlus_ProgressBar
            // 
            this.OPlus_ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.OPlus_ProgressBar.AnimationSpeed = 500;
            this.OPlus_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.OPlus_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.OPlus_ProgressBar.ForeColor = System.Drawing.Color.White;
            this.OPlus_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.OPlus_ProgressBar.InnerMargin = 2;
            this.OPlus_ProgressBar.InnerWidth = -1;
            this.OPlus_ProgressBar.Location = new System.Drawing.Point(414, 8);
            this.OPlus_ProgressBar.MarqueeAnimationSpeed = 2000;
            this.OPlus_ProgressBar.Name = "OPlus_ProgressBar";
            this.OPlus_ProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.OPlus_ProgressBar.OuterMargin = -25;
            this.OPlus_ProgressBar.OuterWidth = 26;
            this.OPlus_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OPlus_ProgressBar.ProgressWidth = 10;
            this.OPlus_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OPlus_ProgressBar.Size = new System.Drawing.Size(114, 114);
            this.OPlus_ProgressBar.StartAngle = 270;
            this.OPlus_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.OPlus_ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.OPlus_ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.OPlus_ProgressBar.SubscriptText = "";
            this.OPlus_ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.OPlus_ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.OPlus_ProgressBar.SuperscriptText = "";
            this.OPlus_ProgressBar.TabIndex = 6;
            this.OPlus_ProgressBar.Text = "12%";
            this.OPlus_ProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.OPlus_ProgressBar.Value = 12;
            // 
            // BPlus_ProgressBar
            // 
            this.BPlus_ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.BPlus_ProgressBar.AnimationSpeed = 500;
            this.BPlus_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.BPlus_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.BPlus_ProgressBar.ForeColor = System.Drawing.Color.White;
            this.BPlus_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.BPlus_ProgressBar.InnerMargin = 2;
            this.BPlus_ProgressBar.InnerWidth = -1;
            this.BPlus_ProgressBar.Location = new System.Drawing.Point(279, 8);
            this.BPlus_ProgressBar.MarqueeAnimationSpeed = 2000;
            this.BPlus_ProgressBar.Name = "BPlus_ProgressBar";
            this.BPlus_ProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.BPlus_ProgressBar.OuterMargin = -25;
            this.BPlus_ProgressBar.OuterWidth = 26;
            this.BPlus_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BPlus_ProgressBar.ProgressWidth = 10;
            this.BPlus_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BPlus_ProgressBar.Size = new System.Drawing.Size(114, 114);
            this.BPlus_ProgressBar.StartAngle = 270;
            this.BPlus_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BPlus_ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.BPlus_ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.BPlus_ProgressBar.SubscriptText = "";
            this.BPlus_ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.BPlus_ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.BPlus_ProgressBar.SuperscriptText = "";
            this.BPlus_ProgressBar.TabIndex = 6;
            this.BPlus_ProgressBar.Text = "6%";
            this.BPlus_ProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.BPlus_ProgressBar.Value = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(422, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "O Minus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(436, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "O Plus";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(295, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "B Minus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(307, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "B Plus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(157, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "AB Minus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(29, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "A Minus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(167, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "AB Plus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "A Plus";
            // 
            // ABPlus_ProgressBar
            // 
            this.ABPlus_ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ABPlus_ProgressBar.AnimationSpeed = 500;
            this.ABPlus_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ABPlus_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.ABPlus_ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ABPlus_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ABPlus_ProgressBar.InnerMargin = 2;
            this.ABPlus_ProgressBar.InnerWidth = -1;
            this.ABPlus_ProgressBar.Location = new System.Drawing.Point(144, 8);
            this.ABPlus_ProgressBar.MarqueeAnimationSpeed = 2000;
            this.ABPlus_ProgressBar.Name = "ABPlus_ProgressBar";
            this.ABPlus_ProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.ABPlus_ProgressBar.OuterMargin = -25;
            this.ABPlus_ProgressBar.OuterWidth = 26;
            this.ABPlus_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ABPlus_ProgressBar.ProgressWidth = 10;
            this.ABPlus_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ABPlus_ProgressBar.Size = new System.Drawing.Size(114, 114);
            this.ABPlus_ProgressBar.StartAngle = 270;
            this.ABPlus_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ABPlus_ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ABPlus_ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ABPlus_ProgressBar.SubscriptText = "";
            this.ABPlus_ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ABPlus_ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ABPlus_ProgressBar.SuperscriptText = "";
            this.ABPlus_ProgressBar.TabIndex = 6;
            this.ABPlus_ProgressBar.Text = "34%";
            this.ABPlus_ProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.ABPlus_ProgressBar.Value = 34;
            // 
            // APlus_ProgressBar
            // 
            this.APlus_ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.APlus_ProgressBar.AnimationSpeed = 500;
            this.APlus_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.APlus_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.APlus_ProgressBar.ForeColor = System.Drawing.Color.White;
            this.APlus_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.APlus_ProgressBar.InnerMargin = 2;
            this.APlus_ProgressBar.InnerWidth = -1;
            this.APlus_ProgressBar.Location = new System.Drawing.Point(9, 8);
            this.APlus_ProgressBar.MarqueeAnimationSpeed = 2000;
            this.APlus_ProgressBar.Name = "APlus_ProgressBar";
            this.APlus_ProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.APlus_ProgressBar.OuterMargin = -25;
            this.APlus_ProgressBar.OuterWidth = 26;
            this.APlus_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.APlus_ProgressBar.ProgressWidth = 10;
            this.APlus_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.APlus_ProgressBar.Size = new System.Drawing.Size(114, 114);
            this.APlus_ProgressBar.StartAngle = 270;
            this.APlus_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.APlus_ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.APlus_ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.APlus_ProgressBar.SubscriptText = "";
            this.APlus_ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.APlus_ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.APlus_ProgressBar.SuperscriptText = "";
            this.APlus_ProgressBar.TabIndex = 6;
            this.APlus_ProgressBar.Text = "8%";
            this.APlus_ProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.APlus_ProgressBar.Value = 8;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.panel11.Controls.Add(this.label13);
            this.panel11.Controls.Add(this.EORProgressBar);
            this.panel11.Controls.Add(this.ICUProgressBar);
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Controls.Add(this.label19);
            this.panel11.Controls.Add(this.label20);
            this.panel11.Controls.Add(this.IRProgressBar);
            this.panel11.Controls.Add(this.MEDProgressBar);
            this.panel11.Location = new System.Drawing.Point(124, 515);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(892, 267);
            this.panel11.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 14.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(607, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 27);
            this.label12.TabIndex = 15;
            this.label12.Text = "Number of hospitals";
            // 
            // EORProgressBar
            // 
            this.EORProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.EORProgressBar.AnimationSpeed = 500;
            this.EORProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.EORProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.EORProgressBar.ForeColor = System.Drawing.Color.White;
            this.EORProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.EORProgressBar.InnerMargin = 2;
            this.EORProgressBar.InnerWidth = -1;
            this.EORProgressBar.Location = new System.Drawing.Point(677, 68);
            this.EORProgressBar.MarqueeAnimationSpeed = 2000;
            this.EORProgressBar.Name = "EORProgressBar";
            this.EORProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.EORProgressBar.OuterMargin = -25;
            this.EORProgressBar.OuterWidth = 26;
            this.EORProgressBar.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.EORProgressBar.ProgressWidth = 16;
            this.EORProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EORProgressBar.Size = new System.Drawing.Size(136, 134);
            this.EORProgressBar.StartAngle = 270;
            this.EORProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EORProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.EORProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.EORProgressBar.SubscriptText = "";
            this.EORProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.EORProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.EORProgressBar.SuperscriptText = "";
            this.EORProgressBar.TabIndex = 6;
            this.EORProgressBar.Text = "12%";
            this.EORProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.EORProgressBar.Value = 12;
            // 
            // ICUProgressBar
            // 
            this.ICUProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ICUProgressBar.AnimationSpeed = 500;
            this.ICUProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ICUProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.ICUProgressBar.ForeColor = System.Drawing.Color.White;
            this.ICUProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ICUProgressBar.InnerMargin = 2;
            this.ICUProgressBar.InnerWidth = -1;
            this.ICUProgressBar.Location = new System.Drawing.Point(465, 68);
            this.ICUProgressBar.MarqueeAnimationSpeed = 2000;
            this.ICUProgressBar.Name = "ICUProgressBar";
            this.ICUProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.ICUProgressBar.OuterMargin = -25;
            this.ICUProgressBar.OuterWidth = 26;
            this.ICUProgressBar.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.ICUProgressBar.ProgressWidth = 16;
            this.ICUProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ICUProgressBar.Size = new System.Drawing.Size(136, 134);
            this.ICUProgressBar.StartAngle = 270;
            this.ICUProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ICUProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ICUProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ICUProgressBar.SubscriptText = "";
            this.ICUProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ICUProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ICUProgressBar.SuperscriptText = "";
            this.ICUProgressBar.TabIndex = 6;
            this.ICUProgressBar.Text = "6%";
            this.ICUProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.ICUProgressBar.Value = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(467, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "ICU Room";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(679, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "EOR Room";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(270, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 28);
            this.label19.TabIndex = 0;
            this.label19.Text = "IR Room";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(44, 219);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(133, 28);
            this.label20.TabIndex = 0;
            this.label20.Text = "MED Room";
            // 
            // IRProgressBar
            // 
            this.IRProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.IRProgressBar.AnimationSpeed = 500;
            this.IRProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.IRProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.IRProgressBar.ForeColor = System.Drawing.Color.White;
            this.IRProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.IRProgressBar.InnerMargin = 2;
            this.IRProgressBar.InnerWidth = -1;
            this.IRProgressBar.Location = new System.Drawing.Point(253, 68);
            this.IRProgressBar.MarqueeAnimationSpeed = 2000;
            this.IRProgressBar.Name = "IRProgressBar";
            this.IRProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.IRProgressBar.OuterMargin = -25;
            this.IRProgressBar.OuterWidth = 26;
            this.IRProgressBar.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.IRProgressBar.ProgressWidth = 16;
            this.IRProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.IRProgressBar.Size = new System.Drawing.Size(136, 134);
            this.IRProgressBar.StartAngle = 270;
            this.IRProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.IRProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.IRProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.IRProgressBar.SubscriptText = "";
            this.IRProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.IRProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.IRProgressBar.SuperscriptText = "";
            this.IRProgressBar.TabIndex = 6;
            this.IRProgressBar.Text = "34%";
            this.IRProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.IRProgressBar.Value = 34;
            // 
            // MEDProgressBar
            // 
            this.MEDProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.MEDProgressBar.AnimationSpeed = 500;
            this.MEDProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.MEDProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.MEDProgressBar.ForeColor = System.Drawing.Color.White;
            this.MEDProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.MEDProgressBar.InnerMargin = 2;
            this.MEDProgressBar.InnerWidth = -1;
            this.MEDProgressBar.Location = new System.Drawing.Point(41, 68);
            this.MEDProgressBar.MarqueeAnimationSpeed = 2000;
            this.MEDProgressBar.Name = "MEDProgressBar";
            this.MEDProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.MEDProgressBar.OuterMargin = -25;
            this.MEDProgressBar.OuterWidth = 26;
            this.MEDProgressBar.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.MEDProgressBar.ProgressWidth = 16;
            this.MEDProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MEDProgressBar.Size = new System.Drawing.Size(136, 134);
            this.MEDProgressBar.StartAngle = 270;
            this.MEDProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MEDProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.MEDProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.MEDProgressBar.SubscriptText = "";
            this.MEDProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.MEDProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.MEDProgressBar.SuperscriptText = "";
            this.MEDProgressBar.TabIndex = 6;
            this.MEDProgressBar.Text = "8%";
            this.MEDProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.MEDProgressBar.Value = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 18.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(250, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(426, 33);
            this.label13.TabIndex = 15;
            this.label13.Text = "Emergency room occupancy rate";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(890, 159);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Snow;
            this.circularProgressBar1.ProgressWidth = 15;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.circularProgressBar1.Size = new System.Drawing.Size(190, 190);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 5;
            this.circularProgressBar1.Text = "9576";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.Value = 59;
            this.circularProgressBar1.Click += new System.EventHandler(this.Porgress1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 14.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(861, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 27);
            this.label15.TabIndex = 15;
            this.label15.Text = "Number of ambulances";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1526, 834);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.Porgress1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "111";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private CircularProgressBar.CircularProgressBar Porgress1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private CircularProgressBar.CircularProgressBar APlus_ProgressBar;
        private CircularProgressBar.CircularProgressBar OPlus_ProgressBar;
        private CircularProgressBar.CircularProgressBar BPlus_ProgressBar;
        private CircularProgressBar.CircularProgressBar ABPlus_ProgressBar;
        private CircularProgressBar.CircularProgressBar OMinus_ProgressBar;
        private CircularProgressBar.CircularProgressBar BMinus_ProgressBar;
        private CircularProgressBar.CircularProgressBar ABMinus_ProgressBar;
        private CircularProgressBar.CircularProgressBar AMinus_ProgressBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label12;
        private CircularProgressBar.CircularProgressBar EORProgressBar;
        private CircularProgressBar.CircularProgressBar ICUProgressBar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private CircularProgressBar.CircularProgressBar IRProgressBar;
        private CircularProgressBar.CircularProgressBar MEDProgressBar;
        private System.Windows.Forms.Label label13;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label15;
    }
}

