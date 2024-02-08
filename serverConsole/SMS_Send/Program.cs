using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Numerics;

namespace SMS_Send
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appiKey = "uab32de40b2fd39e1ab3d152661c5f7c72f905db5a664dedf03bf5c1d0a82fa99cf20b";
            string phoneNumber = "+380966207377";
            string txt ="Привіт від Антона";

            string url = $"https://api.mobizon.ua/service/message/sendsmsmessage?recipient={phoneNumber}&text={txt}&apiKey={appiKey}";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader sr = new StreamReader(dataStream);
                string data = sr.ReadToEnd();
                Console.WriteLine(data);
            }
            response.Close();
        }
    }
}