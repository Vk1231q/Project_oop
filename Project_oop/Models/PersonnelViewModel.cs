using Project_oop.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Project_oop.Models
{
    public class PersonnelViewModel : PersonViewModel, IPersonnel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private int _postOfficeId;
        private string _position = "";
        public PersonnelViewModel()
        {
        }
        public PersonnelViewModel(string name, string surname, string position)
            : base(name, surname)
        {
            this.Position = position;
        }

        [ForeignKey("PostOffice")]
        public int PostOfficeId
        {
            get { return _postOfficeId; }
            set { _postOfficeId = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public sealed override string ToString()
        {
            string baseString = base.ToString();
            return $"{baseString} {Position}";
        }

        public void BasePersonnel()
        {
            PersonViewModel person = new PersonViewModel("John", "Doe");
            PostOfficeViewModel postOffice = new PostOfficeViewModel("Main Post Office");
            PersonnelViewModel personnel = new PersonnelViewModel("Jane", "Smith", "Manager");
            object[] objects = new object[3];
            objects[0] = person;
            objects[1] = postOffice;
            objects[2] = personnel;
        }

        [InverseProperty("Personnels")]
        public virtual PostOfficeViewModel PostOffice { get; set; }
    }
}
