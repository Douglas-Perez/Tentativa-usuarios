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
        public JanelaDeletar(AtualizarLista atualizador)
        {
            InitializeComponent();
            _atualizador = atualizador;
        }

        private void BtnCancelarAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            _atualizador.AtualizarGrid();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudDeletar.Value);
            ManipulaDB mDB = new ManipulaDB();
            if (mDB.DeletarUsuario(id))
                this.Close();
            _atualizador.AtualizarGrid();
        }
    }
}
