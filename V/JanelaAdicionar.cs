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
    public partial class JanelaAdicionar : Form
    {
        private readonly AtualizarLista _atualizador;

        public JanelaAdicionar(AtualizarLista atualizador)
        {
            InitializeComponent();
            _atualizador = atualizador;
        }

        private void BtnConfirmarAdd_Click(object sender, EventArgs e)
        {
            if (new ManipulaDB().AdicionarUsuario(txbNameAdd.Text, txbEmailAdd.Text))
            {
                _atualizador.AtualizarGrid();
                this.Close();
            }
        }

        private void BtnCancelarAdd_Click(object sender, EventArgs e)
        {
            _atualizador.AtualizarGrid();
            this.Close();
        }
    }
}
