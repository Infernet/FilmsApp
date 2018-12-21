namespace FilmsApp.Forms.Base
{
    partial class ShowFilmForm
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
            this.lTitle = new System.Windows.Forms.Label();
            this.picturePoster = new System.Windows.Forms.PictureBox();
            this.lYear = new System.Windows.Forms.Label();
            this.lRuntime = new System.Windows.Forms.Label();
            this.lDateReleased = new System.Windows.Forms.Label();
            this.lGenre = new System.Windows.Forms.Label();
            this.lCountry = new System.Windows.Forms.Label();
            this.lDirector = new System.Windows.Forms.Label();
            this.lRated = new System.Windows.Forms.Label();
            this.lRating = new System.Windows.Forms.Label();
            this.lPlot = new System.Windows.Forms.Label();
            this.lAwards = new System.Windows.Forms.Label();
            this.lActors = new System.Windows.Forms.Label();
            this.lWriters = new System.Windows.Forms.Label();
            this.lWebSite = new System.Windows.Forms.Label();
            this.lDVD = new System.Windows.Forms.Label();
            this.lBoxOffice = new System.Windows.Forms.Label();
            this.lProduction = new System.Windows.Forms.Label();
            this.lLanguage = new System.Windows.Forms.Label();
            this.lMetascore = new System.Windows.Forms.Label();
            this.lImdbRating = new System.Windows.Forms.Label();
            this.tableLP_info = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.tableLP_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.DarkGray;
            this.lTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLP_info.SetColumnSpan(this.lTitle, 4);
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Location = new System.Drawing.Point(5, 2);
            this.lTitle.Name = "lTitle";
            this.tableLP_info.SetRowSpan(this.lTitle, 2);
            this.lTitle.Size = new System.Drawing.Size(759, 15);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Название";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picturePoster
            // 
            this.picturePoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picturePoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLP_info.SetColumnSpan(this.picturePoster, 2);
            this.picturePoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePoster.Location = new System.Drawing.Point(5, 22);
            this.picturePoster.Name = "picturePoster";
            this.tableLP_info.SetRowSpan(this.picturePoster, 2);
            this.picturePoster.Size = new System.Drawing.Size(318, 193);
            this.picturePoster.TabIndex = 1;
            this.picturePoster.TabStop = false;
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.BackColor = System.Drawing.Color.Gainsboro;
            this.lYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lYear.Location = new System.Drawing.Point(331, 137);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(125, 81);
            this.lYear.TabIndex = 2;
            this.lYear.Text = "Год :";
            this.lYear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lYear.Visible = false;
            // 
            // lRuntime
            // 
            this.lRuntime.AutoSize = true;
            this.lRuntime.BackColor = System.Drawing.Color.Gainsboro;
            this.lRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRuntime.Location = new System.Drawing.Point(5, 220);
            this.lRuntime.Name = "lRuntime";
            this.lRuntime.Size = new System.Drawing.Size(123, 28);
            this.lRuntime.TabIndex = 6;
            this.lRuntime.Text = "Длительность :";
            this.lRuntime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lDateReleased
            // 
            this.lDateReleased.AutoSize = true;
            this.lDateReleased.BackColor = System.Drawing.Color.Gainsboro;
            this.lDateReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDateReleased.Location = new System.Drawing.Point(5, 250);
            this.lDateReleased.Name = "lDateReleased";
            this.lDateReleased.Size = new System.Drawing.Size(123, 34);
            this.lDateReleased.TabIndex = 5;
            this.lDateReleased.Text = "Дата выхода :";
            this.lDateReleased.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.BackColor = System.Drawing.Color.Gainsboro;
            this.lGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lGenre.Location = new System.Drawing.Point(331, 286);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(125, 56);
            this.lGenre.TabIndex = 7;
            this.lGenre.Text = "Жанр :";
            this.lGenre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.BackColor = System.Drawing.Color.Gainsboro;
            this.lCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCountry.Location = new System.Drawing.Point(331, 488);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(125, 53);
            this.lCountry.TabIndex = 8;
            this.lCountry.Text = "Страна :";
            this.lCountry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lDirector
            // 
            this.lDirector.AutoSize = true;
            this.lDirector.BackColor = System.Drawing.Color.Gainsboro;
            this.lDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDirector.Location = new System.Drawing.Point(5, 286);
            this.lDirector.Name = "lDirector";
            this.lDirector.Size = new System.Drawing.Size(123, 56);
            this.lDirector.TabIndex = 9;
            this.lDirector.Text = "Режиссёр :";
            this.lDirector.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lRated
            // 
            this.lRated.AutoSize = true;
            this.lRated.BackColor = System.Drawing.Color.Gainsboro;
            this.lRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRated.Location = new System.Drawing.Point(331, 220);
            this.lRated.Name = "lRated";
            this.lRated.Size = new System.Drawing.Size(125, 28);
            this.lRated.TabIndex = 10;
            this.lRated.Text = "Возрастной рейтинг :";
            this.lRated.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lRating
            // 
            this.lRating.AutoSize = true;
            this.lRating.BackColor = System.Drawing.Color.Gainsboro;
            this.lRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRating.Location = new System.Drawing.Point(331, 19);
            this.lRating.Name = "lRating";
            this.lRating.Size = new System.Drawing.Size(125, 116);
            this.lRating.TabIndex = 11;
            this.lRating.Text = "Рейтинг :";
            this.lRating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lPlot
            // 
            this.lPlot.AutoSize = true;
            this.lPlot.BackColor = System.Drawing.Color.Gainsboro;
            this.lPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lPlot.Location = new System.Drawing.Point(5, 344);
            this.lPlot.Name = "lPlot";
            this.lPlot.Size = new System.Drawing.Size(123, 142);
            this.lPlot.TabIndex = 12;
            this.lPlot.Text = "Описание :";
            this.lPlot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lAwards
            // 
            this.lAwards.AutoSize = true;
            this.lAwards.BackColor = System.Drawing.Color.Gainsboro;
            this.lAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAwards.Location = new System.Drawing.Point(5, 642);
            this.lAwards.Name = "lAwards";
            this.lAwards.Size = new System.Drawing.Size(123, 44);
            this.lAwards.TabIndex = 13;
            this.lAwards.Text = "Награды :";
            this.lAwards.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lActors
            // 
            this.lActors.AutoSize = true;
            this.lActors.BackColor = System.Drawing.Color.Gainsboro;
            this.lActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lActors.Location = new System.Drawing.Point(331, 543);
            this.lActors.Name = "lActors";
            this.lActors.Size = new System.Drawing.Size(125, 45);
            this.lActors.TabIndex = 14;
            this.lActors.Text = "Актеры :";
            this.lActors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lWriters
            // 
            this.lWriters.AutoSize = true;
            this.lWriters.BackColor = System.Drawing.Color.Gainsboro;
            this.lWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWriters.Location = new System.Drawing.Point(5, 543);
            this.lWriters.Name = "lWriters";
            this.lWriters.Size = new System.Drawing.Size(123, 45);
            this.lWriters.TabIndex = 15;
            this.lWriters.Text = "Писатели :";
            this.lWriters.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lWebSite
            // 
            this.lWebSite.AutoSize = true;
            this.lWebSite.BackColor = System.Drawing.Color.Gainsboro;
            this.lWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWebSite.Location = new System.Drawing.Point(331, 590);
            this.lWebSite.Name = "lWebSite";
            this.lWebSite.Size = new System.Drawing.Size(125, 50);
            this.lWebSite.TabIndex = 16;
            this.lWebSite.Text = "Сайт :";
            this.lWebSite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lDVD
            // 
            this.lDVD.AutoSize = true;
            this.lDVD.BackColor = System.Drawing.Color.Gainsboro;
            this.lDVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDVD.Location = new System.Drawing.Point(331, 250);
            this.lDVD.Name = "lDVD";
            this.lDVD.Size = new System.Drawing.Size(125, 34);
            this.lDVD.TabIndex = 17;
            this.lDVD.Text = "Дата выхода на DVD :";
            this.lDVD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lBoxOffice
            // 
            this.lBoxOffice.AutoSize = true;
            this.lBoxOffice.BackColor = System.Drawing.Color.Gainsboro;
            this.lBoxOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxOffice.Location = new System.Drawing.Point(331, 642);
            this.lBoxOffice.Name = "lBoxOffice";
            this.lBoxOffice.Size = new System.Drawing.Size(125, 44);
            this.lBoxOffice.TabIndex = 18;
            this.lBoxOffice.Text = "Кассовые сборы :";
            this.lBoxOffice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lProduction
            // 
            this.lProduction.AutoSize = true;
            this.lProduction.BackColor = System.Drawing.Color.Gainsboro;
            this.lProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lProduction.Location = new System.Drawing.Point(5, 590);
            this.lProduction.Name = "lProduction";
            this.lProduction.Size = new System.Drawing.Size(123, 50);
            this.lProduction.TabIndex = 19;
            this.lProduction.Text = "Студия производитель :";
            this.lProduction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.BackColor = System.Drawing.Color.Gainsboro;
            this.lLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLanguage.Location = new System.Drawing.Point(5, 488);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(123, 53);
            this.lLanguage.TabIndex = 20;
            this.lLanguage.Text = "Язык :";
            this.lLanguage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lMetascore
            // 
            this.lMetascore.AutoSize = true;
            this.lMetascore.BackColor = System.Drawing.Color.Gainsboro;
            this.lMetascore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lMetascore.Location = new System.Drawing.Point(5, 688);
            this.lMetascore.Name = "lMetascore";
            this.lMetascore.Size = new System.Drawing.Size(123, 28);
            this.lMetascore.TabIndex = 21;
            this.lMetascore.Text = "Metascore :";
            this.lMetascore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lImdbRating
            // 
            this.lImdbRating.AutoSize = true;
            this.lImdbRating.BackColor = System.Drawing.Color.Gainsboro;
            this.lImdbRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lImdbRating.Location = new System.Drawing.Point(331, 688);
            this.lImdbRating.Name = "lImdbRating";
            this.lImdbRating.Size = new System.Drawing.Size(125, 28);
            this.lImdbRating.TabIndex = 22;
            this.lImdbRating.Text = "IMDB рейтинг :";
            this.lImdbRating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLP_info
            // 
            this.tableLP_info.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLP_info.ColumnCount = 4;
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.95984F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.04016F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tableLP_info.Controls.Add(this.lTitle, 0, 0);
            this.tableLP_info.Controls.Add(this.lImdbRating, 2, 12);
            this.tableLP_info.Controls.Add(this.lMetascore, 0, 12);
            this.tableLP_info.Controls.Add(this.lBoxOffice, 2, 11);
            this.tableLP_info.Controls.Add(this.lAwards, 0, 11);
            this.tableLP_info.Controls.Add(this.lWebSite, 2, 10);
            this.tableLP_info.Controls.Add(this.lProduction, 0, 10);
            this.tableLP_info.Controls.Add(this.picturePoster, 0, 2);
            this.tableLP_info.Controls.Add(this.lRuntime, 0, 4);
            this.tableLP_info.Controls.Add(this.lDateReleased, 0, 5);
            this.tableLP_info.Controls.Add(this.lDVD, 2, 5);
            this.tableLP_info.Controls.Add(this.lActors, 2, 9);
            this.tableLP_info.Controls.Add(this.lWriters, 0, 9);
            this.tableLP_info.Controls.Add(this.lRated, 2, 4);
            this.tableLP_info.Controls.Add(this.lDirector, 0, 6);
            this.tableLP_info.Controls.Add(this.lGenre, 2, 6);
            this.tableLP_info.Controls.Add(this.lPlot, 0, 7);
            this.tableLP_info.Controls.Add(this.lLanguage, 0, 8);
            this.tableLP_info.Controls.Add(this.lCountry, 2, 8);
            this.tableLP_info.Controls.Add(this.dataGridView1, 1, 9);
            this.tableLP_info.Controls.Add(this.dataGridView2, 3, 9);
            this.tableLP_info.Controls.Add(this.groupBox1, 0, 13);
            this.tableLP_info.Controls.Add(this.lRating, 2, 2);
            this.tableLP_info.Controls.Add(this.lYear, 2, 3);
            this.tableLP_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_info.Location = new System.Drawing.Point(0, 0);
            this.tableLP_info.Name = "tableLP_info";
            this.tableLP_info.RowCount = 14;
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.9214F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.0786F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLP_info.Size = new System.Drawing.Size(769, 758);
            this.tableLP_info.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(136, 546);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(187, 39);
            this.dataGridView1.TabIndex = 23;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(464, 546);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(300, 39);
            this.dataGridView2.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.tableLP_info.SetColumnSpan(this.groupBox1, 4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 721);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 32);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // ShowFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(769, 758);
            this.Controls.Add(this.tableLP_info);
            this.Name = "ShowFilmForm";
            this.Text = "ShowFilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.tableLP_info.ResumeLayout(false);
            this.tableLP_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox picturePoster;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.TableLayoutPanel tableLP_info;
        private System.Windows.Forms.Label lRuntime;
        private System.Windows.Forms.Label lDateReleased;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.Label lCountry;
        private System.Windows.Forms.Label lDirector;
        private System.Windows.Forms.Label lRated;
        private System.Windows.Forms.Label lRating;
        private System.Windows.Forms.Label lPlot;
        private System.Windows.Forms.Label lAwards;
        private System.Windows.Forms.Label lActors;
        private System.Windows.Forms.Label lWriters;
        private System.Windows.Forms.Label lWebSite;
        private System.Windows.Forms.Label lDVD;
        private System.Windows.Forms.Label lBoxOffice;
        private System.Windows.Forms.Label lProduction;
        private System.Windows.Forms.Label lLanguage;
        private System.Windows.Forms.Label lMetascore;
        private System.Windows.Forms.Label lImdbRating;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}