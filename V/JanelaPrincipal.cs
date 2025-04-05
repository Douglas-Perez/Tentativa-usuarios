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
using eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.V;

namespace eu_só_queria_ser_feliz__isso_não_foi_uma_piada_
{
    public partial class JanelaPrincipal : Form
    {
        private readonly AtualizarLista _atualizador;

        public JanelaPrincipal()
        {
            InitializeComponent();
            _atualizador = new AtualizarLista(dataGridPrincipal);
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            _atualizador.AtualizarGrid();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var janelaAdd = new JanelaAdicionar(_atualizador);
            janelaAdd.Show();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            var janelaDelet = new JanelaDeletar(_atualizador);
            janelaDelet.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var janelaEditar = new JanelaEditar(_atualizador, 1);
            janelaEditar.Show();
        }

        private void dataGridPrincipal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idUsuario = Convert.ToInt32(dataGridPrincipal.Rows[e.RowIndex].Cells["id"].Value);

            JanelaEditar formEditar = new JanelaEditar(_atualizador, idUsuario);
            formEditar.Show();
        }
    }
}
