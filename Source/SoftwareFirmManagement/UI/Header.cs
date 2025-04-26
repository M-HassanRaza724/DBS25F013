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
    public partial class Header: UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        string previous_text = "Search";
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (previous_text == "Search")
            {
                txt_search.Text = $"{txt_search.Text[txt_search.Text.Length-1]}";
                //txt_search.
                txt_search.StateCommon.Content.Color1 = Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
                btn_clear.Visible = true;
                kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
                kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            }
            else if (txt_search.Text == "")
            {
                txt_search.Text = "Search";
                txt_search.StateCommon.Content.Color1 = Color.Gray;
                btn_clear.Visible = false;
                this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
                this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            }
            else { }
            previous_text = txt_search.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }
    }
}
