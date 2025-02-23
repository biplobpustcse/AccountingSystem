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
                return connection.ExecuteScalar<int>(@"
                    INSERT INTO Transactions (
                        TransactionDate, TransactionNumber, Description, Reference, 
                        DebitAccountID, CreditAccountID, Amount, VATID, VATAmount, CurrencyID
                    ) VALUES (
                        @TransactionDate, @TransactionNumber, @Description, @Reference, 
                        @DebitAccountID, @CreditAccountID, @Amount, @VATID, @VATAmount, @CurrencyID
                    );
                    SELECT CAST(SCOPE_IDENTITY() as int)", transaction);
            }
        }

        public int Update(Transaction transaction)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Execute(@"
                    UPDATE Transactions SET 
                        TransactionDate = @TransactionDate, 
                        TransactionNumber = @TransactionNumber, 
                        Description = @Description, 
                        Reference = @Reference,
                        DebitAccountID = @DebitAccountID,
                        CreditAccountID = @CreditAccountID,
                        Amount = @Amount,
                        VATID = @VATID,
                        VATAmount = @VATAmount,
                        CurrencyID = @CurrencyID
                    WHERE TransactionID = @TransactionID", transaction);
            }
        }

        public void Delete(int transactionId)
        {
            using (var connection = context.CreateConnection())
            {
                connection.Execute("DELETE FROM Transactions WHERE TransactionID = @TransactionID", new { TransactionID = transactionId });
            }
        }
    }
}