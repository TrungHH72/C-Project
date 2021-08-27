using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectQLSV_N12.Models;


namespace ProjectQLSV_N12.Controls
{
    public class studentFunc
    {
        DataProvider data = new DataProvider();

        public DataTable getData(string query, DataTable dt)
        {
            dt = data.executeQuery(query);

            return dt;
        }
    }
}
