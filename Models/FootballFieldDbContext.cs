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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Bạn có thể cấu hình thêm fluent API ở đây nếu cần thiết
            base.OnModelCreating(modelBuilder);
        }
    }
}