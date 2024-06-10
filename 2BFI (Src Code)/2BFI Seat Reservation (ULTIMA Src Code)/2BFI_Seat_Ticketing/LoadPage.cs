using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2BFI_Seat_Ticketing
{
    public partial class LoadPage : Form
    {
        public LoadPage()
        {
            InitializeComponent();
        }

        private void listSeatLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadPage_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            string sql = "SELECT name FROM sqlite_schema WHERE type = 'table' AND name NOT LIKE 'sqlite_%'";
            Database_functions load = new();
            load.ConnectToDatabase();
            using SQLiteCommand command = new(sql, load.m_dbConnection);
            using SQLiteDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                listSeatLoad.Items.Add(read.GetString(0));
            }
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            if (listSeatLoad.SelectedItem == null)                  //Clicking load w/o selecting anything
            {
                return;
            }
            CreatePage.CreationName = listSeatLoad.GetItemText(listSeatLoad.SelectedItem); 
            string sql = "SELECT TotalSeats, Col, Row FROM " + CreatePage.CreationName+ " WHERE SeatNo = 1";
            Database_functions load = new();
            load.ConnectToDatabase();
            using SQLiteCommand command = new(sql, load.m_dbConnection);
            using (SQLiteDataReader read = command.ExecuteReader()) 
            {
                while (read.Read())
                {
                    CreatePage.NumSeats = read.GetInt32(0);
                    CreatePage.numCol = read.GetInt32(1);
                    CreatePage.numRow = read.GetInt32(2);
                    break;
                }
            }
            load.FirstNullSeatNo();
            if(AssignPage.SeatNo == 0)
            {
                AssignPage.SeatNo = 1;
            }
            AssignPage AssignLoad = new();
            AssignLoad.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listSeatLoad.SelectedItem == null)                  //Clicking load w/o selecting anything
            {
                return;
            }
            CreatePage.CreationName = listSeatLoad.GetItemText(listSeatLoad.SelectedItem);
            Database_functions load = new();
            load.ConnectToDatabase();
            load.DeleteCreation();
            LoadPage refresh = new();
            refresh.Show();
            this.Dispose();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            TitleScreen back = new();
            this.Dispose();
            back.Show();
        }

        //Form Title Bar

        //Overridden methods

        //Private methods

    }
}