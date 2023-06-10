using Project_oop.Models;

namespace Project_oop.Interfaces
{
    public interface IPersonnel
    {
        int Id { get; set; }
        int PostOfficeId { get; set; }
        string Position { get; set; }
    }
}
