using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasArvores {
    class Node {

        #region Atributos de node
        public Object item;
        public Node pai;
        public Node esq;
        public Node dir;
        #endregion

        #region Construtora default
        /// <summary>
        /// Inicializa uma nova instância do nó, atribuindo null aos atributos pai, item, dir e esq. 
        /// </summary>
        public Node() {
            this.item = null;
            this.pai = null;
            this.esq = null;
            this.dir = null;
        }
        #endregion
        
        #region Contrutora recebendo apenas o item
        /// <summary>
        /// Inicializa uma nova instância do node atribuindo o valor passado por parâmetro ao atributo item e atribuindo null aos atributos pai, dir e esq.
        /// </summary>
        /// <param name="valorItem"></param>
        public Node(Object valorItem) {
            this.item = valorItem;
            this.pai = null;
            this.esq = null;
            this.dir = null;
        }
        #endregion

        #region Contrutor recebendo valorItem, pai, esq e dir
        /// <summary>
        /// Inicializa um node atribuindo valorItem ao atributo Item, referência "pai" ao atributo pai, referência direita ao atributo dir e referência esquerda ao atributo esq.
        /// </summary>
        /// <param name="valorItem"></param>
        /// <param name="pai"></param>
        /// <param name="esquerda"></param>
        /// <param name="direita"></param>
        public Node(Object valorItem, 
                    Node pai, 
                    Node esquerda, 
                    Node direita) {

            this.item = valorItem;
            this.pai = pai;
            this.esq = esquerda;
            this.dir = direita;
        }
        #endregion

        #region Construtora que cria um filho e aponta para o pai
        /// <summary>
        /// Inicializa um node atribuindo valorItem ao atributo Item, referência "pai" ao atributo pai e null aos atributos "dir" e "esq"
        /// </summary>
        /// <param name="valorItem"></param>
        /// <param name="pai"></param>
        /// <param name=""></param>
        public Node(Object valorItem, Node pai) {

            this.item = valorItem;
            this.pai = pai;
            this.esq = null;
            this.dir = null;
        }
        #endregion


    }//fim class
}//fim namespace
