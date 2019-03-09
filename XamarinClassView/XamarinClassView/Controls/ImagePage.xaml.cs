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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            // ImageOne.IsLoading;

            var image = new Image
            {
                Source = ImageSource.FromFile(Device.RuntimePlatform == Device.UWP ? "image/usb.jpg" : "usb.jpg")
            };

            Container.Children.Add(image);
        }
    }
}