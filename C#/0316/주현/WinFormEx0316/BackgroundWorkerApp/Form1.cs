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

namespace BackgroundWorkerApp
{
    public partial class Form1 : Form
    {
        private BackgroundWorker worker;
        public Form1()
        {
            InitializeComponent();
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_Progresschanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }


        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string srcDir = @"D:\\Temp\\";
            string destDir = @"D:\\Temp\\dst";

            DirectoryInfo di = new DirectoryInfo(srcDir);
            try
            {
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
            catch { }
        }

        void worker_Progresschanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                label1.Text = e.Error.Message;
                MessageBox.Show(e.Error.Message, "Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }

            label1.Text = "완료";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                worker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "예외 발생");
            }
            
        }
    }
}
