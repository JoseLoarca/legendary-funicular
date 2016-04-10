using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApi2014224.Models;

namespace WebApi2014224.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class TelefonoController : ApiController
    {
        private DB_TELEFONO db = new DB_TELEFONO();

        // GET: api/Telefono
        public IQueryable<Telefono> Gettelefono()
        {
            return db.telefono;
        }

        // GET: api/Telefono/5
        [ResponseType(typeof(Telefono))]
        public IHttpActionResult GetTelefono(int id)
        {
            Telefono telefono = db.telefono.Find(id);
            if (telefono == null)
            {
                return NotFound();
            }

            return Ok(telefono);
        }

        // PUT: api/Telefono/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTelefono(int id, Telefono telefono)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != telefono.idTelefono)
            {
                return BadRequest();
            }

            db.Entry(telefono).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelefonoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Telefono
        [ResponseType(typeof(Telefono))]
        public IHttpActionResult PostTelefono(Telefono telefono)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.telefono.Add(telefono);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = telefono.idTelefono }, telefono);
        }

        // DELETE: api/Telefono/5
        [ResponseType(typeof(Telefono))]
        public IHttpActionResult DeleteTelefono(int id)
        {
            Telefono telefono = db.telefono.Find(id);
            if (telefono == null)
            {
                return NotFound();
            }

            db.telefono.Remove(telefono);
            db.SaveChanges();

            return Ok(telefono);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TelefonoExists(int id)
        {
            return db.telefono.Count(e => e.idTelefono == id) > 0;
        }
    }
}