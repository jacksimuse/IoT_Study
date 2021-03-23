using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConfirmedCasesByRegion
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // 잘못해가지고 일단은 주석처리
        // 공공데이터에서 데이터 불러오는 메서드
        //private void LinkXmlData() 
        //{
        //    string ServiceKey = "kjlFy8y0eoQPFXlX9w7PcT40tvtkm7tq1OlGDdV%2F7ZFhjgVA3dCZqhbfR0znksHKzQ5fBH9ZnoQuWMflcBPWoQ%3D%3D";
        //    // 서비스 키 : kjlFy8y0eoQPFXlX9w7PcT40tvtkm7tq1OlGDdV%2F7ZFhjgVA3dCZqhbfR0znksHKzQ5fBH9ZnoQuWMflcBPWoQ%3D%3D
        //    // 사이트 주소 : http://openapi.data.go.kr/openapi/service/rest/Covid19/getCovid19SidoInfStateJson?serviceKey=kjlFy8y0eoQPFXlX9w7PcT40tvtkm7tq1OlGDdV%2F7ZFhjgVA3dCZqhbfR0znksHKzQ5fBH9ZnoQuWMflcBPWoQ%3D%3D&pageNo=1&numOfRows=10&startCreateDt=20200410&endCreateDt=20200410

        //    string url = "http://openapi.data.go.kr/openapi/service/rest/Covid19/getCovid19SidoInfStateJson"; // URL
        //    url += "?ServiceKey=" + ServiceKey; // Service Key
        //    url += "&pageNo=1";
        //    url += "&numOfRows=5";
        //    url += "&startCreateDt=20210320";
        //    url += "&endCreateDt=20210322";

        //    var request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Method = "GET";

        //    string results = string.Empty;
        //    HttpWebResponse response;
        //    using (response = request.GetResponse() as HttpWebResponse)
        //    {
        //        StreamReader reader = new StreamReader(response.GetResponseStream());
        //        results = reader.ReadToEnd();
        //    }

        //    MessageBox.Show(results);
        //    // Console.WriteLine(results);
        //}

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
           // LinkXmlData();
        }
    }
}
