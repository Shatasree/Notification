using EmailNotiFication.Model;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Net.Mail;
using System.Text.Json;

namespace EmailNotiFication.DAL
{
    public class DbInterface : IInterface            //Service Class


    {
        private readonly Irepo2 a;
    

        public DbInterface(Irepo2 irepo2)
        {
            a = irepo2;                               // Service class for Database Connection       
        }
        public string Sendmail(MailRequest mailRequest)
        {
             if (ValidMail.EmailValidation(mailRequest))
                {
                    DataSet dataSet =a.GetTemplate(mailRequest);
                    MailMessage mail = new MailMessage();
                    mail.To.Add(mailRequest.ToEmail);
                    mail.From = new MailAddress("shatasree.das@indusnet.co.in");
                    mail.Subject = dataSet.Tables[0].Rows[0]["MESSAGE"].ToString();
                    mail.Body = dataSet.Tables[0].Rows[0]["BODY"].ToString();
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("shatasree.das@indusnet.co.in", "wubbtgpulqqszwzs"); // Enter seders User name and password  
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    if (mailRequest != null)
                    {
                        MailResponse mailResponse = new MailResponse();
                        mailResponse.Status = "True";
                        mailResponse.StatusCode = "200";
                        mailResponse.Message = "notification sent";
                        string strjson=JsonSerializer.Serialize<MailResponse>(mailResponse);//to change the dot net object to  JSon object
                     
                        return  strjson;

                        
                      }
                    else
                    {
                        MailResponse mailResponse = new MailResponse();
                         mailResponse.StatusCode = "400";
                         mailResponse.Status = "false";
                         mailResponse.Message = "Mail not Sent";
                        string strjson = JsonSerializer.Serialize<MailResponse>(mailResponse);
                        return strjson.ToString();


                    }

                }
                else
                {
                    return ("Mail Should be in proper Stracture");
                }

            }

        }
    }

