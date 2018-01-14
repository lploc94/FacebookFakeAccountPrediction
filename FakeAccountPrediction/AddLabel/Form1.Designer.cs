namespace AddLabel
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LoginXpathTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XPassTB = new System.Windows.Forms.TextBox();
            this.XIDTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.LoginURLTB = new System.Windows.Forms.TextBox();
            this.LoginCB = new System.Windows.Forms.CheckBox();
            this.StartBTN = new System.Windows.Forms.Button();
            this.RealBTN = new System.Windows.Forms.Button();
            this.FakeBTN = new System.Windows.Forms.Button();
            this.UnknowBTN = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.ProcessLB = new System.Windows.Forms.TextBox();
            this.SleepingNUD = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SleepingNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LoginXpathTB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.XPassTB);
            this.groupBox2.Controls.Add(this.XIDTB);
            this.groupBox2.Controls.Add(this.PassTB);
            this.groupBox2.Controls.Add(this.IDTB);
            this.groupBox2.Controls.Add(this.LoginURLTB);
            this.groupBox2.Controls.Add(this.LoginCB);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 155);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // LoginXpathTB
            // 
            this.LoginXpathTB.Location = new System.Drawing.Point(126, 116);
            this.LoginXpathTB.Name = "LoginXpathTB";
            this.LoginXpathTB.Size = new System.Drawing.Size(351, 20);
            this.LoginXpathTB.TabIndex = 30;
            this.LoginXpathTB.Text = "//input[@type=\'submit\']";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "LoginButton Xpath ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Pass Xpath";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "ID Xpath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Login Address";
            // 
            // XPassTB
            // 
            this.XPassTB.Location = new System.Drawing.Point(289, 85);
            this.XPassTB.Name = "XPassTB";
            this.XPassTB.Size = new System.Drawing.Size(187, 20);
            this.XPassTB.TabIndex = 23;
            this.XPassTB.Text = "//input[@name=\'pass\']";
            // 
            // XIDTB
            // 
            this.XIDTB.Location = new System.Drawing.Point(289, 56);
            this.XIDTB.Name = "XIDTB";
            this.XIDTB.Size = new System.Drawing.Size(187, 20);
            this.XIDTB.TabIndex = 22;
            this.XIDTB.Text = "//input[@name=\'email\']";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(50, 85);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(153, 20);
            this.PassTB.TabIndex = 21;
            // 
            // IDTB
            // 
            this.IDTB.Location = new System.Drawing.Point(50, 59);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(153, 20);
            this.IDTB.TabIndex = 20;
            // 
            // LoginURLTB
            // 
            this.LoginURLTB.Location = new System.Drawing.Point(89, 25);
            this.LoginURLTB.Name = "LoginURLTB";
            this.LoginURLTB.Size = new System.Drawing.Size(387, 20);
            this.LoginURLTB.TabIndex = 19;
            this.LoginURLTB.Text = "https://www.facebook.com/";
            // 
            // LoginCB
            // 
            this.LoginCB.AutoSize = true;
            this.LoginCB.Location = new System.Drawing.Point(12, 0);
            this.LoginCB.Name = "LoginCB";
            this.LoginCB.Size = new System.Drawing.Size(103, 17);
            this.LoginCB.TabIndex = 18;
            this.LoginCB.Text = "Facebook Login";
            this.LoginCB.UseVisualStyleBackColor = true;
            // 
            // StartBTN
            // 
            this.StartBTN.Location = new System.Drawing.Point(12, 173);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(99, 30);
            this.StartBTN.TabIndex = 50;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // RealBTN
            // 
            this.RealBTN.Location = new System.Drawing.Point(12, 389);
            this.RealBTN.Name = "RealBTN";
            this.RealBTN.Size = new System.Drawing.Size(94, 28);
            this.RealBTN.TabIndex = 51;
            this.RealBTN.Text = "Real";
            this.RealBTN.UseVisualStyleBackColor = true;
            this.RealBTN.Click += new System.EventHandler(this.RealBTN_Click);
            // 
            // FakeBTN
            // 
            this.FakeBTN.Location = new System.Drawing.Point(112, 389);
            this.FakeBTN.Name = "FakeBTN";
            this.FakeBTN.Size = new System.Drawing.Size(89, 29);
            this.FakeBTN.TabIndex = 52;
            this.FakeBTN.Text = "Fake";
            this.FakeBTN.UseVisualStyleBackColor = true;
            this.FakeBTN.Click += new System.EventHandler(this.FakeBTN_Click);
            // 
            // UnknowBTN
            // 
            this.UnknowBTN.Location = new System.Drawing.Point(207, 389);
            this.UnknowBTN.Name = "UnknowBTN";
            this.UnknowBTN.Size = new System.Drawing.Size(93, 28);
            this.UnknowBTN.TabIndex = 53;
            this.UnknowBTN.Text = "Unknow";
            this.UnknowBTN.UseVisualStyleBackColor = true;
            this.UnknowBTN.Click += new System.EventHandler(this.UnknowBTN_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Location = new System.Drawing.Point(138, 173);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(99, 30);
            this.StopBTN.TabIndex = 54;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // ProcessLB
            // 
            this.ProcessLB.Location = new System.Drawing.Point(12, 236);
            this.ProcessLB.Multiline = true;
            this.ProcessLB.Name = "ProcessLB";
            this.ProcessLB.Size = new System.Drawing.Size(469, 114);
            this.ProcessLB.TabIndex = 56;
            // 
            // SleepingNUD
            // 
            this.SleepingNUD.Location = new System.Drawing.Point(361, 180);
            this.SleepingNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SleepingNUD.Name = "SleepingNUD";
            this.SleepingNUD.Size = new System.Drawing.Size(120, 20);
            this.SleepingNUD.TabIndex = 57;
            this.SleepingNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 438);
            this.Controls.Add(this.SleepingNUD);
            this.Controls.Add(this.ProcessLB);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.UnknowBTN);
            this.Controls.Add(this.FakeBTN);
            this.Controls.Add(this.RealBTN);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Gán Nhãn";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SleepingNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox LoginXpathTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox XPassTB;
        private System.Windows.Forms.TextBox XIDTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.TextBox LoginURLTB;
        private System.Windows.Forms.CheckBox LoginCB;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Button RealBTN;
        private System.Windows.Forms.Button FakeBTN;
        private System.Windows.Forms.Button UnknowBTN;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.TextBox ProcessLB;
        private System.Windows.Forms.NumericUpDown SleepingNUD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

