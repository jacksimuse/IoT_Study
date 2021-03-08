
namespace sumin_calculator
{
    partial class MainForm
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
            this.TxtNum = new System.Windows.Forms.Label();
            this.TxtNum2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum3 = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMutp = new System.Windows.Forms.Button();
            this.Btnsub = new System.Windows.Forms.Button();
            this.BtnDivi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNum
            // 
            this.TxtNum.AutoSize = true;
            this.TxtNum.Location = new System.Drawing.Point(29, 35);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(49, 20);
            this.TxtNum.TabIndex = 0;
            this.TxtNum.Text = "Num1";
            // 
            // TxtNum2
            // 
            this.TxtNum2.AutoSize = true;
            this.TxtNum2.Location = new System.Drawing.Point(29, 87);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(49, 20);
            this.TxtNum2.TabIndex = 1;
            this.TxtNum2.Text = "Num2";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(29, 141);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(69, 20);
            this.Result.TabIndex = 2;
            this.Result.Text = "Result";
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(119, 33);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(226, 27);
            this.TxtNum1.TabIndex = 3;
            // 
            // TxtNum3
            // 
            this.TxtNum3.Location = new System.Drawing.Point(119, 87);
            this.TxtNum3.Name = "TxtNum3";
            this.TxtNum3.Size = new System.Drawing.Size(226, 27);
            this.TxtNum3.TabIndex = 4;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(119, 134);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(379, 27);
            this.TxtResult.TabIndex = 5;
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(361, 28);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(53, 34);
            this.BtnPlus.TabIndex = 6;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnMutp
            // 
            this.BtnMutp.Location = new System.Drawing.Point(361, 83);
            this.BtnMutp.Name = "BtnMutp";
            this.BtnMutp.Size = new System.Drawing.Size(53, 34);
            this.BtnMutp.TabIndex = 7;
            this.BtnMutp.Text = "*";
            this.BtnMutp.UseVisualStyleBackColor = true;
            this.BtnMutp.Click += new System.EventHandler(this.BtnMutp_Click);
            // 
            // Btnsub
            // 
            this.Btnsub.Location = new System.Drawing.Point(445, 29);
            this.Btnsub.Name = "Btnsub";
            this.Btnsub.Size = new System.Drawing.Size(53, 34);
            this.Btnsub.TabIndex = 8;
            this.Btnsub.Text = "-";
            this.Btnsub.UseVisualStyleBackColor = true;
            this.Btnsub.Click += new System.EventHandler(this.Btnsub_Click);
            // 
            // BtnDivi
            // 
            this.BtnDivi.Location = new System.Drawing.Point(445, 83);
            this.BtnDivi.Name = "BtnDivi";
            this.BtnDivi.Size = new System.Drawing.Size(53, 34);
            this.BtnDivi.TabIndex = 9;
            this.BtnDivi.Text = "/";
            this.BtnDivi.UseVisualStyleBackColor = true;
            this.BtnDivi.Click += new System.EventHandler(this.BtnDivi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 194);
            this.Controls.Add(this.BtnDivi);
            this.Controls.Add(this.Btnsub);
            this.Controls.Add(this.BtnMutp);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtNum3);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtNum;
        private System.Windows.Forms.Label TxtNum2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum3;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMutp;
        private System.Windows.Forms.Button Btnsub;
        private System.Windows.Forms.Button BtnDivi;
    }
}

