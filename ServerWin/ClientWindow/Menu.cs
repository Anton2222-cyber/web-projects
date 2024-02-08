using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWindow
{
    public partial class Menu : Form
    {
        Settings settings;
        IPAddress serverIP;
        int port;
        public Menu()
        {
            InitializeComponent();
            settings = new Settings();
            //наш сервер, який буде отримувать повідомлення
            try
            {
                    serverIP = IPAddress.Parse(settings.IPadress);
                    port = Convert.ToInt32(settings.Port);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не коректні налаштування!");
            }
            //serverIP = IPAddress.Parse("127.0.0.1");
            //port = 9076;
        }
        void SendMessageToServer()
        {          
            try
            {
                //ідентифікація сервер ip+port
                IPEndPoint endPoint = new IPEndPoint(serverIP, port);
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
                MessageBox.Show("Проблема при роботі із сервером "+ ex.ToString());
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if(message.Text != "")
            SendMessageToServer();
        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (message.Text != "")
                    SendMessageToServer();

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    serverIP = IPAddress.Parse(settings.IPadress);
                    port = Convert.ToInt32(settings.Port);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не коректні налаштування!");
            }
        }
    }
}
