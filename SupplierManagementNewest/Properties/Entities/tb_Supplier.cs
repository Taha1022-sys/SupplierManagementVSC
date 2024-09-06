using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplierManagementNewest.Entities
{
    [Table("tb_Supplier")]
    public class tb_Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
