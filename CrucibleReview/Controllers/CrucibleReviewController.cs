using CrucibleReview.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CrucibleReview.Controllers
{
    public class CrucibleReviewController : Controller
    {
        //
        // GET: /CrucibleReview/
        public ActionResult Index()
        {
            //for (int i = 1; i < 200; i++)
            //{
            //    string CrucibleId = "OnlifeDB-" + i;
            //    string url = "http://crucible.onlifehealth.com/rest-service/reviews-v1/" + CrucibleId + "/details";
            //    WebClient newWebClient = new WebClient();
            //    string APIResponse = string.Empty;
            //    try
            //    {
            //        APIResponse = newWebClient.DownloadString(url);
            //    }
            //    catch (Exception ex)
            //    {
            //        continue;
            //    }
            //    XmlDocument xDoc = new XmlDocument();
            //    xDoc.LoadXml(APIResponse);

            //    ReviewModel reviewModel = new ReviewModel();

            //    reviewModel.versionedLineCommentData = new List<VersionedLineCommentData>();
            //    if (xDoc.DocumentElement.LocalName.Equals("detailedReviewData"))
            //    {
            //        reviewModel.CrucibleID = xDoc.SelectNodes("detailedReviewData/permaId/id")[0].InnerText;
            //        reviewModel.JiraTicketID = xDoc.SelectSingleNode("detailedReviewData/jiraIssueKey") != null ? xDoc.SelectNodes("detailedReviewData/jiraIssueKey")[0].InnerText : string.Empty;
            //        reviewModel.ProjectKey = xDoc.SelectSingleNode("detailedReviewData/projectKey") != null ? xDoc.SelectNodes("detailedReviewData/projectKey")[0].InnerText : string.Empty;
            //        reviewModel.TicketName = xDoc.SelectSingleNode("detailedReviewData/name") != null ? xDoc.SelectNodes("detailedReviewData/name")[0].InnerText : string.Empty;
            //        reviewModel.UserName = xDoc.SelectNodes("detailedReviewData/author/userName")[0].InnerText;

            //        string xpath = "detailedReviewData/versionedComments/versionedLineCommentData";
            //        XmlNodeList comments = null;
            //        if (xDoc.SelectSingleNode("detailedReviewData/versionedComments/versionedLineCommentData") != null)
            //        {
            //            comments = xDoc.SelectNodes(xpath);
            //        }
            //        if (comments != null)
            //        {
            //            foreach (XmlNode xComment in comments)
            //            {
            //                VersionedLineCommentData reviewerComment = new VersionedLineCommentData();
            //                Replies replies = new Replies();
            //                reviewerComment.Message = "No Comment";
            //                reviewerComment.DefectRaised = "False";

            //                if (xComment.SelectSingleNode("message") != null)
            //                {
            //                    reviewerComment.Message = xComment.SelectNodes("message")[0].InnerText;
            //                    reviewerComment.DefectRaised = xComment.SelectNodes("defectRaised")[0].InnerText;
            //                    reviewerComment.ReviewerName = xComment.SelectNodes("user/displayName")[0].InnerText;
            //                }
            //                if (xComment.SelectSingleNode("replies/generalCommentData") != null)
            //                {
            //                    replies.Message = xComment.SelectNodes("replies/generalCommentData/message")[0].InnerText;
            //                }
            //                reviewerComment.Replies = replies;
            //                reviewModel.versionedLineCommentData.Add(reviewerComment);
            //            }
            //        }
            //        reviewModel.CreatedDate = Convert.ToDateTime(xDoc.SelectNodes("detailedReviewData/createDate")[0].InnerText);
            //        reviewModel.ClosedDate = Convert.ToDateTime(xDoc.SelectNodes("detailedReviewData/dueDate")[0].InnerText);

            //        CrucibleReviewEntities4 entities = new CrucibleReviewEntities4();
            //        foreach (var reviewerComments in reviewModel.versionedLineCommentData)
            //        {
            //            tbl_CrucibleReviewDetails crucibleReview = new tbl_CrucibleReviewDetails()
            //            {
            //                CrucibleID = reviewModel.CrucibleID,
            //                JiraTicketID = reviewModel.JiraTicketID,
            //                ProjectKey = reviewModel.ProjectKey,
            //                ReviewDescription = reviewModel.TicketName,
            //                CreatedUserName = reviewModel.UserName,
            //                ReviewersComment = reviewerComments.Message,
            //                IsDefectRaised = reviewerComments.DefectRaised,
            //                ReviewerName = reviewerComments.ReviewerName,
            //                DevelopersReplie = reviewerComments.Replies.Message,
            //                CrucibleCreatedDate = reviewModel.CreatedDate,
            //                CrucibleClosedDate = reviewModel.ClosedDate
            //            };
            //            entities.tbl_CrucibleReviewDetails.Add(crucibleReview);
            //        };

            //        if (reviewModel.versionedLineCommentData.Count <= 0)
            //        {
            //            tbl_CrucibleReviewDetails crucibleReview = new tbl_CrucibleReviewDetails()
            //            {
            //                CrucibleID = reviewModel.CrucibleID,
            //                JiraTicketID = reviewModel.JiraTicketID,
            //                ProjectKey = reviewModel.ProjectKey,
            //                ReviewDescription = reviewModel.TicketName,
            //                CreatedUserName = reviewModel.UserName,
            //                ReviewersComment = "No Reviewer Comments",
            //                IsDefectRaised = "False",
            //                ReviewerName = "No Reviewer",
            //                DevelopersReplie = "No Dev Replies",
            //                CrucibleCreatedDate = reviewModel.CreatedDate,
            //                CrucibleClosedDate = reviewModel.ClosedDate
            //            };
            //            entities.tbl_CrucibleReviewDetails.Add(crucibleReview);
            //        }
            //        try
            //        {
            //            entities.SaveChanges();
            //        }
            //        catch(DbEntityValidationException ex)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            return View();
        }
    }
}