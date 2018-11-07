using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cachorro
{
    public class GerenciadorLatidos
    {
        private int _intensidadeLatido;
        //public delegate void ExcessoDecibeisHandler(object sender, EventArgs e);
        public event EventHandler ExcessoDecibeisEvent;

        public GerenciadorLatidos()
        {
            _intensidadeLatido = 0;
        }

        public int Latir()
        {
            _intensidadeLatido += 10;

            if (_intensidadeLatido > 80)
            {
                ExcessoDecibeisEventArgs e = new ExcessoDecibeisEventArgs
                {
                    intensidadeLatido = _intensidadeLatido
                };

                OnExcessoDecibeis(e);
            }

            return _intensidadeLatido;
        }

        protected virtual void OnExcessoDecibeis(EventArgs e)
        {
            if (ExcessoDecibeisEvent != null)
            {
                ExcessoDecibeisEvent(this, e);
            }

            Func<int, int, double> potenciacao = (@base, potencia) => Math.Pow(@base, potencia);

            Console.WriteLine(potenciacao(2, 3)); // Irá imprimir 8
        }
    }
}
