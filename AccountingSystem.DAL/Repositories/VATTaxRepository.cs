using AccountingSystem.Models.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccountingSystem.DAL.Repositories
{
    public class VATTaxRepository
    {
        private readonly DapperContext context;

        public VATTaxRepository(DapperContext context)
        {
            this.context = context;
        }

        public IEnumerable<VATTax> GetAll()
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Query<VATTax>("SELECT * FROM VATTaxes");
            }
        }

        public VATTax GetById(int vatId)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.QueryFirstOrDefault<VATTax>("SELECT * FROM VATTaxes WHERE VATID = @VATId", new { VATId = vatId });
            }
        }

        public int Insert(VATTax vatTax)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Execute("INSERT INTO VATTaxes (VATRate, EffectiveDate) VALUES (@VATRate, @EffectiveDate); SELECT CAST(SCOPE_IDENTITY() as int)", vatTax);
            }
        }

        public int Update(VATTax vatTax)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Execute("UPDATE VATTaxes SET VATRate = @VATRate, EffectiveDate = @EffectiveDate WHERE VATID = @VATID", vatTax);
            }
        }

        public int Delete(int vatId)
        {
            using (var connection = context.CreateConnection())
            {
                return connection.Execute("DELETE FROM VATTaxes WHERE VATID = @VATId", new { VATId = vatId });
            }
        }
    }
}
