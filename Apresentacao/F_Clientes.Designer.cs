namespace Biblion.Apresentacao
{
    partial class F_Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Clientes));
            this.tbc_control = new System.Windows.Forms.TabControl();
            this.tbp_lista = new System.Windows.Forms.TabPage();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.tbp_dados = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_cidades = new System.Windows.Forms.ComboBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.n_numero = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_uf = new System.Windows.Forms.ComboBox();
            this.mtb_documento = new System.Windows.Forms.MaskedTextBox();
            this.dtp_datanasc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_registros = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_primeiro = new System.Windows.Forms.ToolStripButton();
            this.tsb_anterior = new System.Windows.Forms.ToolStripButton();
            this.tsb_proximo = new System.Windows.Forms.ToolStripButton();
            this.tsb_ultimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_incluir = new System.Windows.Forms.ToolStripButton();
            this.tsb_alterar = new System.Windows.Forms.ToolStripButton();
            this.tsb_excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gb_filtros = new System.Windows.Forms.GroupBox();
            this.cb_filtroStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_filtroNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbc_control.SuspendLayout();
            this.tbp_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.tbp_dados.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_numero)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gb_filtros.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_control
            // 
            this.tbc_control.Controls.Add(this.tbp_lista);
            this.tbc_control.Controls.Add(this.tbp_dados);
            this.tbc_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_control.Location = new System.Drawing.Point(0, 101);
            this.tbc_control.Name = "tbc_control";
            this.tbc_control.SelectedIndex = 0;
            this.tbc_control.Size = new System.Drawing.Size(971, 434);
            this.tbc_control.TabIndex = 22;
            this.tbc_control.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbc_control_KeyDown);
            // 
            // tbp_lista
            // 
            this.tbp_lista.Controls.Add(this.dgv_clientes);
            this.tbp_lista.Location = new System.Drawing.Point(4, 22);
            this.tbp_lista.Name = "tbp_lista";
            this.tbp_lista.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_lista.Size = new System.Drawing.Size(963, 408);
            this.tbp_lista.TabIndex = 0;
            this.tbp_lista.Text = "Lista";
            this.tbp_lista.UseVisualStyleBackColor = true;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.AllowUserToResizeRows = false;
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.Location = new System.Drawing.Point(3, 3);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(957, 402);
            this.dgv_clientes.TabIndex = 13;
            this.dgv_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellDoubleClick);
            this.dgv_clientes.SelectionChanged += new System.EventHandler(this.dgv_clientes_SelectionChanged);
            // 
            // tbp_dados
            // 
            this.tbp_dados.Controls.Add(this.panel4);
            this.tbp_dados.Controls.Add(this.panel3);
            this.tbp_dados.Location = new System.Drawing.Point(4, 22);
            this.tbp_dados.Name = "tbp_dados";
            this.tbp_dados.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_dados.Size = new System.Drawing.Size(963, 408);
            this.tbp_dados.TabIndex = 1;
            this.tbp_dados.Text = "Dados";
            this.tbp_dados.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_cancelar);
            this.panel4.Controls.Add(this.btn_gravar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 365);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(957, 40);
            this.panel4.TabIndex = 35;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(488, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(126, 34);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(273, 3);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(128, 34);
            this.btn_gravar.TabIndex = 2;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cb_cidades);
            this.panel3.Controls.Add(this.tb_nome);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.cb_status);
            this.panel3.Controls.Add(this.tb_id);
            this.panel3.Controls.Add(this.n_numero);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cb_sexo);
            this.panel3.Controls.Add(this.tb_endereco);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.tb_email);
            this.panel3.Controls.Add(this.tb_bairro);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.mtb_Telefone);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cb_uf);
            this.panel3.Controls.Add(this.mtb_documento);
            this.panel3.Controls.Add(this.dtp_datanasc);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 356);
            this.panel3.TabIndex = 34;
            // 
            // cb_cidades
            // 
            this.cb_cidades.Enabled = false;
            this.cb_cidades.FormattingEnabled = true;
            this.cb_cidades.Location = new System.Drawing.Point(263, 119);
            this.cb_cidades.Name = "cb_cidades";
            this.cb_cidades.Size = new System.Drawing.Size(164, 21);
            this.cb_cidades.TabIndex = 82;
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(90, 25);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(337, 20);
            this.tb_nome.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(430, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 100;
            this.label13.Text = "Status";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 87;
            this.label15.Text = "ID";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(433, 118);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(116, 21);
            this.cb_status.TabIndex = 83;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(14, 25);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(70, 20);
            this.tb_id.TabIndex = 88;
            this.tb_id.TabStop = false;
            // 
            // n_numero
            // 
            this.n_numero.Enabled = false;
            this.n_numero.Location = new System.Drawing.Point(460, 169);
            this.n_numero.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.n_numero.Name = "n_numero";
            this.n_numero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.n_numero.Size = new System.Drawing.Size(89, 20);
            this.n_numero.TabIndex = 86;
            this.n_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(87, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 89;
            this.label14.Text = "Nome";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 99;
            this.label12.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Sexo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "Endereço";
            // 
            // cb_sexo
            // 
            this.cb_sexo.Enabled = false;
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Location = new System.Drawing.Point(14, 70);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(116, 21);
            this.cb_sexo.TabIndex = 77;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Enabled = false;
            this.tb_endereco.Location = new System.Drawing.Point(163, 168);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(291, 20);
            this.tb_endereco.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "E-Mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Bairro";
            // 
            // tb_email
            // 
            this.tb_email.Enabled = false;
            this.tb_email.Location = new System.Drawing.Point(136, 70);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(291, 20);
            this.tb_email.TabIndex = 78;
            // 
            // tb_bairro
            // 
            this.tb_bairro.Enabled = false;
            this.tb_bairro.Location = new System.Drawing.Point(14, 168);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(143, 20);
            this.tb_bairro.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 96;
            this.label9.Text = "Cidade";
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.Enabled = false;
            this.mtb_Telefone.Location = new System.Drawing.Point(433, 70);
            this.mtb_Telefone.Mask = "(99) 0,0000-0000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(116, 20);
            this.mtb_Telefone.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Documento";
            // 
            // cb_uf
            // 
            this.cb_uf.Enabled = false;
            this.cb_uf.FormattingEnabled = true;
            this.cb_uf.Location = new System.Drawing.Point(136, 118);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(121, 21);
            this.cb_uf.TabIndex = 81;
            // 
            // mtb_documento
            // 
            this.mtb_documento.Enabled = false;
            this.mtb_documento.Location = new System.Drawing.Point(433, 25);
            this.mtb_documento.Mask = "000,000,000-00";
            this.mtb_documento.Name = "mtb_documento";
            this.mtb_documento.Size = new System.Drawing.Size(116, 20);
            this.mtb_documento.TabIndex = 76;
            // 
            // dtp_datanasc
            // 
            this.dtp_datanasc.Enabled = false;
            this.dtp_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datanasc.Location = new System.Drawing.Point(14, 119);
            this.dtp_datanasc.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtp_datanasc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_datanasc.Name = "dtp_datanasc";
            this.dtp_datanasc.Size = new System.Drawing.Size(116, 20);
            this.dtp_datanasc.TabIndex = 80;
            this.dtp_datanasc.Value = new System.DateTime(2024, 3, 25, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Data de Nascimento";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_registros
            // 
            this.lb_registros.AutoSize = true;
            this.lb_registros.Location = new System.Drawing.Point(3, 0);
            this.lb_registros.Name = "lb_registros";
            this.lb_registros.Size = new System.Drawing.Size(0, 13);
            this.lb_registros.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 57);
            this.panel1.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.tsb_primeiro,
            this.tsb_anterior,
            this.tsb_proximo,
            this.tsb_ultimo,
            this.toolStripSeparator1,
            this.tsb_incluir,
            this.tsb_alterar,
            this.tsb_excluir,
            this.toolStripSeparator2,
            this.tsb_sair,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(967, 54);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // tsb_primeiro
            // 
            this.tsb_primeiro.AutoSize = false;
            this.tsb_primeiro.Image = global::Biblion.Properties.Resources.arrow_top_15603;
            this.tsb_primeiro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_primeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_primeiro.Name = "tsb_primeiro";
            this.tsb_primeiro.Size = new System.Drawing.Size(56, 51);
            this.tsb_primeiro.Text = "Primeiro";
            this.tsb_primeiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_primeiro.Click += new System.EventHandler(this.tsb_primeiro_Click);
            // 
            // tsb_anterior
            // 
            this.tsb_anterior.AutoSize = false;
            this.tsb_anterior.Image = global::Biblion.Properties.Resources.arrow_left_15601;
            this.tsb_anterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_anterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_anterior.Name = "tsb_anterior";
            this.tsb_anterior.Size = new System.Drawing.Size(56, 51);
            this.tsb_anterior.Text = "Anterior";
            this.tsb_anterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_anterior.Click += new System.EventHandler(this.tsb_anterior_Click);
            // 
            // tsb_proximo
            // 
            this.tsb_proximo.AutoSize = false;
            this.tsb_proximo.Image = global::Biblion.Properties.Resources.arrow_right_15600;
            this.tsb_proximo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_proximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_proximo.Name = "tsb_proximo";
            this.tsb_proximo.Size = new System.Drawing.Size(56, 51);
            this.tsb_proximo.Text = "Próximo";
            this.tsb_proximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_proximo.Click += new System.EventHandler(this.tsb_proximo_Click);
            // 
            // tsb_ultimo
            // 
            this.tsb_ultimo.AutoSize = false;
            this.tsb_ultimo.Image = global::Biblion.Properties.Resources.arrow_bottom_15602;
            this.tsb_ultimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_ultimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ultimo.Name = "tsb_ultimo";
            this.tsb_ultimo.Size = new System.Drawing.Size(56, 51);
            this.tsb_ultimo.Text = "Ulimo";
            this.tsb_ultimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_ultimo.Click += new System.EventHandler(this.tsb_ultimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // tsb_incluir
            // 
            this.tsb_incluir.AutoSize = false;
            this.tsb_incluir.Image = global::Biblion.Properties.Resources.new_page_document_16676;
            this.tsb_incluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_incluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_incluir.Name = "tsb_incluir";
            this.tsb_incluir.Size = new System.Drawing.Size(56, 51);
            this.tsb_incluir.Text = "Incluir";
            this.tsb_incluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_incluir.Click += new System.EventHandler(this.tsb_incluir_Click);
            // 
            // tsb_alterar
            // 
            this.tsb_alterar.AutoSize = false;
            this.tsb_alterar.Image = global::Biblion.Properties.Resources.business_ordering_pencil_table_2333;
            this.tsb_alterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_alterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_alterar.Name = "tsb_alterar";
            this.tsb_alterar.Size = new System.Drawing.Size(56, 51);
            this.tsb_alterar.Text = "Alterar";
            this.tsb_alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_alterar.Click += new System.EventHandler(this.tsb_alterar_Click);
            // 
            // tsb_excluir
            // 
            this.tsb_excluir.AutoSize = false;
            this.tsb_excluir.Image = global::Biblion.Properties.Resources.delete_remove_page_document_16678;
            this.tsb_excluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_excluir.Name = "tsb_excluir";
            this.tsb_excluir.Size = new System.Drawing.Size(56, 51);
            this.tsb_excluir.Text = "Excluir";
            this.tsb_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_excluir.Click += new System.EventHandler(this.tsb_excluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // tsb_sair
            // 
            this.tsb_sair.AutoSize = false;
            this.tsb_sair.Image = global::Biblion.Properties.Resources.Logout_37127;
            this.tsb_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_sair.Name = "tsb_sair";
            this.tsb_sair.Size = new System.Drawing.Size(56, 51);
            this.tsb_sair.Text = "Sair";
            this.tsb_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_sair.Click += new System.EventHandler(this.tsb_sair_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // gb_filtros
            // 
            this.gb_filtros.Controls.Add(this.cb_filtroStatus);
            this.gb_filtros.Controls.Add(this.label1);
            this.gb_filtros.Controls.Add(this.tb_filtroNome);
            this.gb_filtros.Controls.Add(this.label2);
            this.gb_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_filtros.Location = new System.Drawing.Point(0, 0);
            this.gb_filtros.Name = "gb_filtros";
            this.gb_filtros.Size = new System.Drawing.Size(971, 44);
            this.gb_filtros.TabIndex = 21;
            this.gb_filtros.TabStop = false;
            // 
            // cb_filtroStatus
            // 
            this.cb_filtroStatus.FormattingEnabled = true;
            this.cb_filtroStatus.Location = new System.Drawing.Point(393, 14);
            this.cb_filtroStatus.Name = "cb_filtroStatus";
            this.cb_filtroStatus.Size = new System.Drawing.Size(153, 21);
            this.cb_filtroStatus.TabIndex = 6;
            this.cb_filtroStatus.SelectedValueChanged += new System.EventHandler(this.cb_filtroStatus_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status:";
            // 
            // tb_filtroNome
            // 
            this.tb_filtroNome.Location = new System.Drawing.Point(50, 14);
            this.tb_filtroNome.Name = "tb_filtroNome";
            this.tb_filtroNome.Size = new System.Drawing.Size(271, 20);
            this.tb_filtroNome.TabIndex = 4;
            this.tb_filtroNome.TextChanged += new System.EventHandler(this.tb_filtroNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_registros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 20);
            this.panel2.TabIndex = 20;
            // 
            // F_Clientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(971, 555);
            this.Controls.Add(this.tbc_control);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_filtros);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Clientes";
            this.Load += new System.EventHandler(this.F_Clientes_Load);
            this.Shown += new System.EventHandler(this.F_Clientes_Shown_1);
            this.tbc_control.ResumeLayout(false);
            this.tbp_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.tbp_dados.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_numero)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gb_filtros.ResumeLayout(false);
            this.gb_filtros.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_control;
        private System.Windows.Forms.TabPage tbp_lista;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TabPage tbp_dados;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lb_registros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_primeiro;
        private System.Windows.Forms.ToolStripButton tsb_anterior;
        private System.Windows.Forms.ToolStripButton tsb_proximo;
        private System.Windows.Forms.ToolStripButton tsb_ultimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_incluir;
        private System.Windows.Forms.ToolStripButton tsb_alterar;
        private System.Windows.Forms.ToolStripButton tsb_excluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox gb_filtros;
        private System.Windows.Forms.ComboBox cb_filtroStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_filtroNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_cidades;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.NumericUpDown n_numero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_uf;
        private System.Windows.Forms.MaskedTextBox mtb_documento;
        private System.Windows.Forms.DateTimePicker dtp_datanasc;
        private System.Windows.Forms.Label label7;
    }
}