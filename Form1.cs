namespace CatchBotton
{
    using System.Media;
    public partial class Form1 : Form
    {
        SoundPlayer runSound = new SoundPlayer(@"run.wav");
        SoundPlayer catchSound = new SoundPlayer(@"catch.wav");

        Random rd = new Random();

        int score = 0;
        // 버튼 놓친 횟수
        int missCount = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GameOver()
        {
            //게임오버 함수
            MessageBox.Show("Game Over");
            //재시작 함수 실행
            ResetGame();
        }

        private void ResetGame()
        {
            score = 0;
            missCount = 0;

            // 버튼 크기 초기화
            RunningBotton.Width = 233;
            RunningBotton.Height = 126;

            // 버튼 위치 초기화
            RunningBotton.Location = new Point(100, 100);

            // 버튼 다시 활성화
            RunningBotton.Enabled = true;

            // 제목 초기화
            this.Text = "Catch Button Game";
        }

        private void RunningBotton_MouseEnter(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();

            // 놓치면 점수 -10점, 놓친 횟수 +1
            score -= 10;
            missCount++;

            // 1. 난수생성기준비
            Random rd = new Random();
            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            int maxX = this.ClientSize.Width - RunningBotton.Width;
            int maxY = this.ClientSize.Height - RunningBotton.Height;
            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            // 4. 위치할당(새로운Point 객체생성)
            RunningBotton.Location = new Point(nextX, nextY);
            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY}) | 점수: {score}";

            if(missCount >= 20)
            {
                GameOver();
            }

        }


        private void RunningBotton_MouseClick(object sender, MouseEventArgs e)
        {
            score += 100;
            SystemSounds.Asterisk.Play();
            MessageBox.Show("축하합니다~!");

            // 버튼 크기 10% 감소
            RunningBotton.Width = (int)(RunningBotton.Width * 0.9);
            RunningBotton.Height = (int)(RunningBotton.Height * 0.9);
        }
    }
}
