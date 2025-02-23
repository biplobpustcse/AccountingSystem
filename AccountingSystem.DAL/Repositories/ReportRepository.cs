using AccountingSystem.Models.Entities;
using Dapper;

namespace AccountingSystem.DAL.Repositories
{
    public class ReportRepository
    {
        private readonly DapperContext context;

        public ReportRepository(DapperContext context)
        {
            this.context = context;
        }

        public IEnumerable<TrialBalance> GetTrialBalance(DateTime endDate)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Query<TrialBalance>(@"
                    SELECT
                        ca.AccountNumber,
                        ca.AccountName,
                        SUM(CASE WHEN t.DebitAccountID = ca.AccountID THEN t.Amount ELSE 0 END) AS DebitBalance,
                        SUM(CASE WHEN t.CreditAccountID = ca.AccountID THEN t.Amount ELSE 0 END) AS CreditBalance
                    FROM ChartOfAccounts ca
                    LEFT JOIN Transactions t ON ca.AccountID = t.DebitAccountID OR ca.AccountID = t.CreditAccountID
                    WHERE t.TransactionDate <= @EndDate
                    GROUP BY ca.AccountNumber, ca.AccountName;", new { EndDate = endDate });
            }
        }

        public IEnumerable<GeneralLedger> GetGeneralLedger(int accountId, DateTime startDate, DateTime endDate)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Query<GeneralLedger>(@"
                    SELECT
                        t.TransactionDate,
                        t.TransactionNumber,
                        t.Description,
                        t.Reference,
                        CASE WHEN t.DebitAccountID = @AccountId THEN t.Amount ELSE 0 END AS DebitAmount,
                        CASE WHEN t.CreditAccountID = @AccountId THEN t.Amount ELSE 0 END AS CreditAmount
                    FROM Transactions t
                    WHERE (t.DebitAccountID = @AccountId OR t.CreditAccountID = @AccountId)
                        AND t.TransactionDate BETWEEN @StartDate AND @EndDate
                    ORDER BY t.TransactionDate;", new { AccountId = accountId, StartDate = startDate, EndDate = endDate });
            }
        }

        public IEnumerable<BalanceSheet> GetBalanceSheet(DateTime asOfDate)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Query<BalanceSheet>(@"
                    -- Assets
                    SELECT
                        ca.AccountNumber,
                        ca.AccountName,
                        SUM(CASE
                                WHEN t.DebitAccountID = ca.AccountID THEN t.Amount
                                WHEN t.CreditAccountID = ca.AccountID THEN -t.Amount -- Subtract credits for asset accounts
                                ELSE 0
                            END) AS Balance,
                            'Asset' as AccountType
                    FROM ChartOfAccounts ca
                    LEFT JOIN Transactions t ON ca.AccountID = t.DebitAccountID OR ca.AccountID = t.CreditAccountID
                    WHERE ca.AccountType = 'Asset' AND t.TransactionDate <= @AsOfDate
                    GROUP BY ca.AccountNumber, ca.AccountName

                    UNION ALL

                    -- Liabilities
                    SELECT
                        ca.AccountNumber,
                        ca.AccountName,
                        SUM(CASE
                                WHEN t.CreditAccountID = ca.AccountID THEN t.Amount
                                WHEN t.DebitAccountID = ca.AccountID THEN -t.Amount -- Subtract debits for liability accounts
                                ELSE 0
                            END) AS Balance,
                            'Liability' as AccountType
                    FROM ChartOfAccounts ca
                    LEFT JOIN Transactions t ON ca.AccountID = t.DebitAccountID OR ca.AccountID = t.CreditAccountID
                    WHERE ca.AccountType = 'Liability' AND t.TransactionDate <= @AsOfDate
                    GROUP BY ca.AccountNumber, ca.AccountName

                    UNION ALL

                    -- Equity
                    SELECT
                        ca.AccountNumber,
                        ca.AccountName,
                        SUM(CASE
                                WHEN t.CreditAccountID = ca.AccountID THEN t.Amount
                                WHEN t.DebitAccountID = ca.AccountID THEN -t.Amount -- Subtract debits for equity accounts
                                ELSE 0
                            END) AS Balance,
                            'Equity' as AccountType
                    FROM ChartOfAccounts ca
                    LEFT JOIN Transactions t ON ca.AccountID = t.DebitAccountID OR ca.AccountID = t.CreditAccountID
                    WHERE ca.AccountType = 'Equity' AND t.TransactionDate <= @AsOfDate
                    GROUP BY ca.AccountNumber, ca.AccountName

                    UNION ALL

                     -- Revenue
                     SELECT
                         ca.AccountNumber,
                         ca.AccountName,
                         SUM(CASE
                                 WHEN t.CreditAccountID = ca.AccountID THEN t.Amount
                                 WHEN t.DebitAccountID = ca.AccountID THEN -t.Amount -- Subtract debits for equity accounts
                                 ELSE 0
                             END) AS Balance,
                             'Revenue' as AccountCategory
                     FROM ChartOfAccounts ca
                     LEFT JOIN Transactions t ON ca.AccountID = t.DebitAccountID OR ca.AccountID = t.CreditAccountID
                     WHERE ca.AccountType = 'Revenue' --AND t.TransactionDate <= @AsOfDate
                     GROUP BY ca.AccountNumber, ca.AccountName;

                      -- Expense
                     SELECT
                         ca.AccountNumber,
                         ca.AccountName,
                         SUM(CASE
                                 WHEN t.CreditAccountID = ca.AccountID THEN t.Amount
                                 WHEN t.DebitAccountID = ca.AccountID THEN -t.Amount -- Subtract debits for equity accounts
                                 ELSE 0
                             END) AS Balance,
                             'Expense' as AccountCategory
                     FROM ChartOfAccounts ca
                     LEFT JOIN Transactions t ON ca.AccountID = t.DebitAccountID OR ca.AccountID = t.CreditAccountID
                     WHERE ca.AccountType = 'Expense' --AND t.TransactionDate <= @AsOfDate
                     GROUP BY ca.AccountNumber, ca.AccountName;", new { AsOfDate = asOfDate });


            }
        }

        public IEnumerable<IncomeStatement> GetIncomeStatement(DateTime startDate, DateTime endDate)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Query<IncomeStatement>(@"
                    -- Revenue
                    SELECT
                        ca.AccountNumber,
                        ca.AccountName,
                        SUM(CASE
                                WHEN t.CreditAccountID = ca.AccountID THEN t.Amount
                                WHEN t.DebitAccountID = ca.AccountID THEN -t.Amount -- Subtract debits for revenue accounts
                                ELSE 0
                            END) AS Balance,
                            'Revenue' as AccountType
                    FROM ChartOfAccounts ca
                    LEFT JOIN Transactions t ON ca.AccountID = t.DebitAccountID OR ca.AccountID = t.CreditAccountID
                    WHERE ca.AccountType = 'Revenue'
                        AND t.TransactionDate BETWEEN @StartDate AND @EndDate
                    GROUP BY ca.AccountNumber, ca.AccountName

                    UNION ALL

                    -- Expenses
                    SELECT
                        ca.AccountNumber,
                        ca.AccountName,
                        SUM(CASE
                                WHEN t.DebitAccountID = ca.AccountID THEN t.Amount
                                WHEN t.CreditAccountID = ca.AccountID THEN -t.Amount -- Subtract credits for expense accounts
                                ELSE 0
                            END) AS Balance,
                            'Expense' as AccountType
                    FROM ChartOfAccounts ca
                    LEFT JOIN Transactions t ON ca.AccountID = t.DebitAccountID OR ca.AccountID = t.CreditAccountID
                    WHERE ca.AccountType = 'Expense'
                        AND t.TransactionDate BETWEEN @StartDate AND @EndDate
                    GROUP BY ca.AccountNumber, ca.AccountName;", new { StartDate = startDate, EndDate = endDate });
            }
        }
    }
}