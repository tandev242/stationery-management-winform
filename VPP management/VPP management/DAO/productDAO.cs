using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPP_management.DAO
{
    public class productDAO
    {
        private static productDAO instance;

        public static productDAO Instance
        {
            get { if (instance == null) instance = new productDAO(); return productDAO.instance; }
            private set { productDAO.instance = value; }
        }
        private productDAO() { }
        public DataTable getAllInfoProduct()
        {
            string query = @"EXEC sp_getAllInfoProduct";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getAllInfoProductByIdOrName(String Name)
        {
            string query = @"EXEC sp_getAllInfoProductByIdOrName N'"+Name+"'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
