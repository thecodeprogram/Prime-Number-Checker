namespace Asalci
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrimeNumberCounter = new System.Windows.Forms.Label();
            this.lblChecked = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThreadsNeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThreadCheckBetween = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBitir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrimeState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime numbers on DB";
            // 
            // lblPrimeNumberCounter
            // 
            this.lblPrimeNumberCounter.AutoSize = true;
            this.lblPrimeNumberCounter.Location = new System.Drawing.Point(140, 13);
            this.lblPrimeNumberCounter.Name = "lblPrimeNumberCounter";
            this.lblPrimeNumberCounter.Size = new System.Drawing.Size(13, 13);
            this.lblPrimeNumberCounter.TabIndex = 1;
            this.lblPrimeNumberCounter.Text = "0";
            // 
            // lblChecked
            // 
            this.lblChecked.AutoSize = true;
            this.lblChecked.Location = new System.Drawing.Point(140, 36);
            this.lblChecked.Name = "lblChecked";
            this.lblChecked.Size = new System.Drawing.Size(13, 13);
            this.lblChecked.TabIndex = 3;
            this.lblChecked.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Checked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Threads Need";
            // 
            // lblThreadsNeed
            // 
            this.lblThreadsNeed.AutoSize = true;
            this.lblThreadsNeed.Location = new System.Drawing.Point(140, 58);
            this.lblThreadsNeed.Name = "lblThreadsNeed";
            this.lblThreadsNeed.Size = new System.Drawing.Size(13, 13);
            this.lblThreadsNeed.TabIndex = 5;
            this.lblThreadsNeed.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thread Check Between";
            // 
            // lblThreadCheckBetween
            // 
            this.lblThreadCheckBetween.AutoSize = true;
            this.lblThreadCheckBetween.Location = new System.Drawing.Point(140, 82);
            this.lblThreadCheckBetween.Name = "lblThreadCheckBetween";
            this.lblThreadCheckBetween.Size = new System.Drawing.Size(13, 13);
            this.lblThreadCheckBetween.TabIndex = 7;
            this.lblThreadCheckBetween.Text = "0";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(247, 13);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(242, 381);
            this.txtLog.TabIndex = 8;
            this.txtLog.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Max Value";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(140, 109);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(13, 13);
            this.lblMaxValue.TabIndex = 10;
            this.lblMaxValue.Text = "0";
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(16, 201);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(137, 35);
            this.btnKontrol.TabIndex = 11;
            this.btnKontrol.Text = "Start Program";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(16, 242);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(137, 35);
            this.btnBitir.TabIndex = 12;
            this.btnBitir.Text = "Stop Program";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prime Statu";
            // 
            // lblPrimeState
            // 
            this.lblPrimeState.AutoSize = true;
            this.lblPrimeState.Location = new System.Drawing.Point(140, 132);
            this.lblPrimeState.Name = "lblPrimeState";
            this.lblPrimeState.Size = new System.Drawing.Size(13, 13);
            this.lblPrimeState.TabIndex = 14;
            this.lblPrimeState.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 406);
            this.Controls.Add(this.lblPrimeState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblThreadCheckBetween);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblThreadsNeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblChecked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrimeNumberCounter);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrimeNumberCounter;
        private System.Windows.Forms.Label lblChecked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThreadsNeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThreadCheckBetween;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Button btnKontrol;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrimeState;
    }
}

