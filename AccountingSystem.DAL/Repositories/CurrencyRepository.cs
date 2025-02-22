using AccountingSystem.Models.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccountingSystem.DAL.Repositories
{
    public class CurrencyRepository
    {
        private readonly string _connectionString;

        public CurrencyRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public IEnumerable<Currency> GetAll()
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<Currency>("SELECT * FROM Currency");
            }
        }

        public Currency GetById(int currencyId)
        {
            using (var connection = CreateConnection())
            {
                return connection.QueryFirstOrDefault<Currency>("SELECT * FROM Currency WHERE CurrencyID = @CurrencyId", new { CurrencyId = currencyId });
            }
        }

        public Currency GetByCode(string currencyCode)
        {
            using (var connection = CreateConnection())
            {
                return connection.QueryFirstOrDefault<Currency>("SELECT * FROM Currency WHERE CurrencyCode = @CurrencyCode", new { CurrencyCode = currencyCode });
            }
        }

        public int Insert(Currency currency)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("INSERT INTO Currency (CurrencyCode, ExchangeRate) VALUES (@CurrencyCode, @ExchangeRate); SELECT CAST(SCOPE_IDENTITY() as int)", currency);
            }
        }

        public int Update(Currency currency)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("UPDATE Currency SET CurrencyCode = @CurrencyCode, ExchangeRate = @ExchangeRate WHERE CurrencyID = @CurrencyID", currency);
            }
        }

        public int Delete(int currencyId)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("DELETE FROM Currency WHERE CurrencyID = @CurrencyId", new { CurrencyId = currencyId });
            }
        }
    }
}
