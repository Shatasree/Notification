namespace SMSNotification.Model
{
    public class SMS
    {
        public string From { get; set; }
        public string Body { get; set; }
    }
    public  class  UserInput
    {
        public string PhNo { get; set; }
        public string Message { get; set; }
        public string TemplateNo { get; set; }
        public string  NotificationType{get; set; }
    }
    public class Response
    {
        public string StatusCode { get; set; }
        public string Status { get; set; }
        public string AccountSid { get; set; }
        public string Message { get; set; }
        
    }
   

}
