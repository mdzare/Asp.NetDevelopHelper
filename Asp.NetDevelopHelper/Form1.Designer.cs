namespace Asp.NetDevelopHelper
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            prjPathTextbx = new TextBox();
            openPrjPathBtn = new Button();
            label1 = new Label();
            executeBtn = new Button();
            label2 = new Label();
            tableTxbx = new TextBox();
            label3 = new Label();
            topPanel = new Panel();
            schemaChanger = new Button();
            InheretedCheckBox = new CheckBox();
            schemaComboBox = new ComboBox();
            keyTypeCombo = new ComboBox();
            hasYearCheckBox = new CheckBox();
            tableCaptionTxbx = new TextBox();
            yearIndexTxbx = new TextBox();
            yearTextBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            undoBtn = new Button();
            label4 = new Label();
            relationTab = new TabPage();
            relationPanel = new Panel();
            relationDataGridView = new DataGridView();
            Schema = new DataGridViewComboBoxColumn();
            Table = new DataGridViewComboBoxColumn();
            PrincipalKey = new DataGridViewComboBoxColumn();
            ForeignKey = new DataGridViewComboBoxColumn();
            dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            DeleteBehave = new DataGridViewComboBoxColumn();
            SoftDelete = new DataGridViewCheckBoxColumn();
            SoftRelation = new DataGridViewCheckBoxColumn();
            propsTab = new TabPage();
            mainPanel = new Panel();
            propertiesDataGridView = new DataGridView();
            PropName = new DataGridViewTextBoxColumn();
            Caption = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Required = new DataGridViewCheckBoxColumn();
            MaxLength = new DataGridViewTextBoxColumn();
            MinLength = new DataGridViewTextBoxColumn();
            RegEx = new DataGridViewTextBoxColumn();
            Unique = new DataGridViewTextBoxColumn();
            Key = new DataGridViewCheckBoxColumn();
            Index = new DataGridViewCheckBoxColumn();
            BasicCode = new DataGridViewTextBoxColumn();
            Title = new DataGridViewCheckBoxColumn();
            settingTab = new TabPage();
            textBox2 = new TextBox();
            button2 = new Button();
            label12 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label11 = new Label();
            relationCreateCheck = new CheckBox();
            contextReferenceCreateCheck = new CheckBox();
            mappingCreateCheck = new CheckBox();
            controllerCreateCheck = new CheckBox();
            serviceCreateCheck = new CheckBox();
            repositoryCreateCheck = new CheckBox();
            viewModelCreateCheck = new CheckBox();
            dtoCreateCheck = new CheckBox();
            modelCreateCheck = new CheckBox();
            opnCoreWebPathBtn = new Button();
            coreWebPathTxtBox = new TextBox();
            label10 = new Label();
            appPathTtextBox = new TextBox();
            opnApplPathBtn = new Button();
            resourceCreateCheck = new CheckBox();
            label9 = new Label();
            infraPathTxtBx = new TextBox();
            opnInfraPathBtn = new Button();
            label8 = new Label();
            domainPathTxtBx = new TextBox();
            opnDomainPathBtn = new Button();
            label6 = new Label();
            mainTabControl = new TabControl();
            topPanel.SuspendLayout();
            relationTab.SuspendLayout();
            relationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)relationDataGridView).BeginInit();
            propsTab.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).BeginInit();
            settingTab.SuspendLayout();
            mainTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // prjPathTextbx
            // 
            prjPathTextbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            prjPathTextbx.Location = new Point(458, 11);
            prjPathTextbx.Name = "prjPathTextbx";
            prjPathTextbx.ReadOnly = true;
            prjPathTextbx.Size = new Size(681, 27);
            prjPathTextbx.TabIndex = 0;
            prjPathTextbx.TextChanged += prjPathTextbx_TextChanged;
            // 
            // openPrjPathBtn
            // 
            openPrjPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            openPrjPathBtn.Location = new Point(405, 10);
            openPrjPathBtn.Name = "openPrjPathBtn";
            openPrjPathBtn.Size = new Size(47, 29);
            openPrjPathBtn.TabIndex = 1;
            openPrjPathBtn.Text = ". . .";
            openPrjPathBtn.UseVisualStyleBackColor = true;
            openPrjPathBtn.Click += openPrjPathBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1145, 14);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "مسیر پروژه";
            // 
            // executeBtn
            // 
            executeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            executeBtn.BackColor = Color.Lime;
            executeBtn.Location = new Point(292, 14);
            executeBtn.Name = "executeBtn";
            executeBtn.Size = new Size(74, 29);
            executeBtn.TabIndex = 1;
            executeBtn.Text = "اجرا";
            executeBtn.UseVisualStyleBackColor = false;
            executeBtn.Click += executeBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1145, 56);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "نام اسکیما";
            // 
            // tableTxbx
            // 
            tableTxbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableTxbx.Location = new Point(703, 53);
            tableTxbx.Name = "tableTxbx";
            tableTxbx.RightToLeft = RightToLeft.No;
            tableTxbx.Size = new Size(202, 27);
            tableTxbx.TabIndex = 0;
            tableTxbx.TextChanged += Txbx_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(911, 56);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "نام جدول";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(schemaChanger);
            topPanel.Controls.Add(InheretedCheckBox);
            topPanel.Controls.Add(schemaComboBox);
            topPanel.Controls.Add(keyTypeCombo);
            topPanel.Controls.Add(hasYearCheckBox);
            topPanel.Controls.Add(tableCaptionTxbx);
            topPanel.Controls.Add(yearIndexTxbx);
            topPanel.Controls.Add(yearTextBox);
            topPanel.Controls.Add(tableTxbx);
            topPanel.Controls.Add(label5);
            topPanel.Controls.Add(label7);
            topPanel.Controls.Add(label3);
            topPanel.Controls.Add(undoBtn);
            topPanel.Controls.Add(executeBtn);
            topPanel.Controls.Add(prjPathTextbx);
            topPanel.Controls.Add(label4);
            topPanel.Controls.Add(label2);
            topPanel.Controls.Add(openPrjPathBtn);
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1248, 124);
            topPanel.TabIndex = 3;
            // 
            // schemaChanger
            // 
            schemaChanger.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            schemaChanger.Location = new Point(12, 9);
            schemaChanger.Name = "schemaChanger";
            schemaChanger.Size = new Size(100, 29);
            schemaChanger.TabIndex = 8;
            schemaChanger.Text = "تغییر اسکیما";
            schemaChanger.UseVisualStyleBackColor = true;
            schemaChanger.Click += schemaChanger_Click;
            // 
            // InheretedCheckBox
            // 
            InheretedCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InheretedCheckBox.AutoSize = true;
            InheretedCheckBox.Checked = true;
            InheretedCheckBox.CheckState = CheckState.Checked;
            InheretedCheckBox.Location = new Point(1112, 87);
            InheretedCheckBox.Name = "InheretedCheckBox";
            InheretedCheckBox.RightToLeft = RightToLeft.Yes;
            InheretedCheckBox.Size = new Size(110, 24);
            InheretedCheckBox.TabIndex = 7;
            InheretedCheckBox.Text = "جدول وراثتی";
            InheretedCheckBox.UseVisualStyleBackColor = true;
            // 
            // schemaComboBox
            // 
            schemaComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            schemaComboBox.FormattingEnabled = true;
            schemaComboBox.Location = new Point(988, 54);
            schemaComboBox.Name = "schemaComboBox";
            schemaComboBox.Size = new Size(151, 28);
            schemaComboBox.TabIndex = 5;
            // 
            // keyTypeCombo
            // 
            keyTypeCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyTypeCombo.FormattingEnabled = true;
            keyTypeCombo.Items.AddRange(new object[] { "long", "int", "string" });
            keyTypeCombo.Location = new Point(895, 86);
            keyTypeCombo.Name = "keyTypeCombo";
            keyTypeCombo.RightToLeft = RightToLeft.No;
            keyTypeCombo.Size = new Size(112, 28);
            keyTypeCombo.TabIndex = 4;
            keyTypeCombo.Text = "long";
            keyTypeCombo.SelectedIndexChanged += dataTypeCombo_SelectedIndexChanged;
            // 
            // hasYearCheckBox
            // 
            hasYearCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hasYearCheckBox.AutoSize = true;
            hasYearCheckBox.Checked = true;
            hasYearCheckBox.CheckState = CheckState.Checked;
            hasYearCheckBox.Location = new Point(754, 87);
            hasYearCheckBox.Name = "hasYearCheckBox";
            hasYearCheckBox.RightToLeft = RightToLeft.Yes;
            hasYearCheckBox.Size = new Size(125, 24);
            hasYearCheckBox.TabIndex = 3;
            hasYearCheckBox.Text = "سال مالی دارد:";
            hasYearCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableCaptionTxbx
            // 
            tableCaptionTxbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableCaptionTxbx.Location = new Point(405, 53);
            tableCaptionTxbx.Name = "tableCaptionTxbx";
            tableCaptionTxbx.RightToLeft = RightToLeft.Yes;
            tableCaptionTxbx.Size = new Size(178, 27);
            tableCaptionTxbx.TabIndex = 0;
            tableCaptionTxbx.TextAlign = HorizontalAlignment.Right;
            // 
            // yearIndexTxbx
            // 
            yearIndexTxbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yearIndexTxbx.Location = new Point(464, 86);
            yearIndexTxbx.Name = "yearIndexTxbx";
            yearIndexTxbx.Size = new Size(71, 27);
            yearIndexTxbx.TabIndex = 0;
            yearIndexTxbx.TextChanged += Txbx_TextChanged;
            // 
            // yearTextBox
            // 
            yearTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yearTextBox.Location = new Point(678, 86);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.RightToLeft = RightToLeft.No;
            yearTextBox.Size = new Size(70, 27);
            yearTextBox.TabIndex = 0;
            yearTextBox.Text = "Year{}";
            yearTextBox.TextChanged += Txbx_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(589, 56);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 2;
            label5.Text = "نام فارسی جدول";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(541, 89);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(123, 20);
            label7.TabIndex = 2;
            label7.Text = "ایندکس سال مالی";
            // 
            // undoBtn
            // 
            undoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            undoBtn.BackColor = Color.Red;
            undoBtn.ForeColor = SystemColors.Info;
            undoBtn.Location = new Point(212, 14);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(74, 29);
            undoBtn.TabIndex = 1;
            undoBtn.Text = "Undo!!!";
            undoBtn.UseVisualStyleBackColor = false;
            undoBtn.Click += undoBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1013, 90);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(82, 20);
            label4.TabIndex = 2;
            label4.Text = "کلید وراثتی:";
            // 
            // relationTab
            // 
            relationTab.Controls.Add(relationPanel);
            relationTab.Location = new Point(4, 29);
            relationTab.Name = "relationTab";
            relationTab.Padding = new Padding(3);
            relationTab.Size = new Size(1240, 505);
            relationTab.TabIndex = 1;
            relationTab.Text = "روابط جدول";
            relationTab.UseVisualStyleBackColor = true;
            // 
            // relationPanel
            // 
            relationPanel.BackColor = Color.Gainsboro;
            relationPanel.Controls.Add(relationDataGridView);
            relationPanel.Dock = DockStyle.Fill;
            relationPanel.Location = new Point(3, 3);
            relationPanel.Name = "relationPanel";
            relationPanel.Size = new Size(1234, 499);
            relationPanel.TabIndex = 0;
            // 
            // relationDataGridView
            // 
            relationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            relationDataGridView.Columns.AddRange(new DataGridViewColumn[] { Schema, Table, PrincipalKey, ForeignKey, dataGridViewComboBoxColumn1, DeleteBehave, SoftDelete, SoftRelation });
            relationDataGridView.Dock = DockStyle.Fill;
            relationDataGridView.Location = new Point(0, 0);
            relationDataGridView.Name = "relationDataGridView";
            relationDataGridView.RightToLeft = RightToLeft.Yes;
            relationDataGridView.RowHeadersWidth = 51;
            relationDataGridView.RowTemplate.Height = 29;
            relationDataGridView.Size = new Size(1234, 499);
            relationDataGridView.TabIndex = 0;
            relationDataGridView.CellValueChanged += relationDataGridView_CellValueChanged;
            // 
            // Schema
            // 
            Schema.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Schema.DefaultCellStyle = dataGridViewCellStyle1;
            Schema.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Schema.Frozen = true;
            Schema.HeaderText = "Schema";
            Schema.MinimumWidth = 150;
            Schema.Name = "Schema";
            Schema.Width = 150;
            // 
            // Table
            // 
            Table.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Table.HeaderText = "Table";
            Table.MinimumWidth = 150;
            Table.Name = "Table";
            Table.Width = 150;
            // 
            // PrincipalKey
            // 
            PrincipalKey.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PrincipalKey.HeaderText = "PrincipalKey";
            PrincipalKey.MinimumWidth = 150;
            PrincipalKey.Name = "PrincipalKey";
            PrincipalKey.Resizable = DataGridViewTriState.True;
            PrincipalKey.SortMode = DataGridViewColumnSortMode.Automatic;
            PrincipalKey.Width = 150;
            // 
            // ForeignKey
            // 
            ForeignKey.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ForeignKey.HeaderText = "ForeignKey";
            ForeignKey.MinimumWidth = 150;
            ForeignKey.Name = "ForeignKey";
            ForeignKey.Width = 150;
            // 
            // dataGridViewComboBoxColumn1
            // 
            dataGridViewComboBoxColumn1.HeaderText = "Type";
            dataGridViewComboBoxColumn1.Items.AddRange(new object[] { "One2Many", "One2One", "Many2Many" });
            dataGridViewComboBoxColumn1.MinimumWidth = 6;
            dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            dataGridViewComboBoxColumn1.Width = 125;
            // 
            // DeleteBehave
            // 
            DeleteBehave.HeaderText = "DeleteBehave";
            DeleteBehave.Items.AddRange(new object[] { "NoAction", "Cascade", "SetNull" });
            DeleteBehave.MinimumWidth = 6;
            DeleteBehave.Name = "DeleteBehave";
            DeleteBehave.Resizable = DataGridViewTriState.True;
            DeleteBehave.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteBehave.Width = 125;
            // 
            // SoftDelete
            // 
            SoftDelete.HeaderText = "SoftDelete";
            SoftDelete.MinimumWidth = 6;
            SoftDelete.Name = "SoftDelete";
            SoftDelete.Width = 125;
            // 
            // SoftRelation
            // 
            SoftRelation.HeaderText = "SoftRelation";
            SoftRelation.MinimumWidth = 6;
            SoftRelation.Name = "SoftRelation";
            SoftRelation.Width = 125;
            // 
            // propsTab
            // 
            propsTab.Controls.Add(mainPanel);
            propsTab.Location = new Point(4, 29);
            propsTab.Name = "propsTab";
            propsTab.Padding = new Padding(3);
            propsTab.Size = new Size(1240, 505);
            propsTab.TabIndex = 0;
            propsTab.Text = "اطلاعات جدول";
            propsTab.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(propertiesDataGridView);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(3, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1234, 499);
            mainPanel.TabIndex = 5;
            // 
            // propertiesDataGridView
            // 
            propertiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            propertiesDataGridView.Columns.AddRange(new DataGridViewColumn[] { PropName, Caption, Type, Required, MaxLength, MinLength, RegEx, Unique, Key, Index, BasicCode, Title });
            propertiesDataGridView.Dock = DockStyle.Fill;
            propertiesDataGridView.Location = new Point(0, 0);
            propertiesDataGridView.Name = "propertiesDataGridView";
            propertiesDataGridView.RightToLeft = RightToLeft.Yes;
            propertiesDataGridView.RowHeadersWidth = 51;
            propertiesDataGridView.RowTemplate.Height = 29;
            propertiesDataGridView.Size = new Size(1234, 499);
            propertiesDataGridView.TabIndex = 0;
            propertiesDataGridView.CellValueChanged += propertiesDataGridView_CellValueChanged;
            propertiesDataGridView.KeyDown += Form1_KeyDown;
            // 
            // PropName
            // 
            PropName.HeaderText = "Property";
            PropName.MinimumWidth = 6;
            PropName.Name = "PropName";
            PropName.Width = 250;
            // 
            // Caption
            // 
            Caption.HeaderText = "Caption";
            Caption.MinimumWidth = 6;
            Caption.Name = "Caption";
            Caption.Width = 200;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 80;
            // 
            // Required
            // 
            Required.HeaderText = "Required";
            Required.MinimumWidth = 6;
            Required.Name = "Required";
            Required.Width = 70;
            // 
            // MaxLength
            // 
            MaxLength.HeaderText = "MaxLength";
            MaxLength.MinimumWidth = 6;
            MaxLength.Name = "MaxLength";
            MaxLength.Width = 80;
            // 
            // MinLength
            // 
            MinLength.HeaderText = "MinLength";
            MinLength.MinimumWidth = 6;
            MinLength.Name = "MinLength";
            MinLength.Width = 80;
            // 
            // RegEx
            // 
            RegEx.HeaderText = "RegEx";
            RegEx.MinimumWidth = 6;
            RegEx.Name = "RegEx";
            RegEx.Width = 150;
            // 
            // Unique
            // 
            Unique.HeaderText = "Unique";
            Unique.MinimumWidth = 6;
            Unique.Name = "Unique";
            Unique.Width = 70;
            // 
            // Key
            // 
            Key.HeaderText = "Key";
            Key.MinimumWidth = 6;
            Key.Name = "Key";
            Key.Resizable = DataGridViewTriState.True;
            Key.SortMode = DataGridViewColumnSortMode.Automatic;
            Key.Width = 35;
            // 
            // Index
            // 
            Index.HeaderText = "Index";
            Index.MinimumWidth = 6;
            Index.Name = "Index";
            Index.Width = 45;
            // 
            // BasicCode
            // 
            BasicCode.HeaderText = "BasicCode";
            BasicCode.MinimumWidth = 6;
            BasicCode.Name = "BasicCode";
            BasicCode.Width = 80;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 40;
            // 
            // settingTab
            // 
            settingTab.BackColor = SystemColors.ControlLight;
            settingTab.Controls.Add(textBox2);
            settingTab.Controls.Add(button2);
            settingTab.Controls.Add(label12);
            settingTab.Controls.Add(textBox1);
            settingTab.Controls.Add(button1);
            settingTab.Controls.Add(label11);
            settingTab.Controls.Add(relationCreateCheck);
            settingTab.Controls.Add(contextReferenceCreateCheck);
            settingTab.Controls.Add(mappingCreateCheck);
            settingTab.Controls.Add(controllerCreateCheck);
            settingTab.Controls.Add(serviceCreateCheck);
            settingTab.Controls.Add(repositoryCreateCheck);
            settingTab.Controls.Add(viewModelCreateCheck);
            settingTab.Controls.Add(dtoCreateCheck);
            settingTab.Controls.Add(modelCreateCheck);
            settingTab.Controls.Add(opnCoreWebPathBtn);
            settingTab.Controls.Add(coreWebPathTxtBox);
            settingTab.Controls.Add(label10);
            settingTab.Controls.Add(appPathTtextBox);
            settingTab.Controls.Add(opnApplPathBtn);
            settingTab.Controls.Add(resourceCreateCheck);
            settingTab.Controls.Add(label9);
            settingTab.Controls.Add(infraPathTxtBx);
            settingTab.Controls.Add(opnInfraPathBtn);
            settingTab.Controls.Add(label8);
            settingTab.Controls.Add(domainPathTxtBx);
            settingTab.Controls.Add(opnDomainPathBtn);
            settingTab.Controls.Add(label6);
            settingTab.Location = new Point(4, 29);
            settingTab.Name = "settingTab";
            settingTab.Padding = new Padding(3);
            settingTab.Size = new Size(1240, 505);
            settingTab.TabIndex = 2;
            settingTab.Text = "تنظیمات";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Location = new Point(68, 204);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(681, 27);
            textBox2.TabIndex = 33;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(15, 203);
            button2.Name = "button2";
            button2.Size = new Size(47, 29);
            button2.TabIndex = 34;
            button2.Text = ". . .";
            button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(755, 207);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 35;
            label12.Text = "Context Path";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(68, 171);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(681, 27);
            textBox1.TabIndex = 30;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(15, 170);
            button1.Name = "button1";
            button1.Size = new Size(47, 29);
            button1.TabIndex = 31;
            button1.Text = ". . .";
            button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(755, 174);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 32;
            label11.Text = "Mapper Path";
            // 
            // relationCreateCheck
            // 
            relationCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            relationCreateCheck.AutoSize = true;
            relationCreateCheck.Checked = true;
            relationCreateCheck.CheckState = CheckState.Checked;
            relationCreateCheck.Location = new Point(1001, 294);
            relationCreateCheck.Name = "relationCreateCheck";
            relationCreateCheck.RightToLeft = RightToLeft.Yes;
            relationCreateCheck.Size = new Size(138, 24);
            relationCreateCheck.TabIndex = 29;
            relationCreateCheck.Text = "ایجاد/حذف روابط";
            relationCreateCheck.UseVisualStyleBackColor = true;
            // 
            // contextReferenceCreateCheck
            // 
            contextReferenceCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            contextReferenceCreateCheck.AutoSize = true;
            contextReferenceCreateCheck.Checked = true;
            contextReferenceCreateCheck.CheckState = CheckState.Checked;
            contextReferenceCreateCheck.Location = new Point(940, 264);
            contextReferenceCreateCheck.Name = "contextReferenceCreateCheck";
            contextReferenceCreateCheck.RightToLeft = RightToLeft.Yes;
            contextReferenceCreateCheck.Size = new Size(199, 24);
            contextReferenceCreateCheck.TabIndex = 28;
            contextReferenceCreateCheck.Text = "ایجاد/حذف رفرنس Context";
            contextReferenceCreateCheck.UseVisualStyleBackColor = true;
            // 
            // mappingCreateCheck
            // 
            mappingCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mappingCreateCheck.AutoSize = true;
            mappingCreateCheck.Location = new Point(976, 114);
            mappingCreateCheck.Name = "mappingCreateCheck";
            mappingCreateCheck.RightToLeft = RightToLeft.Yes;
            mappingCreateCheck.Size = new Size(163, 24);
            mappingCreateCheck.TabIndex = 27;
            mappingCreateCheck.Text = "ایجاد/حذف Mapping";
            mappingCreateCheck.UseVisualStyleBackColor = true;
            mappingCreateCheck.CheckedChanged += mappingCreateCheck_CheckedChanged;
            // 
            // controllerCreateCheck
            // 
            controllerCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controllerCreateCheck.AutoSize = true;
            controllerCreateCheck.Checked = true;
            controllerCreateCheck.CheckState = CheckState.Checked;
            controllerCreateCheck.Location = new Point(970, 204);
            controllerCreateCheck.Name = "controllerCreateCheck";
            controllerCreateCheck.RightToLeft = RightToLeft.Yes;
            controllerCreateCheck.Size = new Size(169, 24);
            controllerCreateCheck.TabIndex = 26;
            controllerCreateCheck.Text = "ایجاد/حذف Controller";
            controllerCreateCheck.UseVisualStyleBackColor = true;
            // 
            // serviceCreateCheck
            // 
            serviceCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            serviceCreateCheck.AutoSize = true;
            serviceCreateCheck.Checked = true;
            serviceCreateCheck.CheckState = CheckState.Checked;
            serviceCreateCheck.Location = new Point(989, 174);
            serviceCreateCheck.Name = "serviceCreateCheck";
            serviceCreateCheck.RightToLeft = RightToLeft.Yes;
            serviceCreateCheck.Size = new Size(150, 24);
            serviceCreateCheck.TabIndex = 25;
            serviceCreateCheck.Text = "ایجاد/حذف Service";
            serviceCreateCheck.UseVisualStyleBackColor = true;
            // 
            // repositoryCreateCheck
            // 
            repositoryCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            repositoryCreateCheck.AutoSize = true;
            repositoryCreateCheck.Checked = true;
            repositoryCreateCheck.CheckState = CheckState.Checked;
            repositoryCreateCheck.Location = new Point(965, 144);
            repositoryCreateCheck.Name = "repositoryCreateCheck";
            repositoryCreateCheck.RightToLeft = RightToLeft.Yes;
            repositoryCreateCheck.Size = new Size(174, 24);
            repositoryCreateCheck.TabIndex = 24;
            repositoryCreateCheck.Text = "ایجاد/حذف Repository";
            repositoryCreateCheck.UseVisualStyleBackColor = true;
            // 
            // viewModelCreateCheck
            // 
            viewModelCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewModelCreateCheck.AutoSize = true;
            viewModelCreateCheck.Checked = true;
            viewModelCreateCheck.CheckState = CheckState.Checked;
            viewModelCreateCheck.Location = new Point(961, 84);
            viewModelCreateCheck.Name = "viewModelCreateCheck";
            viewModelCreateCheck.RightToLeft = RightToLeft.Yes;
            viewModelCreateCheck.Size = new Size(178, 24);
            viewModelCreateCheck.TabIndex = 23;
            viewModelCreateCheck.Text = "ایجاد/حذف ViewModel";
            viewModelCreateCheck.UseVisualStyleBackColor = true;
            // 
            // dtoCreateCheck
            // 
            dtoCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtoCreateCheck.AutoSize = true;
            dtoCreateCheck.Checked = true;
            dtoCreateCheck.CheckState = CheckState.Checked;
            dtoCreateCheck.Location = new Point(1011, 54);
            dtoCreateCheck.Name = "dtoCreateCheck";
            dtoCreateCheck.RightToLeft = RightToLeft.Yes;
            dtoCreateCheck.Size = new Size(128, 24);
            dtoCreateCheck.TabIndex = 22;
            dtoCreateCheck.Text = "ایجاد/حذف Dto";
            dtoCreateCheck.UseVisualStyleBackColor = true;
            // 
            // modelCreateCheck
            // 
            modelCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            modelCreateCheck.AutoSize = true;
            modelCreateCheck.Checked = true;
            modelCreateCheck.CheckState = CheckState.Checked;
            modelCreateCheck.Location = new Point(993, 24);
            modelCreateCheck.Name = "modelCreateCheck";
            modelCreateCheck.RightToLeft = RightToLeft.Yes;
            modelCreateCheck.Size = new Size(146, 24);
            modelCreateCheck.TabIndex = 21;
            modelCreateCheck.Text = "ایجاد/حذف Model";
            modelCreateCheck.UseVisualStyleBackColor = true;
            // 
            // opnCoreWebPathBtn
            // 
            opnCoreWebPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opnCoreWebPathBtn.Location = new Point(15, 27);
            opnCoreWebPathBtn.Name = "opnCoreWebPathBtn";
            opnCoreWebPathBtn.Size = new Size(47, 29);
            opnCoreWebPathBtn.TabIndex = 20;
            opnCoreWebPathBtn.Text = ". . .";
            opnCoreWebPathBtn.UseVisualStyleBackColor = true;
            // 
            // coreWebPathTxtBox
            // 
            coreWebPathTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coreWebPathTxtBox.Location = new Point(68, 24);
            coreWebPathTxtBox.Name = "coreWebPathTxtBox";
            coreWebPathTxtBox.ReadOnly = true;
            coreWebPathTxtBox.Size = new Size(681, 27);
            coreWebPathTxtBox.TabIndex = 18;
            coreWebPathTxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(755, 27);
            label10.Name = "label10";
            label10.Size = new Size(125, 20);
            label10.TabIndex = 19;
            label10.Text = "Asp.net Core Path";
            // 
            // appPathTtextBox
            // 
            appPathTtextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            appPathTtextBox.Location = new Point(68, 63);
            appPathTtextBox.Name = "appPathTtextBox";
            appPathTtextBox.ReadOnly = true;
            appPathTtextBox.Size = new Size(681, 27);
            appPathTtextBox.TabIndex = 15;
            appPathTtextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // opnApplPathBtn
            // 
            opnApplPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opnApplPathBtn.Location = new Point(15, 62);
            opnApplPathBtn.Name = "opnApplPathBtn";
            opnApplPathBtn.Size = new Size(47, 29);
            opnApplPathBtn.TabIndex = 16;
            opnApplPathBtn.Text = ". . .";
            opnApplPathBtn.UseVisualStyleBackColor = true;
            // 
            // resourceCreateCheck
            // 
            resourceCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resourceCreateCheck.AutoSize = true;
            resourceCreateCheck.Checked = true;
            resourceCreateCheck.CheckState = CheckState.Checked;
            resourceCreateCheck.Location = new Point(976, 234);
            resourceCreateCheck.Name = "resourceCreateCheck";
            resourceCreateCheck.RightToLeft = RightToLeft.Yes;
            resourceCreateCheck.Size = new Size(163, 24);
            resourceCreateCheck.TabIndex = 8;
            resourceCreateCheck.Text = "ایجاد/حذف Resource";
            resourceCreateCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(755, 66);
            label9.Name = "label9";
            label9.Size = new Size(118, 20);
            label9.TabIndex = 17;
            label9.Text = "Application Path";
            // 
            // infraPathTxtBx
            // 
            infraPathTxtBx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            infraPathTxtBx.Location = new Point(68, 98);
            infraPathTxtBx.Name = "infraPathTxtBx";
            infraPathTxtBx.ReadOnly = true;
            infraPathTxtBx.Size = new Size(681, 27);
            infraPathTxtBx.TabIndex = 12;
            infraPathTxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // opnInfraPathBtn
            // 
            opnInfraPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opnInfraPathBtn.Location = new Point(15, 97);
            opnInfraPathBtn.Name = "opnInfraPathBtn";
            opnInfraPathBtn.Size = new Size(47, 29);
            opnInfraPathBtn.TabIndex = 13;
            opnInfraPathBtn.Text = ". . .";
            opnInfraPathBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(755, 101);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 14;
            label8.Text = "Infrastructure Path";
            // 
            // domainPathTxtBx
            // 
            domainPathTxtBx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            domainPathTxtBx.Location = new Point(68, 133);
            domainPathTxtBx.Name = "domainPathTxtBx";
            domainPathTxtBx.ReadOnly = true;
            domainPathTxtBx.Size = new Size(681, 27);
            domainPathTxtBx.TabIndex = 9;
            domainPathTxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // opnDomainPathBtn
            // 
            opnDomainPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opnDomainPathBtn.Location = new Point(15, 132);
            opnDomainPathBtn.Name = "opnDomainPathBtn";
            opnDomainPathBtn.Size = new Size(47, 29);
            opnDomainPathBtn.TabIndex = 10;
            opnDomainPathBtn.Text = ". . .";
            opnDomainPathBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(755, 136);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 11;
            label6.Text = "Domain Path";
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(settingTab);
            mainTabControl.Controls.Add(propsTab);
            mainTabControl.Controls.Add(relationTab);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 124);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.RightToLeft = RightToLeft.Yes;
            mainTabControl.RightToLeftLayout = true;
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1248, 538);
            mainTabControl.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 662);
            Controls.Add(mainTabControl);
            Controls.Add(topPanel);
            MinimumSize = new Size(886, 709);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            relationTab.ResumeLayout(false);
            relationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)relationDataGridView).EndInit();
            propsTab.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).EndInit();
            settingTab.ResumeLayout(false);
            settingTab.PerformLayout();
            mainTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox prjPathTextbx;
        private Button openPrjPathBtn;
        private Label label1;
        private Button executeBtn;
        private Label label2;
        private TextBox tableTxbx;
        private Label label3;
        private Panel topPanel;
        private TextBox tableCaptionTxbx;
        private Label label5;
        private CheckBox hasYearCheckBox;
        private TextBox yearTextBox;
        private Button undoBtn;
        private ComboBox keyTypeCombo;
        private TextBox yearIndexTxbx;
        private Label label7;
        private ComboBox schemaComboBox;
        private CheckBox InheretedCheckBox;
        private Label label4;
        private TabPage relationTab;
        private Panel relationPanel;
        private DataGridView relationDataGridView;
        private DataGridViewComboBoxColumn Schema;
        private DataGridViewComboBoxColumn Table;
        private DataGridViewComboBoxColumn PrincipalKey;
        private DataGridViewComboBoxColumn ForeignKey;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewComboBoxColumn DeleteBehave;
        private DataGridViewCheckBoxColumn SoftDelete;
        private DataGridViewCheckBoxColumn SoftRelation;
        private TabPage propsTab;
        private Panel mainPanel;
        private DataGridView propertiesDataGridView;
        private TabPage settingTab;
        private TextBox textBox2;
        private Button button2;
        private Label label12;
        private TextBox textBox1;
        private Button button1;
        private Label label11;
        private CheckBox relationCreateCheck;
        private CheckBox contextReferenceCreateCheck;
        private CheckBox mappingCreateCheck;
        private CheckBox controllerCreateCheck;
        private CheckBox serviceCreateCheck;
        private CheckBox repositoryCreateCheck;
        private CheckBox viewModelCreateCheck;
        private CheckBox dtoCreateCheck;
        private CheckBox modelCreateCheck;
        private Button opnCoreWebPathBtn;
        private TextBox coreWebPathTxtBox;
        private Label label10;
        private TextBox appPathTtextBox;
        private Button opnApplPathBtn;
        private CheckBox resourceCreateCheck;
        private Label label9;
        private TextBox infraPathTxtBx;
        private Button opnInfraPathBtn;
        private Label label8;
        private TextBox domainPathTxtBx;
        private Button opnDomainPathBtn;
        private Label label6;
        private TabControl mainTabControl;
        private DataGridViewTextBoxColumn PropName;
        private DataGridViewTextBoxColumn Caption;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewCheckBoxColumn Required;
        private DataGridViewTextBoxColumn MaxLength;
        private DataGridViewTextBoxColumn MinLength;
        private DataGridViewTextBoxColumn RegEx;
        private DataGridViewTextBoxColumn Unique;
        private DataGridViewCheckBoxColumn Key;
        private DataGridViewCheckBoxColumn Index;
        private DataGridViewTextBoxColumn BasicCode;
        private DataGridViewCheckBoxColumn Title;
        private Button schemaChanger;
    }
}