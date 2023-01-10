using Microsoft.AspNetCore.Mvc;
using SMSNotification.Model;
using System.Data;
using System.Text.Json;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SMSNotification.DAL
{
    public class DbClass2:IConnection

    {
        private readonly Irepo a;


        public DbClass2(Irepo irepo)
        {
            a = irepo;                               // Service class for Database Connection       
        }
        string AuthToken = "64a088a3ba870cf37acb0ade7c758cf1";
        string AccountSId = "ACfb38078598f7f8b0ea87d0a13f1395a0";

        public string SendMessage(UserInput obj)
        {
            DataSet dataSet = a.GetSMSTemplate(obj);
            TwilioClient.Init(AccountSId, AuthToken);
            var message = MessageResource.Create(
                body: obj.Message,
                from: new Twilio.Types.PhoneNumber("+19519163027"),
                //from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                //to: new Twilio.Types.PhoneNumber("whatsapp:+919366064267")
                to: new Twilio.Types.PhoneNumber(obj.PhNo)
                );
            if (message != null)
            {

                {
                    Response Response = new Response();
                    Response.StatusCode = "200";
                    Response.Status = "True";
                    Response.Message = "Notification Sent";
                    string strjson = JsonSerializer.Serialize<Response>(Response);//to change the dot net object to  JSon object
                    return strjson;


                }
            }
            else
            {
                Response Response = new Response(); ;
                Response.StatusCode = "400";
                Response.Status = "false";
                Response.Message = "Sms not Sent";
                string strjson = JsonSerializer.Serialize<Response>(Response);
                return strjson.ToString();


            }

            }
           

        }
    }

