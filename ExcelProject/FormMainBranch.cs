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
    public partial class FormMainBranch : DevExpress.XtraEditors.XtraForm {

        //single main form
        private static FormMainBranch mainBranchForm;

        public static XLSheet xLSheet { get; set; }

        public DataView dataView;

        //gets the form instance
        public static FormMainBranch GetMainForm()
        {
            if (mainBranchForm == null)
                return mainBranchForm = new FormMainBranch();
            else
                return mainBranchForm;
        }

        //form constructor
        public FormMainBranch()
        {
            InitializeComponent();
        }

        //import table button
        private void btnImportMainTable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //colsName = new List<string>();

            //clear the comboBox for multiple imports
            comboBoxColsName.Items.Clear();

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
            gridControlMainBranch.DataSource = dataView;

            //display records count
            labelTotalRecords.Text = "Total Records : " + dataView.Count;
        }

        //export table button
        private void btnExportMainTable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    Cursor.Current = Cursors.WaitCursor;
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
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        //filter records according to txt box value
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(comboBoxColsName.SelectedItem == null || txtBoxFilterTxt.Text == "Select column to filter...")
            {
                MessageBox.Show("Text box is empty!");
            }
            else
            {
                try
                {
                    dataView.RowFilter = $"{comboBoxColsName.SelectedItem} LIKE '" + txtBoxFilterTxt.Text + "*'";
                    gridControlMainBranch.DataSource = dataView;

                    //display filtered records count
                    labelFilteredRecords.Text = "Filtered Records : " + dataView.Count;
                    labelFilteredRecords.ForeColor = Color.Red;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            try
            {
                dataView = new DataView(xLSheet.XLDataTable);
                gridControlMainBranch.DataSource = dataView;

                txtBoxFilterTxt.Text = "Enter text to filter...";
                txtBoxFilterTxt.ForeColor = Color.Gray;

                comboBoxColsName.SelectedIndex = -1;
                comboBoxColsName.Text = "Select column to filter...";
                comboBoxColsName.ForeColor = Color.Gray;

                //display records count
                labelFilteredRecords.Text = "Filtered Records : " + " ";
                labelTotalRecords.Text = "Total Records : " + dataView.Count;
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void txtBoxFilterTxt_Enter(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control is TextBox)
                control = (TextBox)control;

            if(control.Text == control.Tag.ToString())
            {
                control.Text = "";
                control.ForeColor = Color.Black;
            }
        }

        private void txtBoxFilterTxt_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control is TextBox)
                control = (TextBox)control;

            if (control.Text.Trim() == "")
            {
                control.Text = control.Tag.ToString();
                control.ForeColor = Color.Gray;
            }
        }

    }
}