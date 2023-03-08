using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Fichier.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
    }
}