using PlansAndDreams.Core.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlansAndDreams.WebUI.Forms
{
    public partial class CrearSueno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grabar2_Click(object sender, EventArgs e)
        {
            mensajeEnPantalla.Text = "Sueno grabado con exito.";
        }
    }
}