using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace CallAndPayAPI.Controllers
{
    public class CustomersController : ApiController
    {
        private CustomerRepository _customerRepository;

        public CustomersController()
        {
            _customerRepository = new CustomerRepository();
        }

        // GET: api/Customers
        [AcceptVerbs("GET")]
        [Route("api/Customers")]
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetCustomers()
        {
            var cutomers = _customerRepository.ListCustomers();
            return Ok(cutomers.ToList());
        }

        // GET: api/Customers/5
        [AcceptVerbs("GET")]
        [Route("api/Customers/GetCustomer/{id}")]
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> GetCustomer(int id)
        {
            Customer customer = _customerRepository.FindById(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customers/5
        [AcceptVerbs("POST")]
        [Route("api/Customers/UpdateCustomer/")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateCustomer(Customer customer)
        {
            //return Ok(customer);
            if (!ModelState.IsValid)
            {
               // return Json(new { Msg = "Record could not be created Internal Server Error " });
                return BadRequest(ModelState);
            }
            var i = _customerRepository.Update(customer);
            if (i > 0)
            {
                return Json(new { Msg = "1" });
            }
            //return StatusCode(HttpStatusCode.NoContent);
            return Json(new { Msg = "0" });
        }

        // POST: api/Customers
        [AcceptVerbs("POST")]
        [Route("api/Customers/PostCustomer/")]
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> PostCustomer(Customer customer)
        {
            //return Ok(customer.ToList());
            return Json(new { Msg = "0" });
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var i = _customerRepository.Create(customer);
            if (i > 0)
            {
                //return CreatedAtRoute("DefaultApi", new { id = customer.Id }, customer);
                return Json(new { Msg = "1" });
            }
            //return null;
            return Json(new { Msg = "0" });
        }

        // DELETE: api/Customers/5
        [AcceptVerbs("DELETE")]
        [Route("api/Customers/DeleteCustomer/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteCustomer(int id)
        {
            Customer customer = _customerRepository.FindById(id);
            if (customer == null)
            {
                return NotFound();
            }
            var i = _customerRepository.Delete(customer);
            //return Ok(customer);
            if (i > 0)
            {
                return Json(new { Msg = "1" });
            }
            return Json(new { Msg = "0" });
        }
        private bool CustomerExists(int id)
        {
            Customer cust = _customerRepository.FindById(id);
            if (cust != null)
            {
                return true;
            }
            return false;
        }
    }
}
