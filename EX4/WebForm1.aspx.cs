using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        protected void refreshTable()
        {
            WordsService service = new WordsService();
            GridView1.DataSource = service.GetSubjectsl();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}