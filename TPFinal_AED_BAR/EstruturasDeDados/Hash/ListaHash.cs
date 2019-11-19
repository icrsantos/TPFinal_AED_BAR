using System;

namespace TPFinal_AED_BAR.EstruturasDeDados.Hash {
    class ListaHash {
        private Celula Primeira; 
        private Celula Ultima; 
        private int Qtde = 0;

        public ListaHash() {
            Primeira = new Celula();
            Ultima = Primeira;
        }

        public bool Vazia() {
            return Primeira == Ultima;
        }

        public void InsereFim(Object ValorItem) {
            Ultima.Prox = new Celula(ValorItem);
            Ultima = Ultima.Prox;
            Qtde++;
        }

        public String imprimir() {
            String itens = "";
            if(Primeira != Ultima) {
                for(Celula aux = Primeira.Prox;aux != null;aux = aux.Prox)
                    itens += aux.Item.ToString() + "; ";
            }

            return itens;
        }

        public bool pesquisar(Object elemento) {
            bool achou = false;
            for(Celula aux = Primeira.Prox;aux != null && !achou;aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        public int Quantidade() {
            return Qtde;
        }
    }
}