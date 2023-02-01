using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP1
{
    public partial class App : Application
    {
        public static List<string> NumérosAppelés { get; set; }
        public const string NUEMROS_APPELES = "fdgdfgd";
        public App()
        {
            InitializeComponent();
            NumérosAppelés = new List<string>();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            if (Properties.ContainsKey( NUEMROS_APPELES) )
            {
                var lst = (Properties[NUEMROS_APPELES] as string).Split(';');
                NumérosAppelés.AddRange(lst);
            }
        }

        protected override void OnSleep()
        {
            var lst = string.Join(";", NumérosAppelés);
            Properties[NUEMROS_APPELES] = lst;        
        }

        protected override void OnResume()
        {
        }
    }
}
