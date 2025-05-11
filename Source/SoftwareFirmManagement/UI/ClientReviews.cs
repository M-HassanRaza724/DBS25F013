using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{
    public partial class ClientReviews: Form
    {
        private List<ReviewDisplay> reviews = new List<ReviewDisplay>();
        public ClientReviews()
        {
            InitializeComponent();
        }
        private void LoadReviews()
        {
            reviews.Clear();
            int i = 0;
            foreach (ReviewDAO r in ReviewDL.allReviews)
            {
                ReviewDisplay reviewDisplay = new ReviewDisplay();
                //reviewDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top)));
                //reviewDisplay.BackColor = System.Drawing.Color.Transparent;
                //reviewDisplay.Location = new System.Drawing.Point(((pnl_main.Width / 2) - (375)), 250 + (i * 130));
                //reviewDisplay.Name = $"review{i + 1}";
                //reviewDisplay.Review = s;
                //reviewDisplay.Size = new System.Drawing.Size(750, 130);
                //reviewDisplay.TabIndex = 0;
                //reviews.Add(reviewDisplay);
                //this.pnl_main.Controls.Add(reviews[i]);
                //pnl_main.Height += 235;



                reviewDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
                reviewDisplay.AutoScroll = true;
                reviewDisplay.BackColor = System.Drawing.Color.Transparent;
                reviewDisplay.Date = r.Date;
                reviewDisplay.Description = r.Description;
                reviewDisplay.Location = new System.Drawing.Point(((pnl_main.Width / 2) - (375)), 150 + (i * 170));
                reviewDisplay.MinimumSize = new System.Drawing.Size(580, 0);
                reviewDisplay.Name = $"reviewDisplay{ i + 1 }";
                reviewDisplay.ReviewerName = r.ReviewerName;
                reviewDisplay.Size = new System.Drawing.Size(750, 130);
                reviewDisplay.Stars = r.Stars;
                reviewDisplay.TabIndex = 14;
                reviews.Add(reviewDisplay);
                this.pnl_main.Controls.Add(reviews[i]);
                pnl_main.Height += 170;
                i++;
            }

            //lbl_footer.Location = new System.Drawing.Point(6, 300 + (i * 260));
            vScrollBar.Maximum = (6 * i);
        }
        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int change = e.NewValue - e.OldValue;
            if (change > 0)
            {
                pnl_main.Location = new Point(pnl_main.Location.X, pnl_main.Location.Y - e.NewValue);
            }
            else
            {
                pnl_main.Location = new Point(pnl_main.Location.X, pnl_main.Location.Y + e.NewValue);
            }
            if (e.NewValue == 0)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, 0);

            }
            if (e.NewValue == 100)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, -pnl_main.Height);

            }
        }

        private void ClientReviews_Load(object sender, EventArgs e)
        {
            LoadReviews();
        }
    }
}
