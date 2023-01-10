using Oracle.ManagedDataAccess.Client;
//using SMSNotification.Interfaces;
using SMSNotification.Model;
using System.Data;

namespace SMSNotification.DAL
{
    public class DbClass1 : Irepo
    {
        private readonly string Conn;
        public DbClass1(IConfiguration configuration)
        {
            Conn = configuration.GetConnectionString("DefaultConnection");
        }

      

        public DataSet GetSMSTemplate(UserInput userInput)
        {
            DataSet ds = new DataSet();
            var con = new OracleConnection(Conn);
            con.Open();
            OracleCommand cmd = new OracleCommand("select*from  SMSNOTIFICATIOON where TemplateNo='" + userInput.TemplateNo + "' AND NOTIFICATIONTYPE='" + userInput.NotificationType + "'", con);
            OracleDataAdapter odp = new OracleDataAdapter(cmd);       //odp for retriving and saving data
            odp.Fill(ds);
            con.Close();
            return ds;




        }
        //{   DataSet ds = new DataSet();
        //    var con = new OracleConnection(Conn);
        //    con.Open();
        //    if (userInput.TemplateNo ==1 )
        //    {
        //        OracleCommand cmd = new OracleCommand("select*from  SMSNOTIFICATIOON where TemplateNo='" + userInput.TemplateNo + "' AND NOTIFICATIONTYPE='" + userInput.NotificationType, con);
        //    }
        //    else if (userInput.TemplateNo == 2 )
        //    {
        //        OracleCommand cmd = new OracleCommand("select*from  SMSNOTIFICATIOON where TemplateNo='" + userInput.TemplateNo + "' AND NOTIFICATIONTYPE='" + userInput.NotificationType, con);
        //    }
        //    OracleDataAdapter odp = new OracleDataAdapter(cmd);
        //    odp.Fill(ds);
        //    con.Close();
        //    return ds;

            // throw new NotImplementedException();

        }
    }

