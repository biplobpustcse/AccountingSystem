using AccountingSystem.Models.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccountingSystem.DAL.Repositories
{
    public class VATTaxRepository
    {
        private readonly string _connectionString;

        public VATTaxRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // VATTax Operations

        public IEnumerable<VATTax> GetAll()
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<VATTax>("SELECT * FROM VATTaxes");
            }
        }

        public VATTax GetById(int vatId)
        {
            using (var connection = CreateConnection())
            {
                return connection.QueryFirstOrDefault<VATTax>("SELECT * FROM VATTaxes WHERE VATID = @VATId", new { VATId = vatId });
            }
        }

        public int Insert(VATTax vatTax)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("INSERT INTO VATTaxes (VATRate, EffectiveDate) VALUES (@VATRate, @EffectiveDate); SELECT CAST(SCOPE_IDENTITY() as int)", vatTax);
            }
        }

        public int Update(VATTax vatTax)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("UPDATE VATTaxes SET VATRate = @VATRate, EffectiveDate = @EffectiveDate WHERE VATID = @VATID", vatTax);
            }
        }

        public int Delete(int vatId)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute("DELETE FROM VATTaxes WHERE VATID = @VATId", new { VATId = vatId });
            }
        }
    }
}
