namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    // Método chamado ao clicar no botão "Quem Somos"
    private async void OnQuemSomosClicked(object sender, EventArgs e)
    {
        // Navegar para a página "Quem Somos"
        await Navigation.PushAsync(new QuemSomos());


    }
}