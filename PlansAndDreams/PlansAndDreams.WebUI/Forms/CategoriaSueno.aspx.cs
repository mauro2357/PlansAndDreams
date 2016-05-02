using PlansAndDreams.Core.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlansAndDreams.WebUI.Forms
{
    public partial class CategoriaSueno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //stiven
        protected void grabar_Click(object sender, EventArgs e)
        {

            try
            {
                //CategoriaApplicationService suenoAppService = new CategoriaApplicationService();
                bool grabadoExito = true;//await suenoAppService.grabarCategoria(categoria.Value);
                if (grabadoExito)
                {
                    mensajeEnPantalla.Text = "Categoria grabada con exito.";
                }
                else
                {
                    mensajeEnPantalla.Text = "Hubo un error grabando";
                }
            }
            catch (Exception)
            {
                mensajeEnPantalla.Text = "Hubo un error grabando";
            }


        }

    }
}