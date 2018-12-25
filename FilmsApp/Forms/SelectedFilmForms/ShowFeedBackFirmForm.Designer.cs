namespace FilmsApp.Forms.SelectedFilmForms
{
    partial class ShowFeedBackFirmForm
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
            this.comboBoxFeedBack = new System.Windows.Forms.ComboBox();
            this.userFeedBackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet = new FilmsApp.MovieDBDataSet();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.userFeedBackTableAdapter = new FilmsApp.MovieDBDataSetTableAdapters.UserFeedBackTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userFeedBackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFeedBack
            // 
            this.comboBoxFeedBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.comboBoxFeedBack.DataSource = this.userFeedBackBindingSource;
            this.comboBoxFeedBack.DisplayMember = "UserName";
            this.comboBoxFeedBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFeedBack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFeedBack.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.comboBoxFeedBack.FormattingEnabled = true;
            this.comboBoxFeedBack.Location = new System.Drawing.Point(169, 4);
            this.comboBoxFeedBack.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFeedBack.Name = "comboBoxFeedBack";
            this.comboBoxFeedBack.Size = new System.Drawing.Size(558, 28);
            this.comboBoxFeedBack.TabIndex = 0;
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
            // tbComment
            // 
            this.tbComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbComment.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic);
            this.tbComment.Location = new System.Drawing.Point(4, 23);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ReadOnly = true;
            this.tbComment.Size = new System.Drawing.Size(715, 539);
            this.tbComment.TabIndex = 2;
            this.tbComment.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.70862F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.29138F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxFeedBack, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.738132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.26187F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 653);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пользователь:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.textBoxDate);
            this.groupBox2.Controls.Add(this.tbComment);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(723, 601);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // textBoxDate
            // 
            this.textBoxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.textBoxDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxDate.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic);
            this.textBoxDate.Location = new System.Drawing.Point(4, 569);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(715, 28);
            this.textBoxDate.TabIndex = 3;
            this.textBoxDate.TabStop = false;
            this.textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // userFeedBackTableAdapter
            // 
            this.userFeedBackTableAdapter.ClearBeforeFill = true;
            // 
            // ShowFeedBackFirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ShowFeedBackFirmForm";
            this.Text = "Отзывы";
            this.Load += new System.EventHandler(this.ShowFeedBackFirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userFeedBackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFeedBack;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDate;
        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource userFeedBackBindingSource;
        private MovieDBDataSetTableAdapters.UserFeedBackTableAdapter userFeedBackTableAdapter;
    }
}