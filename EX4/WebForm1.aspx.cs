using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet dataSet;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
                dataSet = (DataSet)Page.Application["App"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        protected void refreshTable()
        {
            GridView1.DataSource = dataSet.Tables["KindsTbl"];
            GridView1.DataBind();
            GridView2.DataSource = dataSet.Tables["WordsTbl"];
            GridView2.DataBind();
        }
    }
}