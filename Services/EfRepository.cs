using study_web_platform.Entities;
using System.Linq;
using System.Collections.Generic;
namespace study_web_platform.Services
{
    public class UserRepository<T> : IEfRepository<T> where T : BaseEntity
    {
        private readonly DataContext? _context;

        public UserRepository(DataContext context) { _context = context; }

        public List<T> GetAll() => _context.Set<T>().ToList();

        public T GetById(long id)
        {
            var result = _context?.Set<T>().FirstOrDefault(x => x.Id == id);

            if (result == null)
                return null;

            return result;
        }

        public async Task<long> Add(T entity)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity.Id;
        }

    }
}