using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SimplilearnWebService
{
    /// <summary>
    /// Description résumée de SimplilearnWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class SimplilearnWebService : System.Web.Services.WebService
    {

        [WebMethod(MessageName ="Addition de deux nombres")]
        public int Sum(int x, int y)
        {
            return x+y;
        }

        [WebMethod(MessageName = "Difference de deux nombres")]
        public int Difference(int x, int y)
        {
            return x - y;
        }

        [WebMethod(MessageName = "Produit de deux nombres")]
        public int Produit(int x, int y)
        {
            return x * y;
        }

        [WebMethod(MessageName = "Division de deux nombres")]
        public int Division(int x, int y)
        {
            return x % y;
        }
    }
}
