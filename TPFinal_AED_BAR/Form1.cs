using MaterialSkin;
using System;
using TPFinal_AED_BAR.EstruturasDeDados.Pilha;
using System.Windows.Forms;

namespace TPFinal_AED_BAR {
    public partial class formPrincipal:MaterialSkin.Controls.MaterialForm {
        
        private String tpEstrutura = null;

        public formPrincipal() {
            InitializeComponent();
            
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan200, Primary.Cyan300,
                Primary.Cyan300, Accent.Orange700,
                TextShade.BLACK
            );
        }

        private void buttonListar_Click(object sender, EventArgs e) {
            if(tpEstrutura == null) {
                MessageBox.Show("Operação bloqueada!\n\nSelecione o tipo de estrutura que deseja trabalhar.");
            } else {
                String textoTela = TextSequencia.Text;
                if(textoTela == null) {
                    MessageBox.Show("Operação bloqueada!\n\nDigite a sequência que deseja manipular.");
                } else {
                    char[] delimitador = {';'};
                    String[] sequencia = textoTela.Split(delimitador);
                }

                switch(tpEstrutura) {
                    case "PILHA": 
                        Pilha pilha = new Pilha();
                        pilha.empilhar();
                    break;
                }
            }
            
        }

        /**
         * Captura e guarda o valor corrente do RadioButton
         **/
        private void rButtonFila_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (getStatusRadioButton(sender)) ? "FILA" : null;
        }

        private void rButtonPilha_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (getStatusRadioButton(sender)) ? "PILHA" : null;
        }

        private void rButtonLista_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (getStatusRadioButton(sender)) ? "LISTA" : null;
        }

        private void rButtonArvore_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (getStatusRadioButton(sender)) ? "ARVORE" : null;
        }

        private void rButtonHash_CheckedChanged(object sender, EventArgs e) {
            tpEstrutura = (getStatusRadioButton(sender)) ?  "HASH" : null;
        }

        private bool getStatusRadioButton(object sender) {
            RadioButton radio = sender as RadioButton;
            if(radio.Checked)
                return true;

            return false;
        }
    }
}
