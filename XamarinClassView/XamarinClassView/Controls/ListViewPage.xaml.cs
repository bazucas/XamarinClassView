using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinClassView.Model;

namespace XamarinClassView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            var personList = new List<Person>
            {
                new Person {Name = "Sérgio Pires", Age = 10},
                new Person {Name = "Marta Santos", Age = 10},
                new Person {Name = "Daniel Gomes", Age = 10},
                new Person {Name = "Bruno Novo", Age = 10},
                new Person {Name = "Tiago Silva", Age = 10}
            };

            PersonsList.ItemsSource = personList;
        }
    }
}