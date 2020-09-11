using System;
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
    public partial class frmTwoPlayers : Form
    {
        public frmTwoPlayers()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (txtPlayerOne.Text == "")
            {
                errorMessage("Người chơi 1 chưa nhập tên!");
                return;
            }
            if (txtPlayerTwo.Text == "")
            {
                errorMessage("Người chơi 2 chưa nhập tên!");
                return;
            }
            if (txtPlayerOne.Text == txtPlayerTwo.Text)
            {
                errorMessage("Tên hai người chơi không được trùng nhau!");
                return;
            }
            if (rdbXStar.Checked == false && rdbOLove.Checked == false)
            {
                errorMessage("Người chơi 1 chưa chọn quân cờ!");
                return;
            }
            if (cbbLuotDi.SelectedItem == null)
            {
                errorMessage("Chưa chọn lượt đi!");
                return;
            }
            Image playerOneMark, playerTwoMark;
            if (rdbXStar.Checked == true)
            {
                playerOneMark = ptbXStar.BackgroundImage;
                playerTwoMark = ptbOLove.BackgroundImage;
            }
            else
            {
                playerOneMark = ptbOLove.BackgroundImage;
                playerTwoMark = ptbXStar.BackgroundImage;
            }
            frmGame frmGame;
            if (cbbLuotDi.SelectedItem.ToString() == "Người chơi 1")
                frmGame = new frmGame(txtPlayerOne.Text, txtPlayerTwo.Text, playerOneMark, playerTwoMark, 2, 0);
            else
                frmGame = new frmGame(txtPlayerTwo.Text, txtPlayerOne.Text, playerTwoMark, playerOneMark, 2, 0);
            frmGame.ShowDialog();
            this.Close();
        }

        private void errorMessage(string text)
        {
            MessageBox.Show(text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
