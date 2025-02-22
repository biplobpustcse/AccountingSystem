using AccountingSystem.Models.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccountingSystem.DAL.Repositories
{
    public class TransactionDetailRepository
    {
        private readonly DapperContext context;

        public TransactionDetailRepository(DapperContext context)
        {
            this.context = context;
        }
        public IDbConnection GetConnection()
        {
            return context.CreateConnection();
        }
        public IEnumerable<TransactionDetail> GetAll()
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Query<TransactionDetail>("SELECT * FROM TransactionDetails");
            }
        }

        public TransactionDetail GetById(int detailId)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.QueryFirstOrDefault<TransactionDetail>("SELECT * FROM TransactionDetails WHERE DetailID = @DetailId", new { DetailId = detailId });
            }
        }
        public IEnumerable<TransactionDetail> GetByTransactionId(int transactionId)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Query<TransactionDetail>("SELECT * FROM TransactionDetails WHERE TransactionID = @TransactionID", new { TransactionID = transactionId });
            }
        }

        public int Insert(TransactionDetail detail)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Execute("INSERT INTO TransactionDetails (TransactionID, DebitAccountID, CreditAccountID, Amount, VATID, VATAmount,CurrencyID) VALUES (@TransactionID, @DebitAccountID, @CreditAccountID, @Amount, @VATID, @VATAmount,@CurrencyID); SELECT CAST(SCOPE_IDENTITY() as int)", detail);
            }
        }

        public int Update(TransactionDetail detail)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Execute("UPDATE TransactionDetails SET TransactionID = @TransactionID, DebitAccountID = @DebitAccountID, CreditAccountID = @CreditAccountID, Amount = @Amount, VATID = @VATID, VATAmount = @VATAmount,CurrencyID = @CurrencyID WHERE DetailID = @DetailID", detail);
            }
        }

        public void Delete(int detailId, IDbTransaction transaction)
        {
            //using (var connection = context.CreateConnection())
            //{
            //    return connection.Execute("DELETE FROM TransactionDetails WHERE DetailID = @DetailId", new { DetailId = detailId });
            //}

            using (var command = transaction.Connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText = "DELETE FROM TransactionDetails WHERE DetailId = @DetailId";
                command.Parameters.Add(new SqlParameter("@DetailId", detailId));
                command.ExecuteNonQuery();
            }
        }
        public void DeleteByTransactionId(int transactionId, IDbTransaction transaction)
        {
            //using (var connection = context.CreateConnection())
            //{
            //    return connection.Execute("DELETE FROM TransactionDetails WHERE TransactionId = @TransactionId", new { TransactionId = transactionId });
            //}
            using (var command = transaction.Connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText = "DELETE FROM TransactionDetails WHERE TransactionID = @TransactionID";
                command.Parameters.Add(new SqlParameter("@TransactionID", transactionId));
                command.ExecuteNonQuery();
            }
        }
    }
}
