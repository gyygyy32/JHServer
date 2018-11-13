using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using JHServer.Models;

namespace JHServer.WebApi
{
    public class tiqclogsController : ApiController
    {
        private Model3 db = new Model3();

        // GET: api/tiqclogs
        public IQueryable<tiqclog> Gettiqclog()
        {
            return db.tiqclog;
        }

        // GET: api/tiqclogs/5
        [ResponseType(typeof(tiqclog))]
        public IHttpActionResult Gettiqclog(long id)
        {
            tiqclog tiqclog = db.tiqclog.Find(id);
            if (tiqclog == null)
            {
                return NotFound();
            }

            return Ok(tiqclog);
        }

        // PUT: api/tiqclogs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttiqclog(long id, tiqclog tiqclog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tiqclog.id)
            {
                return BadRequest();
            }

            db.Entry(tiqclog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tiqclogExists(id))
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

        // POST: api/tiqclogs
        [ResponseType(typeof(tiqclog))]
        public IHttpActionResult Posttiqclog(tiqclog tiqclog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tiqclog.Add(tiqclog);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tiqclog.id }, tiqclog);
        }

        // DELETE: api/tiqclogs/5
        [ResponseType(typeof(tiqclog))]
        public IHttpActionResult Deletetiqclog(long id)
        {
            tiqclog tiqclog = db.tiqclog.Find(id);
            if (tiqclog == null)
            {
                return NotFound();
            }

            db.tiqclog.Remove(tiqclog);
            db.SaveChanges();

            return Ok(tiqclog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tiqclogExists(long id)
        {
            return db.tiqclog.Count(e => e.id == id) > 0;
        }
    }
}