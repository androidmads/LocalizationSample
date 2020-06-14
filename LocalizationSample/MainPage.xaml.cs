using LocalizationSample.Resx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalizationSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string language = Thread.CurrentThread.CurrentUICulture.Name;
            picker.SelectedIndex = language == "ta" ? 2 : language == "fr" ? 1 : 0;
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (App.SelectedIndex == picker.SelectedIndex)
                return;
            App.SelectedIndex = picker.SelectedIndex;
            CultureInfo language = new CultureInfo(picker.SelectedIndex == 0 ? "" : picker.SelectedIndex == 1 ? "fr" : "ta");
            Thread.CurrentThread.CurrentUICulture = language;
            AppResources.Culture = language;
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
