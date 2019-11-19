using System;

namespace TPFinal_AED_BAR.EstruturasDeDados.Hash {
    public class Celula {
        public Object Item;
        public Celula Prox;

        public Celula() {
            Item = null;
            Prox = null;
        }

        public Celula(object ValorItem) {
            Item = ValorItem;
            Prox = null;
        }

        public Celula(object ValorItem, Celula ProxCelula) {
            Item = ValorItem;
            Prox = ProxCelula;
        }
    }
}