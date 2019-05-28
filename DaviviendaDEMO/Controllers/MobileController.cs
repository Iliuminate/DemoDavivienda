using DaviviendaDEMO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DaviviendaDEMO.Controllers
{
    [AllowAnonymous]
    public class MobileController : ApiController
    {
        private EntidadPagoContext db = new EntidadPagoContext();

        [HttpPost]
        public IHttpActionResult Login(UsersModel obj)
        {


            return Ok(obj);
        }

        [HttpGet]
        public IHttpActionResult GetLisPedidos()
        {
            //List<Entidad_Pago> list = new List<Entidad_Pago>();
            //list.Add(new Entidad_Pago() { Empresa = "dsfadf", estado = true, id = "1", id_usuario = 2, Monto = 2323 });

            var list = db.Entidad_Pago.ToList();
            
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetLisPedidos(int idPedido)
        {
            List<Entidad_Pago> list = new List<Entidad_Pago>();

            list.Add(new Entidad_Pago() { Empresa = "dsfadf", estado = true, id = "1", id_usuario = 2, Monto = 2323 });

            return Ok(list);
        }

    }
}