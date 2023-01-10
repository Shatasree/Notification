namespace NotificationTemplate.Model
{
    public class CreateTemplate
    {
        public string NotificationType { get; set; }
        public string Type { get; set; }
        public DateTime templateValidUpto { get; set; }
        public string Message { get; set; }
        public string BodyMessage { get; set; }
        public string RequestId { get; set; }
        public string TemplateNo { get; set; }
        public string UId { get; set; }

    }
}
