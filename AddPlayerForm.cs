using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RAD_Assignment
{
    public partial class AddPlayerForm : Form
    {
        public Form1 _mainForm;
        public List<Player> _playerList;
        public Player _currentPlayer;
        public AddPlayerForm(Form1 mainForm, List<Player> playerList)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _playerList = playerList;
        }
        public void LoadPlayerData(Player player)
        {
            txtName.Text = player.Name;
            txtTeam.Text = player.Team;
            txtRating.Text = player.Rating.ToString();
            txtAssists.Text = player.Assists.ToString();
            txtPosition.Text = player.Position;
            txtPointsPerGame.Text = player.PointsPerGame.ToString();
            txtPhotoURL.Text = player.Photo;

            _currentPlayer = player;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            // Gather data from input fields
            string name = txtName.Text;
            string team = txtTeam.Text;
            double rating = double.Parse(txtRating.Text);
            double assists = double.Parse(txtAssists.Text);
            string position = txtPosition.Text;
            double pointsPerGame = double.Parse(txtPointsPerGame.Text);
            string photo = txtPhotoURL.Text;
            // Create a new Player object
            Player newPlayer = new Player
            {
                Name = name,
                Team = team,
                Rating = rating,
                Assists = assists,
                Position = position,
                PointsPerGame = pointsPerGame,
                Photo = photo
            };

            // Pass the new player to the main form
            _mainForm.AddPlayerToList(newPlayer);

            // Close the AddPlayerForm
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!double.TryParse(txtRating.Text, out double rating) ||
                !double.TryParse(txtPointsPerGame.Text, out double pointsPerGame) ||
                !int.TryParse(txtAssists.Text, out int assists))
            {
                MessageBox.Show("Please enter valid numeric values for Rating, Points Per Game, and Assists.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_currentPlayer != null)
            {
                // Update the existing player
                _currentPlayer.Name = txtName.Text;
                _currentPlayer.Team = txtTeam.Text;
                _currentPlayer.Rating = rating;
                _currentPlayer.Assists = assists;
                _currentPlayer.Position = txtPosition.Text;
                _currentPlayer.PointsPerGame = pointsPerGame;
                _currentPlayer.Photo = txtPhotoURL.Text;

                // Notify the main form
                _mainForm.RefreshPlayerList();

                // Close the form
                this.Close();
            }
            else
            {
                // Add a new player
                Player newPlayer = new Player
                {
                    Name = txtName.Text,
                    Team = txtTeam.Text,
                    Rating = rating,
                    Assists = assists,
                    Position = txtPosition.Text,
                    PointsPerGame = pointsPerGame,
                    Photo = txtPhotoURL.Text
                };

                _mainForm.AddPlayerToList(newPlayer);
                this.Close();
            }
        }
    }
}
