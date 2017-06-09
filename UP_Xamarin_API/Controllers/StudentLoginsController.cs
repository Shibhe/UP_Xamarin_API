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
    public class StudentLoginsController : ApiController
    {
        private UP_XamarinContext db = new UP_XamarinContext();

        // GET: api/StudentLogins
        public IQueryable<StudentLogin> GetStudentLogins()
        {
            return db.StudentLogins;
        }

        // GET: api/StudentLogins/5
        [ResponseType(typeof(StudentLogin))]
        public IHttpActionResult GetStudentLogin(int id)
        {
            StudentLogin studentLogin = db.StudentLogins.Find(id);
            if (studentLogin == null)
            {
                return NotFound();
            }

            return Ok(studentLogin);
        }

        Random rand = new Random();
        // PUT: api/StudentLogins/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudentLogin(int id, StudentLogin studentLogin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != studentLogin.Id)
            {
                return BadRequest();
            }

            db.Entry(studentLogin).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentLoginExists(id))
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

        // POST: api/StudentLogins

        [ResponseType(typeof(StudentLogin))]
        public IHttpActionResult PostStudentLogin(StudentLogin studentLogin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int password = rand.Next(100000000, 99999999);
            db.StudentLogins.Add(
                //It randomly generate student number and Password for every student
            studentLogin = new StudentLogin
            {
                Username = DateTime.Now.Year + rand.Next(10000, 99999).ToString(),
                Password = password.ToString()
        });

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (StudentLoginExists(studentLogin.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = studentLogin.Username }, studentLogin);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentLoginExists(int id)
        {
            return db.StudentLogins.Count(e => e.Id == id) > 0;
        }
    }
}