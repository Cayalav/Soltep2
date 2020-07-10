using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Soltep2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Cargando...", MaskType.Gradient);

        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            UserDialogs.Instance.HideLoading();

        }
    }
}
