using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelProject.Classes
{
    public class dataRowComparer : IEqualityComparer<DataRow>
    {
        private string comparerColName;
        private int comparingType;

        public dataRowComparer(string comparerColName, int comparingType)
        {
            this.comparerColName = comparerColName;
            this.comparingType = comparingType;
        }

        public bool Equals(DataRow x, DataRow y)
        {
            bool condA = x.Field<string>("id").Equals(y.Field<string>("id"));
            bool condB = x.Field<string>("payment").Equals(y.Field<string>("payment"));
            //bool condC = x.Field<string>("actionDate").Equals(y.Field<string>("actionDate"));

            if ((condA && condB) && comparingType == 1)
                return true;
            else if ((condA && !condB) && comparingType == 2)
                return true;
            else if (condA && comparingType == 3)
                return true;
            else
                return false;

            //if ((condA && condB && condC) && comparingType == 1)
            //    return true;
            //else if ((condA && (!condB || !condC)) && comparingType == 2)
            //    return true;
            //else if (condA && comparingType == 3)
            //    return true;
            //else
            //    return false;
        }

        public int GetHashCode(DataRow obj)
        {
            return obj.Field<string>(comparerColName).GetHashCode();
        }
    }
}
