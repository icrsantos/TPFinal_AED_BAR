using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.EstruturasDeDados.ArvoreBinaria {
    class NodeInfo {

        public Node Node;
        public string Text;
        public int posicaoInicial;
        public int Tamanho { get { return Text.Length; } }
        public int PosicaoFinal { get { return posicaoInicial + Tamanho; } set { posicaoInicial = value - Tamanho; } }
        public NodeInfo parente, esq, dir;


    }
}
