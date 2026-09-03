using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_MVC1;

namespace CapaVista_MVC1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        string nombreTabla = "tbl_departamentos";
        Controlador controlador = new Controlador();

        public void actualizarDataGridView()
        {
            DataTable dtVista = controlador.llenarDgv(nombreTabla);
            Dgv_consultar.DataSource = dtVista;
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }
    }
}
