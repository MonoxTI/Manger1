using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manger1
{
    internal class DataHandler
    {
        string connect = "Server = MONOX\\MSSQLSEERVER01 ; Inital Catalog = Propety; Integrated Security = SSPI";

        public void Addprperty(string PropertyName, int Rent, int Levy, int BondInterest, int Rates, string Descrip, int Total, int Income, int Expenses, string TenantName, DateTime StartDate, DateTime EndDate)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("[dbo].AddProperty", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PropertyName", PropertyName);
                cmd.Parameters.AddWithValue("@Rent", Rent);
                cmd.Parameters.AddWithValue("@Levy", Levy);
                cmd.Parameters.AddWithValue("@BondInterest", BondInterest);
                cmd.Parameters.AddWithValue("@RatesAndTaxes", Rates);
                cmd.Parameters.AddWithValue("Description", Descrip);
                cmd.Parameters.AddWithValue("@Total", Total);
                cmd.Parameters.AddWithValue("@Income", Income);
                cmd.Parameters.AddWithValue("@Tenant", TenantName);
                cmd.Parameters.AddWithValue("@Expenses", Expenses);
                cmd.Parameters.AddWithValue("@OwnershipStartDate", StartDate);
                cmd.Parameters.AddWithValue("@OwnershipEndDate", EndDate);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }
        public DataTable getPrp()
        {
            SqlConnection conn = new SqlConnection(connect);
            SqlDataAdapter adapter = new SqlDataAdapter("GetProp", conn)
            return
        }

    }
}
