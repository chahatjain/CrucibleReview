using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace CrucibleReview.Models
{
    public class VersionedLineCommentData
    {
        [XmlAttribute("defectRaised")]
        public string DefectRaised { get; set; }

        [XmlAttribute("message")]
        public string Message { get; set; }

        [XmlAttribute("displayName")]
        public string ReviewerName { get; set; }

        //Developer Replies
        public Replies Replies { get; set; }
    }
}