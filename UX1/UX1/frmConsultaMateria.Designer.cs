namespace UX1
{
    partial class frmConsultaMateria
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
            this.cbTodas = new System.Windows.Forms.CheckBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.gbCarrera = new System.Windows.Forms.GroupBox();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Location = new System.Drawing.Point(432, 38);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(70, 21);
            this.cbTodas.TabIndex = 5;
            this.cbTodas.Text = "Todas";
            this.cbTodas.UseVisualStyleBackColor = true;
            this.cbTodas.CheckedChanged += new System.EventHandler(this.CbTodas_CheckedChanged);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(519, 38);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(93, 23);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "&Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // gbCarrera
            // 
            this.gbCarrera.Controls.Add(this.dgvCarrera);
            this.gbCarrera.Location = new System.Drawing.Point(31, 66);
            this.gbCarrera.Name = "gbCarrera";
            this.gbCarrera.Size = new System.Drawing.Size(593, 381);
            this.gbCarrera.TabIndex = 7;
            this.gbCarrera.TabStop = false;
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrera.Location = new System.Drawing.Point(4, 0);
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.RowTemplate.Height = 24;
            this.dgvCarrera.Size = new System.Drawing.Size(577, 366);
            this.dgvCarrera.TabIndex = 0;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(92, 38);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(313, 22);
            this.txtMateria.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Materia: ";
            // 
            // frmConsultaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 485);
            this.Controls.Add(this.cbTodas);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.gbCarrera);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaMateria";
            this.Text = "frmConsultaMateria";
            this.gbCarrera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTodas;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.GroupBox gbCarrera;
        public System.Windows.Forms.DataGridView dgvCarrera;
        public System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label1;
    }
}