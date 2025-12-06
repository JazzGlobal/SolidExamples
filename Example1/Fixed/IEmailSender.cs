namespace SolidExamples.Example1.Fixed;

public class Email 
{
    public string sender = "";
    public string receiver = "";
    public string content = "";
}

public interface IEmailSender
{
    public string SendEmail(string sender, string receiver, string content);
}