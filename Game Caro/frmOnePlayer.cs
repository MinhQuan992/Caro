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
    public partial class frmOnePlayer : Form
    {
        public frmOnePlayer()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (txtPlayer.Text == "")
            {
                errorMessage("Bạn chưa nhập tên!");
                return;
            }
            if (txtPlayer.Text == "Máy tính")
            {
                errorMessage("Bạn không được đặt tên này!");
                return;
            }
            if (rdbXStar.Checked == false && rdbOLove.Checked == false)
            {
                errorMessage("Bạn chưa chọn quân cờ!");
                return;
            }
            if (cbbLuotDi.SelectedItem == null)
            {
                errorMessage("Bạn chưa chọn lượt đi!");
                return;
            }
            if(cbbLevel.SelectedItem == null)
            {
                errorMessage("Bạn chưa chọn cấp độ!");
                return;
            }
            Image playerMark, computerMark;
            if (rdbXStar.Checked == true)
            {
                playerMark = ptbXStar.BackgroundImage;
                computerMark = ptbOLove.BackgroundImage;
            }
            else
            {
                playerMark = ptbOLove.BackgroundImage;
                computerMark = ptbXStar.BackgroundImage;
            }
            int level;
            if (cbbLevel.SelectedItem.ToString() == "Level 1")
                level = 1;
            else if (cbbLevel.SelectedItem.ToString() == "Level 2")
                level = 2;
            else if (cbbLevel.SelectedItem.ToString() == "Level 3")
                level = 3;
            else if (cbbLevel.SelectedItem.ToString() == "Level 4")
                level = 4;
            else
                level = 5;
            frmGame frmGame;
            if (cbbLuotDi.SelectedItem.ToString() == "Đi trước")
                frmGame = new frmGame(txtPlayer.Text, "Máy tính", playerMark, computerMark, 1, level);
            else
                frmGame = new frmGame("Máy tính", txtPlayer.Text, computerMark, playerMark, 1, level);
            frmGame.ShowDialog();
            this.Close();
        }

        private void errorMessage(string text)
        {
            MessageBox.Show(text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
