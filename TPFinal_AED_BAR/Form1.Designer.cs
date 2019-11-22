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
            this.buttonListar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.gridDataEstruturas = new System.Windows.Forms.DataGridView();
            this.columnsEstrutura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuantidade = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonRelatorioTest = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelEstrutura = new MaterialSkin.Controls.MaterialLabel();
            this.labelEstruturaAtual = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataEstruturas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextSequencia
            // 
            this.TextSequencia.Depth = 0;
            this.TextSequencia.Hint = "Inclua os valores separados por \';\'. Exemplo: 1;2;3;4";
            this.TextSequencia.Location = new System.Drawing.Point(217, 93);
            this.TextSequencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextSequencia.Name = "TextSequencia";
            this.TextSequencia.PasswordChar = '\0';
            this.TextSequencia.SelectedText = "";
            this.TextSequencia.SelectionLength = 0;
            this.TextSequencia.SelectionStart = 0;
            this.TextSequencia.Size = new System.Drawing.Size(596, 23);
            this.TextSequencia.TabIndex = 0;
            this.TextSequencia.UseSystemPasswordChar = false;
            // 
            // rButtonPilha
            // 
            this.rButtonPilha.Depth = 0;
            this.rButtonPilha.Font = new System.Drawing.Font("Roboto", 10F);
            this.rButtonPilha.Location = new System.Drawing.Point(66, 289);
            this.rButtonPilha.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonPilha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonPilha.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonPilha.Name = "rButtonPilha";
            this.rButtonPilha.Ripple = true;
            this.rButtonPilha.Size = new System.Drawing.Size(70, 22);
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
            this.rButtonFila.Location = new System.Drawing.Point(66, 164);
            this.rButtonFila.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonFila.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonFila.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonFila.Name = "rButtonFila";
            this.rButtonFila.Ripple = true;
            this.rButtonFila.Size = new System.Drawing.Size(58, 22);
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
            this.rButtonLista.Location = new System.Drawing.Point(66, 228);
            this.rButtonLista.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonLista.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonLista.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonLista.Name = "rButtonLista";
            this.rButtonLista.Ripple = true;
            this.rButtonLista.Size = new System.Drawing.Size(70, 22);
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
            this.rButtonArvore.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rButtonArvore.Location = new System.Drawing.Point(66, 100);
            this.rButtonArvore.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonArvore.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonArvore.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonArvore.Name = "rButtonArvore";
            this.rButtonArvore.Ripple = true;
            this.rButtonArvore.Size = new System.Drawing.Size(128, 22);
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
            this.rButtonHash.Location = new System.Drawing.Point(66, 350);
            this.rButtonHash.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonHash.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonHash.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonHash.Name = "rButtonHash";
            this.rButtonHash.Ripple = true;
            this.rButtonHash.Size = new System.Drawing.Size(128, 22);
            this.rButtonHash.TabIndex = 5;
            this.rButtonHash.TabStop = true;
            this.rButtonHash.Text = "Tabela Hash";
            this.rButtonHash.UseVisualStyleBackColor = true;
            this.rButtonHash.CheckedChanged += new System.EventHandler(this.rButtonHash_CheckedChanged);
            // 
            // buttonListar
            // 
            this.buttonListar.AutoSize = true;
            this.buttonListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonListar.Depth = 0;
            this.buttonListar.Location = new System.Drawing.Point(750, 125);
            this.buttonListar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Primary = false;
            this.buttonListar.Size = new System.Drawing.Size(63, 36);
            this.buttonListar.TabIndex = 7;
            this.buttonListar.Text = "Inserir";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(682, 125);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(58, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "Listar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // gridDataEstruturas
            // 
            this.gridDataEstruturas.AllowUserToAddRows = false;
            this.gridDataEstruturas.AllowUserToDeleteRows = false;
            this.gridDataEstruturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(120)))));
            this.gridDataEstruturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataEstruturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnsEstrutura,
            this.columnSequencia});
            this.gridDataEstruturas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridDataEstruturas.Location = new System.Drawing.Point(222, 189);
            this.gridDataEstruturas.Name = "gridDataEstruturas";
            this.gridDataEstruturas.ReadOnly = true;
            this.gridDataEstruturas.Size = new System.Drawing.Size(596, 244);
            this.gridDataEstruturas.TabIndex = 9;
            // 
            // columnsEstrutura
            // 
            this.columnsEstrutura.HeaderText = "Posição";
            this.columnsEstrutura.Name = "columnsEstrutura";
            this.columnsEstrutura.ReadOnly = true;
            this.columnsEstrutura.Width = 80;
            // 
            // columnSequencia
            // 
            this.columnSequencia.HeaderText = "Elemento (s)";
            this.columnSequencia.Name = "columnSequencia";
            this.columnSequencia.ReadOnly = true;
            this.columnSequencia.Width = 480;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuantidade.Depth = 0;
            this.labelQuantidade.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuantidade.Location = new System.Drawing.Point(732, 451);
            this.labelQuantidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(86, 31);
            this.labelQuantidade.TabIndex = 11;
            this.labelQuantidade.Text = "0";
            this.labelQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(638, 457);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Quantidade:";
            // 
            // buttonRelatorioTest
            // 
            this.buttonRelatorioTest.AutoSize = true;
            this.buttonRelatorioTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRelatorioTest.Depth = 0;
            this.buttonRelatorioTest.Location = new System.Drawing.Point(222, 451);
            this.buttonRelatorioTest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRelatorioTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRelatorioTest.Name = "buttonRelatorioTest";
            this.buttonRelatorioTest.Primary = false;
            this.buttonRelatorioTest.Size = new System.Drawing.Size(131, 36);
            this.buttonRelatorioTest.TabIndex = 19;
            this.buttonRelatorioTest.Text = "Gerar Relatório";
            this.buttonRelatorioTest.UseVisualStyleBackColor = true;
            this.buttonRelatorioTest.Click += new System.EventHandler(this.buttonRelatorioTest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.rButtonArvore);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.rButtonPilha);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.rButtonFila);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.rButtonLista);
            this.panel1.Controls.Add(this.rButtonHash);
            this.panel1.Location = new System.Drawing.Point(-2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 459);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPFinal_AED_BAR.Properties.Resources.Arvore2BRANCO;
            this.pictureBox1.Location = new System.Drawing.Point(14, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TPFinal_AED_BAR.Properties.Resources.Hashtable3BRANCO;
            this.pictureBox5.Location = new System.Drawing.Point(14, 327);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 47);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TPFinal_AED_BAR.Properties.Resources.Pilha1BRANCO;
            this.pictureBox4.Location = new System.Drawing.Point(14, 266);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 45);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TPFinal_AED_BAR.Properties.Resources.Lista2BRANCO;
            this.pictureBox3.Location = new System.Drawing.Point(14, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 43);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TPFinal_AED_BAR.Properties.Resources.Fila1BRANCO;
            this.pictureBox2.Location = new System.Drawing.Point(14, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(185, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(861, 18);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(844, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 457);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(120)))));
            this.panel5.Location = new System.Drawing.Point(1, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(861, 18);
            this.panel5.TabIndex = 23;
            // 
            // labelEstrutura
            // 
            this.labelEstrutura.AutoSize = true;
            this.labelEstrutura.Depth = 0;
            this.labelEstrutura.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEstrutura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEstrutura.Location = new System.Drawing.Point(218, 167);
            this.labelEstrutura.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEstrutura.Name = "labelEstrutura";
            this.labelEstrutura.Size = new System.Drawing.Size(117, 19);
            this.labelEstrutura.TabIndex = 24;
            this.labelEstrutura.Text = "Estrutura Atual: ";
            // 
            // labelEstruturaAtual
            // 
            this.labelEstruturaAtual.AutoSize = true;
            this.labelEstruturaAtual.Depth = 0;
            this.labelEstruturaAtual.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEstruturaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEstruturaAtual.Location = new System.Drawing.Point(331, 167);
            this.labelEstruturaAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEstruturaAtual.Name = "labelEstruturaAtual";
            this.labelEstruturaAtual.Size = new System.Drawing.Size(30, 19);
            this.labelEstruturaAtual.TabIndex = 26;
            this.labelEstruturaAtual.Text = "est";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(602, 125);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(70, 36);
            this.materialFlatButton2.TabIndex = 27;
            this.materialFlatButton2.Text = "Deletar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 522);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.labelEstruturaAtual);
            this.Controls.Add(this.labelEstrutura);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRelatorioTest);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.gridDataEstruturas);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.TextSequencia);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formPrincipal";
            this.Text = "Manipulador de Estruturas de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.gridDataEstruturas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private MaterialSkin.Controls.MaterialFlatButton buttonListar;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView gridDataEstruturas;
        private MaterialSkin.Controls.MaterialLabel labelQuantidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialFlatButton buttonRelatorioTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsEstrutura;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSequencia;
        private MaterialSkin.Controls.MaterialLabel labelEstrutura;
        private MaterialSkin.Controls.MaterialLabel labelEstruturaAtual;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}

