namespace TPFinal_AED_BAR {
    partial class formPrincipal {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.TextSequencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rButtonPilha = new MaterialSkin.Controls.MaterialRadioButton();
            this.rButtonFila = new MaterialSkin.Controls.MaterialRadioButton();
            this.rButtonLista = new MaterialSkin.Controls.MaterialRadioButton();
            this.rButtonArvore = new MaterialSkin.Controls.MaterialRadioButton();
            this.rButtonHash = new MaterialSkin.Controls.MaterialRadioButton();
            this.labelSequencia = new MaterialSkin.Controls.MaterialLabel();
            this.buttonListar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelExemplo = new MaterialSkin.Controls.MaterialLabel();
            this.buttonQuantidade = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextSequencia
            // 
            this.TextSequencia.Depth = 0;
            this.TextSequencia.Hint = "";
            this.TextSequencia.Location = new System.Drawing.Point(12, 105);
            this.TextSequencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextSequencia.Name = "TextSequencia";
            this.TextSequencia.PasswordChar = '\0';
            this.TextSequencia.SelectedText = "";
            this.TextSequencia.SelectionLength = 0;
            this.TextSequencia.SelectionStart = 0;
            this.TextSequencia.Size = new System.Drawing.Size(473, 23);
            this.TextSequencia.TabIndex = 0;
            this.TextSequencia.UseSystemPasswordChar = false;
            // 
            // rButtonPilha
            // 
            this.rButtonPilha.Depth = 0;
            this.rButtonPilha.Font = new System.Drawing.Font("Roboto", 10F);
            this.rButtonPilha.Location = new System.Drawing.Point(200, 174);
            this.rButtonPilha.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonPilha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonPilha.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonPilha.Name = "rButtonPilha";
            this.rButtonPilha.Ripple = true;
            this.rButtonPilha.Size = new System.Drawing.Size(60, 20);
            this.rButtonPilha.TabIndex = 1;
            this.rButtonPilha.TabStop = true;
            this.rButtonPilha.Text = "Pilha";
            this.rButtonPilha.UseVisualStyleBackColor = true;
            this.rButtonPilha.CheckedChanged += new System.EventHandler(this.rButtonPilha_CheckedChanged);
            // 
            // rButtonFila
            // 
            this.rButtonFila.Depth = 0;
            this.rButtonFila.Font = new System.Drawing.Font("Roboto", 10F);
            this.rButtonFila.Location = new System.Drawing.Point(129, 174);
            this.rButtonFila.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonFila.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonFila.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonFila.Name = "rButtonFila";
            this.rButtonFila.Ripple = true;
            this.rButtonFila.Size = new System.Drawing.Size(50, 20);
            this.rButtonFila.TabIndex = 2;
            this.rButtonFila.TabStop = true;
            this.rButtonFila.Text = "Fila";
            this.rButtonFila.UseVisualStyleBackColor = true;
            this.rButtonFila.CheckedChanged += new System.EventHandler(this.rButtonFila_CheckedChanged);
            // 
            // rButtonLista
            // 
            this.rButtonLista.Depth = 0;
            this.rButtonLista.Font = new System.Drawing.Font("Roboto", 10F);
            this.rButtonLista.Location = new System.Drawing.Point(284, 174);
            this.rButtonLista.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonLista.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonLista.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonLista.Name = "rButtonLista";
            this.rButtonLista.Ripple = true;
            this.rButtonLista.Size = new System.Drawing.Size(60, 20);
            this.rButtonLista.TabIndex = 3;
            this.rButtonLista.TabStop = true;
            this.rButtonLista.Text = "Lista";
            this.rButtonLista.UseVisualStyleBackColor = true;
            this.rButtonLista.CheckedChanged += new System.EventHandler(this.rButtonLista_CheckedChanged);
            // 
            // rButtonArvore
            // 
            this.rButtonArvore.Depth = 0;
            this.rButtonArvore.Font = new System.Drawing.Font("Roboto", 10F);
            this.rButtonArvore.Location = new System.Drawing.Point(365, 174);
            this.rButtonArvore.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonArvore.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonArvore.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonArvore.Name = "rButtonArvore";
            this.rButtonArvore.Ripple = true;
            this.rButtonArvore.Size = new System.Drawing.Size(120, 20);
            this.rButtonArvore.TabIndex = 4;
            this.rButtonArvore.TabStop = true;
            this.rButtonArvore.Text = "Árvore Binária";
            this.rButtonArvore.UseVisualStyleBackColor = true;
            this.rButtonArvore.CheckedChanged += new System.EventHandler(this.rButtonArvore_CheckedChanged);
            // 
            // rButtonHash
            // 
            this.rButtonHash.Depth = 0;
            this.rButtonHash.Font = new System.Drawing.Font("Roboto", 10F);
            this.rButtonHash.Location = new System.Drawing.Point(507, 174);
            this.rButtonHash.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonHash.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonHash.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonHash.Name = "rButtonHash";
            this.rButtonHash.Ripple = true;
            this.rButtonHash.Size = new System.Drawing.Size(110, 20);
            this.rButtonHash.TabIndex = 5;
            this.rButtonHash.TabStop = true;
            this.rButtonHash.Text = "Tabela Hash";
            this.rButtonHash.UseVisualStyleBackColor = true;
            this.rButtonHash.CheckedChanged += new System.EventHandler(this.rButtonHash_CheckedChanged);
            // 
            // labelSequencia
            // 
            this.labelSequencia.AutoSize = true;
            this.labelSequencia.Depth = 0;
            this.labelSequencia.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSequencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSequencia.Location = new System.Drawing.Point(12, 76);
            this.labelSequencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSequencia.Name = "labelSequencia";
            this.labelSequencia.Size = new System.Drawing.Size(79, 19);
            this.labelSequencia.TabIndex = 6;
            this.labelSequencia.Text = "Sequência";
            // 
            // buttonListar
            // 
            this.buttonListar.AutoSize = true;
            this.buttonListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonListar.Depth = 0;
            this.buttonListar.Location = new System.Drawing.Point(492, 103);
            this.buttonListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Primary = false;
            this.buttonListar.Size = new System.Drawing.Size(84, 36);
            this.buttonListar.TabIndex = 7;
            this.buttonListar.Text = "Adicionar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(584, 103);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(58, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "Listar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 244);
            this.dataGridView1.TabIndex = 9;
            // 
            // labelExemplo
            // 
            this.labelExemplo.Depth = 0;
            this.labelExemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelExemplo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelExemplo.Location = new System.Drawing.Point(12, 131);
            this.labelExemplo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelExemplo.Name = "labelExemplo";
            this.labelExemplo.Size = new System.Drawing.Size(473, 20);
            this.labelExemplo.TabIndex = 10;
            this.labelExemplo.Text = "Obs: inclua os valores separados por \';\'. Exemplo: 1;2;3;4";
            // 
            // buttonQuantidade
            // 
            this.buttonQuantidade.AutoSize = true;
            this.buttonQuantidade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonQuantidade.Depth = 0;
            this.buttonQuantidade.Location = new System.Drawing.Point(650, 103);
            this.buttonQuantidade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonQuantidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonQuantidade.Name = "buttonQuantidade";
            this.buttonQuantidade.Primary = false;
            this.buttonQuantidade.Size = new System.Drawing.Size(96, 36);
            this.buttonQuantidade.TabIndex = 11;
            this.buttonQuantidade.Text = "Quantidade";
            this.buttonQuantidade.UseVisualStyleBackColor = true;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 474);
            this.Controls.Add(this.buttonQuantidade);
            this.Controls.Add(this.labelExemplo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.labelSequencia);
            this.Controls.Add(this.rButtonHash);
            this.Controls.Add(this.rButtonArvore);
            this.Controls.Add(this.rButtonLista);
            this.Controls.Add(this.rButtonFila);
            this.Controls.Add(this.rButtonPilha);
            this.Controls.Add(this.TextSequencia);
            this.Name = "formPrincipal";
            this.Text = "Data Struct Test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TextSequencia;
        private MaterialSkin.Controls.MaterialRadioButton rButtonPilha;
        private MaterialSkin.Controls.MaterialRadioButton rButtonFila;
        private MaterialSkin.Controls.MaterialRadioButton rButtonLista;
        private MaterialSkin.Controls.MaterialRadioButton rButtonArvore;
        private MaterialSkin.Controls.MaterialRadioButton rButtonHash;
        private MaterialSkin.Controls.MaterialLabel labelSequencia;
        private MaterialSkin.Controls.MaterialFlatButton buttonListar;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel labelExemplo;
        private MaterialSkin.Controls.MaterialFlatButton buttonQuantidade;
    }
}

