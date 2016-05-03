using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlansAndDreams.Core.repositories.DtoEntities;

namespace PlansAndDreams.WebUI.Forms
{
    public partial class VisualizarSuenosAmigos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Sueno> lstSuenosAmigos = new List<Sueno>();
                GrdListaSuenosAmigos.DataSource = lstSuenosAmigos;
                GrdListaSuenosAmigos.DataBind();
            }
        }
    }
}