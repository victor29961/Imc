using Imc.Maui.Models;
namespace Imc.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        imcLabel.Text = string.Empty;
        EstadoNutricional.Text = string.Empty;
	}

    private void OnCalcularButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            decimal peso = decimal.Parse(pesoEntry.Text);
            decimal estatura = decimal.Parse(estaturaEntry.Text);
            decimal imc = Calculadoraimc.CalcularImc(peso,estatura);
            imcLabel.Text = imc.ToString("F2");
            EstadoNutricional.Text = Calculadoraimc.ObtenerEstadoNutricional(imc);
        }
        catch (Exception)
        {
            throw;
        }
    }

    private void OnLimpiarButton_Clicked(object sender, EventArgs e)
    {
        pesoEntry.Text = string.Empty;
        estaturaEntry.Text = string.Empty;
        imcLabel.Text= string.Empty;
        EstadoNutricional.Text= string.Empty;
    }
}