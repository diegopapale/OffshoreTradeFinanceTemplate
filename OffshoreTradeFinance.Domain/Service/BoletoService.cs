using OffshoreTradeFinance.Domain.Dtos;
using OffshoreTradeFinance.Domain.Interfaces.Services;
using OffshoreTradeFinance.Domain.Interfaces.Repositories;

namespace OffshoreTradeFinance.Domain.Service
{
    public class BoletoService : IBoletoService
    {
        private readonly IBoletoRepository _repository;

        public BoletoService(IBoletoRepository repository)
        {
            _repository = repository;
        }

        public async Task<BoletoDto> GetBoletoByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
