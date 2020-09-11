using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public class BoardManager
    {
        #region Properties
        private Panel board;
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox playerMark;
        private int numberOfPlayers;
        private int level;
        private List<List<Button>> matrix;
        private Stack<PlayInfo> timeLine;
        private event EventHandler endedGame;

        public Panel Board { get => board; set => board = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public int NumberOfPlayers { get => numberOfPlayers; set => numberOfPlayers = value; }
        public int Level { get => level; set => level = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public Stack<PlayInfo> TimeLine { get => timeLine; set => timeLine = value; }
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        #endregion

        #region Initialize
        public BoardManager(Panel board, TextBox playerName, PictureBox playerMark, string playerOne, string playerTwo, Image playerOneMark, Image playerTwoMark, int numberOfPlayers, int level)
        {
            Board = board;
            Player = new List<Player>()
            {
                new Player(playerOne,playerOneMark),
                new Player(playerTwo,playerTwoMark)
            };
            PlayerName = playerName;
            PlayerMark = playerMark;
            NumberOfPlayers = numberOfPlayers;
            Level = level;
        }
        #endregion

        #region Methods
        public void drawBoard()
        {
            board.Enabled = true;
            board.Controls.Clear();
            TimeLine = new Stack<PlayInfo>();
            CurrentPlayer = 0;
            changePlayer();
            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constant.LENGTH; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= Constant.LENGTH; j++)
                {
                    Button newButton = new Button()
                    {
                        Width = Constant.WIDTH,
                        Height = Constant.HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString(),
                        BackColor = Color.FromArgb(200, 200, 200)
                    };
                    newButton.Click += NewButton_Click;
                    Board.Controls.Add(newButton);
                    Matrix[i].Add(newButton);
                    oldButton = newButton;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Constant.HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
            setValueForArrayScore();
            if (NumberOfPlayers == 1 && Player[0].Name == "Máy tính")
            {
                Point point = getCoordinateOfComputerChess();
                Button computerChess = Matrix[point.X][point.Y];
                computerChess.BackgroundImage = Player[CurrentPlayer].Mark;
                computerChess.BackColor = Color.Aqua;
                TimeLine.Push(new PlayInfo(getPoint(computerChess), CurrentPlayer));
                CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
                changePlayer();
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackgroundImage != null)
                return;
            button.BackgroundImage = Player[CurrentPlayer].Mark;
            button.BackColor = Color.White;
            if (isEndGame(button))
            {
                endGame(CurrentPlayer, button);
                return;
            }
            TimeLine.Push(new PlayInfo(getPoint(button), CurrentPlayer));
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            changePlayer();
            if (NumberOfPlayers == 1)
            {
                Point point = getCoordinateOfComputerChess();
                Button computerChess = Matrix[point.X][point.Y];
                computerChess.BackgroundImage = Player[CurrentPlayer].Mark;
                computerChess.BackColor = Color.Aqua;
                if (isEndGame(computerChess))
                {
                    endGame(CurrentPlayer, computerChess);
                    return;
                }
                TimeLine.Push(new PlayInfo(getPoint(computerChess), CurrentPlayer));
                CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
                changePlayer();
            }
        }

        private Point getPoint(Button button)
        {
            int y = Convert.ToInt32(button.Tag);
            int x = Matrix[y].IndexOf(button);
            Point point = new Point(x, y);
            return point;
        }

        private bool isEndGame(Button button)
        {
            if (isEndHorizontal(button) || isEndVertical(button) || isEndMainDiagonal(button) || isEndSubDiagonal(button))
                return true;
            if (isDrawGame())
                return true;
            return false;
        }

        private bool isEndHorizontal(Button button)
        {
            Point point = getPoint(button);
            int countLeft = 0;
            for (int j = point.X; j >= 0; j--)
                if (Matrix[point.Y][j].BackgroundImage == button.BackgroundImage)
                    countLeft++;
                else
                    break;
            int countRight = 0;
            for (int j = point.X + 1; j < Constant.LENGTH; j++)
                if (Matrix[point.Y][j].BackgroundImage == button.BackgroundImage)
                    countRight++;
                else
                    break;
            return countLeft + countRight == 5;
        }

        private bool isEndVertical(Button button)
        {
            Point point = getPoint(button);
            int countUp = 0;
            for (int i = point.Y; i >= 0; i--)
                if (Matrix[i][point.X].BackgroundImage == button.BackgroundImage)
                    countUp++;
                else
                    break;
            int countDown = 0;
            for (int i = point.Y + 1; i < Constant.LENGTH; i++)
                if (Matrix[i][point.X].BackgroundImage == button.BackgroundImage)
                    countDown++;
                else
                    break;
            return countUp + countDown == 5;
        }

        private bool isEndMainDiagonal(Button button)
        {
            Point point = getPoint(button);
            int countUp = 0;
            for (int i = point.Y, j = point.X; i >= 0 && j >= 0; i--, j--)
                if (Matrix[i][j].BackgroundImage == button.BackgroundImage)
                    countUp++;
                else
                    break;
            int countDown = 0;
            for (int i = point.Y + 1, j = point.X + 1; i < Constant.LENGTH && j < Constant.LENGTH; i++, j++)
                if (Matrix[i][j].BackgroundImage == button.BackgroundImage)
                    countDown++;
                else
                    break;
            return countUp + countDown == 5;
        }

        private bool isEndSubDiagonal(Button button)
        {
            Point point = getPoint(button);
            int countUp = 0;
            for (int i = point.Y, j = point.X; i >= 0 && j < Constant.LENGTH; i--, j++)
                if (Matrix[i][j].BackgroundImage == button.BackgroundImage)
                    countUp++;
                else
                    break;
            int countDown = 0;
            for (int i = point.Y + 1, j = point.X - 1; i < Constant.LENGTH && j >= 0; i++, j--)
                if (Matrix[i][j].BackgroundImage == button.BackgroundImage)
                    countDown++;
                else
                    break;
            return countUp + countDown == 5;
        }

        private bool isDrawGame()
        {
            for (int i = 0; i < Constant.LENGTH; i++)
                for (int j = 0; j < Constant.LENGTH; j++)
                    if (Matrix[i][j].BackgroundImage == null)
                        return false;
            return true;
        }

        public bool undo()
        {
            if ((NumberOfPlayers == 1 && Player[0].Name == "Máy tính" && TimeLine.Count <= 1) || TimeLine.Count <= 0)
                return false;
            if (NumberOfPlayers == 1)
            {
                PlayInfo oldButton;
                Button btn;

                oldButton = TimeLine.Pop();
                btn = Matrix[oldButton.Point.Y][oldButton.Point.X];
                btn.BackgroundImage = null;
                btn.BackColor = Color.FromArgb(200, 200, 200);

                oldButton = TimeLine.Pop();
                btn = Matrix[oldButton.Point.Y][oldButton.Point.X];
                btn.BackgroundImage = null;
                btn.BackColor = Color.FromArgb(200, 200, 200);
            }
            else
            {
                PlayInfo oldPoint = TimeLine.Pop();
                Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];
                btn.BackgroundImage = null;
                btn.BackColor = Color.FromArgb(200, 200, 200);
                if (TimeLine.Count <= 0)
                    CurrentPlayer = 0;
                else
                    CurrentPlayer = timeLine.Peek().CurrentPlayer == 1 ? 0 : 1;
                changePlayer();
            }
            return true;
        }

        private void endGame(int currentPlayer, Button button)
        {
            if (isDrawGame())
                MessageBox.Show("Cả 2 người chơi hòa nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (isEndHorizontal(button))
                {
                    Point point = getPoint(button);
                    int i = 0;
                    while (point.X + i < Constant.LENGTH && Matrix[point.Y][point.X + i].BackgroundImage == button.BackgroundImage)
                    {
                        Matrix[point.Y][point.X + i].BackColor = Color.MediumSeaGreen;
                        i++;
                    }
                    i = 1;
                    while (point.X - i >= 0 && Matrix[point.Y][point.X - i].BackgroundImage == button.BackgroundImage)
                    {
                        Matrix[point.Y][point.X - i].BackColor = Color.MediumSeaGreen;
                        i++;
                    }
                }
                else if (isEndVertical(button))
                {
                    Point point = getPoint(button);
                    int i = 0;
                    while (point.Y + i < Constant.LENGTH && Matrix[point.Y + i][point.X].BackgroundImage == button.BackgroundImage)
                    {
                        Matrix[point.Y + i][point.X].BackColor = Color.MediumSeaGreen;
                        i++;
                    }
                    i = 1;
                    while (point.Y - i >= 0 && Matrix[point.Y - i][point.X].BackgroundImage == button.BackgroundImage)
                    {
                        Matrix[point.Y - i][point.X].BackColor = Color.MediumSeaGreen;
                        i++;
                    }
                }
                else if (isEndMainDiagonal(button))
                {
                    Point point = getPoint(button);
                    int i = 0;
                    while (point.Y + i < Constant.LENGTH && point.X + i < Constant.LENGTH && Matrix[point.Y + i][point.X + i].BackgroundImage == button.BackgroundImage)
                    {
                        Matrix[point.Y + i][point.X + i].BackColor = Color.MediumSeaGreen;
                        i++;
                    }
                    i = 1;
                    while (point.Y - i >= 0 && point.X - i >= 0 && Matrix[point.Y - i][point.X - i].BackgroundImage == button.BackgroundImage)
                    {
                        Matrix[point.Y - i][point.X - i].BackColor = Color.MediumSeaGreen;
                        i++;
                    }
                }
                else if (isEndSubDiagonal(button))
                {
                    Point point = getPoint(button);
                    int i = 0;
                    while (point.Y + i < Constant.LENGTH && point.X - i >= 0 && Matrix[point.Y + i][point.X - i].BackgroundImage == button.BackgroundImage)
                    {
                        Matrix[point.Y + i][point.X - i].BackColor = Color.MediumSeaGreen;
                        i++;
                    }
                    i = 1;
                    while (point.Y - i >= 0 && point.X + i < Constant.LENGTH && Matrix[point.Y - i][point.X + i].BackgroundImage == button.BackgroundImage)
                    {
                        Matrix[point.Y - i][point.X + i].BackColor = Color.MediumSeaGreen;
                        i++;
                    }
                }
                if (endedGame != null)
                    endedGame(this, new EventArgs());
                MessageBox.Show(Player[CurrentPlayer].Name + " đã thắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void changePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion

        #region Play with computer

        #region Set value for array score
        private int[] attackScore;
        private int[] defenseScore;

        private void setValueForArrayScore()
        {
            if (Level == 1)
            {
                attackScore = new int[7] { 0, 10, 30, 50, 200, 3000, 10000 };
                defenseScore = new int[7] { 0, 5, 10, 10, 10, 10, 10 };
            }
            else if (Level == 2)
            {
                attackScore = new int[7] { 0, 4, 13, 434, 234, 2434, 42332 };
                defenseScore = new int[7] { 0, 5, 3, 81, 42, 6561, 1221 };
            }
            else if (Level == 3)
            {
                attackScore = new int[7] { 0, 3, 24, 192, 1536, 12288, 98304 };
                defenseScore = new int[7] { 0, 1, 9, 81, 729, 6561, 59049 };
            }
            else if (Level == 4)
            {
                attackScore = new int[7] { 0, 9, 54, 162, 1458, 13112, 118008 };
                defenseScore = new int[7] { 0, 3, 27, 99, 729, 6561, 59049 };
            }
            else
            {
                attackScore = new int[7] { 0, 13, 34, 202, 1546, 12298, 98314 };
                defenseScore = new int[7] { 0, 3, 9, 81, 729, 6561, 59049 };
            }
        }
        #endregion

        #region Attack
        public int attackHorizonal(int currentRow, int currentCol)
        {
            int score = 0;
            int ourChess = 0;
            int enemyChess = 0;
            for (int i = 1; i < 6 && currentCol - i >= 0; i++)
            {
                if (Matrix[currentRow][currentCol - i].BackColor == Color.White)
                    ourChess++;
                else if (Matrix[currentRow][currentCol - i].BackColor == Color.Aqua)
                {
                    enemyChess++;
                    break;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && currentCol + i < Constant.LENGTH; i++)
            {
                if (Matrix[currentRow][currentCol + i].BackColor == Color.White)
                    ourChess++;
                else if (Matrix[currentRow][currentCol + i].BackColor == Color.Aqua)
                {
                    enemyChess++;
                    break;
                }
                else
                    break;
            }
            if (enemyChess == 2)
                return 0;
            score -= defenseScore[enemyChess + 1] * 2;
            score += attackScore[ourChess];
            return score;
        }

        public int attackVertical(int currentRow, int currentCol)
        {
            int score = 0;
            int ourChess = 0;
            int enemyChess = 0;
            for (int i = 1; i < 6 && currentRow - i >= 0; i++)
            {
                if (Matrix[currentRow - i][currentCol].BackColor == Color.White)
                    ourChess++;
                else if (Matrix[currentRow - i][currentCol].BackColor == Color.Aqua)
                {
                    enemyChess++;
                    break;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && currentRow + i < Constant.LENGTH; i++)
            {
                if (Matrix[currentRow + i][currentCol].BackColor == Color.White)
                    ourChess++;
                else if (Matrix[currentRow + i][currentCol].BackColor == Color.Aqua)
                {
                    enemyChess++;
                    break;
                }
                else
                    break;
            }
            if (enemyChess == 2)
                return 0;
            score -= defenseScore[enemyChess + 1] * 2;
            score += attackScore[ourChess];
            return score;
        }

        public int attackSubDiagonal(int currentRow, int currentCol)
        {
            int score = 0;
            int ourChess = 0;
            int enemyChess = 0;
            for (int i = 1; i < 6 && currentRow - i >= 0 && currentCol + i < Constant.LENGTH; i++)
            {
                if (Matrix[currentRow - i][currentCol + i].BackColor == Color.White)
                    ourChess++;
                else if (Matrix[currentRow - i][currentCol + i].BackColor == Color.Aqua)
                {
                    enemyChess++;
                    break;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && currentRow + i < Constant.LENGTH && currentCol - i >= 0; i++)
            {
                if (Matrix[currentRow + i][currentCol - i].BackColor == Color.White)
                    ourChess++;
                else if (Matrix[currentRow + i][currentCol - i].BackColor == Color.Aqua)
                {
                    enemyChess++;
                    break;
                }
                else
                    break;
            }
            if (enemyChess == 2)
                return 0;
            score -= defenseScore[enemyChess + 1] * 2;
            score += attackScore[ourChess];
            return score;
        }

        public int attackMainDiagonal(int currentRow, int currentCol)
        {
            int score = 0;
            int ourChess = 0;
            int enemyChess = 0;
            for (int i = 1; i < 6 && currentRow - i >= 0 && currentCol - i >= 0; i++)
            {
                if (Matrix[currentRow - i][currentCol - i].BackColor == Color.White)
                    ourChess++;
                else if (Matrix[currentRow - i][currentCol - i].BackColor == Color.Aqua)
                {
                    enemyChess++;
                    break;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && currentRow + i < Constant.LENGTH && currentCol + i < Constant.LENGTH; i++)
            {
                if (Matrix[currentRow + i][currentCol + i].BackColor == Color.White)
                    ourChess++;
                else if (Matrix[currentRow + i][currentCol + i].BackColor == Color.Aqua)
                {
                    enemyChess++;
                    break;
                }
                else
                    break;
            }
            if (enemyChess == 2)
                return 0;
            score -= defenseScore[enemyChess + 1] * 2;
            score += attackScore[ourChess];
            return score;
        }
        #endregion

        #region Defense
        public int defenseHorizonal(int currentRow, int currentCol)
        {
            int score = 0;
            int ourChess = 0;
            int enemyChess = 0;
            for (int i = 1; i < 6 && currentCol - i >= 0; i++)
            {
                if (Matrix[currentRow][currentCol - i].BackColor == Color.White)
                {
                    ourChess++;
                    break;
                }
                else if (Matrix[currentRow][currentCol - i].BackColor == Color.Aqua)
                    enemyChess++;
                else
                    break;
            }
            for (int i = 1; i < 6 && currentCol + i < Constant.LENGTH; i++)
            {
                if (Matrix[currentRow][currentCol + i].BackColor == Color.White)
                {
                    ourChess++;
                    break;
                }
                else if (Matrix[currentRow][currentCol + i].BackColor == Color.Aqua)
                    enemyChess++;
                else
                    break;
            }
            if (ourChess == 2)
                return 0;
            score += defenseScore[enemyChess];
            return score;
        }

        public int defenseVertical(int currentRow, int currentCol)
        {
            int score = 0;
            int ourChess = 0;
            int enemyChess = 0;
            for (int i = 1; i < 6 && currentRow - i >= 0; i++)
            {
                if (Matrix[currentRow - i][currentCol].BackColor == Color.White)
                {
                    ourChess++;
                    break;
                }
                else if (Matrix[currentRow - i][currentCol].BackColor == Color.Aqua)
                    enemyChess++;
                else
                    break;
            }
            for (int i = 1; i < 6 && currentRow + i < Constant.LENGTH; i++)
            {
                if (Matrix[currentRow + i][currentCol].BackColor == Color.White)
                {
                    ourChess++;
                    break;
                }
                else if (Matrix[currentRow + i][currentCol].BackColor == Color.Aqua)
                    enemyChess++;
                else
                    break;
            }
            if (ourChess == 2)
                return 0;
            score += defenseScore[enemyChess];
            return score;
        }

        public int defenseSubDiagonal(int currentRow, int currentCol)
        {
            int score = 0;
            int ourChess = 0;
            int enemyChess = 0;
            for (int i = 1; i < 6 && currentRow - i >= 0 && currentCol + i < Constant.LENGTH; i++)
            {
                if (Matrix[currentRow - i][currentCol + i].BackColor == Color.White)
                {
                    ourChess++;
                    break;
                }
                else if (Matrix[currentRow - i][currentCol + i].BackColor == Color.Aqua)
                    enemyChess++;
                else
                    break;
            }
            for (int i = 1; i < 6 && currentRow + i < Constant.LENGTH && currentCol - i >= 0; i++)
            {
                if (Matrix[currentRow + i][currentCol - i].BackColor == Color.White)
                {
                    ourChess++;
                    break;
                }
                else if (Matrix[currentRow + i][currentCol - i].BackColor == Color.Aqua)
                    enemyChess++;
                else
                    break;
            }
            if (ourChess == 2)
                return 0;
            score += defenseScore[enemyChess];
            return score;
        }

        public int defenseMainDiagonal(int currentRow, int currentCol)
        {
            int score = 0;
            int ourChess = 0;
            int enemyChess = 0;
            for (int i = 1; i < 6 && currentRow - i >= 0 && currentCol - i >= 0; i++)
            {
                if (Matrix[currentRow - i][currentCol - i].BackColor == Color.White)
                {
                    ourChess++;
                    break;
                }
                else if (Matrix[currentRow - i][currentCol - i].BackColor == Color.Aqua)
                    enemyChess++;
                else
                    break;
            }
            for (int i = 1; i < 6 && currentRow + i < Constant.LENGTH && currentCol + i < Constant.LENGTH; i++)
            {
                if (Matrix[currentRow + i][currentCol + i].BackColor == Color.White)
                {
                    ourChess++;
                    break;
                }
                else if (Matrix[currentRow + i][currentCol + i].BackColor == Color.Aqua)
                    enemyChess++;
                else
                    break;
            }
            if (ourChess == 2)
                return 0;
            score += defenseScore[enemyChess];
            return score;
        }
        #endregion

        #region Cắt tỉa Alpha-Beta
        bool catTiaNgang(int currentRow, int currentCol)
        {
            if (currentCol < Constant.LENGTH - 5)
                for (int i = 1; i < 6; i++)
                    if (Matrix[currentRow][currentCol + i].BackColor != Color.FromArgb(200, 200, 200))
                        return false;
            if (currentCol > 4)
                for (int i = 1; i < 6; i++)
                    if (Matrix[currentRow][currentCol - i].BackColor != Color.FromArgb(200, 200, 200))
                        return false;
            return true;
        }

        bool catTiaDoc(int currentRow, int currentCol)
        {
            if (currentRow > 4)
                for (int i = 1; i < 6; i++)
                    if (Matrix[currentRow - i][currentCol].BackColor != Color.FromArgb(200, 200, 200))
                        return false;
            if (currentRow < Constant.LENGTH - 5)
                for (int i = 1; i < 6; i++)
                    if (Matrix[currentRow + i][currentCol].BackColor != Color.FromArgb(200, 200, 200))
                        return false;
            return true;
        }

        bool catTiaCheoChinh(int currentRow, int currentCol)
        {
            if (currentRow > 4 && currentCol > 4)
                for (int i = 1; i < 6; i++)
                    if (Matrix[currentRow - i][currentCol - i].BackColor != Color.FromArgb(200, 200, 200))
                        return false;
            if (currentRow < Constant.LENGTH - 5 && currentCol < Constant.LENGTH - 5)
                for (int i = 1; i < 6; i++)
                    if (Matrix[currentRow + i][currentCol + i].BackColor != Color.FromArgb(200, 200, 200))
                        return false;
            return true;
        }

        bool catTiaCheoPhu(int currentRow, int currentCol)
        {
            if (currentRow > 4 && currentCol < Constant.LENGTH - 5)
                for (int i = 1; i < 6; i++)
                    if (Matrix[currentRow - i][currentCol + i].BackColor != Color.FromArgb(200, 200, 200))
                        return false;
            if (currentRow < Constant.LENGTH - 5 && currentCol > 4)
                for (int i = 1; i < 6; i++)
                    if (Matrix[currentRow + i][currentCol - i].BackColor != Color.FromArgb(200, 200, 200))
                        return false;
            return true;
        }

        bool catTia(int currentRow, int currentCol)
        {
            if (catTiaNgang(currentRow, currentCol) && catTiaDoc(currentRow, currentCol) && catTiaCheoChinh(currentRow, currentCol) && catTiaCheoPhu(currentRow, currentCol))
                return true;
            return false;
        }
        #endregion

        #region Máy đánh
        private Point getCoordinateOfComputerChess()
        {
            Point point = new Point();
            int maxScore = 0, attackScore = 0, defenseScore = 0;
            if ((Player[0].Name == "Máy tính" && TimeLine.Count == 0) || (Player[1].Name == "Máy tính" && TimeLine.Count == 1))
            {
                do
                {
                    Random random = new Random();
                    point.X = random.Next(Constant.LENGTH / 2 - 3, Constant.LENGTH / 2 + 3);
                    point.Y = random.Next(Constant.LENGTH / 2 - 3, Constant.LENGTH / 2 + 3);
                } while (Matrix[point.Y][point.X].BackgroundImage != null);
            }
            else
                for (int i = 0; i < Constant.LENGTH; i++)
                    for (int j = 0; j < Constant.LENGTH; j++)
                        if (Matrix[i][j].BackColor == Color.FromArgb(200, 200, 200) && !catTia(i, j))
                        {
                            int tempScore = 0;
                            attackScore = attackHorizonal(i, j) + attackVertical(i, j) + attackMainDiagonal(i, j) + attackSubDiagonal(i, j);
                            defenseScore = defenseHorizonal(i, j) + defenseVertical(i, j) + defenseMainDiagonal(i, j) + defenseSubDiagonal(i, j);
                            tempScore = attackScore > defenseScore ? attackScore : defenseScore;
                            if (maxScore < tempScore)
                            {
                                maxScore = tempScore;
                                point.X = i;
                                point.Y = j;
                            }
                        }
            return point;
        }
        #endregion

        #endregion
    }
}
