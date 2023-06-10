using System;

namespace Project_oop.Interfaces
{
    public interface IParcel
    {
        int Id { get; set; }
        int Wage { get; set; }
        string Dispatch { get; set; }
        string Delievery { get; set; }
        int Cost { get; set; }
        string Status { get; set; }
        void WriteToFile();
    }
}
