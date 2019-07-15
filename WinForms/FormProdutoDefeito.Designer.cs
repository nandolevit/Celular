namespace WinForms
{
    partial class FormProdutoDefeito
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
            this.textBoxDefeito = new System.Windows.Forms.TextBox();
            this.labelDefeito = new System.Windows.Forms.Label();
            this.textBoxCodProd = new System.Windows.Forms.TextBox();
            this.labelProd = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.textBoxProdDescricao = new System.Windows.Forms.TextBox();
            this.buttonAddEletro = new System.Windows.Forms.Button();
            this.buttonBuscarEletro = new System.Windows.Forms.Button();
            this.groupBoxDecricao = new System.Windows.Forms.GroupBox();
            this.labelBarra = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBoxDecricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDefeito
            // 
            this.textBoxDefeito.Location = new System.Drawing.Point(6, 76);
            this.textBoxDefeito.Name = "textBoxDefeito";
            this.textBoxDefeito.Size = new System.Drawing.Size(732, 20);
            this.textBoxDefeito.TabIndex = 10;
            // 
            // labelDefeito
            // 
            this.labelDefeito.AutoSize = true;
            this.labelDefeito.Location = new System.Drawing.Point(6, 61);
            this.labelDefeito.Name = "labelDefeito";
            this.labelDefeito.Size = new System.Drawing.Size(44, 13);
            this.labelDefeito.TabIndex = 9;
            this.labelDefeito.Text = "Defeito:";
            // 
            // textBoxCodProd
            // 
            this.textBoxCodProd.Location = new System.Drawing.Point(6, 37);
            this.textBoxCodProd.Name = "textBoxCodProd";
            this.textBoxCodProd.Size = new System.Drawing.Size(65, 20);
            this.textBoxCodProd.TabIndex = 4;
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Location = new System.Drawing.Point(119, 20);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(47, 13);
            this.labelProd.TabIndex = 7;
            this.labelProd.Text = "Produto:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(583, 126);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(675, 126);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 2;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // textBoxProdDescricao
            // 
            this.textBoxProdDescricao.Location = new System.Drawing.Point(122, 36);
            this.textBoxProdDescricao.Multiline = true;
            this.textBoxProdDescricao.Name = "textBoxProdDescricao";
            this.textBoxProdDescricao.ReadOnly = true;
            this.textBoxProdDescricao.Size = new System.Drawing.Size(616, 21);
            this.textBoxProdDescricao.TabIndex = 8;
            // 
            // buttonAddEletro
            // 
            this.buttonAddEletro.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddEletro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddEletro.FlatAppearance.BorderSize = 0;
            this.buttonAddEletro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEletro.Location = new System.Drawing.Point(96, 37);
            this.buttonAddEletro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddEletro.Name = "buttonAddEletro";
            this.buttonAddEletro.Size = new System.Drawing.Size(20, 20);
            this.buttonAddEletro.TabIndex = 6;
            this.buttonAddEletro.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarEletro
            // 
            this.buttonBuscarEletro.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarEletro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarEletro.FlatAppearance.BorderSize = 0;
            this.buttonBuscarEletro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarEletro.Location = new System.Drawing.Point(76, 37);
            this.buttonBuscarEletro.Name = "buttonBuscarEletro";
            this.buttonBuscarEletro.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarEletro.TabIndex = 5;
            this.buttonBuscarEletro.UseVisualStyleBackColor = true;
            this.buttonBuscarEletro.Click += new System.EventHandler(this.buttonBuscarEletro_Click);
            // 
            // groupBoxDecricao
            // 
            this.groupBoxDecricao.Controls.Add(this.textBoxDefeito);
            this.groupBoxDecricao.Controls.Add(this.labelDefeito);
            this.groupBoxDecricao.Controls.Add(this.buttonAddEletro);
            this.groupBoxDecricao.Controls.Add(this.labelProd);
            this.groupBoxDecricao.Controls.Add(this.buttonBuscarEletro);
            this.groupBoxDecricao.Controls.Add(this.textBoxCodProd);
            this.groupBoxDecricao.Controls.Add(this.textBoxProdDescricao);
            this.groupBoxDecricao.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDecricao.Name = "groupBoxDecricao";
            this.groupBoxDecricao.Size = new System.Drawing.Size(748, 108);
            this.groupBoxDecricao.TabIndex = 0;
            this.groupBoxDecricao.TabStop = false;
            this.groupBoxDecricao.Text = "Produto/Defeito:";
            // 
            // labelBarra
            // 
            this.labelBarra.AutoSize = true;
            this.labelBarra.Location = new System.Drawing.Point(12, 127);
            this.labelBarra.Name = "labelBarra";
            this.labelBarra.Size = new System.Drawing.Size(71, 13);
            this.labelBarra.TabIndex = 46;
            this.labelBarra.Text = "Carregando...";
            this.labelBarra.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 143);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 23);
            this.progressBar1.TabIndex = 47;
            this.progressBar1.Visible = false;
            // 
            // FormProdutoDefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 570);
            this.Controls.Add(this.labelBarra);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBoxDecricao);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Name = "FormProdutoDefeito";
            this.Text = "Informe o produto e o defeito...";
            this.Load += new System.EventHandler(this.FormProdutoDefeito_Load);
            this.groupBoxDecricao.ResumeLayout(false);
            this.groupBoxDecricao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDefeito;
        private System.Windows.Forms.Label labelDefeito;
        private System.Windows.Forms.TextBox textBoxCodProd;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.TextBox textBoxProdDescricao;
        private System.Windows.Forms.Button buttonAddEletro;
        private System.Windows.Forms.Button buttonBuscarEletro;
        private System.Windows.Forms.GroupBox groupBoxDecricao;
        private System.Windows.Forms.Label labelBarra;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}