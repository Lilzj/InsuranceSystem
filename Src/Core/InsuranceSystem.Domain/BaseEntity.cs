using System.ComponentModel.DataAnnotations;

namespace InsuranceSystem.Domain
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime LastModified { get; set; } = DateTime.Now;
        public string? ReasonModified { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
