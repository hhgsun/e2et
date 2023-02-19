namespace excel2excel_template
{
    partial class FormGenerate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerate));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridSourceGenerate = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewSingle = new System.Windows.Forms.DataGridView();
            this.checkBoxSaveSingleSources = new System.Windows.Forms.CheckBox();
            this.buttonClearGridSingle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMultiple = new System.Windows.Forms.DataGridView();
            this.numericUpDownFinishLineCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSaveMultipleSources = new System.Windows.Forms.CheckBox();
            this.buttonClearGridMultiple = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExportFile = new System.Windows.Forms.Button();
            this.checkBoxAddBetweenLines = new System.Windows.Forms.CheckBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.dataGridPreviewSchema = new System.Windows.Forms.DataGridView();
            this.buttonClearSchema = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSourceGenerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMultiple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinishLineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreviewSchema)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1314, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 20);
            this.toolStripMenuItem1.Text = "Kaynak Dosya Seç";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dataGridSourceGenerate
            // 
            this.dataGridSourceGenerate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSourceGenerate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSourceGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSourceGenerate.Location = new System.Drawing.Point(0, 0);
            this.dataGridSourceGenerate.Name = "dataGridSourceGenerate";
            this.dataGridSourceGenerate.RowTemplate.Height = 25;
            this.dataGridSourceGenerate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridSourceGenerate.Size = new System.Drawing.Size(857, 609);
            this.dataGridSourceGenerate.TabIndex = 1;
            this.dataGridSourceGenerate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGenerate_CellClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridSourceGenerate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1314, 609);
            this.splitContainer1.SplitterDistance = 857;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonExportFile);
            this.splitContainer2.Panel2.Controls.Add(this.checkBoxAddBetweenLines);
            this.splitContainer2.Panel2.Controls.Add(this.buttonPreview);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridPreviewSchema);
            this.splitContainer2.Panel2.Controls.Add(this.buttonClearSchema);
            this.splitContainer2.Size = new System.Drawing.Size(453, 609);
            this.splitContainer2.SplitterDistance = 255;
            this.splitContainer2.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridViewSingle);
            this.splitContainer3.Panel1.Controls.Add(this.checkBoxSaveSingleSources);
            this.splitContainer3.Panel1.Controls.Add(this.buttonClearGridSingle);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewMultiple);
            this.splitContainer3.Panel2.Controls.Add(this.numericUpDownFinishLineCount);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Controls.Add(this.checkBoxSaveMultipleSources);
            this.splitContainer3.Panel2.Controls.Add(this.buttonClearGridMultiple);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Size = new System.Drawing.Size(453, 255);
            this.splitContainer3.SplitterDistance = 127;
            this.splitContainer3.TabIndex = 6;
            // 
            // dataGridViewSingle
            // 
            this.dataGridViewSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSingle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSingle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSingle.Location = new System.Drawing.Point(0, 22);
            this.dataGridViewSingle.Name = "dataGridViewSingle";
            this.dataGridViewSingle.RowTemplate.Height = 25;
            this.dataGridViewSingle.Size = new System.Drawing.Size(453, 102);
            this.dataGridViewSingle.TabIndex = 1;
            this.dataGridViewSingle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSingle_CellClick);
            // 
            // checkBoxSaveSingleSources
            // 
            this.checkBoxSaveSingleSources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSaveSingleSources.AutoSize = true;
            this.checkBoxSaveSingleSources.Checked = true;
            this.checkBoxSaveSingleSources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveSingleSources.Location = new System.Drawing.Point(305, 4);
            this.checkBoxSaveSingleSources.Name = "checkBoxSaveSingleSources";
            this.checkBoxSaveSingleSources.Size = new System.Drawing.Size(94, 19);
            this.checkBoxSaveSingleSources.TabIndex = 7;
            this.checkBoxSaveSingleSources.Text = "bilgileri sakla";
            this.checkBoxSaveSingleSources.UseVisualStyleBackColor = true;
            // 
            // buttonClearGridSingle
            // 
            this.buttonClearGridSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearGridSingle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearGridSingle.Location = new System.Drawing.Point(399, 0);
            this.buttonClearGridSingle.Name = "buttonClearGridSingle";
            this.buttonClearGridSingle.Size = new System.Drawing.Size(54, 23);
            this.buttonClearGridSingle.TabIndex = 6;
            this.buttonClearGridSingle.Text = "Temizle";
            this.buttonClearGridSingle.UseVisualStyleBackColor = true;
            this.buttonClearGridSingle.Click += new System.EventHandler(this.buttonClearGridSingle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Özel Alanlar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewMultiple
            // 
            this.dataGridViewMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMultiple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMultiple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMultiple.Location = new System.Drawing.Point(0, 21);
            this.dataGridViewMultiple.Name = "dataGridViewMultiple";
            this.dataGridViewMultiple.RowTemplate.Height = 25;
            this.dataGridViewMultiple.Size = new System.Drawing.Size(453, 100);
            this.dataGridViewMultiple.TabIndex = 2;
            this.dataGridViewMultiple.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMultiple_CellClick);
            // 
            // numericUpDownFinishLineCount
            // 
            this.numericUpDownFinishLineCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownFinishLineCount.Location = new System.Drawing.Point(93, 1);
            this.numericUpDownFinishLineCount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.numericUpDownFinishLineCount.Name = "numericUpDownFinishLineCount";
            this.numericUpDownFinishLineCount.Size = new System.Drawing.Size(35, 23);
            this.numericUpDownFinishLineCount.TabIndex = 4;
            this.numericUpDownFinishLineCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "defa tekrarla";
            // 
            // checkBoxSaveMultipleSources
            // 
            this.checkBoxSaveMultipleSources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSaveMultipleSources.AutoSize = true;
            this.checkBoxSaveMultipleSources.Checked = true;
            this.checkBoxSaveMultipleSources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveMultipleSources.Location = new System.Drawing.Point(303, 3);
            this.checkBoxSaveMultipleSources.Name = "checkBoxSaveMultipleSources";
            this.checkBoxSaveMultipleSources.Size = new System.Drawing.Size(94, 19);
            this.checkBoxSaveMultipleSources.TabIndex = 8;
            this.checkBoxSaveMultipleSources.Text = "bilgileri sakla";
            this.checkBoxSaveMultipleSources.UseVisualStyleBackColor = true;
            // 
            // buttonClearGridMultiple
            // 
            this.buttonClearGridMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearGridMultiple.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearGridMultiple.Location = new System.Drawing.Point(399, -1);
            this.buttonClearGridMultiple.Name = "buttonClearGridMultiple";
            this.buttonClearGridMultiple.Size = new System.Drawing.Size(54, 23);
            this.buttonClearGridMultiple.TabIndex = 7;
            this.buttonClearGridMultiple.Text = "Temizle";
            this.buttonClearGridMultiple.UseVisualStyleBackColor = true;
            this.buttonClearGridMultiple.Click += new System.EventHandler(this.buttonClearGridMultiple_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tekrarlı Alanlar";
            // 
            // buttonExportFile
            // 
            this.buttonExportFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportFile.Location = new System.Drawing.Point(2, 323);
            this.buttonExportFile.Name = "buttonExportFile";
            this.buttonExportFile.Size = new System.Drawing.Size(103, 23);
            this.buttonExportFile.TabIndex = 7;
            this.buttonExportFile.Text = "Farklı Kaydet";
            this.buttonExportFile.UseVisualStyleBackColor = true;
            this.buttonExportFile.Click += new System.EventHandler(this.buttonExportFile_Click);
            // 
            // checkBoxAddBetweenLines
            // 
            this.checkBoxAddBetweenLines.AutoSize = true;
            this.checkBoxAddBetweenLines.Location = new System.Drawing.Point(116, 5);
            this.checkBoxAddBetweenLines.Name = "checkBoxAddBetweenLines";
            this.checkBoxAddBetweenLines.Size = new System.Drawing.Size(80, 19);
            this.checkBoxAddBetweenLines.TabIndex = 6;
            this.checkBoxAddBetweenLines.Text = "Araya Ekle";
            this.checkBoxAddBetweenLines.UseVisualStyleBackColor = true;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(2, 2);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(106, 23);
            this.buttonPreview.TabIndex = 3;
            this.buttonPreview.Text = "Şablona Aktar";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // dataGridPreviewSchema
            // 
            this.dataGridPreviewSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPreviewSchema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPreviewSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreviewSchema.Location = new System.Drawing.Point(0, 26);
            this.dataGridPreviewSchema.Name = "dataGridPreviewSchema";
            this.dataGridPreviewSchema.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridPreviewSchema.RowTemplate.Height = 25;
            this.dataGridPreviewSchema.Size = new System.Drawing.Size(453, 292);
            this.dataGridPreviewSchema.TabIndex = 0;
            // 
            // buttonClearSchema
            // 
            this.buttonClearSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearSchema.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearSchema.Location = new System.Drawing.Point(360, 4);
            this.buttonClearSchema.Name = "buttonClearSchema";
            this.buttonClearSchema.Size = new System.Drawing.Size(93, 23);
            this.buttonClearSchema.TabIndex = 9;
            this.buttonClearSchema.Text = "Şablonu Sıfırla";
            this.buttonClearSchema.UseVisualStyleBackColor = true;
            this.buttonClearSchema.Click += new System.EventHandler(this.buttonClearSchema_Click);
            // 
            // FormGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 633);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGenerate";
            this.Text = "Generate";
            this.Load += new System.EventHandler(this.FormGenerate_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSourceGenerate)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMultiple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinishLineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreviewSchema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private DataGridView dataGridSourceGenerate;
        private SplitContainer splitContainer1;
        private DataGridView dataGridPreviewSchema;
        private DataGridView dataGridViewMultiple;
        private DataGridView dataGridViewSingle;
        private Button buttonPreview;
        private Label label2;
        private Label label1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Label label3;
        private NumericUpDown numericUpDownFinishLineCount;
        private CheckBox checkBoxAddBetweenLines;
        private Button buttonClearGridSingle;
        private Button buttonClearGridMultiple;
        private CheckBox checkBoxSaveSingleSources;
        private CheckBox checkBoxSaveMultipleSources;
        private Button buttonExportFile;
        private Button buttonClearSchema;
    }
}