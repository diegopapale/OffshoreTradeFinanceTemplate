using OffshoreTradeFinance.Domain.Dtos;

namespace OffshoreTradeFinance.Domain.Interfaces.Services
{
    public interface IBoletoService
    {
        Task<BoletoDto> GetBoletoByIdAsync(int id);
    }
}
