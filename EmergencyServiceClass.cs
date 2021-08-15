using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace EmergencyService
{
    class EmergencyServiceClass
    {
        private static SqlConnection connection = Database.GetConnection();

        private string txt, option;

        public string TXT
        {
            get { return this.txt; }
            set { this.txt = value; }
        }

        public string Option
        {
            get { return this.option; }
            set { this.option = value; }
        }

        public SqlDataAdapter Search()
        {
            SqlDataAdapter SearchData;

            if (option == "nid")
            {
                SearchData = new SqlDataAdapter(String.Format("SELECT * FROM [user] WHERE LOWER({'0'}) = '{1}'", option, txt), connection);

                return SearchData;
            }
            else if (option == "name")
            {
                SearchData = new SqlDataAdapter(String.Format("SELECT * FROM [user] WHERE LOWER({'0'}) = '{1}'", option, txt), connection);

                return SearchData;
            }
            else if (option == "phone")
            {
                SearchData = new SqlDataAdapter(String.Format("SELECT * FROM [user] WHERE LOWER({'0'}) = '{1}'", option, txt), connection);

                return SearchData;
            }

            return null;
        }
    }
}
