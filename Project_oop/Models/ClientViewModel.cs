using Project_oop.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Project_oop.Models
{
    public class ClientViewModel : PersonViewModel, IClient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private int _parcelId;
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        private int _money = 1000;
        [ForeignKey("Parcel")]
        public int ParcelId
        {
            get { return _parcelId; }
            set { _parcelId = value; }
        }
        public int Money
        {
            get { return this._money; }
            set { this._money = value; }
        }

        [InverseProperty("Client")]
        public virtual ICollection<ParcelViewModel> Parcels { get; set; }
    }
}


