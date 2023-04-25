namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    partial class Frmclientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCadastroClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtUF = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBAirro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesqNome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabCadastroClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabCadastroClientes
            // 
            this.tabCadastroClientes.Controls.Add(this.tabPage1);
            this.tabCadastroClientes.Controls.Add(this.tabPage2);
            this.tabCadastroClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCadastroClientes.Location = new System.Drawing.Point(0, 56);
            this.tabCadastroClientes.Name = "tabCadastroClientes";
            this.tabCadastroClientes.SelectedIndex = 0;
            this.tabCadastroClientes.Size = new System.Drawing.Size(884, 408);
            this.tabCadastroClientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtUF);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtBAirro);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtComplemento);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtNumero);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtLogradouro);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtCEP);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtTel);
            this.tabPage1.Controls.Add(this.txtCelular);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtRG);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCod);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.FormattingEnabled = true;
            this.txtUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtUF.Location = new System.Drawing.Point(473, 288);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(149, 29);
            this.txtUF.TabIndex = 61;
            this.txtUF.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(287, 288);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 27);
            this.txtCidade.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(208, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 21);
            this.label15.TabIndex = 59;
            this.label15.Text = "Cidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(434, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 21);
            this.label14.TabIndex = 58;
            this.label14.Text = "UF:";
            // 
            // txtBAirro
            // 
            this.txtBAirro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAirro.Location = new System.Drawing.Point(509, 238);
            this.txtBAirro.Name = "txtBAirro";
            this.txtBAirro.Size = new System.Drawing.Size(279, 27);
            this.txtBAirro.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(446, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 21);
            this.label13.TabIndex = 56;
            this.label13.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(161, 232);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(272, 27);
            this.txtComplemento.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 21);
            this.label12.TabIndex = 54;
            this.label12.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(688, 183);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 27);
            this.txtNumero.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(606, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 52;
            this.label11.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(137, 186);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(445, 27);
            this.txtLogradouro.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Logradouro:";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(78, 288);
            this.txtCEP.Mask = "00.000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 27);
            this.txtCEP.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 48;
            this.label9.Text = "CEP:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(323, 127);
            this.txtTel.Mask = "(00) 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(129, 27);
            this.txtTel.TabIndex = 47;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(98, 127);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(133, 27);
            this.txtCelular.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 45;
            this.label8.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Telefone:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(546, 91);
            this.txtCPF.Mask = "###.###.###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(117, 27);
            this.txtCPF.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "CPF:";
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(540, 49);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(117, 27);
            this.txtRG.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "RG:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(91, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(376, 27);
            this.txtEmail.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(91, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(376, 27);
            this.txtNome.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nome:";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(98, 9);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 27);
            this.txtCod.TabIndex = 35;
            this.txtCod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridClientes);
            this.tabPage2.Controls.Add(this.btnPesquisar);
            this.tabPage2.Controls.Add(this.txtPesqNome);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(13, 72);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.Size = new System.Drawing.Size(855, 291);
            this.dataGridClientes.TabIndex = 41;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(483, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(117, 42);
            this.btnPesquisar.TabIndex = 40;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqNome.Location = new System.Drawing.Point(76, 30);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(376, 27);
            this.txtPesqNome.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 21);
            this.label16.TabIndex = 38;
            this.label16.Text = "Nome:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightBlue;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(380, 487);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 51);
            this.btnExcluir.TabIndex = 65;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(266, 487);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 51);
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(145, 487);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 51);
            this.btnSalvar.TabIndex = 63;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(31, 487);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(101, 51);
            this.btnNovo.TabIndex = 62;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.tabCadastroClientes);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Frmclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCadastroClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCadastroClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox txtUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBAirro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesqNome;
        private System.Windows.Forms.Label label16;
    }
}