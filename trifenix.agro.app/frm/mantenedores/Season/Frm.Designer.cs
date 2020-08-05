﻿namespace trifenix.agro.app.frm.mantenedores.season
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbxItem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEndSeason = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartSeason = new System.Windows.Forms.DateTimePicker();
            this.cbCostCenter = new System.Windows.Forms.ComboBox();
            this.bsCostCenter = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.ValidationForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDeleteSector = new System.Windows.Forms.Button();
            this.btnEditSector = new System.Windows.Forms.Button();
            this.btnAddSector = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbxItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationForm)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 82);
            this.panel1.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 15);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // gbxItem
            // 
            this.gbxItem.Controls.Add(this.label3);
            this.gbxItem.Controls.Add(this.dtEndSeason);
            this.gbxItem.Controls.Add(this.label2);
            this.gbxItem.Controls.Add(this.dtStartSeason);
            this.gbxItem.Controls.Add(this.cbCostCenter);
            this.gbxItem.Controls.Add(this.label1);
            this.gbxItem.Controls.Add(this.btnCancel);
            this.gbxItem.Controls.Add(this.btnSave);
            this.gbxItem.Enabled = false;
            this.gbxItem.Location = new System.Drawing.Point(480, 89);
            this.gbxItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItem.Name = "gbxItem";
            this.gbxItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItem.Size = new System.Drawing.Size(496, 520);
            this.gbxItem.TabIndex = 5;
            this.gbxItem.TabStop = false;
            this.gbxItem.Text = "{0}";
            this.gbxItem.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "fin del año agricola : ";
            // 
            // dtEndSeason
            // 
            this.dtEndSeason.CustomFormat = "dd-MM-yyyy";
            this.dtEndSeason.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndSeason.Location = new System.Drawing.Point(11, 206);
            this.dtEndSeason.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtEndSeason.Name = "dtEndSeason";
            this.dtEndSeason.Size = new System.Drawing.Size(454, 26);
            this.dtEndSeason.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Inicio del año agricola : ";
            // 
            // dtStartSeason
            // 
            this.dtStartSeason.CustomFormat = "dd-MM-yyyy";
            this.dtStartSeason.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartSeason.Location = new System.Drawing.Point(11, 140);
            this.dtStartSeason.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtStartSeason.Name = "dtStartSeason";
            this.dtStartSeason.Size = new System.Drawing.Size(454, 26);
            this.dtStartSeason.TabIndex = 11;
            // 
            // cbCostCenter
            // 
            this.cbCostCenter.DataSource = this.bsCostCenter;
            this.cbCostCenter.DisplayMember = "Name";
            this.cbCostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostCenter.FormattingEnabled = true;
            this.cbCostCenter.Location = new System.Drawing.Point(11, 66);
            this.cbCostCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCostCenter.Name = "cbCostCenter";
            this.cbCostCenter.Size = new System.Drawing.Size(454, 28);
            this.cbCostCenter.TabIndex = 10;
            this.cbCostCenter.ValueMember = "Id";
            // 
            // bsCostCenter
            // 
            this.bsCostCenter.DataSource = typeof(trifenix.connect.agro_model.CostCenter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Centro de Costos : ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 460);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(354, 460);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbxItems
            // 
            this.lbxItems.DataSource = this.bsMain;
            this.lbxItems.DisplayMember = "CostCenterName";
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 20;
            this.lbxItems.Location = new System.Drawing.Point(20, 105);
            this.lbxItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(452, 464);
            this.lbxItems.TabIndex = 9;
            this.lbxItems.ValueMember = "Id";
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(trifenix.agro.app.model_extend.SeasonExtend);
            this.bsMain.CurrentChanged += new System.EventHandler(this.bsSectors_CurrentChanged);
            // 
            // ValidationForm
            // 
            this.ValidationForm.ContainerControl = this;
            // 
            // btnDeleteSector
            // 
            this.btnDeleteSector.BackgroundImage = global::trifenix.agro.app.Properties.Resources.deleteIcon;
            this.btnDeleteSector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSector.Location = new System.Drawing.Point(151, 2);
            this.btnDeleteSector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteSector.Name = "btnDeleteSector";
            this.btnDeleteSector.Size = new System.Drawing.Size(34, 29);
            this.btnDeleteSector.TabIndex = 33;
            this.btnDeleteSector.UseVisualStyleBackColor = true;
            // 
            // btnEditSector
            // 
            this.btnEditSector.BackgroundImage = global::trifenix.agro.app.Properties.Resources.edit_icon;
            this.btnEditSector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditSector.Location = new System.Drawing.Point(111, 4);
            this.btnEditSector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditSector.Name = "btnEditSector";
            this.btnEditSector.Size = new System.Drawing.Size(34, 29);
            this.btnEditSector.TabIndex = 32;
            this.btnEditSector.UseVisualStyleBackColor = true;
            this.btnEditSector.Click += new System.EventHandler(this.btnEditSector_Click);
            // 
            // btnAddSector
            // 
            this.btnAddSector.BackgroundImage = global::trifenix.agro.app.Properties.Resources.add_icon;
            this.btnAddSector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSector.Location = new System.Drawing.Point(70, 2);
            this.btnAddSector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSector.Name = "btnAddSector";
            this.btnAddSector.Size = new System.Drawing.Size(34, 29);
            this.btnAddSector.TabIndex = 31;
            this.btnAddSector.UseVisualStyleBackColor = true;
            this.btnAddSector.Click += new System.EventHandler(this.btnAddSector_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnEditSector);
            this.pnlButtons.Controls.Add(this.btnDeleteSector);
            this.pnlButtons.Controls.Add(this.btnAddSector);
            this.pnlButtons.Enabled = false;
            this.pnlButtons.Location = new System.Drawing.Point(260, 576);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(200, 38);
            this.pnlButtons.TabIndex = 4;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(869, 612);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(100, 22);
            this.pb.TabIndex = 9;
            this.pb.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(812, 615);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProgress.Size = new System.Drawing.Size(51, 20);
            this.lblProgress.TabIndex = 10;
            this.lblProgress.Text = "label3";
            this.lblProgress.Visible = false;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 645);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.gbxItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Temporada";
            this.Load += new System.EventHandler(this.SectorFrm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxItem.ResumeLayout(false);
            this.gbxItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationForm)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gbxItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.ErrorProvider ValidationForm;
        private System.Windows.Forms.Button btnDeleteSector;
        private System.Windows.Forms.Button btnEditSector;
        private System.Windows.Forms.Button btnAddSector;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ComboBox cbCostCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsCostCenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEndSeason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartSeason;
    }
}