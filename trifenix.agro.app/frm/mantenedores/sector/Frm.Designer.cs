﻿namespace trifenix.agro.app.frm.mantenedores.sector
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbxItem = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationForm)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxCorrelativo
            // 
            this.tbxCorrelativo.Enabled = false;
            this.tbxCorrelativo.Location = new System.Drawing.Point(26, 66);
            this.tbxCorrelativo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxCorrelativo.Name = "tbxCorrelativo";
            this.tbxCorrelativo.Size = new System.Drawing.Size(82, 26);
            this.tbxCorrelativo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correlativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre :";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(134, 66);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxName.MaxLength = 200;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(498, 26);
            this.tbxName.TabIndex = 3;
            this.tbxName.Validated += new System.EventHandler(this.tbxName_Validated);
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
            this.gbxItem.Controls.Add(this.tbxName);
            this.gbxItem.Controls.Add(this.tbxCorrelativo);
            this.gbxItem.Controls.Add(this.btnCancel);
            this.gbxItem.Controls.Add(this.label1);
            this.gbxItem.Controls.Add(this.label2);
            this.gbxItem.Controls.Add(this.btnSave);
            this.gbxItem.Enabled = false;
            this.gbxItem.Location = new System.Drawing.Point(320, 89);
            this.gbxItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItem.Name = "gbxItem";
            this.gbxItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItem.Size = new System.Drawing.Size(656, 520);
            this.gbxItem.TabIndex = 5;
            this.gbxItem.TabStop = false;
            this.gbxItem.Text = "{0}";
            this.gbxItem.Visible = false;
            this.gbxItem.Enter += new System.EventHandler(this.gbxItem_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(407, 479);
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
            this.btnSave.Location = new System.Drawing.Point(528, 479);
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
            this.lbxItems.DisplayMember = "Name";
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 20;
            this.lbxItems.Location = new System.Drawing.Point(20, 105);
            this.lbxItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(289, 464);
            this.lbxItems.TabIndex = 9;
            this.lbxItems.ValueMember = "Id";
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(trifenix.connect.agro_model.Sector);
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
            this.btnDeleteSector.Location = new System.Drawing.Point(151, 3);
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
            this.btnAddSector.Location = new System.Drawing.Point(70, 3);
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
            this.pnlButtons.Location = new System.Drawing.Point(109, 577);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(200, 38);
            this.pnlButtons.TabIndex = 4;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(876, 611);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(100, 23);
            this.pb.TabIndex = 9;
            this.pb.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(819, 614);
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
            this.ClientSize = new System.Drawing.Size(993, 645);
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
            this.Text = "Sector";
            this.Load += new System.EventHandler(this.SectorFrm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxItem.ResumeLayout(false);
            this.gbxItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationForm)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCorrelativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxName;
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
    }
}