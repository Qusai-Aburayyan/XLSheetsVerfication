using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelProject.Classes
{
    /// <summary>
    /// This class is used to create a table that will be used for implemnting the report operations
    /// </summary>
    public class CustomTable
    {
        private DataTable sourceTable = new DataTable();
        private string tableName;
        private DataTable customTable;
        private int colsCount;

        private string[] srcColsNames;

        private string[] colsNames = { "id", "payment", "actionDate" };
        private string[] colsDataType = { "String", "String", "String" };
        private bool[] isPrimaryKey = { true, false, false, false };

        public CustomTable(DataTable sourceTable, string tableName, string[] srcColsNames)
        {
            this.sourceTable = sourceTable;
            this.tableName = tableName;
            this.srcColsNames = srcColsNames;
            this.colsCount = this.colsNames.Length;

            customTable = new DataTable(this.tableName);

            DeclareTable();
            SelectRecords();
        }

        // declare the custom table
        private DataTable DeclareTable()
        {
            int colsCount = colsNames.Count();

            for (int i = 0; i < colsCount; i++)
            {
                DataColumn dataColumn = new DataColumn(colsNames[i], System.Type.GetType($"System.{colsDataType[i]}".ToString()));

                if (isPrimaryKey[i])
                    customTable.PrimaryKey = new DataColumn[] { customTable.Columns[colsNames.ToString()] };

                customTable.Columns.Add(colsNames[i]);
            }
            return customTable;
        }        

        // add certain records to to the custom table
        void SelectRecords()
        {
            foreach (DataRow row in sourceTable.Rows)
            {
                string[] newRow = new string[this.colsCount];

                for (int i = 0; i < colsCount; i++)
                    newRow[i] = row.Field<string>(srcColsNames[i].ToString());

                customTable.Rows.Add(newRow);
            }
        }

        public DataTable getCustomeTable()
        {
            return customTable;
        }
    }
}
