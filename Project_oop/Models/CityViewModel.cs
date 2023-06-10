 using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Project_oop.Interfaces;

namespace Project_oop.Models
{
    public class CityViewModel : ICity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private string _name = "";
        private string _country = "";
        private string _zipCode = "";

        public CityViewModel()
        {
        }

        public CityViewModel(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        public string ZipCode
        {
            get { return this._zipCode; }
            set { this._zipCode = value; }
        }
        public virtual ICollection<PostOfficeViewModel> PostOffices { get; set; }
    }
}
