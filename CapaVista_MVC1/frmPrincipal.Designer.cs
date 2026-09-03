namespace CapaVista_MVC1
{
    partial class frmPrincipal
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
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Dgv_consultar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultar)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.Location = new System.Drawing.Point(662, 61);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(177, 112);
            this.Btn_consultar.TabIndex = 0;
            this.Btn_consultar.Text = "Consultar Datos";
            this.Btn_consultar.UseVisualStyleBackColor = true;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Dgv_consultar
            // 
            this.Dgv_consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultar.Location = new System.Drawing.Point(170, 179);
            this.Dgv_consultar.Name = "Dgv_consultar";
            this.Dgv_consultar.RowHeadersWidth = 51;
            this.Dgv_consultar.RowTemplate.Height = 24;
            this.Dgv_consultar.Size = new System.Drawing.Size(723, 313);
            this.Dgv_consultar.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 527);
            this.Controls.Add(this.Dgv_consultar);
            this.Controls.Add(this.Btn_consultar);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.DataGridView Dgv_consultar;
    }
}