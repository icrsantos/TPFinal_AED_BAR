using System;
using System.Diagnostics;
using TPFinal_AED_BAR.EstruturasDeDados.ArvoreBinaria;

namespace TPFinal_AED_BAR.Tests {
    class ArvoreTest {
        private ArvoreBinaria arvore;
        public ArvoreTest() {
            arvore = new ArvoreBinaria();
        }

        public ArvoreTest(ArvoreBinaria arvore) {
            this.arvore = arvore;
        }

        public double insereTest(int item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            arvore.InsereNode(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double removeTest(int item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            arvore.Remove(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double pesquisaTest(int item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            arvore.pesquisar(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
