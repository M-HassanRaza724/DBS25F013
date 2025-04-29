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
    public partial class TextBoxWithPlaceHolder: UserControl
    {
        string PlaceHolder = "TextBox";
        string Previoustext;
        public TextBoxWithPlaceHolder()
        {
            InitializeComponent();
            TextBox.Text = PlaceHolder;
            Previous
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if(TextBox.Text == PlaceHolder)
            {
                TextBox.Text = "";
                TextBox.ForeColor = Color.Black;
            }
        }
    }
}
