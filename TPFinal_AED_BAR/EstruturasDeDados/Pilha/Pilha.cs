using System;
using System.Collections.Generic;
using System.Text;

namespace TPFinal_AED_BAR.EstruturasDeDados.Pilha {
    class Pilha {
        private Celula topo = null;
        private int quantidade;

        public void empilhar(Object item) {
            if(topo == null)
                topo = new Celula(item);
            else
                topo = new Celula(item, topo.prox);

            quantidade++;
        }

        public Object desempilhar() {
            Object item = null;
            item = topo.item;
            topo = topo.prox;
            quantidade--;
            return item;
        }

        public  
    }
}
