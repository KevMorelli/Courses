using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos
{
    public class NewDto
    {
        public int NewID { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public virtual User CreatedBy { get; set; }

        public virtual User EditedBy { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? EditionDate { get; set; }
    }
}
