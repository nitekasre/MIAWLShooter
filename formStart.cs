using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooter
{
    public partial class formStart : Form
    {
        public formStart()
        {
            InitializeComponent();
        }

        #region GameStartButon
        private void btnEnter_Click_1(object sender, EventArgs e)
        {
           //opens the game 
           formGame openGame = new formGame();
            openGame.Show();
            this.Hide();
        }
        #endregion

        private void frmStart_Click(object sender, EventArgs e)
        {

        }
    }
}
