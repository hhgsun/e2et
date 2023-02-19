namespace excel2excel_template
{
    partial class FormSchemaEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchemaEdit));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sablonlaraDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sablonSecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridSchema = new System.Windows.Forms.DataGridView();
            this.dataGridViewInputs = new System.Windows.Forms.DataGridView();
            this.dataGridMultiArea = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonSaveSchema = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSchemaName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHelpSingle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonHelpMultiple = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxLineStartCount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIsHorizontal = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMultiArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxLineStartCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sablonlaraDonToolStripMenuItem,
            this.sablonSecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sablonlaraDonToolStripMenuItem
            // 
            this.sablonlaraDonToolStripMenuItem.Name = "sablonlaraDonToolStripMenuItem";
            this.sablonlaraDonToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.sablonlaraDonToolStripMenuItem.Text = "↩️ 💼 Şablonlar";
            this.sablonlaraDonToolStripMenuItem.Click += new System.EventHandler(this.sablonlaraDonToolStripMenuItem_Click);
            // 
            // sablonSecToolStripMenuItem
            // 
            this.sablonSecToolStripMenuItem.Name = "sablonSecToolStripMenuItem";
            this.sablonSecToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.sablonSecToolStripMenuItem.Text = "📂 Şablon Dosyası Seç";
            this.sablonSecToolStripMenuItem.Click += new System.EventHandler(this.sablonSecToolStripMenuItem_Click);
            // 
            // dataGridSchema
            // 
            this.dataGridSchema.AllowUserToAddRows = false;
            this.dataGridSchema.AllowUserToDeleteRows = false;
            this.dataGridSchema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSchema.EnableHeadersVisualStyles = false;
            this.dataGridSchema.Location = new System.Drawing.Point(0, 0);
            this.dataGridSchema.MultiSelect = false;
            this.dataGridSchema.Name = "dataGridSchema";
            this.dataGridSchema.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSchema.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSchema.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridSchema.RowTemplate.Height = 25;
            this.dataGridSchema.RowTemplate.ReadOnly = true;
            this.dataGridSchema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridSchema.Size = new System.Drawing.Size(659, 608);
            this.dataGridSchema.TabIndex = 1;
            this.dataGridSchema.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSchema_CellDoubleClick);
            // 
            // dataGridViewInputs
            // 
            this.dataGridViewInputs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInputs.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewInputs.Name = "dataGridViewInputs";
            this.dataGridViewInputs.RowTemplate.Height = 25;
            this.dataGridViewInputs.Size = new System.Drawing.Size(331, 254);
            this.dataGridViewInputs.TabIndex = 9;
            // 
            // dataGridMultiArea
            // 
            this.dataGridMultiArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMultiArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMultiArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMultiArea.Location = new System.Drawing.Point(3, 19);
            this.dataGridMultiArea.Name = "dataGridMultiArea";
            this.dataGridMultiArea.RowTemplate.Height = 25;
            this.dataGridMultiArea.Size = new System.Drawing.Size(331, 247);
            this.dataGridMultiArea.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridSchema);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 608);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 10;
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
            this.splitContainer2.Panel1.Controls.Add(this.buttonSaveSchema);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxSchemaName);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(337, 608);
            this.splitContainer2.SplitterDistance = 304;
            this.splitContainer2.TabIndex = 11;
            // 
            // buttonSaveSchema
            // 
            this.buttonSaveSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveSchema.Location = new System.Drawing.Point(260, 3);
            this.buttonSaveSchema.Name = "buttonSaveSchema";
            this.buttonSaveSchema.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSchema.TabIndex = 12;
            this.buttonSaveSchema.Text = "Kaydet";
            this.buttonSaveSchema.UseVisualStyleBackColor = true;
            this.buttonSaveSchema.Click += new System.EventHandler(this.buttonSaveSchema_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şablon Adı";
            // 
            // textBoxSchemaName
            // 
            this.textBoxSchemaName.Location = new System.Drawing.Point(74, 3);
            this.textBoxSchemaName.Name = "textBoxSchemaName";
            this.textBoxSchemaName.Size = new System.Drawing.Size(154, 23);
            this.textBoxSchemaName.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewInputs);
            this.groupBox1.Controls.Add(this.buttonHelpSingle);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 276);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özel Alanlar";
            // 
            // buttonHelpSingle
            // 
            this.buttonHelpSingle.AccessibleDescription = "bilgi";
            this.buttonHelpSingle.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.buttonHelpSingle.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelpSingle.FlatAppearance.BorderSize = 0;
            this.buttonHelpSingle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelpSingle.Location = new System.Drawing.Point(74, -1);
            this.buttonHelpSingle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelpSingle.Name = "buttonHelpSingle";
            this.buttonHelpSingle.Size = new System.Drawing.Size(24, 20);
            this.buttonHelpSingle.TabIndex = 10;
            this.buttonHelpSingle.Text = "?";
            this.buttonHelpSingle.UseVisualStyleBackColor = true;
            this.buttonHelpSingle.Click += new System.EventHandler(this.buttonHelpSingle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonHelpMultiple);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dataGridMultiArea);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 300);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tekrarlı Alanlar";
            // 
            // buttonHelpMultiple
            // 
            this.buttonHelpMultiple.AccessibleDescription = "bilgi";
            this.buttonHelpMultiple.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.buttonHelpMultiple.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelpMultiple.FlatAppearance.BorderSize = 0;
            this.buttonHelpMultiple.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelpMultiple.Location = new System.Drawing.Point(90, -1);
            this.buttonHelpMultiple.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelpMultiple.Name = "buttonHelpMultiple";
            this.buttonHelpMultiple.Size = new System.Drawing.Size(24, 20);
            this.buttonHelpMultiple.TabIndex = 11;
            this.buttonHelpMultiple.Text = "?";
            this.buttonHelpMultiple.UseVisualStyleBackColor = true;
            this.buttonHelpMultiple.Click += new System.EventHandler(this.buttonHelpMultiple_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxLineStartCount);
            this.panel1.Controls.Add(this.checkBoxIsHorizontal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 30);
            this.panel1.TabIndex = 13;
            // 
            // txtBoxLineStartCount
            // 
            this.txtBoxLineStartCount.Location = new System.Drawing.Point(3, 3);
            this.txtBoxLineStartCount.Name = "txtBoxLineStartCount";
            this.txtBoxLineStartCount.Size = new System.Drawing.Size(38, 23);
            this.txtBoxLineStartCount.TabIndex = 11;
            // 
            // checkBoxIsHorizontal
            // 
            this.checkBoxIsHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsHorizontal.AutoSize = true;
            this.checkBoxIsHorizontal.Location = new System.Drawing.Point(248, 5);
            this.checkBoxIsHorizontal.Name = "checkBoxIsHorizontal";
            this.checkBoxIsHorizontal.Size = new System.Drawing.Size(78, 19);
            this.checkBoxIsHorizontal.TabIndex = 9;
            this.checkBoxIsHorizontal.Text = "Yatay artır";
            this.checkBoxIsHorizontal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "satır sonra artırmaya başla";
            // 
            // FormSchemaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 632);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSchemaEdit";
            this.Text = "SchemaEdit";
            this.Load += new System.EventHandler(this.FormSchemaEdit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMultiArea)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxLineStartCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sablonSecToolStripMenuItem;
        private DataGridView dataGridSchema;
        private Label label3;
        private DataGridView dataGridMultiArea;
        private DataGridView dataGridViewInputs;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private NumericUpDown txtBoxLineStartCount;
        private CheckBox checkBoxIsHorizontal;
        private Label label1;
        private Label label2;
        private TextBox textBoxSchemaName;
        private Button buttonSaveSchema;
        private Button buttonHelpSingle;
        private Button buttonHelpMultiple;
        private ToolStripMenuItem sablonlaraDonToolStripMenuItem;
    }
}