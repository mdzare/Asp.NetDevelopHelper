namespace Asp.NetDevelopHelper
{
    partial class SchemaChanger
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
            schemaComboBox = new ComboBox();
            label2 = new Label();
            tableComboBox = new ComboBox();
            label1 = new Label();
            newSchemaCombobox = new ComboBox();
            label3 = new Label();
            saveButton = new Button();
            tableListBox = new TextBox();
            label4 = new Label();
            listBoxCheckButton = new Button();
            errorListBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            migrationCombobox = new ComboBox();
            changeMigrationBtn = new Button();
            SuspendLayout();
            // 
            // schemaComboBox
            // 
            schemaComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            schemaComboBox.FormattingEnabled = true;
            schemaComboBox.Location = new Point(546, 12);
            schemaComboBox.Name = "schemaComboBox";
            schemaComboBox.Size = new Size(201, 28);
            schemaComboBox.TabIndex = 7;
            schemaComboBox.SelectedIndexChanged += schemaComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(776, 14);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 6;
            label2.Text = "نام اسکیما";
            // 
            // tableComboBox
            // 
            tableComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableComboBox.FormattingEnabled = true;
            tableComboBox.Location = new Point(12, 14);
            tableComboBox.Name = "tableComboBox";
            tableComboBox.Size = new Size(456, 28);
            tableComboBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(474, 16);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 8;
            label1.Text = "نام جدول";
            // 
            // newSchemaCombobox
            // 
            newSchemaCombobox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newSchemaCombobox.FormattingEnabled = true;
            newSchemaCombobox.Location = new Point(546, 45);
            newSchemaCombobox.Name = "newSchemaCombobox";
            newSchemaCombobox.Size = new Size(201, 28);
            newSchemaCombobox.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(753, 48);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 10;
            label3.Text = "اسکیمای جدید";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(374, 455);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 12;
            saveButton.Text = "تغییر";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // tableListBox
            // 
            tableListBox.Location = new Point(12, 48);
            tableListBox.Multiline = true;
            tableListBox.Name = "tableListBox";
            tableListBox.Size = new Size(354, 436);
            tableListBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(374, 51);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 14;
            label4.Text = "تغییر لیستی";
            // 
            // listBoxCheckButton
            // 
            listBoxCheckButton.Location = new Point(372, 420);
            listBoxCheckButton.Name = "listBoxCheckButton";
            listBoxCheckButton.Size = new Size(94, 29);
            listBoxCheckButton.TabIndex = 15;
            listBoxCheckButton.Text = "بررسی لیست";
            listBoxCheckButton.UseVisualStyleBackColor = true;
            listBoxCheckButton.Click += listBoxCheckButton_Click;
            // 
            // errorListBox
            // 
            errorListBox.Location = new Point(474, 109);
            errorListBox.Multiline = true;
            errorListBox.Name = "errorListBox";
            errorListBox.Size = new Size(376, 375);
            errorListBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(738, 86);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 17;
            label5.Text = "لیست مشکل دار";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(727, 501);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(111, 20);
            label6.TabIndex = 18;
            label6.Text = "تغییر migration:";
            // 
            // migrationCombobox
            // 
            migrationCombobox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            migrationCombobox.FormattingEnabled = true;
            migrationCombobox.Location = new Point(268, 498);
            migrationCombobox.Name = "migrationCombobox";
            migrationCombobox.Size = new Size(453, 28);
            migrationCombobox.TabIndex = 19;
            // 
            // changeMigrationBtn
            // 
            changeMigrationBtn.Location = new Point(168, 498);
            changeMigrationBtn.Name = "changeMigrationBtn";
            changeMigrationBtn.RightToLeft = RightToLeft.Yes;
            changeMigrationBtn.Size = new Size(94, 29);
            changeMigrationBtn.TabIndex = 20;
            changeMigrationBtn.Text = "انجام تغییر!";
            changeMigrationBtn.UseVisualStyleBackColor = true;
            changeMigrationBtn.Click += changeMigrationBtn_Click;
            // 
            // SchemaChanger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 553);
            Controls.Add(changeMigrationBtn);
            Controls.Add(migrationCombobox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(errorListBox);
            Controls.Add(listBoxCheckButton);
            Controls.Add(label4);
            Controls.Add(tableListBox);
            Controls.Add(saveButton);
            Controls.Add(newSchemaCombobox);
            Controls.Add(label3);
            Controls.Add(tableComboBox);
            Controls.Add(label1);
            Controls.Add(schemaComboBox);
            Controls.Add(label2);
            Name = "SchemaChanger";
            Text = "SchemaChanger";
            Shown += SchemaChanger_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox schemaComboBox;
        private Label label2;
        private ComboBox tableComboBox;
        private Label label1;
        private ComboBox newSchemaCombobox;
        private Label label3;
        private Button saveButton;
        private TextBox tableListBox;
        private Label label4;
        private Button listBoxCheckButton;
        private TextBox errorListBox;
        private Label label5;
        private Label label6;
        private ComboBox migrationCombobox;
        private Button changeMigrationBtn;
    }
}