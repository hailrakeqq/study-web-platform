using System;
namespace study_web_platform.Entities
{
    public interface IEntity
    {
        long Id { get; set; }
        bool IsActive { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateUpdated { get; set; }
        Guid UserCreated { get; set; }
        Guid UserUpdated { get; set; }
    }
}