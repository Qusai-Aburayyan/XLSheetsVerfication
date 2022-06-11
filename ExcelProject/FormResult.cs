using ClosedXML.Excel;
using ExcelProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExcelProject
{
    public partial class FormResult : DevExpress.XtraEditors.XtraForm
    {

        // source tables
        private DataTable mainTable;
        private DataTable subTable;

        // custom tables
        private DataTable mBCustomsTable;
        private DataTable sBCustomsTable;

        /// <summary>
        /// custom tables that will be used in the set operations
        /// </summary>
        private void CreateCustomTables()
        {
            string[] srcMbColsNames = { "الملاحظات", "المبلغ", "تاريخ الحركة" };
            string[] srcSbColsNames = { "رقم الإيصال", "المبلغ المدفوع", "تاريخ دفع البنك" };

            //string[] srcMbColsNames = { "الملاحظات", "الفرع", "المبلغ", "تاريخ الحركة" };
            //string[] srcSbColsNames = { "الملاحظات", "الفرع", "المبلغ", "تاريخ الحركة" };

            // declare main branch custom table
            CustomTable mBCustomsTable = new CustomTable(mainTable, "mBCustomsTable", srcMbColsNames);
            this.mBCustomsTable = mBCustomsTable.getCustomeTable();

            CustomTable sBCustomsTable = new CustomTable(subTable, "sBCustomsTable", srcSbColsNames);
            this.sBCustomsTable = sBCustomsTable.getCustomeTable();
        }

        public FormResult()
        {
            if (FormMainBranch.xLSheet == null)
            {
                MessageBox.Show("Import the Main Table and Branch Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InitializeComponent();

                // declare source tables
                this.mainTable = new DataTable("mainTableSRC");
                this.subTable = new DataTable("subTableSRC");

                //initialize the source tables
                this.mainTable = FormMainBranch.xLSheet.XLDataTable;
                this.subTable = FormSubBranch.xLSheet.XLDataTable;

                /// initialize customized tables
                CreateCustomTables();

                //initilize the combox
                comboBoxColName.Items.Add("id");
            }
        }

        //------------------------------------ Set Operations ------------------------------------------------

        #region Set Operations

        DataTable matchedRows = new DataTable("Matched Rows");
        DataTable nonMatchedCells = new DataTable("Non Matched Cells");
        DataTable missingRows = new DataTable("Missing Rows");

        //comparer key
        dataRowComparer mathcComparer = new dataRowComparer("id", 1);
        dataRowComparer noMatchCellsComparer = new dataRowComparer("id", 2);
        dataRowComparer missingRowsComparer = new dataRowComparer("id", 3);

        //Gets the matched records between (Filtered Main Branch Table) and (Branch Table) by using comparerColumn
        private void btnMatchRecords_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                mBCustomsTable = FilterRows(mBCustomsTable);
                sBCustomsTable = FilterRows(sBCustomsTable);

                matchedRows = mBCustomsTable.AsEnumerable().Intersect(sBCustomsTable.AsEnumerable(), mathcComparer).CopyToDataTable();


                string[] colsName = { "matchedIDs", "matchedPayment", "matchedDate" };
                Type[] colsType = { typeof(bool), typeof(bool), typeof(bool) };

                matchedRows = InsertColumns(matchedRows, colsName, colsType);

                foreach (DataRow row in matchedRows.Rows)
                {
                    row["matchedIDs"] = true;
                    row["matchedPayment"] = true;
                    row["matchedDate"] = true;
                }

                gridControlMatchRecords.DataSource = matchedRows.DefaultView;

                labelMatchRecords.Text = "Records Count : " + matchedRows.Rows.Count;
                labelMatchRecords.ForeColor = Color.Red;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Gets missing records in the (Branch Table) that exist in the (Main Branch Table) for a certain Branch
        private void btnFoundInMainNotInBranch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nonMatchedCells = mBCustomsTable.AsEnumerable().Intersect(sBCustomsTable.AsEnumerable(), noMatchCellsComparer).CopyToDataTable();

                string[] colsName = { "matchedIDs", "matchedPayment", "matchedDate", "PaymentInBranch", "ActionDateInBranch" };
                Type[] colsType = { typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(string) };
                nonMatchedCells = InsertColumns(nonMatchedCells, colsName, colsType);

                foreach (DataRow row in nonMatchedCells.Rows) 
                {
                    foreach (DataRow row1 in sBCustomsTable.Rows)
                    {
                        if (row[0].ToString() == row1[0].ToString())
                        {
                            row["matchedIDs"] = true;

                            row["PaymentInBranch"] = row1["payment"].ToString();
                            row["ActionDateInBranch"] = row1["actionDate"].ToString();

                            if (row["PaymentInBranch"].ToString() == row["payment"].ToString())
                            {
                                row["matchedPayment"] = true;
                            }
                            else
                            {
                                row["matchedPayment"] = false;
                            }

                            if (row["ActionDateInBranch"].ToString() == row["actionDate"].ToString())
                            {
                                row["matchedDate"] = true;
                            }
                            else
                            {
                                row["matchedDate"] = false;
                            }
                        }
                    }
                }

                gridControlDifference1.DataSource = nonMatchedCells.DefaultView;

                labelDifference1.Text = "Records Count : " + nonMatchedCells.Rows.Count;
                labelDifference1.ForeColor = Color.Red;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFoundInBranchNotInMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string[] colsName = { "id", "branchNo", "payment", "actionDate" };
                Type[] colsType = { typeof(string), typeof(string), typeof(string), typeof(string) };
                missingRows = InsertColumns(missingRows, colsName, colsType);

                DataTable resultA = new DataTable();
                DataTable resultB = new DataTable();

                resultA = mBCustomsTable.AsEnumerable().Except(sBCustomsTable.AsEnumerable(),missingRowsComparer).CopyToDataTable();
                resultB = sBCustomsTable.AsEnumerable().Except(mBCustomsTable.AsEnumerable(),missingRowsComparer).CopyToDataTable();

                foreach (DataRow row in resultA.Rows)
                    missingRows.ImportRow(row);

                foreach (DataRow row in resultB.Rows)
                    missingRows.ImportRow(row);

                gridControlDifference2.DataSource = missingRows.DefaultView;

                labelDifference2.Text = "Records Count : " + missingRows.Rows.Count;
                labelDifference2.ForeColor = Color.Red;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Filter all records in the (Main Branch Table) that contain in the branch column (Bracnh number / Bracnh intro)
        private DataTable FilterRows(DataTable table)
        {
            DataView dataView;
            dataView = new DataView(table);


            try
            {
                string PKColName = comboBoxColName.SelectedItem.ToString();
                string PKIdentifier = txtBoxComparisonTxt.Text;
                dataView.RowFilter = $"{PKColName} LIKE '" + PKIdentifier + "*'";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataView.ToTable();
        }

        private DataTable InsertColumns(DataTable table, string[] colsNames, Type[] colsType)
        {
            int colsCount = colsNames.Length;

            for (int i = 0; i < colsCount; i++)
            {
                DataColumn newCol = table.Columns.Add(colsNames[i], colsType[i]);
            }
            return table;
        }

        #endregion

        //----------------------------------------------------------------------------------------------------


        #region Export Results

        //export data table to excel
        private void ExportToExcel(DataTable table)
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
                            xLWorkbook.Worksheets.Add(table, "Exported");
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

        //export match table
        private void btnExportMatch_Click(object sender, EventArgs e)
        {
            ExportToExcel(matchedRows);
        }

        //export extra records in the main table
        private void btnExportDifference1_Click(object sender, EventArgs e)
        {
            ExportToExcel(nonMatchedCells);
        }

        //export extra records in the branch
        private void btnExportDifference2_Click(object sender, EventArgs e)
        {
            ExportToExcel(missingRows);
        }

        #endregion


        //-----
        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}