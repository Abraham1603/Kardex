namespace UX1
{
    partial class CarreraMateria
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
            this.btnCarreraMateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARRERA MATERIA";
            // 
            // btnCarreraMateria
            // 
            this.btnCarreraMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCarreraMateria.FlatAppearance.BorderSize = 0;
            this.btnCarreraMateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCarreraMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCarreraMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarreraMateria.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCarreraMateria.Location = new System.Drawing.Point(288, 361);
            this.btnCarreraMateria.Name = "btnCarreraMateria";
            this.btnCarreraMateria.Size = new System.Drawing.Size(238, 68);
            this.btnCarreraMateria.TabIndex = 9;
            this.btnCarreraMateria.Text = "Carrera Materia";
            this.btnCarreraMateria.UseVisualStyleBackColor = false;
            // 
            // CarreraMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarreraMateria);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarreraMateria";
            this.Text = "CarreraMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarreraMateria;
    }
}