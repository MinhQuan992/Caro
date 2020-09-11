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
    public partial class frmGame : Form
    {
        #region Properties
        BoardManager board;
        #endregion

        public frmGame(string playerOne, string playerTwo, Image playerOneMark, Image playerTwoMark, int numberOfPlayers, int level)
        {
            InitializeComponent();
            board = new BoardManager(panelBoard, playerName, playerMark, playerOne, playerTwo, playerOneMark, playerTwoMark, numberOfPlayers, level);
            board.EndedGame += Board_EndedGame;
            newGame();
        }

        private void endGame()
        {
            panelBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            MessageBox.Show("Trò chơi kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Board_EndedGame(object sender, EventArgs e)
        {
            endGame();
        }

        void newGame()
        {
            board.drawBoard();
            undoToolStripMenuItem.Enabled = true;
        }

        void undo()
        {
            board.undo();
        }

        void exit()
        {
            this.Close();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void BtnPlayMusic_Click(object sender, EventArgs e)
        {
            frmMusic frmMusic = new frmMusic();
            frmMusic.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Khi đến lượt mình, người chơi phải chọn vào một ô trên bàn cờ. Người chơi nào có được năm quân cờ liên tiếp theo hàng ngang, hàng dọc hay đường chéo thì người chơi đó thắng.", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}