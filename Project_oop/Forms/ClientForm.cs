using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Project_oop.Models;

namespace Project_oop.Forms
{
    public delegate void UpdateMoneyDelegate(int amount);

    public partial class ClientForm : MaterialForm
    {
        private ClientViewModel _clientViewModel;
        private List<ParcelViewModel> parcels;
        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private string username;

        public ClientForm(string username)
        {
            InitializeComponent();
            this.username = username;

            using (var context = new ContextModel())
            {
                _clientViewModel = context.ClientViewModels.FirstOrDefault(c => c.Username == username);
            }

            if (_clientViewModel != null)
            {
                UpdateMoneyLabel(_clientViewModel.Money);
            }
            else
            {
                UpdateMoneyLabel(0);
            }

            BtnConfirmClient.Click += BtnConfirmClient_Click;

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            Load += ClientForm_Load;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            using (var context = new ContextModel())
            {
                _clientViewModel = context.ClientViewModels.Include("Parcels").FirstOrDefault(c => c.Username == username);
                if (_clientViewModel != null && _clientViewModel.Parcels != null)
                {
                    parcels = _clientViewModel.Parcels.ToList();

                    DGVParcels.Rows.Clear();

                    foreach (var parcel in parcels)
                    {
                        int rowIndex = DGVParcels.Rows.Add();
                        DGVParcels.Rows[rowIndex].Cells["ParcelsId"].Value = parcel.Id;
                        DGVParcels.Rows[rowIndex].Cells["ParcelsWage"].Value = parcel.Wage;
                        DGVParcels.Rows[rowIndex].Cells["ParcelsDispatch"].Value = parcel.Dispatch;
                        DGVParcels.Rows[rowIndex].Cells["ParcelsDelievery"].Value = parcel.Delievery;
                        DGVParcels.Rows[rowIndex].Cells["ParcelsCost"].Value = parcel.Cost;
 
                    }
                }
            }

            ClientName.Text = username.ToString();
        }


        private void BtnConfirmClient_Click(object sender, EventArgs e)
        {
            if (DGVParcels.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGVParcels.SelectedRows[0];
                int rowIndex = selectedRow.Index;
                int id = Convert.ToInt32(selectedRow.Cells["ParcelsId"].Value);

                using (var context = new ContextModel())
                {
                    ParcelViewModel selectedParcel = context.ParcelViewModels.FirstOrDefault(p => p.Id == id);

                    if (selectedParcel != null)
                    {
                        selectedParcel.Status = "Confirmed";
                        if (_clientViewModel != null)
                        {
                            _clientViewModel.Money -= selectedParcel.Cost;
                            context.SaveChanges();

                            DGVParcels.Rows.RemoveAt(rowIndex);
                            UpdateMoneyLabel(_clientViewModel.Money);
                        }
                    }
                }
            }
        }

        private void UpdateMoneyLabel(int amount)
        {
            if (LblMoneyClient.InvokeRequired)
            {
                Invoke(new UpdateMoneyDelegate(UpdateMoneyLabel), new object[] { amount });
            }
            else
            {
                LblMoneyClient.Text = amount.ToString();
            }
        }

        private void materialTabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl2.SelectedTab == tabPage4)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }
    }
}
