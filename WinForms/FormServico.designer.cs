﻿namespace WinForms
{
    partial class FormServico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServico));
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDefeito = new System.Windows.Forms.Label();
            this.textBoxDefeito = new System.Windows.Forms.TextBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.dataGridViewServico = new System.Windows.Forms.DataGridView();
            this.colOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCodTec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResponsavel = new System.Windows.Forms.TextBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.textBoxCaracteristica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.groupBoxServico = new System.Windows.Forms.GroupBox();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonAddTec = new System.Windows.Forms.Button();
            this.buttonBuscarTec = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddServico = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.labelBarra = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(9, 33);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(493, 20);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.TabStop = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(6, 16);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(6, 56);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(56, 13);
            this.labelEnd.TabIndex = 5;
            this.labelEnd.Text = "Endereço:";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(9, 69);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.ReadOnly = true;
            this.textBoxEnd.Size = new System.Drawing.Size(760, 20);
            this.textBoxEnd.TabIndex = 6;
            this.textBoxEnd.TabStop = false;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(6, 92);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(52, 13);
            this.labelDescricao.TabIndex = 10;
            this.labelDescricao.Text = "Aparelho:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(9, 105);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.ReadOnly = true;
            this.textBoxDescricao.Size = new System.Drawing.Size(720, 39);
            this.textBoxDescricao.TabIndex = 11;
            this.textBoxDescricao.TabStop = false;
            // 
            // labelDefeito
            // 
            this.labelDefeito.AutoSize = true;
            this.labelDefeito.Location = new System.Drawing.Point(6, 147);
            this.labelDefeito.Name = "labelDefeito";
            this.labelDefeito.Size = new System.Drawing.Size(44, 13);
            this.labelDefeito.TabIndex = 13;
            this.labelDefeito.Text = "Defeito:";
            // 
            // textBoxDefeito
            // 
            this.textBoxDefeito.Location = new System.Drawing.Point(9, 160);
            this.textBoxDefeito.Name = "textBoxDefeito";
            this.textBoxDefeito.ReadOnly = true;
            this.textBoxDefeito.Size = new System.Drawing.Size(768, 20);
            this.textBoxDefeito.TabIndex = 14;
            this.textBoxDefeito.TabStop = false;
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(540, 33);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(229, 20);
            this.dateTimePickerData.TabIndex = 4;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(537, 17);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "&Data:";
            // 
            // dataGridViewServico
            // 
            this.dataGridViewServico.AllowUserToAddRows = false;
            this.dataGridViewServico.AllowUserToDeleteRows = false;
            this.dataGridViewServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOs,
            this.colDescricao,
            this.colDefeito,
            this.colObs,
            this.colTaxa,
            this.colData});
            this.dataGridViewServico.Location = new System.Drawing.Point(12, 494);
            this.dataGridViewServico.Name = "dataGridViewServico";
            this.dataGridViewServico.ReadOnly = true;
            this.dataGridViewServico.RowHeadersVisible = false;
            this.dataGridViewServico.Size = new System.Drawing.Size(783, 99);
            this.dataGridViewServico.TabIndex = 2;
            // 
            // colOs
            // 
            this.colOs.DataPropertyName = "serid";
            this.colOs.HeaderText = "OS:";
            this.colOs.Name = "colOs";
            this.colOs.ReadOnly = true;
            this.colOs.Width = 75;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "serdescricao";
            this.colDescricao.HeaderText = "Descrição:";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 300;
            // 
            // colDefeito
            // 
            this.colDefeito.DataPropertyName = "serdefeitodescricao";
            this.colDefeito.HeaderText = "Defeito:";
            this.colDefeito.Name = "colDefeito";
            this.colDefeito.ReadOnly = true;
            this.colDefeito.Width = 200;
            // 
            // colObs
            // 
            this.colObs.DataPropertyName = "serobs";
            this.colObs.HeaderText = "Observações:";
            this.colObs.Name = "colObs";
            this.colObs.ReadOnly = true;
            this.colObs.Width = 200;
            // 
            // colTaxa
            // 
            this.colTaxa.DataPropertyName = "sertaxa";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colTaxa.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTaxa.HeaderText = "Taxa:";
            this.colTaxa.Name = "colTaxa";
            this.colTaxa.ReadOnly = true;
            this.colTaxa.Width = 50;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "serdataagend";
            this.colData.HeaderText = "Data:";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 200;
            // 
            // textBoxCodTec
            // 
            this.textBoxCodTec.Location = new System.Drawing.Point(9, 410);
            this.textBoxCodTec.Name = "textBoxCodTec";
            this.textBoxCodTec.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodTec.TabIndex = 17;
            this.textBoxCodTec.TextChanged += new System.EventHandler(this.textBoxCodTec_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Técnico Responsável:";
            // 
            // textBoxResponsavel
            // 
            this.textBoxResponsavel.Location = new System.Drawing.Point(86, 411);
            this.textBoxResponsavel.Name = "textBoxResponsavel";
            this.textBoxResponsavel.ReadOnly = true;
            this.textBoxResponsavel.Size = new System.Drawing.Size(438, 20);
            this.textBoxResponsavel.TabIndex = 21;
            this.textBoxResponsavel.TabStop = false;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(6, 183);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(140, 13);
            this.labelObs.TabIndex = 15;
            this.labelObs.Text = "Características do aparelho:";
            // 
            // textBoxCaracteristica
            // 
            this.textBoxCaracteristica.Location = new System.Drawing.Point(9, 196);
            this.textBoxCaracteristica.Multiline = true;
            this.textBoxCaracteristica.Name = "textBoxCaracteristica";
            this.textBoxCaracteristica.ReadOnly = true;
            this.textBoxCaracteristica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCaracteristica.Size = new System.Drawing.Size(768, 190);
            this.textBoxCaracteristica.TabIndex = 16;
            this.textBoxCaracteristica.Leave += new System.EventHandler(this.TextBoxObs_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOVA ORDEM DE SERVIÇO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNao);
            this.groupBox1.Controls.Add(this.radioButtonSim);
            this.groupBox1.Location = new System.Drawing.Point(615, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 38);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Garantia?";
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Checked = true;
            this.radioButtonNao.Location = new System.Drawing.Point(62, 15);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNao.TabIndex = 1;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(10, 15);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSim.TabIndex = 0;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // groupBoxServico
            // 
            this.groupBoxServico.Controls.Add(this.labelNome);
            this.groupBoxServico.Controls.Add(this.textBoxNome);
            this.groupBoxServico.Controls.Add(this.groupBox1);
            this.groupBoxServico.Controls.Add(this.textBoxEnd);
            this.groupBoxServico.Controls.Add(this.labelEnd);
            this.groupBoxServico.Controls.Add(this.buttonCliente);
            this.groupBoxServico.Controls.Add(this.textBoxDescricao);
            this.groupBoxServico.Controls.Add(this.labelDescricao);
            this.groupBoxServico.Controls.Add(this.labelObs);
            this.groupBoxServico.Controls.Add(this.textBoxDefeito);
            this.groupBoxServico.Controls.Add(this.textBoxCaracteristica);
            this.groupBoxServico.Controls.Add(this.labelDefeito);
            this.groupBoxServico.Controls.Add(this.buttonAddTec);
            this.groupBoxServico.Controls.Add(this.dateTimePickerData);
            this.groupBoxServico.Controls.Add(this.buttonBuscarTec);
            this.groupBoxServico.Controls.Add(this.buttonAdd);
            this.groupBoxServico.Controls.Add(this.textBoxCodTec);
            this.groupBoxServico.Controls.Add(this.label2);
            this.groupBoxServico.Controls.Add(this.labelData);
            this.groupBoxServico.Controls.Add(this.textBoxResponsavel);
            this.groupBoxServico.Controls.Add(this.buttonAddServico);
            this.groupBoxServico.Location = new System.Drawing.Point(12, 50);
            this.groupBoxServico.Name = "groupBoxServico";
            this.groupBoxServico.Size = new System.Drawing.Size(783, 438);
            this.groupBoxServico.TabIndex = 1;
            this.groupBoxServico.TabStop = false;
            this.groupBoxServico.Text = "Serviço:";
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCliente.BackgroundImage")));
            this.buttonCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCliente.Location = new System.Drawing.Point(508, 31);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(26, 23);
            this.buttonCliente.TabIndex = 2;
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.ButtonCliente_Click);
            // 
            // buttonAddTec
            // 
            this.buttonAddTec.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddTec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddTec.Enabled = false;
            this.buttonAddTec.FlatAppearance.BorderSize = 0;
            this.buttonAddTec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTec.Location = new System.Drawing.Point(63, 410);
            this.buttonAddTec.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddTec.Name = "buttonAddTec";
            this.buttonAddTec.Size = new System.Drawing.Size(20, 20);
            this.buttonAddTec.TabIndex = 19;
            this.buttonAddTec.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarTec
            // 
            this.buttonBuscarTec.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarTec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarTec.FlatAppearance.BorderSize = 0;
            this.buttonBuscarTec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarTec.Location = new System.Drawing.Point(43, 410);
            this.buttonBuscarTec.Name = "buttonBuscarTec";
            this.buttonBuscarTec.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarTec.TabIndex = 18;
            this.buttonBuscarTec.UseVisualStyleBackColor = true;
            this.buttonBuscarTec.Click += new System.EventHandler(this.buttonBuscarTec_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_64;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(735, 105);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 39);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAddServico
            // 
            this.buttonAddServico.BackgroundImage = global::WinForms.Properties.Resources.add_32;
            this.buttonAddServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddServico.Enabled = false;
            this.buttonAddServico.Location = new System.Drawing.Point(736, 398);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(41, 34);
            this.buttonAddServico.TabIndex = 23;
            this.buttonAddServico.UseVisualStyleBackColor = true;
            this.buttonAddServico.Click += new System.EventHandler(this.buttonAddServico_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(618, 599);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 6;
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
            this.buttonFechar.Location = new System.Drawing.Point(710, 599);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click_1);
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackgroundImage = global::WinForms.Properties.Resources.remove_32;
            this.buttonRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRemover.Enabled = false;
            this.buttonRemover.Location = new System.Drawing.Point(12, 599);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(41, 40);
            this.buttonRemover.TabIndex = 3;
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackgroundImage = global::WinForms.Properties.Resources.icons8_Print_32;
            this.buttonImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonImprimir.Enabled = false;
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Location = new System.Drawing.Point(559, 599);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(53, 40);
            this.buttonImprimir.TabIndex = 5;
            this.buttonImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // labelBarra
            // 
            this.labelBarra.AutoSize = true;
            this.labelBarra.Location = new System.Drawing.Point(101, 600);
            this.labelBarra.Name = "labelBarra";
            this.labelBarra.Size = new System.Drawing.Size(71, 13);
            this.labelBarra.TabIndex = 46;
            this.labelBarra.Text = "Carregando...";
            this.labelBarra.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(101, 616);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 23);
            this.progressBar1.TabIndex = 47;
            this.progressBar1.Visible = false;
            // 
            // FormServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 660);
            this.Controls.Add(this.labelBarra);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBoxServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.dataGridViewServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormServico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServico_FormClosed);
            this.Load += new System.EventHandler(this.FrmServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxServico.ResumeLayout(false);
            this.groupBoxServico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDefeito;
        private System.Windows.Forms.TextBox textBoxDefeito;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DataGridView dataGridViewServico;
        private System.Windows.Forms.Button buttonAddServico;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonAddTec;
        private System.Windows.Forms.Button buttonBuscarTec;
        private System.Windows.Forms.TextBox textBoxCodTec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResponsavel;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.TextBox textBoxCaracteristica;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.GroupBox groupBoxServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.Label labelBarra;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}