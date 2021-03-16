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

namespace HW210316_2App
{
    public partial class Form1 : Form
    {
        //Thread객체 변수 선언
        BackgroundWorker worker;

        public Form1()
        {
            InitializeComponent();

            //Thread객체 생성(할당)
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            // [이벤트 핸들러 지정]
            // BackgroundWorker로부터 생성된 객체는 DoWork이벤트 핸들러를 통해 실제 작업할 내용을 지정하고, 
            // ProgressChanged이벤트를 통해 진척 사항을 전달하며, RunWorkerCompleted 이벤트를 통해 완료 후 
            // 실행될 작업을 지정한다.
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string srcDir = @"D:\GAMES\_Src";
            string destDir = @"D:\GAMES\_Dest";

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
        
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

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

        private void BtnRun_Click(object sender, EventArgs e)
        {
            // 비동기(Async)로 실행 
            worker.RunWorkerAsync();
        }

    }
}
