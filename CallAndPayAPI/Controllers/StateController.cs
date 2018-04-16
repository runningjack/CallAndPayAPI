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
    public class StateController : ApiController
    {
        private StatesRepository _stateRepository;
        public StateController()
        {
            _stateRepository = new StatesRepository();
        }
        [AcceptVerbs("GET")]
        [Route("api/States")]
        [ResponseType(typeof(State))]
        public IHttpActionResult GetStates()
        {
            var states = _stateRepository.ListStates();
            return Ok(states.ToList());
        }

        // GET: api/States/5
        [AcceptVerbs("GET")]
        [Route("api/State/GetState/{id}")]
        [ResponseType(typeof(State))]
        public async Task<IHttpActionResult> GetState(int id)
        {
            State State = _stateRepository.FindById(id);
            if (State == null)
            {
                return NotFound();
            }

            return Ok(State);
        }

        // PUT: api/States/5
        [AcceptVerbs("POST")]
        [Route("api/States/UpdateState/")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateState(State State)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var i = _stateRepository.Update(State);
            if (i > 0)
            {
                return Json(new { Msg = "1" });
            }
            //return StatusCode(HttpStatusCode.NoContent);
            return Json(new { Msg = "0" });
        }

        // POST: api/States
        [AcceptVerbs("POST")]
        [Route("api/States/PostState/")]
        [ResponseType(typeof(State))]
        public async Task<IHttpActionResult> PostState(State State)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var i = _stateRepository.Create(State);
            if (i > 0)
            {
                //return CreatedAtRoute("DefaultApi", new { id = State.Id }, State);
                return Json(new { Msg = "1" });
            }
            //return null;
            return Json(new { Msg = "0" });
        }

        // DELETE: api/States/5
        [AcceptVerbs("DELETE")]
        [Route("api/States/DeleteState/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteState(int id)
        {
            State State = _stateRepository.FindById(id);
            if (State == null)
            {
                return NotFound();
            }
            var i = _stateRepository.Delete(State);
            //return Ok(State);
            if (i > 0)
            {
                return Json(new { Msg = "1" });
            }
            return Json(new { Msg = "0" });
        }



        private bool StateExists(int id)
        {
            State state = _stateRepository.FindById(id);
            if (state != null)
            {
                return true;
            }
            return false;
        }
    }
}
