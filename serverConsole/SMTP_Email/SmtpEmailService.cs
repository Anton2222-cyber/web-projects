﻿using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTP_Email
{
    public class SmtpEmailService
    {
        private readonly EmailConfiguration _configuration;
        public SmtpEmailService()
        {
            _configuration = new EmailConfiguration();
        }
        public void Send(Message message)
        {
            var body = new TextPart("html")
            {
                Text = message.Body
            };
            string path = @"C:\\Users\\User\\OneDrive\\Зображення\\1_Лащ Антон.png";
            var attachment = new MimePart("image", "png")
            {
                FileName = "Не для роботи",
                Content = new MimeContent(File.OpenRead(path))
            };


            
            var multipart = new Multipart("mixed");
            multipart.Add(body);
            multipart.Add(attachment);
            //
            string path2 = @"C:\\Users\\User\\OneDrive\\Зображення\\2.Anton_Lashch.png";
            var attachment2 = new MimePart("image", "png")
            {
                FileName = "Не для роботи",
                Content = new MimeContent(File.OpenRead(path2))
            };
            multipart.Add(attachment2);
            //
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_configuration.From));
            emailMessage.To.Add(new MailboxAddress(message.To));
            emailMessage.Subject=message.Subject;
            emailMessage.Body = multipart;

            using(var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_configuration.SmptpServer, _configuration.Port, true);
                    client.Authenticate(_configuration.UserName, _configuration.Password);
                    client.Send(emailMessage);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString);
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        public void DownloadMessages()
        {
            using(var client = new ImapClient())
            {
                client.Connect("imap.ukr.net", 993, MailKit.Security.SecureSocketOptions.SslOnConnect);
                client.Authenticate(_configuration.UserName.ToLower(), _configuration.Password);
                client.Inbox.Open(MailKit.FolderAccess.ReadOnly);
                var uids = client.Inbox.Search(SearchQuery.All);
                foreach(var uid in uids)
                {
                    var message = client.Inbox.GetMessage(uid);
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("From: {0}",message.From);
                    Console.WriteLine("Subject: {0}", message.Subject);
                   message.WriteTo(string.Format("{0}.eml",uid));
                }
                client.Disconnect(true);
            }
        }
    }
}
