using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpodS
{
    public partial class Form14 : Form
    {
        private object jsonData;

        public object JsonConvert { get; private set; }

        public Form14()
        {
            InitializeComponent();
            GetRecommendedShoes();

        }

        
        public void GetRecommendedShoes()
        {
            //var client = new RestClient("https://feioyus4w4.execute-api.ap-northeast-1.amazonaws.com/dev/api/recommend?fid=XXXXXXXXXX&dispnum=3&rightlength=23.2&rightwidth=8.5&rightgirth=20.4&leftlength=23.0&leftwidth=8.1&leftgirth=20.1&toetype=1&wearfrequency=1&selectlength=22&selectwidth=D&widthquestion=1&instepquestion=2");
            var client = new RestClient("https://feioyus4w4.execute-api.ap-northeast-1.amazonaws.com//dev/api/purchaseLog");

            var request = new RestRequest(Method.POST);
            request.AddHeader("x-api-key", "kenneHQC5t57Yhr1ax68Rt1wuXIaHUi5N3B7DCXRz");
            IRestResponse response = client.Execute(request);
            string str222 = response.ToString();
            Console.WriteLine(str222);
            Console.WriteLine(str222.Length);
            var content = response.Content; // raw content as string
            Console.WriteLine(content);
            //dynamic json = JsonConvert.DeserializeObject(content);
            //JObject customerObjJson = jsonData.CustomerObj;
            //var customerObj = customerObjJson.ToObject<Customer>();
            //Console.WriteLine(customerObj);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }
    }
}
