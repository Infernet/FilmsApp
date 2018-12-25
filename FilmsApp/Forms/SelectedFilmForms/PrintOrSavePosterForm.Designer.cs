namespace FilmsApp.Forms.SelectedFilmForms
{
    partial class PrintOrSavePosterForm
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
            this.buttonPrintPrinter = new System.Windows.Forms.Button();
            this.buttonSaveOnDisk = new System.Windows.Forms.Button();
            this.printPoster = new System.Drawing.Printing.PrintDocument();
            this.printPosterDialog = new System.Windows.Forms.PrintDialog();
            this.savePosterDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrintPrinter
            // 
            this.buttonPrintPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonPrintPrinter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrintPrinter.Location = new System.Drawing.Point(18, 17);
            this.buttonPrintPrinter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrintPrinter.Name = "buttonPrintPrinter";
            this.buttonPrintPrinter.Size = new System.Drawing.Size(221, 54);
            this.buttonPrintPrinter.TabIndex = 0;
            this.buttonPrintPrinter.Text = "Печать постера на принтере";
            this.buttonPrintPrinter.UseVisualStyleBackColor = false;
            this.buttonPrintPrinter.Click += new System.EventHandler(this.buttonPrintPrinter_Click);
            // 
            // buttonSaveOnDisk
            // 
            this.buttonSaveOnDisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonSaveOnDisk.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveOnDisk.Location = new System.Drawing.Point(18, 79);
            this.buttonSaveOnDisk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveOnDisk.Name = "buttonSaveOnDisk";
            this.buttonSaveOnDisk.Size = new System.Drawing.Size(221, 62);
            this.buttonSaveOnDisk.TabIndex = 1;
            this.buttonSaveOnDisk.Text = "Сохранить постер на диске";
            this.buttonSaveOnDisk.UseVisualStyleBackColor = false;
            this.buttonSaveOnDisk.Click += new System.EventHandler(this.buttonSaveOnDisk_Click);
            // 
            // printPoster
            // 
            this.printPoster.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPosterDialog
            // 
            this.printPosterDialog.UseEXDialog = true;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(247, 14);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(268, 175);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 26;
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(18, 149);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(221, 40);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // PrintOrSavePosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 203);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.buttonSaveOnDisk);
            this.Controls.Add(this.buttonPrintPrinter);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PrintOrSavePosterForm";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintPrinter;
        private System.Windows.Forms.Button buttonSaveOnDisk;
        private System.Drawing.Printing.PrintDocument printPoster;
        private System.Windows.Forms.PrintDialog printPosterDialog;
        private System.Windows.Forms.SaveFileDialog savePosterDialog;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonExit;
    }
}