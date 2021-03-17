using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockApp
{
    public partial class Form1 : Form
    {

        /*
        (0, 0)                (Plus, 0)
        ● → → → → → → → → → →
        ↑   [Form Pos]      ↑
        ↑                   ↑
        ↑                   ↑
        ↑                   ↑
        ↑                   ↑
        ↑→ → → → → → → → → →(Plus, Plus)
        (0, Plus)
        */

        Graphics g;
        int nBlocks = 20; 
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        bool[] bVisible = new bool[100];
        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.Black);
        Brush blockColor = new SolidBrush(Color.Chocolate);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        int racketY = 480; 
        int formW = 300;  

        int racketW = 50;
        int racketH = 10;

        int blockY = 60;  
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;

        Timer myTimer = new Timer();
        private double slope;       // 공의 기울기     
        private double vDir = 1;    // 1:UP, -1:DOWN

        Random r = new Random();
        private int clearedBlocks = 0;
        private int MaxBlocks = 100;

        private int initialBallPosition;


        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(300, 500);

            initbVisible();
            initRacket();
            initBlocks();
            StartBall();

            myTimer.Tick += myTimer_Tick;
            timer1.Interval = 100;  // milliseconds
            timer1.Start();
        }

        private void initbVisible()
        {
            for (int i = 0; i < nBlocks; i++)
                bVisible[i] = true;
        }

        private void initRacket()
        {
            racket.X = (formW / 2) - (racketW / 2);
            racket.Y = racketY;

            racket.Width = racketW;
            racket.Height = racketH;
        }

        private void initBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
                blocks[i] = new Rectangle
                    (i % 10 * blockW, blockY + blockH * (i / 10),
                     blockW - 1, blockH - 1);
        }

        private void initBall()
        {
            ball = new Rectangle();
            ball.X = (formW / 2) - (ballW / 2);
            ball.Y = blockY + (nBlocks / 10) * blockH;
            initialBallPosition = ball.Y;
            ball.Width = ballW;
            ball.Height = ballH;
        }

        private void drawBall() //공 그리기
        {
            g.FillRectangle(ballColor, ball);
            g.DrawRectangle(pen, ball);
        }

        private void drawRacket() //라켓 그리기
        {
            g.FillRectangle(racketColor, racket);
        }

        private void drawBlocks() //블럭 그리기
        {
            for (int i = 0; i < nBlocks; i++)
                if (bVisible[i])
                    g.FillRectangle(blockColor, blocks[i]);
        }

        private void StartBall()
        {
            initBall();
            slope = r.Next(5, 20) / 10.0;
            // slope = 0.5;
            if (r.Next(2) == 1)
                slope = -slope;
        }


        private void myTimer_Tick(object sender, EventArgs e)
        {
            double dX;
            double unit = ballW;

            // dX 가 움직이는 단위임
            dX = (unit / slope);

            // ball Vector : ((unit/slope), (unit*vDir)[고정값])
            // 실제로는 X축의 Dynamic한 변화!
            ball.X += (int) dX;
            ball.Y += (int) (vDir * slope * dX);

            // 벽 충돌 판정
            if (ball.X < 0 || ball.X > formW - ballW)
            {
                slope *= -1;
                // 재미를 위해 랜덤 값 미세 조정
                slope += r.Next(-20, 20) / 100.0;
            }
            // Rectangle 자체에서 Intersect 지원함!
            if (ball.Y < 0 || racket.IntersectsWith(ball))
            {
                vDir *= -1;
            }

            Invalidate();

            // 게임오버 판정
            if (ball.Y > ClientSize.Height)
            {
                StartBall();
                return;
            }

            // 블록 판정
            if (ball.Y > blockY + blockH * nBlocks / 10)
                return;
            Random sRnd = new Random();
            for (int i = 0; i < nBlocks; i++)
            {
                // Rectangle 자체에서 Intersect 지원함!
                if (bVisible[i] && ball.IntersectsWith(blocks[i]))
                {
                    bVisible[i] = false;
                    vDir *= -1;

                    if (++clearedBlocks >= nBlocks)
                    {
                        myTimer.Stop();

                        if (nBlocks == MaxBlocks)
                        {
                            MessageBox.Show("Final Stage Cleared!");
                            this.Close();
                        }
                        else
                        {
                            string str = string.Format("Level {0} Completed! Play More?", nBlocks / 20);
                            DialogResult result = MessageBox.Show(str, "Level Clear!", MessageBoxButtons.YesNo);
                           
                            if (result == DialogResult.Yes)
                                newLevelStart();
                            else
                                Close();
                        }
                    }
                }
            }
        }

        private void newLevelStart()
        {
            if (nBlocks > MaxBlocks)
                return; 

            nBlocks += 20;

            initbVisible();
            initRacket();
            initBall();
            initBlocks();

            clearedBlocks = 0;

            StartBall();
            myTimer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    racket.X -= 10;
                    if (racket.X < 0)
                        racket.X = 0;
                    break;
                case Keys.Right:
                    racket.X += 10;
                    if (racket.X > formW - racketW)
                        racket.X = formW - racketW;
                    break;
                case Keys.Up:
                    racket.Y -= 10;
                    if (racket.Y < initialBallPosition)
                        racket.Y = initialBallPosition;
                    break;
                case Keys.Down:
                    racket.Y += 10;
                    if (racket.Y > ClientSize.Height - 20)
                        racket.Y = ClientSize.Height - 20;
                    break;

                case Keys.Escape:
                case Keys.Enter:
                    myTimer.Enabled ^= true;
                    break;
            }
            Invalidate();

            /*if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
                if (racket.X < 0)
                    racket.X = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
                if (racket.X > formW - racketW)
                    racket.X = formW - racketW;
            }
            else if (e.KeyCode == Keys.Up)
            {
                racket.Y -= 10;
                if (racket.Y < initialBallPosition)
                    racket.Y = initialBallPosition;
            }
            else if (e.KeyCode == Keys.Down)
            {
                racket.Y += 10;
                if (racket.Y > ClientSize.Height - 20)
                    racket.Y = ClientSize.Height - 20;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                myTimer.Stop();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                myTimer.Start();
            }
            Invalidate();*/
        }

        // OnPaint 가상 메소드 오버라이딩
        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics; // this.CreateGraphics();
            drawRacket();
            drawBlocks();
            drawBall();
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            
            // myTimer.Start();
            myTimer.Enabled = true;
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            // myTimer.Stop();
            myTimer.Enabled = false;
        }
    }
}
