using SMSNotification.Model;
using System.Data;

namespace SMSNotification.DAL
{
    public interface Irepo
    {
        public DataSet GetSMSTemplate(UserInput userInput);
    }
}
