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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFeedBackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.43992F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.56008F));
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 386F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отзывы в ожидании:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxFeedBack
            // 
            this.comboBoxFeedBack.DataSource = this.userFeedBackBindingSource;
            this.comboBoxFeedBack.DisplayMember = "UserName";
            this.comboBoxFeedBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFeedBack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFeedBack.FormattingEnabled = true;
            this.comboBoxFeedBack.Location = new System.Drawing.Point(123, 3);
            this.comboBoxFeedBack.Name = "comboBoxFeedBack";
            this.comboBoxFeedBack.Size = new System.Drawing.Size(365, 21);
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
            this.groupBox1.Controls.Add(this.buttonDeleteFeedBack);
            this.groupBox1.Controls.Add(this.buttonSubmit);
            this.groupBox1.Controls.Add(this.checkChagneMode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // buttonDeleteFeedBack
            // 
            this.buttonDeleteFeedBack.Location = new System.Drawing.Point(154, 28);
            this.buttonDeleteFeedBack.Name = "buttonDeleteFeedBack";
            this.buttonDeleteFeedBack.Size = new System.Drawing.Size(93, 28);
            this.buttonDeleteFeedBack.TabIndex = 1;
            this.buttonDeleteFeedBack.Text = "Удалить";
            this.buttonDeleteFeedBack.UseVisualStyleBackColor = true;
            this.buttonDeleteFeedBack.Click += new System.EventHandler(this.buttonDeleteFeedBack_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(9, 28);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(123, 28);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Сделать публичным";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // checkChagneMode
            // 
            this.checkChagneMode.AutoSize = true;
            this.checkChagneMode.Location = new System.Drawing.Point(253, 35);
            this.checkChagneMode.Name = "checkChagneMode";
            this.checkChagneMode.Size = new System.Drawing.Size(103, 17);
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
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя пользователя:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(123, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(365, 20);
            this.tbName.TabIndex = 6;
            this.tbName.TabStop = false;
            // 
            // tbComment
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbComment, 2);
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComment.Enabled = false;
            this.tbComment.Location = new System.Drawing.Point(3, 83);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(485, 380);
            this.tbComment.TabIndex = 2;
            this.tbComment.TabStop = false;
            // 
            // dateTimePickerFeedBack
            // 
            this.dateTimePickerFeedBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFeedBack.Enabled = false;
            this.dateTimePickerFeedBack.Location = new System.Drawing.Point(123, 56);
            this.dateTimePickerFeedBack.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFeedBack.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFeedBack.Name = "dateTimePickerFeedBack";
            this.dateTimePickerFeedBack.Size = new System.Drawing.Size(365, 20);
            this.dateTimePickerFeedBack.TabIndex = 7;
            this.dateTimePickerFeedBack.TabStop = false;
            this.dateTimePickerFeedBack.Value = new System.DateTime(2018, 12, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userFeedBackTableAdapter
            // 
            this.userFeedBackTableAdapter.ClearBeforeFill = true;
            // 
            // FeedBackModerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FeedBackModerationForm";
            this.Text = "FeedBackModerationForm";
            this.Load += new System.EventHandler(this.FeedBackModerationForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFeedBackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}