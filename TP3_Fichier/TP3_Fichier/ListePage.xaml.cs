using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP3_Fichier
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListePage : ContentPage
    {
        public ListePage()
        {
            InitializeComponent();
            lstCitations.ItemsSource = (App.Current as App).GérerCitation.Citations;
        }

        private void lstCitations_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            this.Navigation.PushModalAsync(new CitationPage((Data.Citation)e.Item));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new CitationPage());
        }
    }
}