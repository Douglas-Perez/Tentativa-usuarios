using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.M;

namespace eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.C
{
    class ManipulaDB
    {
        public DataTable ObterTodosUsuarios()
        {
            string sql = "SELECT id, name, email, createdAt FROM users";

            return new BancoDeDados().ExecutarConsultas(sql);
        }

        public bool AdicionarUsuario(string name, string email)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro ao adicionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (new BancoDeDados().InserirUsuario(name, email) > 0)
            {
                MessageBox.Show("Usuario adicionado com exito", "Concluido", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao adicionar novo usuario\nVerifique se o email é unico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarUsuario(int id)
        {
            DialogResult resultado = MessageBox.Show($"Gostaria de DELETAR o usuario com id{id}?", "Você tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                BancoDeDados db = new BancoDeDados();
                if (db.AcharUsuario(id))
                {
                    MessageBox.Show("1");
                    db.DeletarUsuario(id);
                    return true;
                }
                MessageBox.Show("2");
                MessageBox.Show("Usuario não encontrado", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            MessageBox.Show("3");
            return false;
        }

        public Usuario GetUsuario(int id)
        {
            Usuario usuario = new BancoDeDados().ObterUsuarioPorId(id);

            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                return null;
            }
        }
    }
}
