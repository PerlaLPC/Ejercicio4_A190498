using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculadoraAreaWS
{
    /// <summary>
    /// Descripción breve de CalculadoraAreaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculadoraAreaWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal Área_Cuadrado(decimal Lado)
        {
            CalcularArea c = new CalcularArea();
            return c.Areacuadrado(Lado);
        }
        [WebMethod]
        public decimal Área_Triángulo(decimal Base, decimal Altura)
        {
            CalcularArea c = new CalcularArea();
            return c.Areatriangulo(Base,Altura);
        }
        [WebMethod]
        public double Área_Círculo(double Radio)
        {
            CalcularArea c = new CalcularArea();
            return c.Areacirculo(Radio);
        }
    }
}
