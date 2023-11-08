using IMS_project_prn221.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IMS_project_prn221
{
    /// <summary>
    /// Interaction logic for AddEmployees.xaml
    /// </summary>
    public partial class AddEmployees : Window
    {
        private readonly InventoryManagementContext _context = new InventoryManagementContext();
        List<Staff> listStaffs = new List<Staff>();
        public AddEmployees()
        {
            InitializeComponent();
            LoadRoles();
            LoadData();
        }
        private void LoadData()
        {
            listStaffs = _context.Staff.Include(x => x.Role).ToList();
            EmployeeListsView.ItemsSource = listStaffs;
        }

        private void LoadRoles()
        {
            try
            {
                using (InventoryManagementContext context = new InventoryManagementContext()) // Thay thế YourDbContext bằng đối tượng DbContext của bạn
                {
                    // Lấy danh sách các vai trò từ cơ sở dữ liệu
                    List<Role> roles = context.Roles.ToList();
                    List<String> listRole = roles.Select(x=>x.RoleName).ToList();

                    // Gán danh sách các vai trò cho ComboBox
                    cmbRole.ItemsSource = listRole;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách vai trò: " + ex.Message);
            }
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtAddress.Text;
            int phone = int.Parse(txtPhone.Text);
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            Role selectedRole = (Role)cmbRole.SelectedItem;


            // gán thông tin lấy từ form
            Staff newEmployee = new Staff
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Phone = phone,
                Email = email,
                UserName = username,
                PassWord = password,
                RoleId = selectedRole.RoleId
            };
            _context.Staff.Add(newEmployee);
            _context.SaveChanges();

            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            LoadData();
            MessageBox.Show("add successfully!!");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button deleteButton = (Button)sender;
            var employee = deleteButton.Tag as Staff;
            if (employee != null)
            {
                _context.Staff.Remove(employee);
                _context.SaveChanges(true);
                LoadData();
                MessageBox.Show($"{employee.LastName+employee.FirstName } have been deleted ");
            }
        } 
    }
}
