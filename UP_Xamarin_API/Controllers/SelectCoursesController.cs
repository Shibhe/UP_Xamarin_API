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
    public class SelectCoursesController : ApiController
    {
        private UP_XamarinContext db = new UP_XamarinContext();
        private StudentLogin login = new StudentLogin();
        // GET: api/SelectCourses
        public IQueryable<SelectCourse> GetSelectCourses()
        {
            return db.SelectCourses;
        }

        // GET: api/SelectCourses/5
        [ResponseType(typeof(SelectCourse))]
        public IHttpActionResult GetSelectCourse(string id)
        {
            SelectCourse selectCourse = db.SelectCourses.Find(id);
            if (selectCourse == null)
            {
                return NotFound();
            }

            return Ok(selectCourse);
        }

        // PUT: api/SelectCourses/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSelectCourse(string id, SelectCourse selectCourse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != selectCourse.code.ToString())
            {
                return BadRequest();
            }

            db.Entry(selectCourse).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SelectCourseExists(id))
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

        // POST: api/SelectCourses
        [ResponseType(typeof(SelectCourse))]
        public IHttpActionResult PostSelectCourse(SelectCourse selectCourse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SelectCourses.Add(selectCourse);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = selectCourse.Id }, selectCourse);
        }

        // DELETE: api/SelectCourses/5
        [ResponseType(typeof(SelectCourse))]
        public IHttpActionResult DeleteSelectCourse(int id)
        {
            SelectCourse selectCourse = db.SelectCourses.Find(id);
            if (selectCourse == null)
            {
                return NotFound();
            }

            db.SelectCourses.Remove(selectCourse);
            db.SaveChanges();

            return Ok(selectCourse);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SelectCourseExists(string id)
        {
            return db.SelectCourses.Count(e => e.Id == id) > 0;
        }
    }
}