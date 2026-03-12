namespace CatchBotton
{
    using System.Media;
    public partial class Form1 : Form
    {
        SoundPlayer runSound = new SoundPlayer(@"run.wav");
        SoundPlayer catchSound = new SoundPlayer(@"catch.wav");

        public Form1()
        {
            InitializeComponent();
            Random rd = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RunningBotton_MouseEnter(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();

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
            this.Text = $"버튼위치: ({nextX}, {nextY})";

        }

        private void RunningBotton_MouseClick(object sender, MouseEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("축하합니다~!");
        }
    }
}
