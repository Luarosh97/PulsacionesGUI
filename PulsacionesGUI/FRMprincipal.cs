using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionesGUI
{
    public partial class FRMprincipal : Form
    {
        public FRMprincipal()
        {
            InitializeComponent();
        }

        private void registrarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPersonaFrm registrarpersonafrm = new RegistrarPersonaFrm();
            registrarpersonafrm.Show();

        }
    }
}
