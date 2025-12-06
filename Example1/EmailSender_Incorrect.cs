namespace SolidExamples.Example1;

public class EmailSender_Incorrect : IEmailSender_Incorrect
{
    public string SendEmail(string sender, string receiver, string content)
    {
        throw new NotImplementedException();
    }

    public Email ValidateInput(string sender, string receiver, string content)
    {
        throw new NotImplementedException();
    }
}