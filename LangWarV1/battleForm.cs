using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangWarV1
{
    public partial class battleForm : Form
    {
        private Player _opponentPlayer;
        private string _ourName;
        private string _baseAddress = "http://localhost:12345/";
        public battleForm(Player opponentPlayer, string ourName)
        {
            InitializeComponent();
            _opponentPlayer = opponentPlayer;
            _ourName = ourName.Replace(@"""",String.Empty);
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {
            nameOfOpponentPlayerLabel.Text = "Twój przeciwnik nazywa się: "+_opponentPlayer.Name;
            additionalInfoLabel.Text = "Po stronie serwera utworzono dwa pliki tekstowe: " + _ourName + "GameData.txt" + " oraz: " + _opponentPlayer.Name.Replace(@"""", String.Empty) + "GameData.txt" + ", które posłóżą do przechowywania danych z Gry.";
        }

        private void battleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteFilesFromServer();
            menuForm menuForm = new menuForm();
            menuForm.Show();
        }

        private async void DeleteFilesFromServer()
        {
            //To be done
        }
    }
}
