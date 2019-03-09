using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClassView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        private void GoToPage(object sender, EventArgs e)
        {
            Browser.Source = SiteUrl.Text;
        }

        private void GoNext(object sender, EventArgs e)
        {
            if (Browser.CanGoForward)
            {
                Browser.GoForward();
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
            }
        }

        private void WebView_OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            LblStatus.Text = "Loaded";
        }

        private void WebView_OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            LblStatus.Text = "Loading";
        }
    }
}