using Microsoft.AspNetCore.Mvc;
using SMSNotification.Model;

namespace SMSNotification.DAL
{
    public interface IConnection
    {
        public string SendMessage(UserInput obj);
    }
}
