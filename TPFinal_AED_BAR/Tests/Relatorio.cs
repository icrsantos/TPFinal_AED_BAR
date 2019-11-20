using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Tests {
    static class Relatorio {
        public static SortedList<String, String> gerarRelatorio(String[] sequencia) {
            String StrPilha = "";
            String StrFila = "";
            String StrArvore = "";
            String StrHash = "";
            String StrLista = "";

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

            StrPilha += "\nTempo de Inserção(ms): " + vrTimePilha
                       + "\nTempo de Deleção(ms): " + pilhaT.dempilhaTest()
                       + "\nTempo de Pesquisa(ms): " + pilhaT.pesquisaTest(sequencia[(int) sequencia.Length / 2]);

            StrFila += "\nInserção da Sequência(ms): " + vrTimeFila
                       + "\nTempo de Deleção(ms): " + filaT.denfileiraTest()
                       + "\nTempo de Pesquisa(ms): " + filaT.pesquisaTest(sequencia[(int) sequencia.Length / 2]);

            StrArvore += "\nInserção da Sequência(ms): " + vrTimeArvore
                        + "\nTempo de Deleção(ms): " + arvoreT.removeTest(int.Parse(sequencia[(int) sequencia.Length - 1]))
                        + "\nTempo de Pesquisa(ms): " + arvoreT.pesquisaTest(int.Parse(sequencia[(int) sequencia.Length / 2]));

            StrHash += "\nInserção da Sequência(ms): " + vrTimeHash
                        + "\nTempo de Deleção(ms): " + hashT.removeTest(1, sequencia[(int) sequencia.Length - 1])
                        + "\nTempo de Pesquisa(ms): " + hashT.pesquisaTest(1, sequencia[(int) sequencia.Length / 2]);

            StrLista += "\nInserção da Sequência(ms): " + vrTimeLista
                       + "\nTempo de Deleção(ms): " + listaT.removeTest(sequencia[(int) sequencia.Length - 1])
                       + "\nTempo de Pesquisa(ms): " + listaT.pesquisaTest(sequencia[(int) sequencia.Length / 2]);

            SortedList<String, String> relatorio = new SortedList<String, String>();
            relatorio.Add("PILHA", StrPilha);
            relatorio.Add("FILA", StrFila);
            relatorio.Add("ARVORE", StrArvore);
            relatorio.Add("LISTA", StrLista);
            relatorio.Add("HASH", StrHash);

            return relatorio;
        }
    }
}
