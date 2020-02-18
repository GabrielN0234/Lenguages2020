using APISupport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APISupport.Controllers
{
    public class SupervisorController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            IList<SupervisorModel> supervisors = null;

            using (var context = new Entities())
            {
                supervisors = context.Supervisor
                    .Select(supervisorItem => new SupervisorModel()
                    {
                        Id = supervisorItem.Id,
                        Name = supervisorItem.Name,
                        password = supervisorItem.password,
                        FirstSurname = supervisorItem.FirstSurname,
                        Email = supervisorItem.Email

                    }).ToList<SupervisorModel>();
            }
            //to do : transform this snippet into a single return
            if (supervisors.Count == 0)
            {
                return NotFound();
            }
            return Ok(supervisors);
        }
        public IHttpActionResult GetById(int id)
        {
            SupervisorModel supervisor = null;

            using (var context = new Entities())
            {
                supervisor = context.Supervisor
                    .Where(supervisorItem => supervisorItem.Id == id)
                    .Select(supporterItem => new SupervisorModel()
                    {
                        Id = supporterItem.Id,
                        Name = supporterItem.Name,
                        password = supporterItem.password,
                        FirstSurname = supporterItem.FirstSurname,
                        Email = supporterItem.Email

                    }).FirstOrDefault<SupervisorModel>();
            }
            //to do : transform this snippet into a single return
            if (supervisor == null)
            {
                return NotFound();
            }
            return Ok(supervisor);
        }

        public IHttpActionResult Post(SupervisorModel supervisor)
        {

            using (var context = new Entities())
            {
                context.Supporter
                    .Add(new Supporter()
                    {
                        Id = supervisor.Id,
                        Name = supervisor.Name,
                        password = supervisor.password,
                        FirstSurname = supervisor.FirstSurname,
                        Email = supervisor.Email
                    });
                context.SaveChanges();

            }
            return Ok();
        }
    }
}
