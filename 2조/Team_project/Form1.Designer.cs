﻿namespace Team_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EASY = new System.Windows.Forms.RadioButton();
            this.NORMAL = new System.Windows.Forms.RadioButton();
            this.HARH = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(80, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "GAME START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(80, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 18);
            this.button2.TabIndex = 1;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(237, 44);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "총알 피하기";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 7.8F, System.Drawing.FontStyle.Underline);
            this.textBox2.Location = new System.Drawing.Point(10, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 94);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "룰 설명\r\n!캐릭터는 좌우로만 이동가능!\r\n\r\n!하늘에서 총알이 떨어진다!\r\n\r\n!총알에 맞으면 게임 끝!\r\n\r\n!EASY  NORMAL  HAR" +
    "D!\r\n";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EASY
            // 
            this.EASY.AutoSize = true;
            this.EASY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EASY.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EASY.Location = new System.Drawing.Point(10, 216);
            this.EASY.Name = "EASY";
            this.EASY.Size = new System.Drawing.Size(64, 16);
            this.EASY.TabIndex = 3;
            this.EASY.TabStop = true;
            this.EASY.Text = "EASY";
            this.EASY.UseVisualStyleBackColor = false;
            this.EASY.CheckedChanged += new System.EventHandler(this.EASY_CheckedChanged);
            // 
            // NORMAL
            // 
            this.NORMAL.AutoSize = true;
            this.NORMAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NORMAL.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NORMAL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NORMAL.Location = new System.Drawing.Point(80, 216);
            this.NORMAL.Name = "NORMAL";
            this.NORMAL.Size = new System.Drawing.Size(89, 16);
            this.NORMAL.TabIndex = 4;
            this.NORMAL.TabStop = true;
            this.NORMAL.Text = "NORMAL";
            this.NORMAL.UseVisualStyleBackColor = false;
            this.NORMAL.CheckedChanged += new System.EventHandler(this.NORMAL_CheckedChanged);
            // 
            // HARH
            // 
            this.HARH.AutoSize = true;
            this.HARH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HARH.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HARH.Location = new System.Drawing.Point(175, 216);
            this.HARH.Name = "HARH";
            this.HARH.Size = new System.Drawing.Size(67, 16);
            this.HARH.TabIndex = 5;
            this.HARH.TabStop = true;
            this.HARH.Text = "HARD";
            this.HARH.UseVisualStyleBackColor = false;
            this.HARH.CheckedChanged += new System.EventHandler(this.HARH_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(258, 360);
            this.Controls.Add(this.HARH);
            this.Controls.Add(this.NORMAL);
            this.Controls.Add(this.EASY);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton EASY;
        private System.Windows.Forms.RadioButton NORMAL;
        private System.Windows.Forms.RadioButton HARH;
    }
}

