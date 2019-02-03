using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exxat.SupportPro.API.Models
{
    [Table("Module", Schema = "support")]
    public class Module
    {
        public int ModuleId { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public List<CommonQuery> CommonQueries { get; set; }
    }
}
