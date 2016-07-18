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
using AcessoDados;


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
            DBCliente dbCliente = new DBCliente();
            dbCliente.InserirCliente(txtNome.Text.Trim(),Convert.ToInt32(nuIdade.Value.ToString()), mskTelefone.Text.Trim(), txtEndereco.Text.Trim(), (rbMasculino.Checked ? 'M' : 'F'));
            
            MessageBox.Show("Cadastro Realizado com Sucesso");
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
