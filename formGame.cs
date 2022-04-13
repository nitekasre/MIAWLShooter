using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShooterDLL; //allows use of the DLL

namespace Shooter
{
    public partial class formGame : Form
    {
        #region UniversalVariables
        //variables for character directions, health, player&monster speed, score, and a random for monster generation.
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 15;
        int ammo = 10;
        int score;
        int monsterSpeed = 2;
        Random randNum = new Random();
        ScoreRepository repository = new ScoreRepository();
        High_Scores highScores = new High_Scores();

        //creates a list of picture boxes forthe monsters
        List<PictureBox> monsterList = new List<PictureBox>();

        #endregion

        #region FormGame
        public formGame()
        {
            InitializeComponent();

            //uses the RestartGame method to reset the game controls
            SetControls();
        }
        #endregion

        #region SetsGameControls
        private void SetControls()
        {
            gameOver = false;

            //changes the player image from the downed shooter to the shooter facing upward
            player.Image = Properties.Resources.shooter_up1;

            foreach (PictureBox i in monsterList)
            {
                //removes all of the monsters that spawned during the game to reset for spawning in the new game
                this.Controls.Remove(i);
            }

            //clears the monsterList on game restart
            monsterList.Clear();

            //sets the amount of monsters that will spawn at the start of the game
            for (int i = 0; i < 2; i++)
            {
                MakeMonsters();
            }

            //sets movements to false at game start so the player will remain still until moved
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;

            //resets ammo, score, and playerHealth back to default values and starts the game timer
            ammo = 10;
            score = 0;
            playerHealth = 100;
            gameTimer.Start();

            //makes the player visible after it was removed from game over
            player.Visible = true;

            //hides the end pannel & game over button until the game is over
            endPannel.Visible = false;
            lblView.Visible = false;
            btnGameOver.Visible = false;
            picPaused.Visible = false;
        }
        #endregion

        #region MainGameControls
        private void mainTimerEvent(object sender, EventArgs e)
        {
            //controls for: player health & movememnt, ammo drops, monster AI & death

            //diaplays player health as long as it is > 1.
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }

            else
            {
                //replaces the image if the player's health == 0. stops the game timer.
                gameOver = true;
                player.Image = Properties.Resources.deadshooter;
                gameTimer.Stop();

                //makes the buttons visible so the user can go to the scores menu.
                btnGameOver.Visible = true;
                lblView.Visible = true;
            }

            //controls the labels for the score and the ammo count
            lblAmmo.Text = "Ammo: " + ammo;
            lblScore.Text = "Kills: " + score;

            //controls player movement 
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 65)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            //when the playuer makes contact with the ammo drop +5 ammo
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                //controls monster pictures as they chase the player & player health when contact is made
                if (x is PictureBox && (string)x.Tag == "monster")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if (x.Left > player.Left)
                    {
                        x.Left -= monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monster_l;
                    }

                    if (x.Left < player.Left)
                    {
                        x.Left += monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monster_r;
                    }

                    if (x.Top > player.Top)
                    {
                        x.Top -= monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monster_up;
                    }

                    if (x.Top < player.Top)
                    {
                        x.Top += monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monster_d;
                    }
                }

                //controls to kill monsters and remove them from the game after they interact with bullet
                foreach (Control t in this.Controls)
                {
                    if (t is PictureBox && (string)t.Tag == "bullet" && x is PictureBox && (string)x.Tag == "monster")
                    {
                        if (x.Bounds.IntersectsWith(t.Bounds))
                        {
                            //adds one to the score if the monster is hit
                            score++;

                            //removes the monster and bullet from the form and the monster from the monster list
                            //all items are disposed for memory's sake
                            this.Controls.Remove(t);
                            ((PictureBox)t).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            monsterList.Remove(((PictureBox)x));

                            //spawns more monsters
                            MakeMonsters();
                        }
                    }
                }
            }
        }
        #endregion  

        #region KeyIsDown
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.shooter_left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.shooter_right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.shooter_up1;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.shooter_down;
            }

            if (e.KeyCode == Keys.P)
            {
                gameTimer.Stop();
                picPaused.Visible = true;
            }

            if (e.KeyCode == Keys.R)
            {
                gameTimer.Start();
                picPaused.Visible = false;
            }
        }
        #endregion

        #region KeyIsUp
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }
        }


        #endregion

        #region ShootBullet
        private void ShootBullet(string direction)
        {
            //object of the bullet class from the ShooterDLL
            Bullet shootBullet = new Bullet();

            //variable for the bullet's direction of travel
            shootBullet.direction = direction;

            //where the bullet will originate from when the player shoots.
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);

            //function will perform on the formGame form
            shootBullet.MakeBullet(this);
        }
        #endregion

        #region MakeMonsters
        private void MakeMonsters()
        {
            PictureBox monster = new PictureBox();
            monster.Tag = "monster";
            monster.Image = Properties.Resources.monster_d;
            monster.BackColor = Color.Transparent;
            monster.Left = randNum.Next(0, 850);
            monster.Top = randNum.Next(60, 650);
            monster.SizeMode = PictureBoxSizeMode.AutoSize;
            monsterList.Add(monster);
            this.Controls.Add(monster);

            //keeps the monster from overlapping the player
            player.BringToFront();
        }
        #endregion

        #region DropAmmo
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.zammo;
            ammo.BackColor = Color.Transparent;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(60, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(10, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }
        #endregion

        #region GameOverButtonClick
        private void btnGameOver_Click(object sender, EventArgs e)
        {
            endPannel.Visible = true;
            player.Visible = false;
            btnGameOver.Visible = false;
            lblView.Visible = false;

            RefreshGrid();

        }

        #endregion

        #region SaveScore
        private void btnSave_Click(object sender, EventArgs e)
        {
            //generates a new number for the ID for the user
            Random randNumb = new Random();

            if (txtPlayer.Text != string.Empty)
            {
                //adds the new score to the database
                var newscore = new High_Scores();
                newscore.PlayerID = randNumb.Next(1, 900);
                newscore.PlayerName = txtPlayer.Text;
                newscore.PlayerScore = score;
                repository.AddUser(newscore);
                RefreshGrid();
            }

            else
            {
                MessageBox.Show("If you want the bragging rights, you have to tell me your name!", "No name, no rank!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region PlayAgainButton
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //goes back to start and allows the user to enter another name and play again
            Application.Restart();
        }
        #endregion

        #region ExitGameButton
        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        #endregion

        #region DataGridControls
        private void RefreshGrid()
        {
            ShooterGameEntities2 entities = new ShooterGameEntities2();
            //refreshes the grid
            dataHS.DataSource = repository.GetScores().ToList();

            //sort scores


            //grid design elements

            //removes PlayerID, renames the columns and centers all the text
            dataHS.Columns["PlayerID"].Visible = false;
            dataHS.Columns["PlayerName"].HeaderText = "Player";
            this.dataHS.Columns["PlayerName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataHS.Columns["PlayerScore"].HeaderText = "Score";
            this.dataHS.Columns["PlayerScore"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataHS.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
#endregion

        #region PlayerNameTextValidation
        private void txtPlayer_Leave(object sender, EventArgs e)
        {
            if (txtPlayer.TextLength > 15)
            {
                MessageBox.Show("...who picks a username that long!?", "Name must be 15 char or less!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        private void dataHS_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("I mean...I'm no trying to hide your score, buit t wasnt that great", "Go ahead and log off for me :|");
        }
    }
}
