using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            Detail = new Controls.ActivityIndicatorPage();
        }

        private void GoProgressBarPage(object sender, EventArgs e)
        {
            Detail = new Controls.ProgressBarPage();
        }

        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new Controls.BoxViewPage();
        }

        private void GoLabelPage(object sender, EventArgs e)
        {
            Detail = new Controls.LabelPage();
        }

        private void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new Controls.ButtonPage();
        }

        private void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new Controls.EntryEditorPage();
        }

        private void GoDatePickerPage(object sender, EventArgs e)
        {
            Detail = new Controls.DatePickerPage();
        }

        private void GoTimerPickerPage(object sender, EventArgs e)
        {
            Detail = new Controls.TimePickerPage();
        }
    }
}