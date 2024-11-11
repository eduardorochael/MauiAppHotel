namespace MauiAppHotel.Models
{
      public class Hospedagem
    {
        public Quarto QuartoSeleciondo {get; set;}
        public int QntAdultos { get;set;}
        public int QntCriancas { get; set;}
        public DateTime DataChekin { get; set;}
        public DateTime DataChekOut { get; set; }

        public int Estadia
        {
            get => DataChekOut.Subtract(DataChekin).Days;
        }
        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * QuartoSeleciondo.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * QuartoSeleciondo.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;

            }
        }
    }
}
