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

            TxtComment.Completed += delegate { LblCharQuant.Text = TxtComment.Text.Length.ToString(); };
        }
    }
}