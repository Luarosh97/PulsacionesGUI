using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;


namespace PulsacionesGUI
{
    public partial class ConsultarPersonaGui : Form
    {
        PersonaService personaservice = new PersonaService();
        public ConsultarPersonaGui()
        {
            InitializeComponent();
        }


        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            DgvTablaPersonas.DataSource = null;
            RespuestaConsulta respuestaConsulta = personaservice.Consultar();
            if (TipoConsultaCmb.Text.Equals("Todos"))
            {
                DgvTablaPersonas.DataSource = respuestaConsulta.Personas;
                personaservice.TotalizarPersonas();
                Totalinscritostxt.Text = personaservice.TotalizarPersonas().ToString();
               TotalMujerestxt.Text =personaservice.TotalizarMujeres().ToString();
               TotalHombrestxt.Text = personaservice.TotalizarHombres().ToString();
            }
            else
            {
                if (TipoConsultaCmb.Text.Equals("Masculino"))
                {
                    DgvTablaPersonas.DataSource = personaservice.ListaHombres();
                }
                else
                {
                    DgvTablaPersonas.DataSource = personaservice.ListaMujeres();
                }
            }

        }
    }
}
