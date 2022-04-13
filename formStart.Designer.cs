
namespace Shooter
{
    partial class formStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStart));
            this.btnStart = new System.Windows.Forms.Button();
            this.frmStart = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.frmStart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(648, 488);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // frmStart
            // 
            this.frmStart.BackColor = System.Drawing.Color.Transparent;
            this.frmStart.Image = ((System.Drawing.Image)(resources.GetObject("frmStart.Image")));
            this.frmStart.Location = new System.Drawing.Point(-24, 0);
            this.frmStart.Name = "frmStart";
            this.frmStart.Size = new System.Drawing.Size(940, 700);
            this.frmStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.frmStart.TabIndex = 4;
            this.frmStart.TabStop = false;
            this.frmStart.Click += new System.EventHandler(this.frmStart_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Location = new System.Drawing.Point(376, 504);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(144, 64);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click_1);
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.Tan;
            this.txtInstructions.Font = new System.Drawing.Font("Agency FB", 15.75F);
            this.txtInstructions.Location = new System.Drawing.Point(200, 208);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(496, 264);
            this.txtInstructions.TabIndex = 8;
            this.txtInstructions.Text = "GAME INSTRUCTIONS:\n \nNavigate with UP, DOWN, LEFT & RIGHT arrow keys\n\nAmmo drops " +
    "will come after you run out!\n\nPress P to pause and R to resume.\n\nTry not to die." +
    " Good luck! :D";
            // 
            // formStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.frmStart);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Name = "formStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monsters in a Wasteland";
            ((System.ComponentModel.ISupportInitialize)(this.frmStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox frmStart;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.RichTextBox txtInstructions;
    }
}

