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
    public class tparaconfigsController : ApiController
    {
        private DBModel1 db = new DBModel1();

        [ActionName("QueryDDL")]
        [HttpGet]
        public IHttpActionResult QueryDDL(string paratype)
        {
            using (var context = new DBModel1())
            {
                var res = context.tparaconfigs.Where(a => a.paratype == paratype).Select(a => new { a.paraid,a.paraname}).ToList();//.ToList<tparaconfig>();
                return Json(res);
            }
            
        }

        // GET: api/tparaconfigs
        public IQueryable<tparaconfig> aGettparaconfigs()
        {
            return db.tparaconfigs;
        }

        // GET: api/tparaconfigs/5
        [ResponseType(typeof(tparaconfig))]
        public IHttpActionResult aGettparaconfig(string id)
        {
            tparaconfig tparaconfig = db.tparaconfigs.Find(id);
            if (tparaconfig == null)
            {
                return NotFound();
            }

            return Ok(tparaconfig);
        }

        // PUT: api/tparaconfigs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult aPuttparaconfig(string id, tparaconfig tparaconfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tparaconfig.paratype)
            {
                return BadRequest();
            }

            db.Entry(tparaconfig).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tparaconfigExists(id))
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

        //POST: api/tparaconfigs
       [ResponseType(typeof(tparaconfig))]
        public IHttpActionResult aPosttparaconfig(tparaconfig tparaconfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tparaconfigs.Add(tparaconfig);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tparaconfigExists(tparaconfig.paratype))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tparaconfig.paratype }, tparaconfig);
        }

        // DELETE: api/tparaconfigs/5
        [ResponseType(typeof(tparaconfig))]
        public IHttpActionResult Deletetparaconfig(string id)
        {
            tparaconfig tparaconfig = db.tparaconfigs.Find(id);
            if (tparaconfig == null)
            {
                return NotFound();
            }

            db.tparaconfigs.Remove(tparaconfig);
            db.SaveChanges();

            return Ok(tparaconfig);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tparaconfigExists(string id)
        {
            return db.tparaconfigs.Count(e => e.paratype == id) > 0;
        }
    }
}