using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cachorro
{
    public partial class frmLatidoCachorro : Form
    {
        private GerenciadorLatidos _gerenciadorLatidos;

        public frmLatidoCachorro()
        {
            InitializeComponent();
            _gerenciadorLatidos = new GerenciadorLatidos();
            //_gerenciadorLatidos.ExcessoDecibeisEvent += QuandoExcederDecibeis;
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) =>
            {
                ExcessoDecibeisEventArgs eventArgs = (ExcessoDecibeisEventArgs)args;
                MessageBox.Show(string.Format("O cachorro passou dos Limites, com {0} Decibéis!", eventArgs.intensidadeLatido), "Excesso de Decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }

        private void frmLatidoCachorro_Load(object sender, EventArgs e)
        {
            pgbItensidadeLatido.Value = 0;
        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgbItensidadeLatido.Value = _gerenciadorLatidos.Latir();
        }

        /*private void QuandoExcederDecibeis(object sender, EventArgs e)
        {
            ExcessoDecibeisEventArgs eventArgs = (ExcessoDecibeisEventArgs)e;
            MessageBox.Show(string.Format("O cachorro passou dos Limites, com {0} Decibéis!",eventArgs.intensidadeLatido),"Excesso de Decibéis",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }*/
    }
}
