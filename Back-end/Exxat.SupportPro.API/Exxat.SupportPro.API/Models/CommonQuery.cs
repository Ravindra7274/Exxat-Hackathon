using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exxat.SupportPro.API.Models
{
    [Table("CommonQueries", Schema = "support")]
    public class CommonQuery
    {
        public int CommonQueryId { get; set; }
        public string QueryName { get; set; }
        List<Troubleshoot> TroubleShoots { get; set; }
        public string InitialQuery { get; set; }

        [ForeignKey("ModuleId")]
        public int ModuleId { get; set; }

    }
}
