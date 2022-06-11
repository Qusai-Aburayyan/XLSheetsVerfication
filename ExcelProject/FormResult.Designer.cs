
namespace ExcelProject {
    partial class FormResult {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResult));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMatchRecords = new DevExpress.XtraBars.BarButtonItem();
            this.btnFoundInMainNotInBranch = new DevExpress.XtraBars.BarButtonItem();
            this.btnFoundInBranchNotInMain = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxComparisonTxt = new System.Windows.Forms.TextBox();
            this.comboBoxColName = new System.Windows.Forms.ComboBox();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.labelDifference2 = new System.Windows.Forms.Label();
            this.gridControlDifference2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnExportDifference2 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControlDifference1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnExportDifference1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelDifference1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFotter = new System.Windows.Forms.Panel();
            this.labelMatchRecords = new System.Windows.Forms.Label();
            this.gridControlMatchRecords = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExportMatch = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDifference2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDifference1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFotter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatchRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnMatchRecords,
            this.btnFoundInMainNotInBranch,
            this.btnFoundInBranchNotInMain});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1180, 150);
            // 
            // btnMatchRecords
            // 
            this.btnMatchRecords.Caption = "Match Records";
            this.btnMatchRecords.Id = 1;
            this.btnMatchRecords.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMatchRecords.ImageOptions.SvgImage")));
            this.btnMatchRecords.Name = "btnMatchRecords";
            this.btnMatchRecords.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMatchRecords_ItemClick);
            // 
            // btnFoundInMainNotInBranch
            // 
            this.btnFoundInMainNotInBranch.Caption = "Not Found in Branch Table";
            this.btnFoundInMainNotInBranch.Id = 2;
            this.btnFoundInMainNotInBranch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFoundInMainNotInBranch.ImageOptions.SvgImage")));
            this.btnFoundInMainNotInBranch.Name = "btnFoundInMainNotInBranch";
            this.btnFoundInMainNotInBranch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFoundInMainNotInBranch_ItemClick);
            // 
            // btnFoundInBranchNotInMain
            // 
            this.btnFoundInBranchNotInMain.Caption = "Not Found In Main Table";
            this.btnFoundInBranchNotInMain.Id = 3;
            this.btnFoundInBranchNotInMain.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFoundInBranchNotInMain.ImageOptions.SvgImage")));
            this.btnFoundInBranchNotInMain.Name = "btnFoundInBranchNotInMain";
            this.btnFoundInBranchNotInMain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFoundInBranchNotInMain_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMatchRecords);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFoundInMainNotInBranch);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFoundInBranchNotInMain);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBoxComparisonTxt);
            this.panel1.Controls.Add(this.comboBoxColName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 50);
            this.panel1.TabIndex = 1;
            // 
            // txtBoxComparisonTxt
            // 
            this.txtBoxComparisonTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxComparisonTxt.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxComparisonTxt.Location = new System.Drawing.Point(308, 14);
            this.txtBoxComparisonTxt.Name = "txtBoxComparisonTxt";
            this.txtBoxComparisonTxt.Size = new System.Drawing.Size(236, 21);
            this.txtBoxComparisonTxt.TabIndex = 7;
            this.txtBoxComparisonTxt.Tag = "Enter text to comparsion...";
            this.txtBoxComparisonTxt.Text = "Enter text to comparsion...";
            // 
            // comboBoxColName
            // 
            this.comboBoxColName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxColName.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxColName.FormattingEnabled = true;
            this.comboBoxColName.Location = new System.Drawing.Point(557, 14);
            this.comboBoxColName.Name = "comboBoxColName";
            this.comboBoxColName.Size = new System.Drawing.Size(236, 21);
            this.comboBoxColName.TabIndex = 6;
            this.comboBoxColName.Tag = "Select source column...";
            this.comboBoxColName.Text = "Select source column...";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.24F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.76F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 200);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 136F)});
            this.tablePanel1.Size = new System.Drawing.Size(1180, 556);
            this.tablePanel1.TabIndex = 3;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel2.Controls.Add(this.panel4);
            this.tablePanel2.Controls.Add(this.panel3);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(558, 3);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 237F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 237F)});
            this.tablePanel2.Size = new System.Drawing.Size(619, 550);
            this.tablePanel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablePanel2.SetColumn(this.panel4, 0);
            this.panel4.Controls.Add(this.gridControlDifference2);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel14);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(17, 292);
            this.panel4.Margin = new System.Windows.Forms.Padding(17, 17, 3, 3);
            this.panel4.Name = "panel4";
            this.tablePanel2.SetRow(this.panel4, 1);
            this.panel4.Size = new System.Drawing.Size(599, 255);
            this.panel4.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.labelDifference2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(599, 35);
            this.panel12.TabIndex = 7;
            // 
            // labelDifference2
            // 
            this.labelDifference2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDifference2.AutoSize = true;
            this.labelDifference2.Location = new System.Drawing.Point(12, 9);
            this.labelDifference2.Name = "labelDifference2";
            this.labelDifference2.Size = new System.Drawing.Size(88, 13);
            this.labelDifference2.TabIndex = 2;
            this.labelDifference2.Text = "Records Count : ";
            // 
            // gridControlDifference2
            // 
            this.gridControlDifference2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDifference2.Location = new System.Drawing.Point(0, 70);
            this.gridControlDifference2.MainView = this.gridView3;
            this.gridControlDifference2.MenuManager = this.ribbonControl1;
            this.gridControlDifference2.Name = "gridControlDifference2";
            this.gridControlDifference2.Size = new System.Drawing.Size(599, 150);
            this.gridControlDifference2.TabIndex = 2;
            this.gridControlDifference2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlDifference2;
            this.gridView3.Name = "gridView3";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btnExportDifference2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 35);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(599, 35);
            this.panel10.TabIndex = 1;
            // 
            // btnExportDifference2
            // 
            this.btnExportDifference2.Location = new System.Drawing.Point(15, 5);
            this.btnExportDifference2.Name = "btnExportDifference2";
            this.btnExportDifference2.Size = new System.Drawing.Size(109, 23);
            this.btnExportDifference2.TabIndex = 2;
            this.btnExportDifference2.Text = "Export Result";
            this.btnExportDifference2.UseVisualStyleBackColor = true;
            this.btnExportDifference2.Click += new System.EventHandler(this.btnExportDifference2_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(599, 35);
            this.panel9.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(71, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "This Table Represents Missing Records From Main Table";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablePanel2.SetColumn(this.panel3, 0);
            this.panel3.Controls.Add(this.gridControlDifference1);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(17, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(17, 3, 3, 17);
            this.panel3.Name = "panel3";
            this.tablePanel2.SetRow(this.panel3, 0);
            this.panel3.Size = new System.Drawing.Size(599, 255);
            this.panel3.TabIndex = 0;
            // 
            // gridControlDifference1
            // 
            this.gridControlDifference1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDifference1.Location = new System.Drawing.Point(0, 70);
            this.gridControlDifference1.MainView = this.gridView2;
            this.gridControlDifference1.MenuManager = this.ribbonControl1;
            this.gridControlDifference1.Name = "gridControlDifference1";
            this.gridControlDifference1.Size = new System.Drawing.Size(599, 150);
            this.gridControlDifference1.TabIndex = 2;
            this.gridControlDifference1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlDifference1;
            this.gridView2.Name = "gridView2";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnExportDifference1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(599, 35);
            this.panel8.TabIndex = 1;
            // 
            // btnExportDifference1
            // 
            this.btnExportDifference1.Location = new System.Drawing.Point(15, 5);
            this.btnExportDifference1.Name = "btnExportDifference1";
            this.btnExportDifference1.Size = new System.Drawing.Size(109, 23);
            this.btnExportDifference1.TabIndex = 1;
            this.btnExportDifference1.Text = "Export Result";
            this.btnExportDifference1.UseVisualStyleBackColor = true;
            this.btnExportDifference1.Click += new System.EventHandler(this.btnExportDifference1_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(599, 35);
            this.panel7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(71, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "This Table Represents Missing Records From Branch Table";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Maroon;
            this.panel13.Controls.Add(this.panel11);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 220);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(599, 35);
            this.panel13.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.labelDifference1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(599, 35);
            this.panel11.TabIndex = 7;
            // 
            // labelDifference1
            // 
            this.labelDifference1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDifference1.AutoSize = true;
            this.labelDifference1.Location = new System.Drawing.Point(12, 9);
            this.labelDifference1.Name = "labelDifference1";
            this.labelDifference1.Size = new System.Drawing.Size(88, 13);
            this.labelDifference1.TabIndex = 2;
            this.labelDifference1.Text = "Records Count : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.gridControlMatchRecords);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 6, 17, 3);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 0);
            this.panel2.Size = new System.Drawing.Size(535, 547);
            this.panel2.TabIndex = 0;
            // 
            // panelFotter
            // 
            this.panelFotter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelFotter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFotter.Controls.Add(this.labelMatchRecords);
            this.panelFotter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFotter.Location = new System.Drawing.Point(0, 0);
            this.panelFotter.Name = "panelFotter";
            this.panelFotter.Size = new System.Drawing.Size(535, 35);
            this.panelFotter.TabIndex = 7;
            // 
            // labelMatchRecords
            // 
            this.labelMatchRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMatchRecords.AutoSize = true;
            this.labelMatchRecords.Location = new System.Drawing.Point(12, 9);
            this.labelMatchRecords.Name = "labelMatchRecords";
            this.labelMatchRecords.Size = new System.Drawing.Size(88, 13);
            this.labelMatchRecords.TabIndex = 2;
            this.labelMatchRecords.Text = "Records Count : ";
            // 
            // gridControlMatchRecords
            // 
            this.gridControlMatchRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMatchRecords.Location = new System.Drawing.Point(0, 70);
            this.gridControlMatchRecords.MainView = this.gridView1;
            this.gridControlMatchRecords.MenuManager = this.ribbonControl1;
            this.gridControlMatchRecords.Name = "gridControlMatchRecords";
            this.gridControlMatchRecords.Size = new System.Drawing.Size(535, 442);
            this.gridControlMatchRecords.TabIndex = 2;
            this.gridControlMatchRecords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlMatchRecords;
            this.gridView1.Name = "gridView1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnExportMatch);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(535, 35);
            this.panel6.TabIndex = 1;
            // 
            // btnExportMatch
            // 
            this.btnExportMatch.Location = new System.Drawing.Point(8, 5);
            this.btnExportMatch.Name = "btnExportMatch";
            this.btnExportMatch.Size = new System.Drawing.Size(109, 23);
            this.btnExportMatch.TabIndex = 0;
            this.btnExportMatch.Text = "Export Result";
            this.btnExportMatch.UseVisualStyleBackColor = true;
            this.btnExportMatch.Click += new System.EventHandler(this.btnExportMatch_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(535, 35);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(109, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "This Table Represents Match Records";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Maroon;
            this.panel14.Controls.Add(this.panel12);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 220);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(599, 35);
            this.panel14.TabIndex = 8;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Maroon;
            this.panel15.Controls.Add(this.panelFotter);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 512);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(535, 35);
            this.panel15.TabIndex = 8;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 756);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormResult";
            this.Text = "FormResult";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDifference2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDifference1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelFotter.ResumeLayout(false);
            this.panelFotter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatchRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControlMatchRecords;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraBars.BarButtonItem btnMatchRecords;
        private DevExpress.XtraBars.BarButtonItem btnFoundInMainNotInBranch;
        private DevExpress.XtraGrid.GridControl gridControlDifference1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraBars.BarButtonItem btnFoundInBranchNotInMain;
        private DevExpress.XtraGrid.GridControl gridControlDifference2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxComparisonTxt;
        private System.Windows.Forms.ComboBox comboBoxColName;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label labelDifference2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label labelDifference1;
        private System.Windows.Forms.Panel panelFotter;
        private System.Windows.Forms.Label labelMatchRecords;
        private System.Windows.Forms.Button btnExportMatch;
        private System.Windows.Forms.Button btnExportDifference1;
        private System.Windows.Forms.Button btnExportDifference2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
    }
}