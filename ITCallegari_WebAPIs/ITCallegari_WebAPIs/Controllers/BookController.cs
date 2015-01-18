using ITCallegari_WebAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITCallegari_WebAPIs.Controllers
{
    public class BookController : ApiController
    {
       

        static List<BookModels> DB = null;
        public BookController()
        {
            if (DB == null)
            {
                DB = new List<BookModels>();
                DB.Add(new BookModels() { Id = 1, Autor = "John Robertson", Edition = "3rd Edition", Editor = "Chris Harris", Genre = "History", Name = "The Civil War", Pages = 364 });
                DB.Add(new BookModels() { Id = 2, Autor = "Sara White", Edition = "2nd Edition", Editor = "Luka Black", Genre = "None-Fiction", Name = "How to train cats", Pages = 700 });
                DB.Add(new BookModels() { Id = 3, Autor = "David Brown", Edition = "5th Edition", Editor = "Saul Pikman", Genre = "Self Help", Name = "Finding Happines", Pages = 623 });
            }
        }


        // GET api/complexobject
        public IEnumerable<BookModels> Get()
        {
            return DB;
            //return new ComplexObject[] { new ComplexObject(), new ComplexObject() };
        }

        // GET api/complexobject/5

        public BookModels Get(int number)
        {

            return DB.Where(o => o.Id == number).FirstOrDefault();

            //return WebApiApplication.myglobalvalue; 
        }

        // POST api/complexobject
        public void Post([FromBody]BookModels value)
        {
            DB.Add(value);

            // myglobalvalue = value;
        }

        // PUT api/complexobject/5
        public void Put(BookModels value)
        {
            var existingObject = DB.Where(o => o.Id == value.Id).FirstOrDefault();
            existingObject = value;

            //WebApiApplication.myglobalvalue = value;
        }

        // DELETE api/complexobject/5
        public void Delete(int id)
        {
            // myglobalvalue = value;
        }


    }
}
