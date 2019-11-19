using System;
using System.Diagnostics;
using TPFinal_AED_BAR.EstruturasDeDados.Hash;

namespace TPFinal_AED_BAR.Tests {
    class HashTest {
        private Hash hash;
        public HashTest() {
            hash = new Hash();
        }

        public HashTest(Hash hash) {
            this.hash = hash;
        }

        public double insereTest(int chave, Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            hash.inserir(chave, item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double removeTest(int chave, Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            hash.remove(chave, item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double pesquisaTest(int chave, Object item) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            hash.pesquisa(chave, item);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
