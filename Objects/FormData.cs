public class FormData
{
    public string EmailAddress { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }

    public FormData(string emailAddress = "", string subject = "", string body = "")
    {
        EmailAddress = emailAddress;
        Subject = subject;
        Body = body;
    }
}