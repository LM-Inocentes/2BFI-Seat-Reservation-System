using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2BFI_Seat_Ticketing
{
    public partial class InfoPage : Form
    {
        public static string NameInfo = null!;
        public static string DateAssigned = null!;
        public static int InfoSeatNo;
        public InfoPage()
        {
            InitializeComponent();
            this.ControlBox = true;
            Display();
        }
        private void Display()
        {
            Database_functions database_Functions = new();
            database_Functions.GetInfo();
            Namelabel.Text += " " + NameInfo;
            Datelabel.Text += " " + DateAssigned;
            labelSeatNo.Text += "" + InfoSeatNo.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database_functions database_Functions = new();
            database_Functions.DeleteInfo();
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            EditInfoDetails edit = new();
            edit.ShowDialog();
            
        }
    }
}
