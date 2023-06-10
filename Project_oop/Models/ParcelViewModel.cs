using Project_oop.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace Project_oop.Models
{
    public class ParcelViewModel : IParcel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private int _wage = 0;
        private string _dispatch = "";
        private string _delievery = "";
        private int _cost = 0;
        private int _sendingPostOfficeId; 
        private int _receivingPostOfficeId;
        private int _clientId;
        private string _status = "";

        public ParcelViewModel()
        {
        }

        public ParcelViewModel(int id, int wage, string dispatch, string delievery, int cost, PostOfficeViewModel officeFrom, PostOfficeViewModel officeTo, string status)
        {
            Id = id;
            Wage = wage;
            Dispatch = dispatch;
            Delievery = delievery;
            Cost = cost;
            SendingPostOffice = officeFrom;
            ReceivingPostOffice = officeTo;
            Status = status;
        }
        [ForeignKey("SendingPostOffice")]
        public int SendingPostOfficeId
        {
            get { return _sendingPostOfficeId; }
            set { _sendingPostOfficeId = value; }
        }
        [ForeignKey("ReceivingPostOffice")]
        public int ReceivingPostOfficeId
        {
            get { return _receivingPostOfficeId; }
            set { _receivingPostOfficeId = value; }
        }
        [ForeignKey("ClientId")]
        public virtual ClientViewModel Client { get; set; }
        public int Wage
        {
            get { return this._wage; }
            set { this._wage = value; }
        }
        public string Dispatch
        {
            get { return this._dispatch; }
            set { this._dispatch = value; }
        }
        public string Delievery
        {
            get { return this._delievery; }
            set { this._delievery = value; }
        }
        public int Cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        void WriteToFile()
        {
            using (StreamWriter sw = new StreamWriter("Parcel.txt", true))
            {
                sw.WriteLine($"{this.Id} {this.Wage} {this.Dispatch} {this.Delievery} {this.Cost}");
            }
        }

        void IParcel.WriteToFile()
        {
            throw new NotImplementedException();
        }

        [InverseProperty("SentParcels")]
        public virtual PostOfficeViewModel SendingPostOffice { get; set; }
        [InverseProperty("ReceivedParcels")]
        public virtual PostOfficeViewModel ReceivingPostOffice { get; set; }
        public virtual ICollection<ClientViewModel> Clients { get; set; }

    }
}

