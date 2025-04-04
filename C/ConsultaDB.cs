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
    }
}
