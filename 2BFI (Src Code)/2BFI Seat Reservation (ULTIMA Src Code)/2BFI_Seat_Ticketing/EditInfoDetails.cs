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
    public partial class EditInfoDetails : Form
    {
        public EditInfoDetails()
        {
            InitializeComponent();
        }

        private void btnAssignEditInfo_Click(object sender, EventArgs e)
        {
            string NameInfo, DateAssigned;
            NameInfo = txtNameEditInfo.Text;
            DateAssigned = dateIndivEditInfo.Value.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            Database_functions info = new();
            info.AddInfo(NameInfo, DateAssigned);
            AssignPage.SeatNo++;
            this.Dispose();
        }

        private void btnCancelEditInfo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditInfoDetails_Load(object sender, EventArgs e)
        {
            labelSeatNoEditInfo.Text = "Seat #" +(AssignPage.SeatNo);
            this.ControlBox = false;
        }

       
    }
}
