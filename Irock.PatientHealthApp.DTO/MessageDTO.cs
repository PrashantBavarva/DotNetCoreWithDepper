using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irock.PatientHealthApp.DTO
{
    public class MessageDTO
    {
        public Guid MessageId { get; set; }
        public Guid RecipientId { get; set; }
        public Guid SenderId { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageTime { get; set; }
        public DateTime MessageDate { get; set; }
        public string Status { get; set; }
    }
}
