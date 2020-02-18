using APISupport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APISupport.Controllers
{
    public class IssueController : ApiController
    {

        public IHttpActionResult GetAll()
        {
            IList<IssueModel> issues = null;

            using (var context = new Entities())
            {
                issues = context.Issue1
                    .Select(IssueItem => new IssueModel()
                    {
                        id = IssueItem.id,
                        ReportNumber = IssueItem.ReportNumber,
                        Status = IssueItem.Status,
                        RaportTimestamp = IssueItem.RaportTimestamp,
                        ResolutionComment = IssueItem.ResolutionComment,
                        SupervisorId = IssueItem.SupervisorId

                    }).ToList<IssueModel>();
            }
            //to do : transform this snippet into a single return
            if (issues.Count == 0)
            {
                return NotFound();
            }
            return Ok(issues);
        }
        public IHttpActionResult GetById(int id)
        {
            IssueModel issue = null;

            using (var context = new Entities())
            {
                issue = context.Issue1
                    .Where(issueItem => issueItem.id == id)
                    .Select(issueItem => new IssueModel()
                    {
                        id = issueItem.id,
                        ReportNumber = issueItem.ReportNumber,
                        Status = issueItem.Status,
                        RaportTimestamp = issueItem.RaportTimestamp,
                        ResolutionComment = issueItem.ResolutionComment,
                        SupervisorId = issueItem.SupervisorId

                    }).FirstOrDefault<IssueModel>();
            }
            //to do : transform this snippet into a single return
            if (issue == null)
            {
                return NotFound();
            }
            return Ok(issue);
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
                        ResolutionComment = issue.ResolutionComment,
                        SupervisorId = issue.SupervisorId,
                    });
                context.SaveChanges();

            }
            return Ok();
        }
    }
}

