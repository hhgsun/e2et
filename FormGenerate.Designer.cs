namespace excel_deskapp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridSourceGenerate = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSingle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMultiple = new System.Windows.Forms.DataGridView();
            this.numericUpDownFinishLineCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.dataGridSchema = new System.Windows.Forms.DataGridView();
            this.checkBoxAddBetweenLines = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchema)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1414, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "DosyaAc";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dataGridSourceGenerate
            // 
            this.dataGridSourceGenerate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSourceGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSourceGenerate.Location = new System.Drawing.Point(0, 0);
            this.dataGridSourceGenerate.Name = "dataGridSourceGenerate";
            this.dataGridSourceGenerate.RowTemplate.Height = 25;
            this.dataGridSourceGenerate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridSourceGenerate.Size = new System.Drawing.Size(923, 609);
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
            this.splitContainer1.Size = new System.Drawing.Size(1414, 609);
            this.splitContainer1.SplitterDistance = 923;
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
            this.splitContainer2.Panel2.Controls.Add(this.checkBoxAddBetweenLines);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownFinishLineCount);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.buttonPreview);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridSchema);
            this.splitContainer2.Size = new System.Drawing.Size(487, 609);
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
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.dataGridViewSingle);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewMultiple);
            this.splitContainer3.Size = new System.Drawing.Size(487, 255);
            this.splitContainer3.SplitterDistance = 127;
            this.splitContainer3.TabIndex = 6;
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
            // dataGridViewSingle
            // 
            this.dataGridViewSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSingle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSingle.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewSingle.Name = "dataGridViewSingle";
            this.dataGridViewSingle.RowTemplate.Height = 25;
            this.dataGridViewSingle.Size = new System.Drawing.Size(481, 102);
            this.dataGridViewSingle.TabIndex = 1;
            this.dataGridViewSingle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSingle_CellClick);
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
            // dataGridViewMultiple
            // 
            this.dataGridViewMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMultiple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMultiple.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewMultiple.Name = "dataGridViewMultiple";
            this.dataGridViewMultiple.RowTemplate.Height = 25;
            this.dataGridViewMultiple.Size = new System.Drawing.Size(481, 100);
            this.dataGridViewMultiple.TabIndex = 2;
            this.dataGridViewMultiple.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMultiple_CellClick);
            // 
            // numericUpDownFinishLineCount
            // 
            this.numericUpDownFinishLineCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownFinishLineCount.Location = new System.Drawing.Point(439, 3);
            this.numericUpDownFinishLineCount.Name = "numericUpDownFinishLineCount";
            this.numericUpDownFinishLineCount.Size = new System.Drawing.Size(45, 23);
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
            this.label3.Location = new System.Drawing.Point(319, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aktarılacak satır sayısı";
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(0, 3);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 3;
            this.buttonPreview.Text = "Oluştur";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // dataGridSchema
            // 
            this.dataGridSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSchema.Location = new System.Drawing.Point(0, 27);
            this.dataGridSchema.Name = "dataGridSchema";
            this.dataGridSchema.RowTemplate.Height = 25;
            this.dataGridSchema.Size = new System.Drawing.Size(487, 320);
            this.dataGridSchema.TabIndex = 0;
            // 
            // checkBoxAddBetweenLines
            // 
            this.checkBoxAddBetweenLines.AutoSize = true;
            this.checkBoxAddBetweenLines.Location = new System.Drawing.Point(81, 7);
            this.checkBoxAddBetweenLines.Name = "checkBoxAddBetweenLines";
            this.checkBoxAddBetweenLines.Size = new System.Drawing.Size(80, 19);
            this.checkBoxAddBetweenLines.TabIndex = 6;
            this.checkBoxAddBetweenLines.Text = "Araya Ekle";
            this.checkBoxAddBetweenLines.UseVisualStyleBackColor = true;
            // 
            // FormGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 633);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private DataGridView dataGridSourceGenerate;
        private SplitContainer splitContainer1;
        private DataGridView dataGridSchema;
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
    }
}