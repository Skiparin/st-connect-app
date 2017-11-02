using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPage : MasterDetailPage
    {
        public ICommand FactsCommand { get; set; }
        public MyMasterDetailPage()
        {
            Title = "MasterDetailsPage";
            InitializeComponent();
        }

        private void MenuClicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new MenuPage());
        }

        private void AboutClicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new AboutPage());
        }
    }
}