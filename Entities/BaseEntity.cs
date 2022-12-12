namespace study_web_platform.Entities
{
    public class BaseEntity : IEntity
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid UserCreated { get; set; }
        public Guid UserUpdated { get; set; }
    }
}