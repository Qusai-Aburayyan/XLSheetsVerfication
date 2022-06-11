using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelProject.Classes {
    public class XLSheet {
        public DataTable XLDataTable { get; set; }
        public XLSheet()
        {
            this.XLDataTable = new DataTable();
        }
    }
}
