using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wf_macadress_20190529
{
    public partial class Form1 : Form
    {
        public MoreMethodGetMAC adress;
        public GetMAC deviceMac;
        public Form1()
        {
            InitializeComponent();
            adress = new MoreMethodGetMAC();
            deviceMac = new GetMAC();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            string macadress1 = "";
            string macadress2 = "";
            string macadress3 = "";
            macadress1 = adress.GetMacAddress();

            macadress2 = deviceMac.GetMACAddress();
            macadress3 = deviceMac.GetNetMACAddress();
            richTextBox1.Text += macadress1 +"    " + macadress2 + "    " + macadress3 + "    ";
        }
    }
}
