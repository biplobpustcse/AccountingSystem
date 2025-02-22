using Microsoft.EntityFrameworkCore;
using AccountingSystem.Models.Entities; // Assuming your entities are in this namespace

namespace AccountingSystem.DAL
{
    public class AccountingDbContext : DbContext
    {
        public AccountingDbContext(DbContextOptions<AccountingDbContext> options) : base(options)
        {
        }

        public DbSet<ChartOfAccount> ChartOfAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
        public DbSet<TrialBalance> TrialBalances { get; set; }
        public DbSet<GeneralLedger> GeneralLedgers { get; set; }
        public DbSet<BalanceSheet> BalanceSheets { get; set; }
        public DbSet<IncomeStatement> IncomeStatements { get; set; }
        public DbSet<VATTax> VATTaxes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and any other model-specific settings here

            // ChartOfAccount Relationships
            modelBuilder.Entity<ChartOfAccount>()
                .HasMany(coa => coa.DebitTransactionDetails)
                .WithOne(td => td.DebitAccount)
                .HasForeignKey(td => td.DebitAccountID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<ChartOfAccount>()
                .HasMany(coa => coa.CreditTransactionDetails)
                .WithOne(td => td.CreditAccount)
                .HasForeignKey(td => td.CreditAccountID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<ChartOfAccount>()
                .HasMany(coa => coa.TrialBalances)
                .WithOne(tb => tb.Account)
                .HasForeignKey(tb => tb.AccountID);

            modelBuilder.Entity<ChartOfAccount>()
                .HasMany(coa => coa.GeneralLedgers)
                .WithOne(gl => gl.Account)
                .HasForeignKey(gl => gl.AccountID);

            modelBuilder.Entity<ChartOfAccount>()
                .HasMany(coa => coa.BalanceSheets)
                .WithOne(bs => bs.Account)
                .HasForeignKey(bs => bs.AccountID);

            modelBuilder.Entity<ChartOfAccount>()
                .HasMany(coa => coa.IncomeStatements)
                .WithOne(is1 => is1.Account)
                .HasForeignKey(is1 => is1.AccountID);

            // Transaction Relationships
            modelBuilder.Entity<Transaction>()
                .HasMany(t => t.TransactionDetails)
                .WithOne(td => td.Transaction)
                .HasForeignKey(td => td.TransactionID);

            // TransactionDetail Relationships
            modelBuilder.Entity<TransactionDetail>()
                .HasOne(td => td.Transaction)
                .WithMany(t => t.TransactionDetails)
                .HasForeignKey(td => td.TransactionID);

            modelBuilder.Entity<TransactionDetail>()
                .HasOne(td => td.DebitAccount)
                .WithMany(coa => coa.DebitTransactionDetails)
                .HasForeignKey(td => td.DebitAccountID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<TransactionDetail>()
                .HasOne(td => td.CreditAccount)
                .WithMany(coa => coa.CreditTransactionDetails)
                .HasForeignKey(td => td.CreditAccountID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<TransactionDetail>()
                .HasOne(td => td.VATTax)
                .WithMany()
                .HasForeignKey(td => td.VATID)
                .IsRequired(false); // VAT is optional

            // TrialBalance Relationships
            modelBuilder.Entity<TrialBalance>()
                .HasOne(tb => tb.Account)
                .WithMany(coa => coa.TrialBalances)
                .HasForeignKey(tb => tb.AccountID);

            // GeneralLedger Relationships
            modelBuilder.Entity<GeneralLedger>()
                .HasOne(gl => gl.Account)
                .WithMany(coa => coa.GeneralLedgers)
                .HasForeignKey(gl => gl.AccountID);

            modelBuilder.Entity<GeneralLedger>()
                .HasOne(gl => gl.Transaction)
                .WithMany()
                .HasForeignKey(gl => gl.TransactionID);

            // BalanceSheet Relationships
            modelBuilder.Entity<BalanceSheet>()
                .HasOne(bs => bs.Account)
                .WithMany(coa => coa.BalanceSheets)
                .HasForeignKey(bs => bs.AccountID);

            // IncomeStatement Relationships
            modelBuilder.Entity<IncomeStatement>()
                .HasOne(is1 => is1.Account)
                .WithMany(coa => coa.IncomeStatements)
                .HasForeignKey(is1 => is1.AccountID);

            // VATTax (If you have additional configurations for VATTax, add them here)
        }
    }
}