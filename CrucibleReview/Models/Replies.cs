using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace CrucibleReview.Models
{
    public class Replies
    {
        [XmlAttribute("defectRaised")]
        public string DefectRaised { get; set; }

        [XmlAttribute("message")]
        public string Message { get; set; }
    }
}