using AccountingSystem.Models.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccountingSystem.DAL.Repositories
{
    public class TransactionRepository
    {
        private readonly DapperContext context;

        public TransactionRepository(DapperContext context)
        {
            this.context = context;
        }
        public IDbConnection GetConnection()
        {
            return context.CreateConnection();
        }
        public IEnumerable<Transaction> GetAll()
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Query<Transaction>("SELECT * FROM Transactions");
            }
        }

        public Transaction GetById(int transactionId)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.QueryFirstOrDefault<Transaction>("SELECT * FROM Transactions WHERE TransactionID = @TransactionId", new { TransactionId = transactionId });
            }
        }

        public int Insert(Transaction transaction)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.ExecuteScalar<int>("INSERT INTO Transactions (TransactionDate, TransactionNumber, Description, Reference) VALUES (@TransactionDate, @TransactionNumber, @Description, @Reference); SELECT CAST(SCOPE_IDENTITY() as int)", transaction);
            }
        }

        public int Update(Transaction transaction)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Execute("UPDATE Transactions SET TransactionDate = @TransactionDate, TransactionNumber = @TransactionNumber, Description = @Description, Reference = @Reference WHERE TransactionID = @TransactionID", transaction);
            }
        }

        public void Delete(int transactionId, IDbTransaction transaction)
        {
            using (var command = transaction.Connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText = "DELETE FROM Transactions WHERE TransactionID = @TransactionID";
                command.Parameters.Add(new SqlParameter("@TransactionID", transactionId));
                command.ExecuteNonQuery();
            }
        }
    }
}
