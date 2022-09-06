using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTARIO_MENU_1
{
    public partial class Notificaciones : UserControl
    {
        public Notificaciones()
        {
            InitializeComponent();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gunaLinkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://benkyufisica.server2.trinchera.dev/");
        }
    }
}
