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
                //������������� ������ ip+port
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IPtxt.Text), Convert.ToInt32(PORTtxt.Text));
                Socket client = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                //���������� �� �������
                client.Connect(endPoint);

                byte[] data = Encoding.Unicode.GetBytes(message.Text);
                client.Send(data); //����������� ����������� � ������
                //������� ������ �� �������
                data = new byte[1024];
                int bytes = 0; //����� ����������� �� �������
                do
                {
                    bytes = client.Receive(data); //������ ���������� �� �������
                    MessageBox.Show("��� ������� ������ " + Encoding.Unicode.GetString(data));


                } while (client.Available > 0);
                client.Shutdown(SocketShutdown.Both); //��������� �������� �� ��������
                client.Close(); //��������� ����� ��������

            }
            catch (Exception ex)
            {
                MessageBox.Show("�������� ��� ����� �� �������� " + ex.ToString());
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
                MessageBox.Show("�� ������� ������������!");
                LoadSettings();
            }

        }
    }
}