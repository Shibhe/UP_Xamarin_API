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
using UP_Xamarin_API.Models;

namespace UP_Xamarin_API.Controllers
{
    public class ApplicantController : ApiController
    {
        private UP_XamarinContext db = new UP_XamarinContext();

        // GET: api/Applicant
        public IQueryable<Apply> GetApplies()
        {
            return db.Applies;
        }

        // GET: api/Applicant/5
        [ResponseType(typeof(Apply))]
        public IHttpActionResult GetApply(int id)
        {
            Apply apply = db.Applies.Find(id);
            if (apply == null)
            {
                return NotFound();
            }

            return Ok(apply);
        }

        // PUT: api/Applicant/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutApply(int id, Apply apply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != apply.AppID)
            {
                return BadRequest();
            }

            db.Entry(apply).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplyExists(id))
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

        // POST: api/Applicant
        [ResponseType(typeof(Apply))]
        public IHttpActionResult PostApply(Apply apply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Applies.Add(apply);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = apply.AppID }, apply);
        }

        // DELETE: api/Applicant/5
        [ResponseType(typeof(Apply))]
        public IHttpActionResult DeleteApply(int id)
        {
            Apply apply = db.Applies.Find(id);
            if (apply == null)
            {
                return NotFound();
            }

            db.Applies.Remove(apply);
            db.SaveChanges();

            return Ok(apply);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ApplyExists(int id)
        {
            return db.Applies.Count(e => e.AppID == id) > 0;
        }
    }
}