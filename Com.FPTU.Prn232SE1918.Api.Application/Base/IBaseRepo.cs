public interface IBaseRepo<T> where T : class
{
    // Chỉ cho phép lấy ra một TẬP các entity T bất kỳ
    DbSet<T> Entities { get; }
    IApplicationDbContext ApplicationDbContext { get; } //Has-A
}
