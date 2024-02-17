namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int boruhizi = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void gameTimerEvent(object sender, EventArgs e)
        {

            FlaffyBird.Top += gravity;
            BoruAlt.Left -= boruhizi;
            Boru‹st.Left -= boruhizi;
            ScoreText.Text = "Score: " + score;
            if(BoruAlt.Left <-150 )
            {
                BoruAlt.Left = 800;
                score++;
            }
            if (Boru‹st.Left < -180)
            {
                Boru‹st.Left = 950;
                score++;
            }
            if (FlaffyBird.Bounds.IntersectsWith(BoruAlt.Bounds) || FlaffyBird.Bounds.IntersectsWith(Boru‹st.Bounds) || FlaffyBird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endGame();
            }
            if (score>5)
            {
                boruhizi = 15;


            }
            if (score > 10)
            {
                boruhizi = 20;


            }
            if (score > 15)
            {
                boruhizi = 25 ;



            }
            if (score > 20)
            {
                boruhizi = 30;



            }
            if (score > 25)
            {
                boruhizi = 35;



            }
            if (score > 30)
            {
                boruhizi = 40;

            }
            if (score > 35)
            {
                boruhizi = 45;

            }
            if (score > 40)
            {
                boruhizi = 50;  

            }

            if (FlaffyBird.Top <= 25)
            {
                endGame();

            }
            

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Space) 
            {
                gravity = -10;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endGame()
        {
            GameTimer.Stop();
            ScoreText.Text = "Game Over";
        }
    }
}
