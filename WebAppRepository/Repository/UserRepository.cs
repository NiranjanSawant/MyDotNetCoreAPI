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
    public class UserRepository: IUserRepository
    {
        public UserDetails CreateUserDetails(UserDetails objpay)
        {
            UserDetails obj = new UserDetails();
            SqlConnection sqlConnection;
            using (var db = new PaymentDBContext())
            {
                sqlConnection = (SqlConnection)db.Database.GetDbConnection();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "proc_InsertUpdateUser";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@DisplayName", objpay.firstName+" "+ objpay.lastName));
                    cmd.Parameters.Add(new SqlParameter("@EmailId", objpay.emailId));
                    cmd.Parameters.Add(new SqlParameter("@Gender", objpay.Gender));
                    cmd.Parameters.Add(new SqlParameter("@DOB", objpay.DOB));

                    if (sqlConnection.State.Equals(ConnectionState.Closed))
                    { sqlConnection.Open(); }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
            }
            return obj;
        }
    }
}
