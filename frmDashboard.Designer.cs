namespace WinFormProject
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpLotto = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLotto649 = new System.Windows.Forms.Button();
            this.btnLottoMax = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpConv = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTempConv = new System.Windows.Forms.Button();
            this.btnMoneyEx = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnIPVal = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpLotto.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpConv.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(45, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpLotto);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generated Numbers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpLotto
            // 
            this.grpLotto.Controls.Add(this.label2);
            this.grpLotto.Controls.Add(this.label1);
            this.grpLotto.Controls.Add(this.btnLotto649);
            this.grpLotto.Controls.Add(this.btnLottoMax);
            this.grpLotto.Location = new System.Drawing.Point(48, 38);
            this.grpLotto.Name = "grpLotto";
            this.grpLotto.Size = new System.Drawing.Size(522, 353);
            this.grpLotto.TabIndex = 2;
            this.grpLotto.TabStop = false;
            this.grpLotto.Text = "Lotto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lotto649";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lotto Max";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLotto649
            // 
            this.btnLotto649.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLotto649.BackgroundImage")));
            this.btnLotto649.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotto649.Location = new System.Drawing.Point(275, 43);
            this.btnLotto649.Name = "btnLotto649";
            this.btnLotto649.Size = new System.Drawing.Size(205, 251);
            this.btnLotto649.TabIndex = 1;
            this.btnLotto649.UseVisualStyleBackColor = true;
            this.btnLotto649.Click += new System.EventHandler(this.btnLotto649_Click);
            // 
            // btnLottoMax
            // 
            this.btnLottoMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLottoMax.BackgroundImage")));
            this.btnLottoMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLottoMax.Location = new System.Drawing.Point(37, 43);
            this.btnLottoMax.Name = "btnLottoMax";
            this.btnLottoMax.Size = new System.Drawing.Size(203, 252);
            this.btnLottoMax.TabIndex = 0;
            this.btnLottoMax.UseVisualStyleBackColor = true;
            this.btnLottoMax.Click += new System.EventHandler(this.btnLottoMax_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpConv);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpConv
            // 
            this.grpConv.Controls.Add(this.label3);
            this.grpConv.Controls.Add(this.label4);
            this.grpConv.Controls.Add(this.btnTempConv);
            this.grpConv.Controls.Add(this.btnMoneyEx);
            this.grpConv.Location = new System.Drawing.Point(46, 48);
            this.grpConv.Name = "grpConv";
            this.grpConv.Size = new System.Drawing.Size(522, 353);
            this.grpConv.TabIndex = 3;
            this.grpConv.TabStop = false;
            this.grpConv.Text = "Conversions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperature Convert";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Money Exchange";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTempConv
            // 
            this.btnTempConv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTempConv.BackgroundImage")));
            this.btnTempConv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTempConv.Location = new System.Drawing.Point(275, 43);
            this.btnTempConv.Name = "btnTempConv";
            this.btnTempConv.Size = new System.Drawing.Size(205, 251);
            this.btnTempConv.TabIndex = 1;
            this.btnTempConv.UseVisualStyleBackColor = true;
            this.btnTempConv.Click += new System.EventHandler(this.btnTempConv_Click);
            // 
            // btnMoneyEx
            // 
            this.btnMoneyEx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoneyEx.BackgroundImage")));
            this.btnMoneyEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoneyEx.Location = new System.Drawing.Point(37, 43);
            this.btnMoneyEx.Name = "btnMoneyEx";
            this.btnMoneyEx.Size = new System.Drawing.Size(203, 252);
            this.btnMoneyEx.TabIndex = 0;
            this.btnMoneyEx.UseVisualStyleBackColor = true;
            this.btnMoneyEx.Click += new System.EventHandler(this.btnMoneyEx_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCalc);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(614, 449);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simple Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalc.BackgroundImage")));
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalc.Location = new System.Drawing.Point(199, 86);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(205, 251);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnIPVal);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(614, 449);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IPv4 Validator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnIPVal
            // 
            this.btnIPVal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIPVal.BackgroundImage")));
            this.btnIPVal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIPVal.Location = new System.Drawing.Point(205, 99);
            this.btnIPVal.Name = "btnIPVal";
            this.btnIPVal.Size = new System.Drawing.Size(205, 251);
            this.btnIPVal.TabIndex = 2;
            this.btnIPVal.UseVisualStyleBackColor = true;
            this.btnIPVal.Click += new System.EventHandler(this.btnIPVal_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.Location = new System.Drawing.Point(538, 543);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(125, 40);
            this.btnMainExit.TabIndex = 1;
            this.btnMainExit.Text = "E&xit";
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 619);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDashboard";
            this.Text = " ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpLotto.ResumeLayout(false);
            this.grpLotto.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpConv.ResumeLayout(false);
            this.grpConv.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnLotto649;
        private System.Windows.Forms.Button btnLottoMax;
        private System.Windows.Forms.GroupBox grpLotto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMainExit;
        private System.Windows.Forms.GroupBox grpConv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTempConv;
        private System.Windows.Forms.Button btnMoneyEx;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnIPVal;
    }
}

