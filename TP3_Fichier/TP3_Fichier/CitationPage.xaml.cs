using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Fichier.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TP3_Fichier;

namespace TP3_Fichier
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CitationPage : ContentPage
    {
        private Citation citation { get; set; }
        public CitationPage(Citation c = null)
        {
            InitializeComponent();
            this.citation = c;
            if (c != null)
            {
                edText.Text = this.citation.Texte;
                entryAuteur.Text = this.citation.Auteur;
            }
            else
            {
                butDelete.IsVisible = false;
            }
        }

        private void butSave_Clicked(object sender, EventArgs e)
        {
            if (citation != null)
            {
                citation.Auteur = entryAuteur.Text;
                citation.Texte = edText.Text;
            }
            else
            {
                var citations = (App.Current as App).GérerCitation.Citations;
                citations.Add(
                    new Citation
                    {
                        Texte = edText.Text,
                        Auteur = entryAuteur.Text
                    }
                );
            }
            this.Navigation.PopModalAsync();
        }

        private async void butDel_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Suppression", "Êtes vous sûr de vouloir supprimer cette citation ?", "Oui");
            citation.Auteur = "";
            citation.Texte = "";
            await this.Navigation.PopModalAsync();
        }

        private void butCancel_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}