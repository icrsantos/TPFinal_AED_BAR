using System;
using System.Collections.Generic;
using System.Text;

namespace TPFinal_AED_BAR.EstruturasDeDados.Fila {
    class Fila {
        private CCelula Frente;
        private CCelula Tras;
        private int Qtde = 0;

        public Fila() {
            Frente = new CCelula();
            Tras = Frente;
        }

        public CCelula getFrente() {
            return Frente;
        }

        public bool Vazia() {
            return Frente == Tras;
        }

        public void enfileira(Object ValorItem) {
            Tras.Prox = new CCelula(ValorItem);
            Tras = Tras.Prox;
            Qtde++;
        }

        public Object desenfileira() {
            Object Item = null;
            if(Frente != Tras) {
                Frente = Frente.Prox;
                Item = Frente.Item;
                Qtde--;
            }
            return Item;
        }

        public bool pesquisa(Object elemento) {
            bool achou = false;
            CCelula aux = Frente.Prox;
            while(aux != null && !achou) {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        public int Quantidade() {
            return Qtde;
        }

        public Object[] imprimir() {
            Object[] itens = new Object[Qtde];
            int index = 0;
            if(Frente != Tras) {
                for(CCelula aux = Frente.Prox;aux != null;aux = aux.Prox) {
                    itens[index] = aux.Item;
                    index++;
                }
            }

            return itens;
        }
    }
}
