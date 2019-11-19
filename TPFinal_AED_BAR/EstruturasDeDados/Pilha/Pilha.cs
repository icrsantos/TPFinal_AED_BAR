using System;
using System.Collections.Generic;
using System.Text;

namespace TPFinal_AED_BAR.EstruturasDeDados.Pilha {
    class Pilha {
        private CCelula topo = null;
        private int Qtde = 0;

        public bool Vazia() {
            return topo == null;
        }

        public void empilha(Object ValorItem) {
            topo = new CCelula(ValorItem, topo);
            Qtde++;
        }

        public int Quantidade() { 
            return Qtde;
        }

        public CCelula getTopo() {
            return topo;
        }

        public Object desempilhar() {
            Object item = null;
            if(topo != null) {
                item = topo.Item;
                topo = topo.Prox;
                Qtde--;
            }

            return item;
        }

        public bool pesquisa(Object item) {
            bool achou = false;
            CCelula aux = topo;
            while(aux != null && !achou) {
                achou = aux.Item.Equals(item);
                aux = aux.Prox;
            }
            return achou;
        }

        public Object[] imprimir() {
            Object[] itens = new Object[Qtde];
            int index = 0;
            if(topo != null) {
                for(CCelula aux = topo;aux != null;aux = aux.Prox) {
                    itens[index] = aux.Item;
                    index++;
                }
            }

            return itens;
        }
    }
}
