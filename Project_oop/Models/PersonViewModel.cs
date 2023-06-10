using Project_oop.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_oop.Models
{
    public class PersonViewModel : IPerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        protected string _name = "";
        protected string _surname = "";
        protected string _phoneNumber = "";
        protected string _email = "";
        public PersonViewModel()
        {
        }
        public PersonViewModel(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Surname
        {
            get { return this._surname; }
            set { this._surname = value; }
        }
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public virtual string toString()
        {
            return $"{this.Name} {this.Surname} {this.PhoneNumber} {this.Email}";
        }
    }
}
