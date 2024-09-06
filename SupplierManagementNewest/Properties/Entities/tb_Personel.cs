using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplierManagementNewest.Entities
{
    [Table("tb_Personel")]
    public class tb_Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string Name { get; set; }
        public string SurName {  get; set; }
        public string Address { get; set; }

    }
}
