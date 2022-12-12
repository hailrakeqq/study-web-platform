using System.Collections.Generic;
using study_web_platform.Entities;
namespace study_web_platform.Services
{
    public interface IEfRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(long id);
        Task<long> Add(T entity);
    }
}