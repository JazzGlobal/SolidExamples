namespace SolidExamples.Example1.Incorrect;

#nullable enable

public class EmailSender_Incorrect : IEmailSender_Incorrect
{
    public string SendEmail(string sender, string receiver, string content)
    {
        var valid_email = ValidateInput(sender, receiver, content);
        if (valid_email == null)
        {
            return "Failed to validate email!";
        }

        return $"{valid_email.sender} sent an email to {valid_email.receiver} with context: {valid_email.content}";
    }

    public Email? ValidateInput(string sender, string receiver, string content)
    {
        if (!string.IsNullOrEmpty(sender) && !string.IsNullOrEmpty(receiver) && !string.IsNullOrEmpty(content))
        {
            return new Email
            {
                sender = sender,
                receiver = receiver,
                content = content
            };
        }

        return null;
    }
}