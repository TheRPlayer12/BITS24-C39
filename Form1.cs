
namespace BITS24_C39
{
    public partial class Form1 : Form
    {
        private List<string> cards = new List<string> {
            "1", "1", "2", "2", "3", "3", "4", "4"
        };
        private PictureBox Clicked1 = null;
        private PictureBox Clicked2 = null;
        private int attempts = 0;
        private int matches = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            Shuffle();
            for (int i = 0; i < cards.Count; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 170);
                pictureBox.Image = Properties.Resources.card_back;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Tag = cards[i];
                pictureBox.Click += PictureBox_Click;
                flowLayoutPanel.Controls.Add(pictureBox);
            }
        }

        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                string temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (Clicked1 == null)
            {
                Clicked1 = clickedPictureBox;
                Clicked1.Image = GetImage(Clicked1.Tag.ToString());
            }
            else
            {
                Clicked2 = clickedPictureBox;
                Clicked2.Image = GetImage(Clicked2.Tag.ToString());
                attempts++;

                if (Clicked1.Tag.ToString() == Clicked2.Tag.ToString())
                {
                    matches++;
                    Clicked1 = null;
                    Clicked2 = null;
                }
                else
                {
                    timer1.Start();
                }
            }


            UpdateUI();

            if (matches == 4 && attempts <= 6)
            {
                MessageBox.Show("You won!");
            }
            if (attempts > 6)
            {
                MessageBox.Show("You Loose :(");
                Application.Restart();
            }
        }

        private void UpdateUI()
        {
            Attempts_Lbl.Text = attempts.ToString();
            Matches_Lbl.Text = matches.ToString();
        }

        private Image GetImage(string card)
        {
            string imageName = "_" + card;

            if (Properties.Resources.ResourceManager.GetObject(imageName) != null)
            {
                return Properties.Resources.ResourceManager.GetObject(imageName) as Image;
            }
            else
            {
                return Properties.Resources.def_img;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Clicked1.Image = Properties.Resources.card_back;
            Clicked2.Image = Properties.Resources.card_back;
            Clicked1 = null;
            Clicked2 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
