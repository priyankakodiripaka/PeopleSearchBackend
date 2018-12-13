using PeopleSearchBackend.DataRepository;
using PeopleSearchBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeopleSearchBackend.Controllers
{
    public class ValuesController : ApiController
    {
        private IPeopleRepository ipplRepo;
        public ValuesController()
        {
            ipplRepo = new PeopleRepository();
        }

        [HttpGet]
        [Route("api/values/getall")]
        public IHttpActionResult Get()
        {
            return Ok(ipplRepo.getAll());
        }

        [HttpGet]
        [Route("api/values/{username}")]
        public IHttpActionResult Get(string username)
        {
            return Ok(ipplRepo.getDetails(username));
        }

    }
}
