using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Tests {
    static class Relatorio {
        public static String gerarRelatorio(String[] sequencia) {
            String StrPilha = "\tResultados dos testes em Pilha";
            String StrFila = "\tResultado dos testes em Fila";
            String StrArvore = "\tResultado dos testes em Arvore";
            String StrHash = "\tResultado dos testes em Hash";
            String StrLista = "\tResultado dos testes em Lista";

            Double vrTimePilha = 0;
            Double vrTimeFila = 0;
            Double vrTimeArvore = 0;
            Double vrTimeHash = 0;
            Double vrTimeLista = 0;

            PilhaTest pilhaT = new PilhaTest();
            FilaTest filaT = new FilaTest();
            ArvoreTest arvoreT = new ArvoreTest();
            ListaTest listaT = new ListaTest();
            HashTest hashT = new HashTest();

            for(int i = 0;i < sequencia.Length;i++) {
                vrTimePilha += pilhaT.empilhaTest(sequencia[i]);
                vrTimeFila += filaT.enfileiraTest(sequencia[i]);
                vrTimeArvore += arvoreT.insereTest(int.Parse(sequencia[i]));
                vrTimeHash += listaT.insereFimTest(sequencia[i]);
                vrTimeLista += hashT.insereTest(1, sequencia[i]);
            }

            StrPilha += "\nInserção da Sequência(ms): " + vrTimePilha
                       + "\nDeleção de um elemento; " + pilhaT.dempilhaTest()
                       + "\nPesquisa de um elemento: " + pilhaT.pesquisaTest(sequencia[(int) sequencia.Length / 2]);

            StrFila += "\nInserção da Sequência(ms): " + vrTimeFila
                       + "\nDeleção de um elemento; " + filaT.denfileiraTest()
                       + "\nPesquisa de um elemento: " + filaT.pesquisaTest(sequencia[(int) sequencia.Length / 2]);

            StrArvore += "\nInserção da Sequência(ms): " + vrTimeArvore
                        + "\nDeleção de um elemento; " + arvoreT.removeTest(int.Parse(sequencia[(int) sequencia.Length - 1]))
                        + "\nPesquisa de um elemento: " + arvoreT.pesquisaTest(int.Parse(sequencia[(int) sequencia.Length / 2]));

            StrHash += "\nInserção da Sequência(ms): " + vrTimeHash
                        + "\nDeleção de um elemento; " + hashT.removeTest(1, sequencia[(int) sequencia.Length - 1])
                        + "\nPesquisa de um elemento: " + hashT.pesquisaTest(1, sequencia[(int) sequencia.Length / 2]);

            StrLista += "\nInserção da Sequência(ms): " + vrTimeLista
                       + "\nDeleção de um elemento; " + listaT.removeTest(sequencia[(int) sequencia.Length - 1])
                       + "\nPesquisa de um elemento: " + listaT.pesquisaTest(sequencia[(int) sequencia.Length / 2]);

            return (StrPilha
                + "\n\n\t**********************************\n\n" + StrFila
                + "\n\n\t**********************************\n\n" + StrArvore
                + "\n\n\t**********************************\n\n" + StrHash
                + "\n\n\t**********************************\n\n" + StrLista
                + "\n\n");
        }
    }
}
