using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SendToEmail.Data;
using SendToEmail.Data.Entities;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SendToEmail
{
    public partial class Menu : Form
    {
        AppEFContext context;
        string currentFile;
        List<string> formatsList;
        public Menu()
        {
            InitializeComponent();
            context = new AppEFContext();
            formatsList = new List<string>();
            DGVUsers.ForeColor = Color.Red;
            DGVUsers.Font = new Font("Impact", 12);
            DGVUsers.BackgroundColor = Color.Black;
            labelSaveData.Visible = false;

            //context.Users.Add(new UserEntity() { Email = "antonlashch@icloud.com", FullName = "Лащ Антон Вадимович", NumberPhone = "0662609970" });
            //context.Users.Add(new UserEntity() { Email = "lashchanton@gmail.com", FullName = "Лащ Антон Вадимович", NumberPhone = "0662609970" });
            //context.SaveChanges();

            //DGVUsers.DataSource = (from user in context.Users
            //                       select new { user.Id, user.FullName, user.NumberPhone, user.Email }).ToList();
            //DGVUsers.DataSource = context.Users;
            // DGVUsers.EditMode = DataGridViewEditMode.EditOnKeystroke;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rows = new List<UserEntity>();
            foreach (DataGridViewRow row in DGVUsers.Rows)
            {
                rows.Add(new UserEntity
                {
                    //Id = Convert.ToInt32(row.Cells[0].Value),
                    FullName = row.Cells[1].Value.ToString(),
                    NumberPhone = row.Cells[2].Value.ToString(),
                    Email = row.Cells[3].Value.ToString()
                });
            }
            foreach (var entity in context.Users)
            {
                context.Users.Remove(entity);
            }

            context.Users.AddRange(rows);

            context.SaveChanges();
            UpdateCheckBoxEmail();
            labelSaveData.Visible = true;
            timer1.Start();

        }


        private void DGVUsers_KeyDown(object sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in DGVUsers.SelectedRows)
                {
                    context.Users.Remove(context.Users.Where(x => row.Cells[1].Value == x.FullName && x.Email == row.Cells[3].Value && x.NumberPhone == row.Cells[2].Value).FirstOrDefault());
                }
            }
            context.SaveChanges();
            DGVUsers.DataSource = context.Users.ToList();
            UpdateCheckBoxEmail();
            labelDelete.Visible = true;
            timer1.Start();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPhone.Text) || string.IsNullOrEmpty(textBoxEmail.Text))
            {
                //MessageBox.Show("Оберіть файл!");
                labelErroeAdd.Visible = true;
                timerAddUser.Start();
                return;
            }

            context.Users.Add(new UserEntity() { FullName = textBoxName.Text, NumberPhone = textBoxPhone.Text, Email = textBoxEmail.Text });
            context.SaveChanges();
            DGVUsers.DataSource = context.Users.ToList();
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            labelSuccesAdd.Visible = true;
            timerAddUser.Start();
            //MessageBox.Show("Успішно додано!");
            UpdateCheckBoxEmail();

        }
        void UpdateCheckBoxEmail()
        {
            comboBoxEmails.Items.Clear();
            foreach (DataGridViewRow row in DGVUsers.Rows)
            {
                bool b = false;
                foreach (string item in comboBoxEmails.Items)
                {
                    if (string.Compare(item, row.Cells[3].Value.ToString()) == 0)
                    {
                        b = true;
                        break;
                    }
                }
                if (!b)
                    comboBoxEmails.Items.Add(row.Cells[3].Value);

            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DGVUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGVUsers.AutoResizeColumns();
            DGVUsers.DataSource = context.Users.ToList();
            DGVUsers.AllowUserToAddRows = true;
            UpdateCheckBoxEmail();

        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                currentFile = dlg.FileName;
            IsCanAdd();
        }
        void IsCanAdd()
        {
            if (string.IsNullOrEmpty(currentFile) || string.IsNullOrEmpty(comboBoxFormats.Text))
            {
                //MessageBox.Show("Оберіть файл!");
                return;
            }
            buttonAddToList.Enabled = true;
            //comboBoxFormats.Text = "";
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxFiles.SelectedIndex;
                listBoxFiles.Items.RemoveAt(index);
                formatsList.RemoveAt(index);
            }
            catch (Exception ex)
            {

            }

        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {

            SmtpEmailService emailService = new SmtpEmailService();

            Message info = new Message()
            {
                Subject = textBoxSubject.Text,
                Body = textBoxBody.Text,
                To = comboBoxEmails.SelectedItem.ToString()

            };
            string html = File.ReadAllText("html/index.html");
            html = html.Replace("{$Title}", info.Subject);
            html = html.Replace("{$MyBody}", info.Body);
            info.Body = html;
            emailService.Send(info, listBoxFiles, formatsList);
            textBoxSubject.Text = "";
            textBoxBody.Text = "";
            comboBoxEmails.Text = "";
            listBoxFiles.Items.Clear();
            labelSend.Visible = true;
            timerSend.Start();
            //MessageBox.Show("Успішно надіслано!");


            //string html = File.ReadAllText("html/index.html");
            //info.Body = html;

            // emailService.DownloadMessages();
            // Console.WriteLine("Робота");
        }

        private void comboBoxFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsCanAdd();

        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Add(currentFile);
            currentFile = "";
            buttonAddToList.Enabled = false;
            formatsList.Add(comboBoxFormats.Text);
            comboBoxFormats.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaveData.Visible = false;
            labelDelete.Visible = false;
            timer1.Stop();
        }

        private void timerAddUser_Tick(object sender, EventArgs e)
        {
            labelErroeAdd.Visible = false;
            labelSuccesAdd.Visible = false;

            timerAddUser.Stop();
        }

        private void timerSend_Tick(object sender, EventArgs e)
        {
            labelSend.Visible = false;
        }
    }
}