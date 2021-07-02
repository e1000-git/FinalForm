using Final_FootballReserve.Helper;
using Final_FootballReserve.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_FootballReserve
{
    public partial class AddCustomer : Form
    {
        Futbol_DB_ContextContext db = new Futbol_DB_ContextContext();
        Customer selectedCustomer;
        public AddCustomer()
        {
            InitializeComponent();
        }
        private void FillDataGrid()
        {
            dtgcustomerlist.DataSource = db.Customers.Select(x => new {
                x.Id,
                x.Name,
                x.Surname,
                x.PhoneNumber
            }).ToList();
            dtgcustomerlist.Columns[0].Visible = false;


        }
        public void ClearData()
        {
            txtname.Text = "";
            txtsurname.Text = "";
            txtnumber.Text = "";
            lblerror.Visible = false;
        }
      

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

       

        public void ShowBTN(string txt)
        {
            if (txt == "visible")
            {
                btnaddcustomer.Visible = false;
                btnedit.Visible = true;
                btndelete.Visible = true;

            }
            else
            {
                btnaddcustomer.Visible = true;
                btnedit.Visible = false;
                btndelete.Visible = false;

            }
        }
        

       

        

        private void btnaddcustomer_Click_1(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string surname = txtsurname.Text;
            string phonenumber = txtnumber.Text;
            string[] myarr = new string[] { name, surname, phonenumber };
            if (Utilities.NotEmpty(myarr))
            {
                Customer newcustomer = new Customer();
                newcustomer.Name = name;
                newcustomer.Surname = surname;
                newcustomer.PhoneNumber = phonenumber;
                db.Customers.Add(newcustomer);
                db.SaveChanges();
                MessageBox.Show("Customer was added successfully!");
                FillDataGrid();
                ClearData();
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Please fill all the fields!";
            }
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            selectedCustomer.Name = txtname.Text;
            selectedCustomer.Surname = txtsurname.Text;
            selectedCustomer.PhoneNumber = txtnumber.Text;
            db.Customers.Update(selectedCustomer);
            db.SaveChanges();
            FillDataGrid();
            ClearData();
            ShowBTN("no");
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            ShowBTN("no");
            db.Customers.RemoveRange(selectedCustomer);
            db.SaveChanges();
            FillDataGrid();
            ClearData();
        }

        private void dtgcustomerlist_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int customerID = (int)dtgcustomerlist.Rows[e.RowIndex].Cells[0].Value;
            selectedCustomer = db.Customers.FirstOrDefault(x => x.Id == customerID);
            txtname.Text = selectedCustomer.Name;
            txtsurname.Text = selectedCustomer.Surname;
            txtnumber.Text = selectedCustomer.PhoneNumber;
            ShowBTN("visible");
            btnedit.Enabled = true;
            btndelete.Enabled = true;
        }

        private void dtgcustomerlist_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            NewReserve newReserve = new NewReserve(selectedCustomer);
            newReserve.ShowDialog();
            int customerID = (int)dtgcustomerlist.Rows[e.RowIndex].Cells[0].Value;

        }

        private void txtnumber_TextChanged_1(object sender, EventArgs e)
        {
            btnaddcustomer.Enabled = true;

        }
    }
}
