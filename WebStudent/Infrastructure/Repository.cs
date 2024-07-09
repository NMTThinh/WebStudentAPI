using Microsoft.EntityFrameworkCore;
using WebStudent.Infrastructure;
namespace WebStudent.Infrastructure
    //Định nghĩa phương thức CRUD
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext appDbContext; // appDbContext được sử dụng để tương tác với cơ sở dữ liệu. 
        private DbSet<T> entities;// DbSet của kiểu T,đại diện cho tập hợp các thực thể trong cơ sở dữ liệu.
        // Hàm khởi tạo
        public Repository(DbContext context)
        {
            this.appDbContext = context;
            entities = appDbContext.Set<T>();
        }

        public Task SaveChangeAsync() => appDbContext.SaveChangesAsync();

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task<T?> GetByIDAsync(int id)
        {
            var entity = await entities.FindAsync(id);
            if (entity == null)
            {
                return null!;
            }
            return entity;
        }

        public async Task CreateAsync(T entity)
        {
            await entities.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
        }

        public void Update(T entity)
        {
            entities.Update(entity);
        }
    }
}
