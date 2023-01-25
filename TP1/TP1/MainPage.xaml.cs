using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void entNuméro_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex exp = new Regex(@"0[1-9](\.?[0-9]{2}){4}");
            butAppeler.IsEnabled = exp.IsMatch(entNuméro.Text);
        }
    }
}
