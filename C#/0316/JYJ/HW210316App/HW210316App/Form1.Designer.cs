namespace HW210316App
{
    partial class Form1
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
            this.BtnBefore = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnMove = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // BtnBefore
            // 
            this.BtnBefore.Location = new System.Drawing.Point(12, 12);
            this.BtnBefore.Name = "BtnBefore";
            this.BtnBefore.Size = new System.Drawing.Size(63, 21);
            this.BtnBefore.TabIndex = 0;
            this.BtnBefore.Text = "이 전";
            this.BtnBefore.UseVisualStyleBackColor = true;
            this.BtnBefore.Click += new System.EventHandler(this.BtnBefore_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(81, 12);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(63, 21);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "다 음";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // BtnMove
            // 
            this.BtnMove.Location = new System.Drawing.Point(508, 12);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(44, 21);
            this.BtnMove.TabIndex = 3;
            this.BtnMove.Text = "이동";
            this.BtnMove.UseVisualStyleBackColor = true;
            this.BtnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(540, 276);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(565, 327);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BtnMove);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnBefore);
            this.Name = "Form1";
            this.Text = "미니 웹 브라우저";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBefore;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnMove;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

