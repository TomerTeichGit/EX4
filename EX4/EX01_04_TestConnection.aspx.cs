using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX4
{
    public partial class EX01_04_TestConnection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WordsService wordsService = new WordsService();
            LabelError.Text = "";
            LabelMsg.Text = "";
            try
            {
                string results = wordsService.returnWordByKod(TextBox1.Text);
                LabelMsg.Text = results;
            }
            catch(Exception ex)
            {
                this.LabelError.Text = ex.Message;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            WordsService wordsService = new WordsService();
            LabelError.Text = "";
            LabelMsg.Text = "";
            if (wordsService.addKind(TextBox2.Text))
                LabelMsg.Text = "kind added";
            else
                LabelError.Text = "kind already exist";
        }
    }
    
}