using Imc.Maui.Models;
using Imc.Maui.ViewsModels;

namespace Imc.Maui.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
            BindingContext = new MainViewsModel();
  

        }


    }
}

