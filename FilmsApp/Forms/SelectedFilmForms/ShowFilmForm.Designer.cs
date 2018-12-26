namespace FilmsApp.Forms.SelectedFilmForms
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
            this.numericRating = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tbDVD = new System.Windows.Forms.TextBox();
            this.lDVD = new System.Windows.Forms.Label();
            this.tbAwards = new System.Windows.Forms.TextBox();
            this.lAwards = new System.Windows.Forms.Label();
            this.tbMetaScore = new System.Windows.Forms.TextBox();
            this.tbBoxOffice = new System.Windows.Forms.TextBox();
            this.lMetascore = new System.Windows.Forms.Label();
            this.lBoxOffice = new System.Windows.Forms.Label();
            this.tbProduction = new System.Windows.Forms.TextBox();
            this.lProduction = new System.Windows.Forms.Label();
            this.tbWebSite = new System.Windows.Forms.TextBox();
            this.lWebSite = new System.Windows.Forms.Label();
            this.tbYearReleased = new System.Windows.Forms.TextBox();
            this.lYear = new System.Windows.Forms.Label();
            this.tbWriters = new System.Windows.Forms.TextBox();
            this.lWriters = new System.Windows.Forms.Label();
            this.lActors = new System.Windows.Forms.Label();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.picturePoster = new System.Windows.Forms.PictureBox();
            this.lPlot = new System.Windows.Forms.Label();
            this.tbPlot = new System.Windows.Forms.TextBox();
            this.tbImdbVotes = new System.Windows.Forms.TextBox();
            this.tbImdbRated = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbRated = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbRuntime = new System.Windows.Forms.TextBox();
            this.tbReleased = new System.Windows.Forms.TextBox();
            this.lRating = new System.Windows.Forms.Label();
            this.lDateReleased = new System.Windows.Forms.Label();
            this.lRuntime = new System.Windows.Forms.Label();
            this.lGenre = new System.Windows.Forms.Label();
            this.lRated = new System.Windows.Forms.Label();
            this.lDirector = new System.Windows.Forms.Label();
            this.lLanguage = new System.Windows.Forms.Label();
            this.lCountry = new System.Windows.Forms.Label();
            this.lImdbRating = new System.Windows.Forms.Label();
            this.lImdbVotes = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.tableLP_info = new System.Windows.Forms.TableLayoutPanel();
            this.buttonShowFeedBack = new System.Windows.Forms.Button();
            this.buttonAddFeedBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.tableLP_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericRating
            // 
            this.numericRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.numericRating.DecimalPlaces = 2;
            this.numericRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericRating.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.numericRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericRating.Location = new System.Drawing.Point(144, 372);
            this.numericRating.Margin = new System.Windows.Forms.Padding(4);
            this.numericRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericRating.Name = "numericRating";
            this.numericRating.Size = new System.Drawing.Size(198, 28);
            this.numericRating.TabIndex = 49;
            this.numericRating.ValueChanged += new System.EventHandler(this.numericRating_ValueChanged);
            // 
            // groupBox1
            // 
            this.tableLP_info.SetColumnSpan(this.groupBox1, 4);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonShowFeedBack);
            this.groupBox1.Controls.Add(this.buttonAddFeedBack);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(1, 585);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(799, 71);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxIcon
            // 
            this.tableLP_info.SetColumnSpan(this.pictureBoxIcon, 2);
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxIcon.Location = new System.Drawing.Point(805, 540);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.tableLP_info.SetRowSpan(this.pictureBoxIcon, 2);
            this.pictureBoxIcon.Size = new System.Drawing.Size(498, 112);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 26;
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(619, 21);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(136, 38);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tbDVD
            // 
            this.tbDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbDVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDVD.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbDVD.Location = new System.Drawing.Point(953, 490);
            this.tbDVD.Margin = new System.Windows.Forms.Padding(4);
            this.tbDVD.Multiline = true;
            this.tbDVD.Name = "tbDVD";
            this.tbDVD.ReadOnly = true;
            this.tbDVD.Size = new System.Drawing.Size(350, 41);
            this.tbDVD.TabIndex = 40;
            this.tbDVD.TabStop = false;
            this.tbDVD.Visible = false;
            // 
            // lDVD
            // 
            this.lDVD.AutoSize = true;
            this.lDVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDVD.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDVD.Location = new System.Drawing.Point(805, 486);
            this.lDVD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDVD.Name = "lDVD";
            this.lDVD.Size = new System.Drawing.Size(140, 49);
            this.lDVD.TabIndex = 17;
            this.lDVD.Text = "Дата выхода на DVD:";
            this.lDVD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lDVD.Visible = false;
            // 
            // tbAwards
            // 
            this.tbAwards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAwards.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbAwards.Location = new System.Drawing.Point(953, 153);
            this.tbAwards.Margin = new System.Windows.Forms.Padding(4);
            this.tbAwards.Multiline = true;
            this.tbAwards.Name = "tbAwards";
            this.tbAwards.ReadOnly = true;
            this.tbAwards.Size = new System.Drawing.Size(350, 103);
            this.tbAwards.TabIndex = 44;
            this.tbAwards.TabStop = false;
            this.tbAwards.Visible = false;
            // 
            // lAwards
            // 
            this.lAwards.AutoSize = true;
            this.lAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAwards.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAwards.Location = new System.Drawing.Point(805, 149);
            this.lAwards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAwards.Name = "lAwards";
            this.lAwards.Size = new System.Drawing.Size(140, 111);
            this.lAwards.TabIndex = 13;
            this.lAwards.Text = "Награды:";
            this.lAwards.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lAwards.Visible = false;
            // 
            // tbMetaScore
            // 
            this.tbMetaScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbMetaScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMetaScore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbMetaScore.Location = new System.Drawing.Point(144, 539);
            this.tbMetaScore.Margin = new System.Windows.Forms.Padding(4);
            this.tbMetaScore.Multiline = true;
            this.tbMetaScore.Name = "tbMetaScore";
            this.tbMetaScore.ReadOnly = true;
            this.tbMetaScore.Size = new System.Drawing.Size(198, 41);
            this.tbMetaScore.TabIndex = 47;
            this.tbMetaScore.TabStop = false;
            this.tbMetaScore.Visible = false;
            // 
            // tbBoxOffice
            // 
            this.tbBoxOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbBoxOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBoxOffice.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbBoxOffice.Location = new System.Drawing.Point(953, 372);
            this.tbBoxOffice.Margin = new System.Windows.Forms.Padding(4);
            this.tbBoxOffice.Multiline = true;
            this.tbBoxOffice.Name = "tbBoxOffice";
            this.tbBoxOffice.ReadOnly = true;
            this.tbBoxOffice.Size = new System.Drawing.Size(350, 32);
            this.tbBoxOffice.TabIndex = 46;
            this.tbBoxOffice.TabStop = false;
            this.tbBoxOffice.Visible = false;
            // 
            // lMetascore
            // 
            this.lMetascore.AutoSize = true;
            this.lMetascore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lMetascore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMetascore.Location = new System.Drawing.Point(4, 535);
            this.lMetascore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMetascore.Name = "lMetascore";
            this.lMetascore.Size = new System.Drawing.Size(132, 49);
            this.lMetascore.TabIndex = 21;
            this.lMetascore.Text = "Metascore:";
            this.lMetascore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lMetascore.Visible = false;
            // 
            // lBoxOffice
            // 
            this.lBoxOffice.AutoSize = true;
            this.lBoxOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxOffice.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBoxOffice.Location = new System.Drawing.Point(805, 368);
            this.lBoxOffice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBoxOffice.Name = "lBoxOffice";
            this.lBoxOffice.Size = new System.Drawing.Size(140, 40);
            this.lBoxOffice.TabIndex = 18;
            this.lBoxOffice.Text = "Кассовые сборы:";
            this.lBoxOffice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lBoxOffice.Visible = false;
            // 
            // tbProduction
            // 
            this.tbProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProduction.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbProduction.Location = new System.Drawing.Point(953, 264);
            this.tbProduction.Margin = new System.Windows.Forms.Padding(4);
            this.tbProduction.Multiline = true;
            this.tbProduction.Name = "tbProduction";
            this.tbProduction.ReadOnly = true;
            this.tableLP_info.SetRowSpan(this.tbProduction, 2);
            this.tbProduction.Size = new System.Drawing.Size(350, 100);
            this.tbProduction.TabIndex = 41;
            this.tbProduction.TabStop = false;
            this.tbProduction.Visible = false;
            // 
            // lProduction
            // 
            this.lProduction.AutoSize = true;
            this.lProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lProduction.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProduction.Location = new System.Drawing.Point(805, 260);
            this.lProduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProduction.Name = "lProduction";
            this.tableLP_info.SetRowSpan(this.lProduction, 2);
            this.lProduction.Size = new System.Drawing.Size(140, 108);
            this.lProduction.TabIndex = 19;
            this.lProduction.Text = "Студия производитель:";
            this.lProduction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lProduction.Visible = false;
            // 
            // tbWebSite
            // 
            this.tbWebSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWebSite.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbWebSite.Location = new System.Drawing.Point(953, 412);
            this.tbWebSite.Margin = new System.Windows.Forms.Padding(4);
            this.tbWebSite.Multiline = true;
            this.tbWebSite.Name = "tbWebSite";
            this.tbWebSite.ReadOnly = true;
            this.tbWebSite.Size = new System.Drawing.Size(350, 31);
            this.tbWebSite.TabIndex = 28;
            this.tbWebSite.TabStop = false;
            this.tbWebSite.Visible = false;
            // 
            // lWebSite
            // 
            this.lWebSite.AutoSize = true;
            this.lWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWebSite.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWebSite.Location = new System.Drawing.Point(805, 408);
            this.lWebSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWebSite.Name = "lWebSite";
            this.lWebSite.Size = new System.Drawing.Size(140, 39);
            this.lWebSite.TabIndex = 16;
            this.lWebSite.Text = "Сайт:";
            this.lWebSite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lWebSite.Visible = false;
            // 
            // tbYearReleased
            // 
            this.tbYearReleased.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbYearReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbYearReleased.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbYearReleased.Location = new System.Drawing.Point(953, 451);
            this.tbYearReleased.Margin = new System.Windows.Forms.Padding(4);
            this.tbYearReleased.Multiline = true;
            this.tbYearReleased.Name = "tbYearReleased";
            this.tbYearReleased.ReadOnly = true;
            this.tbYearReleased.Size = new System.Drawing.Size(350, 31);
            this.tbYearReleased.TabIndex = 39;
            this.tbYearReleased.TabStop = false;
            this.tbYearReleased.Visible = false;
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lYear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lYear.Location = new System.Drawing.Point(805, 447);
            this.lYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(140, 39);
            this.lYear.TabIndex = 2;
            this.lYear.Text = "Год:";
            this.lYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lYear.Visible = false;
            // 
            // tbWriters
            // 
            this.tbWriters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWriters.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbWriters.Location = new System.Drawing.Point(953, 4);
            this.tbWriters.Margin = new System.Windows.Forms.Padding(4);
            this.tbWriters.Multiline = true;
            this.tbWriters.Name = "tbWriters";
            this.tbWriters.ReadOnly = true;
            this.tbWriters.Size = new System.Drawing.Size(350, 141);
            this.tbWriters.TabIndex = 43;
            this.tbWriters.TabStop = false;
            this.tbWriters.Visible = false;
            // 
            // lWriters
            // 
            this.lWriters.AutoSize = true;
            this.lWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWriters.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWriters.Location = new System.Drawing.Point(805, 0);
            this.lWriters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWriters.Name = "lWriters";
            this.lWriters.Size = new System.Drawing.Size(140, 149);
            this.lWriters.TabIndex = 15;
            this.lWriters.Text = "Сценарий:";
            this.lWriters.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lWriters.Visible = false;
            // 
            // lActors
            // 
            this.lActors.AutoSize = true;
            this.lActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lActors.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lActors.Location = new System.Drawing.Point(350, 149);
            this.lActors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lActors.Name = "lActors";
            this.lActors.Size = new System.Drawing.Size(91, 111);
            this.lActors.TabIndex = 14;
            this.lActors.Text = "Актеры:";
            this.lActors.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lActors.Visible = false;
            // 
            // tbActors
            // 
            this.tbActors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbActors.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbActors.Location = new System.Drawing.Point(449, 153);
            this.tbActors.Margin = new System.Windows.Forms.Padding(4);
            this.tbActors.Multiline = true;
            this.tbActors.Name = "tbActors";
            this.tbActors.ReadOnly = true;
            this.tbActors.Size = new System.Drawing.Size(348, 103);
            this.tbActors.TabIndex = 42;
            this.tbActors.TabStop = false;
            this.tbActors.Visible = false;
            // 
            // picturePoster
            // 
            this.tableLP_info.SetColumnSpan(this.picturePoster, 2);
            this.picturePoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePoster.Location = new System.Drawing.Point(4, 4);
            this.picturePoster.Margin = new System.Windows.Forms.Padding(4);
            this.picturePoster.Name = "picturePoster";
            this.tableLP_info.SetRowSpan(this.picturePoster, 3);
            this.picturePoster.Size = new System.Drawing.Size(338, 301);
            this.picturePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePoster.TabIndex = 1;
            this.picturePoster.TabStop = false;
            this.picturePoster.Click += new System.EventHandler(this.picturePoster_Click);
            // 
            // lPlot
            // 
            this.lPlot.AutoSize = true;
            this.lPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lPlot.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPlot.Location = new System.Drawing.Point(350, 0);
            this.lPlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlot.Name = "lPlot";
            this.lPlot.Size = new System.Drawing.Size(91, 149);
            this.lPlot.TabIndex = 12;
            this.lPlot.Text = "Описание:";
            this.lPlot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbPlot
            // 
            this.tbPlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPlot.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbPlot.Location = new System.Drawing.Point(449, 4);
            this.tbPlot.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlot.Multiline = true;
            this.tbPlot.Name = "tbPlot";
            this.tbPlot.ReadOnly = true;
            this.tbPlot.Size = new System.Drawing.Size(348, 141);
            this.tbPlot.TabIndex = 38;
            this.tbPlot.TabStop = false;
            // 
            // tbImdbVotes
            // 
            this.tbImdbVotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbImdbVotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbImdbVotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbImdbVotes.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbImdbVotes.Location = new System.Drawing.Point(449, 490);
            this.tbImdbVotes.Margin = new System.Windows.Forms.Padding(4);
            this.tbImdbVotes.Multiline = true;
            this.tbImdbVotes.Name = "tbImdbVotes";
            this.tbImdbVotes.ReadOnly = true;
            this.tbImdbVotes.Size = new System.Drawing.Size(348, 41);
            this.tbImdbVotes.TabIndex = 37;
            this.tbImdbVotes.TabStop = false;
            this.tbImdbVotes.Visible = false;
            // 
            // tbImdbRated
            // 
            this.tbImdbRated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbImdbRated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbImdbRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbImdbRated.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbImdbRated.Location = new System.Drawing.Point(449, 539);
            this.tbImdbRated.Margin = new System.Windows.Forms.Padding(4);
            this.tbImdbRated.Multiline = true;
            this.tbImdbRated.Name = "tbImdbRated";
            this.tbImdbRated.ReadOnly = true;
            this.tbImdbRated.Size = new System.Drawing.Size(348, 41);
            this.tbImdbRated.TabIndex = 36;
            this.tbImdbRated.TabStop = false;
            this.tbImdbRated.Visible = false;
            // 
            // tbCountry
            // 
            this.tbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCountry.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbCountry.Location = new System.Drawing.Point(449, 451);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.tbCountry.Multiline = true;
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.ReadOnly = true;
            this.tbCountry.Size = new System.Drawing.Size(348, 31);
            this.tbCountry.TabIndex = 35;
            this.tbCountry.TabStop = false;
            // 
            // tbLanguage
            // 
            this.tbLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLanguage.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbLanguage.Location = new System.Drawing.Point(449, 412);
            this.tbLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.tbLanguage.Multiline = true;
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.ReadOnly = true;
            this.tbLanguage.Size = new System.Drawing.Size(348, 31);
            this.tbLanguage.TabIndex = 34;
            this.tbLanguage.TabStop = false;
            // 
            // tbDirector
            // 
            this.tbDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbDirector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDirector.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbDirector.Location = new System.Drawing.Point(449, 264);
            this.tbDirector.Margin = new System.Windows.Forms.Padding(4);
            this.tbDirector.Multiline = true;
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.ReadOnly = true;
            this.tableLP_info.SetRowSpan(this.tbDirector, 2);
            this.tbDirector.Size = new System.Drawing.Size(348, 100);
            this.tbDirector.TabIndex = 33;
            this.tbDirector.TabStop = false;
            // 
            // tbRated
            // 
            this.tbRated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbRated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRated.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbRated.Location = new System.Drawing.Point(144, 490);
            this.tbRated.Margin = new System.Windows.Forms.Padding(4);
            this.tbRated.Multiline = true;
            this.tbRated.Name = "tbRated";
            this.tbRated.ReadOnly = true;
            this.tbRated.Size = new System.Drawing.Size(198, 41);
            this.tbRated.TabIndex = 32;
            this.tbRated.TabStop = false;
            // 
            // tbGenre
            // 
            this.tbGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGenre.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbGenre.Location = new System.Drawing.Point(449, 372);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.tbGenre.Multiline = true;
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.ReadOnly = true;
            this.tbGenre.Size = new System.Drawing.Size(348, 32);
            this.tbGenre.TabIndex = 31;
            this.tbGenre.TabStop = false;
            // 
            // tbRuntime
            // 
            this.tbRuntime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbRuntime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRuntime.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbRuntime.Location = new System.Drawing.Point(144, 451);
            this.tbRuntime.Margin = new System.Windows.Forms.Padding(4);
            this.tbRuntime.Multiline = true;
            this.tbRuntime.Name = "tbRuntime";
            this.tbRuntime.ReadOnly = true;
            this.tbRuntime.Size = new System.Drawing.Size(198, 31);
            this.tbRuntime.TabIndex = 30;
            this.tbRuntime.TabStop = false;
            // 
            // tbReleased
            // 
            this.tbReleased.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbReleased.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReleased.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbReleased.Location = new System.Drawing.Point(144, 412);
            this.tbReleased.Margin = new System.Windows.Forms.Padding(4);
            this.tbReleased.Multiline = true;
            this.tbReleased.Name = "tbReleased";
            this.tbReleased.ReadOnly = true;
            this.tbReleased.Size = new System.Drawing.Size(198, 31);
            this.tbReleased.TabIndex = 29;
            this.tbReleased.TabStop = false;
            // 
            // lRating
            // 
            this.lRating.AutoSize = true;
            this.lRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRating.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRating.Location = new System.Drawing.Point(4, 368);
            this.lRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRating.Name = "lRating";
            this.lRating.Size = new System.Drawing.Size(132, 40);
            this.lRating.TabIndex = 11;
            this.lRating.Text = "Рейтинг:";
            this.lRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lDateReleased
            // 
            this.lDateReleased.AutoSize = true;
            this.lDateReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDateReleased.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateReleased.Location = new System.Drawing.Point(4, 408);
            this.lDateReleased.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDateReleased.Name = "lDateReleased";
            this.lDateReleased.Size = new System.Drawing.Size(132, 39);
            this.lDateReleased.TabIndex = 5;
            this.lDateReleased.Text = "Дата выхода:";
            this.lDateReleased.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lRuntime
            // 
            this.lRuntime.AutoSize = true;
            this.lRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRuntime.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRuntime.Location = new System.Drawing.Point(4, 447);
            this.lRuntime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRuntime.Name = "lRuntime";
            this.lRuntime.Size = new System.Drawing.Size(132, 39);
            this.lRuntime.TabIndex = 6;
            this.lRuntime.Text = "Длительность:";
            this.lRuntime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lGenre.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGenre.Location = new System.Drawing.Point(350, 368);
            this.lGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(91, 40);
            this.lGenre.TabIndex = 7;
            this.lGenre.Text = "Жанр:";
            this.lGenre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lRated
            // 
            this.lRated.AutoSize = true;
            this.lRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRated.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRated.Location = new System.Drawing.Point(4, 486);
            this.lRated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRated.Name = "lRated";
            this.lRated.Size = new System.Drawing.Size(132, 49);
            this.lRated.TabIndex = 10;
            this.lRated.Text = "Возрастной рейтинг:";
            this.lRated.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lDirector
            // 
            this.lDirector.AutoSize = true;
            this.lDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDirector.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDirector.Location = new System.Drawing.Point(350, 260);
            this.lDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDirector.Name = "lDirector";
            this.tableLP_info.SetRowSpan(this.lDirector, 2);
            this.lDirector.Size = new System.Drawing.Size(91, 108);
            this.lDirector.TabIndex = 9;
            this.lDirector.Text = "Режиссёр:";
            this.lDirector.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLanguage.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLanguage.Location = new System.Drawing.Point(350, 408);
            this.lLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(91, 39);
            this.lLanguage.TabIndex = 20;
            this.lLanguage.Text = "Язык:";
            this.lLanguage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCountry.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountry.Location = new System.Drawing.Point(350, 447);
            this.lCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(91, 39);
            this.lCountry.TabIndex = 8;
            this.lCountry.Text = "Страна:";
            this.lCountry.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lImdbRating
            // 
            this.lImdbRating.AutoSize = true;
            this.lImdbRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lImdbRating.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lImdbRating.Location = new System.Drawing.Point(350, 535);
            this.lImdbRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lImdbRating.Name = "lImdbRating";
            this.lImdbRating.Size = new System.Drawing.Size(91, 49);
            this.lImdbRating.TabIndex = 22;
            this.lImdbRating.Text = "IMDB рейтинг:";
            this.lImdbRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lImdbRating.Visible = false;
            // 
            // lImdbVotes
            // 
            this.lImdbVotes.AutoSize = true;
            this.lImdbVotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lImdbVotes.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lImdbVotes.Location = new System.Drawing.Point(350, 486);
            this.lImdbVotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lImdbVotes.Name = "lImdbVotes";
            this.lImdbVotes.Size = new System.Drawing.Size(91, 49);
            this.lImdbVotes.TabIndex = 27;
            this.lImdbVotes.Text = "IMDB голоса:";
            this.lImdbVotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lImdbVotes.Visible = false;
            // 
            // lTitle
            // 
            this.tableLP_info.SetColumnSpan(this.lTitle, 2);
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.Location = new System.Drawing.Point(7, 316);
            this.lTitle.Margin = new System.Windows.Forms.Padding(7);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(332, 45);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Название";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLP_info
            // 
            this.tableLP_info.ColumnCount = 6;
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.46921F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.53079F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLP_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.tableLP_info.Controls.Add(this.lRated, 0, 7);
            this.tableLP_info.Controls.Add(this.tbRated, 1, 7);
            this.tableLP_info.Controls.Add(this.picturePoster, 0, 0);
            this.tableLP_info.Controls.Add(this.lTitle, 0, 3);
            this.tableLP_info.Controls.Add(this.lDateReleased, 0, 5);
            this.tableLP_info.Controls.Add(this.tbReleased, 1, 5);
            this.tableLP_info.Controls.Add(this.lRating, 0, 4);
            this.tableLP_info.Controls.Add(this.numericRating, 1, 4);
            this.tableLP_info.Controls.Add(this.lRuntime, 0, 6);
            this.tableLP_info.Controls.Add(this.tbRuntime, 1, 6);
            this.tableLP_info.Controls.Add(this.lMetascore, 0, 8);
            this.tableLP_info.Controls.Add(this.tbMetaScore, 1, 8);
            this.tableLP_info.Controls.Add(this.lGenre, 2, 4);
            this.tableLP_info.Controls.Add(this.tbGenre, 3, 4);
            this.tableLP_info.Controls.Add(this.lLanguage, 2, 5);
            this.tableLP_info.Controls.Add(this.tbLanguage, 3, 5);
            this.tableLP_info.Controls.Add(this.lCountry, 2, 6);
            this.tableLP_info.Controls.Add(this.tbCountry, 3, 6);
            this.tableLP_info.Controls.Add(this.lPlot, 2, 0);
            this.tableLP_info.Controls.Add(this.tbPlot, 3, 0);
            this.tableLP_info.Controls.Add(this.lActors, 2, 1);
            this.tableLP_info.Controls.Add(this.tbActors, 3, 1);
            this.tableLP_info.Controls.Add(this.lImdbVotes, 2, 7);
            this.tableLP_info.Controls.Add(this.tbImdbVotes, 3, 7);
            this.tableLP_info.Controls.Add(this.tbWriters, 5, 0);
            this.tableLP_info.Controls.Add(this.lWriters, 4, 0);
            this.tableLP_info.Controls.Add(this.lDirector, 2, 2);
            this.tableLP_info.Controls.Add(this.tbDirector, 3, 2);
            this.tableLP_info.Controls.Add(this.lAwards, 4, 1);
            this.tableLP_info.Controls.Add(this.tbAwards, 5, 1);
            this.tableLP_info.Controls.Add(this.lProduction, 4, 2);
            this.tableLP_info.Controls.Add(this.tbProduction, 5, 2);
            this.tableLP_info.Controls.Add(this.lBoxOffice, 4, 4);
            this.tableLP_info.Controls.Add(this.tbBoxOffice, 5, 4);
            this.tableLP_info.Controls.Add(this.lWebSite, 4, 5);
            this.tableLP_info.Controls.Add(this.tbWebSite, 5, 5);
            this.tableLP_info.Controls.Add(this.lYear, 4, 6);
            this.tableLP_info.Controls.Add(this.tbYearReleased, 5, 6);
            this.tableLP_info.Controls.Add(this.lImdbRating, 2, 8);
            this.tableLP_info.Controls.Add(this.tbImdbRated, 3, 8);
            this.tableLP_info.Controls.Add(this.lDVD, 4, 7);
            this.tableLP_info.Controls.Add(this.tbDVD, 5, 7);
            this.tableLP_info.Controls.Add(this.groupBox1, 0, 9);
            this.tableLP_info.Controls.Add(this.pictureBoxIcon, 4, 8);
            this.tableLP_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLP_info.Location = new System.Drawing.Point(0, 0);
            this.tableLP_info.Margin = new System.Windows.Forms.Padding(4);
            this.tableLP_info.Name = "tableLP_info";
            this.tableLP_info.RowCount = 10;
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.09039F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLP_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLP_info.Size = new System.Drawing.Size(1307, 657);
            this.tableLP_info.TabIndex = 23;
            // 
            // buttonShowFeedBack
            // 
            this.buttonShowFeedBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonShowFeedBack.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowFeedBack.Location = new System.Drawing.Point(208, 21);
            this.buttonShowFeedBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowFeedBack.Name = "buttonShowFeedBack";
            this.buttonShowFeedBack.Size = new System.Drawing.Size(348, 38);
            this.buttonShowFeedBack.TabIndex = 3;
            this.buttonShowFeedBack.Text = "Посмотреть отзывы посетителей";
            this.buttonShowFeedBack.UseVisualStyleBackColor = false;
            this.buttonShowFeedBack.Click += new System.EventHandler(this.buttonShowFeedBack_Click);
            // 
            // buttonAddFeedBack
            // 
            this.buttonAddFeedBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonAddFeedBack.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddFeedBack.Location = new System.Drawing.Point(12, 21);
            this.buttonAddFeedBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddFeedBack.Name = "buttonAddFeedBack";
            this.buttonAddFeedBack.Size = new System.Drawing.Size(141, 38);
            this.buttonAddFeedBack.TabIndex = 2;
            this.buttonAddFeedBack.Text = "Оставить отзыв";
            this.buttonAddFeedBack.UseVisualStyleBackColor = false;
            this.buttonAddFeedBack.Click += new System.EventHandler(this.buttonAddFeedBack_Click);
            // 
            // ShowFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 657);
            this.Controls.Add(this.tableLP_info);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ShowFilmForm";
            this.Text = "Просмотр информации по фильму";
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.tableLP_info.ResumeLayout(false);
            this.tableLP_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericRating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLP_info;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lImdbVotes;
        private System.Windows.Forms.Label lImdbRating;
        private System.Windows.Forms.Label lCountry;
        private System.Windows.Forms.Label lLanguage;
        private System.Windows.Forms.Label lDirector;
        private System.Windows.Forms.Label lRated;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.Label lRuntime;
        private System.Windows.Forms.Label lDateReleased;
        private System.Windows.Forms.Label lRating;
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
        private System.Windows.Forms.Label lPlot;
        private System.Windows.Forms.PictureBox picturePoster;
        private System.Windows.Forms.TextBox tbActors;
        private System.Windows.Forms.Label lActors;
        private System.Windows.Forms.Label lWriters;
        private System.Windows.Forms.TextBox tbWriters;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.TextBox tbYearReleased;
        private System.Windows.Forms.Label lWebSite;
        private System.Windows.Forms.TextBox tbWebSite;
        private System.Windows.Forms.Label lProduction;
        private System.Windows.Forms.TextBox tbProduction;
        private System.Windows.Forms.Label lBoxOffice;
        private System.Windows.Forms.Label lMetascore;
        private System.Windows.Forms.TextBox tbBoxOffice;
        private System.Windows.Forms.TextBox tbMetaScore;
        private System.Windows.Forms.Label lAwards;
        private System.Windows.Forms.TextBox tbAwards;
        private System.Windows.Forms.Label lDVD;
        private System.Windows.Forms.TextBox tbDVD;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonShowFeedBack;
        private System.Windows.Forms.Button buttonAddFeedBack;
    }
}