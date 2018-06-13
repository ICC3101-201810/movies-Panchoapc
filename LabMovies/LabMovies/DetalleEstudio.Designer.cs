namespace LabMovies
{
    partial class DetalleEstudio
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label_Name = new System.Windows.Forms.Label();
            this.label_NameD = new System.Windows.Forms.Label();
            this.label_FechaA = new System.Windows.Forms.Label();
            this.label_bdateD = new System.Windows.Forms.Label();
            this.label_BioD = new System.Windows.Forms.Label();
            this.listView_Movies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(88, 33);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(81, 31);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "name";
            // 
            // label_NameD
            // 
            this.label_NameD.AutoSize = true;
            this.label_NameD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameD.Location = new System.Drawing.Point(88, 171);
            this.label_NameD.Name = "label_NameD";
            this.label_NameD.Size = new System.Drawing.Size(81, 31);
            this.label_NameD.TabIndex = 2;
            this.label_NameD.Text = "name";
            // 
            // label_FechaA
            // 
            this.label_FechaA.AutoSize = true;
            this.label_FechaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FechaA.Location = new System.Drawing.Point(88, 97);
            this.label_FechaA.Name = "label_FechaA";
            this.label_FechaA.Size = new System.Drawing.Size(67, 31);
            this.label_FechaA.TabIndex = 3;
            this.label_FechaA.Text = "date";
            // 
            // label_bdateD
            // 
            this.label_bdateD.AutoSize = true;
            this.label_bdateD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bdateD.Location = new System.Drawing.Point(132, 219);
            this.label_bdateD.Name = "label_bdateD";
            this.label_bdateD.Size = new System.Drawing.Size(66, 26);
            this.label_bdateD.TabIndex = 4;
            this.label_bdateD.Text = "bdate";
            // 
            // label_BioD
            // 
            this.label_BioD.AutoSize = true;
            this.label_BioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BioD.Location = new System.Drawing.Point(132, 258);
            this.label_BioD.Name = "label_BioD";
            this.label_BioD.Size = new System.Drawing.Size(41, 26);
            this.label_BioD.TabIndex = 5;
            this.label_BioD.Text = "bio";
            // 
            // listView_Movies
            // 
            this.listView_Movies.BackColor = System.Drawing.SystemColors.Menu;
            this.listView_Movies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Movies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_Movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView_Movies.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView_Movies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Movies.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_Movies.Location = new System.Drawing.Point(23, 300);
            this.listView_Movies.Margin = new System.Windows.Forms.Padding(0);
            this.listView_Movies.Name = "listView_Movies";
            this.listView_Movies.Size = new System.Drawing.Size(568, 165);
            this.listView_Movies.TabIndex = 7;
            this.listView_Movies.UseCompatibleStateImageBehavior = false;
            this.listView_Movies.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 120;
            // 
            // DetalleEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 474);
            this.Controls.Add(this.listView_Movies);
            this.Controls.Add(this.label_BioD);
            this.Controls.Add(this.label_bdateD);
            this.Controls.Add(this.label_FechaA);
            this.Controls.Add(this.label_NameD);
            this.Controls.Add(this.label_Name);
            this.Name = "DetalleEstudio";
            this.Text = "DetalleEstudio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_NameD;
        private System.Windows.Forms.Label label_FechaA;
        private System.Windows.Forms.Label label_bdateD;
        private System.Windows.Forms.Label label_BioD;
        private System.Windows.Forms.ListView listView_Movies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}