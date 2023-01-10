using EmailNotiFication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Net.Mail;

namespace EmailNotiFication.DAL
{
    public class DbClass : Irepo2
    {

        private readonly string _Conn;
        public DbClass(IConfiguration configuration)
        {
            _Conn = configuration.GetConnectionString("DefaultConnection");   // Database Connection String
        }

        public DataSet GetTemplate(MailRequest mailRequest)
        {


            DataSet ds = new DataSet();
            var con = new OracleConnection(_Conn);
            con.Open();
            OracleCommand cmd = new OracleCommand("select*from  SMSNOTIFICATIOON where TemplateNo='" + mailRequest.TemplateNo + "' AND NOTIFICATIONTYPE='" + mailRequest.NotificationType + "'", con);
            OracleDataAdapter odp = new OracleDataAdapter(cmd);       //odp for retriving and saving data
            odp.Fill(ds);
            con.Close();
            return ds;

        }

       

      
        }
    }

