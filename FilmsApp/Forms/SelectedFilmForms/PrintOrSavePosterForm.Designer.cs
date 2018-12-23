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
            this.SuspendLayout();
            // 
            // buttonPrintPrinter
            // 
            this.buttonPrintPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintPrinter.Location = new System.Drawing.Point(12, 12);
            this.buttonPrintPrinter.Name = "buttonPrintPrinter";
            this.buttonPrintPrinter.Size = new System.Drawing.Size(167, 56);
            this.buttonPrintPrinter.TabIndex = 0;
            this.buttonPrintPrinter.Text = "Печать постера на принтере";
            this.buttonPrintPrinter.UseVisualStyleBackColor = true;
            // 
            // buttonSaveOnDisk
            // 
            this.buttonSaveOnDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveOnDisk.Location = new System.Drawing.Point(218, 12);
            this.buttonSaveOnDisk.Name = "buttonSaveOnDisk";
            this.buttonSaveOnDisk.Size = new System.Drawing.Size(166, 56);
            this.buttonSaveOnDisk.TabIndex = 1;
            this.buttonSaveOnDisk.Text = "Сохранить постер на диске";
            this.buttonSaveOnDisk.UseVisualStyleBackColor = true;
            // 
            // PrintOrSavePosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 94);
            this.Controls.Add(this.buttonSaveOnDisk);
            this.Controls.Add(this.buttonPrintPrinter);
            this.Name = "PrintOrSavePosterForm";
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintPrinter;
        private System.Windows.Forms.Button buttonSaveOnDisk;
    }
}