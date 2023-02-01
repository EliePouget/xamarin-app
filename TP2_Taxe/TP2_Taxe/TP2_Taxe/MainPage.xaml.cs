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
            if (entPrix.Text != "" && exp.IsMatch(entPrix.Text))
            {
                if (swTaxeIncluse.IsToggled)
                {
                    double prixTTC = double.Parse(entPrix.Text);
                    double tauxTaxe = slTauxTaxe.Value / 100;
                    lblTaxe.Text = Math.Round((prixTTC * tauxTaxe/(1+tauxTaxe)),2).ToString();
                    lblTotal.Text = prixTTC.ToString();
                }
                else
                {
                    double prixHT = double.Parse(entPrix.Text);
                    double tauxTaxe = (double)slTauxTaxe.Value / 100;
                    double taxe = prixHT * tauxTaxe;
                    lblTaxe.Text = taxe.ToString();
                    lblTotal.Text = (taxe + prixHT).ToString();
    
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

        private void swTaxeIncluse_Toggled(object sender, ToggledEventArgs e)
        {
            Calculer();
        }

        private void but15Pourcent_Clicked(object sender, EventArgs e)
        {
            slTauxTaxe.Value = 15;
        }

        private void but20Pourcent_Clicked(object sender, EventArgs e)
        {
            slTauxTaxe.Value = 20;
        }
    }
}
