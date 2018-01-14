namespace GetIdFB
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
            this.GetIDBTN = new System.Windows.Forms.Button();
            this.MaxThreadNUD = new System.Windows.Forms.NumericUpDown();
            this.ProcessLB = new System.Windows.Forms.Label();
            this.StopBTN = new System.Windows.Forms.Button();
            this.InputRTB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaxThreadNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // GetIDBTN
            // 
            this.GetIDBTN.Location = new System.Drawing.Point(15, 209);
            this.GetIDBTN.Name = "GetIDBTN";
            this.GetIDBTN.Size = new System.Drawing.Size(91, 28);
            this.GetIDBTN.TabIndex = 0;
            this.GetIDBTN.Text = "GetID";
            this.GetIDBTN.UseVisualStyleBackColor = true;
            this.GetIDBTN.Click += new System.EventHandler(this.GetIDBTN_Click);
            // 
            // MaxThreadNUD
            // 
            this.MaxThreadNUD.Location = new System.Drawing.Point(15, 183);
            this.MaxThreadNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxThreadNUD.Name = "MaxThreadNUD";
            this.MaxThreadNUD.Size = new System.Drawing.Size(91, 20);
            this.MaxThreadNUD.TabIndex = 2;
            this.MaxThreadNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ProcessLB
            // 
            this.ProcessLB.AutoSize = true;
            this.ProcessLB.Location = new System.Drawing.Point(192, 180);
            this.ProcessLB.Name = "ProcessLB";
            this.ProcessLB.Size = new System.Drawing.Size(13, 13);
            this.ProcessLB.TabIndex = 3;
            this.ProcessLB.Text = "0";
            // 
            // StopBTN
            // 
            this.StopBTN.Location = new System.Drawing.Point(195, 209);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(77, 28);
            this.StopBTN.TabIndex = 4;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // InputRTB
            // 
            this.InputRTB.Location = new System.Drawing.Point(15, 12);
            this.InputRTB.Name = "InputRTB";
            this.InputRTB.Size = new System.Drawing.Size(257, 165);
            this.InputRTB.TabIndex = 5;
            this.InputRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.InputRTB);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.ProcessLB);
            this.Controls.Add(this.MaxThreadNUD);
            this.Controls.Add(this.GetIDBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MaxThreadNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetIDBTN;
        private System.Windows.Forms.NumericUpDown MaxThreadNUD;
        private System.Windows.Forms.Label ProcessLB;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.RichTextBox InputRTB;
    }
}

