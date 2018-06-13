namespace LabMovies
{
    partial class Buscador
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
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Peliculas = new System.Windows.Forms.Button();
            this.button_Actores = new System.Windows.Forms.Button();
            this.button_Directores = new System.Windows.Forms.Button();
            this.button_Productores = new System.Windows.Forms.Button();
            this.button_estudios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(237, 146);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(604, 36);
            this.textBox_Search.TabIndex = 0;
            // 
            // button_Peliculas
            // 
            this.button_Peliculas.Location = new System.Drawing.Point(99, 220);
            this.button_Peliculas.Name = "button_Peliculas";
            this.button_Peliculas.Size = new System.Drawing.Size(143, 46);
            this.button_Peliculas.TabIndex = 1;
            this.button_Peliculas.Text = "Peliculas";
            this.button_Peliculas.UseVisualStyleBackColor = true;
            this.button_Peliculas.Click += new System.EventHandler(this.button_Peliculas_Click);
            // 
            // button_Actores
            // 
            this.button_Actores.Location = new System.Drawing.Point(270, 220);
            this.button_Actores.Name = "button_Actores";
            this.button_Actores.Size = new System.Drawing.Size(143, 46);
            this.button_Actores.TabIndex = 2;
            this.button_Actores.Text = "Actores";
            this.button_Actores.UseVisualStyleBackColor = true;
            this.button_Actores.Click += new System.EventHandler(this.button_Actores_Click);
            // 
            // button_Directores
            // 
            this.button_Directores.Location = new System.Drawing.Point(437, 220);
            this.button_Directores.Name = "button_Directores";
            this.button_Directores.Size = new System.Drawing.Size(143, 46);
            this.button_Directores.TabIndex = 3;
            this.button_Directores.Text = "Directores";
            this.button_Directores.UseVisualStyleBackColor = true;
            this.button_Directores.Click += new System.EventHandler(this.button_Directores_Click);
            // 
            // button_Productores
            // 
            this.button_Productores.Location = new System.Drawing.Point(603, 220);
            this.button_Productores.Name = "button_Productores";
            this.button_Productores.Size = new System.Drawing.Size(143, 46);
            this.button_Productores.TabIndex = 4;
            this.button_Productores.Text = "Productores";
            this.button_Productores.UseVisualStyleBackColor = true;
            this.button_Productores.Click += new System.EventHandler(this.button_Productores_Click);
            // 
            // button_estudios
            // 
            this.button_estudios.Location = new System.Drawing.Point(770, 220);
            this.button_estudios.Name = "button_estudios";
            this.button_estudios.Size = new System.Drawing.Size(143, 46);
            this.button_estudios.TabIndex = 5;
            this.button_estudios.Text = "Estudios";
            this.button_estudios.UseVisualStyleBackColor = true;
            this.button_estudios.Click += new System.EventHandler(this.button_estudios_Click);
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 362);
            this.Controls.Add(this.button_estudios);
            this.Controls.Add(this.button_Productores);
            this.Controls.Add(this.button_Directores);
            this.Controls.Add(this.button_Actores);
            this.Controls.Add(this.button_Peliculas);
            this.Controls.Add(this.textBox_Search);
            this.Name = "Buscador";
            this.Text = "Buscador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Peliculas;
        private System.Windows.Forms.Button button_Actores;
        private System.Windows.Forms.Button button_Directores;
        private System.Windows.Forms.Button button_Productores;
        private System.Windows.Forms.Button button_estudios;
    }
}