namespace FilmsApp.Forms.Moderator
{
    partial class FeedBackModerationForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFeedBack = new System.Windows.Forms.ComboBox();
            this.userFeedBackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet = new FilmsApp.MovieDBDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteFeedBack = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.checkChagneMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.dateTimePickerFeedBack = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.userFeedBackTableAdapter = new FilmsApp.MovieDBDataSetTableAdapters.UserFeedBackTableAdapter();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFeedBackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.56489F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.43511F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxFeedBack, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbComment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerFeedBack, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 827);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отзывы в ожидании:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxFeedBack
            // 
            this.comboBoxFeedBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.comboBoxFeedBack.DataSource = this.userFeedBackBindingSource;
            this.comboBoxFeedBack.DisplayMember = "UserName";
            this.comboBoxFeedBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFeedBack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFeedBack.FormattingEnabled = true;
            this.comboBoxFeedBack.Location = new System.Drawing.Point(199, 4);
            this.comboBoxFeedBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFeedBack.Name = "comboBoxFeedBack";
            this.comboBoxFeedBack.Size = new System.Drawing.Size(534, 28);
            this.comboBoxFeedBack.TabIndex = 0;
            this.comboBoxFeedBack.TabStop = false;
            this.comboBoxFeedBack.ValueMember = "FeedBackId";
            this.comboBoxFeedBack.SelectedIndexChanged += new System.EventHandler(this.comboBoxFeedBack_SelectedIndexChanged);
            // 
            // userFeedBackBindingSource
            // 
            this.userFeedBackBindingSource.DataMember = "UserFeedBack";
            this.userFeedBackBindingSource.DataSource = this.movieDBDataSet;
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.pictureBoxIcon);
            this.groupBox1.Controls.Add(this.buttonDeleteFeedBack);
            this.groupBox1.Controls.Add(this.buttonSubmit);
            this.groupBox1.Controls.Add(this.checkChagneMode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(4, 671);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(729, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // buttonDeleteFeedBack
            // 
            this.buttonDeleteFeedBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonDeleteFeedBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteFeedBack.Location = new System.Drawing.Point(216, 90);
            this.buttonDeleteFeedBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteFeedBack.Name = "buttonDeleteFeedBack";
            this.buttonDeleteFeedBack.Size = new System.Drawing.Size(140, 51);
            this.buttonDeleteFeedBack.TabIndex = 1;
            this.buttonDeleteFeedBack.Text = "Удалить";
            this.buttonDeleteFeedBack.UseVisualStyleBackColor = false;
            this.buttonDeleteFeedBack.Click += new System.EventHandler(this.buttonDeleteFeedBack_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.Location = new System.Drawing.Point(24, 90);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(184, 51);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Сделать публичным";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // checkChagneMode
            // 
            this.checkChagneMode.AutoSize = true;
            this.checkChagneMode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.checkChagneMode.Location = new System.Drawing.Point(24, 55);
            this.checkChagneMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkChagneMode.Name = "checkChagneMode";
            this.checkChagneMode.Size = new System.Drawing.Size(142, 27);
            this.checkChagneMode.TabIndex = 3;
            this.checkChagneMode.TabStop = false;
            this.checkChagneMode.Text = "Редактировать";
            this.checkChagneMode.UseVisualStyleBackColor = true;
            this.checkChagneMode.CheckedChanged += new System.EventHandler(this.checkChagneMode_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя пользователя:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(199, 47);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(534, 28);
            this.tbName.TabIndex = 6;
            this.tbName.TabStop = false;
            // 
            // tbComment
            // 
            this.tbComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tableLayoutPanel1.SetColumnSpan(this.tbComment, 2);
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComment.Enabled = false;
            this.tbComment.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbComment.Location = new System.Drawing.Point(4, 129);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(729, 534);
            this.tbComment.TabIndex = 2;
            this.tbComment.TabStop = false;
            // 
            // dateTimePickerFeedBack
            // 
            this.dateTimePickerFeedBack.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.dateTimePickerFeedBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFeedBack.Enabled = false;
            this.dateTimePickerFeedBack.Location = new System.Drawing.Point(199, 88);
            this.dateTimePickerFeedBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFeedBack.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFeedBack.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFeedBack.Name = "dateTimePickerFeedBack";
            this.dateTimePickerFeedBack.Size = new System.Drawing.Size(534, 28);
            this.dateTimePickerFeedBack.TabIndex = 7;
            this.dateTimePickerFeedBack.TabStop = false;
            this.dateTimePickerFeedBack.Value = new System.DateTime(2018, 12, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userFeedBackTableAdapter
            // 
            this.userFeedBackTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(512, 19);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(206, 122);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 26;
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(364, 90);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 51);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FeedBackModerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 827);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FeedBackModerationForm";
            this.Text = "Модерация отзывов";
            this.Load += new System.EventHandler(this.FeedBackModerationForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFeedBackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteFeedBack;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.CheckBox checkChagneMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFeedBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dateTimePickerFeedBack;
        private System.Windows.Forms.Label label3;
        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource userFeedBackBindingSource;
        private MovieDBDataSetTableAdapters.UserFeedBackTableAdapter userFeedBackTableAdapter;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonExit;
    }
}