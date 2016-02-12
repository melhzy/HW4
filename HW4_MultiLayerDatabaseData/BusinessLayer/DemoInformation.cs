using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using Models;

namespace BusinessLayer
{
    public class DemoInformation
    {
        public static List<IndivDemographics> GetDemoData()
        {
            IndivDemographics IndivDemo = new IndivDemographics();
            var IndivDemoList = new List<IndivDemographics>();
            DataSet dsGetDemographicsReport = new DataSet();
            dsGetDemographicsReport = DADemoInformation.GetDemographics();

            if (dsGetDemographicsReport.Tables.Count > 0)
            {
                IndivDemoList = dsGetDemographicsReport.Tables[0].AsEnumerable().Select(m => new IndivDemographics
                {
                    FirstName = Convert.ToString(m["FirstName"]),
                    LastName = Convert.ToString(m["LastName"]),
                    Sex = Convert.ToString(m["Sex"]),
                    Address = Convert.ToString(m["Address"])
                }).ToList();
            }

            return IndivDemoList;
        }
    }
}
