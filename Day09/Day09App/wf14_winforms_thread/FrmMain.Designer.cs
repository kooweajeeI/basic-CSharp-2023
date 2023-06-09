﻿namespace wf14_winforms_thread
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.PgbCalculate = new System.Windows.Forms.ProgressBar();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력(수)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "결과";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(97, 116);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(14, 14);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "0";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(328, 29);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "시작";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(409, 29);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(104, 26);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(100, 21);
            this.TxtNumber.TabIndex = 5;
            this.TxtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNumber.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            // 
            // PgbCalculate
            // 
            this.PgbCalculate.Location = new System.Drawing.Point(53, 77);
            this.PgbCalculate.Name = "PgbCalculate";
            this.PgbCalculate.Size = new System.Drawing.Size(431, 23);
            this.PgbCalculate.TabIndex = 6;
            this.PgbCalculate.Click += new System.EventHandler(this.PgbCalculate_Click);
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 153);
            this.Controls.Add(this.PgbCalculate);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Text = "BackgroundWorker 테스트";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.ProgressBar PgbCalculate;
        private System.ComponentModel.BackgroundWorker Worker;
    }
}

