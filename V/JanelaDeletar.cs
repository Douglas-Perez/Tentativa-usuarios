using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.C;

namespace eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.V
{
    public partial class JanelaDeletar: Form
    {
        private readonly AtualizarLista _atualizador;
        public JanelaDeletar()
        {
            InitializeComponent();
        }

        private void btnCancelarAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            _atualizador.AtualizarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Gostaria de DELETAR o usuario de id {nudDeletar.Value}", "Você tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("exclui");
            } 
        }
    }
}
