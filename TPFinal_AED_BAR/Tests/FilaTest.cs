using System;
using System.Diagnostics;
using TPFinal_AED_BAR.EstruturasDeDados;

namespace TPFinal_AED_BAR.Tests {
    class FilaTest {
        private Fila f;
        public FilaTest() {
            f = new Fila();
        }

        public FilaTest(Fila f) {
            this.f = f;
        }

        public double enfileiraTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            f.enfileira(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double denfileiraTest() {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            f.denfileira();
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double getPosicaoTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            f.getItem(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
