namespace FakeAccountPrediction
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
            this.TrainingBTN = new System.Windows.Forms.Button();
            this.FBLoginGB = new System.Windows.Forms.GroupBox();
            this.LoginXpathTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SleepingNUD = new System.Windows.Forms.NumericUpDown();
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
            this.ProcessLB = new System.Windows.Forms.TextBox();
            this.TraningExamplesPathTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AccountPredictionTB = new System.Windows.Forms.TextBox();
            this.PredictBTN = new System.Windows.Forms.Button();
            this.FBLoginGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SleepingNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainingBTN
            // 
            this.TrainingBTN.Location = new System.Drawing.Point(379, 40);
            this.TrainingBTN.Name = "TrainingBTN";
            this.TrainingBTN.Size = new System.Drawing.Size(109, 29);
            this.TrainingBTN.TabIndex = 0;
            this.TrainingBTN.Text = "Training";
            this.TrainingBTN.UseVisualStyleBackColor = true;
            this.TrainingBTN.Click += new System.EventHandler(this.TrainingBTN_Click);
            // 
            // FBLoginGB
            // 
            this.FBLoginGB.Controls.Add(this.LoginXpathTB);
            this.FBLoginGB.Controls.Add(this.label7);
            this.FBLoginGB.Controls.Add(this.SleepingNUD);
            this.FBLoginGB.Controls.Add(this.label5);
            this.FBLoginGB.Controls.Add(this.label4);
            this.FBLoginGB.Controls.Add(this.label3);
            this.FBLoginGB.Controls.Add(this.label2);
            this.FBLoginGB.Controls.Add(this.label1);
            this.FBLoginGB.Controls.Add(this.XPassTB);
            this.FBLoginGB.Controls.Add(this.XIDTB);
            this.FBLoginGB.Controls.Add(this.PassTB);
            this.FBLoginGB.Controls.Add(this.IDTB);
            this.FBLoginGB.Controls.Add(this.LoginURLTB);
            this.FBLoginGB.Location = new System.Drawing.Point(12, 276);
            this.FBLoginGB.Name = "FBLoginGB";
            this.FBLoginGB.Size = new System.Drawing.Size(486, 181);
            this.FBLoginGB.TabIndex = 47;
            this.FBLoginGB.TabStop = false;
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
            // SleepingNUD
            // 
            this.SleepingNUD.Location = new System.Drawing.Point(347, 155);
            this.SleepingNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SleepingNUD.Name = "SleepingNUD";
            this.SleepingNUD.Size = new System.Drawing.Size(120, 20);
            this.SleepingNUD.TabIndex = 58;
            this.SleepingNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            this.XPassTB.Text = "//input[@id=\'pass\']";
            // 
            // XIDTB
            // 
            this.XIDTB.Location = new System.Drawing.Point(289, 56);
            this.XIDTB.Name = "XIDTB";
            this.XIDTB.Size = new System.Drawing.Size(187, 20);
            this.XIDTB.TabIndex = 22;
            this.XIDTB.Text = "//input[@id=\'email\']";
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
            this.LoginCB.Location = new System.Drawing.Point(12, 253);
            this.LoginCB.Name = "LoginCB";
            this.LoginCB.Size = new System.Drawing.Size(103, 17);
            this.LoginCB.TabIndex = 18;
            this.LoginCB.Text = "Facebook Login";
            this.LoginCB.UseVisualStyleBackColor = true;
            this.LoginCB.CheckStateChanged += new System.EventHandler(this.LoginCB_CheckStateChanged);
            // 
            // ProcessLB
            // 
            this.ProcessLB.Location = new System.Drawing.Point(19, 84);
            this.ProcessLB.Multiline = true;
            this.ProcessLB.Name = "ProcessLB";
            this.ProcessLB.Size = new System.Drawing.Size(469, 88);
            this.ProcessLB.TabIndex = 59;
            // 
            // TraningExamplesPathTB
            // 
            this.TraningExamplesPathTB.Location = new System.Drawing.Point(19, 45);
            this.TraningExamplesPathTB.Name = "TraningExamplesPathTB";
            this.TraningExamplesPathTB.Size = new System.Drawing.Size(342, 20);
            this.TraningExamplesPathTB.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Log";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Traning Examples Path";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Account Prediction";
            // 
            // AccountPredictionTB
            // 
            this.AccountPredictionTB.Location = new System.Drawing.Point(19, 212);
            this.AccountPredictionTB.Name = "AccountPredictionTB";
            this.AccountPredictionTB.Size = new System.Drawing.Size(342, 20);
            this.AccountPredictionTB.TabIndex = 64;
            // 
            // PredictBTN
            // 
            this.PredictBTN.Location = new System.Drawing.Point(379, 207);
            this.PredictBTN.Name = "PredictBTN";
            this.PredictBTN.Size = new System.Drawing.Size(109, 29);
            this.PredictBTN.TabIndex = 63;
            this.PredictBTN.Text = "Predict";
            this.PredictBTN.UseVisualStyleBackColor = true;
            this.PredictBTN.Click += new System.EventHandler(this.PredictBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 469);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AccountPredictionTB);
            this.Controls.Add(this.PredictBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TraningExamplesPathTB);
            this.Controls.Add(this.ProcessLB);
            this.Controls.Add(this.FBLoginGB);
            this.Controls.Add(this.TrainingBTN);
            this.Controls.Add(this.LoginCB);
            this.Name = "Form1";
            this.Text = "Dự đoán";
            this.FBLoginGB.ResumeLayout(false);
            this.FBLoginGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SleepingNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrainingBTN;
        private System.Windows.Forms.GroupBox FBLoginGB;
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
        private System.Windows.Forms.NumericUpDown SleepingNUD;
        private System.Windows.Forms.TextBox ProcessLB;
        private System.Windows.Forms.TextBox TraningExamplesPathTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AccountPredictionTB;
        private System.Windows.Forms.Button PredictBTN;
    }
}

