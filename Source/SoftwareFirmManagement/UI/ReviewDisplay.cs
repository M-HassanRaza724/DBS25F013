using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{
    public partial class ReviewDisplay: UserControl
    {
        string _ReviewerName = "Reviewer";
        int _Stars = 5;
        DateTime _Date = DateTime.Now;
        string _Description = "Review description";

        public string ReviewerName { get { return _ReviewerName; } set { _ReviewerName = value; lbl_reviewer.Text = value; } }
        public int Stars { get { return _Stars; } 
            set 
            {
                _Stars = value;
                stars_Display1.Stars = _Stars;
            }
        }
        public string Description { get { return _Description; } set { _Description = value; lbl_description.Text = value; } }
        public DateTime Date { get { return _Date; } set { _Date = value; lbl_date.Text = value.ToString("yyyy-mm-dd"); } }
        public ReviewDisplay()
        {
            InitializeComponent();
        }
    }
}
