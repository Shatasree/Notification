using System.Data;
using System.Text.RegularExpressions;

namespace EmailNotiFication.Model
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }              //User Input
        public string TemplateNo { get; set; }
        public string NotificationType { get; set; }
        public string From { get; set; }
    }
    public class MailResponse
    {


        public string StatusCode { get; set; }
        public string Status { get; set; }              //API Return
        public string Message { get; set; }

       
    }
    public class ValidMail
    {
        public static bool EmailValidation(MailRequest userDetails)
        {
         
            string Email = userDetails.ToEmail;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");   // Mail Validation
            Match match = regex.Match(Email);
            if (match.Success)

                return true;
            else
                return false;
        }
    }
}
