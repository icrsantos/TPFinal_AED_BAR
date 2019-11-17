using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasArvores {
    class ArvoreBinaria {

        #region Atributos da classe
        Node raiz;
        int qtde=0;//Quantidade de nodos existentes na árvore
        int altura = 0;
        #endregion

        #region Contrutora default
        /// <summary>
        /// Aloca a raiz da árvore criando um nodo null e aponta as referências "pai", "esquerda" e "direita" para null. 
        /// </summary>
        public ArvoreBinaria() {
            raiz =null;
        }
        #endregion

        #region Retorna a raiz da árvore
        /// <summary>
        /// Retorna a raiz da árvore binária
        /// </summary>
        /// <returns></returns>
        public Node Raiz() {
            return this.raiz;
        }
        #endregion

        #region Retorna a quantidade de nodes na raiz
        /// <summary>
        /// Retorna a quantidade de nodes inseridos na árvore binária.
        /// </summary>
        /// <returns></returns>
        public int Qtde() {
            return this.qtde;
        }
        #endregion

        #region Método de inserir recebendo apenas o valor int
        /// <summary>
        /// Função para inserir o número inteiro na árvore binária
        /// </summary>
        /// <param name="item"></param>
        public void InsereNode(int item) {
            /*Para controlar que o primeiro número passado será sempre a raíz, eu chamo a função de forma recursiva passando a raíz como parâmetro. 
             O método que recebe um node como parâmetro é privado, e só será chamado dento da classe, o método público só recebe o número inteiro.
             É transparente pro usuário, mas meu controle de começar na raiz está garantido.*/
            this.InsereNode(item, raiz);
        }
        #endregion

        #region Método para remover da árvore binária
        /// <summary>
        /// Remove da árvore binária o elemento passado por parâmetro
        /// </summary>
        /// <param name="item"></param>
        public void Remove(int item) {
            this.Remove(item, raiz);
        }
        #endregion
        #region CLASSE PRIVADA para fazer a remoção dos elementos da árvore binária
        private void Remove(int valorItem, Node esteNode) {
            if (esteNode != null) {

                if (valorItem < (int)esteNode.item)
                    Remove(valorItem, esteNode.esq);
                else if (valorItem > (int)esteNode.item)
                    Remove(valorItem, esteNode.dir);
                else {

                    //QUANDO ESTE NODE NÃO TIVER FILHOS
                    if (esteNode.dir == null && esteNode.esq == null) {
                        if (valorItem < (int)esteNode.pai.item)
                            esteNode.pai.esq = null;
                        else
                            esteNode.pai.dir = null;
                        this.qtde--;
                    }
                    //QUANDO ESTE NODE TIVER SÓ 1 FILHO
                    //PELA ESQUERDA
                    else if (esteNode.dir == null && esteNode.esq != null) {
                        //trocar o elemento removido pelo único filho dele
                        if (valorItem > (int)esteNode.pai.item) {
                            esteNode.esq.pai = esteNode.pai;
                            esteNode.pai.dir = esteNode.esq;
                        } else {
                            esteNode.esq.pai = esteNode.pai;
                            esteNode.pai.esq = esteNode.esq;
                        }
                        this.qtde--;
                        //PELA DIREITA
                    } else if (esteNode.dir != null && esteNode.esq == null) {
                        //trocar o elemento removido pelo único filho dele
                        if (valorItem > (int)esteNode.pai.item) {
                            esteNode.dir.pai = esteNode.pai;
                            esteNode.pai.dir = esteNode.dir;
                        } else {
                            esteNode.dir.pai = esteNode.pai;
                            esteNode.pai.esq = esteNode.dir;
                        }
                        this.qtde--;
                        //QUANDO ESTE NODE TIVER 2 FILHOS
                    } else {
                        //Obter o elemento extremo invertido ao lado da subárvore
                        Node aux = ElementoMaisAEsquerda(esteNode.dir);

                        if (valorItem > (int)esteNode.pai.item) {
                            
                            //Mudar as referências do elemento anterior
                            if ((int)aux.item > (int)aux.pai.item)
                                aux.pai.dir = esteNode.dir.dir;
                            else
                                aux.pai.esq = esteNode.esq.esq;

                            //Atualizar o valor do node a ser removido para manter a coerência da arvore binária
                            esteNode.item = aux.item;

                        } else {
                            //Mudar as referências do elemento anterior
                            if ((int)aux.item > (int)aux.pai.item)
                                aux.pai.dir = null;
                            else
                                aux.pai.esq = null;
                            //Atualizar o valor do node a ser removido para manter a coerência da arvore binária
                            esteNode.item = aux.item;
                        }
                        this.qtde--;
                    }
                }
            }
        }
        #endregion

        #region Método para obter o elemento mais a direita
        /// <summary>
        /// Obtém o elemento mais a direita de uma determinada árvore/subárvore a partir de um node passado por parâmetro
        /// </summary>
        /// <param name="esteNode"></param>
        /// <returns></returns>
        public Node ElementoMaisADireita(Node esteNode) {

            if (esteNode != null) {
                if (esteNode.dir == null)
                    return esteNode;
                else
                    return ElementoMaisADireita(esteNode.dir);
            } else
                return null;
        }
        #endregion

        #region Método para obter o elemento mais a esquerda
        /// <summary>
        /// Obtém o elemento mais a esquerda de uma determinada árvore/subárvore a partir de um node passado por parâmetro
        /// </summary>
        /// <param name="esteNode"></param>
        /// <returns></returns>
        public Node ElementoMaisAEsquerda(Node esteNode) {

            if (esteNode != null) {
                if (esteNode.esq == null)
                    return esteNode;
                else
                    return ElementoMaisAEsquerda(esteNode.esq);
            } else
                return null;
        }
        #endregion

        #region Método de inserir passando item e node - MÉTODO PRIVADO. Só será conhecido dentro da classe
        private void InsereNode(int item, Node esteNode) {
            //Essa inserção só será feita na raiz da árvore
            if (esteNode == null) {
                raiz = new Node(item);
                qtde++;
            }
            //Caminhando para a DIREITA
            else if (item > (int)esteNode.item) {
                //validar se pode inserir, pq só consigo inserir quando o próximo node for null
                if (esteNode.dir == null) {
                    esteNode.dir = new Node(item, esteNode);
                    qtde++;
                } else {
                    InsereNode(item, esteNode.dir);
                }
            }
            //Caminhando para a ESQUERDA
            else if (item < (int)esteNode.item) {
                //Validar se pode inser, pq só consigo inserir se o próximo node for null
                if (esteNode.esq == null) {
                    esteNode.esq = new Node(item, esteNode);
                    qtde++;
                } else {
                    InsereNode(item, esteNode.esq);
                }
            }
        }//fim inserir
        #endregion

        #region Método para informar se existe o elemento passado por parâmetro na árvore
        /// <summary>
        /// Retorna um boolean pra informar se um elemento existe na árvore binária. 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="esteNode"></param>
        /// <returns></returns>
        public bool ContemOElementoNaArvore(int item, Node esteNode) {
            
            //Significa que a árvore está vazia
            if (esteNode == null)
                return false;
            //Caminhando para a DIREITA
            else if (item > (int)esteNode.item) {
                    return ContemOElementoNaArvore(item, esteNode.dir);
            } 
            //Caminhando para a ESQUERDA
            else if (item < (int)esteNode.item) {
                return ContemOElementoNaArvore(item, esteNode.esq);
            } 
            else {
                return esteNode.item.Equals(item);
            }
        }
        #endregion

        #region Método de impressão da árvore binária
        /// <summary>
        /// Imprime os elementos da árvore na representação de diagrama.
        /// </summary>
        public void ImprimeArvore() {

            int margemSuperior = 2, margemEsquerda = 2;
            ImprimeArvore(raiz, margemSuperior, margemEsquerda);
        }
        #endregion
        #region MÉTODOS PRIVADOS para fazer a impressão da árvore binária em forma de diagrama
        private void ImprimeArvore(Node raiz, string textFormat = "0", int espacamento = 2, int margemSuperior = 2, int margemEsquerda = 2) {
            if (raiz == null) return;
            int telhado = Console.CursorTop + margemSuperior;
            var ultimo = new List<NodeInfo>();
            var proximo = raiz;
            for (int level = 0; proximo != null; level++) {
                var item = new NodeInfo { Node = proximo, Text = proximo.item.ToString() };
                if (level < ultimo.Count) {
                    item.posicaoInicial = ultimo[level].PosicaoFinal + espacamento;
                    ultimo[level] = item;
                } else {
                    item.posicaoInicial = margemEsquerda;
                    ultimo.Add(item);
                }
                if (level > 0) {
                    item.parente = ultimo[level - 1];
                    if (proximo == item.parente.Node.esq) {
                        item.parente.esq = item;
                        item.PosicaoFinal = Math.Max(item.PosicaoFinal, item.parente.posicaoInicial - 1);
                    } else {
                        item.parente.dir = item;
                        item.posicaoInicial = Math.Max(item.posicaoInicial, item.parente.PosicaoFinal + 1);
                    }
                }
                proximo = proximo.esq ?? proximo.dir;
                for (; proximo == null; item = item.parente) {
                    int top = telhado + 2 * level;
                    ImprimeArvore(item.Text, top, item.posicaoInicial);
                    if (item.esq != null) {
                        ImprimeArvore("/", top + 1, item.esq.PosicaoFinal);
                        ImprimeArvore("_", top, item.esq.PosicaoFinal + 1, item.posicaoInicial);
                    }
                    if (item.dir != null) {
                        ImprimeArvore("_", top, item.PosicaoFinal, item.dir.posicaoInicial - 1);
                        ImprimeArvore("\\", top + 1, item.dir.posicaoInicial - 1);
                    }
                    if (--level < 0) break;
                    if (item == item.parente.esq) {
                        item.parente.posicaoInicial = item.PosicaoFinal + 1;
                        proximo = item.parente.Node.dir;
                    } else {
                        if (item.parente.esq == null)
                            item.parente.PosicaoFinal = item.posicaoInicial - 1;
                        else
                            item.parente.posicaoInicial += (item.posicaoInicial - 1 - item.parente.PosicaoFinal) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, telhado + 2 * ultimo.Count - 1);
        }

        private static void ImprimeArvore(string texto, int teto, int esquerda, int direita = -1) {
            Console.SetCursorPosition(esquerda, teto);
            if (direita < 0) direita = esquerda + texto.Length;
            while (Console.CursorLeft < direita)
                Console.Write(texto);
        }


        private static void SwapColors() {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
        }
        private void ImprimeArvore(NodeInfo item, int teto) {
            SwapColors();
            ImprimeArvore(item.Text, teto, item.posicaoInicial);
            SwapColors();
            if (item.esq != null)
                ImprimeLigacoes(teto + 1, "┌", "┘", item.esq.posicaoInicial + item.esq.Tamanho / 2, item.posicaoInicial);
            if (item.dir != null)
                ImprimeLigacoes(teto + 1, "└", "┐", item.PosicaoFinal - 1, item.dir.posicaoInicial + item.dir.Tamanho / 2);
        }
        private static void ImprimeLigacoes(int top, string inicio, string fim, int posicaoInicial, int posicaoFinal) {
            ImprimeArvore(inicio, top, posicaoInicial);
            ImprimeArvore("─", top, posicaoInicial + 1, posicaoFinal);
            ImprimeArvore(fim, top, posicaoFinal);
        }
        private void ImprimeArvore(Node raiz, int margemSuperior = 2, int margemEsquerda = 2) {
            if (raiz == null) return;
            int telhado = Console.CursorTop + margemSuperior;
            var ultimo = new List<NodeInfo>();
            var proximo = raiz;
            for (int level = 0; proximo != null; level++) {
                var item = new NodeInfo { Node = proximo, Text = proximo.item.ToString() };
                if (level < ultimo.Count) {
                    item.posicaoInicial = ultimo[level].PosicaoFinal + 1;
                    ultimo[level] = item;
                } else {
                    item.posicaoInicial = margemEsquerda;
                    ultimo.Add(item);
                }
                if (level > 0) {
                    item.parente = ultimo[level - 1];
                    if (proximo == item.parente.Node.esq) {
                        item.parente.esq = item;
                        item.PosicaoFinal = Math.Max(item.PosicaoFinal, item.parente.posicaoInicial);
                    } else {
                        item.parente.dir = item;
                        item.posicaoInicial = Math.Max(item.posicaoInicial, item.parente.PosicaoFinal);
                    }
                }
                proximo = proximo.esq ?? proximo.dir;
                for (; proximo == null; item = item.parente) {
                    ImprimeArvore(item, telhado + 2 * level);
                    if (--level < 0) break;
                    if (item == item.parente.esq) {
                        item.parente.posicaoInicial = item.PosicaoFinal;
                        proximo = item.parente.Node.dir;
                    } else {
                        if (item.parente.esq == null)
                            item.parente.PosicaoFinal = item.posicaoInicial;
                        else
                            item.parente.posicaoInicial += (item.posicaoInicial - item.parente.PosicaoFinal) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, telhado + 2 * ultimo.Count - 1);
        }

        #endregion

        #region Impressão simples dos elementos da árvore
        public void ImprimeArvoreSimples(Node esteNode) {
            if (this.raiz != null) {
                Console.Write(esteNode.item + " ");
                if (esteNode.esq != null) {
                    ImprimeArvoreSimples(esteNode.esq);
                }
                if (esteNode.dir != null) {
                    ImprimeArvoreSimples(esteNode.dir);
                }
            }
        }
        #endregion

        #region Calcular a altura da árvore binária
        /// <summary>
        /// Retorna a altura da Árvore Binária
        /// </summary>
        /// <returns></returns>
        public int AlturaDaArvore() {
            return AlturaDaArvore(raiz);
        }
        #endregion

        //ERRADO
        #region Calcular a altura da árvore binária a partir de um nodo específico
        /// <summary>
        /// Retorna a altura da arvore binária a partir de um nodo passado por parâmetro
        /// </summary>
        /// <param name="esteNode"></param>
        /// <returns></returns>
        public int AlturaDaArvore(Node esteNode) {
            //Só vai entrar nesse if quando houver elementos na árvore 
            if (esteNode != null) {
                //Criação de variáveis auxiliares para a comparação da altura de cada node
                int alturaEsq, alturaDir;
                
                //Definindo a altura da subarvore direita e da esquerda
                alturaEsq = AlturaDaArvore(esteNode.esq);
                alturaDir = AlturaDaArvore(esteNode.dir);

                //Resultado
                if (alturaEsq > alturaDir)
                    return alturaEsq+1;
                else
                    return alturaDir+1;
            }
            //Se este node for null, significa que não há elementos na árvore
            return 0;
        }
        #endregion

        #region Calcula o Node de maior valor na árvore
        /// <summary>
        /// Retorna o node de maior valor na árvore binária
        /// </summary>
        /// <returns></returns>
        public Node NodeDeMaiorValor() {
            return NodeDeMaiorValor(raiz);
        }
        #endregion

        #region MÉTODO PRIVADO para auxiliar na identificação do Node de maior valor
        private Node NodeDeMaiorValor(Node esteNode) {
            if (esteNode != null) {
                if (esteNode.dir != null) {
                    return NodeDeMaiorValor(esteNode.dir);
                } else
                    return esteNode;
            } else
                return null;
        }
        #endregion


        #region Calcula a profundidade (ou nível) do node passado por parâmetro está
        /// <summary>
        /// Calcula em que nível/profundidade o valor do node passado por parâmetro está inserido
        /// </summary>
        /// <param name="valorItem"></param>
        /// <returns></returns>
        public int Profundidade(int valorItem) {
            return Profundidade(valorItem, raiz);
        }
        #endregion

        #region CLASSE PRIVADA para identificar qual é o node pasado por parâmetro e calcular em que nível ele está
        private int Profundidade(int valorItem, Node esteNode) {

            if (esteNode != null) {
                //CAMINHANDO PARA A DIREITA PARA ACHAR O NODE
                if (valorItem > (int)esteNode.item)
                    return Profundidade(valorItem, esteNode.dir);
                //CAMINHANDO PARA A ESQUERDA
                else if (valorItem < (int)esteNode.item)
                    return Profundidade(valorItem, esteNode.esq);
                //SE O NODE.ITEM FOR IGUAL AO VALORITEM, CALCULA A PROFUNDIDADE
                else 
                    return CalculaProfundidade(esteNode);
            } else
                return 0;
        }
        #endregion

        #region CLASSE PRIVADA para calcular a profundidade do node
        //Calculando a profundidade
        private int CalculaProfundidade(Node esteNode) {
            if (esteNode != null) 
                return 1 + CalculaProfundidade(esteNode.pai);
            //se for null retorna 0, pq não tem mais elementos
            return 0;
        }
        #endregion

        
       
        

    }//Fim classe
}//fim namespace
