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
    public partial class FormNORMAL : Form
    {
        int playerSpeed = 10;  // 플레이어 이동 속도
        int bulletSpeed = 5; //총알 떨어지는 속도
        private Rectangle bulletRect;

        public FormNORMAL()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeGame()
        {
            // 타이머 설정
            timer1.Interval = 50; // 타이머 간격 (ms)
            timer1.Tick += timer1_Tick;
            timer1.Start();

            // 초기 위치 설정
            player.Top = this.ClientSize.Height - player.Height - 10;
            player.Left = (this.ClientSize.Width - player.Width) / 2;

            bullet.Top = 0; // 화면 상단에서 시작
            Random rand = new Random();
            bullet.Left = rand.Next(0, this.ClientSize.Width - bullet.Width);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bullet.Top += bulletSpeed;

            // 구슬이 바닥에 도달하면 다시 위로 초기화
            if (bullet.Top > this.ClientSize.Height)
            {
                ResetBulletPosition();
            }

            // 충돌 감지
            if (PixelPerfectCollision(player, bullet))
            {
                GameOver();
            }
        }

        private void ResetBulletPosition()
        {
            bullet.Top = 0;
            Random rand = new Random();
            bullet.Left = rand.Next(0, this.ClientSize.Width - bullet.Width);
        }

        private void GameOver()
        {
            timer1.Stop();
            MessageBox.Show("게임 오버!");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            else if (keyData == Keys.Right && player.Right < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private bool PixelPerfectCollision(PictureBox player, PictureBox bullet)
        {
            // 두 PictureBox의 겹치는 사각형 영역을 계산합니다.
            Rectangle intersectionRect = Rectangle.Intersect(player.Bounds, bullet.Bounds);

            // 겹치는 영역이 없다면 false를 반환
            if (intersectionRect.IsEmpty)
            {
                return false;
            }

            // 플레이어와 볼 이미지에서 Bitmap 가져오기
            using (Bitmap playerBitmap = new Bitmap(player.Image))
            using (Bitmap bulletBitmap = new Bitmap(bullet.Image))
            {
                // 겹치는 영역 내의 각 픽셀을 비교
                for (int x = 0; x < intersectionRect.Width; x++)
                {
                    for (int y = 0; y < intersectionRect.Height; y++)
                    {
                        // 겹치는 영역 내에서 상대적 위치 계산
                        int playerX = x + intersectionRect.Left - player.Left;
                        int playerY = y + intersectionRect.Top - player.Top;

                        int bulletX = x + intersectionRect.Left - bullet.Left;
                        int bulletY = y + intersectionRect.Top - bullet.Top;

                        // 범위를 벗어나지 않도록 확인 (추가 안전장치)
                        if (playerX < 0 || playerX >= playerBitmap.Width || playerY < 0 || playerY >= playerBitmap.Height)
                            continue;
                        if (bulletX < 0 || bulletX >= bulletBitmap.Width || bulletY < 0 || bulletY >= bulletBitmap.Height)
                            continue;

                        // 플레이어와 볼의 해당 픽셀 가져오기
                        Color playerPixel = playerBitmap.GetPixel(playerX, playerY);
                        Color bulletPixel = bulletBitmap.GetPixel(bulletX, bulletY);

                        // 두 픽셀이 모두 투명하지 않다면 충돌로 간주
                        if (playerPixel.A != 0 && bulletPixel.A != 0)
                        {
                            return true;
                        }
                    }
                }
            }

            // 겹치는 영역에서 투명하지 않은 픽셀이 겹치지 않으면 충돌이 아님
            return false;
        }
    }
}
