using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDomain.ViewModel;
using WebAppRepository.Interface;

namespace WebAppRepository.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        public PaymentRepository()
        {

        }
       

        public PaymentDetails CreatePayDetails(PaymentDetails objpay)
        {
            PaymentDetails obj = new PaymentDetails();
            SqlConnection sqlConnection;
            using (var db= new PaymentDBContext())
            {
                sqlConnection = (SqlConnection)db.Database.GetDbConnection();
                using(SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "proc_CreatePaymentDetails";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CardOwnerName", objpay.CardOwnerName));
                    cmd.Parameters.Add(new SqlParameter("@CardNumber", objpay.CardNumber));
                    cmd.Parameters.Add(new SqlParameter("@CardExpirationDate", objpay.CardExpirationDate));
                    cmd.Parameters.Add(new SqlParameter("@CVV", objpay.CVV));

                    if (sqlConnection.State.Equals(ConnectionState.Closed))
                    { sqlConnection.Open(); }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
            }
                return obj;
        }
        public PaymentDetails UpdatePayDetails (){
            PaymentDetails obj = new PaymentDetails();
            return obj;
        }
        public PaymentDetails GetAllDetails() {
            PaymentDetails obj = new PaymentDetails();
            return obj;
        }
        public PaymentDetails DeleteDetails() {
            PaymentDetails obj = new PaymentDetails();
            return obj;
        }

        public  IEnumerable<PaymentDetails> GetDetails() {

           IEnumerable<PaymentDetails> obj = new List<PaymentDetails>();
            SqlConnection sqlConnection;
            using (var db = new PaymentDBContext())
            {
                sqlConnection = (SqlConnection)db.Database.GetDbConnection();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "proc_GetPaymentDetails";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;                 
                    if (sqlConnection.State.Equals(ConnectionState.Closed))
                    { sqlConnection.Open(); }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    obj = (from d in ds.Tables[0].AsEnumerable()
                           select new PaymentDetails()
                           {
                               PMId = d.Field<int>("PMId"),
                               CardOwnerName = d.Field<string>("CardOwnerName"),
                               CardExpirationDate = d.Field<string>("CardExpirationDate"),
                               CardNumber = d.Field<string>("CardNumber"),
                               CVV = d.Field<string>("CVV")
                           }).ToList<PaymentDetails>();
                          
                }
            }
            return obj;
        }
    }
}
