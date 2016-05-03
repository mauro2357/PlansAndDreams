using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlansAndDreams.WebUI.Forms
{
    public partial class VisualizarSuenosSonador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var lst = new List<string>();
            lst.Add("aaaaaa");
            lst.Add("bbbbbbbb");
            gridSuenos.DataSource = lst;
            gridSuenos.DataBind();
        }
    }
}