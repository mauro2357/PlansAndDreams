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
                //int grabadoExito = suenoAppService.grabarCategoria(categoria.Value);

                int grabadoExito = 0;
                if (categoria.Value == "Viajes")
                {
                    grabadoExito = 1;
                }
                if (categoria.Value == "Juguetes")
                {
                    grabadoExito = 2;
                }
                if (grabadoExito == 1)
                {
                    mensajeEnPantalla.Text = "Categoria grabada con exito.";
                }
                else if ((grabadoExito == 2))
                {
                    mensajeEnPantalla.Text = "La categoria ya existe.";
                }
                else if ((grabadoExito == 0))
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