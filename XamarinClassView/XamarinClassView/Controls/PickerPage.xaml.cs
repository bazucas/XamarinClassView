using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClassView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
        }

        private void ActionIndexChanged(object sender, EventArgs e)
        {
            var obj = (Picker) sender;
            Result.Text = obj.SelectedItem + " - " + obj.SelectedIndex;
        }
    }
}