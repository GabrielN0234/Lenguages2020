using APISupport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APISupport.Controllers
{
    public class SupporterController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            IList<SupporterModel> supporters = null;

            using (var context = new Entities())
            {
                supporters = context.Supporter
                    .Select(supporterItem => new SupporterModel()
                    {
                        Id = supporterItem.Id,
                        Name = supporterItem.Name,
                        password = supporterItem.password,
                        FirstSurname = supporterItem.FirstSurname,
                        SecondSurname = supporterItem.SecondSurname,
                        Email = supporterItem.Email

                    }).ToList<SupporterModel>();
            }
            //to do : transform this snippet into a single return
            if (supporters.Count == 0)
            {
                return NotFound();
            }
            return Ok(supporters);
        }
        public IHttpActionResult GetById(int id)
        {
            SupporterModel supporter = null;

            using (var context = new Entities())
            {
                supporter = context.Supporter
                    .Where(supporterItem => supporterItem.Id == id)
                    .Select(supporterItem => new SupporterModel()
                    {
                        Id = supporterItem.Id,
                        Name = supporterItem.Name,
                        password = supporterItem.password,
                        FirstSurname = supporterItem.FirstSurname,
                        SecondSurname = supporterItem.SecondSurname,
                        Email = supporterItem.Email

                    }).FirstOrDefault<SupporterModel>();
            }
            //to do : transform this snippet into a single return
            if (supporter == null)
            {
                return NotFound();
            }
            return Ok(supporter);
        }

        public IHttpActionResult Post(SupporterModel suporter)
        {

            using (var context = new Entities())
            {
                context.Supporter
                    .Add(new Supporter()
                    {
                        Id = suporter.Id,
                        Name = suporter.Name,
                        password = suporter.password,
                        FirstSurname = suporter.FirstSurname,
                        SecondSurname = suporter.SecondSurname,
                        Email = suporter.Email
                    });
                context.SaveChanges();

            }
            return Ok();
        }
    }
}
