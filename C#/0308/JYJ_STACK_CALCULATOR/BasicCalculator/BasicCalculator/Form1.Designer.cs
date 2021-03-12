namespace BasicCalculator
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TxtCmd = new System.Windows.Forms.TextBox();
            this.GroupBoxNumber = new System.Windows.Forms.GroupBox();
            this.RightParentheses = new System.Windows.Forms.Button();
            this.LeftParentheses = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.BtnCE = new System.Windows.Forms.Button();
            this.GroupBoxNumber.SuspendLayout();
            this.groupBoxOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCmd
            // 
            this.TxtCmd.Location = new System.Drawing.Point(12, 12);
            this.TxtCmd.Multiline = true;
            this.TxtCmd.Name = "TxtCmd";
            this.TxtCmd.ReadOnly = true;
            this.TxtCmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtCmd.Size = new System.Drawing.Size(268, 35);
            this.TxtCmd.TabIndex = 0;
            this.TxtCmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GroupBoxNumber
            // 
            this.GroupBoxNumber.Controls.Add(this.RightParentheses);
            this.GroupBoxNumber.Controls.Add(this.LeftParentheses);
            this.GroupBoxNumber.Controls.Add(this.BtnResult);
            this.GroupBoxNumber.Controls.Add(this.BtnDot);
            this.GroupBoxNumber.Controls.Add(this.Btn0);
            this.GroupBoxNumber.Controls.Add(this.Btn9);
            this.GroupBoxNumber.Controls.Add(this.Btn8);
            this.GroupBoxNumber.Controls.Add(this.Btn7);
            this.GroupBoxNumber.Controls.Add(this.Btn6);
            this.GroupBoxNumber.Controls.Add(this.Btn5);
            this.GroupBoxNumber.Controls.Add(this.Btn4);
            this.GroupBoxNumber.Controls.Add(this.Btn3);
            this.GroupBoxNumber.Controls.Add(this.Btn2);
            this.GroupBoxNumber.Controls.Add(this.Btn1);
            this.GroupBoxNumber.Location = new System.Drawing.Point(12, 56);
            this.GroupBoxNumber.Name = "GroupBoxNumber";
            this.GroupBoxNumber.Size = new System.Drawing.Size(173, 234);
            this.GroupBoxNumber.TabIndex = 1;
            this.GroupBoxNumber.TabStop = false;
            this.GroupBoxNumber.Text = "Numbers";
            // 
            // RightParentheses
            // 
            this.RightParentheses.Location = new System.Drawing.Point(118, 182);
            this.RightParentheses.Name = "RightParentheses";
            this.RightParentheses.Size = new System.Drawing.Size(50, 35);
            this.RightParentheses.TabIndex = 16;
            this.RightParentheses.Text = ")";
            this.RightParentheses.UseVisualStyleBackColor = true;
            this.RightParentheses.Click += new System.EventHandler(this.Parentheses_Click);
            // 
            // LeftParentheses
            // 
            this.LeftParentheses.Location = new System.Drawing.Point(6, 182);
            this.LeftParentheses.Name = "LeftParentheses";
            this.LeftParentheses.Size = new System.Drawing.Size(50, 35);
            this.LeftParentheses.TabIndex = 15;
            this.LeftParentheses.Text = "(";
            this.LeftParentheses.UseVisualStyleBackColor = true;
            this.LeftParentheses.Click += new System.EventHandler(this.Parentheses_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(118, 141);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(50, 35);
            this.BtnResult.TabIndex = 14;
            this.BtnResult.Text = "=";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Location = new System.Drawing.Point(62, 141);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(50, 35);
            this.BtnDot.TabIndex = 13;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(6, 141);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(50, 35);
            this.Btn0.TabIndex = 12;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(118, 100);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(50, 35);
            this.Btn9.TabIndex = 11;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(62, 100);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(50, 35);
            this.Btn8.TabIndex = 10;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(6, 100);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(50, 35);
            this.Btn7.TabIndex = 9;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(118, 59);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(50, 35);
            this.Btn6.TabIndex = 8;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(62, 59);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(50, 35);
            this.Btn5.TabIndex = 7;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(6, 59);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(50, 35);
            this.Btn4.TabIndex = 6;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(118, 20);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(50, 35);
            this.Btn3.TabIndex = 5;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(62, 20);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(50, 35);
            this.Btn2.TabIndex = 4;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(6, 20);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(50, 35);
            this.Btn1.TabIndex = 3;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.BtnDiv);
            this.groupBoxOperation.Controls.Add(this.BtnMul);
            this.groupBoxOperation.Controls.Add(this.BtnSub);
            this.groupBoxOperation.Controls.Add(this.BtnAdd);
            this.groupBoxOperation.Location = new System.Drawing.Point(191, 56);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(89, 234);
            this.groupBoxOperation.TabIndex = 2;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Operations";
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(6, 141);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(75, 35);
            this.BtnDiv.TabIndex = 18;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnSym_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Location = new System.Drawing.Point(6, 100);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(75, 35);
            this.BtnMul.TabIndex = 17;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnSym_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(6, 59);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(75, 35);
            this.BtnSub.TabIndex = 16;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSym_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(6, 20);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 35);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnSym_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.Location = new System.Drawing.Point(74, 238);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(50, 35);
            this.BtnCE.TabIndex = 15;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 297);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.groupBoxOperation);
            this.Controls.Add(this.GroupBoxNumber);
            this.Controls.Add(this.TxtCmd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사칙연산 계산기";
            this.GroupBoxNumber.ResumeLayout(false);
            this.groupBoxOperation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCmd;
        private System.Windows.Forms.GroupBox GroupBoxNumber;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button RightParentheses;
        private System.Windows.Forms.Button LeftParentheses;
    }
}

