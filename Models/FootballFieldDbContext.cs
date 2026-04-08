using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement_CodeFirst.Models
{
    public class FootballFieldDbContext : DbContext
    {
        public FootballFieldDbContext(DbContextOptions<FootballFieldDbContext> options)
            : base(options)
        {
        }

        // Khai báo các tập thực thể (tương ứng với các bảng trong DB)
        public DbSet<FieldType> FieldTypes { get; set; }
        public DbSet<Field> Fields { get; set; }

        // GỘP CHUNG VÀO MỘT PHƯƠNG THỨC DUY NHẤT
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Thêm dữ liệu mẫu cho Loại sân (FieldType)
            modelBuilder.Entity<FieldType>().HasData(
                new FieldType { FieldTypeId = 1, TypeName = "Sân 5 người", Description = "Sân cỏ nhân tạo mini" },
                new FieldType { FieldTypeId = 2, TypeName = "Sân 7 người", Description = "Sân cỏ nhân tạo trung bình" }
            );

            // Thêm dữ liệu mẫu cho Sân bóng cụ thể (Field)
            modelBuilder.Entity<Field>().HasData(
                new Field { FieldId = 1, FieldName = "Sân A1", PricePerHour = 300000, IsActive = true, FieldTypeId = 1 },
                new Field { FieldId = 2, FieldName = "Sân B2", PricePerHour = 500000, IsActive = true, FieldTypeId = 2 }
            );
        }
    }
}