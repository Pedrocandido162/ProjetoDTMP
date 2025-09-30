namespace CrudComBancoDeDados
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
            this.components = new System.ComponentModel.Container();
            this.CadastrarButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.panelCadastroFuncionario = new System.Windows.Forms.Panel();
            this.dgvDadosFuncionarios = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textNascimento = new System.Windows.Forms.MaskedTextBox();
            this.ButtonExibir = new System.Windows.Forms.Button();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Funcionarios = new System.Windows.Forms.Button();
            this.Impressoras = new System.Windows.Forms.Button();
            this.Escolas = new System.Windows.Forms.Button();
            this.Manutenções = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelImpressoras = new System.Windows.Forms.Panel();
            this.atualizarAparelho = new System.Windows.Forms.Button();
            this.comboBoxAparelho = new System.Windows.Forms.ComboBox();
            this.textIdEscola = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridAparelho = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.ExibirAparelhos = new System.Windows.Forms.Button();
            this.ConsultarAparelhos = new System.Windows.Forms.Button();
            this.DeleteAparelhos = new System.Windows.Forms.Button();
            this.CadastrarAparelhos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ModeloAparelho = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textIdAparelho = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelEscolas = new System.Windows.Forms.Panel();
            this.exibirImpressoraEscola = new System.Windows.Forms.Button();
            this.dataGridEscolas = new System.Windows.Forms.DataGridView();
            this.ExibirEscolas = new System.Windows.Forms.Button();
            this.ConsultarEscolas = new System.Windows.Forms.Button();
            this.DeleteEscolas = new System.Windows.Forms.Button();
            this.AtualizarEscola = new System.Windows.Forms.Button();
            this.CadastrarEscola = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtnomeEscola = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtidescola = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panelManutenção = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ConsultarManutenção = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AtualizarManutenção = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelCadastroFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosFuncionarios)).BeginInit();
            this.panelImpressoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAparelho)).BeginInit();
            this.panelEscolas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEscolas)).BeginInit();
            this.panelManutenção.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CadastrarButton
            // 
            this.CadastrarButton.Location = new System.Drawing.Point(26, 182);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(75, 23);
            this.CadastrarButton.TabIndex = 4;
            this.CadastrarButton.Text = "Cadastrar";
            this.CadastrarButton.UseVisualStyleBackColor = true;
            this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(216, 182);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(116, 182);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(75, 23);
            this.atualizarButton.TabIndex = 6;
            this.atualizarButton.Text = "Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCadastroFuncionario
            // 
            this.panelCadastroFuncionario.Controls.Add(this.dgvDadosFuncionarios);
            this.panelCadastroFuncionario.Controls.Add(this.label6);
            this.panelCadastroFuncionario.Controls.Add(this.textNascimento);
            this.panelCadastroFuncionario.Controls.Add(this.ButtonExibir);
            this.panelCadastroFuncionario.Controls.Add(this.buttonConsulta);
            this.panelCadastroFuncionario.Controls.Add(this.DeleteButton);
            this.panelCadastroFuncionario.Controls.Add(this.atualizarButton);
            this.panelCadastroFuncionario.Controls.Add(this.CadastrarButton);
            this.panelCadastroFuncionario.Controls.Add(this.label4);
            this.panelCadastroFuncionario.Controls.Add(this.label3);
            this.panelCadastroFuncionario.Controls.Add(this.textNome);
            this.panelCadastroFuncionario.Controls.Add(this.label1);
            this.panelCadastroFuncionario.Controls.Add(this.textId);
            this.panelCadastroFuncionario.Controls.Add(this.label2);
            this.panelCadastroFuncionario.Location = new System.Drawing.Point(216, 11);
            this.panelCadastroFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.panelCadastroFuncionario.Name = "panelCadastroFuncionario";
            this.panelCadastroFuncionario.Size = new System.Drawing.Size(801, 587);
            this.panelCadastroFuncionario.TabIndex = 12;
            this.panelCadastroFuncionario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvDadosFuncionarios
            // 
            this.dgvDadosFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosFuncionarios.Location = new System.Drawing.Point(26, 241);
            this.dgvDadosFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDadosFuncionarios.Name = "dgvDadosFuncionarios";
            this.dgvDadosFuncionarios.RowHeadersWidth = 51;
            this.dgvDadosFuncionarios.RowTemplate.Height = 24;
            this.dgvDadosFuncionarios.Size = new System.Drawing.Size(646, 162);
            this.dgvDadosFuncionarios.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ano, mês, dia";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textNascimento
            // 
            this.textNascimento.Location = new System.Drawing.Point(32, 141);
            this.textNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.textNascimento.Mask = "0000/00/00";
            this.textNascimento.Name = "textNascimento";
            this.textNascimento.Size = new System.Drawing.Size(168, 20);
            this.textNascimento.TabIndex = 12;
            this.textNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textNascimento_MaskInputRejected);
            // 
            // ButtonExibir
            // 
            this.ButtonExibir.Location = new System.Drawing.Point(403, 182);
            this.ButtonExibir.Name = "ButtonExibir";
            this.ButtonExibir.Size = new System.Drawing.Size(75, 23);
            this.ButtonExibir.TabIndex = 10;
            this.ButtonExibir.Text = "Exibir";
            this.ButtonExibir.UseVisualStyleBackColor = true;
            this.ButtonExibir.Click += new System.EventHandler(this.textExibir_Click);
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(314, 182);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(75, 23);
            this.buttonConsulta.TabIndex = 11;
            this.buttonConsulta.Text = "Consultar";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chave de Consulta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nascimento";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(33, 80);
            this.textNome.Margin = new System.Windows.Forms.Padding(2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(275, 20);
            this.textNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(33, 31);
            this.textId.Margin = new System.Windows.Forms.Padding(2);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(105, 20);
            this.textId.TabIndex = 2;
            this.textId.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Funcionarios
            // 
            this.Funcionarios.BackColor = System.Drawing.SystemColors.Highlight;
            this.Funcionarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Funcionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Funcionarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Funcionarios.Location = new System.Drawing.Point(0, 168);
            this.Funcionarios.Margin = new System.Windows.Forms.Padding(2);
            this.Funcionarios.Name = "Funcionarios";
            this.Funcionarios.Size = new System.Drawing.Size(214, 30);
            this.Funcionarios.TabIndex = 13;
            this.Funcionarios.Text = "Funcionarios";
            this.Funcionarios.UseVisualStyleBackColor = false;
            this.Funcionarios.Click += new System.EventHandler(this.Funcionarios_Click);
            // 
            // Impressoras
            // 
            this.Impressoras.BackColor = System.Drawing.SystemColors.Highlight;
            this.Impressoras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Impressoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Impressoras.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Impressoras.Location = new System.Drawing.Point(0, 202);
            this.Impressoras.Margin = new System.Windows.Forms.Padding(2);
            this.Impressoras.Name = "Impressoras";
            this.Impressoras.Size = new System.Drawing.Size(214, 30);
            this.Impressoras.TabIndex = 14;
            this.Impressoras.Text = "Aparelhos";
            this.Impressoras.UseVisualStyleBackColor = false;
            this.Impressoras.Click += new System.EventHandler(this.Impressoras_Click);
            // 
            // Escolas
            // 
            this.Escolas.BackColor = System.Drawing.SystemColors.Highlight;
            this.Escolas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Escolas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Escolas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Escolas.Location = new System.Drawing.Point(0, 236);
            this.Escolas.Margin = new System.Windows.Forms.Padding(2);
            this.Escolas.Name = "Escolas";
            this.Escolas.Size = new System.Drawing.Size(214, 30);
            this.Escolas.TabIndex = 15;
            this.Escolas.Text = "Escolas";
            this.Escolas.UseVisualStyleBackColor = false;
            this.Escolas.Click += new System.EventHandler(this.Escolas_Click);
            // 
            // Manutenções
            // 
            this.Manutenções.BackColor = System.Drawing.SystemColors.Highlight;
            this.Manutenções.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Manutenções.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manutenções.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Manutenções.Location = new System.Drawing.Point(0, 270);
            this.Manutenções.Margin = new System.Windows.Forms.Padding(2);
            this.Manutenções.Name = "Manutenções";
            this.Manutenções.Size = new System.Drawing.Size(214, 30);
            this.Manutenções.TabIndex = 16;
            this.Manutenções.Text = "Manutenções";
            this.Manutenções.UseVisualStyleBackColor = false;
            this.Manutenções.Click += new System.EventHandler(this.Manutenções_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // panelImpressoras
            // 
            this.panelImpressoras.Controls.Add(this.atualizarAparelho);
            this.panelImpressoras.Controls.Add(this.comboBoxAparelho);
            this.panelImpressoras.Controls.Add(this.textIdEscola);
            this.panelImpressoras.Controls.Add(this.label13);
            this.panelImpressoras.Controls.Add(this.dataGridAparelho);
            this.panelImpressoras.Controls.Add(this.label7);
            this.panelImpressoras.Controls.Add(this.ExibirAparelhos);
            this.panelImpressoras.Controls.Add(this.ConsultarAparelhos);
            this.panelImpressoras.Controls.Add(this.DeleteAparelhos);
            this.panelImpressoras.Controls.Add(this.CadastrarAparelhos);
            this.panelImpressoras.Controls.Add(this.label9);
            this.panelImpressoras.Controls.Add(this.label10);
            this.panelImpressoras.Controls.Add(this.ModeloAparelho);
            this.panelImpressoras.Controls.Add(this.label11);
            this.panelImpressoras.Controls.Add(this.textIdAparelho);
            this.panelImpressoras.Controls.Add(this.label12);
            this.panelImpressoras.Location = new System.Drawing.Point(216, 11);
            this.panelImpressoras.Margin = new System.Windows.Forms.Padding(2);
            this.panelImpressoras.Name = "panelImpressoras";
            this.panelImpressoras.Size = new System.Drawing.Size(801, 587);
            this.panelImpressoras.TabIndex = 19;
            this.panelImpressoras.Visible = false;
            this.panelImpressoras.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImpressoras_Paint);
            // 
            // atualizarAparelho
            // 
            this.atualizarAparelho.Location = new System.Drawing.Point(116, 182);
            this.atualizarAparelho.Name = "atualizarAparelho";
            this.atualizarAparelho.Size = new System.Drawing.Size(75, 23);
            this.atualizarAparelho.TabIndex = 18;
            this.atualizarAparelho.Text = "Atualizar";
            this.atualizarAparelho.UseVisualStyleBackColor = true;
            this.atualizarAparelho.Click += new System.EventHandler(this.atualizarAparelho_Click_1);
            // 
            // comboBoxAparelho
            // 
            this.comboBoxAparelho.FormattingEnabled = true;
            this.comboBoxAparelho.Items.AddRange(new object[] {
            "Bom",
            "Usável",
            "Ruim",
            "Sem uso"});
            this.comboBoxAparelho.Location = new System.Drawing.Point(30, 118);
            this.comboBoxAparelho.Name = "comboBoxAparelho";
            this.comboBoxAparelho.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAparelho.TabIndex = 17;
            this.comboBoxAparelho.SelectedIndexChanged += new System.EventHandler(this.comboBoxAparelho_SelectedIndexChanged);
            // 
            // textIdEscola
            // 
            this.textIdEscola.Location = new System.Drawing.Point(30, 157);
            this.textIdEscola.Margin = new System.Windows.Forms.Padding(2);
            this.textIdEscola.Name = "textIdEscola";
            this.textIdEscola.Size = new System.Drawing.Size(57, 20);
            this.textIdEscola.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Status";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dataGridAparelho
            // 
            this.dataGridAparelho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAparelho.Location = new System.Drawing.Point(26, 241);
            this.dataGridAparelho.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAparelho.Name = "dataGridAparelho";
            this.dataGridAparelho.RowHeadersWidth = 51;
            this.dataGridAparelho.RowTemplate.Height = 24;
            this.dataGridAparelho.Size = new System.Drawing.Size(646, 162);
            this.dataGridAparelho.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "*Somente numeros*";
            // 
            // ExibirAparelhos
            // 
            this.ExibirAparelhos.Location = new System.Drawing.Point(395, 182);
            this.ExibirAparelhos.Name = "ExibirAparelhos";
            this.ExibirAparelhos.Size = new System.Drawing.Size(75, 23);
            this.ExibirAparelhos.TabIndex = 10;
            this.ExibirAparelhos.Text = "Exibir";
            this.ExibirAparelhos.UseVisualStyleBackColor = true;
            this.ExibirAparelhos.Click += new System.EventHandler(this.ExibirAparelhos_Click);
            // 
            // ConsultarAparelhos
            // 
            this.ConsultarAparelhos.Location = new System.Drawing.Point(297, 182);
            this.ConsultarAparelhos.Name = "ConsultarAparelhos";
            this.ConsultarAparelhos.Size = new System.Drawing.Size(75, 23);
            this.ConsultarAparelhos.TabIndex = 11;
            this.ConsultarAparelhos.Text = "Consultar";
            this.ConsultarAparelhos.UseVisualStyleBackColor = true;
            this.ConsultarAparelhos.Click += new System.EventHandler(this.ConsultarAparelhos_Click);
            // 
            // DeleteAparelhos
            // 
            this.DeleteAparelhos.Location = new System.Drawing.Point(210, 182);
            this.DeleteAparelhos.Name = "DeleteAparelhos";
            this.DeleteAparelhos.Size = new System.Drawing.Size(75, 23);
            this.DeleteAparelhos.TabIndex = 5;
            this.DeleteAparelhos.Text = "Delete";
            this.DeleteAparelhos.UseVisualStyleBackColor = true;
            this.DeleteAparelhos.Click += new System.EventHandler(this.DeleteAparelhos_Click);
            // 
            // CadastrarAparelhos
            // 
            this.CadastrarAparelhos.Location = new System.Drawing.Point(26, 182);
            this.CadastrarAparelhos.Name = "CadastrarAparelhos";
            this.CadastrarAparelhos.Size = new System.Drawing.Size(75, 23);
            this.CadastrarAparelhos.TabIndex = 4;
            this.CadastrarAparelhos.Text = "Cadastrar";
            this.CadastrarAparelhos.UseVisualStyleBackColor = true;
            this.CadastrarAparelhos.Click += new System.EventHandler(this.CadastrarAparelhos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Chave de Consulta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "ID Escola";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ModeloAparelho
            // 
            this.ModeloAparelho.Location = new System.Drawing.Point(33, 80);
            this.ModeloAparelho.Margin = new System.Windows.Forms.Padding(2);
            this.ModeloAparelho.Name = "ModeloAparelho";
            this.ModeloAparelho.Size = new System.Drawing.Size(275, 20);
            this.ModeloAparelho.TabIndex = 4;
            this.ModeloAparelho.TextChanged += new System.EventHandler(this.ModeloAparelho_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Modelo";
            // 
            // textIdAparelho
            // 
            this.textIdAparelho.Location = new System.Drawing.Point(33, 31);
            this.textIdAparelho.Margin = new System.Windows.Forms.Padding(2);
            this.textIdAparelho.Name = "textIdAparelho";
            this.textIdAparelho.Size = new System.Drawing.Size(105, 20);
            this.textIdAparelho.TabIndex = 2;
            this.textIdAparelho.TextChanged += new System.EventHandler(this.textIdAparelho_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Id";
            // 
            // panelEscolas
            // 
            this.panelEscolas.Controls.Add(this.exibirImpressoraEscola);
            this.panelEscolas.Controls.Add(this.dataGridEscolas);
            this.panelEscolas.Controls.Add(this.ExibirEscolas);
            this.panelEscolas.Controls.Add(this.ConsultarEscolas);
            this.panelEscolas.Controls.Add(this.DeleteEscolas);
            this.panelEscolas.Controls.Add(this.AtualizarEscola);
            this.panelEscolas.Controls.Add(this.CadastrarEscola);
            this.panelEscolas.Controls.Add(this.label15);
            this.panelEscolas.Controls.Add(this.txtnomeEscola);
            this.panelEscolas.Controls.Add(this.label17);
            this.panelEscolas.Controls.Add(this.txtidescola);
            this.panelEscolas.Controls.Add(this.label18);
            this.panelEscolas.Location = new System.Drawing.Point(216, 11);
            this.panelEscolas.Margin = new System.Windows.Forms.Padding(2);
            this.panelEscolas.Name = "panelEscolas";
            this.panelEscolas.Size = new System.Drawing.Size(801, 587);
            this.panelEscolas.TabIndex = 20;
            this.panelEscolas.Visible = false;
            this.panelEscolas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEscolas_Paint);
            // 
            // exibirImpressoraEscola
            // 
            this.exibirImpressoraEscola.Location = new System.Drawing.Point(350, 182);
            this.exibirImpressoraEscola.Name = "exibirImpressoraEscola";
            this.exibirImpressoraEscola.Size = new System.Drawing.Size(129, 23);
            this.exibirImpressoraEscola.TabIndex = 15;
            this.exibirImpressoraEscola.Text = "Consultar Impressoras";
            this.exibirImpressoraEscola.UseVisualStyleBackColor = true;
            this.exibirImpressoraEscola.Click += new System.EventHandler(this.exibirImpressoraEscola_Click);
            // 
            // dataGridEscolas
            // 
            this.dataGridEscolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEscolas.Location = new System.Drawing.Point(26, 241);
            this.dataGridEscolas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridEscolas.Name = "dataGridEscolas";
            this.dataGridEscolas.RowHeadersWidth = 51;
            this.dataGridEscolas.RowTemplate.Height = 24;
            this.dataGridEscolas.Size = new System.Drawing.Size(646, 162);
            this.dataGridEscolas.TabIndex = 14;
            // 
            // ExibirEscolas
            // 
            this.ExibirEscolas.Location = new System.Drawing.Point(485, 182);
            this.ExibirEscolas.Name = "ExibirEscolas";
            this.ExibirEscolas.Size = new System.Drawing.Size(75, 23);
            this.ExibirEscolas.TabIndex = 10;
            this.ExibirEscolas.Text = "Exibir";
            this.ExibirEscolas.UseVisualStyleBackColor = true;
            this.ExibirEscolas.Click += new System.EventHandler(this.ExibirEscolas_Click);
            // 
            // ConsultarEscolas
            // 
            this.ConsultarEscolas.Location = new System.Drawing.Point(269, 182);
            this.ConsultarEscolas.Name = "ConsultarEscolas";
            this.ConsultarEscolas.Size = new System.Drawing.Size(75, 23);
            this.ConsultarEscolas.TabIndex = 11;
            this.ConsultarEscolas.Text = "Consultar";
            this.ConsultarEscolas.UseVisualStyleBackColor = true;
            this.ConsultarEscolas.Click += new System.EventHandler(this.ConsultarEscolas_Click);
            // 
            // DeleteEscolas
            // 
            this.DeleteEscolas.Location = new System.Drawing.Point(188, 182);
            this.DeleteEscolas.Name = "DeleteEscolas";
            this.DeleteEscolas.Size = new System.Drawing.Size(75, 23);
            this.DeleteEscolas.TabIndex = 5;
            this.DeleteEscolas.Text = "Delete";
            this.DeleteEscolas.UseVisualStyleBackColor = true;
            this.DeleteEscolas.Click += new System.EventHandler(this.DeleteEscolas_Click);
            // 
            // AtualizarEscola
            // 
            this.AtualizarEscola.Location = new System.Drawing.Point(107, 182);
            this.AtualizarEscola.Name = "AtualizarEscola";
            this.AtualizarEscola.Size = new System.Drawing.Size(75, 23);
            this.AtualizarEscola.TabIndex = 6;
            this.AtualizarEscola.Text = "Atualizar";
            this.AtualizarEscola.UseVisualStyleBackColor = true;
            this.AtualizarEscola.Click += new System.EventHandler(this.AtualizarEscola_Click);
            // 
            // CadastrarEscola
            // 
            this.CadastrarEscola.Location = new System.Drawing.Point(26, 182);
            this.CadastrarEscola.Name = "CadastrarEscola";
            this.CadastrarEscola.Size = new System.Drawing.Size(75, 23);
            this.CadastrarEscola.TabIndex = 4;
            this.CadastrarEscola.Text = "Cadastrar";
            this.CadastrarEscola.UseVisualStyleBackColor = true;
            this.CadastrarEscola.Click += new System.EventHandler(this.CadastrarEscola_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(148, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Chave de Consulta";
            // 
            // txtnomeEscola
            // 
            this.txtnomeEscola.Location = new System.Drawing.Point(33, 80);
            this.txtnomeEscola.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomeEscola.Name = "txtnomeEscola";
            this.txtnomeEscola.Size = new System.Drawing.Size(275, 20);
            this.txtnomeEscola.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 64);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Nome Da Escola";
            // 
            // txtidescola
            // 
            this.txtidescola.Location = new System.Drawing.Point(32, 31);
            this.txtidescola.Margin = new System.Windows.Forms.Padding(2);
            this.txtidescola.Name = "txtidescola";
            this.txtidescola.Size = new System.Drawing.Size(105, 20);
            this.txtidescola.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Id";
            // 
            // panelManutenção
            // 
            this.panelManutenção.Controls.Add(this.label20);
            this.panelManutenção.Controls.Add(this.label5);
            this.panelManutenção.Controls.Add(this.maskedTextBox1);
            this.panelManutenção.Controls.Add(this.textBox3);
            this.panelManutenção.Controls.Add(this.dateTimePicker1);
            this.panelManutenção.Controls.Add(this.dataGridView1);
            this.panelManutenção.Controls.Add(this.button1);
            this.panelManutenção.Controls.Add(this.ConsultarManutenção);
            this.panelManutenção.Controls.Add(this.button3);
            this.panelManutenção.Controls.Add(this.AtualizarManutenção);
            this.panelManutenção.Controls.Add(this.button5);
            this.panelManutenção.Controls.Add(this.label8);
            this.panelManutenção.Controls.Add(this.label14);
            this.panelManutenção.Controls.Add(this.textBox1);
            this.panelManutenção.Controls.Add(this.label16);
            this.panelManutenção.Controls.Add(this.textBox2);
            this.panelManutenção.Controls.Add(this.label19);
            this.panelManutenção.Location = new System.Drawing.Point(216, 11);
            this.panelManutenção.Margin = new System.Windows.Forms.Padding(2);
            this.panelManutenção.Name = "panelManutenção";
            this.panelManutenção.Size = new System.Drawing.Size(801, 587);
            this.panelManutenção.TabIndex = 21;
            this.panelManutenção.Visible = false;
            this.panelManutenção.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(113, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Ano, mês,  dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data Manutenção";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(32, 145);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Mask = "0000/00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(547, 371);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 241);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 162);
            this.dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exibir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ConsultarManutenção
            // 
            this.ConsultarManutenção.Location = new System.Drawing.Point(314, 182);
            this.ConsultarManutenção.Name = "ConsultarManutenção";
            this.ConsultarManutenção.Size = new System.Drawing.Size(75, 23);
            this.ConsultarManutenção.TabIndex = 11;
            this.ConsultarManutenção.Text = "Consultar";
            this.ConsultarManutenção.UseVisualStyleBackColor = true;
            this.ConsultarManutenção.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AtualizarManutenção
            // 
            this.AtualizarManutenção.Location = new System.Drawing.Point(116, 182);
            this.AtualizarManutenção.Name = "AtualizarManutenção";
            this.AtualizarManutenção.Size = new System.Drawing.Size(75, 23);
            this.AtualizarManutenção.TabIndex = 6;
            this.AtualizarManutenção.Text = "Atualizar";
            this.AtualizarManutenção.UseVisualStyleBackColor = true;
            this.AtualizarManutenção.Click += new System.EventHandler(this.AtualizarManutenção_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cadastrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Chave de Consulta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "ID Aparelho";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "ID Funcionario";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 31);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 15);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.Funcionarios);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Impressoras);
            this.panel2.Controls.Add(this.Manutenções);
            this.panel2.Controls.Add(this.Escolas);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 611);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CrudComBancoDeDados.Properties.Resources.WhatsApp_Image_2025_07_01_at_10_41_21_preview_rev_1_modified;
            this.pictureBox1.InitialImage = global::CrudComBancoDeDados.Properties.Resources.WhatsApp_Image_2025_07_01_at_10_41_21_preview_rev_1_modified;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 609);
            this.Controls.Add(this.panelManutenção);
            this.Controls.Add(this.panelImpressoras);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCadastroFuncionario);
            this.Controls.Add(this.panelEscolas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCadastroFuncionario.ResumeLayout(false);
            this.panelCadastroFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosFuncionarios)).EndInit();
            this.panelImpressoras.ResumeLayout(false);
            this.panelImpressoras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAparelho)).EndInit();
            this.panelEscolas.ResumeLayout(false);
            this.panelEscolas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEscolas)).EndInit();
            this.panelManutenção.ResumeLayout(false);
            this.panelManutenção.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CadastrarButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Panel panelCadastroFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonExibir;
        private System.Windows.Forms.Button buttonConsulta;
        private System.Windows.Forms.Button Funcionarios;
        private System.Windows.Forms.Button Impressoras;
        private System.Windows.Forms.Button Escolas;
        private System.Windows.Forms.Button Manutenções;
        private System.Windows.Forms.MaskedTextBox textNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDadosFuncionarios;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelImpressoras;
        private System.Windows.Forms.TextBox textIdEscola;
        private System.Windows.Forms.DataGridView dataGridAparelho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ExibirAparelhos;
        private System.Windows.Forms.Button ConsultarAparelhos;
        private System.Windows.Forms.Button DeleteAparelhos;
        private System.Windows.Forms.Button CadastrarAparelhos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ModeloAparelho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textIdAparelho;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelEscolas;
        private System.Windows.Forms.DataGridView dataGridEscolas;
        private System.Windows.Forms.Button ExibirEscolas;
        private System.Windows.Forms.Button ConsultarEscolas;
        private System.Windows.Forms.Button DeleteEscolas;
        private System.Windows.Forms.Button AtualizarEscola;
        private System.Windows.Forms.Button CadastrarEscola;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnomeEscola;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtidescola;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxAparelho;
        private System.Windows.Forms.Button exibirImpressoraEscola;
        private System.Windows.Forms.Panel panelManutenção;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConsultarManutenção;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AtualizarManutenção;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button atualizarAparelho;
    }
}

