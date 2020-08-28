﻿namespace trifenix.agro.app.frm.mantenedores.doses
{
    partial class Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm));
            this.tbxCorrelativo = new System.Windows.Forms.TextBox();
            this.bsDoses = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbxItem = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSpecies = new System.Windows.Forms.TabPage();
            this.btnRemoveVariety = new System.Windows.Forms.Button();
            this.btnRemoveSpecie = new System.Windows.Forms.Button();
            this.lbxVariety = new System.Windows.Forms.ListBox();
            this.bsVarietyCollection = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddSpecie = new System.Windows.Forms.Button();
            this.lbxSpecie = new System.Windows.Forms.ListBox();
            this.bsSpecieCollection = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddVariety = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbVariety = new System.Windows.Forms.ComboBox();
            this.bsVariety = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cbSpecie = new System.Windows.Forms.ComboBox();
            this.bsSpecie = new System.Windows.Forms.BindingSource(this.components);
            this.tpTarget = new System.Windows.Forms.TabPage();
            this.btnRemoveTarget = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bsTargetCollection = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bsTarget = new System.Windows.Forms.BindingSource(this.components);
            this.tpCertifiedEnties = new System.Windows.Forms.TabPage();
            this.btnRemoveHarvest = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxCertDays = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxPPm = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.waitingHarvestExtendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.cbCertifiedEntity = new System.Windows.Forms.ComboBox();
            this.bsCertifiedEntity = new System.Windows.Forms.BindingSource(this.components);
            this.tbxMaxDoses = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxMinDoses = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSizeContainer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCosecha = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxWettingRecommended = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSecquence = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudIntervalDays = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudReEntryToBarrack = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ValidationForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsDoses)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxItem.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSpecies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVarietyCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecieCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVariety)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecie)).BeginInit();
            this.tpTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTargetCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).BeginInit();
            this.tpCertifiedEnties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingHarvestExtendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCertifiedEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecquence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReEntryToBarrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationForm)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxCorrelativo
            // 
            this.tbxCorrelativo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDoses, "ClientId", true));
            this.tbxCorrelativo.Enabled = false;
            this.tbxCorrelativo.Location = new System.Drawing.Point(12, 53);
            this.tbxCorrelativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCorrelativo.Name = "tbxCorrelativo";
            this.tbxCorrelativo.Size = new System.Drawing.Size(84, 22);
            this.tbxCorrelativo.TabIndex = 0;
            // 
            // bsDoses
            // 
            this.bsDoses.DataSource = typeof(trifenix.connect.agro_model_input.DosesInput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correlativo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 66);
            this.panel1.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 12);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // gbxItem
            // 
            this.gbxItem.Controls.Add(this.tabControl1);
            this.gbxItem.Controls.Add(this.tbxMaxDoses);
            this.gbxItem.Controls.Add(this.label9);
            this.gbxItem.Controls.Add(this.tbxMinDoses);
            this.gbxItem.Controls.Add(this.label8);
            this.gbxItem.Controls.Add(this.cbSizeContainer);
            this.gbxItem.Controls.Add(this.label7);
            this.gbxItem.Controls.Add(this.nudCosecha);
            this.gbxItem.Controls.Add(this.label6);
            this.gbxItem.Controls.Add(this.tbxWettingRecommended);
            this.gbxItem.Controls.Add(this.label5);
            this.gbxItem.Controls.Add(this.nudSecquence);
            this.gbxItem.Controls.Add(this.label4);
            this.gbxItem.Controls.Add(this.nudIntervalDays);
            this.gbxItem.Controls.Add(this.label3);
            this.gbxItem.Controls.Add(this.nudReEntryToBarrack);
            this.gbxItem.Controls.Add(this.label2);
            this.gbxItem.Controls.Add(this.tbxCorrelativo);
            this.gbxItem.Controls.Add(this.btnCancel);
            this.gbxItem.Controls.Add(this.label1);
            this.gbxItem.Controls.Add(this.btnSave);
            this.gbxItem.Enabled = false;
            this.gbxItem.Location = new System.Drawing.Point(13, 72);
            this.gbxItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxItem.Name = "gbxItem";
            this.gbxItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxItem.Size = new System.Drawing.Size(943, 595);
            this.gbxItem.TabIndex = 5;
            this.gbxItem.TabStop = false;
            this.gbxItem.Text = "{0}";
            this.gbxItem.Visible = false;
            this.gbxItem.Validating += new System.ComponentModel.CancelEventHandler(this.gbxItem_Validating);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSpecies);
            this.tabControl1.Controls.Add(this.tpTarget);
            this.tabControl1.Controls.Add(this.tpCertifiedEnties);
            this.tabControl1.Location = new System.Drawing.Point(12, 162);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 394);
            this.tabControl1.TabIndex = 26;
            // 
            // tpSpecies
            // 
            this.tpSpecies.Controls.Add(this.btnRemoveVariety);
            this.tpSpecies.Controls.Add(this.btnRemoveSpecie);
            this.tpSpecies.Controls.Add(this.lbxVariety);
            this.tpSpecies.Controls.Add(this.btnAddSpecie);
            this.tpSpecies.Controls.Add(this.lbxSpecie);
            this.tpSpecies.Controls.Add(this.btnAddVariety);
            this.tpSpecies.Controls.Add(this.label11);
            this.tpSpecies.Controls.Add(this.cbVariety);
            this.tpSpecies.Controls.Add(this.label10);
            this.tpSpecies.Controls.Add(this.cbSpecie);
            this.tpSpecies.Location = new System.Drawing.Point(4, 25);
            this.tpSpecies.Name = "tpSpecies";
            this.tpSpecies.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSpecies.Size = new System.Drawing.Size(912, 365);
            this.tpSpecies.TabIndex = 0;
            this.tpSpecies.Text = "Especies";
            this.tpSpecies.UseVisualStyleBackColor = true;
            // 
            // btnRemoveVariety
            // 
            this.btnRemoveVariety.BackgroundImage = global::trifenix.agro.app.Properties.Resources.deleteIcon;
            this.btnRemoveVariety.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveVariety.Location = new System.Drawing.Point(875, 338);
            this.btnRemoveVariety.Name = "btnRemoveVariety";
            this.btnRemoveVariety.Size = new System.Drawing.Size(30, 23);
            this.btnRemoveVariety.TabIndex = 37;
            this.btnRemoveVariety.UseVisualStyleBackColor = true;
            this.btnRemoveVariety.Click += new System.EventHandler(this.btnRemoveVariety_Click);
            // 
            // btnRemoveSpecie
            // 
            this.btnRemoveSpecie.BackgroundImage = global::trifenix.agro.app.Properties.Resources.deleteIcon;
            this.btnRemoveSpecie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveSpecie.Location = new System.Drawing.Point(355, 338);
            this.btnRemoveSpecie.Name = "btnRemoveSpecie";
            this.btnRemoveSpecie.Size = new System.Drawing.Size(30, 23);
            this.btnRemoveSpecie.TabIndex = 36;
            this.btnRemoveSpecie.UseVisualStyleBackColor = true;
            this.btnRemoveSpecie.Click += new System.EventHandler(this.btnRemoveSpecie_Click);
            // 
            // lbxVariety
            // 
            this.lbxVariety.DataSource = this.bsVarietyCollection;
            this.lbxVariety.DisplayMember = "FullName";
            this.lbxVariety.FormattingEnabled = true;
            this.lbxVariety.ItemHeight = 16;
            this.lbxVariety.Location = new System.Drawing.Point(407, 60);
            this.lbxVariety.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxVariety.Name = "lbxVariety";
            this.lbxVariety.Size = new System.Drawing.Size(498, 276);
            this.lbxVariety.TabIndex = 35;
            this.lbxVariety.ValueMember = "Id";
            // 
            // bsVarietyCollection
            // 
            this.bsVarietyCollection.DataSource = typeof(trifenix.agro.app.model_extend.VarieryExtend);
            // 
            // btnAddSpecie
            // 
            this.btnAddSpecie.BackgroundImage = global::trifenix.agro.app.Properties.Resources.add_icon;
            this.btnAddSpecie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSpecie.Location = new System.Drawing.Point(355, 31);
            this.btnAddSpecie.Name = "btnAddSpecie";
            this.btnAddSpecie.Size = new System.Drawing.Size(30, 23);
            this.btnAddSpecie.TabIndex = 34;
            this.btnAddSpecie.UseVisualStyleBackColor = true;
            this.btnAddSpecie.Click += new System.EventHandler(this.btnAddSpecie_Click);
            // 
            // lbxSpecie
            // 
            this.lbxSpecie.DataSource = this.bsSpecieCollection;
            this.lbxSpecie.DisplayMember = "Name";
            this.lbxSpecie.FormattingEnabled = true;
            this.lbxSpecie.ItemHeight = 16;
            this.lbxSpecie.Location = new System.Drawing.Point(36, 60);
            this.lbxSpecie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxSpecie.Name = "lbxSpecie";
            this.lbxSpecie.Size = new System.Drawing.Size(351, 276);
            this.lbxSpecie.TabIndex = 33;
            this.lbxSpecie.ValueMember = "Id";
            // 
            // bsSpecieCollection
            // 
            this.bsSpecieCollection.DataSource = typeof(trifenix.connect.agro_model.Specie);
            // 
            // btnAddVariety
            // 
            this.btnAddVariety.BackgroundImage = global::trifenix.agro.app.Properties.Resources.add_icon;
            this.btnAddVariety.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddVariety.Location = new System.Drawing.Point(875, 33);
            this.btnAddVariety.Name = "btnAddVariety";
            this.btnAddVariety.Size = new System.Drawing.Size(30, 23);
            this.btnAddVariety.TabIndex = 32;
            this.btnAddVariety.UseVisualStyleBackColor = true;
            this.btnAddVariety.Click += new System.EventHandler(this.btnAddVariety_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Variedad";
            // 
            // cbVariety
            // 
            this.cbVariety.DataSource = this.bsVariety;
            this.cbVariety.DisplayMember = "FullName";
            this.cbVariety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVariety.FormattingEnabled = true;
            this.cbVariety.Location = new System.Drawing.Point(407, 33);
            this.cbVariety.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVariety.Name = "cbVariety";
            this.cbVariety.Size = new System.Drawing.Size(463, 24);
            this.cbVariety.TabIndex = 28;
            this.cbVariety.ValueMember = "Id";
            // 
            // bsVariety
            // 
            this.bsVariety.DataSource = typeof(trifenix.agro.app.model_extend.VarieryExtend);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Especie";
            // 
            // cbSpecie
            // 
            this.cbSpecie.DataSource = this.bsSpecie;
            this.cbSpecie.DisplayMember = "Name";
            this.cbSpecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecie.FormattingEnabled = true;
            this.cbSpecie.Location = new System.Drawing.Point(36, 33);
            this.cbSpecie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSpecie.Name = "cbSpecie";
            this.cbSpecie.Size = new System.Drawing.Size(313, 24);
            this.cbSpecie.TabIndex = 0;
            this.cbSpecie.ValueMember = "Id";
            // 
            // bsSpecie
            // 
            this.bsSpecie.DataSource = typeof(trifenix.connect.agro_model.Specie);
            // 
            // tpTarget
            // 
            this.tpTarget.Controls.Add(this.btnRemoveTarget);
            this.tpTarget.Controls.Add(this.button2);
            this.tpTarget.Controls.Add(this.listBox1);
            this.tpTarget.Controls.Add(this.label12);
            this.tpTarget.Controls.Add(this.comboBox1);
            this.tpTarget.Location = new System.Drawing.Point(4, 25);
            this.tpTarget.Name = "tpTarget";
            this.tpTarget.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpTarget.Size = new System.Drawing.Size(912, 365);
            this.tpTarget.TabIndex = 1;
            this.tpTarget.Text = "Objetivo de la aplicación";
            this.tpTarget.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTarget
            // 
            this.btnRemoveTarget.BackgroundImage = global::trifenix.agro.app.Properties.Resources.deleteIcon;
            this.btnRemoveTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveTarget.Location = new System.Drawing.Point(344, 340);
            this.btnRemoveTarget.Name = "btnRemoveTarget";
            this.btnRemoveTarget.Size = new System.Drawing.Size(30, 23);
            this.btnRemoveTarget.TabIndex = 39;
            this.btnRemoveTarget.UseVisualStyleBackColor = true;
            this.btnRemoveTarget.Click += new System.EventHandler(this.btnRemoveTarget_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::trifenix.agro.app.Properties.Resources.add_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(344, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 38;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.bsTargetCollection;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(26, 59);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 276);
            this.listBox1.TabIndex = 37;
            this.listBox1.ValueMember = "Id";
            // 
            // bsTargetCollection
            // 
            this.bsTargetCollection.DataSource = typeof(trifenix.connect.agro_model.ApplicationTarget);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Objetivo de la aplicación";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bsTarget;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "Id";
            // 
            // bsTarget
            // 
            this.bsTarget.DataSource = typeof(trifenix.connect.agro_model.ApplicationTarget);
            // 
            // tpCertifiedEnties
            // 
            this.tpCertifiedEnties.Controls.Add(this.btnRemoveHarvest);
            this.tpCertifiedEnties.Controls.Add(this.label15);
            this.tpCertifiedEnties.Controls.Add(this.tbxCertDays);
            this.tpCertifiedEnties.Controls.Add(this.label14);
            this.tpCertifiedEnties.Controls.Add(this.tbxPPm);
            this.tpCertifiedEnties.Controls.Add(this.button3);
            this.tpCertifiedEnties.Controls.Add(this.listBox2);
            this.tpCertifiedEnties.Controls.Add(this.label13);
            this.tpCertifiedEnties.Controls.Add(this.cbCertifiedEntity);
            this.tpCertifiedEnties.Location = new System.Drawing.Point(4, 25);
            this.tpCertifiedEnties.Name = "tpCertifiedEnties";
            this.tpCertifiedEnties.Size = new System.Drawing.Size(912, 365);
            this.tpCertifiedEnties.TabIndex = 2;
            this.tpCertifiedEnties.Text = "Mercados";
            this.tpCertifiedEnties.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHarvest
            // 
            this.btnRemoveHarvest.BackgroundImage = global::trifenix.agro.app.Properties.Resources.deleteIcon;
            this.btnRemoveHarvest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveHarvest.Location = new System.Drawing.Point(548, 337);
            this.btnRemoveHarvest.Name = "btnRemoveHarvest";
            this.btnRemoveHarvest.Size = new System.Drawing.Size(30, 23);
            this.btnRemoveHarvest.TabIndex = 46;
            this.btnRemoveHarvest.UseVisualStyleBackColor = true;
            this.btnRemoveHarvest.Click += new System.EventHandler(this.btnRemoveHarvest_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(430, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 17);
            this.label15.TabIndex = 45;
            this.label15.Text = "Días";
            // 
            // tbxCertDays
            // 
            this.tbxCertDays.Location = new System.Drawing.Point(434, 30);
            this.tbxCertDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCertDays.Name = "tbxCertDays";
            this.tbxCertDays.Size = new System.Drawing.Size(108, 22);
            this.tbxCertDays.TabIndex = 44;
            this.tbxCertDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMinDoses_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(345, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "PPM";
            // 
            // tbxPPm
            // 
            this.tbxPPm.Location = new System.Drawing.Point(345, 30);
            this.tbxPPm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPPm.Name = "tbxPPm";
            this.tbxPPm.Size = new System.Drawing.Size(73, 22);
            this.tbxPPm.TabIndex = 27;
            this.tbxPPm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMinDoses_KeyPress);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::trifenix.agro.app.Properties.Resources.add_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(548, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 42;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.waitingHarvestExtendBindingSource;
            this.listBox2.DisplayMember = "FullName";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(26, 56);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(552, 276);
            this.listBox2.TabIndex = 41;
            this.listBox2.ValueMember = "Id";
            // 
            // waitingHarvestExtendBindingSource
            // 
            this.waitingHarvestExtendBindingSource.DataSource = typeof(trifenix.agro.app.model_extend.WaitingHarvestExtend);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "Objetivo de la aplicación";
            // 
            // cbCertifiedEntity
            // 
            this.cbCertifiedEntity.DataSource = this.bsCertifiedEntity;
            this.cbCertifiedEntity.DisplayMember = "Name";
            this.cbCertifiedEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCertifiedEntity.FormattingEnabled = true;
            this.cbCertifiedEntity.Location = new System.Drawing.Point(26, 29);
            this.cbCertifiedEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCertifiedEntity.Name = "cbCertifiedEntity";
            this.cbCertifiedEntity.Size = new System.Drawing.Size(313, 24);
            this.cbCertifiedEntity.TabIndex = 39;
            this.cbCertifiedEntity.ValueMember = "Id";
            // 
            // bsCertifiedEntity
            // 
            this.bsCertifiedEntity.DataSource = typeof(trifenix.connect.agro_model.CertifiedEntity);
            // 
            // tbxMaxDoses
            // 
            this.tbxMaxDoses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDoses, "DosesQuantityMax", true));
            this.tbxMaxDoses.Location = new System.Drawing.Point(132, 117);
            this.tbxMaxDoses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMaxDoses.Name = "tbxMaxDoses";
            this.tbxMaxDoses.Size = new System.Drawing.Size(108, 22);
            this.tbxMaxDoses.TabIndex = 24;
            this.tbxMaxDoses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMinDoses_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Dosis Máxima";
            // 
            // tbxMinDoses
            // 
            this.tbxMinDoses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDoses, "DosesQuantityMin", true));
            this.tbxMinDoses.Location = new System.Drawing.Point(12, 117);
            this.tbxMinDoses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMinDoses.Name = "tbxMinDoses";
            this.tbxMinDoses.Size = new System.Drawing.Size(108, 22);
            this.tbxMinDoses.TabIndex = 22;
            this.tbxMinDoses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMinDoses_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Dosis Mínima";
            // 
            // cbSizeContainer
            // 
            this.cbSizeContainer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDoses, "DosesApplicatedTo", true));
            this.cbSizeContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSizeContainer.FormattingEnabled = true;
            this.cbSizeContainer.Location = new System.Drawing.Point(727, 53);
            this.cbSizeContainer.Name = "cbSizeContainer";
            this.cbSizeContainer.Size = new System.Drawing.Size(205, 24);
            this.cbSizeContainer.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tamaño contenedor";
            // 
            // nudCosecha
            // 
            this.nudCosecha.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDoses, "WaitingDaysLabel", true));
            this.nudCosecha.Location = new System.Drawing.Point(642, 53);
            this.nudCosecha.Name = "nudCosecha";
            this.nudCosecha.Size = new System.Drawing.Size(65, 22);
            this.nudCosecha.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(638, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 50);
            this.label6.TabIndex = 18;
            this.label6.Text = "Días \r\nCosecha";
            // 
            // tbxWettingRecommended
            // 
            this.tbxWettingRecommended.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDoses, "WettingRecommendedByHectares", true));
            this.tbxWettingRecommended.Location = new System.Drawing.Point(520, 53);
            this.tbxWettingRecommended.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxWettingRecommended.Name = "tbxWettingRecommended";
            this.tbxWettingRecommended.Size = new System.Drawing.Size(110, 22);
            this.tbxWettingRecommended.TabIndex = 15;
            this.tbxWettingRecommended.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWettingRecommended_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(520, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 50);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mojamiento Recomendado";
            // 
            // nudSecquence
            // 
            this.nudSecquence.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDoses, "NumberOfSequentialApplication", true));
            this.nudSecquence.Location = new System.Drawing.Point(430, 54);
            this.nudSecquence.Name = "nudSecquence";
            this.nudSecquence.Size = new System.Drawing.Size(80, 22);
            this.nudSecquence.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(426, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 40);
            this.label4.TabIndex = 13;
            this.label4.Text = "Número de secuencia";
            // 
            // nudIntervalDays
            // 
            this.nudIntervalDays.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDoses, "ApplicationDaysInterval", true));
            this.nudIntervalDays.Location = new System.Drawing.Point(287, 54);
            this.nudIntervalDays.Name = "nudIntervalDays";
            this.nudIntervalDays.Size = new System.Drawing.Size(131, 22);
            this.nudIntervalDays.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Días de intervalo";
            // 
            // nudReEntryToBarrack
            // 
            this.nudReEntryToBarrack.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDoses, "HoursToReEntryToBarrack", true));
            this.nudReEntryToBarrack.Location = new System.Drawing.Point(110, 53);
            this.nudReEntryToBarrack.Name = "nudReEntryToBarrack";
            this.nudReEntryToBarrack.Size = new System.Drawing.Size(155, 22);
            this.nudReEntryToBarrack.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Horas de Reingreso";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(726, 563);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(833, 563);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ValidationForm
            // 
            this.ValidationForm.ContainerControl = this;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 670);
            this.Controls.Add(this.gbxItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dosis";
            this.Load += new System.EventHandler(this.SectorFrm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bsDoses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxItem.ResumeLayout(false);
            this.gbxItem.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpSpecies.ResumeLayout(false);
            this.tpSpecies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVarietyCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecieCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVariety)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecie)).EndInit();
            this.tpTarget.ResumeLayout(false);
            this.tpTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTargetCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).EndInit();
            this.tpCertifiedEnties.ResumeLayout(false);
            this.tpCertifiedEnties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingHarvestExtendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCertifiedEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecquence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReEntryToBarrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCorrelativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gbxItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider ValidationForm;
        private System.Windows.Forms.NumericUpDown nudReEntryToBarrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudIntervalDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSecquence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxWettingRecommended;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSizeContainer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCosecha;
        private System.Windows.Forms.TextBox tbxMaxDoses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMinDoses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSpecies;
        private System.Windows.Forms.TabPage tpTarget;
        private System.Windows.Forms.TabPage tpCertifiedEnties;
        private System.Windows.Forms.BindingSource bsSpecie;
        private System.Windows.Forms.BindingSource bsVariety;
        private System.Windows.Forms.BindingSource bsTarget;
        private System.Windows.Forms.BindingSource bsCertifiedEntity;
        private System.Windows.Forms.BindingSource bsDoses;
        private System.Windows.Forms.ComboBox cbSpecie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbVariety;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddVariety;
        private System.Windows.Forms.ListBox lbxVariety;
        private System.Windows.Forms.Button btnAddSpecie;
        private System.Windows.Forms.ListBox lbxSpecie;
        private System.Windows.Forms.BindingSource bsSpecieCollection;
        private System.Windows.Forms.BindingSource bsVarietyCollection;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbCertifiedEntity;
        private System.Windows.Forms.BindingSource bsTargetCollection;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxCertDays;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxPPm;
        private System.Windows.Forms.BindingSource waitingHarvestExtendBindingSource;
        private System.Windows.Forms.Button btnRemoveVariety;
        private System.Windows.Forms.Button btnRemoveSpecie;
        private System.Windows.Forms.Button btnRemoveTarget;
        private System.Windows.Forms.Button btnRemoveHarvest;
    }
}