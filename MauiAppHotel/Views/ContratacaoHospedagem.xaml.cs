namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    // M�todo chamado ao clicar no bot�o "Quem Somos"
    private async void OnQuemSomosClicked(object sender, EventArgs e)
    {
        // Navegar para a p�gina "Quem Somos"
        await Navigation.PushAsync(new QuemSomos());


    }
}