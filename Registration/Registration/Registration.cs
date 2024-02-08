using Newtonsoft.Json;
using Registration.Data;
using Registration.Data.Entities;
using System.Net;
using System.Text;

namespace Registration
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            FillGrid();
            UsersDataGridView.ForeColor = Color.Red;
            UsersDataGridView.Font = new Font("Impact", 12);
            UsersDataGridView.BackgroundColor = Color.Black;
            //DataGridViewColumn column= new DataGridViewImageColumn();
        }
        void FillGrid()
        {
            try
            {
                new Filler().Fill(UsersDataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void choosePhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                // MessageBox.Show("Select path", filePath);
                photoPathTxt.Text = filePath;
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(photoPathTxt.Text) || string.IsNullOrEmpty(passwordTxt.Text) || string.IsNullOrEmpty(nicknameTxt.Text))
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }
            //Отримуємо байти із файлу
            byte[] imgBytes = File.ReadAllBytes(photoPathTxt.Text);
            string base64 = Convert.ToBase64String(imgBytes);
            UploadDTO upload = new UploadDTO
            {
                Photo = base64
            };
            string json = JsonConvert.SerializeObject(upload);
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            string serverUrl = "https://pv113.itstep.click";
            WebRequest request = WebRequest.Create($"{serverUrl}/api/gallery/upload");
            request.Method = "POST";
            request.ContentType = "application/json";
            using (var stream = request.GetRequestStream())
            {
                stream.Write(bytes, 0, bytes.Length);
            }
            try
            {
                var context = new AppEFContext();
                var user = new UserEntity();
                var response = request.GetResponse();
                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    string data = stream.ReadToEnd();
                    var resp = JsonConvert.DeserializeObject<UploadResponseDTO>(data);
                    user.PhotoUrl = serverUrl + resp.Image;
                    // txtPath.Text = serverUrl + resp.Image;
                }
                user.Nickname = nicknameTxt.Text;
                user.Password = passwordTxt.Text;
                context.Users.Add(user);
                context.SaveChanges();
                MessageBox.Show("Успішно зареєстровано!");
                photoPathTxt.Text = "";
                passwordTxt.Text = "";
                nicknameTxt.Text = "";
                FillGrid();
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}