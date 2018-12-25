namespace FilmsApp.Forms.Admin
{
    partial class FilmAddForm
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.dGVLanguage = new System.Windows.Forms.DataGridView();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.gBMainParam = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.lLanguage = new System.Windows.Forms.Label();
            this.buttonSelectPoster = new System.Windows.Forms.Button();
            this.lPoster = new System.Windows.Forms.Label();
            this.cBAdditionalParam = new System.Windows.Forms.CheckBox();
            this.lDirector = new System.Windows.Forms.Label();
            this.lGenre = new System.Windows.Forms.Label();
            this.lCountry = new System.Windows.Forms.Label();
            this.dGVDirector = new System.Windows.Forms.DataGridView();
            this.dGVCountry = new System.Windows.Forms.DataGridView();
            this.dGVGenre = new System.Windows.Forms.DataGridView();
            this.tbRated = new System.Windows.Forms.TextBox();
            this.numericRuntime = new System.Windows.Forms.NumericUpDown();
            this.tbPlot = new System.Windows.Forms.TextBox();
            this.lPlot = new System.Windows.Forms.Label();
            this.dTPReleased = new System.Windows.Forms.DateTimePicker();
            this.lRated = new System.Windows.Forms.Label();
            this.lRuntime = new System.Windows.Forms.Label();
            this.lReleased = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gBAdditionParam = new System.Windows.Forms.GroupBox();
            this.tBAwards = new System.Windows.Forms.TextBox();
            this.lAwards = new System.Windows.Forms.Label();
            this.numericMetaScore = new System.Windows.Forms.NumericUpDown();
            this.numericImdbVotes = new System.Windows.Forms.NumericUpDown();
            this.numericImdbRated = new System.Windows.Forms.NumericUpDown();
            this.lMetascore = new System.Windows.Forms.Label();
            this.lImdbVotes = new System.Windows.Forms.Label();
            this.lImdbRated = new System.Windows.Forms.Label();
            this.numericBoxOffice = new System.Windows.Forms.NumericUpDown();
            this.lBoxOffice = new System.Windows.Forms.Label();
            this.dTPDvd = new System.Windows.Forms.DateTimePicker();
            this.tbSite = new System.Windows.Forms.TextBox();
            this.lDVD = new System.Windows.Forms.Label();
            this.lSite = new System.Windows.Forms.Label();
            this.lWriters = new System.Windows.Forms.Label();
            this.dGVWriter = new System.Windows.Forms.DataGridView();
            this.lProduction = new System.Windows.Forms.Label();
            this.dGVProduction = new System.Windows.Forms.DataGridView();
            this.lActors = new System.Windows.Forms.Label();
            this.dGVActors = new System.Windows.Forms.DataGridView();
            this.openPosterDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLanguage)).BeginInit();
            this.gBMainParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRuntime)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gBAdditionParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMetaScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImdbVotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImdbRated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBoxOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWriter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVActors)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(10, 211);
            this.lTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(75, 18);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Название";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(163, 208);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.MaxLength = 50;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(239, 24);
            this.tbTitle.TabIndex = 1;
            // 
            // dGVLanguage
            // 
            this.dGVLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLanguage.Location = new System.Drawing.Point(424, 41);
            this.dGVLanguage.Name = "dGVLanguage";
            this.dGVLanguage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVLanguage.Size = new System.Drawing.Size(358, 162);
            this.dGVLanguage.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(972, 438);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(203, 34);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Добавить новый фильм";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // gBMainParam
            // 
            this.gBMainParam.Controls.Add(this.buttonExit);
            this.gBMainParam.Controls.Add(this.pictureBoxIcon);
            this.gBMainParam.Controls.Add(this.lLanguage);
            this.gBMainParam.Controls.Add(this.dGVLanguage);
            this.gBMainParam.Controls.Add(this.buttonSelectPoster);
            this.gBMainParam.Controls.Add(this.lPoster);
            this.gBMainParam.Controls.Add(this.cBAdditionalParam);
            this.gBMainParam.Controls.Add(this.buttonSubmit);
            this.gBMainParam.Controls.Add(this.lDirector);
            this.gBMainParam.Controls.Add(this.lGenre);
            this.gBMainParam.Controls.Add(this.lCountry);
            this.gBMainParam.Controls.Add(this.dGVDirector);
            this.gBMainParam.Controls.Add(this.dGVCountry);
            this.gBMainParam.Controls.Add(this.dGVGenre);
            this.gBMainParam.Controls.Add(this.tbRated);
            this.gBMainParam.Controls.Add(this.numericRuntime);
            this.gBMainParam.Controls.Add(this.tbPlot);
            this.gBMainParam.Controls.Add(this.lPlot);
            this.gBMainParam.Controls.Add(this.dTPReleased);
            this.gBMainParam.Controls.Add(this.lRated);
            this.gBMainParam.Controls.Add(this.lRuntime);
            this.gBMainParam.Controls.Add(this.lReleased);
            this.gBMainParam.Controls.Add(this.lTitle);
            this.gBMainParam.Controls.Add(this.tbTitle);
            this.gBMainParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBMainParam.Location = new System.Drawing.Point(3, 3);
            this.gBMainParam.Name = "gBMainParam";
            this.gBMainParam.Size = new System.Drawing.Size(1184, 478);
            this.gBMainParam.TabIndex = 5;
            this.gBMainParam.TabStop = false;
            this.gBMainParam.Text = "Обязательные параметры";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(213, 23);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 33);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(9, 23);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(198, 178);
            this.pictureBoxIcon.TabIndex = 22;
            this.pictureBoxIcon.TabStop = false;
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.Location = new System.Drawing.Point(421, 20);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(46, 18);
            this.lLanguage.TabIndex = 15;
            this.lLanguage.Text = "Язык";
            // 
            // buttonSelectPoster
            // 
            this.buttonSelectPoster.Location = new System.Drawing.Point(487, 438);
            this.buttonSelectPoster.Name = "buttonSelectPoster";
            this.buttonSelectPoster.Size = new System.Drawing.Size(119, 34);
            this.buttonSelectPoster.TabIndex = 20;
            this.buttonSelectPoster.Text = "Выбрать файл";
            this.buttonSelectPoster.UseVisualStyleBackColor = true;
            this.buttonSelectPoster.Click += new System.EventHandler(this.buttonSelectPoster_Click);
            // 
            // lPoster
            // 
            this.lPoster.AutoSize = true;
            this.lPoster.Location = new System.Drawing.Point(422, 446);
            this.lPoster.Name = "lPoster";
            this.lPoster.Size = new System.Drawing.Size(59, 18);
            this.lPoster.TabIndex = 19;
            this.lPoster.Text = "Постер";
            // 
            // cBAdditionalParam
            // 
            this.cBAdditionalParam.AutoSize = true;
            this.cBAdditionalParam.Location = new System.Drawing.Point(687, 445);
            this.cBAdditionalParam.Name = "cBAdditionalParam";
            this.cBAdditionalParam.Size = new System.Drawing.Size(230, 22);
            this.cBAdditionalParam.TabIndex = 6;
            this.cBAdditionalParam.Text = "Дополнительные параметры";
            this.cBAdditionalParam.UseVisualStyleBackColor = true;
            this.cBAdditionalParam.CheckedChanged += new System.EventHandler(this.cBAdditionalParam_CheckedChanged);
            // 
            // lDirector
            // 
            this.lDirector.AutoSize = true;
            this.lDirector.Location = new System.Drawing.Point(809, 220);
            this.lDirector.Name = "lDirector";
            this.lDirector.Size = new System.Drawing.Size(77, 18);
            this.lDirector.TabIndex = 18;
            this.lDirector.Text = "Режиссёр";
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Location = new System.Drawing.Point(809, 20);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(46, 18);
            this.lGenre.TabIndex = 17;
            this.lGenre.Text = "Жанр";
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Location = new System.Drawing.Point(421, 220);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(58, 18);
            this.lCountry.TabIndex = 16;
            this.lCountry.Text = "Страна";
            // 
            // dGVDirector
            // 
            this.dGVDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDirector.Location = new System.Drawing.Point(812, 241);
            this.dGVDirector.Name = "dGVDirector";
            this.dGVDirector.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVDirector.Size = new System.Drawing.Size(363, 171);
            this.dGVDirector.TabIndex = 14;
            // 
            // dGVCountry
            // 
            this.dGVCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCountry.Location = new System.Drawing.Point(424, 241);
            this.dGVCountry.Name = "dGVCountry";
            this.dGVCountry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVCountry.Size = new System.Drawing.Size(358, 171);
            this.dGVCountry.TabIndex = 13;
            // 
            // dGVGenre
            // 
            this.dGVGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGenre.Location = new System.Drawing.Point(812, 41);
            this.dGVGenre.Name = "dGVGenre";
            this.dGVGenre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVGenre.Size = new System.Drawing.Size(363, 162);
            this.dGVGenre.TabIndex = 12;
            // 
            // tbRated
            // 
            this.tbRated.Location = new System.Drawing.Point(163, 325);
            this.tbRated.MaxLength = 30;
            this.tbRated.Name = "tbRated";
            this.tbRated.Size = new System.Drawing.Size(239, 24);
            this.tbRated.TabIndex = 11;
            // 
            // numericRuntime
            // 
            this.numericRuntime.Location = new System.Drawing.Point(163, 286);
            this.numericRuntime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericRuntime.Name = "numericRuntime";
            this.numericRuntime.Size = new System.Drawing.Size(239, 24);
            this.numericRuntime.TabIndex = 10;
            this.numericRuntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPlot
            // 
            this.tbPlot.Location = new System.Drawing.Point(12, 375);
            this.tbPlot.MaxLength = 500;
            this.tbPlot.Multiline = true;
            this.tbPlot.Name = "tbPlot";
            this.tbPlot.Size = new System.Drawing.Size(390, 89);
            this.tbPlot.TabIndex = 9;
            // 
            // lPlot
            // 
            this.lPlot.AutoSize = true;
            this.lPlot.Location = new System.Drawing.Point(9, 354);
            this.lPlot.Name = "lPlot";
            this.lPlot.Size = new System.Drawing.Size(135, 18);
            this.lPlot.TabIndex = 8;
            this.lPlot.Text = "Краткое описание";
            // 
            // dTPReleased
            // 
            this.dTPReleased.Location = new System.Drawing.Point(163, 245);
            this.dTPReleased.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dTPReleased.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dTPReleased.Name = "dTPReleased";
            this.dTPReleased.Size = new System.Drawing.Size(239, 24);
            this.dTPReleased.TabIndex = 7;
            this.dTPReleased.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dTPReleased.ValueChanged += new System.EventHandler(this.dTPReleased_ValueChanged);
            // 
            // lRated
            // 
            this.lRated.AutoSize = true;
            this.lRated.Location = new System.Drawing.Point(9, 328);
            this.lRated.Name = "lRated";
            this.lRated.Size = new System.Drawing.Size(148, 18);
            this.lRated.TabIndex = 6;
            this.lRated.Text = "Возрастной рейтинг";
            // 
            // lRuntime
            // 
            this.lRuntime.AutoSize = true;
            this.lRuntime.Location = new System.Drawing.Point(9, 288);
            this.lRuntime.Name = "lRuntime";
            this.lRuntime.Size = new System.Drawing.Size(150, 18);
            this.lRuntime.TabIndex = 5;
            this.lRuntime.Text = "Длительность (мин)";
            // 
            // lReleased
            // 
            this.lReleased.AutoSize = true;
            this.lReleased.Location = new System.Drawing.Point(10, 250);
            this.lReleased.Name = "lReleased";
            this.lReleased.Size = new System.Drawing.Size(99, 18);
            this.lReleased.TabIndex = 4;
            this.lReleased.Text = "Дата выхода";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gBMainParam, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gBAdditionParam, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.06045F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.93955F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1190, 834);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // gBAdditionParam
            // 
            this.gBAdditionParam.Controls.Add(this.tBAwards);
            this.gBAdditionParam.Controls.Add(this.lAwards);
            this.gBAdditionParam.Controls.Add(this.numericMetaScore);
            this.gBAdditionParam.Controls.Add(this.numericImdbVotes);
            this.gBAdditionParam.Controls.Add(this.numericImdbRated);
            this.gBAdditionParam.Controls.Add(this.lMetascore);
            this.gBAdditionParam.Controls.Add(this.lImdbVotes);
            this.gBAdditionParam.Controls.Add(this.lImdbRated);
            this.gBAdditionParam.Controls.Add(this.numericBoxOffice);
            this.gBAdditionParam.Controls.Add(this.lBoxOffice);
            this.gBAdditionParam.Controls.Add(this.dTPDvd);
            this.gBAdditionParam.Controls.Add(this.tbSite);
            this.gBAdditionParam.Controls.Add(this.lDVD);
            this.gBAdditionParam.Controls.Add(this.lSite);
            this.gBAdditionParam.Controls.Add(this.lWriters);
            this.gBAdditionParam.Controls.Add(this.dGVWriter);
            this.gBAdditionParam.Controls.Add(this.lProduction);
            this.gBAdditionParam.Controls.Add(this.dGVProduction);
            this.gBAdditionParam.Controls.Add(this.lActors);
            this.gBAdditionParam.Controls.Add(this.dGVActors);
            this.gBAdditionParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBAdditionParam.Enabled = false;
            this.gBAdditionParam.Location = new System.Drawing.Point(3, 487);
            this.gBAdditionParam.Name = "gBAdditionParam";
            this.gBAdditionParam.Size = new System.Drawing.Size(1184, 344);
            this.gBAdditionParam.TabIndex = 6;
            this.gBAdditionParam.TabStop = false;
            this.gBAdditionParam.Text = "Дополнительные параметры";
            // 
            // tBAwards
            // 
            this.tBAwards.Location = new System.Drawing.Point(425, 189);
            this.tBAwards.MaxLength = 100;
            this.tBAwards.Multiline = true;
            this.tBAwards.Name = "tBAwards";
            this.tBAwards.Size = new System.Drawing.Size(358, 128);
            this.tBAwards.TabIndex = 36;
            // 
            // lAwards
            // 
            this.lAwards.AutoSize = true;
            this.lAwards.Location = new System.Drawing.Point(421, 168);
            this.lAwards.Name = "lAwards";
            this.lAwards.Size = new System.Drawing.Size(69, 18);
            this.lAwards.TabIndex = 35;
            this.lAwards.Text = "Награды";
            // 
            // numericMetaScore
            // 
            this.numericMetaScore.Location = new System.Drawing.Point(169, 249);
            this.numericMetaScore.Name = "numericMetaScore";
            this.numericMetaScore.Size = new System.Drawing.Size(233, 24);
            this.numericMetaScore.TabIndex = 34;
            this.numericMetaScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericImdbVotes
            // 
            this.numericImdbVotes.Location = new System.Drawing.Point(169, 202);
            this.numericImdbVotes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericImdbVotes.Name = "numericImdbVotes";
            this.numericImdbVotes.Size = new System.Drawing.Size(233, 24);
            this.numericImdbVotes.TabIndex = 33;
            this.numericImdbVotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericImdbRated
            // 
            this.numericImdbRated.DecimalPlaces = 2;
            this.numericImdbRated.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericImdbRated.Location = new System.Drawing.Point(169, 162);
            this.numericImdbRated.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericImdbRated.Name = "numericImdbRated";
            this.numericImdbRated.Size = new System.Drawing.Size(233, 24);
            this.numericImdbRated.TabIndex = 32;
            this.numericImdbRated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lMetascore
            // 
            this.lMetascore.AutoSize = true;
            this.lMetascore.Location = new System.Drawing.Point(10, 251);
            this.lMetascore.Name = "lMetascore";
            this.lMetascore.Size = new System.Drawing.Size(81, 18);
            this.lMetascore.TabIndex = 31;
            this.lMetascore.Text = "MetaScore";
            // 
            // lImdbVotes
            // 
            this.lImdbVotes.AutoSize = true;
            this.lImdbVotes.Location = new System.Drawing.Point(9, 204);
            this.lImdbVotes.Name = "lImdbVotes";
            this.lImdbVotes.Size = new System.Drawing.Size(98, 18);
            this.lImdbVotes.TabIndex = 30;
            this.lImdbVotes.Text = "IMDB голоса";
            // 
            // lImdbRated
            // 
            this.lImdbRated.AutoSize = true;
            this.lImdbRated.Location = new System.Drawing.Point(9, 162);
            this.lImdbRated.Name = "lImdbRated";
            this.lImdbRated.Size = new System.Drawing.Size(102, 18);
            this.lImdbRated.TabIndex = 29;
            this.lImdbRated.Text = "IMDB рейтинг";
            // 
            // numericBoxOffice
            // 
            this.numericBoxOffice.Location = new System.Drawing.Point(169, 116);
            this.numericBoxOffice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericBoxOffice.Name = "numericBoxOffice";
            this.numericBoxOffice.Size = new System.Drawing.Size(233, 24);
            this.numericBoxOffice.TabIndex = 28;
            this.numericBoxOffice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lBoxOffice
            // 
            this.lBoxOffice.AutoSize = true;
            this.lBoxOffice.Location = new System.Drawing.Point(9, 118);
            this.lBoxOffice.Name = "lBoxOffice";
            this.lBoxOffice.Size = new System.Drawing.Size(139, 18);
            this.lBoxOffice.TabIndex = 27;
            this.lBoxOffice.Text = "Кассовые сборы $";
            // 
            // dTPDvd
            // 
            this.dTPDvd.Location = new System.Drawing.Point(169, 74);
            this.dTPDvd.Name = "dTPDvd";
            this.dTPDvd.Size = new System.Drawing.Size(233, 24);
            this.dTPDvd.TabIndex = 26;
            this.dTPDvd.ValueChanged += new System.EventHandler(this.dTPDvd_ValueChanged);
            // 
            // tbSite
            // 
            this.tbSite.Location = new System.Drawing.Point(55, 32);
            this.tbSite.MaxLength = 100;
            this.tbSite.Name = "tbSite";
            this.tbSite.Size = new System.Drawing.Size(347, 24);
            this.tbSite.TabIndex = 25;
            // 
            // lDVD
            // 
            this.lDVD.AutoSize = true;
            this.lDVD.Location = new System.Drawing.Point(9, 79);
            this.lDVD.Name = "lDVD";
            this.lDVD.Size = new System.Drawing.Size(154, 18);
            this.lDVD.TabIndex = 24;
            this.lDVD.Text = "Дата выхода на DVD";
            // 
            // lSite
            // 
            this.lSite.AutoSize = true;
            this.lSite.Location = new System.Drawing.Point(7, 35);
            this.lSite.Name = "lSite";
            this.lSite.Size = new System.Drawing.Size(42, 18);
            this.lSite.TabIndex = 23;
            this.lSite.Text = "Сайт";
            // 
            // lWriters
            // 
            this.lWriters.AutoSize = true;
            this.lWriters.Location = new System.Drawing.Point(809, 11);
            this.lWriters.Name = "lWriters";
            this.lWriters.Size = new System.Drawing.Size(75, 18);
            this.lWriters.TabIndex = 22;
            this.lWriters.Text = "Сценарий";
            // 
            // dGVWriter
            // 
            this.dGVWriter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVWriter.Location = new System.Drawing.Point(812, 32);
            this.dGVWriter.Name = "dGVWriter";
            this.dGVWriter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVWriter.Size = new System.Drawing.Size(363, 128);
            this.dGVWriter.TabIndex = 21;
            // 
            // lProduction
            // 
            this.lProduction.AutoSize = true;
            this.lProduction.Location = new System.Drawing.Point(809, 168);
            this.lProduction.Name = "lProduction";
            this.lProduction.Size = new System.Drawing.Size(169, 18);
            this.lProduction.TabIndex = 20;
            this.lProduction.Text = "Студия производитель";
            // 
            // dGVProduction
            // 
            this.dGVProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProduction.Location = new System.Drawing.Point(812, 189);
            this.dGVProduction.Name = "dGVProduction";
            this.dGVProduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVProduction.Size = new System.Drawing.Size(363, 128);
            this.dGVProduction.TabIndex = 19;
            // 
            // lActors
            // 
            this.lActors.AutoSize = true;
            this.lActors.Location = new System.Drawing.Point(421, 11);
            this.lActors.Name = "lActors";
            this.lActors.Size = new System.Drawing.Size(59, 18);
            this.lActors.TabIndex = 18;
            this.lActors.Text = "Актеры";
            // 
            // dGVActors
            // 
            this.dGVActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVActors.Location = new System.Drawing.Point(424, 32);
            this.dGVActors.Name = "dGVActors";
            this.dGVActors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVActors.Size = new System.Drawing.Size(359, 128);
            this.dGVActors.TabIndex = 17;
            // 
            // openPosterDialog
            // 
            this.openPosterDialog.FileName = "openFileDialog1";
            // 
            // FilmAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1190, 834);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FilmAddForm";
            this.Text = "Добавление нового фильма";
            this.Load += new System.EventHandler(this.FilmAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLanguage)).EndInit();
            this.gBMainParam.ResumeLayout(false);
            this.gBMainParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRuntime)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gBAdditionParam.ResumeLayout(false);
            this.gBAdditionParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMetaScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImdbVotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImdbRated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBoxOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWriter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVActors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.DataGridView dGVLanguage;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox gBMainParam;
        private System.Windows.Forms.NumericUpDown numericRuntime;
        private System.Windows.Forms.TextBox tbPlot;
        private System.Windows.Forms.Label lPlot;
        private System.Windows.Forms.DateTimePicker dTPReleased;
        private System.Windows.Forms.Label lRated;
        private System.Windows.Forms.Label lRuntime;
        private System.Windows.Forms.Label lReleased;
        private System.Windows.Forms.Label lDirector;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.Label lCountry;
        private System.Windows.Forms.Label lLanguage;
        private System.Windows.Forms.DataGridView dGVDirector;
        private System.Windows.Forms.DataGridView dGVCountry;
        private System.Windows.Forms.DataGridView dGVGenre;
        private System.Windows.Forms.TextBox tbRated;
        private System.Windows.Forms.CheckBox cBAdditionalParam;
        private System.Windows.Forms.Button buttonSelectPoster;
        private System.Windows.Forms.Label lPoster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gBAdditionParam;
        private System.Windows.Forms.TextBox tBAwards;
        private System.Windows.Forms.Label lAwards;
        private System.Windows.Forms.NumericUpDown numericMetaScore;
        private System.Windows.Forms.NumericUpDown numericImdbVotes;
        private System.Windows.Forms.NumericUpDown numericImdbRated;
        private System.Windows.Forms.Label lMetascore;
        private System.Windows.Forms.Label lImdbVotes;
        private System.Windows.Forms.Label lImdbRated;
        private System.Windows.Forms.NumericUpDown numericBoxOffice;
        private System.Windows.Forms.Label lBoxOffice;
        private System.Windows.Forms.DateTimePicker dTPDvd;
        private System.Windows.Forms.TextBox tbSite;
        private System.Windows.Forms.Label lDVD;
        private System.Windows.Forms.Label lSite;
        private System.Windows.Forms.Label lWriters;
        private System.Windows.Forms.DataGridView dGVWriter;
        private System.Windows.Forms.Label lProduction;
        private System.Windows.Forms.DataGridView dGVProduction;
        private System.Windows.Forms.Label lActors;
        private System.Windows.Forms.DataGridView dGVActors;
        private System.Windows.Forms.OpenFileDialog openPosterDialog;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonExit;
    }
}