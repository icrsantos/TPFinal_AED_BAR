using System;
using System.Diagnostics;
using TPFinal_AED_BAR.EstruturasDeDados;

namespace TPFinal_AED_BAR.Tests {
    class ListaTest {
        private Lista l;
        public ListaTest() {
            l = new Lista();
        }

        public ListaTest(Lista l) {
            this.l = l;
        }

        public double insereInicioTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            l.insereInicio(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double insereFimTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            l.insereFim(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double inserePosicaoTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            l.inserePosicao(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double removeTest() {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            l.remove();
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double removeItemTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            l.remove(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double getPosicaoTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            l.getItem(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
