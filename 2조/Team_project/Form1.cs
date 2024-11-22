using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Team_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 크기 조정 비활성화
            this.MaximizeBox = false; // 최대화 버튼 비활성화
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form gameForm = null;

            // 라디오 버튼 선택에 따라 난이도 결정
            if (EASY.Checked)
            {
                gameForm = new FormEASY(this);
            }
            else if (NORMAL.Checked)
            {
                gameForm = new FormNORMAL(this);
            }
            else if (HARD.Checked)
            {
                gameForm = new FormHARD(this);
            }
            else
            {
                MessageBox.Show("난이도를 선택해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 게임 시작
            gameForm.FormClosed += (s, args) => this.Show(); // 게임 종료 시 메인 폼 다시 표시
            gameForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
