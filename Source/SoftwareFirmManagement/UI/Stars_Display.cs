using System;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{
    public partial class Stars_Display : UserControl
    {
        int stars = 5;
        bool inputMode = false;

        public bool InputMode
        {
            get { return inputMode; }
            set { inputMode = value; }
        }

        public int Stars
        {
            get { return stars; }
            set
            {
                stars = (value < 6 && value > 0) ? value : throw new InvalidOperationException("Starts must be in range 1-5");
                for (int i = 0; i < value; i++)
                {
                    star_list[i].Image = Properties.Resources.Star_filled_;
                }
                for (int i = value; i < star_list.Count; i++)
                {
                    star_list[i].Image = Properties.Resources.Star;
                }

            }
        }
        public Stars_Display()
        {
            InitializeComponent();
        }



        private void star1_Click(object sender, EventArgs e)
        {
            if (inputMode)
            {
                if (stars != 1)
                {
                    star1.Image = Properties.Resources.Star_filled_;
                    star2.Image = Properties.Resources.Star;
                    star3.Image = Properties.Resources.Star;
                    star4.Image = Properties.Resources.Star;
                    star5.Image = Properties.Resources.Star;
                    stars = 1;
                }
            }
        }

        private void star2_Click(object sender, EventArgs e)
        {
            if (inputMode)
            {
                star1.Image = Properties.Resources.Star_filled_;
                star2.Image = Properties.Resources.Star_filled_;
                star3.Image = Properties.Resources.Star;
                star4.Image = Properties.Resources.Star;
                star5.Image = Properties.Resources.Star;
                stars = 2;
            }
        }
        private void star3_Click(object sender, EventArgs e)
        {
            if (inputMode)
            {
                star1.Image = Properties.Resources.Star_filled_;
                star2.Image = Properties.Resources.Star_filled_;
                star3.Image = Properties.Resources.Star_filled_;
                star4.Image = Properties.Resources.Star;
                star5.Image = Properties.Resources.Star;
                stars = 3;
            }
        }

        private void star4_Click(object sender, EventArgs e)
        {
            if (inputMode)
            {
                star1.Image = Properties.Resources.Star_filled_;
                star2.Image = Properties.Resources.Star_filled_;
                star3.Image = Properties.Resources.Star_filled_;
                star4.Image = Properties.Resources.Star_filled_;
                star5.Image = Properties.Resources.Star;
                stars = 4;
            }
        }

        private void star5_Click(object sender, EventArgs e)
        {
            if (inputMode)
            {
                star1.Image = Properties.Resources.Star_filled_;
                star2.Image = Properties.Resources.Star_filled_;
                star3.Image = Properties.Resources.Star_filled_;
                star4.Image = Properties.Resources.Star_filled_;
                star5.Image = Properties.Resources.Star_filled_;
                stars = 5;
            }

        }

    }
}
