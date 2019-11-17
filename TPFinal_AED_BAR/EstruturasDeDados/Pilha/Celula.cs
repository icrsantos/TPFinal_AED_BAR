using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.EstruturasDeDados.Pilha {
    class Celula {
        public Object item;
        public Celula prox;

        public Celula() {
            this.item = null;
            this.prox = null;
        }

        public Celula(Object item) {
            this.item = item;
            this.prox = null;
        }

        public Celula(Object item, Celula prox) {
            this.item = item;
            this.prox = prox;
        }
    }
}
