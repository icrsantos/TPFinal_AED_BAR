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
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

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
                            listarDados(pilha.imprimir());
                        break;
                        case "FILA":
                            foreach(String elemento in sequencia)
                                fila.enfileira(elemento);
                            listarDados(fila.imprimir());
                        break;
                        case "LISTA":
                            foreach(String elemento in sequencia)
                                lista.InsereFim(elemento);
                            listarDados(lista.imprimir());
                        break;
                        case "ARVORE":
                            if(validarSequenciaInteger(sequencia)) {
                                foreach(String elemento in sequencia)
                                    arvore.InsereNode(int.Parse(elemento));
                                listarDados(arvore.imprimir());
                            }
                        break;
                        case "HASH":
                            foreach(String elemento in sequencia)
                                hash.inserir(0, elemento);
                            listarDados(hash.imprimir());
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

        public void listarDados(Object[] itens, bool validarDataVazio = false) {
            gridDataEstruturas.Rows.Clear();
            if(itens != null && itens.Length > 0) {
                int i = 1;
                foreach(Object item in itens) {
                    string[] currentRow = new string[2];
                    currentRow[0] = i.ToString();
                    currentRow[1] = item.ToString();
                    gridDataEstruturas.Rows.Add(currentRow);
                    i++;
                }
            }

            if(validarDataVazio && itens != null && itens.Length == 0)
                MessageBox.Show("Estrutura Vazia.");
        }

        /**
         * Captura e guarda o valor corrente do RadioButton
         **/
        private void rButtonFila_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (rButtonFila.Checked) ? "FILA" : null;
            if(tpEstrutura != null) {
                labelQuantidade.Text = fila.Quantidade().ToString();
                labelEstruturaAtual.Text = "Fila";
                listarDados(fila.imprimir());
            }
        }

        private void rButtonPilha_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (rButtonPilha.Checked) ? "PILHA" : null;
            if(tpEstrutura != null) {
                labelQuantidade.Text = pilha.Quantidade().ToString();
                labelEstruturaAtual.Text = "Pilha";
                listarDados(pilha.imprimir());
            }
        }

        private void rButtonLista_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (rButtonLista.Checked) ? "LISTA" : null;
            if(tpEstrutura != null) {
                labelQuantidade.Text = lista.Quantidade().ToString();
                labelEstruturaAtual.Text = "Lista";
                listarDados(lista.imprimir());
            }
        }

        private void rButtonArvore_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = ( rButtonArvore.Checked ) ? "ARVORE" : null;
            if(tpEstrutura != null) {
                labelQuantidade.Text = arvore.Qtde().ToString();
                labelEstruturaAtual.Text = "Árvore Binária";
                listarDados(arvore.imprimir());
            }
        }

        private void rButtonHash_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = ( rButtonHash.Checked ) ? "HASH" : null;
            if(tpEstrutura != null) {
                labelQuantidade.Text = hash.Quantidade().ToString();
                labelEstruturaAtual.Text = "Tabela Hash";
                listarDados(hash.imprimir());
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e) {
            if(tpEstrutura == null) {
                MessageBox.Show("Operação bloqueada!\n\nSelecione o tipo de estrutura que deseja trabalhar.");
            } else {
                gridDataEstruturas.Rows.Clear();
                switch(tpEstrutura) {
                    case "FILA":
                        labelQuantidade.Text = fila.Quantidade().ToString();
                        listarDados(fila.imprimir(), true);
                    break;
                    case "PILHA":
                        labelQuantidade.Text = pilha.Quantidade().ToString();
                        listarDados(pilha.imprimir(), true);
                    break;
                    case "LISTA":
                        labelQuantidade.Text = lista.Quantidade().ToString();
                        listarDados(lista.imprimir(), true);
                    break;
                    case "ARVORE":
                        labelQuantidade.Text = arvore.Qtde().ToString();
                        listarDados(arvore.imprimir(), true);
                    break;
                    case "HASH":
                        labelQuantidade.Text = hash.Quantidade().ToString();
                        listarDados(hash.imprimir(), true);
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

        private void materialFlatButton2_Click(object sender, EventArgs e) {
            if(gridDataEstruturas.SelectedRows.Count == 0 && tpEstrutura != "FILA" && tpEstrutura != "PILHA") {
                MessageBox.Show("\tOperação bloqueada!\nSelecione a row que deseja deletar");
            } else {
                String index    = gridDataEstruturas.CurrentRow.Cells[0].Value.ToString();
                String elemento = gridDataEstruturas.CurrentRow.Cells[1].Value.ToString();
                
                switch(tpEstrutura) {
                    case "FILA":
                        if(fila.Vazia()) {
                            MessageBox.Show("\tOperação bloqueada!\nA estrutura selecionada não possui elementos.");
                        }  else {
                            fila.desenfileira();
                            labelQuantidade.Text = fila.Quantidade().ToString();
                            listarDados(fila.imprimir());
                        }
                        break;
                    case "PILHA":
                        if(pilha.Vazia()) {
                            MessageBox.Show("\tOperação bloqueada!\nA estrutura selecionada não possui elementos.");
                        } else {
                            pilha.desempilhar();
                            labelQuantidade.Text = pilha.Quantidade().ToString();
                            listarDados(pilha.imprimir());
                        }
                        break;
                    case "LISTA":
                        if(lista.Vazia()) {
                            MessageBox.Show("\tOperação bloqueada!\nA estrutura selecionada não possui elementos.");
                        } else {
                            lista.Remove(elemento);
                            labelQuantidade.Text = lista.Quantidade().ToString();
                            listarDados(lista.imprimir());
                        }
                        break;
                    case "ARVORE":
                        if(arvore.Vazia()) {
                            MessageBox.Show("\tOperação bloqueada!\nA estrutura selecionada não possui elementos.");
                        } else {
                            arvore.Remove(int.Parse(elemento));
                            labelQuantidade.Text = arvore.Qtde().ToString();
                            listarDados(arvore.imprimir());
                        }
                        break;
                    case "HASH":
                        String textoTela = TextSequencia.Text;
                        if(textoTela == "") {
                            MessageBox.Show("\t\t\tOperação bloqueada!\nPara deletar um elemento da tabela hash" +
                                " digite o valor item a ser deletafo no campo de sequência, " +
                                "selecione a row da chave em que ele se encontra e tecle no botão deletar.");
                        } else {
                            char[] delimitador = { ';' };
                            elemento = textoTela.Split(delimitador)[0];

                            if(hash.Vazia(int.Parse(index) - 1)) {
                                MessageBox.Show("\tOperação bloqueada!\nA estrutura selecionada não possui elementos.");
                            } else {
                                hash.remove(int.Parse(index) - 1, elemento);
                                labelQuantidade.Text = hash.Quantidade().ToString();
                                listarDados(hash.imprimir());
                            }
                        }
                    break;
                }
            }
        }
    }
}
