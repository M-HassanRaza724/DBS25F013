using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SoftwareFirmManagement.UI
{
    public partial class TextBoxWithPlaceHolder: UserControl
    {
        string _PlaceHolder = "place holder";
        string PreviousText = "place holder";
        public TextBoxWithPlaceHolder()
        {
            InitializeComponent();
        
        }

        public bool MultiLine
        {
            get { return this.TextBox.Multiline.Equals(true) ? true : false; }
            set { this.TextBox.Multiline = value; }
        }
        public string Style
        {
            get { return this.TextBox.InputControlStyle.ToString(); }
            set
            {
                if (Enum.TryParse(value, out ComponentFactory.Krypton.Toolkit.InputControlStyle parsedStyle))
                {
                    this.TextBox.InputControlStyle = parsedStyle;
                }
                else
                {
                    throw new ArgumentException($"Invalid value for InputControlStyle: {value}");
                }
            }
        }
        public string PlaceHolder
        {
            get { return _PlaceHolder; }
            set { _PlaceHolder = value; TextBoxText = value;}
        }
        public string TextBoxText
        {
            get { return this.TextBox.Text; } set
            {
                if (!this.DesignMode)
                {
                    this.TextBox.Text = value;
                }
                else
                {
                    // Design-time only assignment (won't trigger events)
                    this.TextBox.TextChanged -= TextBox_TextChanged; // Temporarily detach
                    this.TextBox.Text = value;
                    this.TextBox.TextChanged += TextBox_TextChanged; // Reattach
                }
            }
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //if (DesignMode) return;

            if (PreviousText == _PlaceHolder && PreviousText != "place holder")
            {
                TextBox.Text = $"{_PlaceHolder[_PlaceHolder.Length-1]}";
                TextBox.ForeColor = Color.White;
            }
            else if(TextBox.Text == "")
            {
                TextBox.Text = _PlaceHolder;
                TextBox.ForeColor = Color.Gray;
            }
            else { }

            PreviousText = TextBox.Text;

        }
    }
}
