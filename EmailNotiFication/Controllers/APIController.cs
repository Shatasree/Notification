using EmailNotiFication.DAL;
using EmailNotiFication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq.Expressions;
using System.Net.Mail;

namespace EmailNotiFication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {

        private readonly IInterface b;


        public APIController(IInterface @interface) //Calling IInterface
        {
            b = @interface;

        }



        [HttpPost]
        [Route("api/v0.0.1/notification/sendemailnotification")]

        public string SendMailNotification(MailRequest mailRequest)

        {
            string status = b.Sendmail(mailRequest);
            return status;




        }
    }
}

      