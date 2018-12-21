﻿
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PosterImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.FilmIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posterData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длительностьминDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.режиссёрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтинг10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet = new FilmsApp.MovieDBDataSet();
            this.vMoviesTableAdapter = new FilmsApp.MovieDBDataSetTableAdapters.vMoviesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFilmAdd = new System.Windows.Forms.Button();
            this.buttonShowMovie = new System.Windows.Forms.Button();
            this.buttonSelectFilther = new System.Windows.Forms.Button();
            this.buttonShowSelectedFilm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMoviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PosterImage,
            this.FilmIdColumn,
            this.posterData,
            this.названиеDataGridViewTextBoxColumn,
            this.годВыходаDataGridViewTextBoxColumn,
            this.языкDataGridViewTextBoxColumn,
            this.длительностьминDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.режиссёрDataGridViewTextBoxColumn,
            this.рейтинг10DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.vMoviesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 672);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // PosterImage
            // 
            this.PosterImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PosterImage.FillWeight = 182F;
            this.PosterImage.HeaderText = "Постер";
            this.PosterImage.MinimumWidth = 182;
            this.PosterImage.Name = "PosterImage";
            this.PosterImage.ReadOnly = true;
            this.PosterImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PosterImage.Width = 182;
            // 
            // FilmIdColumn
            // 
            this.FilmIdColumn.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FilmIdColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.FilmIdColumn.HeaderText = "ID";
            this.FilmIdColumn.Name = "FilmIdColumn";
            this.FilmIdColumn.ReadOnly = true;
            this.FilmIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FilmIdColumn.Visible = false;
            // 
            // posterData
            // 
            this.posterData.DataPropertyName = "Poster";
            this.posterData.HeaderText = "Poster";
            this.posterData.Name = "posterData";
            this.posterData.ReadOnly = true;
            this.posterData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.posterData.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.FillWeight = 22.84264F;
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // годВыходаDataGridViewTextBoxColumn
            // 
            this.годВыходаDataGridViewTextBoxColumn.DataPropertyName = "Год выхода";
            this.годВыходаDataGridViewTextBoxColumn.FillWeight = 22.84264F;
            this.годВыходаDataGridViewTextBoxColumn.HeaderText = "Год выхода";
            this.годВыходаDataGridViewTextBoxColumn.Name = "годВыходаDataGridViewTextBoxColumn";
            this.годВыходаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // языкDataGridViewTextBoxColumn
            // 
            this.языкDataGridViewTextBoxColumn.DataPropertyName = "Язык";
            this.языкDataGridViewTextBoxColumn.FillWeight = 22.84264F;
            this.языкDataGridViewTextBoxColumn.HeaderText = "Язык";
            this.языкDataGridViewTextBoxColumn.Name = "языкDataGridViewTextBoxColumn";
            this.языкDataGridViewTextBoxColumn.ReadOnly = true;
            this.языкDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // длительностьминDataGridViewTextBoxColumn
            // 
            this.длительностьминDataGridViewTextBoxColumn.DataPropertyName = "Длительность (мин)";
            this.длительностьминDataGridViewTextBoxColumn.FillWeight = 22.84264F;
            this.длительностьминDataGridViewTextBoxColumn.HeaderText = "Длительность (мин)";
            this.длительностьминDataGridViewTextBoxColumn.Name = "длительностьминDataGridViewTextBoxColumn";
            this.длительностьминDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.FillWeight = 22.84264F;
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.ReadOnly = true;
            this.жанрDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.FillWeight = 22.84264F;
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            this.странаDataGridViewTextBoxColumn.ReadOnly = true;
            this.странаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // режиссёрDataGridViewTextBoxColumn
            // 
            this.режиссёрDataGridViewTextBoxColumn.DataPropertyName = "Режиссёр";
            this.режиссёрDataGridViewTextBoxColumn.FillWeight = 22.84264F;
            this.режиссёрDataGridViewTextBoxColumn.HeaderText = "Режиссёр";
            this.режиссёрDataGridViewTextBoxColumn.Name = "режиссёрDataGridViewTextBoxColumn";
            this.режиссёрDataGridViewTextBoxColumn.ReadOnly = true;
            this.режиссёрDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // рейтинг10DataGridViewTextBoxColumn
            // 
            this.рейтинг10DataGridViewTextBoxColumn.DataPropertyName = "Рейтинг /10";
            this.рейтинг10DataGridViewTextBoxColumn.FillWeight = 22.84264F;
            this.рейтинг10DataGridViewTextBoxColumn.HeaderText = "Рейтинг /10";
            this.рейтинг10DataGridViewTextBoxColumn.Name = "рейтинг10DataGridViewTextBoxColumn";
            this.рейтинг10DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vMoviesBindingSource
            // 
            this.vMoviesBindingSource.DataMember = "vMovies";
            this.vMoviesBindingSource.DataSource = this.movieDBDataSet;
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vMoviesTableAdapter
            // 
            this.vMoviesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonShowSelectedFilm);
            this.groupBox1.Controls.Add(this.buttonFilmAdd);
            this.groupBox1.Controls.Add(this.buttonShowMovie);
            this.groupBox1.Controls.Add(this.buttonSelectFilther);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 572);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonFilmAdd
            // 
            this.buttonFilmAdd.Location = new System.Drawing.Point(767, 44);
            this.buttonFilmAdd.Name = "buttonFilmAdd";
            this.buttonFilmAdd.Size = new System.Drawing.Size(160, 23);
            this.buttonFilmAdd.TabIndex = 2;
            this.buttonFilmAdd.Text = "Добавление фильма в базу";
            this.buttonFilmAdd.UseVisualStyleBackColor = true;
            // 
            // buttonShowMovie
            // 
            this.buttonShowMovie.Location = new System.Drawing.Point(363, 45);
            this.buttonShowMovie.Name = "buttonShowMovie";
            this.buttonShowMovie.Size = new System.Drawing.Size(138, 23);
            this.buttonShowMovie.TabIndex = 1;
            this.buttonShowMovie.Text = "Подробнее о фильме";
            this.buttonShowMovie.UseVisualStyleBackColor = true;
            // 
            // buttonSelectFilther
            // 
            this.buttonSelectFilther.Location = new System.Drawing.Point(587, 45);
            this.buttonSelectFilther.Name = "buttonSelectFilther";
            this.buttonSelectFilther.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFilther.TabIndex = 0;
            this.buttonSelectFilther.Text = "Фильтр";
            this.buttonSelectFilther.UseVisualStyleBackColor = true;
            this.buttonSelectFilther.Click += new System.EventHandler(this.buttonSelectFilther_Click);
            // 
            // buttonShowSelectedFilm
            // 
            this.buttonShowSelectedFilm.Location = new System.Drawing.Point(142, 33);
            this.buttonShowSelectedFilm.Name = "buttonShowSelectedFilm";
            this.buttonShowSelectedFilm.Size = new System.Drawing.Size(80, 45);
            this.buttonShowSelectedFilm.TabIndex = 3;
            this.buttonShowSelectedFilm.Text = "Подробнее о фильме";
            this.buttonShowSelectedFilm.UseVisualStyleBackColor = true;
            this.buttonShowSelectedFilm.Click += new System.EventHandler(this.buttonShowSelectedFilm_Click);
            // 
            // SelectedFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1221, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelectedFilmForm";
            this.Load += new System.EventHandler(this.SelectedFilmForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMoviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource vMoviesBindingSource;
        private MovieDBDataSetTableAdapters.vMoviesTableAdapter vMoviesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFilmAdd;
        private System.Windows.Forms.Button buttonShowMovie;
        private System.Windows.Forms.Button buttonSelectFilther;
        private System.Windows.Forms.DataGridViewImageColumn PosterImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posterData;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыходаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длительностьминDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn режиссёрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейтинг10DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonShowSelectedFilm;
    }
}