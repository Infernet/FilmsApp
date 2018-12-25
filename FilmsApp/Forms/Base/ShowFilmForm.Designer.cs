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
            this.tbReleased = new System.Windows.Forms.TextBox();
            this.tbRuntime = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbRated = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbImdbRated = new System.Windows.Forms.TextBox();
            this.tbImdbVotes = new System.Windows.Forms.TextBox();
            this.tbPlot = new System.Windows.Forms.TextBox();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.tbWriters = new System.Windows.Forms.TextBox();
            this.tbYearReleased = new System.Windows.Forms.TextBox();
            this.tbWebSite = new System.Windows.Forms.TextBox();
            this.tbProduction = new System.Windows.Forms.TextBox();
            this.tbBoxOffice = new System.Windows.Forms.TextBox();
            this.tbMetaScore = new System.Windows.Forms.TextBox();
            this.tbAwards = new System.Windows.Forms.TextBox();
            this.tbDVD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonShowFeedBack = new System.Windows.Forms.Button();
            this.buttonAddFeedBack = new System.Windows.Forms.Button();
            this.numericRating = new System.Windows.Forms.NumericUpDown();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.tableLP_info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.DarkGray;
            this.lTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLP_info.SetColumnSpan(this.lTitle, 2);
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.Location = new System.Drawing.Point(5, 262);
            this.lTitle.Margin = new System.Windows.Forms.Padding(5);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(365, 51);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Название";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picturePoster
            // 
            this.picturePoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picturePoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLP_info.SetColumnSpan(this.picturePoster, 2);
            this.picturePoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePoster.Location = new System.Drawing.Point(3, 3);
            this.picturePoster.Name = "picturePoster";
            this.tableLP_info.SetRowSpan(this.picturePoster, 2);
            this.picturePoster.Size = new System.Drawing.Size(369, 251);
            this.picturePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePoster.TabIndex = 1;
            this.picturePoster.TabStop = false;
            this.picturePoster.Click += new System.EventHandler(this.picturePoster_Click);
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.BackColor = System.Drawing.Color.Gainsboro;
            this.lYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lYear.Location = new System.Drawing.Point(378, 468);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(118, 38);
            this.lYear.TabIndex = 2;
            this.lYear.Text = "Год:";
            this.lYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lYear.Visible = false;
            // 
            // lRuntime
            // 
            this.lRuntime.AutoSize = true;
            this.lRuntime.BackColor = System.Drawing.Color.Gainsboro;
            this.lRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRuntime.Location = new System.Drawing.Point(3, 384);
            this.lRuntime.Name = "lRuntime";
            this.lRuntime.Size = new System.Drawing.Size(111, 40);
            this.lRuntime.TabIndex = 6;
            this.lRuntime.Text = "Длительность:";
            this.lRuntime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lDateReleased
            // 
            this.lDateReleased.AutoSize = true;
            this.lDateReleased.BackColor = System.Drawing.Color.Gainsboro;
            this.lDateReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDateReleased.Location = new System.Drawing.Point(3, 349);
            this.lDateReleased.Name = "lDateReleased";
            this.lDateReleased.Size = new System.Drawing.Size(111, 35);
            this.lDateReleased.TabIndex = 5;
            this.lDateReleased.Text = "Дата выхода:";
            this.lDateReleased.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.BackColor = System.Drawing.Color.Gainsboro;
            this.lGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lGenre.Location = new System.Drawing.Point(3, 424);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(111, 44);
            this.lGenre.TabIndex = 7;
            this.lGenre.Text = "Жанр:";
            this.lGenre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.BackColor = System.Drawing.Color.Gainsboro;
            this.lCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCountry.Location = new System.Drawing.Point(3, 591);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(111, 55);
            this.lCountry.TabIndex = 8;
            this.lCountry.Text = "Страна:";
            this.lCountry.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lDirector
            // 
            this.lDirector.AutoSize = true;
            this.lDirector.BackColor = System.Drawing.Color.Gainsboro;
            this.lDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDirector.Location = new System.Drawing.Point(3, 506);
            this.lDirector.Name = "lDirector";
            this.lDirector.Size = new System.Drawing.Size(111, 39);
            this.lDirector.TabIndex = 9;
            this.lDirector.Text = "Режиссёр:";
            this.lDirector.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lRated
            // 
            this.lRated.AutoSize = true;
            this.lRated.BackColor = System.Drawing.Color.Gainsboro;
            this.lRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRated.Location = new System.Drawing.Point(3, 468);
            this.lRated.Name = "lRated";
            this.lRated.Size = new System.Drawing.Size(111, 38);
            this.lRated.TabIndex = 10;
            this.lRated.Text = "Возрастной рейтинг:";
            this.lRated.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lRating
            // 
            this.lRating.AutoSize = true;
            this.lRating.BackColor = System.Drawing.Color.Gainsboro;
            this.lRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRating.Location = new System.Drawing.Point(3, 318);
            this.lRating.Name = "lRating";
            this.lRating.Size = new System.Drawing.Size(111, 31);
            this.lRating.TabIndex = 11;
            this.lRating.Text = "Рейтинг:";
            this.lRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lPlot
            // 
            this.lPlot.AutoSize = true;
            this.lPlot.BackColor = System.Drawing.Color.Gainsboro;
            this.lPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lPlot.Location = new System.Drawing.Point(378, 0);
            this.lPlot.Name = "lPlot";
            this.lPlot.Size = new System.Drawing.Size(118, 170);
            this.lPlot.TabIndex = 12;
            this.lPlot.Text = "Описание:";
            this.lPlot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lAwards
            // 
            this.lAwards.AutoSize = true;
            this.lAwards.BackColor = System.Drawing.Color.Gainsboro;
            this.lAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAwards.Location = new System.Drawing.Point(378, 591);
            this.lAwards.Name = "lAwards";
            this.lAwards.Size = new System.Drawing.Size(118, 55);
            this.lAwards.TabIndex = 13;
            this.lAwards.Text = "Награды:";
            this.lAwards.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lAwards.Visible = false;
            // 
            // lActors
            // 
            this.lActors.AutoSize = true;
            this.lActors.BackColor = System.Drawing.Color.Gainsboro;
            this.lActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lActors.Location = new System.Drawing.Point(378, 170);
            this.lActors.Name = "lActors";
            this.tableLP_info.SetRowSpan(this.lActors, 2);
            this.lActors.Size = new System.Drawing.Size(118, 148);
            this.lActors.TabIndex = 14;
            this.lActors.Text = "Актеры:";
            this.lActors.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lActors.Visible = false;
            // 
            // lWriters
            // 
            this.lWriters.AutoSize = true;
            this.lWriters.BackColor = System.Drawing.Color.Gainsboro;
            this.lWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWriters.Location = new System.Drawing.Point(378, 318);
            this.lWriters.Name = "lWriters";
            this.tableLP_info.SetRowSpan(this.lWriters, 3);
            this.lWriters.Size = new System.Drawing.Size(118, 106);
            this.lWriters.TabIndex = 15;
            this.lWriters.Text = "Сценарий:";
            this.lWriters.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lWriters.Visible = false;
            // 
            // lWebSite
            // 
            this.lWebSite.AutoSize = true;
            this.lWebSite.BackColor = System.Drawing.Color.Gainsboro;
            this.lWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWebSite.Location = new System.Drawing.Point(378, 424);
            this.lWebSite.Name = "lWebSite";
            this.lWebSite.Size = new System.Drawing.Size(118, 44);
            this.lWebSite.TabIndex = 16;
            this.lWebSite.Text = "Сайт:";
            this.lWebSite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lWebSite.Visible = false;
            // 
            // lDVD
            // 
            this.lDVD.AutoSize = true;
            this.lDVD.BackColor = System.Drawing.Color.Gainsboro;
            this.lDVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDVD.Location = new System.Drawing.Point(378, 545);
            this.lDVD.Name = "lDVD";
            this.lDVD.Size = new System.Drawing.Size(118, 46);
            this.lDVD.TabIndex = 17;
            this.lDVD.Text = "Дата выхода на DVD:";
            this.lDVD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lDVD.Visible = false;
            // 
            // lBoxOffice
            // 
            this.lBoxOffice.AutoSize = true;
            this.lBoxOffice.BackColor = System.Drawing.Color.Gainsboro;
            this.lBoxOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxOffice.Location = new System.Drawing.Point(378, 646);
            this.lBoxOffice.Name = "lBoxOffice";
            this.lBoxOffice.Size = new System.Drawing.Size(118, 40);
            this.lBoxOffice.TabIndex = 18;
            this.lBoxOffice.Text = "Кассовые сборы:";
            this.lBoxOffice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lBoxOffice.Visible = false;
            // 
            // lProduction
            // 
            this.lProduction.AutoSize = true;
            this.lProduction.BackColor = System.Drawing.Color.Gainsboro;
            this.lProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lProduction.Location = new System.Drawing.Point(378, 506);
            this.lProduction.Name = "lProduction";
            this.lProduction.Size = new System.Drawing.Size(118, 39);
            this.lProduction.TabIndex = 19;
            this.lProduction.Text = "Студия производитель:";
            this.lProduction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lProduction.Visible = false;
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.BackColor = System.Drawing.Color.Gainsboro;
            this.lLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLanguage.Location = new System.Drawing.Point(3, 545);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(111, 46);
            this.lLanguage.TabIndex = 20;
            this.lLanguage.Text = "Язык:";
            this.lLanguage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lMetascore
            // 
            this.lMetascore.AutoSize = true;
            this.lMetascore.BackColor = System.Drawing.Color.Gainsboro;
            this.lMetascore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lMetascore.Location = new System.Drawing.Point(378, 686);
            this.lMetascore.Name = "lMetascore";
            this.lMetascore.Size = new System.Drawing.Size(118, 34);
            this.lMetascore.TabIndex = 21;
            this.lMetascore.Text = "Metascore:";
            this.lMetascore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lMetascore.Visible = false;
            // 
            // lImdbRating
            // 
            this.lImdbRating.AutoSize = true;
            this.lImdbRating.BackColor = System.Drawing.Color.Gainsboro;
            this.lImdbRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lImdbRating.Location = new System.Drawing.Point(3, 646);
            this.lImdbRating.Name = "lImdbRating";
            this.lImdbRating.Size = new System.Drawing.Size(111, 40);
            this.lImdbRating.TabIndex = 22;
            this.lImdbRating.Text = "IMDB рейтинг:";
            this.lImdbRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lImdbRating.Visible = false;
            // 
            // tableLP_info
            // 
            this.tableLP_info.ColumnCount = 4;
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.32832F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.67168F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
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
            this.tableLP_info.Controls.Add(this.groupBox1, 0, 13);
            this.tableLP_info.Controls.Add(this.numericRating, 1, 3);
            this.tableLP_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLP_info.Location = new System.Drawing.Point(0, 0);
            this.tableLP_info.Name = "tableLP_info";
            this.tableLP_info.RowCount = 14;
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.09039F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLP_info.Size = new System.Drawing.Size(927, 782);
            this.tableLP_info.TabIndex = 23;
            // 
            // lImdbVotes
            // 
            this.lImdbVotes.AutoSize = true;
            this.lImdbVotes.BackColor = System.Drawing.Color.Gainsboro;
            this.lImdbVotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lImdbVotes.Location = new System.Drawing.Point(3, 686);
            this.lImdbVotes.Name = "lImdbVotes";
            this.lImdbVotes.Size = new System.Drawing.Size(111, 34);
            this.lImdbVotes.TabIndex = 27;
            this.lImdbVotes.Text = "IMDB голоса:";
            this.lImdbVotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lImdbVotes.Visible = false;
            // 
            // tbReleased
            // 
            this.tbReleased.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReleased.Location = new System.Drawing.Point(120, 352);
            this.tbReleased.Multiline = true;
            this.tbReleased.Name = "tbReleased";
            this.tbReleased.ReadOnly = true;
            this.tbReleased.Size = new System.Drawing.Size(252, 29);
            this.tbReleased.TabIndex = 29;
            this.tbReleased.TabStop = false;
            // 
            // tbRuntime
            // 
            this.tbRuntime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRuntime.Location = new System.Drawing.Point(120, 387);
            this.tbRuntime.Multiline = true;
            this.tbRuntime.Name = "tbRuntime";
            this.tbRuntime.ReadOnly = true;
            this.tbRuntime.Size = new System.Drawing.Size(252, 34);
            this.tbRuntime.TabIndex = 30;
            this.tbRuntime.TabStop = false;
            // 
            // tbGenre
            // 
            this.tbGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGenre.Location = new System.Drawing.Point(120, 427);
            this.tbGenre.Multiline = true;
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.ReadOnly = true;
            this.tbGenre.Size = new System.Drawing.Size(252, 38);
            this.tbGenre.TabIndex = 31;
            this.tbGenre.TabStop = false;
            // 
            // tbRated
            // 
            this.tbRated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRated.Location = new System.Drawing.Point(120, 471);
            this.tbRated.Multiline = true;
            this.tbRated.Name = "tbRated";
            this.tbRated.ReadOnly = true;
            this.tbRated.Size = new System.Drawing.Size(252, 32);
            this.tbRated.TabIndex = 32;
            this.tbRated.TabStop = false;
            // 
            // tbDirector
            // 
            this.tbDirector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDirector.Location = new System.Drawing.Point(120, 509);
            this.tbDirector.Multiline = true;
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.ReadOnly = true;
            this.tbDirector.Size = new System.Drawing.Size(252, 33);
            this.tbDirector.TabIndex = 33;
            this.tbDirector.TabStop = false;
            // 
            // tbLanguage
            // 
            this.tbLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLanguage.Location = new System.Drawing.Point(120, 548);
            this.tbLanguage.Multiline = true;
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.ReadOnly = true;
            this.tbLanguage.Size = new System.Drawing.Size(252, 40);
            this.tbLanguage.TabIndex = 34;
            this.tbLanguage.TabStop = false;
            // 
            // tbCountry
            // 
            this.tbCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCountry.Location = new System.Drawing.Point(120, 594);
            this.tbCountry.Multiline = true;
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.ReadOnly = true;
            this.tbCountry.Size = new System.Drawing.Size(252, 49);
            this.tbCountry.TabIndex = 35;
            this.tbCountry.TabStop = false;
            // 
            // tbImdbRated
            // 
            this.tbImdbRated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbImdbRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbImdbRated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbImdbRated.Location = new System.Drawing.Point(120, 649);
            this.tbImdbRated.Multiline = true;
            this.tbImdbRated.Name = "tbImdbRated";
            this.tbImdbRated.ReadOnly = true;
            this.tbImdbRated.Size = new System.Drawing.Size(252, 34);
            this.tbImdbRated.TabIndex = 36;
            this.tbImdbRated.TabStop = false;
            this.tbImdbRated.Visible = false;
            // 
            // tbImdbVotes
            // 
            this.tbImdbVotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbImdbVotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbImdbVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbImdbVotes.Location = new System.Drawing.Point(120, 689);
            this.tbImdbVotes.Multiline = true;
            this.tbImdbVotes.Name = "tbImdbVotes";
            this.tbImdbVotes.ReadOnly = true;
            this.tbImdbVotes.Size = new System.Drawing.Size(252, 28);
            this.tbImdbVotes.TabIndex = 37;
            this.tbImdbVotes.TabStop = false;
            this.tbImdbVotes.Visible = false;
            // 
            // tbPlot
            // 
            this.tbPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlot.Location = new System.Drawing.Point(502, 3);
            this.tbPlot.Multiline = true;
            this.tbPlot.Name = "tbPlot";
            this.tbPlot.ReadOnly = true;
            this.tbPlot.Size = new System.Drawing.Size(422, 164);
            this.tbPlot.TabIndex = 38;
            this.tbPlot.TabStop = false;
            // 
            // tbActors
            // 
            this.tbActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbActors.Location = new System.Drawing.Point(502, 173);
            this.tbActors.Multiline = true;
            this.tbActors.Name = "tbActors";
            this.tbActors.ReadOnly = true;
            this.tableLP_info.SetRowSpan(this.tbActors, 2);
            this.tbActors.Size = new System.Drawing.Size(422, 142);
            this.tbActors.TabIndex = 42;
            this.tbActors.TabStop = false;
            this.tbActors.Visible = false;
            // 
            // tbWriters
            // 
            this.tbWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWriters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWriters.Location = new System.Drawing.Point(502, 321);
            this.tbWriters.Multiline = true;
            this.tbWriters.Name = "tbWriters";
            this.tbWriters.ReadOnly = true;
            this.tableLP_info.SetRowSpan(this.tbWriters, 3);
            this.tbWriters.Size = new System.Drawing.Size(422, 100);
            this.tbWriters.TabIndex = 43;
            this.tbWriters.TabStop = false;
            this.tbWriters.Visible = false;
            // 
            // tbYearReleased
            // 
            this.tbYearReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbYearReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbYearReleased.Location = new System.Drawing.Point(502, 471);
            this.tbYearReleased.Multiline = true;
            this.tbYearReleased.Name = "tbYearReleased";
            this.tbYearReleased.ReadOnly = true;
            this.tbYearReleased.Size = new System.Drawing.Size(422, 32);
            this.tbYearReleased.TabIndex = 39;
            this.tbYearReleased.TabStop = false;
            this.tbYearReleased.Visible = false;
            // 
            // tbWebSite
            // 
            this.tbWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWebSite.Location = new System.Drawing.Point(502, 427);
            this.tbWebSite.Multiline = true;
            this.tbWebSite.Name = "tbWebSite";
            this.tbWebSite.ReadOnly = true;
            this.tbWebSite.Size = new System.Drawing.Size(422, 38);
            this.tbWebSite.TabIndex = 28;
            this.tbWebSite.TabStop = false;
            this.tbWebSite.Visible = false;
            // 
            // tbProduction
            // 
            this.tbProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProduction.Location = new System.Drawing.Point(502, 509);
            this.tbProduction.Multiline = true;
            this.tbProduction.Name = "tbProduction";
            this.tbProduction.ReadOnly = true;
            this.tbProduction.Size = new System.Drawing.Size(422, 33);
            this.tbProduction.TabIndex = 41;
            this.tbProduction.TabStop = false;
            this.tbProduction.Visible = false;
            // 
            // tbBoxOffice
            // 
            this.tbBoxOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBoxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBoxOffice.Location = new System.Drawing.Point(502, 649);
            this.tbBoxOffice.Multiline = true;
            this.tbBoxOffice.Name = "tbBoxOffice";
            this.tbBoxOffice.ReadOnly = true;
            this.tbBoxOffice.Size = new System.Drawing.Size(422, 34);
            this.tbBoxOffice.TabIndex = 46;
            this.tbBoxOffice.TabStop = false;
            this.tbBoxOffice.Visible = false;
            // 
            // tbMetaScore
            // 
            this.tbMetaScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMetaScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMetaScore.Location = new System.Drawing.Point(502, 689);
            this.tbMetaScore.Multiline = true;
            this.tbMetaScore.Name = "tbMetaScore";
            this.tbMetaScore.ReadOnly = true;
            this.tbMetaScore.Size = new System.Drawing.Size(422, 28);
            this.tbMetaScore.TabIndex = 47;
            this.tbMetaScore.TabStop = false;
            this.tbMetaScore.Visible = false;
            // 
            // tbAwards
            // 
            this.tbAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAwards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAwards.Location = new System.Drawing.Point(502, 594);
            this.tbAwards.Multiline = true;
            this.tbAwards.Name = "tbAwards";
            this.tbAwards.ReadOnly = true;
            this.tbAwards.Size = new System.Drawing.Size(422, 49);
            this.tbAwards.TabIndex = 44;
            this.tbAwards.TabStop = false;
            this.tbAwards.Visible = false;
            // 
            // tbDVD
            // 
            this.tbDVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDVD.Location = new System.Drawing.Point(502, 548);
            this.tbDVD.Multiline = true;
            this.tbDVD.Name = "tbDVD";
            this.tbDVD.ReadOnly = true;
            this.tbDVD.Size = new System.Drawing.Size(422, 40);
            this.tbDVD.TabIndex = 40;
            this.tbDVD.TabStop = false;
            this.tbDVD.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLP_info.SetColumnSpan(this.groupBox1, 4);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonShowFeedBack);
            this.groupBox1.Controls.Add(this.buttonAddFeedBack);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 723);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 56);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // buttonShowFeedBack
            // 
            this.buttonShowFeedBack.Location = new System.Drawing.Point(145, 14);
            this.buttonShowFeedBack.Name = "buttonShowFeedBack";
            this.buttonShowFeedBack.Size = new System.Drawing.Size(257, 36);
            this.buttonShowFeedBack.TabIndex = 1;
            this.buttonShowFeedBack.Text = "Посмотреть отзывы посетителей";
            this.buttonShowFeedBack.UseVisualStyleBackColor = true;
            this.buttonShowFeedBack.Click += new System.EventHandler(this.buttonShowFeedBack_Click);
            // 
            // buttonAddFeedBack
            // 
            this.buttonAddFeedBack.Location = new System.Drawing.Point(9, 14);
            this.buttonAddFeedBack.Name = "buttonAddFeedBack";
            this.buttonAddFeedBack.Size = new System.Drawing.Size(130, 36);
            this.buttonAddFeedBack.TabIndex = 0;
            this.buttonAddFeedBack.Text = "Оставить отзыв";
            this.buttonAddFeedBack.UseVisualStyleBackColor = true;
            this.buttonAddFeedBack.Click += new System.EventHandler(this.buttonAddFeedBack_Click);
            // 
            // numericRating
            // 
            this.numericRating.DecimalPlaces = 2;
            this.numericRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericRating.Location = new System.Drawing.Point(120, 321);
            this.numericRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericRating.Name = "numericRating";
            this.numericRating.Size = new System.Drawing.Size(252, 24);
            this.numericRating.TabIndex = 49;
            this.numericRating.ValueChanged += new System.EventHandler(this.numericRating_ValueChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(418, 14);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 36);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ShowFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(927, 782);
            this.Controls.Add(this.tableLP_info);
            this.Name = "ShowFilmForm";
            this.Text = "ShowFilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.tableLP_info.ResumeLayout(false);
            this.tableLP_info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddFeedBack;
        private System.Windows.Forms.NumericUpDown numericRating;
        private System.Windows.Forms.Button buttonShowFeedBack;
        private System.Windows.Forms.Button buttonExit;
    }
}