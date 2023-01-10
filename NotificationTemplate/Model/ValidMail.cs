using System.Text.RegularExpressions;

namespace NotificationTemplate.Model
{
    public class ValidMail
    {
      
            //public static bool EmailValidation(UserRequest userDetails)
            //{
            //    //string mail=new 
            //    string Email = userDetails.ToEmail;
            //    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //    Match match = regex.Match(Email);
            //    if (match.Success)

            //        return true;
            //    else
            //        return false;
            //}

       public  bool EmailValidation(UserRequest userDetails)
        {
            //CreateTemplate createTemplate1 = new CreateTemplate();
            string Email = userDetails.ToEmail;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            if (match.Success)
            {
                return true ;
            }
            else
            {
                return false ;
            }



               
            //else
               // return false;
          //  throw new NotImplementedException();
        }
    }
    public class UserRequest
    {
        public string ToEmail { get; set; }
        public string phNo{ get; set; }
        //public string Body { get; set; }
    }
    public class Response
    {
        public string StatusCode { get; set; }
       
        public string TemplateNo{ get; set; }
        public string Message { get; set; }

    }


}
