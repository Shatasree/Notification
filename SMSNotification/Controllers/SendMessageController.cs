using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSNotification.DAL;
using SMSNotification.Model;
using System.Net;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML.Messaging;

namespace SMSNotification.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {

        //string AuthToken = "64a088a3ba870cf37acb0ade7c758cf1";
        //string AccountSId= "ACfb38078598f7f8b0ea87d0a13f1395a0";
        private readonly IConnection b;


        public SendMessageController(IConnection connection) 
        {
            b = connection;

        }


        [HttpPost]
        [Route("SendMessage")]

        public string MessageNotification(UserInput obj)
        {
            var result=b.SendMessage(obj);
            return (result);
            
        }
    }
}
       