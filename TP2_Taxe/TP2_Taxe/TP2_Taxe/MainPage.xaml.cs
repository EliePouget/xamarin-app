using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP2_Taxe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Calculer()
        {
            Regex exp = new Regex(@"^\d{1,9}(,\d{1,2})?$");
            if (entPrix.Text != "" || exp.IsMatch(entPrix.Text))
            {
                if (swTaxeIncluse.IsToggled)
                {
                    lblTaxe.Text = Math.Round((int)slTauxTaxe.Value * int.Parse(entPrix.Text) / (1+ slTauxTaxe.Value),2).ToString();
                    lblTotal.Text = entPrix.Text;
                }
                else
                {
                    lblTaxe.Text = ((int)slTauxTaxe.Value * int.Parse(entPrix.Text)).ToString();
                    lblTotal.Text = ((int)slTauxTaxe.Value * int.Parse(entPrix.Text) + (int)slTauxTaxe.Value).ToString();
    
                }
            }
            else
            {
                lblTaxe.Text = "---";
                lblTotal.Text = "---";
            }
            
        }

        private void entPrix_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculer();
        }

        private void slTauxTaxe_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Calculer();
        }
    }
}
