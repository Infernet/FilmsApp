namespace FilmsApp.Forms.Base
{
    partial class MovieFilterForm
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
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.checkEnableGenre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkEnableCountry = new System.Windows.Forms.CheckBox();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkEnableDirector = new System.Windows.Forms.CheckBox();
            this.comboDirector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkEnableLanguage = new System.Windows.Forms.CheckBox();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkEnableRated = new System.Windows.Forms.CheckBox();
            this.comboRated = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.checkEnableYear = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // comboGenre
            // 
            this.comboGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.Enabled = false;
            this.comboGenre.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(229, 44);
            this.comboGenre.Margin = new System.Windows.Forms.Padding(4);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(277, 28);
            this.comboGenre.TabIndex = 0;
            // 
            // checkEnableGenre
            // 
            this.checkEnableGenre.AutoSize = true;
            this.checkEnableGenre.Location = new System.Drawing.Point(207, 52);
            this.checkEnableGenre.Margin = new System.Windows.Forms.Padding(4);
            this.checkEnableGenre.Name = "checkEnableGenre";
            this.checkEnableGenre.Size = new System.Drawing.Size(15, 14);
            this.checkEnableGenre.TabIndex = 1;
            this.checkEnableGenre.UseVisualStyleBackColor = true;
            this.checkEnableGenre.CheckedChanged += new System.EventHandler(this.checkEnableGenre_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(226, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(226, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Страна";
            // 
            // checkEnableCountry
            // 
            this.checkEnableCountry.AutoSize = true;
            this.checkEnableCountry.Location = new System.Drawing.Point(207, 110);
            this.checkEnableCountry.Margin = new System.Windows.Forms.Padding(4);
            this.checkEnableCountry.Name = "checkEnableCountry";
            this.checkEnableCountry.Size = new System.Drawing.Size(15, 14);
            this.checkEnableCountry.TabIndex = 4;
            this.checkEnableCountry.UseVisualStyleBackColor = true;
            this.checkEnableCountry.CheckedChanged += new System.EventHandler(this.checkEnableCountry_CheckedChanged);
            // 
            // comboCountry
            // 
            this.comboCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.comboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCountry.Enabled = false;
            this.comboCountry.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Location = new System.Drawing.Point(230, 102);
            this.comboCountry.Margin = new System.Windows.Forms.Padding(4);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(276, 28);
            this.comboCountry.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(226, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Режиссёр";
            // 
            // checkEnableDirector
            // 
            this.checkEnableDirector.AutoSize = true;
            this.checkEnableDirector.Location = new System.Drawing.Point(207, 166);
            this.checkEnableDirector.Margin = new System.Windows.Forms.Padding(4);
            this.checkEnableDirector.Name = "checkEnableDirector";
            this.checkEnableDirector.Size = new System.Drawing.Size(15, 14);
            this.checkEnableDirector.TabIndex = 7;
            this.checkEnableDirector.UseVisualStyleBackColor = true;
            this.checkEnableDirector.CheckedChanged += new System.EventHandler(this.checkEnableDirector_CheckedChanged);
            // 
            // comboDirector
            // 
            this.comboDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.comboDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDirector.Enabled = false;
            this.comboDirector.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboDirector.FormattingEnabled = true;
            this.comboDirector.Location = new System.Drawing.Point(230, 158);
            this.comboDirector.Margin = new System.Windows.Forms.Padding(4);
            this.comboDirector.Name = "comboDirector";
            this.comboDirector.Size = new System.Drawing.Size(276, 28);
            this.comboDirector.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(226, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Язык";
            // 
            // checkEnableLanguage
            // 
            this.checkEnableLanguage.AutoSize = true;
            this.checkEnableLanguage.Location = new System.Drawing.Point(207, 224);
            this.checkEnableLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.checkEnableLanguage.Name = "checkEnableLanguage";
            this.checkEnableLanguage.Size = new System.Drawing.Size(15, 14);
            this.checkEnableLanguage.TabIndex = 10;
            this.checkEnableLanguage.UseVisualStyleBackColor = true;
            this.checkEnableLanguage.CheckedChanged += new System.EventHandler(this.checkEnableLanguage_CheckedChanged);
            // 
            // comboLanguage
            // 
            this.comboLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.Enabled = false;
            this.comboLanguage.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Location = new System.Drawing.Point(230, 216);
            this.comboLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(276, 28);
            this.comboLanguage.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(226, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Возрастной рейтинг";
            // 
            // checkEnableRated
            // 
            this.checkEnableRated.AutoSize = true;
            this.checkEnableRated.Location = new System.Drawing.Point(206, 288);
            this.checkEnableRated.Margin = new System.Windows.Forms.Padding(4);
            this.checkEnableRated.Name = "checkEnableRated";
            this.checkEnableRated.Size = new System.Drawing.Size(15, 14);
            this.checkEnableRated.TabIndex = 13;
            this.checkEnableRated.UseVisualStyleBackColor = true;
            this.checkEnableRated.CheckedChanged += new System.EventHandler(this.checkEnableRated_CheckedChanged);
            // 
            // comboRated
            // 
            this.comboRated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.comboRated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRated.Enabled = false;
            this.comboRated.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboRated.FormattingEnabled = true;
            this.comboRated.Location = new System.Drawing.Point(230, 280);
            this.comboRated.Margin = new System.Windows.Forms.Padding(4);
            this.comboRated.Name = "comboRated";
            this.comboRated.Size = new System.Drawing.Size(276, 28);
            this.comboRated.TabIndex = 12;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.Location = new System.Drawing.Point(28, 396);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(158, 40);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.Text = "Принять";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReset.Location = new System.Drawing.Point(207, 396);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(143, 40);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // numericYear
            // 
            this.numericYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.numericYear.Enabled = false;
            this.numericYear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericYear.Location = new System.Drawing.Point(229, 338);
            this.numericYear.Margin = new System.Windows.Forms.Padding(4);
            this.numericYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(277, 28);
            this.numericYear.TabIndex = 17;
            this.numericYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // checkEnableYear
            // 
            this.checkEnableYear.AutoSize = true;
            this.checkEnableYear.Location = new System.Drawing.Point(206, 345);
            this.checkEnableYear.Margin = new System.Windows.Forms.Padding(4);
            this.checkEnableYear.Name = "checkEnableYear";
            this.checkEnableYear.Size = new System.Drawing.Size(15, 14);
            this.checkEnableYear.TabIndex = 18;
            this.checkEnableYear.UseVisualStyleBackColor = true;
            this.checkEnableYear.CheckedChanged += new System.EventHandler(this.checkEnableYear_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(226, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Год выхода";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(366, 396);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 40);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(13, 18);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(185, 341);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 26;
            this.pictureBoxIcon.TabStop = false;
            // 
            // MovieFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 448);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkEnableYear);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkEnableRated);
            this.Controls.Add(this.comboRated);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkEnableLanguage);
            this.Controls.Add(this.comboLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkEnableDirector);
            this.Controls.Add(this.comboDirector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkEnableCountry);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkEnableGenre);
            this.Controls.Add(this.comboGenre);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MovieFilterForm";
            this.ShowInTaskbar = false;
            this.Text = "Фильтр";
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.CheckBox checkEnableGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkEnableCountry;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkEnableDirector;
        private System.Windows.Forms.ComboBox comboDirector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkEnableLanguage;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkEnableRated;
        private System.Windows.Forms.ComboBox comboRated;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.CheckBox checkEnableYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
    }
}