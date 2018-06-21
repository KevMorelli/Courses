using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class New
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public virtual User CreatedBy { get; set; }

        public virtual User EditedBy { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? EditionDate { get; set; }

    }
}
