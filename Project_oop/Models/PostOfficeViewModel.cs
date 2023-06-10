using Project_oop.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_oop.Models
{
    public class PostOfficeViewModel : IPostOffice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        private string _address = "";
        private int _cityId;
        private string _contactNumber = "";
        private string _officeName;

        public PostOfficeViewModel(string officeName)
        {
            OfficeName = officeName;
        }

        public PostOfficeViewModel()
        {
        }

        [ForeignKey("City")]
        public int CityId
        {
            get { return _cityId; }
            set { _cityId = value; }
        }

        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        public string ContactNumber
        {
            get { return this._contactNumber; }
            set { this._contactNumber = value; }
        }

        public string OfficeName
        {
            get { return this._officeName; }
            set { this._officeName = value; }
        }
        public override string ToString()
        {
            return OfficeName;
        }

        [InverseProperty("PostOffices")]
        public virtual CityViewModel City { get; set; }
        public virtual ICollection<PersonnelViewModel> Personnels { get; set; }

        [InverseProperty("SendingPostOffice")]
        public virtual ICollection<ParcelViewModel> SentParcels { get; set; }

        [InverseProperty("ReceivingPostOffice")]
        public virtual ICollection<ParcelViewModel> ReceivedParcels { get; set; }
    }
}
