using Asp.NetDevelopHelper.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Asp.NetDevelopHelper
{
    public partial class SchemaChanger : Form
    {
        public string ProjectPath { get; set; }
        private bool tableCheck;
        public SchemaChanger()
        {
            InitializeComponent();
        }

        private void SchemaChanger_Shown(object sender, EventArgs e)
        {
            schemaComboBox.Items.Clear();
            schemaComboBox.Items.AddRange(ServiceCreator.GetSchemas(ProjectPath).ToArray());

            newSchemaCombobox.Items.Clear();
            newSchemaCombobox.Items.AddRange(schemaComboBox.Items.Cast<string>().ToArray());

            migrationCombobox.Items.AddRange(ServiceCreator.GetMigrations(ProjectPath).ToArray());
        }

        private void schemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tables = ServiceCreator.GetTables(ProjectPath, schemaComboBox.Text);
            tableComboBox.Items.Clear();
            tableComboBox.Items.AddRange(tables.ToArray());

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var list = tableListBox.Text.Split("\r\n").Where(x => !string.IsNullOrWhiteSpace(x));
            list.Append(tableComboBox.Text);

            if (!tableCheck && string.IsNullOrWhiteSpace(tableComboBox.Text))
            {
                MessageBox.Show("جداول انتخابی بررسی نشده است");
                return;
            }
            if (list.Count() == 0)
            {
                MessageBox.Show("هیچ جدولی وجود ندارد");
                return;
            }
            if (string.IsNullOrWhiteSpace(schemaComboBox.Text) || string.IsNullOrWhiteSpace(newSchemaCombobox.Text))
            {
                MessageBox.Show("اسکیما انتخاب نشده است");
                return;
            }

            var service = new SchemaService(ProjectPath);

            foreach (var table in list)
            {
                service.ChangeSchema(schemaComboBox.Text, table, newSchemaCombobox.Text);
            }
            MessageBox.Show("انجام شد!");

        }

        private void listBoxCheckButton_Click(object sender, EventArgs e)
        {
            var list = tableListBox.Text.Split("\r\n").Where(x => !string.IsNullOrWhiteSpace(x));
            var error = "";
            foreach (var item in list)
            {
                if (!IO.IOService.FileExists(ProjectPath + $"\\ArvinERP.Domain\\Models\\{schemaComboBox.Text}\\{item}.cs"))
                {
                    tableListBox.Text = tableListBox.Text.Replace($"\r\n{item}\r\n", $"\r\n\r\n");
                    error += $"\r\n{item}";
                }
            }
            errorListBox.Text = errorListBox.Text + error;
            if (error.Length > 0)
                MessageBox.Show("برخی جداول یافت نشد");
            else
            {
                tableCheck = true;
                MessageBox.Show("همه جداول بررسی شد");
            }
        }

        private void changeMigrationBtn_Click(object sender, EventArgs e)
        {
            var list = tableListBox.Text.Split("\r\n").Where(x => !string.IsNullOrWhiteSpace(x));
            list.Append(tableComboBox.Text);

            var serv = new SchemaService(ProjectPath);

           var res = serv.ChangeMigration(schemaComboBox.Text, list.ToArray(), newSchemaCombobox.Text, migrationCombobox.Text);
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, res);
                }
            }
        }
    }
}
