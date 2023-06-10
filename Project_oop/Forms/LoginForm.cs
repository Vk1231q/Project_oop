using MaterialSkin.Controls;
using Project_oop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project_oop.Forms
{
    public partial class LoginForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public LoginForm()
        {
            InitializeComponent(); materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = LoginParcels.Text;
            string password = PasswordParcels.Text;

            if (username == "admin" && password == "admin")
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.Show();
            }
            else
            {
                using (var context = new ContextModel())
                {
                    bool userExists = context.ClientViewModels.Any(c => c.Username == username);

                    if (userExists)
                    {
                        ClientForm clientForm = new ClientForm(username);
                        this.Hide();
                        clientForm.Show();
                    }
                    else
                    {
                        var client = new ClientViewModel()
                        {
                            Username = username,
                            Password = password
                        };
                        List<string> allUsernames = context.ClientViewModels
                            .Where(c => c.Username != "admin") 
                            .Select(c => c.Username)
                            .ToList();

                        AdminForm adminForm = Application.OpenForms.OfType<AdminForm>().FirstOrDefault();
                        if (adminForm != null)
                        {
                            adminForm.AddUsernamesToComboBox(allUsernames);
                        }
                        context.ClientViewModels.Add(client);
                        context.SaveChanges();

                        MessageBox.Show("Реєстрація успішна.");
                    }
                }
            }
        }
        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl2.SelectedTab == tabPage4)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
