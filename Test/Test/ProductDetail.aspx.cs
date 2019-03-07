using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Specialized;
namespace Test
{
    public partial class ProductDetail : WebBasePage
    {


        /*Productdetail page*/
        public string id = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            GetList();
        }

        protected void Lb_ProductDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {

        }
        /*DataBind with listview*/
        protected void GetList()
        {

            //get url parameter to search specific item
            if (Request.QueryString["id"] != null)
            {
                string results = Request.QueryString["id"];
                Label1.Text = "PRODUCT DETAILS";
                id = results;
            }
            else
                Label1.Text = "There is no results in QueryString";



            string sql = "SELECT * FROM product where No='" + id + "'";


            DataSet ds = db.SelectData(sql);

            if (ds != null)
            {
                int cnt = ds.Tables[0].Rows.Count;
                if (cnt > 0)
                {

                    Lb_ProductDetail.DataSource = ds.Tables[0].DefaultView;
                    Lb_ProductDetail.DataBind();


                }
                else
                {
                    Lb_ProductDetail.DataSource = null;
                    Lb_ProductDetail.DataBind();
                }
            }


        }

        protected void Bt_Dashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("Test");
        }
    }
}