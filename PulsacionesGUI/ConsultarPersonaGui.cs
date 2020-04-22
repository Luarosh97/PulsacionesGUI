using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
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
        RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
        string TotalPersonas;
        string TotalHombres;
        string TotalMujeres;
        public ConsultarPersonaGui()
        {
            InitializeComponent();
        }


        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            respuestaConsulta = personaservice.Consultar();
            TotalPersonas = personaservice.TotalizarPersonas().ToString();
            TotalHombres = personaservice.TotalizarHombres().ToString();
            TotalMujeres = personaservice.TotalizarMujeres().ToString();
            Consultar();
        }
        public void Consultar()
        {
            if (TipoConsultaCmb.SelectedIndex == 0)
            {
                dataGridView1.DataSource = respuestaConsulta.Personas;
            }
            else if (TipoConsultaCmb.SelectedIndex == 1)
            {
                dataGridView1.DataSource = personaservice.ListaHombres();
                TotalMujeres = "0";
                TotalPersonas = TotalHombres;
            }
            else
            {
                dataGridView1.DataSource = personaservice.ListaMujeres();
                TotalHombres = "0";
                TotalPersonas = TotalMujeres;
            }
            LlenarCampos();
        }
        public void LlenarCampos()
        {
            TotalHombrestxt.Text = TotalHombres;
            TotalMujerestxt.Text = TotalMujeres;
            Totalinscritostxt.Text = TotalPersonas;
        }
    }
}
