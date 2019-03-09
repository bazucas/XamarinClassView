using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClassView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderStepperPage : ContentPage
    {
        public SliderStepperPage()
        {
            InitializeComponent();
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderResult.Text = e.NewValue.ToString(CultureInfo.InvariantCulture);
        }

        private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            StepperResult.Text = e.NewValue.ToString(CultureInfo.InvariantCulture);
        }
    }
}