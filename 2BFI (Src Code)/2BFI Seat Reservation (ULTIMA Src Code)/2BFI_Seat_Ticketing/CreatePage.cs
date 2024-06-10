using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2BFI_Seat_Ticketing
{
    public partial class CreatePage : Form
    {
        //Fields
        public static String CreationName = null!;
        public static int NumSeats;
        public static int numCol;
        public static int numRow;
        public CreatePage()
        {
            InitializeComponent();
        }

        private void btnCreatePlan_Click(object sender, EventArgs e)
        {
            int calNumSeats;
            AssignPage.SeatNo = 1;
            if (String.IsNullOrEmpty(txtCreationName.Text) || String.IsNullOrEmpty(txtNoSeats.Text) || String.IsNullOrEmpty(txtNoCol.Text) ||
                String.IsNullOrEmpty(txtNoRow.Text))
            {
                labelPromptCreate.Text = "All fields must not be empty.";
            }
            else
            {
                NumSeats = Int32.Parse(txtNoSeats.Text);
                numCol = Int32.Parse(txtNoCol.Text);
                numRow = Int32.Parse(txtNoRow.Text);
                CreationName = txtCreationName.Text;
                calNumSeats = numCol * numRow;

                if (NumSeats > 900 || numCol >30 || numRow > 30)
                {
                    labelPromptCreate.Text = "Maximum seat limit is 900\nMaximum number of column is 30\nMaximum number of row is 30";
                }
                else if (NumSeats < 1 || numCol < 1 || numRow < 1)
                {
                    labelPromptCreate.Text = "Amount must not be less than 1 or greater than the number of seats.";
                }
                else if (calNumSeats != NumSeats)
                {
                    labelPromptCreate.Text = String.Format("Invalid row or column value.\nSuggested number of seats: {0}", calNumSeats);
                }
                else
                {
                    labelPromptCreate.Text = "Success! Please wait...";
                    //transferring data to database
                    CreationName = CreationName.Replace(" ", "_");     //Replace spaces with underscore to prevent SQL logic error
                    Database_functions createpage = new();
                    createpage.NewCreation();
                    Task.Delay(500).Wait();
                    AssignPage assignPage = new();
                    assignPage.Show();
                    this.Dispose();
                }
            }
            //Form Title Bar

            //Overridden methods

            //Private methods

        }

        private void CreatePage_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}