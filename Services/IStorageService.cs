using Ilmhub.Clients;

namespace Ilmhub.Services
{
    public interface IStorageService
    {
        Task<(bool IsSuccess, Exception exception)> InsertstudentAsync(Student student);
        Task<(bool IsSuccess, Exception exception)> UpdatestudentAsync(Student student);
        Task<bool> ExistsAsync(long chatId);
        Task<bool> ExistsAsync(string studentname);
        Task<(bool IsSuccess, Exception exception, Student student)> RemoveAsync(Student student);
        Task<Student> GetstudentAsync(long chatId);
        Task<Student> GetstudentAsync(string studentname);
    }
}