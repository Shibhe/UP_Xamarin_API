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
    public class SubjectsController : ApiController
    {
        private UP_XamarinContext db = new UP_XamarinContext();

        // GET: api/Subjects
        public IQueryable<Subjects> GetSubjects()
        {
            return db.Subjects;
        }

        // GET: api/Subjects/5
        [ResponseType(typeof(Subjects))]
        public IHttpActionResult GetSubjects(int id)
        {
            Subjects subjects = db.Subjects.Find(id);
            if (subjects == null)
            {
                return NotFound();
            }

            return Ok(subjects);
        }

        // PUT: api/Subjects/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSubjects(int id, Subjects subjects)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != subjects.Id)
            {
                return BadRequest();
            }

            db.Entry(subjects).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectsExists(id))
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

        // POST: api/Subjects
        [ResponseType(typeof(Subjects))]
        public IHttpActionResult PostSubjects(Subjects subjects)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Subjects.Add(subjects);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = subjects.Id }, subjects);
        }

        // DELETE: api/Subjects/5
        [ResponseType(typeof(Subjects))]
        public IHttpActionResult DeleteSubjects(int id)
        {
            Subjects subjects = db.Subjects.Find(id);
            if (subjects == null)
            {
                return NotFound();
            }

            db.Subjects.Remove(subjects);
            db.SaveChanges();

            return Ok(subjects);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SubjectsExists(int id)
        {
            return db.Subjects.Count(e => e.Id == id) > 0;
        }
    }
}