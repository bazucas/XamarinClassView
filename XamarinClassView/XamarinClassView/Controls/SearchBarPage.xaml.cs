using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClassView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        private readonly List<string> _itCompanies = new List<string>
        {
            "Microsoft",
            "Apple",
            "Oracle",
            "IBM",
            "SAP",
            "Uber",
            "AirBnB"
        };

        public SearchBarPage()
        {
            InitializeComponent();
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var result = _itCompanies.Where(a => a.Contains(e.NewTextValue)).ToList();

            FillSearchBar(result);
        }

        private void SearchBar_OnSearchButtonPressed(object sender, EventArgs e)
        {
            var result = _itCompanies.Where(a => a.Contains(((SearchBar) sender).Text)).ToList();

            FillSearchBar(result);
        }

        private void FillSearchBar(IEnumerable<string> allItCompanies)
        {
            ResultList.Children.Clear();

            foreach (var itCompany in allItCompanies) ResultList.Children.Add(new Label {Text = itCompany});
        }
    }
}