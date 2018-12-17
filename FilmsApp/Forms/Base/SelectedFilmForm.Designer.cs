namespace FilmsApp.Forms.Base
{
    partial class SelectedFilmForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet = new FilmsApp.MovieDBDataSet();
            this.viewPersonInMovieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPersonInMovieTableAdapter = new FilmsApp.MovieDBDataSetTableAdapters.ViewPersonInMovieTableAdapter();
            this.названиеФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЧеловекаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDРолиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPersonInMovieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеФильмаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn,
            this.iDФильмаDataGridViewTextBoxColumn,
            this.iDЧеловекаDataGridViewTextBoxColumn,
            this.iDРолиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewPersonInMovieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // movieDBDataSetBindingSource
            // 
            this.movieDBDataSetBindingSource.DataSource = this.movieDBDataSet;
            this.movieDBDataSetBindingSource.Position = 0;
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPersonInMovieBindingSource
            // 
            this.viewPersonInMovieBindingSource.DataMember = "ViewPersonInMovie";
            this.viewPersonInMovieBindingSource.DataSource = this.movieDBDataSetBindingSource;
            // 
            // viewPersonInMovieTableAdapter
            // 
            this.viewPersonInMovieTableAdapter.ClearBeforeFill = true;
            // 
            // названиеФильмаDataGridViewTextBoxColumn
            // 
            this.названиеФильмаDataGridViewTextBoxColumn.DataPropertyName = "Название фильма";
            this.названиеФильмаDataGridViewTextBoxColumn.HeaderText = "Название фильма";
            this.названиеФильмаDataGridViewTextBoxColumn.Name = "названиеФильмаDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            // 
            // iDФильмаDataGridViewTextBoxColumn
            // 
            this.iDФильмаDataGridViewTextBoxColumn.DataPropertyName = "ID фильма";
            this.iDФильмаDataGridViewTextBoxColumn.HeaderText = "ID фильма";
            this.iDФильмаDataGridViewTextBoxColumn.Name = "iDФильмаDataGridViewTextBoxColumn";
            // 
            // iDЧеловекаDataGridViewTextBoxColumn
            // 
            this.iDЧеловекаDataGridViewTextBoxColumn.DataPropertyName = "ID человека";
            this.iDЧеловекаDataGridViewTextBoxColumn.HeaderText = "ID человека";
            this.iDЧеловекаDataGridViewTextBoxColumn.Name = "iDЧеловекаDataGridViewTextBoxColumn";
            // 
            // iDРолиDataGridViewTextBoxColumn
            // 
            this.iDРолиDataGridViewTextBoxColumn.DataPropertyName = "ID роли";
            this.iDРолиDataGridViewTextBoxColumn.HeaderText = "ID роли";
            this.iDРолиDataGridViewTextBoxColumn.Name = "iDРолиDataGridViewTextBoxColumn";
            // 
            // SelectedFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelectedFilmForm";
            this.Text = "SelectedFilmForm";
            this.Load += new System.EventHandler(this.SelectedFilmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPersonInMovieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource movieDBDataSetBindingSource;
        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource viewPersonInMovieBindingSource;
        private MovieDBDataSetTableAdapters.ViewPersonInMovieTableAdapter viewPersonInMovieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеФильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЧеловекаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРолиDataGridViewTextBoxColumn;
    }
}