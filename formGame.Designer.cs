
namespace Shooter
{
    partial class formGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGame));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.endPannel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.dataHS = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnGameOver = new System.Windows.Forms.Button();
            this.lblView = new System.Windows.Forms.Label();
            this.picPaused = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.endPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaused)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.BackColor = System.Drawing.Color.Transparent;
            this.lblAmmo.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmmo.Location = new System.Drawing.Point(16, 16);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(106, 39);
            this.lblAmmo.TabIndex = 0;
            this.lblAmmo.Text = "Ammo: 0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(192, 16);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 39);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Kills: 0";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHealth.Location = new System.Drawing.Point(536, 16);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(94, 39);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health: ";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(640, 16);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(256, 40);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainTimerEvent);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Shooter.Properties.Resources.shooter_up1;
            this.player.Location = new System.Drawing.Point(416, 560);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(88, 88);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // endPannel
            // 
            this.endPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("endPannel.BackgroundImage")));
            this.endPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.endPannel.Controls.Add(this.pictureBox1);
            this.endPannel.Controls.Add(this.btnSave);
            this.endPannel.Controls.Add(this.txtPlayer);
            this.endPannel.Controls.Add(this.dataHS);
            this.endPannel.Controls.Add(this.btnExit);
            this.endPannel.Controls.Add(this.btnPlay);
            this.endPannel.Location = new System.Drawing.Point(0, 0);
            this.endPannel.Name = "endPannel";
            this.endPannel.Size = new System.Drawing.Size(928, 664);
            this.endPannel.TabIndex = 5;
            this.endPannel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(264, 456);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(352, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 80);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer.Location = new System.Drawing.Point(384, 472);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(200, 32);
            this.txtPlayer.TabIndex = 3;
            this.txtPlayer.Leave += new System.EventHandler(this.txtPlayer_Leave);
            // 
            // dataHS
            // 
            this.dataHS.AllowUserToDeleteRows = false;
            this.dataHS.AllowUserToOrderColumns = true;
            this.dataHS.AllowUserToResizeColumns = false;
            this.dataHS.AllowUserToResizeRows = false;
            this.dataHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHS.BackgroundColor = System.Drawing.Color.Tan;
            this.dataHS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataHS.EnableHeadersVisualStyles = false;
            this.dataHS.Location = new System.Drawing.Point(248, 192);
            this.dataHS.MultiSelect = false;
            this.dataHS.Name = "dataHS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataHS.RowHeadersVisible = false;
            this.dataHS.Size = new System.Drawing.Size(336, 256);
            this.dataHS.TabIndex = 2;
            this.dataHS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataHS_Scroll);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(616, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 151);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(616, 192);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(168, 160);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnGameOver
            // 
            this.btnGameOver.BackColor = System.Drawing.Color.Transparent;
            this.btnGameOver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGameOver.BackgroundImage")));
            this.btnGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGameOver.FlatAppearance.BorderSize = 0;
            this.btnGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameOver.Location = new System.Drawing.Point(368, 0);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(128, 88);
            this.btnGameOver.TabIndex = 6;
            this.btnGameOver.UseVisualStyleBackColor = false;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.BackColor = System.Drawing.Color.Transparent;
            this.lblView.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblView.Location = new System.Drawing.Point(400, 88);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(75, 20);
            this.lblView.TabIndex = 7;
            this.lblView.Text = "View Scores";
            // 
            // picPaused
            // 
            this.picPaused.BackColor = System.Drawing.Color.Transparent;
            this.picPaused.Image = ((System.Drawing.Image)(resources.GetObject("picPaused.Image")));
            this.picPaused.Location = new System.Drawing.Point(344, 256);
            this.picPaused.Name = "picPaused";
            this.picPaused.Size = new System.Drawing.Size(200, 100);
            this.picPaused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPaused.TabIndex = 6;
            this.picPaused.TabStop = false;
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.picPaused);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.endPannel);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblAmmo);
            this.DoubleBuffered = true;
            this.Name = "formGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monsters in a Wasteland";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.endPannel.ResumeLayout(false);
            this.endPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaused)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel endPannel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.DataGridView dataHS;
        private System.Windows.Forms.Button btnGameOver;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picPaused;
    }
}