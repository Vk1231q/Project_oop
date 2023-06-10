using Project_oop.Models;
using System.Collections.Generic;

namespace Project_oop.Interfaces
{
    public interface IPostOffice
    {
        int Id { get; set; }
        string Address { get; set; }
        int CityId { get; set; }
        string ContactNumber { get; set; }
        string OfficeName { get; set; }
    }
}
