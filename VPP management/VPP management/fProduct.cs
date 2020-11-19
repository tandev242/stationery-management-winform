using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VPP_management.DAO;

namespace VPP_management
{
    public partial class fProduct : Form
    {
        public fProduct()
        {
            InitializeComponent();
        }

        private void fProduct_Load(object sender, EventArgs e)
        {
            LoadAllProduct();
        }
        void LoadAllProduct()
        {
            listView1.Items.Clear();
            DataTable dt = productDAO.Instance.getAllInfoProduct();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["ID"].ToString());
                listitem.SubItems.Add(dr["Image"].ToString());
                listitem.SubItems.Add(dr["Name"].ToString());
                listitem.SubItems.Add(dr["Quantity"].ToString());
                listitem.SubItems.Add(dr["PriceBuy"].ToString());
                listitem.SubItems.Add(dr["Price"].ToString());
                listitem.SubItems.Add(dr["NameCategory"].ToString());
                listView1.Items.Add(listitem);
            }
        }
    }
}
