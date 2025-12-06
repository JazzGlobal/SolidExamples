
using SolidExamples.Example1.Incorrect;

// Example 1: Send an email using the public interface. 

using SolidExamples.Example1;
using SolidExamples.Example1.Fixed;

IEmailSender_Incorrect emailSender = new EmailSender_Incorrect();

emailSender.SendEmail("chris@gmail.com", "ken@gmail.com", "pair ah maters");

// The production code only ever utilizes IEmailSender_Incorrect.SendEmail. Therefore the public contract should not include 
// IEmailSender_Incorrect.ValidateEmails.