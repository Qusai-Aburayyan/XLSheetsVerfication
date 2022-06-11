
namespace ExcelProject {
    partial class FormMainBranch {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainBranch));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnImportMainTable = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportMainTable = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelFormName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtBoxFilterTxt = new System.Windows.Forms.TextBox();
            this.comboBoxColsName = new System.Windows.Forms.ComboBox();
            this.panelMainGridControl = new System.Windows.Forms.Panel();
            this.panelFotter = new System.Windows.Forms.Panel();
            this.labelFilteredRecords = new System.Windows.Forms.Label();
            this.labelTotalRecords = new System.Windows.Forms.Label();
            this.gridControlMainBranch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panelFormName.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panelMainGridControl.SuspendLayout();
            this.panelFotter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnImportMainTable,
            this.btnExportMainTable});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(875, 150);
            // 
            // btnImportMainTable
            // 
            this.btnImportMainTable.Caption = "Import";
            this.btnImportMainTable.Id = 1;
            this.btnImportMainTable.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportMainTable.ImageOptions.SvgImage")));
            this.btnImportMainTable.Name = "btnImportMainTable";
            this.btnImportMainTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImportMainTable_ItemClick);
            // 
            // btnExportMainTable
            // 
            this.btnExportMainTable.Caption = "Export";
            this.btnExportMainTable.Id = 2;
            this.btnExportMainTable.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportMainTable.ImageOptions.SvgImage")));
            this.btnExportMainTable.Name = "btnExportMainTable";
            this.btnExportMainTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportMainTable_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main Branch";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnImportMainTable);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExportMainTable);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // panelFormName
            // 
            this.panelFormName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFormName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormName.Controls.Add(this.label1);
            this.panelFormName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormName.Location = new System.Drawing.Point(0, 150);
            this.panelFormName.Margin = new System.Windows.Forms.Padding(4);
            this.panelFormName.Name = "panelFormName";
            this.panelFormName.Size = new System.Drawing.Size(875, 50);
            this.panelFormName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Table Represents a Collection of Branches Tables";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelChildForm.Controls.Add(this.btnClearFilter);
            this.panelChildForm.Controls.Add(this.btnFilter);
            this.panelChildForm.Controls.Add(this.txtBoxFilterTxt);
            this.panelChildForm.Controls.Add(this.comboBoxColsName);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChildForm.Location = new System.Drawing.Point(0, 200);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(875, 50);
            this.panelChildForm.TabIndex = 2;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Location = new System.Drawing.Point(458, 12);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(104, 25);
            this.btnClearFilter.TabIndex = 3;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(568, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(104, 25);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtBoxFilterTxt
            // 
            this.txtBoxFilterTxt.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxFilterTxt.Location = new System.Drawing.Point(35, 14);
            this.txtBoxFilterTxt.Name = "txtBoxFilterTxt";
            this.txtBoxFilterTxt.Size = new System.Drawing.Size(188, 23);
            this.txtBoxFilterTxt.TabIndex = 1;
            this.txtBoxFilterTxt.Tag = "Enter text to filter...";
            this.txtBoxFilterTxt.Text = "Enter text to filter...";
            this.txtBoxFilterTxt.Enter += new System.EventHandler(this.txtBoxFilterTxt_Enter);
            this.txtBoxFilterTxt.Leave += new System.EventHandler(this.txtBoxFilterTxt_Leave);
            // 
            // comboBoxColsName
            // 
            this.comboBoxColsName.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxColsName.FormattingEnabled = true;
            this.comboBoxColsName.Location = new System.Drawing.Point(257, 14);
            this.comboBoxColsName.Name = "comboBoxColsName";
            this.comboBoxColsName.Size = new System.Drawing.Size(188, 23);
            this.comboBoxColsName.TabIndex = 0;
            this.comboBoxColsName.Tag = "Select column to filter...";
            this.comboBoxColsName.Text = "Select column to filter...";
            this.comboBoxColsName.Enter += new System.EventHandler(this.txtBoxFilterTxt_Enter);
            this.comboBoxColsName.Leave += new System.EventHandler(this.txtBoxFilterTxt_Leave);
            // 
            // panelMainGridControl
            // 
            this.panelMainGridControl.Controls.Add(this.gridControlMainBranch);
            this.panelMainGridControl.Controls.Add(this.panelFotter);
            this.panelMainGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainGridControl.Location = new System.Drawing.Point(0, 250);
            this.panelMainGridControl.Margin = new System.Windows.Forms.Padding(10);
            this.panelMainGridControl.Name = "panelMainGridControl";
            this.panelMainGridControl.Size = new System.Drawing.Size(875, 372);
            this.panelMainGridControl.TabIndex = 3;
            // 
            // panelFotter
            // 
            this.panelFotter.Controls.Add(this.labelFilteredRecords);
            this.panelFotter.Controls.Add(this.labelTotalRecords);
            this.panelFotter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFotter.Location = new System.Drawing.Point(0, 337);
            this.panelFotter.Name = "panelFotter";
            this.panelFotter.Size = new System.Drawing.Size(875, 35);
            this.panelFotter.TabIndex = 2;
            // 
            // labelFilteredRecords
            // 
            this.labelFilteredRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFilteredRecords.AutoSize = true;
            this.labelFilteredRecords.Location = new System.Drawing.Point(12, 11);
            this.labelFilteredRecords.Name = "labelFilteredRecords";
            this.labelFilteredRecords.Size = new System.Drawing.Size(100, 15);
            this.labelFilteredRecords.TabIndex = 2;
            this.labelFilteredRecords.Text = "Filtered Records : ";
            // 
            // labelTotalRecords
            // 
            this.labelTotalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalRecords.AutoSize = true;
            this.labelTotalRecords.Location = new System.Drawing.Point(216, 11);
            this.labelTotalRecords.Name = "labelTotalRecords";
            this.labelTotalRecords.Size = new System.Drawing.Size(87, 15);
            this.labelTotalRecords.TabIndex = 1;
            this.labelTotalRecords.Text = "Total Records : ";
            // 
            // gridControlMainBranch
            // 
            this.gridControlMainBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMainBranch.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlMainBranch.Location = new System.Drawing.Point(0, 0);
            this.gridControlMainBranch.MainView = this.gridView1;
            this.gridControlMainBranch.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlMainBranch.MenuManager = this.ribbonControl1;
            this.gridControlMainBranch.Name = "gridControlMainBranch";
            this.gridControlMainBranch.Size = new System.Drawing.Size(875, 337);
            this.gridControlMainBranch.TabIndex = 0;
            this.gridControlMainBranch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 404;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControlMainBranch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // FormMainBranch
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 622);
            this.Controls.Add(this.panelMainGridControl);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelFormName);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainBranch";
            this.Text = "FormMainBranch";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panelFormName.ResumeLayout(false);
            this.panelFormName.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.panelMainGridControl.ResumeLayout(false);
            this.panelFotter.ResumeLayout(false);
            this.panelFotter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Panel panelFormName;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelMainGridControl;
        private DevExpress.XtraGrid.GridControl gridControlMainBranch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnImportMainTable;
        private System.Windows.Forms.ComboBox comboBoxColsName;
        private DevExpress.XtraBars.BarButtonItem btnExportMainTable;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtBoxFilterTxt;
        private System.Windows.Forms.Label labelTotalRecords;
        private System.Windows.Forms.Panel panelFotter;
        private System.Windows.Forms.Label labelFilteredRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearFilter;
    }
}