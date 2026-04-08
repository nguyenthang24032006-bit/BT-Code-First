using System.ComponentModel.DataAnnotations;

namespace BookstoreManagement_CodeFirst.Models
{
    public class FieldType
    {
        [Key] // Khóa chính
        public int FieldTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string TypeName { get; set; } // Ví dụ: Sân cỏ nhân tạo 5 người

        public string Description { get; set; }

        // Mối quan hệ: Một loại sân có nhiều sân bóng cụ thể
        public virtual ICollection<Field> Fields { get; set; }
    }
}