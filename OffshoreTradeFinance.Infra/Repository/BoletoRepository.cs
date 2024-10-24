using OffshoreTradeFinance.Domain.Dtos;
using OffshoreTradeFinance.Domain.Interfaces.Repositories;
using System.Data;
using Dapper;

namespace OffshoreTradeFinance.Infra.Repository
{
    public class BoletoRepository : IBoletoRepository
    {
        private readonly IDbConnection _dbConnection;

        public BoletoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<BoletoDto> GetByIdAsync(int id)
        {
            const string sql = @"
                SELECT Id, NumeroBoleto, Valor, DataVencimento, NomeSacado
                FROM Boletos
                WHERE Id = @Id";

            using var connection = _dbConnection;
            connection.Open();
            return await connection.QueryFirstOrDefaultAsync<BoletoDto>(sql, new { Id = id });
        }
    }
}
