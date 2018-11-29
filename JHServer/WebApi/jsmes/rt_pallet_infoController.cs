using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using JHServer.Models;

namespace JHServer.WebApi.jsmes
{
    public class rt_pallet_infoController : ApiController
    {
        private jsModel db = new jsModel();
        [Route("api/jsmes/UpdatePallet")]
        [HttpGet]
        public IHttpActionResult UpdatePallet(string palletno, string customlot)
        {
            try
            {
                using (var context = new jsModel())
                {
                    rt_pallet_info res = context.rt_pallet_info.SingleOrDefault(a => a.pallet_no == palletno);
                    if (res != null)
                    {
                        res.CustomLot = customlot;

                        context.Entry(res).State = EntityState.Modified;
                        //context.Entry(res).Property("jbox_spec").IsModified = false;
                        //context.Entry(res).Property("frame_spec").IsModified = false;
                        context.SaveChanges();
                        return Json(new { result = "success", msg = "" });
                    }
                }
            }

            catch (DbEntityValidationException dbEx)
            {
                var a= dbEx.EntityValidationErrors;
            }

            return Json(new { result = "fail", msg = "" });
        }

        // GET: api/rt_pallet_info
        public IQueryable<rt_pallet_info> Getrt_pallet_info()
        {
            return db.rt_pallet_info;
        }

        // GET: api/rt_pallet_info/5
        [ResponseType(typeof(rt_pallet_info))]
        public IHttpActionResult Getrt_pallet_info(string id)
        {
            rt_pallet_info rt_pallet_info = db.rt_pallet_info.Find(id);
            if (rt_pallet_info == null)
            {
                return NotFound();
            }

            return Ok(rt_pallet_info);
        }

        // PUT: api/rt_pallet_info/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putrt_pallet_info(string id, rt_pallet_info rt_pallet_info)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rt_pallet_info.pallet_no)
            {
                return BadRequest();
            }

            db.Entry(rt_pallet_info).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!rt_pallet_infoExists(id))
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

        // POST: api/rt_pallet_info
        [ResponseType(typeof(rt_pallet_info))]
        public IHttpActionResult Postrt_pallet_info(rt_pallet_info rt_pallet_info)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.rt_pallet_info.Add(rt_pallet_info);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (rt_pallet_infoExists(rt_pallet_info.pallet_no))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = rt_pallet_info.pallet_no }, rt_pallet_info);
        }

        // DELETE: api/rt_pallet_info/5
        [ResponseType(typeof(rt_pallet_info))]
        public IHttpActionResult Deletert_pallet_info(string id)
        {
            rt_pallet_info rt_pallet_info = db.rt_pallet_info.Find(id);
            if (rt_pallet_info == null)
            {
                return NotFound();
            }

            db.rt_pallet_info.Remove(rt_pallet_info);
            db.SaveChanges();

            return Ok(rt_pallet_info);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool rt_pallet_infoExists(string id)
        {
            return db.rt_pallet_info.Count(e => e.pallet_no == id) > 0;
        }
    }
}