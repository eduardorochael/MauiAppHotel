using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 110,
                ValorDiariaCrianca = 60
            },
             new Quarto()
            {
                Descricao = "Suite  Luxo",
                ValorDiariaAdulto = 100,
                ValorDiariaCrianca = 55
            },
               new Quarto()
            {
                Descricao = "Suite  Single ",
                ValorDiariaAdulto = 60,
                ValorDiariaCrianca = 30
            },
                 new Quarto()
            {
                Descricao = "Suite Crise ",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 20
            }

        };
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 800;

            return window;
        }
    }
}