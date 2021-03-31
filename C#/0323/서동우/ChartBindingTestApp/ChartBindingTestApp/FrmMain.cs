using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartBindingTestApp
{
    // Data Source=127.0.0.1;Initial Catalog=COVID-19;User ID=sa;Password=mssql_p@ssw0rd!

    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // List를 이용한 데이터 바인딩
            //List<string> x = new List<string> { "재훈", "동우", "하윤", "주현", "수민" };  // 확진자 수
            //List<double> y = new List<double> { 90, 70, 85, 100, 95 };                     // 확진 날짜
            //chart1.Series[0].Points.DataBindXY(x, y);
            //chart1.Series[0].Name = "점수";




            // 객체 컬렉션에 대한 데이타바인딩
            List<Student> students = new List<Student>();
            students.Add(new Student("재훈", 80));
            students.Add(new Student("동우", 75));
            students.Add(new Student("하윤", 85));
            students.Add(new Student("주현", 95));
            students.Add(new Student("수민", 100));

            // X축: Name, Y축: Score
            chart1.Series[0].Points.DataBind(students, "Name", "Score", null);
            chart1.Series[0].Name = "점수";

            // (참고) DataBindTable() 사용시. (X축: Name, Y축: 자동검색)
            // chart1.DataBindTable(students, "Name"); 
        }
    }

    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }

        public Student(string name, double score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}

