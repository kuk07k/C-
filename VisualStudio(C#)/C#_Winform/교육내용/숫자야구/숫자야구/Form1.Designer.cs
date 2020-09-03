namespace 숫자야구
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
            this.button1 = new System.Windows.Forms.Button();
            this.rd1 = new System.Windows.Forms.Label();
            this.rd2 = new System.Windows.Forms.Label();
            this.rd3 = new System.Windows.Forms.Label();
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.tbInput3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbStrike = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbBall = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(376, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rd1.Location = new System.Drawing.Point(137, 170);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(18, 19);
            this.rd1.TabIndex = 1;
            this.rd1.Text = "?";
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rd2.Location = new System.Drawing.Point(212, 170);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(18, 19);
            this.rd2.TabIndex = 1;
            this.rd2.Text = "?";
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rd3.Location = new System.Drawing.Point(287, 170);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(18, 19);
            this.rd3.TabIndex = 1;
            this.rd3.Text = "?";
            // 
            // tbInput1
            // 
            this.tbInput1.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbInput1.Location = new System.Drawing.Point(110, 204);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(70, 25);
            this.tbInput1.TabIndex = 2;
            this.tbInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInput2
            // 
            this.tbInput2.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbInput2.Location = new System.Drawing.Point(186, 204);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(69, 25);
            this.tbInput2.TabIndex = 2;
            this.tbInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInput3
            // 
            this.tbInput3.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbInput3.Location = new System.Drawing.Point(261, 204);
            this.tbInput3.Name = "tbInput3";
            this.tbInput3.Size = new System.Drawing.Size(69, 25);
            this.tbInput3.TabIndex = 2;
            this.tbInput3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(38, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "정답";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(38, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "입력";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Count.Location = new System.Drawing.Point(36, 97);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(63, 19);
            this.Count.TabIndex = 1;
            this.Count.Text = "카운트";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCount.Location = new System.Drawing.Point(121, 97);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(18, 19);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(16, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "스트라이크";
            // 
            // lbStrike
            // 
            this.lbStrike.AutoSize = true;
            this.lbStrike.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbStrike.Location = new System.Drawing.Point(121, 36);
            this.lbStrike.Name = "lbStrike";
            this.lbStrike.Size = new System.Drawing.Size(18, 19);
            this.lbStrike.TabIndex = 1;
            this.lbStrike.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(54, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "볼";
            // 
            // lbBall
            // 
            this.lbBall.AutoSize = true;
            this.lbBall.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBall.Location = new System.Drawing.Point(121, 67);
            this.lbBall.Name = "lbBall";
            this.lbBall.Size = new System.Drawing.Size(18, 19);
            this.lbBall.TabIndex = 1;
            this.lbBall.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(102, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 45);
            this.label12.TabIndex = 1;
            this.label12.Text = "숫 자 야 구";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbStrike);
            this.groupBox1.Controls.Add(this.lbBall);
            this.groupBox1.Controls.Add(this.Count);
            this.groupBox1.Controls.Add(this.lbCount);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕코딩", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(376, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "투구현황";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(376, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "재시작";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 270);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbInput3);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.tbInput1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rd3);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "숫자야구";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label rd1;
        private System.Windows.Forms.Label rd2;
        private System.Windows.Forms.Label rd3;
        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.TextBox tbInput3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbStrike;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbBall;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}

