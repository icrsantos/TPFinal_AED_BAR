using System;
using System.Diagnostics;
using TPFinal_AED_BAR.EstruturasDeDados.Fila;

namespace TPFinal_AED_BAR.Tests {
    class FilaTest {
        private Fila fila;
        public FilaTest() {
            fila = new Fila();
        }

        public FilaTest(Fila fila) {
            this.fila = fila;
        }

        public double enfileiraTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            fila.enfileira(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double denfileiraTest() {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            fila.desenfileira();
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double getPosicaoTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            fila.pesquisa(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
