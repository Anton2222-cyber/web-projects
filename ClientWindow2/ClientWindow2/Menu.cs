using System.Net.Sockets;
using System.Net;
using System.Text;
using ClientWindow2.Data;
using ClientWindow2.Data.Entities;
using System.IO;

namespace ClientWindow2
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            LoadSettings();

        }
        void SendMessageToServer()
        {
            try
            {
                //ідентифікація сервер ip+port
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IPtxt.Text), Convert.ToInt32(PORTtxt.Text));
                Socket client = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                //підключення до сервера
                client.Connect(endPoint);

                byte[] data = Encoding.Unicode.GetBytes(message.Text);
                client.Send(data); //відправляємо повідомелння в байтах
                //очікуємо відповіді від сервера
                data = new byte[1024];
                int bytes = 0; //розмір повідомлення від сервера
                do
                {
                    bytes = client.Receive(data); //отримує інформацію від сервера
                    MessageBox.Show("Нам прислав сервер " + Encoding.Unicode.GetString(data));


                } while (client.Available > 0);
                client.Shutdown(SocketShutdown.Both); //завершуємо зяднання із сервером
                client.Close(); //закриваємо повне зяднання

            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема при роботі із сервером " + ex.ToString());
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (message.Text != "")
                SendMessageToServer();
        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (message.Text != "")
                    SendMessageToServer();

        }
        void LoadSettings()
        {
            var context = new AppEFContext();
            IPtxt.Text = context.Settings.FirstOrDefault().IpAdress;
            PORTtxt.Text = context.Settings.FirstOrDefault().Port.ToString();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new AppEFContext();
                var setting = context.Settings.FirstOrDefault();
                setting.IpAdress = IPtxt.Text;
                setting.Port = Convert.ToInt32(PORTtxt.Text);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не коректні налаштування!");
                LoadSettings();
            }

        }
    }
}