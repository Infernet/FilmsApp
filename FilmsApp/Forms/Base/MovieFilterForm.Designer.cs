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
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            this.SuspendLayout();
            // 
            // comboGenre
            // 
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.Enabled = false;
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(33, 25);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(208, 21);
            this.comboGenre.TabIndex = 0;
            // 
            // checkEnableGenre
            // 
            this.checkEnableGenre.AutoSize = true;
            this.checkEnableGenre.Location = new System.Drawing.Point(12, 28);
            this.checkEnableGenre.Name = "checkEnableGenre";
            this.checkEnableGenre.Size = new System.Drawing.Size(15, 14);
            this.checkEnableGenre.TabIndex = 1;
            this.checkEnableGenre.UseVisualStyleBackColor = true;
            this.checkEnableGenre.CheckedChanged += new System.EventHandler(this.checkEnableGenre_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Страна";
            // 
            // checkEnableCountry
            // 
            this.checkEnableCountry.AutoSize = true;
            this.checkEnableCountry.Location = new System.Drawing.Point(12, 68);
            this.checkEnableCountry.Name = "checkEnableCountry";
            this.checkEnableCountry.Size = new System.Drawing.Size(15, 14);
            this.checkEnableCountry.TabIndex = 4;
            this.checkEnableCountry.UseVisualStyleBackColor = true;
            this.checkEnableCountry.CheckedChanged += new System.EventHandler(this.checkEnableCountry_CheckedChanged);
            // 
            // comboCountry
            // 
            this.comboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCountry.Enabled = false;
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Location = new System.Drawing.Point(33, 65);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(208, 21);
            this.comboCountry.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Режиссёр";
            // 
            // checkEnableDirector
            // 
            this.checkEnableDirector.AutoSize = true;
            this.checkEnableDirector.Location = new System.Drawing.Point(12, 108);
            this.checkEnableDirector.Name = "checkEnableDirector";
            this.checkEnableDirector.Size = new System.Drawing.Size(15, 14);
            this.checkEnableDirector.TabIndex = 7;
            this.checkEnableDirector.UseVisualStyleBackColor = true;
            this.checkEnableDirector.CheckedChanged += new System.EventHandler(this.checkEnableDirector_CheckedChanged);
            // 
            // comboDirector
            // 
            this.comboDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDirector.Enabled = false;
            this.comboDirector.FormattingEnabled = true;
            this.comboDirector.Location = new System.Drawing.Point(33, 105);
            this.comboDirector.Name = "comboDirector";
            this.comboDirector.Size = new System.Drawing.Size(208, 21);
            this.comboDirector.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Язык";
            // 
            // checkEnableLanguage
            // 
            this.checkEnableLanguage.AutoSize = true;
            this.checkEnableLanguage.Location = new System.Drawing.Point(12, 148);
            this.checkEnableLanguage.Name = "checkEnableLanguage";
            this.checkEnableLanguage.Size = new System.Drawing.Size(15, 14);
            this.checkEnableLanguage.TabIndex = 10;
            this.checkEnableLanguage.UseVisualStyleBackColor = true;
            this.checkEnableLanguage.CheckedChanged += new System.EventHandler(this.checkEnableLanguage_CheckedChanged);
            // 
            // comboLanguage
            // 
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.Enabled = false;
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Location = new System.Drawing.Point(33, 145);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(208, 21);
            this.comboLanguage.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Возрастной рейтинг";
            // 
            // checkEnableRated
            // 
            this.checkEnableRated.AutoSize = true;
            this.checkEnableRated.Location = new System.Drawing.Point(12, 188);
            this.checkEnableRated.Name = "checkEnableRated";
            this.checkEnableRated.Size = new System.Drawing.Size(15, 14);
            this.checkEnableRated.TabIndex = 13;
            this.checkEnableRated.UseVisualStyleBackColor = true;
            this.checkEnableRated.CheckedChanged += new System.EventHandler(this.checkEnableRated_CheckedChanged);
            // 
            // comboRated
            // 
            this.comboRated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRated.Enabled = false;
            this.comboRated.FormattingEnabled = true;
            this.comboRated.Location = new System.Drawing.Point(33, 185);
            this.comboRated.Name = "comboRated";
            this.comboRated.Size = new System.Drawing.Size(208, 21);
            this.comboRated.TabIndex = 12;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 263);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.Text = "Принять";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(166, 263);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // numericYear
            // 
            this.numericYear.Enabled = false;
            this.numericYear.Location = new System.Drawing.Point(33, 225);
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
            this.numericYear.Size = new System.Drawing.Size(208, 20);
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
            this.checkEnableYear.Location = new System.Drawing.Point(12, 227);
            this.checkEnableYear.Name = "checkEnableYear";
            this.checkEnableYear.Size = new System.Drawing.Size(15, 14);
            this.checkEnableYear.TabIndex = 18;
            this.checkEnableYear.UseVisualStyleBackColor = true;
            this.checkEnableYear.CheckedChanged += new System.EventHandler(this.checkEnableYear_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Год выхода";
            // 
            // MovieFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 298);
            this.ControlBox = false;
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
            this.Name = "MovieFilterForm";
            this.ShowInTaskbar = false;
            this.Text = "Фильтр";
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
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
    }
}