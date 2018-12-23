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
            this.lImdbVotes = new System.Windows.Forms.Label();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.tbReleased = new System.Windows.Forms.TextBox();
            this.tbRuntime = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbRated = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbImdbRated = new System.Windows.Forms.TextBox();
            this.tbImdbVotes = new System.Windows.Forms.TextBox();
            this.tbProduction = new System.Windows.Forms.TextBox();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.tbWriters = new System.Windows.Forms.TextBox();
            this.tbMetaScore = new System.Windows.Forms.TextBox();
            this.tbPlot = new System.Windows.Forms.TextBox();
            this.tbWebSite = new System.Windows.Forms.TextBox();
            this.tbBoxOffice = new System.Windows.Forms.TextBox();
            this.tbAwards = new System.Windows.Forms.TextBox();
            this.tbDVD = new System.Windows.Forms.TextBox();
            this.tbYearReleased = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.tableLP_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.DarkGray;
            this.lTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLP_info.SetColumnSpan(this.lTitle, 2);
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.Location = new System.Drawing.Point(5, 353);
            this.lTitle.Margin = new System.Windows.Forms.Padding(5);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(406, 82);
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
            this.picturePoster.Location = new System.Drawing.Point(3, 3);
            this.picturePoster.Name = "picturePoster";
            this.tableLP_info.SetRowSpan(this.picturePoster, 2);
            this.picturePoster.Size = new System.Drawing.Size(410, 342);
            this.picturePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePoster.TabIndex = 1;
            this.picturePoster.TabStop = false;
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.BackColor = System.Drawing.Color.Gainsboro;
            this.lYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lYear.Location = new System.Drawing.Point(419, 598);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(135, 33);
            this.lYear.TabIndex = 2;
            this.lYear.Text = "Год :";
            this.lYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lYear.Visible = false;
            // 
            // lRuntime
            // 
            this.lRuntime.AutoSize = true;
            this.lRuntime.BackColor = System.Drawing.Color.Gainsboro;
            this.lRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRuntime.Location = new System.Drawing.Point(3, 502);
            this.lRuntime.Name = "lRuntime";
            this.lRuntime.Size = new System.Drawing.Size(157, 34);
            this.lRuntime.TabIndex = 6;
            this.lRuntime.Text = "Длительность :";
            this.lRuntime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lDateReleased
            // 
            this.lDateReleased.AutoSize = true;
            this.lDateReleased.BackColor = System.Drawing.Color.Gainsboro;
            this.lDateReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDateReleased.Location = new System.Drawing.Point(3, 472);
            this.lDateReleased.Name = "lDateReleased";
            this.lDateReleased.Size = new System.Drawing.Size(157, 30);
            this.lDateReleased.TabIndex = 5;
            this.lDateReleased.Text = "Дата выхода :";
            this.lDateReleased.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.BackColor = System.Drawing.Color.Gainsboro;
            this.lGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lGenre.Location = new System.Drawing.Point(3, 536);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(157, 62);
            this.lGenre.TabIndex = 7;
            this.lGenre.Text = "Жанр :";
            this.lGenre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.BackColor = System.Drawing.Color.Gainsboro;
            this.lCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCountry.Location = new System.Drawing.Point(3, 740);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(157, 58);
            this.lCountry.TabIndex = 8;
            this.lCountry.Text = "Страна :";
            this.lCountry.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lDirector
            // 
            this.lDirector.AutoSize = true;
            this.lDirector.BackColor = System.Drawing.Color.Gainsboro;
            this.lDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDirector.Location = new System.Drawing.Point(3, 631);
            this.lDirector.Name = "lDirector";
            this.lDirector.Size = new System.Drawing.Size(157, 70);
            this.lDirector.TabIndex = 9;
            this.lDirector.Text = "Режиссёр :";
            this.lDirector.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lRated
            // 
            this.lRated.AutoSize = true;
            this.lRated.BackColor = System.Drawing.Color.Gainsboro;
            this.lRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRated.Location = new System.Drawing.Point(3, 598);
            this.lRated.Name = "lRated";
            this.lRated.Size = new System.Drawing.Size(157, 33);
            this.lRated.TabIndex = 10;
            this.lRated.Text = "Возрастной рейтинг :";
            this.lRated.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lRating
            // 
            this.lRating.AutoSize = true;
            this.lRating.BackColor = System.Drawing.Color.Gainsboro;
            this.lRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRating.Location = new System.Drawing.Point(3, 440);
            this.lRating.Name = "lRating";
            this.lRating.Size = new System.Drawing.Size(157, 32);
            this.lRating.TabIndex = 11;
            this.lRating.Text = "Рейтинг :";
            this.lRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lPlot
            // 
            this.lPlot.AutoSize = true;
            this.lPlot.BackColor = System.Drawing.Color.Gainsboro;
            this.lPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lPlot.Location = new System.Drawing.Point(419, 0);
            this.lPlot.Name = "lPlot";
            this.lPlot.Size = new System.Drawing.Size(135, 143);
            this.lPlot.TabIndex = 12;
            this.lPlot.Text = "Описание :";
            this.lPlot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lAwards
            // 
            this.lAwards.AutoSize = true;
            this.lAwards.BackColor = System.Drawing.Color.Gainsboro;
            this.lAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAwards.Location = new System.Drawing.Point(419, 740);
            this.lAwards.Name = "lAwards";
            this.lAwards.Size = new System.Drawing.Size(135, 58);
            this.lAwards.TabIndex = 13;
            this.lAwards.Text = "Награды :";
            this.lAwards.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lAwards.Visible = false;
            // 
            // lActors
            // 
            this.lActors.AutoSize = true;
            this.lActors.BackColor = System.Drawing.Color.Gainsboro;
            this.lActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lActors.Location = new System.Drawing.Point(419, 143);
            this.lActors.Name = "lActors";
            this.tableLP_info.SetRowSpan(this.lActors, 2);
            this.lActors.Size = new System.Drawing.Size(135, 297);
            this.lActors.TabIndex = 14;
            this.lActors.Text = "Актеры :";
            this.lActors.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lActors.Visible = false;
            // 
            // lWriters
            // 
            this.lWriters.AutoSize = true;
            this.lWriters.BackColor = System.Drawing.Color.Gainsboro;
            this.lWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWriters.Location = new System.Drawing.Point(419, 440);
            this.lWriters.Name = "lWriters";
            this.tableLP_info.SetRowSpan(this.lWriters, 3);
            this.lWriters.Size = new System.Drawing.Size(135, 96);
            this.lWriters.TabIndex = 15;
            this.lWriters.Text = "Сценарий :";
            this.lWriters.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lWriters.Visible = false;
            // 
            // lWebSite
            // 
            this.lWebSite.AutoSize = true;
            this.lWebSite.BackColor = System.Drawing.Color.Gainsboro;
            this.lWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWebSite.Location = new System.Drawing.Point(419, 536);
            this.lWebSite.Name = "lWebSite";
            this.lWebSite.Size = new System.Drawing.Size(135, 62);
            this.lWebSite.TabIndex = 16;
            this.lWebSite.Text = "Сайт :";
            this.lWebSite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lWebSite.Visible = false;
            // 
            // lDVD
            // 
            this.lDVD.AutoSize = true;
            this.lDVD.BackColor = System.Drawing.Color.Gainsboro;
            this.lDVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDVD.Location = new System.Drawing.Point(419, 701);
            this.lDVD.Name = "lDVD";
            this.lDVD.Size = new System.Drawing.Size(135, 39);
            this.lDVD.TabIndex = 17;
            this.lDVD.Text = "Дата выхода на DVD :";
            this.lDVD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lDVD.Visible = false;
            // 
            // lBoxOffice
            // 
            this.lBoxOffice.AutoSize = true;
            this.lBoxOffice.BackColor = System.Drawing.Color.Gainsboro;
            this.lBoxOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxOffice.Location = new System.Drawing.Point(419, 798);
            this.lBoxOffice.Name = "lBoxOffice";
            this.lBoxOffice.Size = new System.Drawing.Size(135, 34);
            this.lBoxOffice.TabIndex = 18;
            this.lBoxOffice.Text = "Кассовые сборы :";
            this.lBoxOffice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lBoxOffice.Visible = false;
            // 
            // lProduction
            // 
            this.lProduction.AutoSize = true;
            this.lProduction.BackColor = System.Drawing.Color.Gainsboro;
            this.lProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lProduction.Location = new System.Drawing.Point(419, 631);
            this.lProduction.Name = "lProduction";
            this.lProduction.Size = new System.Drawing.Size(135, 70);
            this.lProduction.TabIndex = 19;
            this.lProduction.Text = "Студия производитель :";
            this.lProduction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lProduction.Visible = false;
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.BackColor = System.Drawing.Color.Gainsboro;
            this.lLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLanguage.Location = new System.Drawing.Point(3, 701);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(157, 39);
            this.lLanguage.TabIndex = 20;
            this.lLanguage.Text = "Язык :";
            this.lLanguage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lMetascore
            // 
            this.lMetascore.AutoSize = true;
            this.lMetascore.BackColor = System.Drawing.Color.Gainsboro;
            this.lMetascore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lMetascore.Location = new System.Drawing.Point(419, 832);
            this.lMetascore.Name = "lMetascore";
            this.lMetascore.Size = new System.Drawing.Size(135, 33);
            this.lMetascore.TabIndex = 21;
            this.lMetascore.Text = "Metascore :";
            this.lMetascore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lMetascore.Visible = false;
            // 
            // lImdbRating
            // 
            this.lImdbRating.AutoSize = true;
            this.lImdbRating.BackColor = System.Drawing.Color.Gainsboro;
            this.lImdbRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lImdbRating.Location = new System.Drawing.Point(3, 798);
            this.lImdbRating.Name = "lImdbRating";
            this.lImdbRating.Size = new System.Drawing.Size(157, 34);
            this.lImdbRating.TabIndex = 22;
            this.lImdbRating.Text = "IMDB рейтинг :";
            this.lImdbRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lImdbRating.Visible = false;
            // 
            // tableLP_info
            // 
            this.tableLP_info.ColumnCount = 4;
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.18269F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.81731F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 441F));
            this.tableLP_info.Controls.Add(this.lTitle, 0, 2);
            this.tableLP_info.Controls.Add(this.lImdbVotes, 0, 12);
            this.tableLP_info.Controls.Add(this.lImdbRating, 0, 11);
            this.tableLP_info.Controls.Add(this.lCountry, 0, 10);
            this.tableLP_info.Controls.Add(this.lLanguage, 0, 9);
            this.tableLP_info.Controls.Add(this.lDirector, 0, 8);
            this.tableLP_info.Controls.Add(this.lRated, 0, 7);
            this.tableLP_info.Controls.Add(this.lGenre, 0, 6);
            this.tableLP_info.Controls.Add(this.lRuntime, 0, 5);
            this.tableLP_info.Controls.Add(this.lDateReleased, 0, 4);
            this.tableLP_info.Controls.Add(this.lRating, 0, 3);
            this.tableLP_info.Controls.Add(this.tbRating, 1, 3);
            this.tableLP_info.Controls.Add(this.tbReleased, 1, 4);
            this.tableLP_info.Controls.Add(this.tbRuntime, 1, 5);
            this.tableLP_info.Controls.Add(this.tbGenre, 1, 6);
            this.tableLP_info.Controls.Add(this.tbRated, 1, 7);
            this.tableLP_info.Controls.Add(this.tbDirector, 1, 8);
            this.tableLP_info.Controls.Add(this.tbLanguage, 1, 9);
            this.tableLP_info.Controls.Add(this.tbCountry, 1, 10);
            this.tableLP_info.Controls.Add(this.tbImdbRated, 1, 11);
            this.tableLP_info.Controls.Add(this.tbImdbVotes, 1, 12);
            this.tableLP_info.Controls.Add(this.tbPlot, 3, 0);
            this.tableLP_info.Controls.Add(this.lPlot, 2, 0);
            this.tableLP_info.Controls.Add(this.picturePoster, 0, 0);
            this.tableLP_info.Controls.Add(this.tbActors, 3, 1);
            this.tableLP_info.Controls.Add(this.lActors, 2, 1);
            this.tableLP_info.Controls.Add(this.lWriters, 2, 3);
            this.tableLP_info.Controls.Add(this.tbWriters, 3, 3);
            this.tableLP_info.Controls.Add(this.lYear, 2, 7);
            this.tableLP_info.Controls.Add(this.tbYearReleased, 3, 7);
            this.tableLP_info.Controls.Add(this.lWebSite, 2, 6);
            this.tableLP_info.Controls.Add(this.tbWebSite, 3, 6);
            this.tableLP_info.Controls.Add(this.lProduction, 2, 8);
            this.tableLP_info.Controls.Add(this.tbProduction, 3, 8);
            this.tableLP_info.Controls.Add(this.lBoxOffice, 2, 11);
            this.tableLP_info.Controls.Add(this.lMetascore, 2, 12);
            this.tableLP_info.Controls.Add(this.tbBoxOffice, 3, 11);
            this.tableLP_info.Controls.Add(this.tbMetaScore, 3, 12);
            this.tableLP_info.Controls.Add(this.lAwards, 2, 10);
            this.tableLP_info.Controls.Add(this.tbAwards, 3, 10);
            this.tableLP_info.Controls.Add(this.lDVD, 2, 9);
            this.tableLP_info.Controls.Add(this.tbDVD, 3, 9);
            this.tableLP_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLP_info.Location = new System.Drawing.Point(0, 0);
            this.tableLP_info.Name = "tableLP_info";
            this.tableLP_info.RowCount = 14;
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.09039F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLP_info.Size = new System.Drawing.Size(999, 910);
            this.tableLP_info.TabIndex = 23;
            // 
            // lImdbVotes
            // 
            this.lImdbVotes.AutoSize = true;
            this.lImdbVotes.BackColor = System.Drawing.Color.Gainsboro;
            this.lImdbVotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lImdbVotes.Location = new System.Drawing.Point(3, 832);
            this.lImdbVotes.Name = "lImdbVotes";
            this.lImdbVotes.Size = new System.Drawing.Size(157, 33);
            this.lImdbVotes.TabIndex = 27;
            this.lImdbVotes.Text = "IMDB голоса :";
            this.lImdbVotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lImdbVotes.Visible = false;
            // 
            // tbRating
            // 
            this.tbRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRating.Location = new System.Drawing.Point(166, 443);
            this.tbRating.Multiline = true;
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(247, 26);
            this.tbRating.TabIndex = 26;
            this.tbRating.TabStop = false;
            // 
            // tbReleased
            // 
            this.tbReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReleased.Location = new System.Drawing.Point(166, 475);
            this.tbReleased.Multiline = true;
            this.tbReleased.Name = "tbReleased";
            this.tbReleased.ReadOnly = true;
            this.tbReleased.Size = new System.Drawing.Size(247, 24);
            this.tbReleased.TabIndex = 29;
            // 
            // tbRuntime
            // 
            this.tbRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRuntime.Location = new System.Drawing.Point(166, 505);
            this.tbRuntime.Multiline = true;
            this.tbRuntime.Name = "tbRuntime";
            this.tbRuntime.ReadOnly = true;
            this.tbRuntime.Size = new System.Drawing.Size(247, 28);
            this.tbRuntime.TabIndex = 30;
            // 
            // tbGenre
            // 
            this.tbGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGenre.Location = new System.Drawing.Point(166, 539);
            this.tbGenre.Multiline = true;
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.ReadOnly = true;
            this.tbGenre.Size = new System.Drawing.Size(247, 56);
            this.tbGenre.TabIndex = 31;
            // 
            // tbRated
            // 
            this.tbRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRated.Location = new System.Drawing.Point(166, 601);
            this.tbRated.Multiline = true;
            this.tbRated.Name = "tbRated";
            this.tbRated.ReadOnly = true;
            this.tbRated.Size = new System.Drawing.Size(247, 27);
            this.tbRated.TabIndex = 32;
            // 
            // tbDirector
            // 
            this.tbDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDirector.Location = new System.Drawing.Point(166, 634);
            this.tbDirector.Multiline = true;
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.ReadOnly = true;
            this.tbDirector.Size = new System.Drawing.Size(247, 64);
            this.tbDirector.TabIndex = 33;
            // 
            // tbLanguage
            // 
            this.tbLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLanguage.Location = new System.Drawing.Point(166, 704);
            this.tbLanguage.Multiline = true;
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.ReadOnly = true;
            this.tbLanguage.Size = new System.Drawing.Size(247, 33);
            this.tbLanguage.TabIndex = 34;
            // 
            // tbCountry
            // 
            this.tbCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCountry.Location = new System.Drawing.Point(166, 743);
            this.tbCountry.Multiline = true;
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.ReadOnly = true;
            this.tbCountry.Size = new System.Drawing.Size(247, 52);
            this.tbCountry.TabIndex = 35;
            // 
            // tbImdbRated
            // 
            this.tbImdbRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbImdbRated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbImdbRated.Location = new System.Drawing.Point(166, 801);
            this.tbImdbRated.Multiline = true;
            this.tbImdbRated.Name = "tbImdbRated";
            this.tbImdbRated.ReadOnly = true;
            this.tbImdbRated.Size = new System.Drawing.Size(247, 28);
            this.tbImdbRated.TabIndex = 36;
            this.tbImdbRated.Visible = false;
            // 
            // tbImdbVotes
            // 
            this.tbImdbVotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbImdbVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbImdbVotes.Location = new System.Drawing.Point(166, 835);
            this.tbImdbVotes.Multiline = true;
            this.tbImdbVotes.Name = "tbImdbVotes";
            this.tbImdbVotes.ReadOnly = true;
            this.tbImdbVotes.Size = new System.Drawing.Size(247, 27);
            this.tbImdbVotes.TabIndex = 37;
            this.tbImdbVotes.Visible = false;
            // 
            // tbProduction
            // 
            this.tbProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProduction.Location = new System.Drawing.Point(560, 634);
            this.tbProduction.Multiline = true;
            this.tbProduction.Name = "tbProduction";
            this.tbProduction.ReadOnly = true;
            this.tbProduction.Size = new System.Drawing.Size(436, 64);
            this.tbProduction.TabIndex = 41;
            this.tbProduction.Visible = false;
            // 
            // tbActors
            // 
            this.tbActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbActors.Location = new System.Drawing.Point(560, 146);
            this.tbActors.Multiline = true;
            this.tbActors.Name = "tbActors";
            this.tbActors.ReadOnly = true;
            this.tableLP_info.SetRowSpan(this.tbActors, 2);
            this.tbActors.Size = new System.Drawing.Size(436, 291);
            this.tbActors.TabIndex = 42;
            this.tbActors.Visible = false;
            // 
            // tbWriters
            // 
            this.tbWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWriters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWriters.Location = new System.Drawing.Point(560, 443);
            this.tbWriters.Multiline = true;
            this.tbWriters.Name = "tbWriters";
            this.tbWriters.ReadOnly = true;
            this.tableLP_info.SetRowSpan(this.tbWriters, 3);
            this.tbWriters.Size = new System.Drawing.Size(436, 90);
            this.tbWriters.TabIndex = 43;
            this.tbWriters.Visible = false;
            // 
            // tbMetaScore
            // 
            this.tbMetaScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMetaScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMetaScore.Location = new System.Drawing.Point(560, 835);
            this.tbMetaScore.Multiline = true;
            this.tbMetaScore.Name = "tbMetaScore";
            this.tbMetaScore.ReadOnly = true;
            this.tbMetaScore.Size = new System.Drawing.Size(436, 27);
            this.tbMetaScore.TabIndex = 47;
            this.tbMetaScore.Visible = false;
            // 
            // tbPlot
            // 
            this.tbPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlot.Location = new System.Drawing.Point(560, 3);
            this.tbPlot.Multiline = true;
            this.tbPlot.Name = "tbPlot";
            this.tbPlot.ReadOnly = true;
            this.tbPlot.Size = new System.Drawing.Size(436, 137);
            this.tbPlot.TabIndex = 38;
            // 
            // tbWebSite
            // 
            this.tbWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWebSite.Location = new System.Drawing.Point(560, 539);
            this.tbWebSite.Multiline = true;
            this.tbWebSite.Name = "tbWebSite";
            this.tbWebSite.ReadOnly = true;
            this.tbWebSite.Size = new System.Drawing.Size(436, 56);
            this.tbWebSite.TabIndex = 28;
            this.tbWebSite.Visible = false;
            // 
            // tbBoxOffice
            // 
            this.tbBoxOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBoxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBoxOffice.Location = new System.Drawing.Point(560, 801);
            this.tbBoxOffice.Multiline = true;
            this.tbBoxOffice.Name = "tbBoxOffice";
            this.tbBoxOffice.ReadOnly = true;
            this.tbBoxOffice.Size = new System.Drawing.Size(436, 28);
            this.tbBoxOffice.TabIndex = 46;
            this.tbBoxOffice.Visible = false;
            // 
            // tbAwards
            // 
            this.tbAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAwards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAwards.Location = new System.Drawing.Point(560, 743);
            this.tbAwards.Multiline = true;
            this.tbAwards.Name = "tbAwards";
            this.tbAwards.ReadOnly = true;
            this.tbAwards.Size = new System.Drawing.Size(436, 52);
            this.tbAwards.TabIndex = 44;
            this.tbAwards.Visible = false;
            // 
            // tbDVD
            // 
            this.tbDVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDVD.Location = new System.Drawing.Point(560, 704);
            this.tbDVD.Multiline = true;
            this.tbDVD.Name = "tbDVD";
            this.tbDVD.ReadOnly = true;
            this.tbDVD.Size = new System.Drawing.Size(436, 33);
            this.tbDVD.TabIndex = 40;
            this.tbDVD.Visible = false;
            // 
            // tbYearReleased
            // 
            this.tbYearReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbYearReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbYearReleased.Location = new System.Drawing.Point(560, 601);
            this.tbYearReleased.Multiline = true;
            this.tbYearReleased.Name = "tbYearReleased";
            this.tbYearReleased.ReadOnly = true;
            this.tbYearReleased.Size = new System.Drawing.Size(436, 27);
            this.tbYearReleased.TabIndex = 39;
            this.tbYearReleased.Visible = false;
            // 
            // ShowFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(999, 910);
            this.Controls.Add(this.tableLP_info);
            this.Name = "ShowFilmForm";
            this.Text = "ShowFilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.tableLP_info.ResumeLayout(false);
            this.tableLP_info.PerformLayout();
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
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.Label lImdbVotes;
        private System.Windows.Forms.TextBox tbWebSite;
        private System.Windows.Forms.TextBox tbReleased;
        private System.Windows.Forms.TextBox tbRuntime;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbRated;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.TextBox tbLanguage;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbImdbRated;
        private System.Windows.Forms.TextBox tbImdbVotes;
        private System.Windows.Forms.TextBox tbPlot;
        private System.Windows.Forms.TextBox tbYearReleased;
        private System.Windows.Forms.TextBox tbDVD;
        private System.Windows.Forms.TextBox tbProduction;
        private System.Windows.Forms.TextBox tbActors;
        private System.Windows.Forms.TextBox tbWriters;
        private System.Windows.Forms.TextBox tbAwards;
        private System.Windows.Forms.TextBox tbBoxOffice;
        private System.Windows.Forms.TextBox tbMetaScore;
    }
}