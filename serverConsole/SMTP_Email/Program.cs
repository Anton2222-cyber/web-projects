namespace SMTP_Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            SmtpEmailService emailService = new SmtpEmailService();
            Message info = new Message()
            {
                Subject = "Відпочинок",
                Body = "Не втрачаємо час треба іти купатись",
                To = "antonlashch@icloud.com"
            };
            string html=File.ReadAllText("html/index.html");

            info.Body = html;
            emailService.Send(info);
           // emailService.DownloadMessages();
           // Console.WriteLine("Робота");
        }
    }
}