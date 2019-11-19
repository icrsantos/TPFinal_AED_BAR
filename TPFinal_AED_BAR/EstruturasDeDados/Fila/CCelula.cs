using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.EstruturasDeDados
{
    class CCelula
    {
        public Object Item; 
        public CCelula Prox; 

        public CCelula()
        {
            Item = null;
            Prox = null;
        }

        public CCelula(object ValorItem)
        {
            Item = ValorItem;
            Prox = null;
        }

        public CCelula(object ValorItem, CCelula ProxCelula)
        {
            Item = ValorItem;
            Prox = ProxCelula;
        }
    }
}
