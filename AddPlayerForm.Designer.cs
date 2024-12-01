namespace RAD_Assignment
{
    partial class AddPlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTeam = new TextBox();
            txtAssists = new TextBox();
            txtPosition = new TextBox();
            txtName = new TextBox();
            txtRating = new TextBox();
            txtPointsPerGame = new TextBox();
            txtPhotoURL = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAddPlayer = new Button();
            label8 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtTeam
            // 
            txtTeam.Location = new Point(134, 187);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(255, 27);
            txtTeam.TabIndex = 0;
            // 
            // txtAssists
            // 
            txtAssists.Location = new Point(134, 240);
            txtAssists.Name = "txtAssists";
            txtAssists.Size = new Size(255, 27);
            txtAssists.TabIndex = 1;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(134, 288);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(255, 27);
            txtPosition.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 27);
            txtName.TabIndex = 3;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(134, 136);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(255, 27);
            txtRating.TabIndex = 4;
            // 
            // txtPointsPerGame
            // 
            txtPointsPerGame.Location = new Point(134, 339);
            txtPointsPerGame.Name = "txtPointsPerGame";
            txtPointsPerGame.Size = new Size(255, 27);
            txtPointsPerGame.TabIndex = 5;
            // 
            // txtPhotoURL
            // 
            txtPhotoURL.Location = new Point(134, 387);
            txtPhotoURL.Name = "txtPhotoURL";
            txtPhotoURL.Size = new Size(255, 27);
            txtPhotoURL.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 89);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 143);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 8;
            label2.Text = "Rating: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 194);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 9;
            label3.Text = "Team: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 247);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 10;
            label4.Text = "Assists: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 291);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 11;
            label5.Text = "Position: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 343);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 12;
            label6.Text = "Points: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 394);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 13;
            label7.Text = "PhotoURL: ";
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.BackColor = Color.Black;
            btnAddPlayer.ForeColor = SystemColors.ButtonHighlight;
            btnAddPlayer.Location = new Point(84, 439);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(94, 29);
            btnAddPlayer.TabIndex = 14;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = false;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(92, 24);
            label8.Name = "label8";
            label8.Size = new Size(314, 32);
            label8.TabIndex = 15;
            label8.Text = "Add/Update New Player";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(295, 439);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Update";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddPlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(498, 496);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(btnAddPlayer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhotoURL);
            Controls.Add(txtPointsPerGame);
            Controls.Add(txtRating);
            Controls.Add(txtName);
            Controls.Add(txtPosition);
            Controls.Add(txtAssists);
            Controls.Add(txtTeam);
            Name = "AddPlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPlayerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTeam;
        private TextBox txtAssists;
        private TextBox txtPosition;
        private TextBox txtName;
        private TextBox txtRating;
        private TextBox txtPointsPerGame;
        private TextBox txtPhotoURL;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAddPlayer;
        private Label label8;
        private Button btnSave;
    }
}