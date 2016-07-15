using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CursoDesktop
{
    public partial class InserirCliente : Form
    {
        
        public InserirCliente()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutenção!");
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            nuIdade.Value = 0;
            mskTelefone.Text = "";
            txtEndereco.Text = "";
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
        }
    }
}
