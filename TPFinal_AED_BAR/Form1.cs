using MaterialSkin;
using System;
using TPFinal_AED_BAR.EstruturasDeDados.Pilha;
using TPFinal_AED_BAR.EstruturasDeDados.Fila;
using TPFinal_AED_BAR.EstruturasDeDados.ArvoreBinaria;
using TPFinal_AED_BAR.EstruturasDeDados.Lista;
using TPFinal_AED_BAR.EstruturasDeDados.Hash;
using System.Windows.Forms;
using TPFinal_AED_BAR.Tests;

namespace TPFinal_AED_BAR {
    public partial class formPrincipal:MaterialSkin.Controls.MaterialForm {
        
        private String tpEstrutura = null;
        private Pilha pilha;
        private Fila fila;
        private ArvoreBinaria arvore;
        private Lista lista;
        private Hash hash;

        public formPrincipal() {
            InitializeComponent();

            pilha  = new Pilha();
            fila   = new Fila();
            arvore = new ArvoreBinaria();
            hash   = new Hash(20);
            lista  = new Lista();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo800, Primary.Indigo700,
                Primary.Indigo400, Accent.Indigo400,
                TextShade.WHITE
            );
        }

        private void buttonListar_Click(object sender, EventArgs e) {
            if(tpEstrutura == null) {
                MessageBox.Show("\tOperação bloqueada!\n\nSelecione o tipo de estrutura que deseja trabalhar.");
            } else {
                String[] sequencia = getSequencia();

                if(sequencia.Length > 0) {
                    switch(tpEstrutura) {
                        case "PILHA":
                            foreach(String elemento in sequencia)
                                pilha.empilha(elemento);
                        break;
                        case "FILA":
                            foreach(String elemento in sequencia)
                                fila.enfileira(elemento);
                        break;
                        case "LISTA":
                            foreach(String elemento in sequencia)
                                lista.InsereFim(elemento);
                        break;
                        case "ARVORE":
                            if(validarSequenciaInteger(sequencia)) {
                                foreach(String elemento in sequencia)
                                    arvore.InsereNode(int.Parse(elemento));
                            }
                        break;
                        case "HASH":
                            foreach(String elemento in sequencia)
                                hash.inserir(0, elemento);
                        break;
                    }

                    TextSequencia.Text = "";
                }
            }
        }

        public String[] getSequencia() {
            String[] sequencia = {};
            String textoTela   = TextSequencia.Text;
            if(textoTela == null || textoTela == "") {
                MessageBox.Show("\tOperação bloqueada!\n\nDigite a sequência que deseja manipular.");
            } else {
                char[] delimitador = {';'};
                sequencia = textoTela.Split(delimitador);
            }

            return sequencia;
        }

        public bool validarSequenciaInteger(String[] sequencia) {
            int value;
            foreach(String number in sequencia) {
                if(!int.TryParse(number, out value)) {
                    MessageBox.Show("\tOperação bloqueada!\n\nA estrutura selecionada só aceita dados numéricos.");
                    return false;
                }
            }

            return true;
        }

        public void listarDados(Object[] itens, String estrutura, bool validarDataVazio = false) {
            if(itens.Length > 0) { 
                foreach(Object item in itens) {
                    string[] currentRow = new string[2];
                    currentRow[0] = estrutura;
                    currentRow[1] = item.ToString();
                    gridDataEstruturas.Rows.Add(currentRow);
                }
            }

            if(validarDataVazio && itens.Length == 0)
                MessageBox.Show("Estrutura Vazia.");
        }

        /**
         * Captura e guarda o valor corrente do RadioButton
         **/
        private void rButtonFila_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (rButtonFila.Checked) ? "FILA" : null;
            gridDataEstruturas.Rows.Clear();
            if(tpEstrutura != null) {
                labelQuantidade.Text = fila.Quantidade().ToString();
                listarDados(fila.imprimir(), "Fila");
            }
        }

        private void rButtonPilha_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (rButtonPilha.Checked) ? "PILHA" : null;
            gridDataEstruturas.Rows.Clear();
            if(tpEstrutura != null) {
                labelQuantidade.Text = pilha.Quantidade().ToString();
                listarDados(pilha.imprimir(), "Pilha");
            }
        }

        private void rButtonLista_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (rButtonLista.Checked) ? "LISTA" : null;
            gridDataEstruturas.Rows.Clear();
            if(tpEstrutura != null) {
                labelQuantidade.Text = lista.Quantidade().ToString();
                listarDados(lista.imprimir(), "Lista");
            }
        }

        private void rButtonArvore_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = ( rButtonArvore.Checked ) ? "ARVORE" : null;
            gridDataEstruturas.Rows.Clear();
            if(tpEstrutura != null) {
                labelQuantidade.Text = arvore.Qtde().ToString();
                listarDados(arvore.imprimir(), "Árvore");
            }
        }

        private void rButtonHash_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = ( rButtonHash.Checked ) ? "HASH" : null;
            gridDataEstruturas.Rows.Clear();
            if(tpEstrutura != null) {
                labelQuantidade.Text = hash.Quantidade().ToString();
                listarDados(hash.imprimir(), "Tabela Hash");
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e) {
            if(tpEstrutura == null) {
                MessageBox.Show("Operação bloqueada!\n\nSelecione o tipo de estrutura que deseja trabalhar.");
            } else {
                switch(tpEstrutura) {
                    case "FILA":
                        labelQuantidade.Text = fila.Quantidade().ToString();
                        listarDados(fila.imprimir(), "Fila", true);
                    break;
                    case "PILHA":
                        labelQuantidade.Text = pilha.Quantidade().ToString();
                        listarDados(pilha.imprimir(), "Pilha", true);
                    break;
                    case "LISTA":
                        labelQuantidade.Text = lista.Quantidade().ToString();
                        listarDados(lista.imprimir(), "Lista", true);
                    break;
                    case "ARVORE":
                        labelQuantidade.Text = arvore.Qtde().ToString();
                        listarDados(arvore.imprimir(), "Árvore", true);
                    break;
                    case "HASH":
                        labelQuantidade.Text = hash.Quantidade().ToString();
                        listarDados(hash.imprimir(), "Tabela Hash", true);
                    break;
                }
            }
        }

        private void buttonRelatorioTest_Click(object sender, EventArgs e) {
            String[] sequencia = getSequencia();

            if(sequencia.Length > 0 && validarSequenciaInteger(sequencia)) {
                FormRelatorio frelatorio = new FormRelatorio();
                this.Hide();
                frelatorio.mostraRelatorio(Relatorio.gerarRelatorio(sequencia));
                frelatorio.ShowDialog();
            }
        }
    }
}
