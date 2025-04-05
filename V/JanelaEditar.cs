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
using eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.M;

namespace eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.V
{
    public partial class JanelaEditar: Form
    {
        private readonly AtualizarLista _atualizador;
        private readonly int _idUsuario;
        public JanelaEditar(AtualizarLista atualizador, int idUsuario)
        {
            InitializeComponent();
            _atualizador = atualizador;
            _idUsuario = idUsuario;
            nudEditar.Value = _idUsuario;
            NudEditar_ValueChanged(this, EventArgs.Empty);
        }
        private void NudEditar_ValueChanged(object sender, EventArgs e)
        {
            Usuario usuarioAtual = new ManipulaDB().GetUsuario((int)nudEditar.Value);

            if (usuarioAtual != null )
            {
                txbNameEdit.Text = usuarioAtual.Name;
                txtEmailEdit.Text = usuarioAtual.Email;
            }
            else
            {
                txbNameEdit.Text = "Usuario não encontrado";
                txtEmailEdit.Text = "Usuario não encontrado";
            }
        }

        private void BtnConfirmarEdit_Click(object sender, EventArgs e)
        {
            if (new BancoDeDados().UpdateUsuarioPorId((int)nudEditar.Value, txbNameEdit.Text, txtEmailEdit.Text))
            {
                _atualizador.AtualizarGrid();
                this.Close();
            }
            else
                MessageBox.Show("Erro ao atualiza!");
        }
    }
}
