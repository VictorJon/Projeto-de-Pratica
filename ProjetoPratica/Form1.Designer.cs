namespace ProjetoPratica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabRead = new System.Windows.Forms.TabPage();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabCad = new System.Windows.Forms.TabPage();
            this.inputData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.inputQuantidade = new System.Windows.Forms.TextBox();
            this.buttonCadEvento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCad = new System.Windows.Forms.Button();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label9 = new System.Windows.Forms.Label();
            this.datePickerFiltro = new System.Windows.Forms.DateTimePicker();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tabRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            this.tabCad.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRead
            // 
            this.tabRead.Controls.Add(this.buttonRefresh);
            this.tabRead.Controls.Add(this.buttonFiltrar);
            this.tabRead.Controls.Add(this.datePickerFiltro);
            this.tabRead.Controls.Add(this.label9);
            this.tabRead.Controls.Add(this.dataGridViewEventos);
            this.tabRead.Controls.Add(this.label1);
            this.tabRead.Controls.Add(this.buttonRead);
            this.tabRead.Controls.Add(this.label2);
            this.tabRead.Controls.Add(this.label3);
            this.tabRead.Controls.Add(this.textEndereco);
            this.tabRead.Controls.Add(this.inputNome);
            this.tabRead.Controls.Add(this.label4);
            this.tabRead.Location = new System.Drawing.Point(4, 22);
            this.tabRead.Name = "tabRead";
            this.tabRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabRead.Size = new System.Drawing.Size(700, 552);
            this.tabRead.TabIndex = 1;
            this.tabRead.Text = "Consulta";
            this.tabRead.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.AllowUserToDeleteRows = false;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Location = new System.Drawing.Point(25, 285);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.Size = new System.Drawing.Size(443, 248);
            this.dataGridViewEventos.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Consulta de Eventos";
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(429, 150);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(187, 52);
            this.buttonRead.TabIndex = 22;
            this.buttonRead.Text = "Consultar";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nome:";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(109, 167);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.ReadOnly = true;
            this.textEndereco.Size = new System.Drawing.Size(175, 20);
            this.textEndereco.TabIndex = 17;
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(108, 108);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(175, 20);
            this.inputNome.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Consulta de Clientes";
            // 
            // tabCad
            // 
            this.tabCad.Controls.Add(this.inputData);
            this.tabCad.Controls.Add(this.label8);
            this.tabCad.Controls.Add(this.inputQuantidade);
            this.tabCad.Controls.Add(this.buttonCadEvento);
            this.tabCad.Controls.Add(this.label5);
            this.tabCad.Controls.Add(this.label6);
            this.tabCad.Controls.Add(this.textBox2);
            this.tabCad.Controls.Add(this.label7);
            this.tabCad.Controls.Add(this.buttonCad);
            this.tabCad.Controls.Add(this.labelEndereco);
            this.tabCad.Controls.Add(this.labelNome);
            this.tabCad.Controls.Add(this.textBoxEndereco);
            this.tabCad.Controls.Add(this.textBoxNome);
            this.tabCad.Controls.Add(this.labelTitulo);
            this.tabCad.Location = new System.Drawing.Point(4, 22);
            this.tabCad.Name = "tabCad";
            this.tabCad.Padding = new System.Windows.Forms.Padding(3);
            this.tabCad.Size = new System.Drawing.Size(700, 552);
            this.tabCad.TabIndex = 0;
            this.tabCad.Text = "Cadastro";
            this.tabCad.UseVisualStyleBackColor = true;
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(82, 372);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(229, 20);
            this.inputData.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(32, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Quantidade de Pessoas:";
            // 
            // inputQuantidade
            // 
            this.inputQuantidade.Location = new System.Drawing.Point(208, 398);
            this.inputQuantidade.Name = "inputQuantidade";
            this.inputQuantidade.Size = new System.Drawing.Size(175, 20);
            this.inputQuantidade.TabIndex = 29;
            // 
            // buttonCadEvento
            // 
            this.buttonCadEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadEvento.Location = new System.Drawing.Point(443, 375);
            this.buttonCadEvento.Name = "buttonCadEvento";
            this.buttonCadEvento.Size = new System.Drawing.Size(187, 52);
            this.buttonCadEvento.TabIndex = 27;
            this.buttonCadEvento.Text = "Cadastrar";
            this.buttonCadEvento.UseVisualStyleBackColor = true;
            this.buttonCadEvento.Click += new System.EventHandler(this.buttonCadEvento_click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(32, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Responsável:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 348);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(30, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cadastro de Eventos";
            // 
            // buttonCad
            // 
            this.buttonCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCad.Location = new System.Drawing.Point(441, 125);
            this.buttonCad.Name = "buttonCad";
            this.buttonCad.Size = new System.Drawing.Size(187, 52);
            this.buttonCad.TabIndex = 21;
            this.buttonCad.Text = "Cadastrar";
            this.buttonCad.UseVisualStyleBackColor = true;
            this.buttonCad.Click += new System.EventHandler(this.buttonCad_Click);
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(29, 169);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(66, 18);
            this.labelEndereco.TabIndex = 20;
            this.labelEndereco.Text = "Número:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(29, 109);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 19;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(111, 170);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(175, 20);
            this.textBoxEndereco.TabIndex = 18;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(110, 111);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(175, 20);
            this.textBoxNome.TabIndex = 17;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitulo.Location = new System.Drawing.Point(28, 32);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(256, 25);
            this.labelTitulo.TabIndex = 16;
            this.labelTitulo.Text = "Cadastro de Moradores";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCad);
            this.tabControl.Controls.Add(this.tabRead);
            this.tabControl.Location = new System.Drawing.Point(1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(708, 578);
            this.tabControl.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(473, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Filtro de Data:";
            // 
            // datePickerFiltro
            // 
            this.datePickerFiltro.Location = new System.Drawing.Point(478, 313);
            this.datePickerFiltro.Name = "datePickerFiltro";
            this.datePickerFiltro.Size = new System.Drawing.Size(216, 20);
            this.datePickerFiltro.TabIndex = 26;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(478, 339);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(216, 28);
            this.buttonFiltrar.TabIndex = 27;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(393, 256);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 28;
            this.buttonRefresh.Text = "Recarregar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 590);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabRead.ResumeLayout(false);
            this.tabRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            this.tabCad.ResumeLayout(false);
            this.tabCad.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabRead;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabCad;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonCad;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.Button buttonCadEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputQuantidade;
        private System.Windows.Forms.DateTimePicker inputData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.DateTimePicker datePickerFiltro;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

