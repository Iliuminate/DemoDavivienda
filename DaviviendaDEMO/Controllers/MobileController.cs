using DaviviendaDEMO.Models;
using System.Collections.Generic;
using System.Data.Entity;
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
        public IHttpActionResult GetItem(string id)
        {
            Entidad_Pago entidad_Pago = db.Entidad_Pago.Find(id);

            return Ok(entidad_Pago);
        }


        //"id,Empresa,Monto,id_usuario,estado"
        [HttpPost]
        public IHttpActionResult Add(Entidad_Pago obj)
        {
            var entidad_Pago = db.Entidad_Pago.Find(obj.id);

            if (entidad_Pago != null) {

                return Ok("Exist");
            }


            if (ModelState.IsValid)
            {
                db.Entidad_Pago.Add(obj);
                db.SaveChanges();                
            }

            return Ok("Ok");
        }

        
        [HttpGet]
        public IHttpActionResult delete(string id)
        {
            Entidad_Pago entidad_Pago = db.Entidad_Pago.Find(id);
            if (entidad_Pago == null)
            {
                return Ok("Bad");
            }

            return Ok("Ok");
        }


        //"id,Empresa,Monto,id_usuario,estado"
        [HttpPost]
        public IHttpActionResult Edit(Entidad_Pago obj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Ok(obj);
        }

              
    }
}
