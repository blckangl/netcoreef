using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace completed1
{
    [Table("strings")]
    public class StringItem
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] [Column("Id")] [Required]
        public long Id { get; set; }
        
        [Column("name")]
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

    }
}