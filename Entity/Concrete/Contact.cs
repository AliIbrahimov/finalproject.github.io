using System.ComponentModel;

namespace Entity.Concrete;

public class Contact
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Subject { get; set; }
    public string? Message { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    [DefaultValue(false)]
    public bool IsDeleted { get; set; }
}
