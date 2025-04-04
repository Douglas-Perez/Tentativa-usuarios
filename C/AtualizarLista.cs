using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.C
{
    public class AtualizarLista
    {
        private readonly DataGridView _dataGrid;
        private readonly ManipulaDB _db;

        public AtualizarLista(DataGridView dataGrid)
        {
            _dataGrid = dataGrid;
            _db = new ManipulaDB();
        }

        public void AtualizarGrid()
        {
            try
            {
                _dataGrid.Invoke((MethodInvoker)delegate
                {
                    _dataGrid.DataSource = _db.ObterTodosUsuarios();
                    _dataGrid.Columns["id"].FillWeight = 15;
                    _dataGrid.Refresh();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar lista: {ex.Message}");
            }
        }
    }
}
