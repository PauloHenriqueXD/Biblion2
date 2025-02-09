namespace Biblion.Apresentacao
{
    partial class F_Cidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Cidades));
            this.tbc_control = new System.Windows.Forms.TabControl();
            this.tbp_lista = new System.Windows.Forms.TabPage();
            this.dgv_cidades = new System.Windows.Forms.DataGridView();
            this.tbp_dados = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_codMunicipio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_estados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_funcoes = new System.Windows.Forms.ToolStripSplitButton();
            this.importarEstadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gb_filtros = new System.Windows.Forms.GroupBox();
            this.tb_filtroNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbc_control.SuspendLayout();
            this.tbp_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidades)).BeginInit();
            this.tbp_dados.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tbp_lista.Controls.Add(this.dgv_cidades);
            this.tbp_lista.Location = new System.Drawing.Point(4, 22);
            this.tbp_lista.Name = "tbp_lista";
            this.tbp_lista.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_lista.Size = new System.Drawing.Size(963, 408);
            this.tbp_lista.TabIndex = 0;
            this.tbp_lista.Text = "Lista";
            this.tbp_lista.UseVisualStyleBackColor = true;
            // 
            // dgv_cidades
            // 
            this.dgv_cidades.AllowUserToAddRows = false;
            this.dgv_cidades.AllowUserToDeleteRows = false;
            this.dgv_cidades.AllowUserToResizeRows = false;
            this.dgv_cidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cidades.EnableHeadersVisualStyles = false;
            this.dgv_cidades.Location = new System.Drawing.Point(3, 3);
            this.dgv_cidades.MultiSelect = false;
            this.dgv_cidades.Name = "dgv_cidades";
            this.dgv_cidades.ReadOnly = true;
            this.dgv_cidades.RowHeadersVisible = false;
            this.dgv_cidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cidades.Size = new System.Drawing.Size(957, 402);
            this.dgv_cidades.TabIndex = 13;
            this.dgv_cidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cidades_CellDoubleClick);
            this.dgv_cidades.SelectionChanged += new System.EventHandler(this.dgv_cidades_SelectionChanged);
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
            this.panel3.Controls.Add(this.tb_cidade);
            this.panel3.Controls.Add(this.tb_codMunicipio);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cb_estados);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tb_id);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 356);
            this.panel3.TabIndex = 34;
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(12, 145);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(337, 20);
            this.tb_cidade.TabIndex = 44;
            // 
            // tb_codMunicipio
            // 
            this.tb_codMunicipio.Location = new System.Drawing.Point(397, 147);
            this.tb_codMunicipio.Name = "tb_codMunicipio";
            this.tb_codMunicipio.Size = new System.Drawing.Size(100, 20);
            this.tb_codMunicipio.TabIndex = 43;
            this.tb_codMunicipio.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Estado";
            // 
            // cb_estados
            // 
            this.cb_estados.FormattingEnabled = true;
            this.cb_estados.Location = new System.Drawing.Point(12, 88);
            this.cb_estados.Name = "cb_estados";
            this.cb_estados.Size = new System.Drawing.Size(337, 21);
            this.cb_estados.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cod. Municipio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cidade";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 27);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(70, 20);
            this.tb_id.TabIndex = 37;
            this.tb_id.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID";
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
            this.toolStripSeparator5,
            this.tsb_funcoes,
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 54);
            // 
            // tsb_funcoes
            // 
            this.tsb_funcoes.AutoSize = false;
            this.tsb_funcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarEstadosToolStripMenuItem});
            this.tsb_funcoes.Image = global::Biblion.Properties.Resources.funcoes2;
            this.tsb_funcoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_funcoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_funcoes.Name = "tsb_funcoes";
            this.tsb_funcoes.Size = new System.Drawing.Size(65, 51);
            this.tsb_funcoes.Text = "Funções";
            this.tsb_funcoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // importarEstadosToolStripMenuItem
            // 
            this.importarEstadosToolStripMenuItem.Name = "importarEstadosToolStripMenuItem";
            this.importarEstadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarEstadosToolStripMenuItem.Text = "Importar Cidades";
            this.importarEstadosToolStripMenuItem.Click += new System.EventHandler(this.importarEstadosToolStripMenuItem_Click);
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
            this.gb_filtros.Controls.Add(this.tb_filtroNome);
            this.gb_filtros.Controls.Add(this.label2);
            this.gb_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_filtros.Location = new System.Drawing.Point(0, 0);
            this.gb_filtros.Name = "gb_filtros";
            this.gb_filtros.Size = new System.Drawing.Size(971, 44);
            this.gb_filtros.TabIndex = 21;
            this.gb_filtros.TabStop = false;
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
            // F_Cidades
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(971, 555);
            this.Controls.Add(this.tbc_control);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_filtros);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Cidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Cidades";
            this.Load += new System.EventHandler(this.F_Cidades_Load);
            this.Shown += new System.EventHandler(this.F_Cidades_Shown);
            this.tbc_control.ResumeLayout(false);
            this.tbp_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidades)).EndInit();
            this.tbp_dados.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_cidades;
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
        private System.Windows.Forms.TextBox tb_filtroNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripSplitButton tsb_funcoes;
        public System.Windows.Forms.ToolStripMenuItem importarEstadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TextBox tb_codMunicipio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_estados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cidade;
    }
}