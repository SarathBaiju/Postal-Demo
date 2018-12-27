using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostalEg.Models
{
    public class MailParameter
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
    }
}