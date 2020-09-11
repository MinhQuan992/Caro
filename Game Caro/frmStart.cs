﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }


        private void BtnOnePlayer_Click(object sender, EventArgs e)
        {
            frmOnePlayer frmOnePlayer = new frmOnePlayer();
            frmOnePlayer.ShowDialog();
        }

        private void BtnTwoPlayers_Click(object sender, EventArgs e)
        {
            frmTwoPlayers frmTwoPlayers = new frmTwoPlayers();
            frmTwoPlayers.ShowDialog();
        }
    }
}
