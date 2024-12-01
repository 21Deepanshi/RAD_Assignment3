using System.ComponentModel;
using System.Numerics;

namespace RAD_Assignment
{
    public partial class Form1 : Form
    {
        private Players playerList;
        public List<Player> _playerList;
        public BindingList<Player> playersData = new BindingList<Player>();
        public Panel panelPlayerCards = new Panel();
        public List<Player> playersList = new List<Player>();

        public Form1()
        {
            InitializeComponent();
            playerList = new Players();
            _playerList = new List<Player>();
            lstPlayerList.DataSource = playersData;
            lstPlayerList.DataSource = _playerList;
            lstPlayerList.DisplayMember = "Name";
            JoinPlayers();
            lstPlayerList.SelectedIndexChanged += listboxPlayers_SelectedIndexChanged;
            pbPlayerPhotos.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public void AddPlayerToList(Player newPlayer)
        {
            _playerList.Add(newPlayer);

            // Refresh the ListBox
            lstPlayerList.DataSource = null; 
            lstPlayerList.DataSource = _playerList;
            lstPlayerList.DisplayMember = "Name";

            // Create a new player card (Panel)
            Panel playerCard = new Panel
            {
                Width = 200,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = newPlayer
            };

            
            Label lblPlayerName = new Label
            {
                Text = newPlayer.Name,
                Dock = DockStyle.Top
            };
            playerCard.Controls.Add(lblPlayerName);

            
            panel1.Controls.Add(playerCard);
        }
        private void JoinPlayers()
        {
            lstPlayerList.DataSource = playerList.player;
            lstPlayerList.DisplayMember = "Name";

            if (playerList.player.Count > 0)
            {
                lstPlayerList.SelectedIndex = 0;
            }
        }
        private void listboxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayerList.SelectedIndex != -1)
            {
                
                Player selectedPlayer = (Player)lstPlayerList.SelectedItem;

                
                panel1.Controls.Clear();

                
                DisplayPlayers(selectedPlayer);
            }

        }

        private void DisplayPhoto(string photo)
        {
            try
            {
                using (var client = new System.Net.WebClient())
                {
                    var imageStream = new MemoryStream(client.DownloadData(photo));
                    var img = Image.FromStream(imageStream);
                    pbPlayerPhotos.Image = ResizeImage(img, 343, 181);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load the image. Please check the URL or your internet connection.\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

               
                pbPlayerPhotos.Image = null; 
            }
        }
        private Image ResizeImage(Image img, int width, int height)
        {
            var aspectRatio = (float)img.Width / img.Height;
            var newWidth = width;
            var newHeight = (int)(width / aspectRatio);

            if (newHeight > height)
            {
                newHeight = height;
                newWidth = (int)(height * aspectRatio);
            }

            var newImage = new Bitmap(width, height);

            using (var g = Graphics.FromImage(newImage))
            {
                g.DrawImage(img, 0, 0, width, height);
            }

            return newImage;
        }

        private void DisplayPlayers(Player player)
        {
            Panel playerCard = new Panel
            {
                Size = new Size(300, 400),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5),
                Tag = player
            };
            
            int x = (panel1.Width - playerCard.Width) / 2;
            int y = (panel1.Height - playerCard.Height) / 2;

            playerCard.Location = new Point(x, y);
            

            switch (player.Team)
            {
                case "Lakers": playerCard.BackColor = Color.Purple; break;
                case "Warriors": playerCard.BackColor = Color.Yellow; break;
                case "Bucks": playerCard.BackColor = Color.DarkGreen; break;
                case "Suns": playerCard.BackColor = Color.Orange; break;
                case "Clippers": playerCard.BackColor = Color.Blue; break;
                case "76ers": playerCard.BackColor = Color.Red; break;
                case "Nuggets": playerCard.BackColor = Color.Cyan; break;
                case "Heat": playerCard.BackColor = Color.DarkRed; break;
                case "Mavericks": playerCard.BackColor = Color.Navy; break;
                case "Hawks": playerCard.BackColor = Color.Maroon; break;
            }

            // Add player photo
            PictureBox playerPhoto = new PictureBox
            {
                Size = new Size(280, 160),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = player.Photo
            };

            Label lblName = new Label
            {
                Text = player.Name,
                Font = new Font("Time New Roman", 15, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 170),
                ForeColor = Color.Black
            };

            Label lblRating = new Label
            {
                Text = $"Rating: {player.Rating}",
                Font = new Font("Arial", 11, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 210),
                ForeColor = player.Rating < 75 ? Color.Red : Color.Green
            };

            Label lblPosition = new Label
            {
                Text = $"Position: {player.Position}",
                Font = new Font("Arial", 11, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(10, 240),
                ForeColor = Color.Black
            };

            Label lblTeam = new Label
            {
                Text = $"Team: {player.Team}",
                Font = new Font("Arial", 11, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(10, 270),
                ForeColor = Color.Black
            };

            Label lblAssists = new Label
            {
                Text = $"Assists: {player.Assists}",
                Font = new Font("Arial", 11, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(10, 300),
                ForeColor = Color.Black
            };

            Label lblPointsPerGame = new Label
            {
                Text = $"Points: {player.PointsPerGame}",
                Font = new Font("Arial", 11, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(10, 330),
                ForeColor = Color.Black
            };

            playerCard.Controls.Add(playerPhoto);
            playerCard.Controls.Add(lblName);
            playerCard.Controls.Add(lblRating);
            playerCard.Controls.Add(lblTeam);
            playerCard.Controls.Add(lblAssists);
            playerCard.Controls.Add(lblPosition);
            playerCard.Controls.Add(lblPointsPerGame);

            playerCard.Click += PlayerCard_Click;
            playerPhoto.Click += PlayerCard_Click;

            panel1.Controls.Add(playerCard);
        }
        private void PlayerCard_Click(object sender, EventArgs e)
        {
            Panel clickedCard = sender as Panel ?? ((Control)sender).Parent as Panel;

            if (clickedCard != null && clickedCard.Tag is Player selectedPlayer)
            {
                // Update labels with the player's details
                lblName.Text = "Name: " + selectedPlayer.Name;
                lblTeam.Text = "Team: " + selectedPlayer.Team;
                lblRating.Text = "Rating: " + selectedPlayer.Rating.ToString();
                lblAssists.Text = "Assists: " + selectedPlayer.Assists.ToString();
                lblPosition.Text = "Position: " + selectedPlayer.Position.ToString();
                lblPointsPerGame.Text = "Points: " + selectedPlayer.PointsPerGame.ToString();

                // Update the PictureBox with the player's photo
                DisplayPhoto(selectedPlayer.Photo);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm(this, _playerList);
            addPlayerForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedPlayer = (Player)lstPlayerList.SelectedItem;
            if (selectedPlayer != null)
            {
              
                AddPlayerForm addPlayerForm = new AddPlayerForm(this, _playerList);
                addPlayerForm.LoadPlayerData(selectedPlayer);
                addPlayerForm.ShowDialog();
                RefreshPlayerList();
            }
            else
            {
                MessageBox.Show("Please select a player to update.");
            }
        }
        public Player GetSelectedPlayer()
        {
            return (Player)lstPlayerList.SelectedItem;
        }

        public void RefreshPlayerList()
        {
            lstPlayerList.DataSource = null;
            lstPlayerList.DataSource = _playerList;
            lstPlayerList.DisplayMember = "Name";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedPlayer = (Player)lstPlayerList.SelectedItem;

            if (selectedPlayer != null)
            {
                _playerList.Remove(selectedPlayer);

               
                Control playerCardToRemove = panel1.Controls
                    .Cast<Control>()
                    .FirstOrDefault(control => control is Panel panel && panel.Tag == selectedPlayer);

                if (playerCardToRemove != null)
                {
                    panel1.Controls.Remove(playerCardToRemove);
                }

                // Refresh the ListBox
                lstPlayerList.DataSource = null; 
                lstPlayerList.DataSource = _playerList;
                lstPlayerList.DisplayMember = "Name";

                // Clear player details
                lblName.Text = "";
                lblTeam.Text = "";
                lblRating.Text = "";
                lblAssists.Text = "";
                lblPosition.Text = "";
                lblPointsPerGame.Text = "";
                pbPlayerPhotos.Image = null;
            }
        }
    }
}
