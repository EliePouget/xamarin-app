using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TP3_Fichier.Data;
namespace TP3_Fichier
{
    public partial class App : Application
    {
        public GestionCitations GérerCitation { get; }
        public App()
        {
            InitializeComponent();
            GérerCitation = new GestionCitations();
            MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
