using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClientWindow
{
    public partial class Settings : Form
    {
        public string IPadress
        {
            set { IPtxt.Text = value; }
            get { return IPtxt.Text; }
        }
        public string Port
        {

            set { PORTtxt.Text = value; }
            get {return PORTtxt.Text;  }

        }

        public Settings()
        {
            InitializeComponent();
            FileStream fs = new FileStream("settings.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader streamReader = new StreamReader(fs, Encoding.UTF8);
            IPadress = streamReader.ReadLine();
            Port = streamReader.ReadLine();

            streamReader.Dispose();
            fs.Close();


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("settings.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
            StreamWriter streamWriter = new StreamWriter(fs, Encoding.UTF8);
            streamWriter.WriteLine(IPadress);
            streamWriter.WriteLine(Port);

            streamWriter.Dispose();
            fs.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
