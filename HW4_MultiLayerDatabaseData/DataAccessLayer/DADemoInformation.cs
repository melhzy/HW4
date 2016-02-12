using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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

        public static DataSet GetDemographicsUsingDBWithConfig()
        {

            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;
            DataTable dt = new DataTable();
            DataSet dsGetDemographicsReport = new DataSet();

            string cs = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "Select * from IndividualDemographics";

            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetDemographicsReport.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetDemographicsReport;
        }

        //Get the demographics from database but define the connection string in this method
        public static DataSet GetDemographicsUsingDBWithOutConfig()
        {
            string connetionString = null;

            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;
            DataTable dt = new DataTable();
            DataSet dsGetDemographicsReport = new DataSet();

            connetionString = "Data Source=MELSACERINNJ;Initial Catalog=employee;Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);

            sql = "Select * from IndividualDemographics";

            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetDemographicsReport.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetDemographicsReport;
        }
    }
}