namespace RAD_Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstPlayerList = new ListBox();
            panel1 = new Panel();
            label7 = new Label();
            lblPointsPerGame = new Label();
            lblPosition = new Label();
            lblRating = new Label();
            lblAssists = new Label();
            lblTeam = new Label();
            lblName = new Label();
            pbPlayerPhotos = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlayerPhotos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(211, 11);
            label1.Name = "label1";
            label1.Size = new Size(452, 47);
            label1.TabIndex = 0;
            label1.Text = "Basket Ball Players";
            // 
            // lstPlayerList
            // 
            lstPlayerList.BackColor = SystemColors.MenuText;
            lstPlayerList.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPlayerList.ForeColor = SystemColors.Info;
            lstPlayerList.FormattingEnabled = true;
            lstPlayerList.ItemHeight = 25;
            lstPlayerList.Location = new Point(22, 94);
            lstPlayerList.Name = "lstPlayerList";
            lstPlayerList.Size = new Size(229, 229);
            lstPlayerList.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblPointsPerGame);
            panel1.Controls.Add(lblPosition);
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(lblAssists);
            panel1.Controls.Add(lblTeam);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(pbPlayerPhotos);
            panel1.Controls.Add(label3);
            panel1.Cursor = Cursors.Hand;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(440, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 446);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 107);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 8;
            // 
            // lblPointsPerGame
            // 
            lblPointsPerGame.AutoSize = true;
            lblPointsPerGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPointsPerGame.Location = new Point(19, 397);
            lblPointsPerGame.Name = "lblPointsPerGame";
            lblPointsPerGame.Size = new Size(0, 28);
            lblPointsPerGame.TabIndex = 7;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPosition.Location = new Point(16, 329);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(0, 28);
            lblPosition.TabIndex = 6;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRating.Location = new Point(19, 256);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(0, 28);
            lblRating.TabIndex = 5;
            // 
            // lblAssists
            // 
            lblAssists.AutoSize = true;
            lblAssists.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssists.Location = new Point(19, 363);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(0, 28);
            lblAssists.TabIndex = 4;
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeam.Location = new Point(21, 294);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(0, 28);
            lblTeam.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(19, 222);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 28);
            lblName.TabIndex = 2;
            // 
            // pbPlayerPhotos
            // 
            pbPlayerPhotos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbPlayerPhotos.Location = new Point(19, 39);
            pbPlayerPhotos.Name = "pbPlayerPhotos";
            pbPlayerPhotos.Size = new Size(310, 167);
            pbPlayerPhotos.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPlayerPhotos.TabIndex = 1;
            pbPlayerPhotos.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(108, 6);
            label3.Name = "label3";
            label3.Size = new Size(133, 27);
            label3.TabIndex = 0;
            label3.Text = "PLAYERS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 4;
            label2.Text = "List of the Players";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(168, 347);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(174, 394);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(168, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 351);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 8;
            label4.Text = "1. Add New Player: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 398);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 9;
            label5.Text = "2. Update the player: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 439);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 10;
            label6.Text = "3. Delete the Player: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 529);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(lstPlayerList);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trading Cards";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlayerPhotos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstPlayerList;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private PictureBox pbPlayerPhotos;
        private Label lblName;
        private Label lblRating;
        private Label lblAssists;
        private Label lblTeam;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblPointsPerGame;
        private Label lblPosition;
        private Label label7;
    }
}
