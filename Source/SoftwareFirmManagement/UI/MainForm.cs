using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace SoftwareFirmManagement
{
    public partial class MainForm: KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //new Form1().Show();

        }

        private void orders1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_size_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) 
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(800, 600);
                this.btn_size.StateCommon.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Full_Screen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.btn_size.StateCommon.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Normal_Screen;

            }


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonCheckButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtn_test.Checked)
            {
                cbtn_test.Values.ExtraText = "▼";
            }
            else
            {
                cbtn_test.Values.ExtraText = "▲";
            }

        }
    }

}
