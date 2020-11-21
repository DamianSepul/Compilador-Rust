using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compi_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_LEXICO_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txb_codigofuente.Clear();
        }

        private void Sintactico_btn_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ejecutar_Click(object sender, EventArgs e)
        {
            var Lexico = new Lexico(CodigoFuente_Txb.Text);
            Lexico.EjecutadorLexico();

            var lista_token = new BindingList<Token>(Lexico.ListaToken);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista_token;
            
            var objSintactico = new Sintactico(Lexico.ListaToken);
            List<Error> listaErroresLexico = Lexico.ListaError;
            List<Error> listaErroresSintactico = objSintactico.listaError;
            List<Varia> ListaVariables = objSintactico.listaVariables;
            
            List<Error> listaErrores = listaErroresLexico.Union(listaErroresSintactico).ToList();

            
            //var lista_error = new BindingList<Error>(Lexico.ListaError);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaErrores;

            varia_dgv.DataSource = null;
            varia_dgv.DataSource = ListaVariables;

          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CodigoFuente_Txb.Clear();
        }
    }
}
