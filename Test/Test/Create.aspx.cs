using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class Create : WebBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        /*Create product*/
        protected void Bt_ok_Click(object sender, EventArgs e)
        {
            //sql query for insert the product
            string query1 = "insert into Product(Title,Description) values ('"+ tb_CreateTitle.Text + "','" +tb_CreateDescription.Text.Replace("\r\n", "<br />") +  "')";


            //App_Code/Sqldb
            db.ExecData(query1);

            Response.Redirect("Test.aspx");
            

        }
    }
}