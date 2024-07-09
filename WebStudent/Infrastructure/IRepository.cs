namespace WebStudent.Infrastructure
// khởi tạo phương thức CRUD
{
    public interface IRepository<T> where T : class
        //IRepository<T>: Đây là một interface generic với tham số kiểu T.
        //where T : class: Ràng buộc generic này chỉ ra rằng T phải là một kiểu tham chiếu (class). Điều này đảm bảo rằng T có thể là bất kỳ lớp nào.
    {
        Task<IReadOnlyList<T>> GetAllAsync(); // chỉ đọc.  Task chỉ ra rằng phương thức này là bất đồng bộ (asynchronous) và sẽ trả về một Task khi hoàn thành.
        Task<T?> GetByIDAsync(int id); // trả về thực thể T tương ứng với id nếu tìm được nếu không trả về null
        //Task<T?>: Phương thức bất đồng bộ, có thể trả về null.
        Task CreateAsync(T entity); // tạo thực thể mới
        void Update(T entity); // cập nhật thông tin thực thể. phương thức này đồng bộ
        void Delete(T entity);// xóa một thực thể 
        Task SaveChangeAsync(); // lưu thay đổi và CSDL.
    }
}
