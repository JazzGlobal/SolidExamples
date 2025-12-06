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

    // This interface is not correct because it requires a function that should not be in the public contract. And in our example, the consumer never
    // uses this function. SendEmail validating the input is purely an implementation detail.
    public Email? ValidateInput(string sender, string receiver, string content);
}