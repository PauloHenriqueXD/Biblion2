namespace Biblion.Apresentacao
{
    partial class F_ImportaCidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ImportaCidades));
            this.checkedListBoxEstados = new System.Windows.Forms.CheckedListBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_importar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarImportacao = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // checkedListBoxEstados
            // 
            this.checkedListBoxEstados.FormattingEnabled = true;
            this.checkedListBoxEstados.Location = new System.Drawing.Point(12, 27);
            this.checkedListBoxEstados.Name = "checkedListBoxEstados";
            this.checkedListBoxEstados.Size = new System.Drawing.Size(560, 184);
            this.checkedListBoxEstados.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(314, 294);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(126, 34);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_importar
            // 
            this.btn_importar.Location = new System.Drawing.Point(104, 294);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(128, 34);
            this.btn_importar.TabIndex = 2;
            this.btn_importar.Text = "Importar Dados";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione os Estados que deseja importar as Cidades:";
            // 
            // progressBarImportacao
            // 
            this.progressBarImportacao.Location = new System.Drawing.Point(12, 229);
            this.progressBarImportacao.Name = "progressBarImportacao";
            this.progressBarImportacao.Size = new System.Drawing.Size(560, 45);
            this.progressBarImportacao.TabIndex = 5;
            // 
            // F_ImportaCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 345);
            this.Controls.Add(this.progressBarImportacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.checkedListBoxEstados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_ImportaCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação de Cidades";
            this.Load += new System.EventHandler(this.F_ImportaCidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxEstados;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarImportacao;
    }
}