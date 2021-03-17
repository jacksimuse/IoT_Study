using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private BackgroundWorker worker;

        private Timer timer;
        private int timerCount = 0;
        public Form1()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            // 테스트용 타이머 이용
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }

        

        // Worker Thread가 실제 하는 일
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string srcDir = @"C:\Temp\_Src";
            string destDir = @"C:\Temp\_Dest";

            DirectoryInfo di = new DirectoryInfo(srcDir);
            FileInfo[] fileInfos = di.GetFiles();
            int totalFiles = fileInfos.Length;
            int counter = 0;
            int pct = 0;
            foreach (var fi in fileInfos)
            {
                string destFile = Path.Combine(destDir, fi.Name);
                File.Copy(fi.FullName, destFile);

                pct = ((++counter * 100) / totalFiles);
                worker.ReportProgress(pct);
            }
        }

        // Progress 리포트 - UI Thread
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        // 작업 완료 - UI Thread
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // 에러가 있는지 체크
            if (e.Error != null)
            {
                lblMsg.Text = e.Error.Message;
                MessageBox.Show(e.Error.Message, "Error");
                return;
            }
            lblMsg.Text = "성공적으로 완료되었습니다";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 비동기(Async)로 진행
            worker.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 디폴트값 사용 (Maximum = 100, Minimum = 0, Step = 10)
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 90;
            progressBar2.Step = 5;
            progressBar2.Value = 0;

            // Marquee 스타일
            progressBar3.Style = ProgressBarStyle.Marquee;
            progressBar3.Enabled = true;

            // 테스트를 위해 타이머 시작
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            // 한 스텝 이동
            progressBar1.PerformStep();
            progressBar2.PerformStep();

            // 타이머 중지 조건
            if (++timerCount == 10)
            {
                timer.Stop();
                progressBar3.Enabled = false;
            }
        }

    }
}
