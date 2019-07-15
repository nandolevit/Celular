namespace WinForms
{
    partial class FormServicoTipo
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
            this.buttonNotebook = new System.Windows.Forms.Button();
            this.buttonCelular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNotebook
            // 
            this.buttonNotebook.BackColor = System.Drawing.Color.Transparent;
            this.buttonNotebook.FlatAppearance.BorderSize = 0;
            this.buttonNotebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotebook.Image = global::WinForms.Properties.Resources.icons8_iMac_32;
            this.buttonNotebook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNotebook.Location = new System.Drawing.Point(124, 15);
            this.buttonNotebook.Name = "buttonNotebook";
            this.buttonNotebook.Size = new System.Drawing.Size(102, 60);
            this.buttonNotebook.TabIndex = 3;
            this.buttonNotebook.Text = "Notebook (F2)";
            this.buttonNotebook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNotebook.UseVisualStyleBackColor = false;
            this.buttonNotebook.Click += new System.EventHandler(this.ButtonNotebook_Click);
            this.buttonNotebook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonNotebook_KeyDown);
            // 
            // buttonCelular
            // 
            this.buttonCelular.BackColor = System.Drawing.Color.Transparent;
            this.buttonCelular.FlatAppearance.BorderSize = 0;
            this.buttonCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCelular.Image = global::WinForms.Properties.Resources.icons8_iPhone_32;
            this.buttonCelular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCelular.Location = new System.Drawing.Point(14, 15);
            this.buttonCelular.Name = "buttonCelular";
            this.buttonCelular.Size = new System.Drawing.Size(102, 60);
            this.buttonCelular.TabIndex = 2;
            this.buttonCelular.Text = "Celular (F1)";
            this.buttonCelular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCelular.UseVisualStyleBackColor = false;
            this.buttonCelular.Click += new System.EventHandler(this.ButtonCelular_Click);
            // 
            // FormServicoTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 90);
            this.Controls.Add(this.buttonNotebook);
            this.Controls.Add(this.buttonCelular);
            this.Name = "FormServicoTipo";
            this.Text = "FormServicoTipo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNotebook;
        private System.Windows.Forms.Button buttonCelular;
    }
}