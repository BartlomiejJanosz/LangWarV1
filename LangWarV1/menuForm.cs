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
    public partial class menuForm : Form
    {
        private string _baseAddress = "http://localhost:12345/";
        private bool _isConnectedToServer = false;
        private int _waitingTime = 10;
        private bool _thisStationSetUpANewGame = false;
 
        public menuForm()
        {
            InitializeComponent();
        }
       
        private async void IsConnectedToServer()
        {           
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(_baseAddress + "api/values/0");
                    if (response.IsSuccessStatusCode)
                    {
                        _isConnectedToServer = true;
                    }
                    else
                    {
                        _isConnectedToServer = false;
                    }
                }
                catch (Exception ex)
                {
                    _isConnectedToServer = false;
                }                          
            }          
        }

        private void IsConnectedTimer_Tick(object sender, EventArgs e)
        {
            IsConnectedToServer();
            if (_isConnectedToServer)
            {
                isConnectedLabel.Text = "Połączono z serwerem";
                isConnectedLabel.BackColor = Color.LightGreen;
            }
            else
            {
                isConnectedLabel.Text = "Brak połączenia z serwerem";
                isConnectedLabel.BackColor = Color.Red;
            }
        }

        private void CreateGameButton_Click(object sender, EventArgs e)
        {
            if(_isConnectedToServer)
            {
                _thisStationSetUpANewGame = true;
                createGameButton.Text = "Oczekiwanie na przeciwnika (" + _waitingTime.ToString() + "s" + ")";
                CheckIfSomeoneJoinedToGameTimer.Start();
                EnableButtons(false);
                AddPlayerToWaitingRoom(playerNameTextBox.Text);
                waitForOtherPlayerTimer.Start();
                playerNameTextBox.Enabled = false;
            }      
            else
            {
                MessageBox.Show("Błąd połączenia z serwerem", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void EnableButtons(bool enable)
        {
            createGameButton.Enabled = enable;
            joinToGameButton.Enabled = enable;
        }


        private async void AddPlayerToWaitingRoom(string playerName)
        {
            var player = new Player
            {
                Name = playerName,
                JoinToExistingGame = false
            };

            var stringPlayer = await Task.Run(() => JsonConvert.SerializeObject(player));
            var httpContent = new StringContent(stringPlayer, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var httpResponse = await httpClient.PostAsync(_baseAddress + "api/values", httpContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia z serwerem", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void JoinToGameButton_Click(object sender, EventArgs e)
        {
            if(_isConnectedToServer)
            {
                if (playerNameTextBox.Text.Length > 0)
                    joinToGameButton.Enabled = true;
                JoinToGameIfExists(playerNameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Błąd połączenia z serwerem", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private async void JoinToGameIfExists(string playerName)
        {
            var player = new Player()
            {
                Name = playerName,
                JoinToExistingGame = true
            };

            var stringPlayer = await Task.Run(() => JsonConvert.SerializeObject(player));
            var httpContent = new StringContent(stringPlayer, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var httpResponse = await httpClient.PostAsync(_baseAddress + "api/values", httpContent);
                    var nameOfOpponent = httpResponse.Content.ReadAsStringAsync().Result;


                    if (nameOfOpponent.Length != 0 && nameOfOpponent.Contains('1'))
                    {
                        var opponentPlayer = new Player()
                        {
                            Name = nameOfOpponent.Replace("1", ""),
                            JoinToExistingGame = true
                        };
                        StopAllTimers();
                        battleForm form = new battleForm(opponentPlayer,playerNameTextBox.Text);
                        form.Show();
                        this.Hide();
                                          
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono żadnej gry");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd połączenia z serwerem", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void StopAllTimers()
        {
            waitForOtherPlayerTimer.Stop();
            isConnectedTimer.Stop();
            CheckIfSomeoneJoinedToGameTimer.Stop();
            CheckIfSomeoneSetUpAnewGame.Stop();
        }

        private void PlayerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            bool containsInt = playerNameTextBox.Text.Any(char.IsDigit);
            if (containsInt)
            {
                playerNameTextBox.Text = "";
                MessageBox.Show("Nazwa gracza nie może zawierać cyfr");
            }
            if (playerNameTextBox.Text.Length > 0)
            {
                joinToGameButton.Enabled = true;
                createGameButton.Enabled = true;
            }
            else
            {
                joinToGameButton.Enabled = false;
                createGameButton.Enabled = false;
            }               
        }

        private void WaitForOtherPlayerTimer_Tick(object sender, EventArgs e)
        {  
            if(_isConnectedToServer)
            {
                _waitingTime -= 1;
                createGameButton.Text = "Oczekiwanie na przeciwnika (" + _waitingTime.ToString() + "s" + ")";
                if (_waitingTime == 0)
                {
                    _thisStationSetUpANewGame = false;
                    waitForOtherPlayerTimer.Stop();
                    _waitingTime = 10;
                    playerNameTextBox.Enabled = true;
                    DeletePlayersFromWaitingRoom();
                    CheckIfSomeoneJoinedToGameTimer.Stop();
                    waitForOtherPlayerTimer.Stop();
                    EnableButtons(true);
                    createGameButton.Text = "Stwórz grę";
                }
            }                
        }

        private async void DeletePlayersFromWaitingRoom()
        {           
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    await httpClient.DeleteAsync(_baseAddress + "api/values");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd połączenia z serwerem", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private async void CheckIfSomeoneJoinedToGameTimer_Tick(object sender, EventArgs e)
        {
            if(_isConnectedToServer)
            {
                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        var httpResponse = await httpClient.GetAsync(_baseAddress + "api/values");
                        var lastContentOfWaitingRoom = httpResponse.Content.ReadAsStringAsync().Result;
                        var index = lastContentOfWaitingRoom.IndexOf('2');
                        if (index > 0)
                        {
                            var nameOfOpponent = lastContentOfWaitingRoom.Substring(index + 1);
                            Player player = new Player()
                            {
                                Name = nameOfOpponent,
                                JoinToExistingGame = false

                            };

                            StopAllTimers();
                            DeletePlayersFromWaitingRoom();
                            battleForm battleForm = new battleForm(player, playerNameTextBox.Text);                           
                            battleForm.Show();
                            this.Hide();                         
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z serwerem", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                          
        }

        private void CheckIfSomeoneSetUpAnewGame_Tick(object sender, EventArgs e)
        {
            if(_isConnectedToServer)
            {
                DisableButtons();
            }     
        }

        private async void DisableButtons()
        {
            if (!_thisStationSetUpANewGame)
            {
                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        var httpResponse = await httpClient.GetAsync(_baseAddress + "api/values");
                        var lastContentOfWaitingRoom = httpResponse.Content.ReadAsStringAsync().Result;
                        if (lastContentOfWaitingRoom.Contains('1'))
                        {
                            createGameButton.Enabled = false;
                            createGameButton.Text = "Przeciwnik rozpoczął grę, możesz do niej dołączyć";
                        }
                        else
                        {
                            if (playerNameTextBox.Text.Length > 0)
                            {
                                createGameButton.Enabled = true;
                            }
                            createGameButton.Text = "Stwórz grę";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z serwerem", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }          
        }

        private void menuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeletePlayersFromWaitingRoom();
            Application.Exit();
        }
    }
}
