using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClassView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();
        }

        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            LblResult.Text = e.OldDate.ToString("dd/MM/yyyy") + " > " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}