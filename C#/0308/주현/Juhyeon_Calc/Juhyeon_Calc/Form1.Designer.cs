
namespace Juhyeon_Calc
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
            this.Plus = new System.Windows.Forms.Button();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.Minus = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(230, 10);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(34, 23);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(80, 12);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(135, 21);
            this.TxtNum1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(80, 42);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(135, 21);
            this.TxtNum2.TabIndex = 5;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(80, 82);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(240, 21);
            this.TxtResult.TabIndex = 6;
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(286, 10);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(34, 23);
            this.Minus.TabIndex = 7;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(286, 40);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(34, 23);
            this.Divide.TabIndex = 9;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiple
            // 
            this.Multiple.Location = new System.Drawing.Point(230, 40);
            this.Multiple.Name = "Multiple";
            this.Multiple.Size = new System.Drawing.Size(34, 23);
            this.Multiple.TabIndex = 8;
            this.Multiple.Text = "*";
            this.Multiple.UseVisualStyleBackColor = true;
            this.Multiple.Click += new System.EventHandler(this.Multiple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 128);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiple);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.Plus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiple;
    }
}

