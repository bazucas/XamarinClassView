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
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();

            TxtAge.TextChanged += delegate(object sender, TextChangedEventArgs e) { LblDup.Text = e.NewTextValue; };

            TxtComment.Completed += delegate(object sender, EventArgs e) { LblCharQuant.Text = TxtComment.Text.Length.ToString(); };
        }
    }
}