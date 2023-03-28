namespace WinFormProject
{
    partial class frmIPv4Validator
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
            this.lblIPValDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPVal = new System.Windows.Forms.TextBox();
            this.btnIPValExit = new System.Windows.Forms.Button();
            this.btnIPValReset = new System.Windows.Forms.Button();
            this.btnIPVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today:";
            // 
            // lblIPValDate
            // 
            this.lblIPValDate.AutoSize = true;
            this.lblIPValDate.Location = new System.Drawing.Point(260, 36);
            this.lblIPValDate.Name = "lblIPValDate";
            this.lblIPValDate.Size = new System.Drawing.Size(97, 20);
            this.lblIPValDate.TabIndex = 1;
            this.lblIPValDate.Text = "CurrentDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter IP address:";
            // 
            // txtIPVal
            // 
            this.txtIPVal.Location = new System.Drawing.Point(210, 103);
            this.txtIPVal.Name = "txtIPVal";
            this.txtIPVal.Size = new System.Drawing.Size(273, 26);
            this.txtIPVal.TabIndex = 1;
            // 
            // btnIPValExit
            // 
            this.btnIPValExit.Location = new System.Drawing.Point(395, 177);
            this.btnIPValExit.Name = "btnIPValExit";
            this.btnIPValExit.Size = new System.Drawing.Size(118, 46);
            this.btnIPValExit.TabIndex = 4;
            this.btnIPValExit.Text = "E&xit";
            this.btnIPValExit.UseVisualStyleBackColor = true;
            this.btnIPValExit.Click += new System.EventHandler(this.btnIPValExit_Click);
            // 
            // btnIPValReset
            // 
            this.btnIPValReset.Location = new System.Drawing.Point(218, 180);
            this.btnIPValReset.Name = "btnIPValReset";
            this.btnIPValReset.Size = new System.Drawing.Size(118, 43);
            this.btnIPValReset.TabIndex = 3;
            this.btnIPValReset.Text = "&Reset";
            this.btnIPValReset.UseVisualStyleBackColor = true;
            this.btnIPValReset.Click += new System.EventHandler(this.btnIPValReset_Click);
            // 
            // btnIPVal
            // 
            this.btnIPVal.Location = new System.Drawing.Point(44, 179);
            this.btnIPVal.Name = "btnIPVal";
            this.btnIPVal.Size = new System.Drawing.Size(118, 43);
            this.btnIPVal.TabIndex = 2;
            this.btnIPVal.Text = "&Validate IP";
            this.btnIPVal.UseVisualStyleBackColor = true;
            this.btnIPVal.Click += new System.EventHandler(this.btnIPVal_Click);
            // 
            // frmIPv4Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 266);
            this.Controls.Add(this.btnIPValExit);
            this.Controls.Add(this.btnIPValReset);
            this.Controls.Add(this.btnIPVal);
            this.Controls.Add(this.txtIPVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIPValDate);
            this.Controls.Add(this.label1);
            this.Name = "frmIPv4Validator";
            this.Text = "IPv4 Validator - Bernadette";
            this.Load += new System.EventHandler(this.frmIPv4Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIPValDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPVal;
        private System.Windows.Forms.Button btnIPValExit;
        private System.Windows.Forms.Button btnIPValReset;
        private System.Windows.Forms.Button btnIPVal;
    }
}