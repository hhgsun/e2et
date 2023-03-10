using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace excel2excel_template
{
    public partial class FormSchemas : Form
    {
        public bool isBackForm = false;
        public FormSchemas()
        {
            InitializeComponent();
        }

        private void buttonNewSchema_Click(object sender, EventArgs e)
        {
            FormSchemaEdit formEdit = new FormSchemaEdit();
            formEdit.InitialSchemaFileName = null;
            showFormEdit(formEdit);
        }

        private void buttonSchemaEdit_Click(object sender, EventArgs e)
        {
            if(comboBoxSchemas.SelectedIndex == -1)
            {
                MessageBox.Show(Constans.MessageSchemaChoose);
                return;
            }
            if (string.IsNullOrEmpty((comboBoxSchemas.SelectedItem as ComboboxItem)?.Value))
            {
                MessageBox.Show(Constans.MessageInvalid);
                return;
            }
            FormSchemaEdit formEdit = new FormSchemaEdit();
            formEdit.InitialSchemaFileName = (comboBoxSchemas.SelectedItem as ComboboxItem)?.Value;
            showFormEdit(formEdit);
        }

        private void showFormEdit(FormSchemaEdit formEdit)
        {
            this.isBackForm = false;
            this.Hide();
            formEdit.formSchemasInstance = this;
            formEdit.FormClosed += (s, args) => handleBackForm(s, args);
            formEdit.Show();
        }

        private void handleBackForm(object? s, FormClosedEventArgs args)
        {
            if (this.isBackForm)
                this.Show();
            else
                this.Close();
        }

        private void buttonSchemaUse_Click(object sender, EventArgs e)
        {
            this.isBackForm = false;
            if (comboBoxSchemas.SelectedIndex == -1)
            {
                MessageBox.Show(Constans.MessageSchemaChoose);
                return;
            }

            string? selectedValue = (comboBoxSchemas.SelectedItem as ComboboxItem)?.Value;

            if (checkBoxCache.Checked)
            {
                saveCacheSchemaName(selectedValue ?? "");
            }
            else
            {
                deleteCacheSchemaName();
            }

            this.Hide();
            FormGenerate formGenerate = new FormGenerate();
            formGenerate.formSchemasInstance = this;
            formGenerate.InitialSchemaFileName = selectedValue;
            formGenerate.FormClosed += (s, args) => handleBackForm(s, args);
            formGenerate.Show();
        }

        private void FormSchemas_Load(object sender, EventArgs e)
        {
            label2.Text = "© 2023 " + Constans.AppName + " | " + label2.Text;
            loadDataToForm();
        }

        public void loadDataToForm()
        {
            this.Text = Constans.AppName + " › Şablonlar";
            comboBoxSchemas.Items.Clear();

            string folder = @$"{ConfigurationManager.AppSettings.Get("RecordsPath") ?? @"C:\Apps\Excel2Excel\Records"}";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            buttonSchemaUse.Enabled = false;
            buttonSchemaEdit.Enabled = false;

            var folders = Directory.GetDirectories(folder);

            if(folders.Length > 0)
            {
                buttonSchemaUse.Enabled = true;
                buttonSchemaEdit.Enabled = true;
                foreach (var f in folders)
                {
                    var name = Path.GetFileName(f);
                    string textFile = @$"{folder}\{name}\{ConfigurationManager.AppSettings.Get("FileNameOwner") ?? "owner"}.txt";
                    string text = File.ReadAllText(textFile);
                    comboBoxSchemas.Items.Add(new ComboboxItem() { Text = text, Value = name });
                }
            }

            string cacheFileName = @$"{folder}\{ConfigurationManager.AppSettings.Get("FileNameCacheSelectedSchema") ?? "_cache"}.txt";
            if (File.Exists(cacheFileName))
            {
                string cacheName = File.ReadAllText(cacheFileName);
                for (int i = 0; i < comboBoxSchemas.Items.Count; i++)
                {
                    var item = (ComboboxItem)comboBoxSchemas.Items[i];
                    if (item.Value == cacheName)
                    {
                        comboBoxSchemas.SelectedItem = item;
                        checkBoxCache.Checked = true;
                        break;
                    }
                }
            }
        }

        private void saveCacheSchemaName(string schemaName)
        {
            string folder = @$"{ConfigurationManager.AppSettings.Get("RecordsPath") ?? @"C:\Apps\Excel2Excel\Records"}";
            string fileName = ConfigurationManager.AppSettings.Get("FileNameCacheSelectedSchema") ?? "_cache";
            saveFileSettingOptions(folder, fileName, schemaName);
        }

        private void deleteCacheSchemaName()
        {
            string folder = @$"{ConfigurationManager.AppSettings.Get("RecordsPath") ?? @"C:\Apps\Excel2Excel\Records"}";
            string fileName = ConfigurationManager.AppSettings.Get("FileNameCacheSelectedSchema") ?? "_cache";
            string path = @$"{folder}\{fileName}.txt";
            File.Delete(path);
        }

        private void saveFileSettingOptions(string folder, string fileName, string value)
        {
            string path = @$"{folder}\{fileName}.txt";
            TextWriter writer = new StreamWriter(path);
            writer.Write(value);
            writer.Close();
        }

    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

}
