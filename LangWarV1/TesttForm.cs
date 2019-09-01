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
using System.Web.Script.Serialization;

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
            var firstCard = new Card(1, 5, "słoń", "elephant", "PL");
            var secondCard = new Card(2, 1, "library", "biblioteka", "ANG");

            var battleInfo = new BattleInfo(-1, 1, 30, firstCard, secondCard);

            var battleInfoAsString = await Task.Run(() => JsonConvert.SerializeObject(battleInfo));
            var httpContent = new StringContent(battleInfoAsString, Encoding.UTF8, "application/json");

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
                var resultAsString = httpResponse.Content.ReadAsStringAsync().Result;
                //Do not know why but string that comes from server is modified and has '\'added in some places plus '"' at the end and the beginning
                var resultReadyToBeDeserialized = PrepareStringToDeserialization(resultAsString);
                BattleInfo battleInfo = await Task.Run(() => JsonConvert.DeserializeObject<BattleInfo>(resultReadyToBeDeserialized));
            }
        }

        private static string PrepareStringToDeserialization(string resultasstring)
        {
            resultasstring = resultasstring.Replace(@"\", "");
            resultasstring = resultasstring.Substring(1);
            resultasstring = resultasstring.Remove(resultasstring.Length - 1);
            return resultasstring;
        }
    }
}
