namespace NewCarProjectV1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label s_NLabel;
            System.Windows.Forms.Label companyCLabel;
            System.Windows.Forms.Label modelCLabel;
            System.Windows.Forms.Label cOLORLabel;
            System.Windows.Forms.Label yERLabel;
            System.Windows.Forms.Label yADLabel;
            System.Windows.Forms.Label kMLabel;
            System.Windows.Forms.Label pRIVELabel;
            System.Windows.Forms.Label pRICELabel;
            System.Windows.Forms.Label sELLERLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label dateAddLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label avilabelLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.carsTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCARSDataSet = new NewCarProjectV1.DBCARSDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.s_NTextBox = new System.Windows.Forms.TextBox();
            this.companyCTextBox = new System.Windows.Forms.TextBox();
            this.modelCTextBox = new System.Windows.Forms.TextBox();
            this.cOLORTextBox = new System.Windows.Forms.TextBox();
            this.yERTextBox = new System.Windows.Forms.TextBox();
            this.yADTextBox = new System.Windows.Forms.TextBox();
            this.kMTextBox = new System.Windows.Forms.TextBox();
            this.pRIVETextBox = new System.Windows.Forms.TextBox();
            this.pRICETextBox = new System.Windows.Forms.TextBox();
            this.sELLERTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.dateAddDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.avilabelCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carsTTableAdapter = new NewCarProjectV1.DBCARSDataSetTableAdapters.CarsTTableAdapter();
            this.tableAdapterManager = new NewCarProjectV1.DBCARSDataSetTableAdapters.TableAdapterManager();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.carsTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            s_NLabel = new System.Windows.Forms.Label();
            companyCLabel = new System.Windows.Forms.Label();
            modelCLabel = new System.Windows.Forms.Label();
            cOLORLabel = new System.Windows.Forms.Label();
            yERLabel = new System.Windows.Forms.Label();
            yADLabel = new System.Windows.Forms.Label();
            kMLabel = new System.Windows.Forms.Label();
            pRIVELabel = new System.Windows.Forms.Label();
            pRICELabel = new System.Windows.Forms.Label();
            sELLERLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            dateAddLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            avilabelLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCARSDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // s_NLabel
            // 
            s_NLabel.AutoSize = true;
            s_NLabel.Location = new System.Drawing.Point(91, 50);
            s_NLabel.Name = "s_NLabel";
            s_NLabel.Size = new System.Drawing.Size(39, 20);
            s_NLabel.TabIndex = 0;
            s_NLabel.Text = "S/N:";
            // 
            // companyCLabel
            // 
            companyCLabel.AutoSize = true;
            companyCLabel.Location = new System.Drawing.Point(91, 82);
            companyCLabel.Name = "companyCLabel";
            companyCLabel.Size = new System.Drawing.Size(95, 20);
            companyCLabel.TabIndex = 2;
            companyCLabel.Text = "Company C:";
            // 
            // modelCLabel
            // 
            modelCLabel.AutoSize = true;
            modelCLabel.Location = new System.Drawing.Point(91, 114);
            modelCLabel.Name = "modelCLabel";
            modelCLabel.Size = new System.Drawing.Size(71, 20);
            modelCLabel.TabIndex = 4;
            modelCLabel.Text = "Model C:";
            // 
            // cOLORLabel
            // 
            cOLORLabel.AutoSize = true;
            cOLORLabel.Location = new System.Drawing.Point(91, 146);
            cOLORLabel.Name = "cOLORLabel";
            cOLORLabel.Size = new System.Drawing.Size(69, 20);
            cOLORLabel.TabIndex = 6;
            cOLORLabel.Text = "COLOR:";
            // 
            // yERLabel
            // 
            yERLabel.AutoSize = true;
            yERLabel.Location = new System.Drawing.Point(91, 178);
            yERLabel.Name = "yERLabel";
            yERLabel.Size = new System.Drawing.Size(47, 20);
            yERLabel.TabIndex = 8;
            yERLabel.Text = "YER:";
            // 
            // yADLabel
            // 
            yADLabel.AutoSize = true;
            yADLabel.Location = new System.Drawing.Point(91, 210);
            yADLabel.Name = "yADLabel";
            yADLabel.Size = new System.Drawing.Size(47, 20);
            yADLabel.TabIndex = 10;
            yADLabel.Text = "YAD:";
            // 
            // kMLabel
            // 
            kMLabel.AutoSize = true;
            kMLabel.Location = new System.Drawing.Point(91, 242);
            kMLabel.Name = "kMLabel";
            kMLabel.Size = new System.Drawing.Size(36, 20);
            kMLabel.TabIndex = 12;
            kMLabel.Text = "KM:";
            // 
            // pRIVELabel
            // 
            pRIVELabel.AutoSize = true;
            pRIVELabel.Location = new System.Drawing.Point(91, 274);
            pRIVELabel.Name = "pRIVELabel";
            pRIVELabel.Size = new System.Drawing.Size(62, 20);
            pRIVELabel.TabIndex = 14;
            pRIVELabel.Text = "PRIVE:";
            // 
            // pRICELabel
            // 
            pRICELabel.AutoSize = true;
            pRICELabel.Location = new System.Drawing.Point(91, 306);
            pRICELabel.Name = "pRICELabel";
            pRICELabel.Size = new System.Drawing.Size(62, 20);
            pRICELabel.TabIndex = 16;
            pRICELabel.Text = "PRICE:";
            // 
            // sELLERLabel
            // 
            sELLERLabel.AutoSize = true;
            sELLERLabel.Location = new System.Drawing.Point(91, 338);
            sELLERLabel.Name = "sELLERLabel";
            sELLERLabel.Size = new System.Drawing.Size(76, 20);
            sELLERLabel.TabIndex = 18;
            sELLERLabel.Text = "SELLER:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(91, 370);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(55, 20);
            photoLabel.TabIndex = 20;
            photoLabel.Text = "Photo:";
            // 
            // dateAddLabel
            // 
            dateAddLabel.AutoSize = true;
            dateAddLabel.Location = new System.Drawing.Point(91, 403);
            dateAddLabel.Name = "dateAddLabel";
            dateAddLabel.Size = new System.Drawing.Size(81, 20);
            dateAddLabel.TabIndex = 22;
            dateAddLabel.Text = "Date Add:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(91, 434);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 24;
            descriptionLabel.Text = "Description:";
            // 
            // avilabelLabel
            // 
            avilabelLabel.AutoSize = true;
            avilabelLabel.Location = new System.Drawing.Point(91, 468);
            avilabelLabel.Name = "avilabelLabel";
            avilabelLabel.Size = new System.Drawing.Size(67, 20);
            avilabelLabel.TabIndex = 26;
            avilabelLabel.Text = "Avilabel:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1613, 711);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(579, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1034, 669);
            this.panel4.TabIndex = 2;
            // 
            // carsTBindingSource
            // 
            this.carsTBindingSource.DataMember = "CarsT";
            this.carsTBindingSource.DataSource = this.dBCARSDataSet;
            // 
            // dBCARSDataSet
            // 
            this.dBCARSDataSet.DataSetName = "DBCARSDataSet";
            this.dBCARSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(s_NLabel);
            this.panel3.Controls.Add(this.s_NTextBox);
            this.panel3.Controls.Add(companyCLabel);
            this.panel3.Controls.Add(this.companyCTextBox);
            this.panel3.Controls.Add(modelCLabel);
            this.panel3.Controls.Add(this.modelCTextBox);
            this.panel3.Controls.Add(cOLORLabel);
            this.panel3.Controls.Add(this.cOLORTextBox);
            this.panel3.Controls.Add(yERLabel);
            this.panel3.Controls.Add(this.yERTextBox);
            this.panel3.Controls.Add(yADLabel);
            this.panel3.Controls.Add(this.yADTextBox);
            this.panel3.Controls.Add(kMLabel);
            this.panel3.Controls.Add(this.kMTextBox);
            this.panel3.Controls.Add(pRIVELabel);
            this.panel3.Controls.Add(this.pRIVETextBox);
            this.panel3.Controls.Add(pRICELabel);
            this.panel3.Controls.Add(this.pRICETextBox);
            this.panel3.Controls.Add(sELLERLabel);
            this.panel3.Controls.Add(this.sELLERTextBox);
            this.panel3.Controls.Add(photoLabel);
            this.panel3.Controls.Add(this.photoTextBox);
            this.panel3.Controls.Add(dateAddLabel);
            this.panel3.Controls.Add(this.dateAddDateTimePicker);
            this.panel3.Controls.Add(descriptionLabel);
            this.panel3.Controls.Add(this.descriptionTextBox);
            this.panel3.Controls.Add(avilabelLabel);
            this.panel3.Controls.Add(this.avilabelCheckBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 669);
            this.panel3.TabIndex = 1;
            // 
            // s_NTextBox
            // 
            this.s_NTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "S/N", true));
            this.s_NTextBox.Location = new System.Drawing.Point(192, 47);
            this.s_NTextBox.Name = "s_NTextBox";
            this.s_NTextBox.Size = new System.Drawing.Size(200, 26);
            this.s_NTextBox.TabIndex = 1;
            // 
            // companyCTextBox
            // 
            this.companyCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "CompanyC", true));
            this.companyCTextBox.Location = new System.Drawing.Point(192, 79);
            this.companyCTextBox.Name = "companyCTextBox";
            this.companyCTextBox.Size = new System.Drawing.Size(200, 26);
            this.companyCTextBox.TabIndex = 3;
            // 
            // modelCTextBox
            // 
            this.modelCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "ModelC", true));
            this.modelCTextBox.Location = new System.Drawing.Point(192, 111);
            this.modelCTextBox.Name = "modelCTextBox";
            this.modelCTextBox.Size = new System.Drawing.Size(200, 26);
            this.modelCTextBox.TabIndex = 5;
            // 
            // cOLORTextBox
            // 
            this.cOLORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "COLOR", true));
            this.cOLORTextBox.Location = new System.Drawing.Point(192, 143);
            this.cOLORTextBox.Name = "cOLORTextBox";
            this.cOLORTextBox.Size = new System.Drawing.Size(200, 26);
            this.cOLORTextBox.TabIndex = 7;
            // 
            // yERTextBox
            // 
            this.yERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "YER", true));
            this.yERTextBox.Location = new System.Drawing.Point(192, 175);
            this.yERTextBox.Name = "yERTextBox";
            this.yERTextBox.Size = new System.Drawing.Size(200, 26);
            this.yERTextBox.TabIndex = 9;
            // 
            // yADTextBox
            // 
            this.yADTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "YAD", true));
            this.yADTextBox.Location = new System.Drawing.Point(192, 207);
            this.yADTextBox.Name = "yADTextBox";
            this.yADTextBox.Size = new System.Drawing.Size(200, 26);
            this.yADTextBox.TabIndex = 11;
            // 
            // kMTextBox
            // 
            this.kMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "KM", true));
            this.kMTextBox.Location = new System.Drawing.Point(192, 239);
            this.kMTextBox.Name = "kMTextBox";
            this.kMTextBox.Size = new System.Drawing.Size(200, 26);
            this.kMTextBox.TabIndex = 13;
            // 
            // pRIVETextBox
            // 
            this.pRIVETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "PRIVE", true));
            this.pRIVETextBox.Location = new System.Drawing.Point(192, 271);
            this.pRIVETextBox.Name = "pRIVETextBox";
            this.pRIVETextBox.Size = new System.Drawing.Size(200, 26);
            this.pRIVETextBox.TabIndex = 15;
            // 
            // pRICETextBox
            // 
            this.pRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "PRICE", true));
            this.pRICETextBox.Location = new System.Drawing.Point(192, 303);
            this.pRICETextBox.Name = "pRICETextBox";
            this.pRICETextBox.Size = new System.Drawing.Size(200, 26);
            this.pRICETextBox.TabIndex = 17;
            // 
            // sELLERTextBox
            // 
            this.sELLERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "SELLER", true));
            this.sELLERTextBox.Location = new System.Drawing.Point(192, 335);
            this.sELLERTextBox.Name = "sELLERTextBox";
            this.sELLERTextBox.Size = new System.Drawing.Size(200, 26);
            this.sELLERTextBox.TabIndex = 19;
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "Photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(192, 367);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(200, 26);
            this.photoTextBox.TabIndex = 21;
            // 
            // dateAddDateTimePicker
            // 
            this.dateAddDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carsTBindingSource, "DateAdd", true));
            this.dateAddDateTimePicker.Location = new System.Drawing.Point(192, 399);
            this.dateAddDateTimePicker.Name = "dateAddDateTimePicker";
            this.dateAddDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateAddDateTimePicker.TabIndex = 23;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsTBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(192, 431);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 26);
            this.descriptionTextBox.TabIndex = 25;
            // 
            // avilabelCheckBox
            // 
            this.avilabelCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.carsTBindingSource, "Avilabel", true));
            this.avilabelCheckBox.Location = new System.Drawing.Point(192, 463);
            this.avilabelCheckBox.Name = "avilabelCheckBox";
            this.avilabelCheckBox.Size = new System.Drawing.Size(200, 24);
            this.avilabelCheckBox.TabIndex = 27;
            this.avilabelCheckBox.Text = "checkBox1";
            this.avilabelCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1613, 42);
            this.panel2.TabIndex = 0;
            // 
            // carsTTableAdapter
            // 
            this.carsTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsTTableAdapter = this.carsTTableAdapter;
            this.tableAdapterManager.ColorTTableAdapter = null;
            this.tableAdapterManager.CompanyTTableAdapter = null;
            this.tableAdapterManager.ModelTTableAdapter = null;
            this.tableAdapterManager.OrderTTableAdapter = null;
            this.tableAdapterManager.SellerTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NewCarProjectV1.DBCARSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTTableAdapter = null;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.carsTDataGridView);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1034, 669);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1034, 37);
            this.panel6.TabIndex = 0;
            // 
            // carsTDataGridView
            // 
            this.carsTDataGridView.AutoGenerateColumns = false;
            this.carsTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn1});
            this.carsTDataGridView.DataSource = this.carsTBindingSource;
            this.carsTDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsTDataGridView.Location = new System.Drawing.Point(0, 37);
            this.carsTDataGridView.Name = "carsTDataGridView";
            this.carsTDataGridView.RowHeadersWidth = 62;
            this.carsTDataGridView.RowTemplate.Height = 28;
            this.carsTDataGridView.Size = new System.Drawing.Size(1034, 632);
            this.carsTDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "S/N";
            this.dataGridViewTextBoxColumn1.HeaderText = "S/N";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyC";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompanyC";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ModelC";
            this.dataGridViewTextBoxColumn3.HeaderText = "ModelC";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COLOR";
            this.dataGridViewTextBoxColumn4.HeaderText = "COLOR";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "YER";
            this.dataGridViewTextBoxColumn5.HeaderText = "YER";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "YAD";
            this.dataGridViewTextBoxColumn6.HeaderText = "YAD";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "KM";
            this.dataGridViewTextBoxColumn7.HeaderText = "KM";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PRIVE";
            this.dataGridViewTextBoxColumn8.HeaderText = "PRIVE";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PRICE";
            this.dataGridViewTextBoxColumn9.HeaderText = "PRICE";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SELLER";
            this.dataGridViewTextBoxColumn10.HeaderText = "SELLER";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Photo";
            this.dataGridViewTextBoxColumn11.HeaderText = "Photo";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DateAdd";
            this.dataGridViewTextBoxColumn12.HeaderText = "DateAdd";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn13.HeaderText = "Description";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Avilabel";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Avilabel";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 711);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCARSDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsTDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DBCARSDataSet dBCARSDataSet;
        private System.Windows.Forms.BindingSource carsTBindingSource;
        private DBCARSDataSetTableAdapters.CarsTTableAdapter carsTTableAdapter;
        private System.Windows.Forms.TextBox s_NTextBox;
        private System.Windows.Forms.TextBox companyCTextBox;
        private System.Windows.Forms.TextBox modelCTextBox;
        private System.Windows.Forms.TextBox cOLORTextBox;
        private System.Windows.Forms.TextBox yERTextBox;
        private System.Windows.Forms.TextBox yADTextBox;
        private System.Windows.Forms.TextBox kMTextBox;
        private System.Windows.Forms.TextBox pRIVETextBox;
        private System.Windows.Forms.TextBox pRICETextBox;
        private System.Windows.Forms.TextBox sELLERTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.DateTimePicker dateAddDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox avilabelCheckBox;
        private DBCARSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView carsTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel6;
    }
}