using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_tingy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pfButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ipTextBox.Text) || string.IsNullOrEmpty(portTextBox.Text))
            {
                consoleTextBox.AppendText("Please input correct external IP and PORT\r\nOn format: Num.Num.Num.Num and XXXX\r\n");
            }

            else
            {
                NATUPNPLib.UPnPNAT upnpnat = new NATUPNPLib.UPnPNAT();
                NATUPNPLib.IStaticPortMappingCollection mappings = upnpnat.StaticPortMappingCollection;

                foreach (NATUPNPLib.IStaticPortMapping portMapping in mappings)
                {
                    consoleTextBox.AppendText(portMapping + "\r\n");
                }

                int addport = int.Parse(portTextBox.Text);

                mappings.Add(addport, "TCP", addport, "192.168.51.164", true, "Game server");
                mappings.Add(addport, "UDP", addport, "192.168.51.164", true, "Game Server");

            }
        }

        private void pfremoveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(portRemoveTextBox.Text))
            {
                consoleTextBox.AppendText("Please input correct PORT\r\nOn format: XXXX\r\n");
            }

            else
            {
                NATUPNPLib.UPnPNAT upnpnat = new NATUPNPLib.UPnPNAT();
                NATUPNPLib.IStaticPortMappingCollection mappings = upnpnat.StaticPortMappingCollection;

                int removeport = int.Parse(portRemoveTextBox.Text);

                mappings.Remove(removeport, "TCP");
                mappings.Remove(removeport, "UDP");
            }
        }
    }
}
