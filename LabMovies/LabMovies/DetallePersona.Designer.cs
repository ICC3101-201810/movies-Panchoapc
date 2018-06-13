namespace LabMovies
{
    partial class DetallePersona
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.label_Birth = new System.Windows.Forms.Label();
            this.label_Biography = new System.Windows.Forms.Label();
            this.listView_Movies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(39, 49);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(81, 31);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "name";
            // 
            // label_Lastname
            // 
            this.label_Lastname.AutoSize = true;
            this.label_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lastname.Location = new System.Drawing.Point(135, 49);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(124, 31);
            this.label_Lastname.TabIndex = 1;
            this.label_Lastname.Text = "lastname";
            // 
            // label_Birth
            // 
            this.label_Birth.AutoSize = true;
            this.label_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Birth.Location = new System.Drawing.Point(39, 123);
            this.label_Birth.Name = "label_Birth";
            this.label_Birth.Size = new System.Drawing.Size(120, 31);
            this.label_Birth.TabIndex = 2;
            this.label_Birth.Text = "birthdate";
            // 
            // label_Biography
            // 
            this.label_Biography.AutoSize = true;
            this.label_Biography.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Biography.Location = new System.Drawing.Point(39, 199);
            this.label_Biography.Name = "label_Biography";
            this.label_Biography.Size = new System.Drawing.Size(50, 31);
            this.label_Biography.TabIndex = 4;
            this.label_Biography.Text = "bio";
            // 
            // listView_Movies
            // 
            this.listView_Movies.BackColor = System.Drawing.SystemColors.Menu;
            this.listView_Movies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Movies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_Movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Movies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Movies.Location = new System.Drawing.Point(45, 300);
            this.listView_Movies.Margin = new System.Windows.Forms.Padding(0);
            this.listView_Movies.Name = "listView_Movies";
            this.listView_Movies.Size = new System.Drawing.Size(524, 189);
            this.listView_Movies.TabIndex = 6;
            this.listView_Movies.UseCompatibleStateImageBehavior = false;
            this.listView_Movies.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 120;
            // 
            // DetallePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 512);
            this.Controls.Add(this.listView_Movies);
            this.Controls.Add(this.label_Biography);
            this.Controls.Add(this.label_Birth);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.label_Name);
            this.Name = "DetallePersona";
            this.Text = "DetallePersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.Label label_Birth;
        private System.Windows.Forms.Label label_Biography;
        private System.Windows.Forms.ListView listView_Movies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}