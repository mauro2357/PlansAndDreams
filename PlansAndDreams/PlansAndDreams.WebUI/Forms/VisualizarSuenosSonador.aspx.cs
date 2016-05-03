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
            //List<Sueno> lstSuenos = new List<Sueno>();
            //gridSuenos.DataSource = lstSuenos;
            //gridSuenos.DataBind();

            var lst = new List<string>();
            lst.Add("Viajar a europa");
            lst.Add("Viajar a africa");
            gridSuenos.DataSource = lst;
            gridSuenos.DataBind();

        }
    }
}