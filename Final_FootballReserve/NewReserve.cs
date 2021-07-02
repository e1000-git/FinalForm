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
    public partial class NewReserve : Form
    {
        Futbol_DB_ContextContext db = new Futbol_DB_ContextContext();
        Customer activeCustomer;
        Room selectedRoom;
        public NewReserve(Customer customer)
        {
            activeCustomer = customer;
            InitializeComponent();
        }
        public void FillStadium()
        {
            cmbstadium.Items.AddRange(db.Stadia.Select(x => x.Name).ToArray());
        }
        public void FillTime()
        {
            cmbtime.Items.AddRange(db.TimeZones.Select(x => x.Timezone1).ToArray());
        }
        public void FillRoom()
        {
            cmbroom.Items.AddRange(db.Rooms.Where(x=> x.Capacity>=nmrpeople.Value).Select(x => x.Name).ToArray());
        }
        public void ClearData()
        {
            cmbtime.Text = "";
            cmbstadium.Text = "";
            cmbroom.Text = "";
            nmrpeople.Value = 1;
            //lblprice = "";
        }

        private void NewReserve_Load(object sender, EventArgs e)
        {
            FillStadium();
            FillRoom();
            FillTime();
            lblcustomer.Visible = true;
        }

      
        private void btnreserve_Click_1(object sender, EventArgs e)
        {
            DateTime date = datepicker.Value;
            string time = cmbtime.Text;
            string stadium = cmbstadium.Text;
            string room = cmbroom.Text;
            lblprice.Text = "Price is " + nmrpeople.Value * 5 + "Azn";
            string[] myarr2 = new string[] { time, stadium, room };
            if (Utilities.NotEmpty(myarr2))
            {
                Reservation newreserve = new Reservation();
                newreserve.CustomerId = activeCustomer.Id;
                newreserve.Date = date;
                newreserve.RoomId = db.Rooms.FirstOrDefault(x => x.Name == cmbroom.Text).Id;
                newreserve.StadiumId = db.Stadia.FirstOrDefault(x => x.Name == cmbstadium.Text).Id;
                newreserve.TimeId = db.TimeZones.FirstOrDefault(x => x.Timezone1 == cmbtime.Text).Id;
                newreserve.Price = nmrpeople.Value * 5;
                db.Reservations.Add(newreserve);
                db.SaveChanges();
                MessageBox.Show("Reservation was created successfully!");

            }
            else
            {
                MessageBox.Show("Please fill all the fields!");

            }
        }

        private void nmrpeople_ValueChanged(object sender, EventArgs e)
        {
            lblcustomer.Text = activeCustomer.Name + " " + activeCustomer.Surname;
            ClearData();
            FillRoom();
        }
    }
}

