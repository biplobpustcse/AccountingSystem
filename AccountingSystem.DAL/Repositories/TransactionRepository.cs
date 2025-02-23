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
        public IEnumerable<Transaction> SearchTransactions(DateTime? startDate, DateTime? endDate, string descriptionFilter, int? debitAccountId, int? creditAccountId)
        {
            using (var connection = context.CreateConnection())
            {
                string sql = "SELECT * FROM Transactions WHERE 1=1";
                DynamicParameters parameters = new DynamicParameters();

                if (startDate.HasValue)
                {
                    sql += " AND TransactionDate >= @StartDate";
                    parameters.Add("StartDate", startDate.Value.Date, DbType.Date);
                }

                if (endDate.HasValue)
                {
                    sql += " AND TransactionDate <= @EndDate";
                    parameters.Add("EndDate", endDate.Value.Date.AddDays(1).AddSeconds(-1), DbType.DateTime);
                }

                if (!string.IsNullOrEmpty(descriptionFilter))
                {
                    sql += " AND Description LIKE @DescriptionFilter";
                    parameters.Add("DescriptionFilter", "%" + descriptionFilter + "%", DbType.String);
                }

                if (debitAccountId.HasValue)
                {
                    sql += " AND DebitAccountID = @DebitAccountId";
                    parameters.Add("DebitAccountId", debitAccountId, DbType.Int32);
                }

                if (creditAccountId.HasValue)
                {
                    sql += " AND CreditAccountID = @CreditAccountId";
                    parameters.Add("CreditAccountId", creditAccountId, DbType.Int32);
                }

                return connection.Query<Transaction>(sql, parameters);
            }
        }
    }
}