using Microsoft.Maui.Controls;
namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();

	}

    private void VoltarButton_Clicked(object sender, EventArgs e)
    {
        // Lógica para voltar
        Navigation.PopAsync();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        try
        {
            Navigation.PushAsync(new Sobre());

        }
        catch (Exception ex)

        {

            DisplayAlert("OPS", ex.Message, "ok");
        }

       
    }
}