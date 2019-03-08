using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace quotes
{
    public partial class MainPage : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = new string[]
        {
            "Here is the quote 1.",
            "Here is the quote 2.",
            "Here is the quote 3.",
        };

        public MainPage()
        {
            InitializeComponent();
            currentQuote.Text = _quotes[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes.Length)
                _index = 0;

            currentQuote.Text = _quotes[_index];
        }
    }
}
