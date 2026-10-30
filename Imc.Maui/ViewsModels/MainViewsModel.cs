using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Imc.Maui.Models;

using System.ComponentModel;


namespace Imc.Maui.ViewsModels
{
    public partial class MainViewsModel : ObservableObject
    {
        [ObservableProperty]
        private string _peso;
        [ObservableProperty]
        private string _estatura;
        [ObservableProperty]
        private string _imc;
        [ObservableProperty]
        private string _estadoNutricional;
        public MainViewsModel()
        {
            Limpiar();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        [RelayCommand]
        private void Calcular()
        {
          decimal peso;
          decimal estatura;
          bool pesoEsValido = decimal.TryParse(Peso, out peso);
          bool estaturaEsValida = decimal.TryParse(Estatura, out estatura);

            if (pesoEsValido && estaturaEsValida)
            {
               decimal imc = Calculadoraimc.IndiceDeMasaCorporal(peso, estatura);
               Imc = imc.ToString("F4");
               EstadoNutricional = Calculadoraimc.EstadoNutricional(imc);
            }
        }
        [RelayCommand]
        private void Limpiar()
        {
            Peso = string.Empty;
            Estatura = string.Empty;
            Imc = string.Empty;
            EstadoNutricional = string.Empty;
        }
    }
}
    

