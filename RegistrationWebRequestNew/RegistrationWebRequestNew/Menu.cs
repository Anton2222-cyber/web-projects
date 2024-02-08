using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RegistrationWebRequestNew.dto;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RegistrationWebRequestNew
{
    public partial class Menu : Form
    {
        // string url;
        public Menu()
        {
            InitializeComponent();
            dataGridViewDB.ReadOnly = true;
            dataGridViewDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridViewDB.ForeColor = Color.Red;
            dataGridViewDB.Font = new Font("Impact", 12);
            dataGridViewDB.BackgroundColor = Color.Black;


            // dataGridViewDB.AutoResizeColumns();
            FillDataDB();
        }
        public static string GetDatabaseData(string apiUrl)
        {
            try
            {
                // Create a WebRequest with the API URL
                WebRequest request = WebRequest.Create(apiUrl);

                // Set the method to GET
                request.Method = "GET";

                // Get the response from the API
                using (WebResponse response = request.GetResponse())
                {
                    // Read the response stream
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Read the data from the response stream
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            // Parse the JSON data as a string
                            string jsonData = reader.ReadToEnd();
                            return jsonData;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle any errors that might occur during the request
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        void FillDataDB()
        {

            string apiUrl = "https://pv113.itstep.click/api/account/users";
            // Call the method to get data from the database
            string jsonData = GetDatabaseData(apiUrl);

            // Now you can work with the retrieved JSON data
            if (jsonData != null)
            {
                List<RegisterUserDTO> users = JsonConvert.DeserializeObject<List<RegisterUserDTO>>(jsonData);
                // dataGridViewDB.DataSource = users;

                try
                {
                    new Filler().Fill(dataGridViewDB, users);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show("Select path", filePath);
                textPhoto.Text = dlg.FileName;
            }
        }
        private static string ImageToBase64(string path)
        {
            try
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
            catch (Exception ex)
            {
                //textPhoto.Text = "";
                MessageBox.Show("Не Корректний шлях фото!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

        }
        void ClearTextBoxes()
        {
            textFirstname.Text = "";
            textSecondname.Text = "";
            textEmail.Text = "";
            textPhone.Text = "";
            textPassword.Text = "";
            textConfirmpassword.Text = "";
            textPhoto.Text = "";
        }
        private void btnLogOn_Click(object sender, EventArgs e)
        {
            // textPhoto.Text = "";
            var user = new RegisterUserDTO();
            user.FirstName = textFirstname.Text;
            user.SecondName = textSecondname.Text;
            user.Email = textEmail.Text;
            user.Phone = textPhone.Text;
            user.Password = textPassword.Text;
            user.ConfirmPassword = textConfirmpassword.Text;
            string img = textPhoto.Text;
            user.Photo = ImageToBase64(img);

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
                                                     // MessageBox.Show("User info " + data);//виводимо дані на екран, що зробив сервак
                    ClearTextBoxes();
                    FillDataDB();
                    MessageBox.Show("Успішно зареєстрований");
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

                            // MessageBox.Show(errorResponseData);

                            //string pattern = @"\[\""([^\""]*)\""\]";
                            //MatchCollection matches = Regex.Matches(errorResponseData, pattern);
                            //string error="";
                            //foreach (Match match in matches)
                            //{
                            //    // Збіги знаходяться у групі з індексом 1
                            //    error+=match.Groups[1].Value+"\n";
                            //}
                            JObject jsonObject = JObject.Parse(errorResponseData);


                            // Витягуємо назви помилок
                            JObject errorsObject = (JObject)jsonObject["errors"];
                            string errors = "";
                            foreach (var error in errorsObject)
                            {
                                string fieldName = error.Key;
                                string[] errorMessages = error.Value.ToObject<string[]>();

                                errors += "Поле: " + fieldName + "\n";
                                //Console.WriteLine("Повідомлення про помилку:");
                                foreach (string errorMessage in errorMessages)
                                {
                                    errors += errorMessage + "\n";
                                }
                                errors += "\n";

                            }


                            MessageBox.Show(errors, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("WebException: " + ex.Message);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}