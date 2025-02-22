using AccountingSystem.Models.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccountingSystem.DAL.Repositories
{
    public class ChartOfAccountsRepository
    {
        private readonly string _connectionString;

        public ChartOfAccountsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // ChartOfAccount Operations

        public IEnumerable<ChartOfAccount> GetAll()
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<ChartOfAccount>("SELECT * FROM ChartOfAccounts");
            }
        }

        public ChartOfAccount GetById(int accountId)
        {
            using (var connection = CreateConnection())
            {
                return connection.QueryFirstOrDefault<ChartOfAccount>("SELECT * FROM ChartOfAccounts WHERE AccountID = @AccountId", new { AccountId = accountId });
            }
        }

        public int Insert(ChartOfAccount account)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("INSERT INTO ChartOfAccounts (AccountNumber, AccountName, AccountType, AccountGroup, OpeningBalance) VALUES (@AccountNumber, @AccountName, @AccountType, @AccountGroup, @OpeningBalance); SELECT CAST(SCOPE_IDENTITY() as int)", account);
            }
        }

        public int Update(ChartOfAccount account)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("UPDATE ChartOfAccounts SET AccountNumber = @AccountNumber, AccountName = @AccountName, AccountType = @AccountType, AccountGroup = @AccountGroup, OpeningBalance = @OpeningBalance WHERE AccountID = @AccountID", account);
            }
        }

        public int Delete(int accountId)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("DELETE FROM ChartOfAccounts WHERE AccountID = @AccountId", new { AccountId = accountId });
            }
        }
    }
}
