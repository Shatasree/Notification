using EmailNotiFication.Model;

namespace EmailNotiFication.DAL
{
    public interface IInterface
    {
        public string Sendmail(MailRequest mailRequest);   //  implementation  for Sending Mail  

    }
}
