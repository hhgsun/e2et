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

namespace excel_deskapp
{
    public partial class FormSchemas : Form
    {
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
            formEdit.formSchemasInstance = this;
            formEdit.Show();
        }

        private void buttonSchemaUse_Click(object sender, EventArgs e)
        {
            if (comboBoxSchemas.SelectedIndex == -1)
            {
                MessageBox.Show(Constans.MessageSchemaChoose);
                return;
            }
            FormGenerate formGenerate = new FormGenerate();
            formGenerate.InitialSchemaFileName = (comboBoxSchemas.SelectedItem as ComboboxItem)?.Value;
            formGenerate.Show();
        }

        private void FormSchemas_Load(object sender, EventArgs e)
        {
            string folder = @$"{ConfigurationManager.AppSettings.Get("RecordsPath") ?? @"C:\Apps\Excel2Excel\Records"}";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var folders = Directory.GetDirectories(folder);

            foreach ( var f in folders )
            {
                var name = Path.GetFileName(f);
                string textFile = @$"{folder}\{name}\{ConfigurationManager.AppSettings.Get("FileNameOwner") ?? "owner"}.txt";
                string text = File.ReadAllText(textFile);
                comboBoxSchemas.Items.Add(new ComboboxItem() { Text = text, Value = name});
            }
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
