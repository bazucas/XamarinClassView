using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinClassView.Controls;

namespace XamarinClassView.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoActivityIndicatorPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ActivityIndicatorPage());
            IsPresented = false;
        }

        private void GoProgressBarPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ProgressBarPage());
            IsPresented = false;
        }

        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new BoxViewPage());
            IsPresented = false;
        }

        private void GoLabelPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new LabelPage());
            IsPresented = false;
        }

        private void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ButtonPage());
            IsPresented = false;
        }

        private void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new EntryEditorPage());
            IsPresented = false;
        }

        private void GoDatePickerPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DatePickerPage());
            IsPresented = false;
        }

        private void GoTimerPickerPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TimePickerPage());
            IsPresented = false;
        }

        private void GoPickerPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PickerPage());
            IsPresented = false;
        }

        private void GoSearchBarPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SearchBarPage());
            IsPresented = false;
        }

        private void GoSliderStepperPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SliderStepperPage());
            IsPresented = false;
        }

        private void GoSwitchPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SwitchPage());
            IsPresented = false;

        }

        private void GoImagePage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ImagePage());
            IsPresented = false;
        }

        private void GoListViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListViewPage());
            IsPresented = false;
        }


        private void GoTableViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TableViewPage());
            IsPresented = false;
        }

        private void GoWebViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new WebViewPage());
            IsPresented = false;
        }
    }
}