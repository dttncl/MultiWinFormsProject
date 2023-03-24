namespace WinFormProject
{
    partial class frmTempConv
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
            this.optCtoF = new System.Windows.Forms.RadioButton();
            this.optFtoC = new System.Windows.Forms.RadioButton();
            this.txtTempFrom = new System.Windows.Forms.TextBox();
            this.txtTempTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtfTempDesc = new System.Windows.Forms.RichTextBox();
            this.btnTConvExit = new System.Windows.Forms.Button();
            this.btnTConvRead = new System.Windows.Forms.Button();
            this.btnTConv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optCtoF
            // 
            this.optCtoF.AutoSize = true;
            this.optCtoF.Location = new System.Drawing.Point(210, 59);
            this.optCtoF.Name = "optCtoF";
            this.optCtoF.Size = new System.Drawing.Size(113, 24);
            this.optCtoF.TabIndex = 0;
            this.optCtoF.TabStop = true;
            this.optCtoF.Text = "from C to F";
            this.optCtoF.UseVisualStyleBackColor = true;
            this.optCtoF.CheckedChanged += new System.EventHandler(this.optCtoF_CheckedChanged);
            // 
            // optFtoC
            // 
            this.optFtoC.AutoSize = true;
            this.optFtoC.Location = new System.Drawing.Point(210, 107);
            this.optFtoC.Name = "optFtoC";
            this.optFtoC.Size = new System.Drawing.Size(113, 24);
            this.optFtoC.TabIndex = 1;
            this.optFtoC.TabStop = true;
            this.optFtoC.Text = "from F to C";
            this.optFtoC.UseVisualStyleBackColor = true;
            this.optFtoC.CheckedChanged += new System.EventHandler(this.optFtoC_CheckedChanged);
            // 
            // txtTempFrom
            // 
            this.txtTempFrom.Location = new System.Drawing.Point(56, 170);
            this.txtTempFrom.Name = "txtTempFrom";
            this.txtTempFrom.Size = new System.Drawing.Size(177, 26);
            this.txtTempFrom.TabIndex = 2;
            // 
            // txtTempTo
            // 
            this.txtTempTo.Location = new System.Drawing.Point(308, 170);
            this.txtTempTo.Name = "txtTempTo";
            this.txtTempTo.ReadOnly = true;
            this.txtTempTo.Size = new System.Drawing.Size(177, 26);
            this.txtTempTo.TabIndex = 3;
            this.txtTempTo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(120, 208);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(31, 29);
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "C";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(373, 208);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 29);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // rtfTempDesc
            // 
            this.rtfTempDesc.Location = new System.Drawing.Point(56, 311);
            this.rtfTempDesc.Name = "rtfTempDesc";
            this.rtfTempDesc.ReadOnly = true;
            this.rtfTempDesc.Size = new System.Drawing.Size(429, 84);
            this.rtfTempDesc.TabIndex = 9;
            this.rtfTempDesc.TabStop = false;
            this.rtfTempDesc.Text = "";
            // 
            // btnTConvExit
            // 
            this.btnTConvExit.Location = new System.Drawing.Point(387, 421);
            this.btnTConvExit.Name = "btnTConvExit";
            this.btnTConvExit.Size = new System.Drawing.Size(118, 46);
            this.btnTConvExit.TabIndex = 5;
            this.btnTConvExit.Text = "E&xit";
            this.btnTConvExit.UseVisualStyleBackColor = true;
            this.btnTConvExit.Click += new System.EventHandler(this.btnTConvExit_Click);
            // 
            // btnTConvRead
            // 
            this.btnTConvRead.Location = new System.Drawing.Point(210, 424);
            this.btnTConvRead.Name = "btnTConvRead";
            this.btnTConvRead.Size = new System.Drawing.Size(118, 43);
            this.btnTConvRead.TabIndex = 4;
            this.btnTConvRead.Text = "&Read File";
            this.btnTConvRead.UseVisualStyleBackColor = true;
            this.btnTConvRead.Click += new System.EventHandler(this.btnTConvRead_Click);
            // 
            // btnTConv
            // 
            this.btnTConv.Location = new System.Drawing.Point(36, 423);
            this.btnTConv.Name = "btnTConv";
            this.btnTConv.Size = new System.Drawing.Size(118, 43);
            this.btnTConv.TabIndex = 3;
            this.btnTConv.Text = "&Convert";
            this.btnTConv.UseVisualStyleBackColor = true;
            this.btnTConv.Click += new System.EventHandler(this.btnTConv_Click);
            // 
            // frmTempConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 539);
            this.Controls.Add(this.btnTConvExit);
            this.Controls.Add(this.btnTConvRead);
            this.Controls.Add(this.btnTConv);
            this.Controls.Add(this.rtfTempDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempTo);
            this.Controls.Add(this.txtTempFrom);
            this.Controls.Add(this.optFtoC);
            this.Controls.Add(this.optCtoF);
            this.Name = "frmTempConv";
            this.Text = "Temp Converter - Bernadette";
            this.Load += new System.EventHandler(this.frmTempConv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optCtoF;
        private System.Windows.Forms.RadioButton optFtoC;
        private System.Windows.Forms.TextBox txtTempFrom;
        private System.Windows.Forms.TextBox txtTempTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtfTempDesc;
        private System.Windows.Forms.Button btnTConvExit;
        private System.Windows.Forms.Button btnTConvRead;
        private System.Windows.Forms.Button btnTConv;
    }
}