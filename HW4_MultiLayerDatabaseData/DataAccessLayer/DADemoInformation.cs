using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class DADemoInformation
    {
        public static DataSet GetDemographics()
        {

            DataSet dsGetDemographicsReport = new DataSet();

            dsGetDemographicsReport.DataSetName = "Demographics";

            DataTable dt = new DataTable("BasicInformation");
            dt.Clear();
            dt.Columns.Add(new DataColumn("FirstName", typeof(string)));
            dt.Columns.Add(new DataColumn("LastName", typeof(string)));
            dt.Columns.Add(new DataColumn("Sex", typeof(string)));
            dt.Columns.Add(new DataColumn("Address", typeof(string)));

            DataRow

            dr = dt.NewRow();
            dr["FirstName"] = "James";
            dr["LastName"] = "Bond";
            dr["Sex"] = "Male";
            dr["Address"] = "25 James Road, Orlando, FL";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "David";
            dr["LastName"] = "Johnson";
            dr["Sex"] = "Male";
            dr["Address"] = "222 David Drive, David, PA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "John";
            dr["LastName"] = "Williams";
            dr["Sex"] = "Male";
            dr["Address"] = "444 Williams Road, Williams, PA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "Pete";
            dr["LastName"] = "Queen";
            dr["Sex"] = "Female";
            dr["Address"] = "555 Pete Road, Queen, GA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "Jaswi";
            dr["LastName"] = "Edwars";
            dr["Sex"] = "Female";
            dr["Address"] = "666 Jaswi Drive, Edwars, PA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "Anderson";
            dr["LastName"] = "John";
            dr["Sex"] = "Male";
            dr["Address"] = "1000 Florida Ave, Tampa, FL";
            dt.Rows.Add(dr);

            dsGetDemographicsReport.Tables.Add(dt);

            return dsGetDemographicsReport;
        }
    }
}
