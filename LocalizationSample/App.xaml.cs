using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalizationSample
{
    public partial class App : Application
    {
        public static int SelectedIndex = -1;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
