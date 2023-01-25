using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP1
{
    public partial class App : Application
    {
        public static List<string> NumérosAppelés { get; set; }
        public App()
        {
            InitializeComponent();
            NumérosAppelés = new List<string>();
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
