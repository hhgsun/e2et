namespace excel_deskapp
{
    partial class FormSchemas
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
            this.comboBoxSchemas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewSchema = new System.Windows.Forms.Button();
            this.buttonSchemaEdit = new System.Windows.Forms.Button();
            this.buttonSchemaUse = new System.Windows.Forms.Button();
            this.checkBoxCache = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxSchemas
            // 
            this.comboBoxSchemas.FormattingEnabled = true;
            this.comboBoxSchemas.Location = new System.Drawing.Point(32, 45);
            this.comboBoxSchemas.Name = "comboBoxSchemas";
            this.comboBoxSchemas.Size = new System.Drawing.Size(370, 23);
            this.comboBoxSchemas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şablonlar";
            // 
            // buttonNewSchema
            // 
            this.buttonNewSchema.Location = new System.Drawing.Point(32, 191);
            this.buttonNewSchema.Name = "buttonNewSchema";
            this.buttonNewSchema.Size = new System.Drawing.Size(147, 23);
            this.buttonNewSchema.TabIndex = 2;
            this.buttonNewSchema.Text = "Yeni Şablon Ekle";
            this.buttonNewSchema.UseVisualStyleBackColor = true;
            this.buttonNewSchema.Click += new System.EventHandler(this.buttonNewSchema_Click);
            // 
            // buttonSchemaEdit
            // 
            this.buttonSchemaEdit.Location = new System.Drawing.Point(32, 152);
            this.buttonSchemaEdit.Name = "buttonSchemaEdit";
            this.buttonSchemaEdit.Size = new System.Drawing.Size(147, 23);
            this.buttonSchemaEdit.TabIndex = 3;
            this.buttonSchemaEdit.Text = "Seçili Şablonu Düzenle";
            this.buttonSchemaEdit.UseVisualStyleBackColor = true;
            this.buttonSchemaEdit.Click += new System.EventHandler(this.buttonSchemaEdit_Click);
            // 
            // buttonSchemaUse
            // 
            this.buttonSchemaUse.Location = new System.Drawing.Point(32, 74);
            this.buttonSchemaUse.Name = "buttonSchemaUse";
            this.buttonSchemaUse.Size = new System.Drawing.Size(147, 23);
            this.buttonSchemaUse.TabIndex = 4;
            this.buttonSchemaUse.Text = "Seçili Şablonu Kullan";
            this.buttonSchemaUse.UseVisualStyleBackColor = true;
            this.buttonSchemaUse.Click += new System.EventHandler(this.buttonSchemaUse_Click);
            // 
            // checkBoxCache
            // 
            this.checkBoxCache.AutoSize = true;
            this.checkBoxCache.Location = new System.Drawing.Point(185, 77);
            this.checkBoxCache.Name = "checkBoxCache";
            this.checkBoxCache.Size = new System.Drawing.Size(217, 19);
            this.checkBoxCache.TabIndex = 5;
            this.checkBoxCache.Text = "Sonraki açılışlarda bu şablonu kullan";
            this.checkBoxCache.UseVisualStyleBackColor = true;
            // 
            // FormSchemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 251);
            this.Controls.Add(this.checkBoxCache);
            this.Controls.Add(this.buttonSchemaUse);
            this.Controls.Add(this.buttonSchemaEdit);
            this.Controls.Add(this.buttonNewSchema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSchemas);
            this.Name = "FormSchemas";
            this.Text = "FormSchemas";
            this.Load += new System.EventHandler(this.FormSchemas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxSchemas;
        private Label label1;
        private Button buttonNewSchema;
        private Button buttonSchemaEdit;
        private Button buttonSchemaUse;
        private CheckBox checkBoxCache;
    }
}