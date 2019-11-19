using System;
using System.Collections.Generic;
using System.Text;

namespace TPFinal_AED_BAR.EstruturasDeDados.Lista {
    class Lista {
        private CCelula Primeira;
        private CCelula Ultima;
        private int Qtde = 0;

        public Lista() {
            Primeira = new CCelula();
            Ultima = Primeira;
        }

        public bool Vazia() {
            return Primeira == Ultima;
        }

        public void InsereFim(Object ValorItem) {
            Ultima.Prox = new CCelula(ValorItem);
            Ultima = Ultima.Prox;
            Qtde++;
        }

        public void Remove(Object ValorItem) {
            if(Primeira != Ultima) {
                CCelula aux = Primeira;
                bool achou = false;
                while(aux.Prox != null && !achou) {
                    achou = aux.Prox.Item.Equals(ValorItem);
                    if(!achou)
                        aux = aux.Prox;
                }

                if(achou) {
                    aux.Prox = aux.Prox.Prox;
                    if(aux.Prox == null)
                        Ultima = aux;
                    Qtde--;
                }
            }
        }

        public bool pesquisa(Object elemento) {
            bool achou = false;
            for(CCelula aux = Primeira.Prox;aux != null && !achou;aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        public Object[] imprimir() {
            Object[] itens = new Object[Qtde];
            int index = 0;
            if(Primeira != Ultima) {
                for(CCelula aux = Primeira.Prox;aux != null;aux = aux.Prox) {
                    itens[index] = aux.Item;
                    index++;
                }
            }
            return itens;
        }

        public int Quantidade() {
            return Qtde;
        }

        public CCelula getPrimeira() {
            return Primeira;
        }
    }
}
