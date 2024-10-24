namespace OffshoreTradeFinance.Domain.Dtos
{
    public class BoletoDto
    {
        public int Id { get; set; }
        public string NumeroBoleto { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public string NomeSacado { get; set; }
    }
}
