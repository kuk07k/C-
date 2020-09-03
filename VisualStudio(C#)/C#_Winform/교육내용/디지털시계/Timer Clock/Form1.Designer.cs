namespace Timer_Clock
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DisM = new System.Windows.Forms.Label();
            this.DisS = new System.Windows.Forms.Label();
            this.DisMS = new System.Windows.Forms.Label();
            this.UnitM = new System.Windows.Forms.Label();
            this.UnitS = new System.Windows.Forms.Label();
            this.UnitMS = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DisM
            // 
            this.DisM.AutoSize = true;
            this.DisM.Font = new System.Drawing.Font("나눔고딕코딩", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DisM.Location = new System.Drawing.Point(58, 47);
            this.DisM.Name = "DisM";
            this.DisM.Size = new System.Drawing.Size(44, 48);
            this.DisM.TabIndex = 0;
            this.DisM.Text = "0";
            // 
            // DisS
            // 
            this.DisS.AutoSize = true;
            this.DisS.Font = new System.Drawing.Font("나눔고딕코딩", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DisS.Location = new System.Drawing.Point(58, 95);
            this.DisS.Name = "DisS";
            this.DisS.Size = new System.Drawing.Size(44, 48);
            this.DisS.TabIndex = 0;
            this.DisS.Text = "0";
            // 
            // DisMS
            // 
            this.DisMS.AutoSize = true;
            this.DisMS.Font = new System.Drawing.Font("나눔고딕코딩", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DisMS.Location = new System.Drawing.Point(58, 143);
            this.DisMS.Name = "DisMS";
            this.DisMS.Size = new System.Drawing.Size(44, 48);
            this.DisMS.TabIndex = 0;
            this.DisMS.Text = "0";
            // 
            // UnitM
            // 
            this.UnitM.AutoSize = true;
            this.UnitM.Font = new System.Drawing.Font("나눔고딕코딩", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UnitM.Location = new System.Drawing.Point(211, 47);
            this.UnitM.Name = "UnitM";
            this.UnitM.Size = new System.Drawing.Size(68, 48);
            this.UnitM.TabIndex = 0;
            this.UnitM.Text = "분";
            // 
            // UnitS
            // 
            this.UnitS.AutoSize = true;
            this.UnitS.Font = new System.Drawing.Font("나눔고딕코딩", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UnitS.Location = new System.Drawing.Point(211, 95);
            this.UnitS.Name = "UnitS";
            this.UnitS.Size = new System.Drawing.Size(68, 48);
            this.UnitS.TabIndex = 0;
            this.UnitS.Text = "초";
            // 
            // UnitMS
            // 
            this.UnitMS.AutoSize = true;
            this.UnitMS.Font = new System.Drawing.Font("나눔고딕코딩", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UnitMS.Location = new System.Drawing.Point(211, 143);
            this.UnitMS.Name = "UnitMS";
            this.UnitMS.Size = new System.Drawing.Size(164, 48);
            this.UnitMS.TabIndex = 0;
            this.UnitMS.Text = "밀리초";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(271, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start / Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(271, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 298);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisMS);
            this.Controls.Add(this.DisS);
            this.Controls.Add(this.UnitMS);
            this.Controls.Add(this.UnitS);
            this.Controls.Add(this.UnitM);
            this.Controls.Add(this.DisM);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "디지털 시계";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DisM;
        private System.Windows.Forms.Label DisS;
        private System.Windows.Forms.Label DisMS;
        private System.Windows.Forms.Label UnitM;
        private System.Windows.Forms.Label UnitS;
        private System.Windows.Forms.Label UnitMS;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

