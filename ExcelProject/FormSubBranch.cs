using ClosedXML.Excel;
using DevExpress.XtraEditors;
using ExcelProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelProject {
    public partial class FormSubBranch : DevExpress.XtraEditors.XtraForm {
        //single sub branch form
        private static FormSubBranch subBranchForm;
        public static XLSheet xLSheet { get; set; }

        public DataView dataView;

        //gets the form instance
        public static FormSubBranch GetSubBranchForm()
        {
            if (subBranchForm == null)
                return subBranchForm = new FormSubBranch();
            else
                return subBranchForm;
        }

        public FormSubBranch()
        {
            InitializeComponent();
        }

        //import table button
        private void btnImportBranchTable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                Multiselect = false
            };

            xLSheet = new XLSheet();

            using (openFileDialog)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    XLWorkbook xLWorkbook = new XLWorkbook(openFileDialog.FileName);
                    using (xLWorkbook)
                    {
                        bool isFirstRow = true;
                        var rows = xLWorkbook.Worksheet(1).RowsUsed();
                        foreach (var row in rows)
                        {
                            if (isFirstRow)
                            {
                                foreach (IXLCell cell in row.Cells())
                                {
                                    xLSheet.XLDataTable.Columns.Add(cell.Value.ToString());
                                    comboBoxColsName.Items.Add(cell.Value.ToString());
                                }
                                isFirstRow = false;
                            }
                            else
                            {
                                xLSheet.XLDataTable.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    xLSheet.XLDataTable.Rows[xLSheet.XLDataTable.Rows.Count - 1][i++] = cell.Value.ToString();
                            }
                        }
                    }
                }
            }

            dataView = new DataView(xLSheet.XLDataTable);
            gridControlSubBranch.DataSource = dataView;

            //display records count
            labelTotalRecords.Text = "Total Records : " + dataView.Count;

        }

        //export table button
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx"
            };
            using (saveFileDialog)
            {
                XLWorkbook xLWorkbook = new XLWorkbook();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (xLWorkbook)
                        {
                            xLWorkbook.Worksheets.Add(dataView.ToTable(), "Exported");
                            xLWorkbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("You have successfuly exported your data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //filter records according to txt box value
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                dataView.RowFilter = $"{comboBoxColsName.SelectedItem} LIKE '" + txtBoxFilterTxt.Text + "*'";
                gridControlSubBranch.DataSource = dataView;
                //display filtered records count
                labelFilteredRecords.Text = "Filtered Records : " + dataView.Count;
                labelFilteredRecords.ForeColor = Color.Red;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Do leave and Enter Events
        //**************************

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}