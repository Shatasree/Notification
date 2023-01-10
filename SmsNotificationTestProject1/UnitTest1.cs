using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Moq;
using SMSNotification.Controllers;
using SMSNotification.DAL;
using SMSNotification.Model;

namespace SmsNotificationTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var ExpectedResult = "{\"StatusCode\":\"200\",\"Status\":\"True\",\"Message\":\"notification sent\"}";
            UserInput userInput = new UserInput();
            var IConnection = new Mock<IConnection>();
            IConnection.Setup(x => x.SendMessage(It.IsAny<UserInput>())).Returns(ExpectedResult);
            var obj = new SendMessageController(IConnection.Object );
            userInput.PhNo = "+919366064267";
            userInput.Message = "Security Message";
            userInput.TemplateNo = "";
            userInput.NotificationType = "SMS";
            var result = obj.MessageNotification(userInput);
            Assert.Equal(ExpectedResult, result);
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
               

            //var SendMessageController = new sendMessageController(IConnection.Object);
            //mailRequest.ToEmail = "das.shatasree2015@gmail.com";
            //mailRequest.From = "shatasree.das@indusnet.co.in";
            //mailRequest.Subject = "Security Purpose";
            //mailRequest.Body = "be Secure with ur data";
            //mailRequest.TemplateNo = "2";
            //var result = APIController.SendMailNotification(mailRequest);
            //Assert.Equal(ExpectedResult, result);


        }
    }
}