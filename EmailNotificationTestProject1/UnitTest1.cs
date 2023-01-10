using EmailNotiFication.Controllers;
using EmailNotiFication.DAL;
using EmailNotiFication.Model;
using Moq;

namespace EmailNotificationTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var ExpectedResult = "{\"StatusCode\":\"200\",\"Status\":\"True\",\"Message\":\"notification sent\"}";
            MailRequest mailRequest = new MailRequest();
            var IInterface = new Mock<IInterface>();
            IInterface.Setup(x => x.Sendmail(It.IsAny<MailRequest>())).Returns(ExpectedResult);
            var APIController = new APIController(IInterface.Object);
            mailRequest.ToEmail = "das.shatasree2015@gmail.com";
            mailRequest.From = "shatasree.das@indusnet.co.in";
            mailRequest.Subject = "Security Purpose";
            mailRequest.Body = "be Secure with ur data";
            mailRequest.TemplateNo = "2";
            var result=APIController.SendMailNotification(mailRequest);
            Assert.Equal(ExpectedResult, result);

        }
    }
}