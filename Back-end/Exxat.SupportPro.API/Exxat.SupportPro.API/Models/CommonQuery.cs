using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exxat.SupportPro.API.Models
{
    [Table("CommonQueries", Schema = "support")]
    public class CommonQuery
    {
        [Key]
        public int QueryId { get; set; }
        public string Description { get; set; }
        //public string InitialQuery { get; set; }
        [NotMapped]
        public List<string> InputParams { get; set; }
        [NotMapped]
        public List<Troubleshoot> Troubleshoot { get; set; }
        public string Context { get; set; }

        [ForeignKey("ModuleId")]
        public int ModuleId { get; set; }

    }
}
