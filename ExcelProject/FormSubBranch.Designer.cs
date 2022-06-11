
namespace ExcelProject {
    partial class FormSubBranch {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubBranch));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnImportBranchTable = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlSubBranch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtBoxFilterTxt = new System.Windows.Forms.TextBox();
            this.comboBoxColsName = new System.Windows.Forms.ComboBox();
            this.panelFotter = new System.Windows.Forms.Panel();
            this.labelFilteredRecords = new System.Windows.Forms.Label();
            this.labelTotalRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFotter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnImportBranchTable,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(737, 150);
            // 
            // btnImportBranchTable
            // 
            this.btnImportBranchTable.Caption = "Import";
            this.btnImportBranchTable.Id = 1;
            this.btnImportBranchTable.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportBranchTable.ImageOptions.SvgImage")));
            this.btnImportBranchTable.Name = "btnImportBranchTable";
            this.btnImportBranchTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImportBranchTable_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Export";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnImportBranchTable);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gridControlSubBranch
            // 
            this.gridControlSubBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSubBranch.Location = new System.Drawing.Point(0, 250);
            this.gridControlSubBranch.MainView = this.gridView1;
            this.gridControlSubBranch.MenuManager = this.ribbonControl1;
            this.gridControlSubBranch.Name = "gridControlSubBranch";
            this.gridControlSubBranch.Size = new System.Drawing.Size(737, 375);
            this.gridControlSubBranch.TabIndex = 3;
            this.gridControlSubBranch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlSubBranch;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(169, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "This Table Represents Certain Branch Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 50);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.txtBoxFilterTxt);
            this.panel2.Controls.Add(this.comboBoxColsName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 50);
            this.panel2.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(461, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(104, 25);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtBoxFilterTxt
            // 
            this.txtBoxFilterTxt.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxFilterTxt.Location = new System.Drawing.Point(29, 16);
            this.txtBoxFilterTxt.Name = "txtBoxFilterTxt";
            this.txtBoxFilterTxt.Size = new System.Drawing.Size(188, 21);
            this.txtBoxFilterTxt.TabIndex = 4;
            this.txtBoxFilterTxt.Tag = "Enter text to filter...";
            this.txtBoxFilterTxt.Text = "Enter text to filter...";
            // 
            // comboBoxColsName
            // 
            this.comboBoxColsName.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxColsName.FormattingEnabled = true;
            this.comboBoxColsName.Location = new System.Drawing.Point(251, 16);
            this.comboBoxColsName.Name = "comboBoxColsName";
            this.comboBoxColsName.Size = new System.Drawing.Size(188, 21);
            this.comboBoxColsName.TabIndex = 3;
            this.comboBoxColsName.Tag = "Select column to filter...";
            this.comboBoxColsName.Text = "Select column to filter...";
            // 
            // panelFotter
            // 
            this.panelFotter.Controls.Add(this.labelFilteredRecords);
            this.panelFotter.Controls.Add(this.labelTotalRecords);
            this.panelFotter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFotter.Location = new System.Drawing.Point(0, 590);
            this.panelFotter.Name = "panelFotter";
            this.panelFotter.Size = new System.Drawing.Size(737, 35);
            this.panelFotter.TabIndex = 6;
            // 
            // labelFilteredRecords
            // 
            this.labelFilteredRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFilteredRecords.AutoSize = true;
            this.labelFilteredRecords.Location = new System.Drawing.Point(12, 11);
            this.labelFilteredRecords.Name = "labelFilteredRecords";
            this.labelFilteredRecords.Size = new System.Drawing.Size(95, 13);
            this.labelFilteredRecords.TabIndex = 2;
            this.labelFilteredRecords.Text = "Filtered Records : ";
            // 
            // labelTotalRecords
            // 
            this.labelTotalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalRecords.AutoSize = true;
            this.labelTotalRecords.Location = new System.Drawing.Point(216, 11);
            this.labelTotalRecords.Name = "labelTotalRecords";
            this.labelTotalRecords.Size = new System.Drawing.Size(83, 13);
            this.labelTotalRecords.TabIndex = 1;
            this.labelTotalRecords.Text = "Total Records : ";
            // 
            // FormSubBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 625);
            this.Controls.Add(this.panelFotter);
            this.Controls.Add(this.gridControlSubBranch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormSubBranch";
            this.Text = "FormSubBranch";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFotter.ResumeLayout(false);
            this.panelFotter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControlSubBranch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnImportBranchTable;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtBoxFilterTxt;
        private System.Windows.Forms.ComboBox comboBoxColsName;
        private System.Windows.Forms.Panel panelFotter;
        private System.Windows.Forms.Label labelFilteredRecords;
        private System.Windows.Forms.Label labelTotalRecords;
    }
}