
namespace StopWatchApp
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
            this.components = new System.ComponentModel.Container();
            this.Hour = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Font = new System.Drawing.Font("나눔고딕코딩", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hour.Location = new System.Drawing.Point(44, 75);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(47, 32);
            this.Hour.TabIndex = 0;
            this.Hour.Text = "00";
            this.Hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.Font = new System.Drawing.Font("나눔고딕코딩", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minute.Location = new System.Drawing.Point(168, 75);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(47, 32);
            this.Minute.TabIndex = 1;
            this.Minute.Text = "00";
            this.Minute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Font = new System.Drawing.Font("나눔고딕코딩", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Second.Location = new System.Drawing.Point(299, 75);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(47, 32);
            this.Second.TabIndex = 2;
            this.Second.Text = "00";
            this.Second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕코딩", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(113, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕코딩", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(243, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(60, 154);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 55);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(151, 154);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 55);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(242, 154);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 55);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 259);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.Hour);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer timer1;
    }
}

