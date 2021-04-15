namespace EmailService
{
    public interface IEmailSender
    {
        void SendEmail(EmailMessage message);
    }
}
