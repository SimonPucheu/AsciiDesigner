namespace AsciiDesigner
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownZoom = new System.Windows.Forms.NumericUpDown();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.checkBoxQuick = new System.Windows.Forms.CheckBox();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChooseFile.Location = new System.Drawing.Point(0, 0);
            this.buttonChooseFile.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseFile.TabIndex = 0;
            this.buttonChooseFile.Text = "Choose";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxResult, 2);
            this.richTextBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxResult.Font = new System.Drawing.Font("Consolas", 1F);
            this.richTextBoxResult.Location = new System.Drawing.Point(228, 3);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.tableLayoutPanel1.SetRowSpan(this.richTextBoxResult, 3);
            this.richTextBoxResult.Size = new System.Drawing.Size(553, 232);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownZoom, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonConvert, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonChooseFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxResult, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFileName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxPreview, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxQuick, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSize, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownFontSize, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 261);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // numericUpDownZoom
            // 
            this.numericUpDownZoom.DecimalPlaces = 2;
            this.numericUpDownZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownZoom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownZoom.Location = new System.Drawing.Point(507, 241);
            this.numericUpDownZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownZoom.Name = "numericUpDownZoom";
            this.numericUpDownZoom.Size = new System.Drawing.Size(274, 20);
            this.numericUpDownZoom.TabIndex = 8;
            this.numericUpDownZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownZoom.ValueChanged += new System.EventHandler(this.numericUpDownZoom_ValueChanged);
            // 
            // buttonConvert
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonConvert, 2);
            this.buttonConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConvert.Location = new System.Drawing.Point(0, 238);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(225, 23);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileName.Location = new System.Drawing.Point(78, 3);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(144, 20);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // pictureBoxPreview
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxPreview, 2);
            this.pictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPreview.Location = new System.Drawing.Point(3, 26);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(219, 186);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 4;
            this.pictureBoxPreview.TabStop = false;
            // 
            // checkBoxQuick
            // 
            this.checkBoxQuick.AutoSize = true;
            this.checkBoxQuick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxQuick.Location = new System.Drawing.Point(3, 218);
            this.checkBoxQuick.Name = "checkBoxQuick";
            this.checkBoxQuick.Size = new System.Drawing.Size(69, 17);
            this.checkBoxQuick.TabIndex = 5;
            this.checkBoxQuick.Text = "Quick";
            this.checkBoxQuick.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownSize.Location = new System.Drawing.Point(78, 218);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(144, 20);
            this.numericUpDownSize.TabIndex = 6;
            this.numericUpDownSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownFontSize.Location = new System.Drawing.Point(228, 241);
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(273, 20);
            this.numericUpDownFontSize.TabIndex = 7;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownFontSize.ValueChanged += new System.EventHandler(this.numericUpDownFontSize_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "AsciiConverter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.CheckBox checkBoxQuick;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.NumericUpDown numericUpDownZoom;
    }
}

