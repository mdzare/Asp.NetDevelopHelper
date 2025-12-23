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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            prjPathTextbx = new TextBox();
            openPrjPathBtn = new Button();
            label1 = new Label();
            executeBtn = new Button();
            label2 = new Label();
            tableTxbx = new TextBox();
            label3 = new Label();
            topPanel = new Panel();
            DPAPIBtn = new Button();
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
            contextPathTxtBox = new TextBox();
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
            prjPathTextbx.Location = new Point(401, 8);
            prjPathTextbx.Margin = new Padding(3, 2, 3, 2);
            prjPathTextbx.Name = "prjPathTextbx";
            prjPathTextbx.ReadOnly = true;
            prjPathTextbx.Size = new Size(596, 23);
            prjPathTextbx.TabIndex = 0;
            prjPathTextbx.TextChanged += prjPathTextbx_TextChanged;
            // 
            // openPrjPathBtn
            // 
            openPrjPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            openPrjPathBtn.Location = new Point(354, 8);
            openPrjPathBtn.Margin = new Padding(3, 2, 3, 2);
            openPrjPathBtn.Name = "openPrjPathBtn";
            openPrjPathBtn.Size = new Size(41, 22);
            openPrjPathBtn.TabIndex = 1;
            openPrjPathBtn.Text = ". . .";
            openPrjPathBtn.UseVisualStyleBackColor = true;
            openPrjPathBtn.Click += openPrjPathBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1002, 10);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "مسیر پروژه";
            // 
            // executeBtn
            // 
            executeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            executeBtn.BackColor = Color.Lime;
            executeBtn.Location = new Point(256, 10);
            executeBtn.Margin = new Padding(3, 2, 3, 2);
            executeBtn.Name = "executeBtn";
            executeBtn.Size = new Size(65, 22);
            executeBtn.TabIndex = 1;
            executeBtn.Text = "اجرا";
            executeBtn.UseVisualStyleBackColor = false;
            executeBtn.Click += executeBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1002, 42);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "نام اسکیما";
            // 
            // tableTxbx
            // 
            tableTxbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableTxbx.Location = new Point(615, 40);
            tableTxbx.Margin = new Padding(3, 2, 3, 2);
            tableTxbx.Name = "tableTxbx";
            tableTxbx.RightToLeft = RightToLeft.No;
            tableTxbx.Size = new Size(177, 23);
            tableTxbx.TabIndex = 0;
            tableTxbx.TextChanged += Txbx_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(797, 42);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "نام جدول";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(DPAPIBtn);
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
            topPanel.Margin = new Padding(3, 2, 3, 2);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1092, 93);
            topPanel.TabIndex = 3;
            // 
            // DPAPIBtn
            // 
            DPAPIBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DPAPIBtn.Location = new Point(12, 47);
            DPAPIBtn.Name = "DPAPIBtn";
            DPAPIBtn.Size = new Size(100, 29);
            DPAPIBtn.TabIndex = 9;
            DPAPIBtn.Text = "Hasher";
            DPAPIBtn.UseVisualStyleBackColor = true;
            // 
            // schemaChanger
            // 
            schemaChanger.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            schemaChanger.Location = new Point(10, 7);
            schemaChanger.Margin = new Padding(3, 2, 3, 2);
            schemaChanger.Name = "schemaChanger";
            schemaChanger.Size = new Size(88, 22);
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
            InheretedCheckBox.Location = new Point(982, 65);
            InheretedCheckBox.Margin = new Padding(3, 2, 3, 2);
            InheretedCheckBox.Name = "InheretedCheckBox";
            InheretedCheckBox.RightToLeft = RightToLeft.Yes;
            InheretedCheckBox.Size = new Size(87, 19);
            InheretedCheckBox.TabIndex = 7;
            InheretedCheckBox.Text = "جدول وراثتی";
            InheretedCheckBox.UseVisualStyleBackColor = true;
            // 
            // schemaComboBox
            // 
            schemaComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            schemaComboBox.FormattingEnabled = true;
            schemaComboBox.Location = new Point(864, 40);
            schemaComboBox.Margin = new Padding(3, 2, 3, 2);
            schemaComboBox.Name = "schemaComboBox";
            schemaComboBox.Size = new Size(133, 23);
            schemaComboBox.TabIndex = 5;
            // 
            // keyTypeCombo
            // 
            keyTypeCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyTypeCombo.FormattingEnabled = true;
            keyTypeCombo.Items.AddRange(new object[] { "long", "int", "string" });
            keyTypeCombo.Location = new Point(783, 64);
            keyTypeCombo.Margin = new Padding(3, 2, 3, 2);
            keyTypeCombo.Name = "keyTypeCombo";
            keyTypeCombo.RightToLeft = RightToLeft.No;
            keyTypeCombo.Size = new Size(98, 23);
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
            hasYearCheckBox.Location = new Point(670, 65);
            hasYearCheckBox.Margin = new Padding(3, 2, 3, 2);
            hasYearCheckBox.Name = "hasYearCheckBox";
            hasYearCheckBox.RightToLeft = RightToLeft.Yes;
            hasYearCheckBox.Size = new Size(99, 19);
            hasYearCheckBox.TabIndex = 3;
            hasYearCheckBox.Text = "سال مالی دارد:";
            hasYearCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableCaptionTxbx
            // 
            tableCaptionTxbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableCaptionTxbx.Location = new Point(354, 40);
            tableCaptionTxbx.Margin = new Padding(3, 2, 3, 2);
            tableCaptionTxbx.Name = "tableCaptionTxbx";
            tableCaptionTxbx.RightToLeft = RightToLeft.Yes;
            tableCaptionTxbx.Size = new Size(156, 23);
            tableCaptionTxbx.TabIndex = 0;
            tableCaptionTxbx.TextAlign = HorizontalAlignment.Right;
            // 
            // yearIndexTxbx
            // 
            yearIndexTxbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yearIndexTxbx.Location = new Point(406, 64);
            yearIndexTxbx.Margin = new Padding(3, 2, 3, 2);
            yearIndexTxbx.Name = "yearIndexTxbx";
            yearIndexTxbx.Size = new Size(63, 23);
            yearIndexTxbx.TabIndex = 0;
            yearIndexTxbx.TextChanged += Txbx_TextChanged;
            // 
            // yearTextBox
            // 
            yearTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yearTextBox.Location = new Point(593, 64);
            yearTextBox.Margin = new Padding(3, 2, 3, 2);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.RightToLeft = RightToLeft.No;
            yearTextBox.Size = new Size(62, 23);
            yearTextBox.TabIndex = 0;
            yearTextBox.Text = "Year{}";
            yearTextBox.TextChanged += Txbx_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(515, 42);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 2;
            label5.Text = "نام فارسی جدول";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(473, 67);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(95, 15);
            label7.TabIndex = 2;
            label7.Text = "ایندکس سال مالی";
            // 
            // undoBtn
            // 
            undoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            undoBtn.BackColor = Color.Red;
            undoBtn.ForeColor = SystemColors.Info;
            undoBtn.Location = new Point(186, 10);
            undoBtn.Margin = new Padding(3, 2, 3, 2);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(65, 22);
            undoBtn.TabIndex = 1;
            undoBtn.Text = "Undo!!!";
            undoBtn.UseVisualStyleBackColor = false;
            undoBtn.Click += undoBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(886, 68);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(64, 15);
            label4.TabIndex = 2;
            label4.Text = "کلید وراثتی:";
            // 
            // relationTab
            // 
            relationTab.Controls.Add(relationPanel);
            relationTab.Location = new Point(4, 24);
            relationTab.Margin = new Padding(3, 2, 3, 2);
            relationTab.Name = "relationTab";
            relationTab.Padding = new Padding(3, 2, 3, 2);
            relationTab.Size = new Size(1084, 381);
            relationTab.TabIndex = 1;
            relationTab.Text = "روابط جدول";
            relationTab.UseVisualStyleBackColor = true;
            // 
            // relationPanel
            // 
            relationPanel.BackColor = Color.Gainsboro;
            relationPanel.Controls.Add(relationDataGridView);
            relationPanel.Dock = DockStyle.Fill;
            relationPanel.Location = new Point(3, 2);
            relationPanel.Margin = new Padding(3, 2, 3, 2);
            relationPanel.Name = "relationPanel";
            relationPanel.Size = new Size(1078, 377);
            relationPanel.TabIndex = 0;
            // 
            // relationDataGridView
            // 
            relationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            relationDataGridView.Columns.AddRange(new DataGridViewColumn[] { Schema, Table, PrincipalKey, ForeignKey, dataGridViewComboBoxColumn1, DeleteBehave, SoftDelete, SoftRelation });
            relationDataGridView.Dock = DockStyle.Fill;
            relationDataGridView.Location = new Point(0, 0);
            relationDataGridView.Margin = new Padding(3, 2, 3, 2);
            relationDataGridView.Name = "relationDataGridView";
            relationDataGridView.RightToLeft = RightToLeft.Yes;
            relationDataGridView.RowHeadersWidth = 51;
            relationDataGridView.RowTemplate.Height = 29;
            relationDataGridView.Size = new Size(1078, 377);
            relationDataGridView.TabIndex = 0;
            relationDataGridView.CellValueChanged += relationDataGridView_CellValueChanged;
            // 
            // Schema
            // 
            Schema.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Schema.DefaultCellStyle = dataGridViewCellStyle2;
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
            propsTab.Location = new Point(4, 24);
            propsTab.Margin = new Padding(3, 2, 3, 2);
            propsTab.Name = "propsTab";
            propsTab.Padding = new Padding(3, 2, 3, 2);
            propsTab.Size = new Size(1084, 381);
            propsTab.TabIndex = 0;
            propsTab.Text = "اطلاعات جدول";
            propsTab.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(propertiesDataGridView);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(3, 2);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1078, 377);
            mainPanel.TabIndex = 5;
            // 
            // propertiesDataGridView
            // 
            propertiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            propertiesDataGridView.Columns.AddRange(new DataGridViewColumn[] { PropName, Caption, Type, Required, MaxLength, MinLength, RegEx, Unique, Key, Index, BasicCode, Title });
            propertiesDataGridView.Dock = DockStyle.Fill;
            propertiesDataGridView.Location = new Point(0, 0);
            propertiesDataGridView.Margin = new Padding(3, 2, 3, 2);
            propertiesDataGridView.Name = "propertiesDataGridView";
            propertiesDataGridView.RightToLeft = RightToLeft.Yes;
            propertiesDataGridView.RowHeadersWidth = 51;
            propertiesDataGridView.RowTemplate.Height = 29;
            propertiesDataGridView.Size = new Size(1078, 377);
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
            settingTab.Controls.Add(contextPathTxtBox);
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
            settingTab.Location = new Point(4, 24);
            settingTab.Margin = new Padding(3, 2, 3, 2);
            settingTab.Name = "settingTab";
            settingTab.Padding = new Padding(3, 2, 3, 2);
            settingTab.Size = new Size(1084, 381);
            settingTab.TabIndex = 2;
            settingTab.Text = "تنظیمات";
            // 
            // contextPathTxtBox
            // 
            contextPathTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            contextPathTxtBox.Location = new Point(60, 153);
            contextPathTxtBox.Margin = new Padding(3, 2, 3, 2);
            contextPathTxtBox.Name = "contextPathTxtBox";
            contextPathTxtBox.ReadOnly = true;
            contextPathTxtBox.Size = new Size(596, 23);
            contextPathTxtBox.TabIndex = 33;
            contextPathTxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(13, 152);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(41, 22);
            button2.TabIndex = 34;
            button2.Text = ". . .";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(661, 155);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 35;
            label12.Text = "Context Path";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(60, 128);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(596, 23);
            textBox1.TabIndex = 30;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(13, 128);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(41, 22);
            button1.TabIndex = 31;
            button1.Text = ". . .";
            button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(661, 130);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 32;
            label11.Text = "Mapper Path";
            // 
            // relationCreateCheck
            // 
            relationCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            relationCreateCheck.AutoSize = true;
            relationCreateCheck.Checked = true;
            relationCreateCheck.CheckState = CheckState.Checked;
            relationCreateCheck.Location = new Point(887, 220);
            relationCreateCheck.Margin = new Padding(3, 2, 3, 2);
            relationCreateCheck.Name = "relationCreateCheck";
            relationCreateCheck.RightToLeft = RightToLeft.Yes;
            relationCreateCheck.Size = new Size(109, 19);
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
            contextReferenceCreateCheck.Location = new Point(838, 198);
            contextReferenceCreateCheck.Margin = new Padding(3, 2, 3, 2);
            contextReferenceCreateCheck.Name = "contextReferenceCreateCheck";
            contextReferenceCreateCheck.RightToLeft = RightToLeft.Yes;
            contextReferenceCreateCheck.Size = new Size(159, 19);
            contextReferenceCreateCheck.TabIndex = 28;
            contextReferenceCreateCheck.Text = "ایجاد/حذف رفرنس Context";
            contextReferenceCreateCheck.UseVisualStyleBackColor = true;
            // 
            // mappingCreateCheck
            // 
            mappingCreateCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mappingCreateCheck.AutoSize = true;
            mappingCreateCheck.Location = new Point(867, 86);
            mappingCreateCheck.Margin = new Padding(3, 2, 3, 2);
            mappingCreateCheck.Name = "mappingCreateCheck";
            mappingCreateCheck.RightToLeft = RightToLeft.Yes;
            mappingCreateCheck.Size = new Size(130, 19);
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
            controllerCreateCheck.Location = new Point(861, 153);
            controllerCreateCheck.Margin = new Padding(3, 2, 3, 2);
            controllerCreateCheck.Name = "controllerCreateCheck";
            controllerCreateCheck.RightToLeft = RightToLeft.Yes;
            controllerCreateCheck.Size = new Size(135, 19);
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
            serviceCreateCheck.Location = new Point(877, 130);
            serviceCreateCheck.Margin = new Padding(3, 2, 3, 2);
            serviceCreateCheck.Name = "serviceCreateCheck";
            serviceCreateCheck.RightToLeft = RightToLeft.Yes;
            serviceCreateCheck.Size = new Size(119, 19);
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
            repositoryCreateCheck.Location = new Point(859, 108);
            repositoryCreateCheck.Margin = new Padding(3, 2, 3, 2);
            repositoryCreateCheck.Name = "repositoryCreateCheck";
            repositoryCreateCheck.RightToLeft = RightToLeft.Yes;
            repositoryCreateCheck.Size = new Size(138, 19);
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
            viewModelCreateCheck.Location = new Point(855, 63);
            viewModelCreateCheck.Margin = new Padding(3, 2, 3, 2);
            viewModelCreateCheck.Name = "viewModelCreateCheck";
            viewModelCreateCheck.RightToLeft = RightToLeft.Yes;
            viewModelCreateCheck.Size = new Size(141, 19);
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
            dtoCreateCheck.Location = new Point(895, 40);
            dtoCreateCheck.Margin = new Padding(3, 2, 3, 2);
            dtoCreateCheck.Name = "dtoCreateCheck";
            dtoCreateCheck.RightToLeft = RightToLeft.Yes;
            dtoCreateCheck.Size = new Size(101, 19);
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
            modelCreateCheck.Location = new Point(881, 18);
            modelCreateCheck.Margin = new Padding(3, 2, 3, 2);
            modelCreateCheck.Name = "modelCreateCheck";
            modelCreateCheck.RightToLeft = RightToLeft.Yes;
            modelCreateCheck.Size = new Size(116, 19);
            modelCreateCheck.TabIndex = 21;
            modelCreateCheck.Text = "ایجاد/حذف Model";
            modelCreateCheck.UseVisualStyleBackColor = true;
            // 
            // opnCoreWebPathBtn
            // 
            opnCoreWebPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opnCoreWebPathBtn.Location = new Point(13, 20);
            opnCoreWebPathBtn.Margin = new Padding(3, 2, 3, 2);
            opnCoreWebPathBtn.Name = "opnCoreWebPathBtn";
            opnCoreWebPathBtn.Size = new Size(41, 22);
            opnCoreWebPathBtn.TabIndex = 20;
            opnCoreWebPathBtn.Text = ". . .";
            opnCoreWebPathBtn.UseVisualStyleBackColor = true;
            opnCoreWebPathBtn.Click += opnCoreWebPathBtn_Click;
            // 
            // coreWebPathTxtBox
            // 
            coreWebPathTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coreWebPathTxtBox.Location = new Point(60, 18);
            coreWebPathTxtBox.Margin = new Padding(3, 2, 3, 2);
            coreWebPathTxtBox.Name = "coreWebPathTxtBox";
            coreWebPathTxtBox.ReadOnly = true;
            coreWebPathTxtBox.Size = new Size(596, 23);
            coreWebPathTxtBox.TabIndex = 18;
            coreWebPathTxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(661, 20);
            label10.Name = "label10";
            label10.Size = new Size(102, 15);
            label10.TabIndex = 19;
            label10.Text = "Asp.net Core Path";
            // 
            // appPathTtextBox
            // 
            appPathTtextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            appPathTtextBox.Location = new Point(60, 47);
            appPathTtextBox.Margin = new Padding(3, 2, 3, 2);
            appPathTtextBox.Name = "appPathTtextBox";
            appPathTtextBox.ReadOnly = true;
            appPathTtextBox.Size = new Size(596, 23);
            appPathTtextBox.TabIndex = 15;
            appPathTtextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // opnApplPathBtn
            // 
            opnApplPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opnApplPathBtn.Location = new Point(13, 46);
            opnApplPathBtn.Margin = new Padding(3, 2, 3, 2);
            opnApplPathBtn.Name = "opnApplPathBtn";
            opnApplPathBtn.Size = new Size(41, 22);
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
            resourceCreateCheck.Location = new Point(867, 176);
            resourceCreateCheck.Margin = new Padding(3, 2, 3, 2);
            resourceCreateCheck.Name = "resourceCreateCheck";
            resourceCreateCheck.RightToLeft = RightToLeft.Yes;
            resourceCreateCheck.Size = new Size(130, 19);
            resourceCreateCheck.TabIndex = 8;
            resourceCreateCheck.Text = "ایجاد/حذف Resource";
            resourceCreateCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(661, 50);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 17;
            label9.Text = "Application Path";
            // 
            // infraPathTxtBx
            // 
            infraPathTxtBx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            infraPathTxtBx.Location = new Point(60, 74);
            infraPathTxtBx.Margin = new Padding(3, 2, 3, 2);
            infraPathTxtBx.Name = "infraPathTxtBx";
            infraPathTxtBx.ReadOnly = true;
            infraPathTxtBx.Size = new Size(596, 23);
            infraPathTxtBx.TabIndex = 12;
            infraPathTxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // opnInfraPathBtn
            // 
            opnInfraPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opnInfraPathBtn.Location = new Point(13, 73);
            opnInfraPathBtn.Margin = new Padding(3, 2, 3, 2);
            opnInfraPathBtn.Name = "opnInfraPathBtn";
            opnInfraPathBtn.Size = new Size(41, 22);
            opnInfraPathBtn.TabIndex = 13;
            opnInfraPathBtn.Text = ". . .";
            opnInfraPathBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(661, 76);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 14;
            label8.Text = "Infrastructure Path";
            // 
            // domainPathTxtBx
            // 
            domainPathTxtBx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            domainPathTxtBx.Location = new Point(60, 100);
            domainPathTxtBx.Margin = new Padding(3, 2, 3, 2);
            domainPathTxtBx.Name = "domainPathTxtBx";
            domainPathTxtBx.ReadOnly = true;
            domainPathTxtBx.Size = new Size(596, 23);
            domainPathTxtBx.TabIndex = 9;
            domainPathTxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // opnDomainPathBtn
            // 
            opnDomainPathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opnDomainPathBtn.Location = new Point(13, 99);
            opnDomainPathBtn.Margin = new Padding(3, 2, 3, 2);
            opnDomainPathBtn.Name = "opnDomainPathBtn";
            opnDomainPathBtn.Size = new Size(41, 22);
            opnDomainPathBtn.TabIndex = 10;
            opnDomainPathBtn.Text = ". . .";
            opnDomainPathBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(661, 102);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 11;
            label6.Text = "Domain Path";
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(settingTab);
            mainTabControl.Controls.Add(propsTab);
            mainTabControl.Controls.Add(relationTab);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 93);
            mainTabControl.Margin = new Padding(3, 2, 3, 2);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.RightToLeft = RightToLeft.Yes;
            mainTabControl.RightToLeftLayout = true;
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1092, 409);
            mainTabControl.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 502);
            Controls.Add(mainTabControl);
            Controls.Add(topPanel);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(777, 541);
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
        private TextBox contextPathTxtBox;
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
        private Button DPAPIBtn;
    }
}