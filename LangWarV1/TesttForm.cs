using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LangWarV1
{
    public partial class TesttForm : Form
    {
        public TesttForm()
        {
            InitializeComponent();
        }
        private string _baseAddress = "http://localhost:12345/";

        private async void AddBattleInfoToTableButton_Click(object sender, EventArgs e)
        {
            var firstCard = new Card(1, 3, "pies", "book", "PL");
            var secondCard = new Card(2, 4, "kot", "library", "ANG");

            var battleInfo = new BattleInfo(1, 1, 30, firstCard, secondCard);

            var stringBattleInfo = await Task.Run(() => JsonConvert.SerializeObject(battleInfo));
            var httpContent = new StringContent(stringBattleInfo, Encoding.UTF8, "application/json");

            using (HttpClient httpClient = new HttpClient())
            {
                await httpClient.PostAsync(_baseAddress + "api/values/battleInfo", httpContent);
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.GetAsync(_baseAddress + "api/values/battleInfo/1");
                var resultasstring = httpResponse.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
