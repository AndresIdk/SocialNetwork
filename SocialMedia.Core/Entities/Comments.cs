using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Entities
{
    public class Comments
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
