using System;

namespace MyTMS.Domain.Entities
{
    public class Partner
    {
        public long ID { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
