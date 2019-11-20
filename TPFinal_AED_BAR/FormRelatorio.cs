using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal_AED_BAR {
    public partial class FormRelatorio:MaterialSkin.Controls.MaterialForm {
        public FormRelatorio() {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e) {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo800, Primary.Indigo700,
                Primary.Indigo400, Accent.Indigo400,
                TextShade.WHITE
            );
        }

        private void buttonVoltar_Click(object sender, EventArgs e) {
            formPrincipal fprincipal = new formPrincipal();
            this.Hide();
            fprincipal.ShowDialog();
        }

        public void mostraRelatorio(SortedList<String, String> relatorio) {
            labelArvore.Text = relatorio["ARVORE"];
            labelFila.Text = relatorio["FILA"];
            labelPilha.Text = relatorio["PILHA"];
            labellista.Text = relatorio["LISTA"];
            labelHash.Text = relatorio["HASH"];
        }
    }
}
