using Microsoft.VisualBasic;

namespace wfaMemory
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 30;
        int countDownTime;
        bool gameOver = false;
        int correctMatches = 0;

        Menu menu;
        public Form1(Menu Menu)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            menu = Menu;
            LoadPictures();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDownTime--;
            label2.Text = "Осталось времени: " + countDownTime;

            if (countDownTime < 1)
            {
                GameOver("Время вышло, вы прогирали ");
                foreach (PictureBox x in pictures)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics/" + (string)x.Tag + ".png");
                    }
                }
            }
        }
        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();

        }
        private void LoadPictures()
        {
            int leftPos = 40;
            int topPos = 40;
            int rows = 0;

            for (int i = 0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 70;
                newPic.Width = 70;
                newPic.BackColor = Color.Purple;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 3)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 80;
                }

                if (rows == 3)
                {
                    leftPos = 40;
                    topPos += 80;
                    rows = 0;
                }
            }
            RestartGame();
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("pics/" + (string)picA.Tag + ".png");
                    firstChoice = (string)picA.Tag;
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;
                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("pics/" + (string)picB.Tag + ".png");
                    secondChoice = (string)picB.Tag;
                }
            }
            else
            {
                CheckPictures(picA, picB);
            }

        }

        private void RestartGame()
        {
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            numbers = randomList;
            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            tries = 0;
            label1.Text = "Количество попыток: " + tries;
            label2.Text = "Осталось времени: " + totalTime;
            gameOver = false;
            timer1.Start();
            countDownTime = totalTime;

        }
        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if (firstChoice == secondChoice)
            {
                A.Tag = null;
                B.Tag = null;
                correctMatches++;
            }
            else
            {
                tries++;
                label1.Text = "Количество попыток: " + tries;
            }
            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            //if (pictures.All(o => o.Tag == pictures[0].Tag))
            //{
            //    GameOver("Great work!");
            //}
            if (correctMatches == pictures.Count() / 2)
            {
                GameOver("Вы молодец!");
            }


        }
        private void GameOver(string msg)
        {
            timer1.Stop();
            gameOver = true;
            MessageBox.Show(msg + " \nНажмите Перезапустить, чтобы начать снова");
            correctMatches = 0;
        }

    }
}