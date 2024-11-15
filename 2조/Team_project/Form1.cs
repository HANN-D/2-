using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int selectedLEVEL = 0;

        private void EASY_CheckedChanged(object sender, EventArgs e)
        {
            selectedLEVEL = 1;
        }

        private void NORMAL_CheckedChanged(object sender, EventArgs e)
        {
            selectedLEVEL = 2;
        }

        private void HARH_CheckedChanged(object sender, EventArgs e)
        {
            selectedLEVEL = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form gameForm = null;

            //난이도 선택에 따라 폼 지정
            if (selectedLEVEL == 1)
            {
                gameForm = new FormEASY();
            }
            else if (selectedLEVEL == 2)
            {
                gameForm = new FormNORMAL();
            }
            else if (selectedLEVEL == 3)
            {
                gameForm = new FormHARD();
            }
            else
                MessageBox.Show("난이도를 정해주세요");
            // 폼 생성 및 Form1 숨기기, 닫기시  Form1 보여주기
            if (selectedLEVEL != 0)
            {
                gameForm.FormClosed += (s, args) => this.Show();

                gameForm.Show();

                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 프로그램 종료
        }
    }
}
