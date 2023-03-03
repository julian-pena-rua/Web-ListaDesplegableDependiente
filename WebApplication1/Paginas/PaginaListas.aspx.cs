using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Paginas
{
    public partial class PaginaListas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //cuente los items que hay en ddlautmotor

            if (ddlAutomotor.Items.Count <= 0)
            {
                // agregar un item en el combo.
                ddlAutomotor.Items.Add("Seleccionar el tipo de vehiculo");
                ddlAutomotor.Items.Add("Sedan");
                ddlAutomotor.Items.Add("Campero");
                ddlAutomotor.Items.Add("tractomula");


            }

           
           

        }

        protected void ddlAutomotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // entrega el index seleccionado.
            int auto = ddlAutomotor.SelectedIndex;
            // LIMPIAMOS TODOS LOS ITEMS.
            ddlMarca.Items.Clear();
            ddlModelo.Items.Clear();


            if (auto == 1)  // == sirve para comparar

            {
                ddlMarca.Items.Add("Seleccionar marca.");
                ddlMarca.Items.Add("Mazda");
                ddlMarca.Items.Add("Renault");
                ddlMarca.Items.Add("Chevrolet");

                ddlModelo.Items.Clear();
                ddlModelo.Items.Add("2012");
                ddlModelo.Items.Add("2011");

            }

                else if ( auto ==2)
                {
                 ddlMarca.Items.Add("Seleccionar marca.");
                ddlMarca.Items.Add("Tropér");
                ddlMarca.Items.Add("Chevrolet");
                ddlMarca.Items.Add("Toyota");
                ddlModelo.Items.Clear();
                ddlModelo.Items.Add("2001");
                ddlModelo.Items.Add("1999");

                }

                else if ( auto ==3)
                {
                 ddlMarca.Items.Add("Seleccionar marca.");
                ddlMarca.Items.Add("Mercedez");
                ddlMarca.Items.Add("Kentwort");
                ddlMarca.Items.Add("KODIAK");
                ddlModelo.Items.Clear();
                ddlModelo.Items.Add("2003");
                ddlModelo.Items.Add("2002");

                }

            


            }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ddlModelo.Items.Clear();
            ddlMarca.Items.Clear();
            // Limpiar la seleccion.
            ddlAutomotor.ClearSelection();
        }

        protected void ddlModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            // REGISTRAR EL AUTO EN EL CONTROL LISTBOX

            if (ddlAutomotor.SelectedIndex > 0 && ddlMarca.SelectedIndex > 0)

            {
                string automotor = ddlAutomotor.SelectedItem.Text;
                string marca = ddlMarca.SelectedItem.Text;
                string modelo = ddlModelo.SelectedItem.Text;

                string Registro = automotor + " * " + marca + " * " + modelo;
                LsbRegistro.Items.Add(Registro);

            }
        }


        }
    }
