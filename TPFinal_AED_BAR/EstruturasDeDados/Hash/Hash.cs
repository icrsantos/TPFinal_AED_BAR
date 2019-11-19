using System;
using System.Collections.Generic;
using System.Text;

namespace TPFinal_AED_BAR.EstruturasDeDados.Hash {

    class Hash {
        private int quntidade;
        private ListaHash[] tabela;
        private int tamanhoTbl;

        public Hash(int size = 3) {
            quntidade = 0;
            tamanhoTbl = size;
            tabela = new ListaHash[tamanhoTbl];

            this.preencheTabela();
        }

        private void preencheTabela() {
            for(int i = 0;i < tamanhoTbl;i++)
                tabela[i] = new ListaHash();
        }

        private int hash(int chave) {
            return (int) ( chave % tamanhoTbl );
        }

        public Object pesquisa(int chave, Object item) {
            int posicao = hash(chave);
            return ( (ListaHash) ( tabela[posicao] ) ).pesquisar(item);
        }

        public void remove(int chave, Object item) {
            int posicao = hash(chave);
            ( (ListaHash) ( tabela[posicao] ) ).Remove(item);
        }

        public void inserir(int chave, Object Item) {
            if(chave < tamanhoTbl) {
                int posicao = hash(chave);
                bool adicionado = false;

                ListaHash lista = ( (ListaHash) ( tabela[posicao] ) );
                if(lista != null && lista.pesquisar(Item)) {
                    inserir(( posicao + 1 ), Item);
                } else {
                    if(!adicionado) {
                        lista.InsereFim(Item);
                        quntidade++;
                    }
                }
            }
        }

        public Object[] imprimir() {
            Object[] itens = new Object[tabela.Length];
            for(int i = 0;i < tabela.Length;i++) {
                int chave = hash(i);
                ListaHash elementos = ( (ListaHash) tabela[chave] );
                itens[i] = ("\nChave [" + chave + "] : ") + elementos.imprimir();
            }
            return itens;
        }

        public int Quantidade() {
            int quantidade = 0;
            for(int i = 0;i < tabela.Length;i++) {
                int chave = hash(i);
                ListaHash elementos = ( (ListaHash) tabela[chave] );
               quantidade += elementos.Quantidade();
            }
            return quantidade;
        }
    }
}
