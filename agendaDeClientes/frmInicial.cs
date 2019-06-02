using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaDeClientes
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //ABRIR FRM DE CADASTRO DE CLIENTE
            frmCadastro frmCadastroCliente = new frmCadastro();
            frmCadastroCliente.ShowDialog();

        }
    }
}
