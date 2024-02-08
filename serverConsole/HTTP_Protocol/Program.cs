using HTTP_Protocol.dto;
using Newtonsoft.Json;
using System.Drawing;
using System.Net;
using System.Text;

namespace HTTP_Protocol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            var user = new RegisterUserDTO();
            user.FirstName = "Антон";    
            user.SecondName = "Лащ";
            user.Email = "lashxhanton@gmail.com";
            user.Phone = "1234567890";
            user.Password = "123456";
            user.ConfirmPassword= "123456";
            string img = "C:\\Users\\User\\OneDrive\\Зображення\\1_Лащ Антон.png";
            user.Photo=ImageToBase64(img);
            //адреса, куди відправляємо запит
            string url = "https://pv113.itstep.click/api/account/register";

            //дані для сервера повинні бути у форматі json
            string json = JsonConvert.SerializeObject(user);
            //json перетворюємо  у масив байтів
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            //Створюємо запит і його підготовлюємо
            WebRequest request = WebRequest.Create(url);//вказуємо адресу
            request.ContentType = "application/json";//формат даних який вказується для сервера
            request.Method = "POST";// тип запиту для сервера
            using (Stream stream = request.GetRequestStream())//у запит записуємо дані для відправки
            {
                stream.Write(bytes, 0, bytes.Length);//дані у вигляді байт
            }
            try
            {
                var response = request.GetResponse();//Відправляємо запит і очікуємо результату
                using (var stream = new StreamReader(response.GetResponseStream()))//читаємо результат від сервера
                {
                    string data = stream.ReadToEnd();//результат у вигляді рядка
                    Console.WriteLine("User info {0}", data);//виводимо дані на екран, що зробив сервак
                }
            }
            catch (WebException ex)
            {
                // Handle web-related exceptions
                if (ex.Response != null)
                {
                    using (Stream errorResponseStream = ex.Response.GetResponseStream())
                    {
                        using (StreamReader errorStreamReader = new StreamReader(errorResponseStream))
                        {
                            string errorResponseData = errorStreamReader.ReadToEnd();
                            Console.WriteLine("Error Response Data:");
                            Console.WriteLine(errorResponseData);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("WebException: " + ex.Message);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public static string ImageToBase64(string path)
        {
            using (Image img = Image.FromFile(path))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    var bytes = ms.ToArray();
                    return Convert.ToBase64String(bytes);
                }
            }
        }
    }
}