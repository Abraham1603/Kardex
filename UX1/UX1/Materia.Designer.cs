namespace UX1
{
    partial class Materia
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.btnModificacionMateria = new System.Windows.Forms.Button();
            this.btnConsultaMateria = new System.Windows.Forms.Button();
            this.btnBajaMateria = new System.Windows.Forms.Button();
            this.btnAltaMateria = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(478, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Materia";
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCerrar.Location = new System.Drawing.Point(1028, 11);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(20, 20);
            this.lblCerrar.TabIndex = 4;
            this.lblCerrar.Text = "X";
            // 
            // btnModificacionMateria
            // 
            this.btnModificacionMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnModificacionMateria.FlatAppearance.BorderSize = 0;
            this.btnModificacionMateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificacionMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnModificacionMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificacionMateria.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnModificacionMateria.ForeColor = System.Drawing.Color.White;
            this.btnModificacionMateria.Location = new System.Drawing.Point(926, 447);
            this.btnModificacionMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificacionMateria.Name = "btnModificacionMateria";
            this.btnModificacionMateria.Size = new System.Drawing.Size(106, 94);
            this.btnModificacionMateria.TabIndex = 9;
            this.btnModificacionMateria.Text = "Modificacion";
            this.btnModificacionMateria.UseVisualStyleBackColor = false;
            this.btnModificacionMateria.Click += new System.EventHandler(this.BtnModificacionMateria_Click);
            // 
            // btnConsultaMateria
            // 
            this.btnConsultaMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultaMateria.FlatAppearance.BorderSize = 0;
            this.btnConsultaMateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConsultaMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaMateria.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnConsultaMateria.ForeColor = System.Drawing.Color.White;
            this.btnConsultaMateria.Location = new System.Drawing.Point(34, 435);
            this.btnConsultaMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaMateria.Name = "btnConsultaMateria";
            this.btnConsultaMateria.Size = new System.Drawing.Size(96, 89);
            this.btnConsultaMateria.TabIndex = 8;
            this.btnConsultaMateria.Text = "Consulta";
            this.btnConsultaMateria.UseVisualStyleBackColor = false;
            this.btnConsultaMateria.Click += new System.EventHandler(this.BtnConsultaMateria_Click);
            // 
            // btnBajaMateria
            // 
            this.btnBajaMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBajaMateria.FlatAppearance.BorderSize = 0;
            this.btnBajaMateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBajaMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBajaMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaMateria.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnBajaMateria.ForeColor = System.Drawing.Color.White;
            this.btnBajaMateria.Location = new System.Drawing.Point(956, 11);
            this.btnBajaMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnBajaMateria.Name = "btnBajaMateria";
            this.btnBajaMateria.Size = new System.Drawing.Size(92, 74);
            this.btnBajaMateria.TabIndex = 7;
            this.btnBajaMateria.Text = "Baja";
            this.btnBajaMateria.UseVisualStyleBackColor = false;
            this.btnBajaMateria.Click += new System.EventHandler(this.BtnBajaMateria_Click);
            // 
            // btnAltaMateria
            // 
            this.btnAltaMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAltaMateria.FlatAppearance.BorderSize = 0;
            this.btnAltaMateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAltaMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAltaMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaMateria.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAltaMateria.ForeColor = System.Drawing.Color.White;
            this.btnAltaMateria.Location = new System.Drawing.Point(13, 8);
            this.btnAltaMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltaMateria.Name = "btnAltaMateria";
            this.btnAltaMateria.Size = new System.Drawing.Size(91, 69);
            this.btnAltaMateria.TabIndex = 6;
            this.btnAltaMateria.Text = "Alta";
            this.btnAltaMateria.UseVisualStyleBackColor = false;
            this.btnAltaMateria.Click += new System.EventHandler(this.BtnAltaMateria_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelContenedor.Location = new System.Drawing.Point(173, 73);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(719, 468);
            this.PanelContenedor.TabIndex = 10;
            // 
            // Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.btnModificacionMateria);
            this.Controls.Add(this.btnConsultaMateria);
            this.Controls.Add(this.btnBajaMateria);
            this.Controls.Add(this.btnAltaMateria);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Materia";
            this.Text = "Materia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Button btnModificacionMateria;
        private System.Windows.Forms.Button btnConsultaMateria;
        private System.Windows.Forms.Button btnBajaMateria;
        private System.Windows.Forms.Button btnAltaMateria;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}