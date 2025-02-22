using AccountingSystem.Models.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccountingSystem.DAL.Repositories
{
    public class TransactionDetailRepository
    {
        private readonly string _connectionString;

        public TransactionDetailRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // TransactionDetail Operations

        public IEnumerable<TransactionDetail> GetAll()
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<TransactionDetail>("SELECT * FROM TransactionDetails");
            }
        }

        public TransactionDetail GetById(int detailId)
        {
            using (var connection = CreateConnection())
            {
                return connection.QueryFirstOrDefault<TransactionDetail>("SELECT * FROM TransactionDetails WHERE DetailID = @DetailId", new { DetailId = detailId });
            }
        }

        public int Insert(TransactionDetail detail)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("INSERT INTO TransactionDetails (TransactionID, DebitAccountID, CreditAccountID, Amount, VATID, VATAmount) VALUES (@TransactionID, @DebitAccountID, @CreditAccountID, @Amount, @VATID, @VATAmount); SELECT CAST(SCOPE_IDENTITY() as int)", detail);
            }
        }

        public int Update(TransactionDetail detail)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("UPDATE TransactionDetails SET TransactionID = @TransactionID, DebitAccountID = @DebitAccountID, CreditAccountID = @CreditAccountID, Amount = @Amount, VATID = @VATID, VATAmount = @VATAmount WHERE DetailID = @DetailID", detail);
            }
        }

        public int Delete(int detailId)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("DELETE FROM TransactionDetails WHERE DetailID = @DetailId", new { DetailId = detailId });
            }
        }
    }
}
