using NotificationTemplate.Model;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace NotificationTemplate.DAL
{
    public class DatabaseCon:Idbcon
    {
        private readonly string conn;

        public DatabaseCon(IConfiguration _configuration)
        {
            conn = _configuration.GetConnectionString("DefaultConnection").ToString();
        }

        public int Connection(CreateTemplate createTemplate)
        {


            var con = new OracleConnection(conn);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SP_SMSNOTIFICATION";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("UId", OracleDbType.Double).Value =createTemplate.UId;
            cmd.Parameters.Add("NotificationType", OracleDbType.Varchar2).Value = createTemplate.NotificationType;
            cmd.Parameters.Add("ValidUpto", OracleDbType.Date).Value = createTemplate.templateValidUpto;
            cmd.Parameters.Add("Type", OracleDbType.Varchar2).Value = createTemplate.Type;
            cmd.Parameters.Add("Body", OracleDbType.Varchar2).Value = createTemplate.BodyMessage;
            cmd.Parameters.Add("Message", OracleDbType.Varchar2).Value = createTemplate.Message;
            cmd.Parameters.Add("RequestId ", OracleDbType.Varchar2).Value = createTemplate.RequestId;
            cmd.Parameters.Add("TemplateNo", OracleDbType.Varchar2).Value = createTemplate.TemplateNo;
            
            var a=cmd.ExecuteNonQuery();
            con.Close();
            //t i = cmd.ExecuteNonQuery();


            return 1;
        }
    }
}

