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
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            this.IsBusy = true;

            int nbCitations = await Task<int>.Run(() =>
            {
                return
               (Application.Current as App).GérerCitation.Citations.Count;
            });
            lblNombreCitations.Text = nbCitations.ToString();
            butAfficherCitations.IsEnabled = true;
            butAfficherCitations.Text = "Afficher les citations";
            this.IsBusy = false;
        }


            private void butAfficherCitations_Clicked(object sender, EventArgs e)
        {
      
            this.Navigation.PushAsync(new ListePage());

        }
    }
}
