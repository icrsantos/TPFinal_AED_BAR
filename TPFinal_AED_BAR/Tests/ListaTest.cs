using System;
using System.Diagnostics;
using TPFinal_AED_BAR.EstruturasDeDados.Lista;

namespace TPFinal_AED_BAR.Tests {
    class ListaTest {
        private Lista lista;
        public ListaTest() {
            lista = new Lista();
        }

        public ListaTest(Lista lista) {
            this.lista = lista;
        }

        public double insereFimTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            lista.InsereFim(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double removeTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            lista.Remove(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double pesquisaTest(Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            lista.pesquisa(item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
