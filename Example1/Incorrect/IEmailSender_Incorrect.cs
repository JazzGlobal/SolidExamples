namespace SolidExamples.Example1.Incorrect;

public class Email 
{
    public string sender = "";
    public string receiver = "";
    public string content = "";
}

public interface IEmailSender_Incorrect
{
    public string SendEmail(string sender, string receiver, string content);

    public Email ValidateInput(string sender, string receiver, string content);
}