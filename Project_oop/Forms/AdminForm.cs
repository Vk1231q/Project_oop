using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Project_oop.Forms;
using Project_oop.Interfaces;
using Project_oop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_oop
{
    public partial class AdminForm : MaterialForm
    {
        public static List<ParcelViewModel> parcelList = new List<ParcelViewModel>();
        public static List<CityViewModel> cityList = new List<CityViewModel>();
        public static List<PostOfficeViewModel> postOfficeList = new List<PostOfficeViewModel>();
        public static List<PersonnelViewModel> personnelList = new List<PersonnelViewModel>();
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public AdminForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE);
            Load += AdminForm_Load;
        }
        private void BtnAddCities_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxCountryCities.Text)
                || string.IsNullOrEmpty(TxtBoxNameCities.Text) || string.IsNullOrEmpty(TxtBoxZipCode.Text))
            {
                MessageBox.Show("Введіть значення у всі поля");
            }
            else
            {
                string cityName = TxtBoxNameCities.Text;
                string country = TxtBoxCountryCities.Text;
                string zipCode = TxtBoxZipCode.Text;

                using (var context = new ContextModel())
                {
                    CityViewModel dbCity = new CityViewModel();
                    dbCity.Name = cityName;
                    dbCity.Country = country;
                    dbCity.ZipCode = zipCode;

                    context.CityViewModels.Add(dbCity);
                    context.SaveChanges();

                    int generatedId = dbCity.Id;

                    int rowIndex = DGVCities.Rows.Add();
                    DGVCities.Rows[rowIndex].Cells["IdCities"].Value = generatedId;
                    DGVCities.Rows[rowIndex].Cells["NameCities"].Value = cityName;
                    DGVCities.Rows[rowIndex].Cells["CountryCities"].Value = country;
                    DGVCities.Rows[rowIndex].Cells["CodeCities"].Value = zipCode;

                    CityViewModel city = new CityViewModel(cityName);
                    CMBCityPostOffices.Items.Add(city.Name);

                    TxtBoxCountryCities.Clear();
                    TxtBoxNameCities.Clear();
                    TxtBoxZipCode.Clear();
                }
            }

        }
        private void BtnEditCities_Click(object sender, EventArgs e)
        {
            if (DGVCities.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGVCities.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                int id = Convert.ToInt32(selectedRow.Cells["IdCities"].Value);
                string cityName = TxtBoxNameCities.Text;
                string country = TxtBoxCountryCities.Text;
                string zipCode = TxtBoxZipCode.Text;

                if (!string.IsNullOrEmpty(cityName) && !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(zipCode))
                {
                    selectedRow.Cells["NameCities"].Value = cityName;
                    selectedRow.Cells["CountryCities"].Value = country;
                    selectedRow.Cells["CodeCities"].Value = zipCode;

                    using (var context = new ContextModel())
                    {
                        CityViewModel city = context.CityViewModels.FirstOrDefault(p => p.Id == id);
                        if (city != null)
                        {
                            city.Name = cityName;
                            city.Country = country;
                            city.ZipCode = zipCode;
                            context.SaveChanges();
                        }
                    }

                    CMBCityPostOffices.Items[rowIndex] = cityName;
                }
                else
                {
                    MessageBox.Show("Заповніть всі поля.");
                }
            }
        }
        private void BtnDeleteCities_Click(object sender, EventArgs e)
        {
            if (DGVCities.SelectedRows.Count > 0)
            {
                using (var context = new ContextModel())
                {
                    foreach (DataGridViewRow row in DGVCities.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["IdCities"].Value);

                        var city = context.CityViewModels.FirstOrDefault(c => c.Id == id);
                        if (city != null)
                        {
                            string deletedCityName = city.Name;

                            var officesToRemove = context.PostOfficeViewModels.Where(po => po.CityId == id).ToList();
                            foreach (var office in officesToRemove)
                            {
                                string deletedOfficeName = office.OfficeName;
                                var personnelToRemove = context.PersonnelViewModels.Where(emp => emp.PostOfficeId == office.Id).ToList();
                                context.PersonnelViewModels.RemoveRange(personnelToRemove);
                                CMBDepartmentPersonnel.Items.Remove(deletedOfficeName);
                                CMBFromParcels.Items.Remove(deletedOfficeName);
                                CMBToParcels.Items.Remove(deletedOfficeName);
                            }

                            context.PostOfficeViewModels.RemoveRange(officesToRemove);
                            context.CityViewModels.Remove(city);
                            CMBCityPostOffices.Items.Remove(deletedCityName);
                        }

                        DGVCities.Rows.Remove(row);
                    }

                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок(и) для видалення");
            }
        }
        private void BtnRefreshCities_Click(object sender, EventArgs e)
        {
            DGVCities.Rows.Clear();
            using (var context = new ContextModel())
            {
                cityList = context.CityViewModels.ToList();
            }
            foreach (var city in cityList)
            {
                int rowIndex = DGVCities.Rows.Add();
                DGVCities.Rows[rowIndex].Cells["IdCities"].Value = city.Id;
                DGVCities.Rows[rowIndex].Cells["NameCities"].Value = city.Name;
                DGVCities.Rows[rowIndex].Cells["CountryCities"].Value = city.Country;
                DGVCities.Rows[rowIndex].Cells["CodeCities"].Value = city.ZipCode;
            }
        }
        private void BtnPostOffices_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxAddressPostOffices.Text)
                || string.IsNullOrEmpty(CMBCityPostOffices.Text) || string.IsNullOrEmpty(TxtBoxNamePostOffices.Text)
                || string.IsNullOrEmpty(TxtBoxCntctNPostOffices.Text))
            {
                MessageBox.Show("Введіть значення у всі поля");
            }
            else
            {
                string address = TxtBoxAddressPostOffices.Text;
                string cityName = CMBCityPostOffices.SelectedItem != null ? CMBCityPostOffices.SelectedItem.ToString() : string.Empty;
                string officeName = TxtBoxNamePostOffices.Text;
                string contactN = TxtBoxCntctNPostOffices.Text;

                using (var context = new ContextModel())
                {
                    PostOfficeViewModel dbOffices = new PostOfficeViewModel();
                    dbOffices.Address = address;

                    CityViewModel city = context.CityViewModels.FirstOrDefault(c => c.Name == cityName);
                    if (city == null)
                    {
                        city = new CityViewModel() { Name = cityName };
                        context.CityViewModels.Add(city);
                    }

                    dbOffices.City = city;

                    dbOffices.OfficeName = officeName;
                    dbOffices.ContactNumber = contactN;

                    context.PostOfficeViewModels.Add(dbOffices);
                    context.SaveChanges();

                    int generatedId = dbOffices.Id;

                    int rowIndex = DGVOffices.Rows.Add();
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeId"].Value = generatedId;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeAddress"].Value = address;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeCity"].Value = cityName;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeName"].Value = officeName;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeNumber"].Value = contactN;

                    PostOfficeViewModel office = new PostOfficeViewModel(officeName);
                    CMBDepartmentPersonnel.Items.Add(office);
                    CMBFromParcels.Items.Add(office);
                    CMBToParcels.Items.Add(office);

                    TxtBoxAddressPostOffices.Clear();
                    CMBCityPostOffices.Text = string.Empty;
                    TxtBoxNamePostOffices.Clear();
                    TxtBoxCntctNPostOffices.Clear();
                }
            }
        }
        private void BtnEditPostOffices_Click(object sender, EventArgs e)
        {
            if (DGVOffices.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGVOffices.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                int id = Convert.ToInt32(selectedRow.Cells["PostOfficeId"].Value);
                string address = TxtBoxAddressPostOffices.Text;
                string cityName = CMBCityPostOffices.SelectedItem != null ? CMBCityPostOffices.SelectedItem.ToString() : string.Empty;
                string officeName = TxtBoxNamePostOffices.Text;
                string contactN = TxtBoxCntctNPostOffices.Text;

                if (!string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(cityName) && !string.IsNullOrEmpty(officeName) && !string.IsNullOrEmpty(contactN))
                {
                    selectedRow.Cells["PostOfficeAddress"].Value = address;
                    selectedRow.Cells["PostOfficeCity"].Value = cityName;
                    selectedRow.Cells["PostOfficeName"].Value = officeName;
                    selectedRow.Cells["PostOfficeNumber"].Value = contactN;

                    using (var context = new ContextModel())
                    {
                        PostOfficeViewModel office = context.PostOfficeViewModels.FirstOrDefault(po => po.Id == id);
                        if (office != null)
                        {
                            office.Address = address;

                            CityViewModel city = context.CityViewModels.FirstOrDefault(c => c.Name == cityName);
                            if (city == null)
                            {
                                city = new CityViewModel() { Name = cityName };
                                context.CityViewModels.Add(city);
                            }
                            office.City = city;

                            office.OfficeName = officeName;
                            office.ContactNumber = contactN;
                            context.SaveChanges();
                        }

                        CMBDepartmentPersonnel.Items[rowIndex] = officeName;
                        CMBFromParcels.Items[rowIndex] = officeName;
                        CMBToParcels.Items[rowIndex] = officeName;
                    }
                }
                else
                {
                    MessageBox.Show("Заповніть всі поля.");
                }
            }
        }
        private void BtnDeletePostOffices_Click(object sender, EventArgs e)
        {
            if (DGVOffices.SelectedRows.Count > 0)
            {
                using (var context = new ContextModel())
                {
                    foreach (DataGridViewRow row in DGVOffices.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["PostOfficeId"].Value);

                        var office = context.PostOfficeViewModels.FirstOrDefault(po => po.Id == id);
                        if (office != null)
                        {
                            string deletedOfficeName = office.OfficeName;

                            var personnelToRemove = context.PersonnelViewModels.Where(p => p.PostOfficeId == id).ToList();
                            context.PersonnelViewModels.RemoveRange(personnelToRemove);

                            context.PostOfficeViewModels.Remove(office);
                            CMBDepartmentPersonnel.Items.Remove(deletedOfficeName);
                            CMBFromParcels.Items.Remove(deletedOfficeName);
                            CMBToParcels.Items.Remove(deletedOfficeName);
                        }

                        DGVOffices.Rows.Remove(row);
                    }
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок(и) для видалення");
            }
        }
        private void BtnRefreshPostOffices_Click(object sender, EventArgs e)
        {

            DGVOffices.Rows.Clear();
            using (var context = new ContextModel())
            {
                var postOfficeList = context.PostOfficeViewModels.Include("City").ToList();
                foreach (var office in postOfficeList)
                {
                    int rowIndex = DGVOffices.Rows.Add();
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeId"].Value = office.Id;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeAddress"].Value = office.Address;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeCity"].Value = office.City?.Name;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeName"].Value = office.OfficeName;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeNumber"].Value = office.ContactNumber;
                }
            }
        }
        private void BtnAddPesonnel_Click(object sender, EventArgs e)
        {
            string name = TxtBoxNamePersonnel.Text;
            string surname = TxtBoxSurnamePersonnel.Text;
            string phone = TxtBoxPhonePersonnel.Text;
            string email = TxtBoxEmailPersonnel.Text;
            string department = CMBDepartmentPersonnel.SelectedItem?.ToString();
            string position = CMBPositionPersonnel.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(department) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Введіть значення у всі поля");
            }
            else
            {
                using (var context = new ContextModel())
                {
                    PersonnelViewModel dbPersonnel = new PersonnelViewModel();
                    dbPersonnel.Name = name;
                    dbPersonnel.Surname = surname;
                    dbPersonnel.PhoneNumber = phone;
                    dbPersonnel.Email = email;
                    dbPersonnel.Position = position;

                    var office = context.PostOfficeViewModels.FirstOrDefault(po => po.OfficeName == department);
                    if (office == null)
                    {
                        office = new PostOfficeViewModel() { OfficeName = department };
                        context.PostOfficeViewModels.Add(office);
                    }

                    dbPersonnel.PostOffice = office;

                    context.PersonnelViewModels.Add(dbPersonnel);
                    context.SaveChanges();

                    int generatedId = dbPersonnel.Id;

                    int rowIndex = DGVPersonnel.Rows.Add();
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelId"].Value = generatedId;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelName"].Value = name;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelSurname"].Value = surname;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelPhoneNumber"].Value = phone;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelEmail"].Value = email;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelDepartment"].Value = department;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelPosition"].Value = position;

                    TxtBoxNamePersonnel.Clear();
                    TxtBoxSurnamePersonnel.Clear();
                    TxtBoxPhonePersonnel.Clear();
                    TxtBoxEmailPersonnel.Clear();
                    CMBDepartmentPersonnel.Text = string.Empty;
                    CMBPositionPersonnel.Text = string.Empty;
                }
            }
        }
        private void BtnEditPesonnel_Click(object sender, EventArgs e)
        {
            if (DGVPersonnel.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGVPersonnel.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                int id = Convert.ToInt32(selectedRow.Cells["PersonnelId"].Value);
                string name = TxtBoxNamePersonnel.Text;
                string surname = TxtBoxSurnamePersonnel.Text;
                string phone = TxtBoxPhonePersonnel.Text;
                string email = TxtBoxEmailPersonnel.Text;
                string department = CMBDepartmentPersonnel.SelectedItem?.ToString();
                string position = CMBPositionPersonnel.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) &&
                    !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(email) &&
                    !string.IsNullOrEmpty(department) && !string.IsNullOrEmpty(position))
                {
                    selectedRow.Cells["PersonnelName"].Value = name;
                    selectedRow.Cells["PersonnelSurname"].Value = surname;
                    selectedRow.Cells["PersonnelPhoneNumber"].Value = phone;
                    selectedRow.Cells["PersonnelEmail"].Value = email;
                    selectedRow.Cells["PersonnelDepartment"].Value = department;
                    selectedRow.Cells["PersonnelPosition"].Value = position;

                    using (var context = new ContextModel())
                    {
                        PersonnelViewModel personnel = context.PersonnelViewModels.FirstOrDefault(p => p.Id == id);
                        if (personnel != null)
                        {
                            personnel.Name = name;
                            personnel.Surname = surname;
                            personnel.PhoneNumber = phone;
                            personnel.Email = email;
                            personnel.Position = position;

                            var office = context.PostOfficeViewModels.FirstOrDefault(po => po.OfficeName == department);
                            if (office == null)
                            {
                                office = new PostOfficeViewModel() { OfficeName = department };
                                context.PostOfficeViewModels.Add(office);
                            }

                            personnel.PostOffice = office;

                            context.SaveChanges();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Заповніть всі поля.");
                }
            }
        }
        private void BtnDeletePesonnel_Click(object sender, EventArgs e)
        {
            if (DGVPersonnel.SelectedRows.Count > 0)
            {
                using (var context = new ContextModel())
                {
                    foreach (DataGridViewRow row in DGVPersonnel.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["PersonnelId"].Value);

                        PersonnelViewModel personnel = context.PersonnelViewModels.FirstOrDefault(p => p.Id == id);
                        if (personnel != null)
                        {
                            context.PersonnelViewModels.Remove(personnel);
                        }

                        DGVPersonnel.Rows.Remove(row);
                    }

                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок(и) для видалення");
            }
        }
        private void BtnRefreshPesonnel_Click(object sender, EventArgs e)
        {
            DGVPersonnel.Rows.Clear();
            using (var context = new ContextModel())
            {
                var personnelList = context.PersonnelViewModels.Include("PostOffice").ToList();

                foreach (var personnel in personnelList)
                {
                    int rowIndex = DGVPersonnel.Rows.Add();
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelId"].Value = personnel.Id;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelName"].Value = personnel.Name;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelSurname"].Value = personnel.Surname;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelPhoneNumber"].Value = personnel.PhoneNumber;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelEmail"].Value = personnel.Email;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelDepartment"].Value = personnel.PostOffice?.OfficeName;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelPosition"].Value = personnel.Position;
                }
            }
        }
        private void BtnAddParcels_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxWageParcels.Text)
                || string.IsNullOrEmpty(DTPDispatchParcels.Text) || string.IsNullOrEmpty(DTPDelieveryParcels.Text)
                || string.IsNullOrEmpty(TxtBoxCostParcels.Text) || string.IsNullOrEmpty(CMBFromParcels.Text)
                || string.IsNullOrEmpty(CMBToParcels.Text) || string.IsNullOrEmpty(CMBClientParcels.Text)
                || string.IsNullOrEmpty(CMBStatusParcels.Text))
            {
                MessageBox.Show("Введіть значення у всі поля");
            }
            else
            {
                int wage;
                if (!int.TryParse(TxtBoxWageParcels.Text, out wage))
                {
                    MessageBox.Show("Некоректне значення в полі 'Wage'");
                    return;
                }
                string dispatch = DTPDispatchParcels.Text;
                string delievery = DTPDelieveryParcels.Text;
                int cost;
                if (!int.TryParse(TxtBoxCostParcels.Text, out cost))
                {
                    MessageBox.Show("Некоректне значення в полі 'Cost'");
                    return;
                }
                string from = CMBFromParcels.SelectedItem?.ToString();
                string to = CMBToParcels.SelectedItem?.ToString();
                string client = CMBClientParcels.SelectedItem?.ToString();
                string status = CMBStatusParcels.SelectedItem.ToString();

                using (var context = new ContextModel())
                {
                    var officeFrom = context.PostOfficeViewModels.FirstOrDefault(po => po.OfficeName == from);
                    if (officeFrom == null)
                    {
                        officeFrom = new PostOfficeViewModel() { OfficeName = from };
                        context.PostOfficeViewModels.Add(officeFrom);
                    }
                    var officeTo = context.PostOfficeViewModels.FirstOrDefault(po => po.OfficeName == to);
                    if (officeTo == null)
                    {
                        officeTo = new PostOfficeViewModel() { OfficeName = to };
                        context.PostOfficeViewModels.Add(officeTo);
                    }
                    var clientModel = context.ClientViewModels.FirstOrDefault(c => c.Username == client);
                    if (clientModel == null)
                    {
                        clientModel = new ClientViewModel() { Username = client };
                        context.ClientViewModels.Add(clientModel);
                    }

                    ParcelViewModel dbParcel = new ParcelViewModel();
                    dbParcel.Wage = wage;
                    dbParcel.Dispatch = dispatch;
                    dbParcel.Delievery = delievery;
                    dbParcel.Cost = cost;
                    dbParcel.Status = status;
                    dbParcel.SendingPostOffice = officeFrom;
                    dbParcel.ReceivingPostOffice = officeTo;
                    dbParcel.Client = clientModel;

                    context.ParcelViewModels.Add(dbParcel);
                    context.SaveChanges();

                    int generatedId = dbParcel.Id;

                    int rowIndex = DGVParcels.Rows.Add();
                    DGVParcels.Rows[rowIndex].Cells["ParcelsId"].Value = generatedId;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsWage"].Value = wage;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsDispatch"].Value = dispatch;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsDelievery"].Value = delievery;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsCost"].Value = cost;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsFrom"].Value = officeFrom;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsTo"].Value = officeTo;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsClient"].Value = clientModel.Username;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsStatus"].Value = status;

                    ParcelViewModel parcel = new ParcelViewModel(generatedId, wage, dispatch, delievery, cost, officeFrom, officeTo, status);
                    parcelList.Add(parcel);

                    TxtBoxWageParcels.Clear();
                    TxtBoxCostParcels.Clear();
                    CMBFromParcels.Text = string.Empty;
                    CMBToParcels.Text = string.Empty;
                    CMBClientParcels.Text = string.Empty;
                    CMBStatusParcels.Text = string.Empty;
                }
            }
        }
        private void BtnEditParcels_Click(object sender, EventArgs e)
        {
            if (DGVParcels.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGVParcels.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                int id = Convert.ToInt32(selectedRow.Cells["ParcelsId"].Value);
                int wage;
                if (!int.TryParse(TxtBoxWageParcels.Text, out wage))
                {
                    MessageBox.Show("Некоректне значення в полі 'Wage'");
                    return;
                }
                string dispatch = DTPDispatchParcels.Text;
                string delievery = DTPDelieveryParcels.Text;
                int cost;
                if (!int.TryParse(TxtBoxCostParcels.Text, out cost))
                {
                    MessageBox.Show("Некоректне значення в полі 'Cost'");
                    return;
                }
                string from = CMBFromParcels.SelectedItem?.ToString();
                string to = CMBToParcels.SelectedItem?.ToString();
                string client = CMBClientParcels.SelectedItem?.ToString();
                string status = CMBStatusParcels.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(dispatch) && !string.IsNullOrEmpty(delievery) && !string.IsNullOrEmpty(from) && !string.IsNullOrEmpty(to) && !string.IsNullOrEmpty(client))
                {
                    selectedRow.Cells["ParcelsWage"].Value = wage;
                    selectedRow.Cells["ParcelsDispatch"].Value = dispatch;
                    selectedRow.Cells["ParcelsDelievery"].Value = delievery;
                    selectedRow.Cells["ParcelsCost"].Value = cost;
                    selectedRow.Cells["ParcelsFrom"].Value = from;
                    selectedRow.Cells["ParcelsTo"].Value = to;
                    selectedRow.Cells["ParcelsClient"].Value = client;
                    selectedRow.Cells["ParcelsStatus"].Value = status;

                    using (var context = new ContextModel())
                    {
                        ParcelViewModel parcel = context.ParcelViewModels.FirstOrDefault(p => p.Id == id);
                        if (parcel != null)
                        {
                            ParcelViewModel pparcels = new ParcelViewModel();
                            pparcels.SendingPostOffice = new PostOfficeViewModel();
                            pparcels.ReceivingPostOffice = new PostOfficeViewModel();
                            parcel.Wage = wage;
                            parcel.Dispatch = dispatch;
                            parcel.Delievery = delievery;
                            parcel.Cost = cost;
                            parcel.Status = status;

                            var officeFrom = context.PostOfficeViewModels.FirstOrDefault(po => po.OfficeName == from);
                            if (officeFrom == null)
                            {
                                officeFrom = new PostOfficeViewModel() { OfficeName = from };
                                context.PostOfficeViewModels.Add(officeFrom);
                            }
                            var officeTo = context.PostOfficeViewModels.FirstOrDefault(po => po.OfficeName == to);
                            if (officeTo == null)
                            {
                                officeTo = new PostOfficeViewModel() { OfficeName = to };
                                context.PostOfficeViewModels.Add(officeTo);
                            }
                            var clients = context.ClientViewModels.FirstOrDefault(po => po.Username == client);
                            if (clients == null)
                            {
                                clients = new ClientViewModel() { Username = client };
                                context.ClientViewModels.Add(clients);
                            }
                            parcel.SendingPostOffice = officeFrom;
                            parcel.ReceivingPostOffice = officeTo;
                            parcel.Client = clients;

                            context.SaveChanges();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введіть значення для всіх обов'язкових полів");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Виберіть посилку для редагування");
                return;
            }
        }
        private void BtnDeleteParcels_Click(object sender, EventArgs e)
        {
            if (DGVParcels.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити вибрану посилку?", "Видалення посилки", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = DGVParcels.SelectedRows[0];
                    int rowIndex = selectedRow.Index;
                    int id = Convert.ToInt32(selectedRow.Cells["ParcelsId"].Value);

                    DGVParcels.Rows.RemoveAt(rowIndex);

                    using (var context = new ContextModel())
                    {
                        ParcelViewModel parcel = context.ParcelViewModels.FirstOrDefault(p => p.Id == id);
                        if (parcel != null)
                        {
                            context.ParcelViewModels.Remove(parcel);
                            context.SaveChanges();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть посилку для видалення");
            }
        }
        private void BtnRefreshParcels_Click(object sender, EventArgs e)
        {
            DGVParcels.Rows.Clear();

            using (var context = new ContextModel())
            {
                var parcels = context.ParcelViewModels
                    .Include("SendingPostOffice")
                    .Include("ReceivingPostOffice")
                    .Include("Client")
                    .ToList();

                foreach (var parcel in parcels)
                {
                    int rowIndex = DGVParcels.Rows.Add();
                    DGVParcels.Rows[rowIndex].Cells["ParcelsId"].Value = parcel.Id;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsWage"].Value = parcel.Wage;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsDispatch"].Value = parcel.Dispatch;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsDelievery"].Value = parcel.Delievery;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsCost"].Value = parcel.Cost;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsFrom"].Value = parcel.SendingPostOffice?.OfficeName;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsTo"].Value = parcel.ReceivingPostOffice?.OfficeName;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsClient"].Value = parcel.Client?.Username;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsStatus"].Value = parcel.Status;

                }
            }
        }
        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabPage2)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            DGVCities.Rows.Clear();
            DGVOffices.Rows.Clear();
            DGVPersonnel.Rows.Clear();
            DGVParcels.Rows.Clear();
            CMBCityPostOffices.Items.Clear();
            CMBDepartmentPersonnel.Items.Clear();
            CMBFromParcels.Items.Clear();
            CMBToParcels.Items.Clear();
            using (var context = new ContextModel())
            {
                cityList = context.CityViewModels.ToList();
                foreach (var city in cityList)
                {
                    int rowIndex = DGVCities.Rows.Add();
                    DGVCities.Rows[rowIndex].Cells["IdCities"].Value = city.Id;
                    DGVCities.Rows[rowIndex].Cells["NameCities"].Value = city.Name;
                    DGVCities.Rows[rowIndex].Cells["CountryCities"].Value = city.Country;
                    DGVCities.Rows[rowIndex].Cells["CodeCities"].Value = city.ZipCode;
                }

                postOfficeList = context.PostOfficeViewModels.Include("City").ToList();
                foreach (var office in postOfficeList)
                {
                    int rowIndex = DGVOffices.Rows.Add();
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeId"].Value = office.Id;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeAddress"].Value = office.Address;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeCity"].Value = office.City?.Name;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeName"].Value = office.OfficeName;
                    DGVOffices.Rows[rowIndex].Cells["PostOfficeNumber"].Value = office.ContactNumber;
                }

                personnelList = context.PersonnelViewModels.Include("PostOffice").ToList();
                foreach (var personnel in personnelList)
                {
                    int rowIndex = DGVPersonnel.Rows.Add();
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelId"].Value = personnel.Id;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelName"].Value = personnel.Name;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelSurname"].Value = personnel.Surname;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelPhoneNumber"].Value = personnel.PhoneNumber;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelEmail"].Value = personnel.Email;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelDepartment"].Value = personnel.PostOffice?.OfficeName;
                    DGVPersonnel.Rows[rowIndex].Cells["PersonnelPosition"].Value = personnel.Position;
                }

                parcelList = context.ParcelViewModels.ToList();
                foreach (var parcel in parcelList)
                {
                    int rowIndex = DGVParcels.Rows.Add();
                    DGVParcels.Rows[rowIndex].Cells["ParcelsId"].Value = parcel.Id;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsWage"].Value = parcel.Wage;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsDispatch"].Value = parcel.Dispatch;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsDelievery"].Value = parcel.Delievery;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsCost"].Value = parcel.Cost;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsFrom"].Value = parcel.SendingPostOffice?.OfficeName;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsTo"].Value = parcel.ReceivingPostOffice?.OfficeName;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsClient"].Value = parcel.Client?.Username;
                    DGVParcels.Rows[rowIndex].Cells["ParcelsStatus"].Value = parcel.Status;
                }
                foreach (var city in cityList)
                {
                    CMBCityPostOffices.Items.Add(city.Name);
                }

                foreach (var office in postOfficeList)
                {
                    CMBDepartmentPersonnel.Items.Add(office.OfficeName);
                }
                foreach (var office in postOfficeList)
                {
                    CMBFromParcels.Items.Add(office.OfficeName);
                }

                foreach (var office in postOfficeList)
                {
                    CMBToParcels.Items.Add(office.OfficeName);
                }

                List<string> allUsernames = context.ClientViewModels.Select(c => c.Username).ToList();
                AddUsernamesToComboBox(allUsernames);
            }
            DGVCities.Update(); DGVCities.Refresh();
            DGVOffices.Update(); DGVOffices.Refresh();
            DGVPersonnel.Update(); DGVPersonnel.Refresh();
            DGVParcels.Update(); DGVParcels.Refresh();
            CMBCityPostOffices.Update(); CMBCityPostOffices.Refresh();
            CMBDepartmentPersonnel.Update(); CMBDepartmentPersonnel.Refresh();
            CMBFromParcels.Update(); CMBFromParcels.Refresh();
            CMBToParcels.Update(); CMBToParcels.Refresh();
            CMBClientParcels.Update(); CMBClientParcels.Refresh();
        }
        public void AddUsernamesToComboBox(List<string> usernames)
        {
            CMBClientParcels.Items.Clear(); 

            foreach (string username in usernames)
            {
                CMBClientParcels.Items.Add(username);
            }
        }
    }
}
