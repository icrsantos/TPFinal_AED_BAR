using System;
using System.Diagnostics;
using TPFinal_AED_BAR.EstruturasDeDados;

namespace TPFinal_AED_BAR.Tests {
    class PilhaTest {

        private Pilha p;
        public PilhaTest() {
            p = new Pilha();
        }

        public PilhaTest(Pilha p) {
            this.p = p;
        }

        public double empilhaTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            p.empilha(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double dempilhaTest() {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            p.dempilha();
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double getPosicaoTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            p.getItem(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
