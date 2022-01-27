using Ilmhub.Clients;
using Ilmhub.Data;

namespace Ilmhub.Services
{
    public class DbStorageService : IStorageService
    {
private readonly BotDbContext _context;

        public DbStorageService(BotDbContext context)
        {
            _context = context;
        }
        public async Task<bool> ExistsAsync(long chatId)
            => await _context.students.AnyAsync(u => u.ChatId == chatId);


        public async Task<bool> ExistsAsync(string studentname)
            => await _context.students.AnyAsync(u => u.Fullname == studentname);

        public async Task<Student> GetstudentAsync(long chatId)
            => await _context.students.FirstOrDefaultAsync(u => u.ChatId == chatId);

        public async Task<Student> GetstudentAsync(string studentname)
            => await _context.students.FirstOrDefaultAsync(u => u.Fullname == studentname);


        public async Task<(bool IsSuccess, Exception exception)> InsertstudentAsync(Student student)
        {
            try
            {
                await _context.students.AddAsync(student);
                await _context.SaveChangesAsync();
                return (true, null);
            }
            catch(Exception e)
            {
                return (false, e);
            }
        }

        public async Task<(bool IsSuccess, Exception exception, Student student)> RemoveAsync(Student student)
        {
            try
            {
                _context.students.Remove(student);
                await _context.SaveChangesAsync();
                return (true, null, student);
            }
            catch(Exception e)
            {
                return (false, e, null);
            }
        }

        public async Task<(bool IsSuccess, Exception exception)> UpdatestudentAsync(Student student)
        {
            try
            {
                _context.students.Update(student);
                await _context.SaveChangesAsync();

                return (true, null);
            }
            catch(Exception e)
            {
                return (false, e);
            }
        }
    }
}