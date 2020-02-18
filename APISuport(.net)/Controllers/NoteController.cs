using APISupport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APISupport.Controllers
{
    public class NoteController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            IList<NoteModel> notes = null;

            using (var context = new Entities())
            {
                notes = context.Notes
                    .Select(noteItem => new NoteModel()
                    {
                        Id = noteItem.Id,
                        Dscription = noteItem.Dscription,
                        NoteTimestamp = noteItem.NoteTimestamp

                    }).ToList<NoteModel>();
            }
            //to do : transform this snippet into a single return
            if (notes.Count == 0)
            {
                return NotFound();
            }
            return Ok("f");
        }
        public IHttpActionResult GetById(int id)
        {
            NoteModel note = null;

            using (var context = new Entities())
            {
                note = context.Notes
                    .Where(NoteItem => NoteItem.Id == id)
                    .Select(NoteItem => new NoteModel()
                    {
                        Id = NoteItem.Id,
                        Dscription = NoteItem.Dscription,
                        NoteTimestamp = NoteItem.NoteTimestamp

                    }).FirstOrDefault<NoteModel>();
            }
            //to do : transform this snippet into a single return
            if (note == null)
            {
                return NotFound();
            }
            return Ok(note);
        }

        public IHttpActionResult Post(IssueModel issue)
        {

            using (var context = new Entities())
            {
                context.Issue1
                    .Add(new Issue1()
                    {
                        id = issue.id,
                        ReportNumber = issue.ReportNumber,
                        Status = issue.Status,
                        RaportTimestamp = issue.RaportTimestamp,
                    });
                context.SaveChanges();

            }
            return Ok();
        }
    }
}

