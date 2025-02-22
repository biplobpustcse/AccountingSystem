using AccountingSystem.Models.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccountingSystem.DAL.Repositories
{
    public class TransactionRepository
    {
        private readonly string _connectionString;

        public TransactionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Transaction Operations

        public IEnumerable<Transaction> GetAll()
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<Transaction>("SELECT * FROM Transactions");
            }
        }

        public Transaction GetById(int transactionId)
        {
            using (var connection = CreateConnection())
            {
                return connection.QueryFirstOrDefault<Transaction>("SELECT * FROM Transactions WHERE TransactionID = @TransactionId", new { TransactionId = transactionId });
            }
        }

        public int Insert(Transaction transaction)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("INSERT INTO Transactions (TransactionDate, TransactionNumber, Description, Reference) VALUES (@TransactionDate, @TransactionNumber, @Description, @Reference); SELECT CAST(SCOPE_IDENTITY() as int)", transaction);
            }
        }

        public int Update(Transaction transaction)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("UPDATE Transactions SET TransactionDate = @TransactionDate, TransactionNumber = @TransactionNumber, Description = @Description, Reference = @Reference WHERE TransactionID = @TransactionID", transaction);
            }
        }

        public int Delete(int transactionId)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("DELETE FROM Transactions WHERE TransactionID = @TransactionId", new { TransactionId = transactionId });
            }
        }
    }
}
