using OffshoreTradeFinance.Domain.Dtos;

namespace OffshoreTradeFinance.Domain.Interfaces.Repositories
{
    public interface IBoletoRepository
    {
        Task<BoletoDto> GetByIdAsync(int id);
    }
}
