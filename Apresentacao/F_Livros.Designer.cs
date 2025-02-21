namespace Biblion.Apresentacao
{
    partial class F_Livros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Livros));
            this.tbc_control = new System.Windows.Forms.TabControl();
            this.tbp_lista = new System.Windows.Forms.TabPage();
            this.dgv_livros = new System.Windows.Forms.DataGridView();
            this.tbp_dados = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gb_descricao = new System.Windows.Forms.GroupBox();
            this.rtb_descricao = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_idioma = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_categoria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_numeroPaginas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_editora = new System.Windows.Forms.TextBox();
            this.dtp_dataPublicacao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_autores = new System.Windows.Forms.TextBox();
            this.btn_addFoto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).BeginInit();
            this.tbp_dados.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_descricao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
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
            this.tbp_lista.Controls.Add(this.dgv_livros);
            this.tbp_lista.Location = new System.Drawing.Point(4, 22);
            this.tbp_lista.Name = "tbp_lista";
            this.tbp_lista.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_lista.Size = new System.Drawing.Size(963, 408);
            this.tbp_lista.TabIndex = 0;
            this.tbp_lista.Text = "Lista";
            this.tbp_lista.UseVisualStyleBackColor = true;
            // 
            // dgv_livros
            // 
            this.dgv_livros.AllowUserToAddRows = false;
            this.dgv_livros.AllowUserToDeleteRows = false;
            this.dgv_livros.AllowUserToResizeRows = false;
            this.dgv_livros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_livros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_livros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_livros.EnableHeadersVisualStyles = false;
            this.dgv_livros.Location = new System.Drawing.Point(3, 3);
            this.dgv_livros.MultiSelect = false;
            this.dgv_livros.Name = "dgv_livros";
            this.dgv_livros.ReadOnly = true;
            this.dgv_livros.RowHeadersVisible = false;
            this.dgv_livros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_livros.Size = new System.Drawing.Size(957, 402);
            this.dgv_livros.TabIndex = 13;
            this.dgv_livros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_livros_CellDoubleClick);
            this.dgv_livros.SelectionChanged += new System.EventHandler(this.dgv_livros_SelectionChanged);
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
            this.panel3.Controls.Add(this.gb_descricao);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.tb_idioma);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tb_categoria);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.tb_numeroPaginas);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.tb_editora);
            this.panel3.Controls.Add(this.dtp_dataPublicacao);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tb_autores);
            this.panel3.Controls.Add(this.btn_addFoto);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.pb_foto);
            this.panel3.Controls.Add(this.tb_id);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tb_ISBN);
            this.panel3.Controls.Add(this.tb_titulo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cb_status);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 356);
            this.panel3.TabIndex = 34;
            // 
            // gb_descricao
            // 
            this.gb_descricao.Controls.Add(this.rtb_descricao);
            this.gb_descricao.Location = new System.Drawing.Point(14, 153);
            this.gb_descricao.Name = "gb_descricao";
            this.gb_descricao.Size = new System.Drawing.Size(936, 196);
            this.gb_descricao.TabIndex = 105;
            this.gb_descricao.TabStop = false;
            this.gb_descricao.Text = "Descrição";
            // 
            // rtb_descricao
            // 
            this.rtb_descricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_descricao.Enabled = false;
            this.rtb_descricao.Location = new System.Drawing.Point(3, 16);
            this.rtb_descricao.Name = "rtb_descricao";
            this.rtb_descricao.Size = new System.Drawing.Size(930, 177);
            this.rtb_descricao.TabIndex = 0;
            this.rtb_descricao.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(498, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 104;
            this.label12.Text = "Idioma";
            // 
            // tb_idioma
            // 
            this.tb_idioma.Enabled = false;
            this.tb_idioma.Location = new System.Drawing.Point(501, 118);
            this.tb_idioma.Name = "tb_idioma";
            this.tb_idioma.Size = new System.Drawing.Size(170, 20);
            this.tb_idioma.TabIndex = 103;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 102;
            this.label11.Text = "Categoria";
            // 
            // tb_categoria
            // 
            this.tb_categoria.Enabled = false;
            this.tb_categoria.Location = new System.Drawing.Point(261, 118);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.Size = new System.Drawing.Size(234, 20);
            this.tb_categoria.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Nº De Páginas";
            // 
            // tb_numeroPaginas
            // 
            this.tb_numeroPaginas.Enabled = false;
            this.tb_numeroPaginas.Location = new System.Drawing.Point(136, 118);
            this.tb_numeroPaginas.Name = "tb_numeroPaginas";
            this.tb_numeroPaginas.Size = new System.Drawing.Size(119, 20);
            this.tb_numeroPaginas.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "Editora";
            // 
            // tb_editora
            // 
            this.tb_editora.Enabled = false;
            this.tb_editora.Location = new System.Drawing.Point(437, 68);
            this.tb_editora.Name = "tb_editora";
            this.tb_editora.Size = new System.Drawing.Size(422, 20);
            this.tb_editora.TabIndex = 97;
            // 
            // dtp_dataPublicacao
            // 
            this.dtp_dataPublicacao.Enabled = false;
            this.dtp_dataPublicacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataPublicacao.Location = new System.Drawing.Point(14, 118);
            this.dtp_dataPublicacao.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtp_dataPublicacao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_dataPublicacao.Name = "dtp_dataPublicacao";
            this.dtp_dataPublicacao.Size = new System.Drawing.Size(116, 20);
            this.dtp_dataPublicacao.TabIndex = 5;
            this.dtp_dataPublicacao.Value = new System.DateTime(2024, 3, 25, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Data de Públicação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Autores";
            // 
            // tb_autores
            // 
            this.tb_autores.Enabled = false;
            this.tb_autores.Location = new System.Drawing.Point(14, 68);
            this.tb_autores.Name = "tb_autores";
            this.tb_autores.Size = new System.Drawing.Size(417, 20);
            this.tb_autores.TabIndex = 3;
            // 
            // btn_addFoto
            // 
            this.btn_addFoto.Enabled = false;
            this.btn_addFoto.Location = new System.Drawing.Point(865, 127);
            this.btn_addFoto.Name = "btn_addFoto";
            this.btn_addFoto.Size = new System.Drawing.Size(85, 23);
            this.btn_addFoto.TabIndex = 6;
            this.btn_addFoto.Text = "Add Imagem";
            this.btn_addFoto.UseVisualStyleBackColor = true;
            this.btn_addFoto.Click += new System.EventHandler(this.btn_addFoto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID";
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(865, 8);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(85, 113);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 33;
            this.pb_foto.TabStop = false;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(14, 24);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(70, 20);
            this.tb_id.TabIndex = 21;
            this.tb_id.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Status";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Enabled = false;
            this.tb_ISBN.Location = new System.Drawing.Point(90, 24);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(195, 20);
            this.tb_ISBN.TabIndex = 1;
            // 
            // tb_titulo
            // 
            this.tb_titulo.Enabled = false;
            this.tb_titulo.Location = new System.Drawing.Point(291, 24);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(568, 20);
            this.tb_titulo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Título";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(677, 118);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(182, 21);
            this.cb_status.TabIndex = 4;
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
            // F_Livros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(971, 555);
            this.Controls.Add(this.tbc_control);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_filtros);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Livros";
            this.Load += new System.EventHandler(this.F_Livros_Load);
            this.Shown += new System.EventHandler(this.F_Livros_Shown);
            this.tbc_control.ResumeLayout(false);
            this.tbp_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).EndInit();
            this.tbp_dados.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gb_descricao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_livros;
        private System.Windows.Forms.TabPage tbp_dados;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_addFoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_autores;
        private System.Windows.Forms.DateTimePicker dtp_dataPublicacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_numeroPaginas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_editora;
        private System.Windows.Forms.GroupBox gb_descricao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_idioma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_categoria;
        private System.Windows.Forms.RichTextBox rtb_descricao;
    }
}