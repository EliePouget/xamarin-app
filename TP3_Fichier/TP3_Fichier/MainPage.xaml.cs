using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP3_Fichier
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            lblNombreCitations.Text = (App.Current as App).GérerCitation.Citations.Count().ToString();
            butAfficherCitations.IsEnabled = true;
            butAfficherCitations.Text = "Afficher les citations";
            base.OnAppearing();    
        }

        private void butAfficherCitations_Clicked(object sender, EventArgs e)
        {
      
            this.Navigation.PushAsync(new ListePage());

        }
    }
}
