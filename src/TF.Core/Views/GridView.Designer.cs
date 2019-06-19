﻿namespace TF.Core.Views
{
    partial class GridView
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
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SubtitleGridView = new TF.Core.Views.GridView.TFDataGridView();
            this.btnSimpleImport = new System.Windows.Forms.Button();
            this.btnOffsetImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ExportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblChangedLinesCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dockPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubtitleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(1069, 450);
            this.dockPanel1.TabIndex = 0;
            this.dockPanel1.Theme = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SubtitleGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblChangedLinesCount);
            this.splitContainer1.Panel2.Controls.Add(this.btnSimpleImport);
            this.splitContainer1.Panel2.Controls.Add(this.btnOffsetImport);
            this.splitContainer1.Panel2.Controls.Add(this.btnExport);
            this.splitContainer1.Size = new System.Drawing.Size(1069, 450);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 2;
            // 
            // SubtitleGridView
            // 
            this.SubtitleGridView.AllowUserToAddRows = false;
            this.SubtitleGridView.AllowUserToDeleteRows = false;
            this.SubtitleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubtitleGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtitleGridView.Location = new System.Drawing.Point(0, 0);
            this.SubtitleGridView.MultiSelect = false;
            this.SubtitleGridView.Name = "SubtitleGridView";
            this.SubtitleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SubtitleGridView.Size = new System.Drawing.Size(1069, 418);
            this.SubtitleGridView.TabIndex = 2;
            this.SubtitleGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubtitleGridView_CellEndEdit);
            this.SubtitleGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SubtitleGridView_CellMouseDoubleClick);
            this.SubtitleGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.SubtitleGridView_CellPainting);
            this.SubtitleGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.SubtitleGridView_EditingControlShowing);
            // 
            // btnSimpleImport
            // 
            this.btnSimpleImport.Location = new System.Drawing.Point(209, 3);
            this.btnSimpleImport.Name = "btnSimpleImport";
            this.btnSimpleImport.Size = new System.Drawing.Size(97, 23);
            this.btnSimpleImport.TabIndex = 5;
            this.btnSimpleImport.Text = "Importer (Simple)";
            this.toolTip1.SetToolTip(this.btnSimpleImport, "Importer la traduction d'un fichier .xlsx\n\nCorrespond aux lignes du texte" +
        " original.");
            this.btnSimpleImport.UseVisualStyleBackColor = true;
            this.btnSimpleImport.Click += new System.EventHandler(this.btnSimpleImport_Click);
            // 
            // btnOffsetImport
            // 
            this.btnOffsetImport.Location = new System.Drawing.Point(106, 3);
            this.btnOffsetImport.Name = "btnOffsetImport";
            this.btnOffsetImport.Size = new System.Drawing.Size(97, 23);
            this.btnOffsetImport.TabIndex = 4;
            this.btnOffsetImport.Text = "Importar (Offset)";
            this.toolTip1.SetToolTip(this.btnOffsetImport, "Importer la traduction d'un fichier .xlsx\n\nCorrespond aux lignes par le champ" +
        " Offset");
            this.btnOffsetImport.UseVisualStyleBackColor = true;
            this.btnOffsetImport.Click += new System.EventHandler(this.btnOffsetImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(3, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exporter dans Excel";
            this.toolTip1.SetToolTip(this.btnExport, "Exporter les lignes dans un fichier .xlsx");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ExportFileDialog
            // 
            this.ExportFileDialog.Filter = "Archives Excel|*.xlsx";
            // 
            // ImportFileDialog
            // 
            this.ImportFileDialog.Filter = "Archives Excel|*.xlsx";
            // 
            // lblChangedLinesCount
            // 
            this.lblChangedLinesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChangedLinesCount.AutoSize = true;
            this.lblChangedLinesCount.Location = new System.Drawing.Point(312, 8);
            this.lblChangedLinesCount.Name = "lblChangedLinesCount";
            this.lblChangedLinesCount.Size = new System.Drawing.Size(124, 13);
            this.lblChangedLinesCount.TabIndex = 6;
            this.lblChangedLinesCount.Text = "Lignes modifiées : X/Y";
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridView";
            this.Text = "Sous-titres";
            ((System.ComponentModel.ISupportInitialize)(this.dockPanel1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubtitleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private TFDataGridView SubtitleGridView;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSimpleImport;
        private System.Windows.Forms.Button btnOffsetImport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog ExportFileDialog;
        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.Label lblChangedLinesCount;
    }
}