namespace Vehicles
{
    public interface IMailer
    {
        void SendEmail(string emailAddress, string body);
    }
}