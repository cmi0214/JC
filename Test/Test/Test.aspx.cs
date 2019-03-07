using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Test
{
    public partial class Test : WebBasePage
    {
        public int CurrentPage = 1;
        public string ListPagingText = "";
        public string TotalRecord = "";
        public string PageStatus = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            GetList();
            }
        }

        protected void ListView1_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
       

        }

        /*
         *Listview DataBind with Product table
         */
        protected void GetList()
        {
            string sql = "SELECT * FROM product ";
            DataSet ds = db.SelectData(sql);

            if (ds != null)
            {
                int cnt = ds.Tables[0].Rows.Count;
                if (cnt > 0)
                {

                    ListView1.DataSource = ds.Tables[0].DefaultView;
                    ListView1.DataBind();
                    ldPager.DataBind();
                    ldPager.Visible = true;


                }
                else
                {
                    ListView1.DataSource = null;
                    ListView1.DataBind();
                    ldPager.DataBind();
                    ldPager.Visible = false;
                }
            }


        }

        protected void BtSearch_Click(object sender, EventArgs e)
        {
            //search the product include text entered
            string sql = "SELECT * FROM product where title like'" + Tb_Search.Text+"%'" ;
            DataSet ds = db.SelectData(sql);

            if (ds != null)
            {
                int cnt = ds.Tables[0].Rows.Count;
                if (cnt > 0)
                {


                    
                    ListView1.DataSource = ds.Tables[0].DefaultView;
                    ListView1.DataBind();
                    ldPager.DataBind();
                
                    ldPager.Visible = true;


                }
                else
                {
                    ListView1.DataSource = null;
                    ListView1.DataBind();
                    ldPager.DataBind();
                    ldPager.Visible = false;
                }
            }


        }
        /*
         * Move to Create Page
         */
        protected void Bt_Create_Click(object sender, EventArgs e)
        {

            Response.Redirect("Create.aspx");


        }

        protected void ListView1_PagePropertiesChanged(object sender, EventArgs e)
        {
            GetList();
        }

        /*
         Reset button
         */
        protected void Bt_all_Click(object sender, EventArgs e)
        {
            GetList();
        }

   
    }
}