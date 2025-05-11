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
    //public partial class TextBoxWithPlaceHolder: UserControl
    //{
    //    string _PlaceHolder = "place holder";
    //    string PreviousText = "place holder";
    //    public TextBoxWithPlaceHolder()
    //    {
    //        InitializeComponent();

    //    }

    //    public bool MultiLine
    //    {
    //        get { return this.TextBox.Multiline.Equals(true) ? true : false; }
    //        set { this.TextBox.Multiline = value; }
    //    }
    //    public string Style
    //    {
    //        get { return this.TextBox.InputControlStyle.ToString(); }
    //        set
    //        {
    //            if (Enum.TryParse(value, out ComponentFactory.Krypton.Toolkit.InputControlStyle parsedStyle))
    //            {
    //                this.TextBox.InputControlStyle = parsedStyle;
    //            }
    //            else
    //            {
    //                throw new ArgumentException($"Invalid value for InputControlStyle: {value}");
    //            }
    //        }
    //    }
    //    public string PlaceHolder
    //    {
    //        get { return _PlaceHolder; }
    //        set { _PlaceHolder = value; TextBoxText = value;}
    //    }
    //    public string TextBoxText
    //    {
    //        get { return this.TextBox.Text; } set
    //        {
    //            if (!this.DesignMode)
    //            {
    //                this.TextBox.Text = value;
    //            }
    //            else
    //            {
    //                // Design-time only assignment (won't trigger events)
    //                this.TextBox.TextChanged -= TextBox_TextChanged; // Temporarily detach
    //                this.TextBox.Text = value;
    //                this.TextBox.TextChanged += TextBox_TextChanged; // Reattach
    //            }
    //        }
    //    }


    //    private void TextBox_TextChanged(object sender, EventArgs e)
    //    {
    //        //if (DesignMode) return;

    //        if (PreviousText == _PlaceHolder && PreviousText != "place holder")
    //        {
    //            TextBox.Text = $"{_PlaceHolder[_PlaceHolder.Length-1]}";
    //            TextBox.ForeColor = Color.White;
    //        }
    //        else if(TextBox.Text == "")
    //        {
    //            TextBox.Text = _PlaceHolder;
    //            TextBox.ForeColor = Color.Gray;
    //        }
    //        else { }

    //        PreviousText = TextBox.Text;

    //    }
    //}

    public partial class TextBoxWithPlaceHolder : UserControl
    {
        private string _placeHolder = "place holder";
        private bool _isPlaceholderActive = true;
        private Color _placeholderColor = Color.Gray;
        private Color _userTextColor = Color.White;

        public TextBoxWithPlaceHolder()
        {
            InitializeComponent();
            InitializePlaceholder();
        }

        private void InitializePlaceholder()
        {
            // Set initial placeholder
            if (string.IsNullOrEmpty(TextBox.Text))
            {
                TextBox.Text = _placeHolder;
                TextBox.ForeColor = _placeholderColor;
                _isPlaceholderActive = true;
            }

            // Wire up events
            TextBox.GotFocus += TextBox_GotFocus;
            TextBox.LostFocus += TextBox_LostFocus;
            TextBox.TextChanged += TextBox_TextChanged;
        }

        public string PlaceHolder
        {
            get => _placeHolder;
            set
            {
                _placeHolder = value;
                if (_isPlaceholderActive)
                {
                    TextBox.Text = value;
                    TextBox.ForeColor = _placeholderColor;
                }
            }
        }

        public string TextBoxText
        {
            get => _isPlaceholderActive ? string.Empty : TextBox.Text;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    ShowPlaceholder();
                }
                else
                {
                    HidePlaceholder();
                    TextBox.Text = value;
                }
            }
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            if (_isPlaceholderActive)
            {
                HidePlaceholder();
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox.Text))
            {
                ShowPlaceholder();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isPlaceholderActive) return;

            // Your custom text changed logic here
            // (e.g., input validation, formatting, etc.)
        }

        private void ShowPlaceholder()
        {
            TextBox.Text = _placeHolder;
            TextBox.ForeColor = _placeholderColor;
            _isPlaceholderActive = true;
        }

        private void HidePlaceholder()
        {
            TextBox.Text = string.Empty;
            TextBox.ForeColor = _userTextColor;
            _isPlaceholderActive = false;
        }

        // Keep your existing properties for MultiLine and Style
        public bool MultiLine
        {
            get => TextBox.Multiline;
            set => TextBox.Multiline = value;
        }

        public string Style
        {
            get => TextBox.InputControlStyle.ToString();
            set
            {
                if (Enum.TryParse(value, out ComponentFactory.Krypton.Toolkit.InputControlStyle parsedStyle))
                {
                    TextBox.InputControlStyle = parsedStyle;
                }
                else
                {
                    throw new ArgumentException($"Invalid value for InputControlStyle: {value}");
                }
            }
        }
    }
}
