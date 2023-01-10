using EmailNotiFication.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EmailNotiFication.DAL
{
    public interface Irepo2
    {
        public DataSet GetTemplate(MailRequest mailRequest);    // Implementing for Databasee Connection
       
      
    }
}
