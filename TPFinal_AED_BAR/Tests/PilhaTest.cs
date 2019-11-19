using System;
using System.Diagnostics;
using TPFinal_AED_BAR.EstruturasDeDados.Pilha;

namespace TPFinal_AED_BAR.Tests {
    class PilhaTest {
        private Pilha pilha;
        public PilhaTest() {
            pilha = new Pilha();
        }

        public PilhaTest(Pilha pilha) {
            this.pilha = pilha;
        }

        public double empilhaTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            pilha.empilha(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double dempilhaTest() {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            pilha.desempilhar();
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double pesquisaTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            pilha.pesquisa(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
