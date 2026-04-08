using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreManagement_CodeFirst.Models
{
    public class Field
    {
        [Key]
        public int FieldId { get; set; }

        [Required]
        [StringLength(100)]
        public string FieldName { get; set; } // Ví dụ: Sân số 1, Sân A1

        public decimal PricePerHour { get; set; }

        public bool IsActive { get; set; }

        // Khóa ngoại liên kết tới FieldType
        public int FieldTypeId { get; set; }

        [ForeignKey("FieldTypeId")]
        public virtual FieldType FieldType { get; set; }
    }
}