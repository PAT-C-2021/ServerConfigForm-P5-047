using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20190140047;

namespace ServerConfigForm_P5_20190140047
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            buttonON.Enabled = false;
            buttonOFF.Enabled = true;
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            buttonON.Enabled = true;
            buttonOFF.Enabled = false;
            labelOnOrOff.Text = "Server OFF";
            labelKet.Text = "Klik ON untuk Menjalankan Server";
            Host.Close();
        }
    }
}
