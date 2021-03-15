
namespace DynamicButton
{
    partial class StopWatch
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
            this.Start = new System.Windows.Forms.Button();
            this.Hour = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Start.Location = new System.Drawing.Point(52, 101);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(74, 42);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hour.Location = new System.Drawing.Point(13, 9);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(80, 65);
            this.Hour.TabIndex = 1;
            this.Hour.Text = "00";
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minute.Location = new System.Drawing.Point(132, 9);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(80, 65);
            this.Minute.TabIndex = 2;
            this.Minute.Text = "00";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Second.Location = new System.Drawing.Point(251, 9);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(80, 65);
            this.Second.TabIndex = 3;
            this.Second.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(93, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 65);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(212, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 65);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stop.Location = new System.Drawing.Point(132, 101);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(74, 42);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reset.Location = new System.Drawing.Point(212, 101);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(74, 42);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 162);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.Start);
            this.Name = "StopWatch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer timer1;
    }
}

