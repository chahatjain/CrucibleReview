using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace CrucibleReview.Models
{
    public class ReviewModel
    {
        [XmlAttribute("displayName")]
        public string DisplayName { get; set; }

        [XmlAttribute("userName")]
        public string UserName { get; set; }

        [XmlAttribute("createDate")]
        public DateTime CreatedDate { get; set; }

        [XmlAttribute("closeDate")]
        public DateTime ClosedDate { get; set; }

        [XmlAttribute("jiraIssueKey")]
        public string JiraTicketID { get; set; }

        //Description of the ticket
        [XmlAttribute("name")]
        public string TicketName { get; set; }

        //Crucible id
        [XmlAttribute("id")]
        public string CrucibleID { get; set; }

        [XmlAttribute("projectKey")]
        public string ProjectKey { get; set; }

        //Reviewer Comments
        [XmlAttribute("versionedLineCommentData")]
        public List<VersionedLineCommentData> versionedLineCommentData { get; set; }
    }
}