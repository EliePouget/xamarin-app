using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP2_calculatrice
{
    public partial class MainPage : ContentPage
    {
        enum Touche
        {
            AUCUNE,
            CHIFFRE,
            OPERATEUR
        }
        private Touche DerniereTouche;
        private string Resultat;
        public MainPage()
        {
            Resultat = "";
            DerniereTouche = Touche.AUCUNE;
            InitializeComponent();
        }

        private void ButC_clicked(object sender, EventArgs e)
        {
            lblOperation.Text = "0";
            lblResultat.Text = "---";
            DerniereTouche = Touche.AUCUNE;
        }

        private void ButChiffreClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (DerniereTouche == Touche.AUCUNE)
            {
                if (lblOperation.Text == "0")
                {
                    if (btn.Text != "0")
                    {
                        lblOperation.Text = btn.Text;
                        DerniereTouche = Touche.CHIFFRE;
                        Calculer();
                    }
                }
                else
                {
                    lblOperation.Text += btn.Text;
                    DerniereTouche = Touche.CHIFFRE;
                    Calculer();
                }
            }
            else if (DerniereTouche == Touche.OPERATEUR)
            {
                lblOperation.Text = btn.Text;
                DerniereTouche = Touche.CHIFFRE;
                Calculer();
            } 
            else
            {
                lblOperation.Text += btn.Text;
                DerniereTouche = Touche.CHIFFRE;
                Calculer();
            }
        }
        private void ButOperatorClicked(object sender, EventArgs e)
        {
            if(DerniereTouche == Touche.CHIFFRE)
            {
                Button btn = (Button)sender;
                lblOperation.Text = btn.Text;
                DerniereTouche = Touche.OPERATEUR;
                Resultat = "";
            } 
        }
        private void ButEqualClicked(object sender, EventArgs e)
        {
            if (lblResultat.Text != "")
            {
                lblOperation.Text = lblResultat.Text;
                lblResultat.Text = "";
                DerniereTouche = Touche.AUCUNE;
            }
            
        }
        private void Calculer()
        {
            if (Resultat == "")
            {
                DataTable res = new DataTable();
                object total = res.Compute(lblOperation.Text, null);
                lblResultat.Text = total.ToString();
                Resultat += total.ToString();
            }
            else
            {
                DataTable res = new DataTable();
                object total = res.Compute(Resultat, null);
                lblResultat.Text = total.ToString();
                Resultat += total.ToString();
            }
            
        }
    }
}
