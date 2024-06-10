using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2BFI_Seat_Ticketing
{
    public partial class AssignPage : Form
    {
        public static int groupNum;
        public static int SeatNo = 0;
        public static int OccupiedSeats;
        public static int AvailableSeats;
        public AssignPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CreateVisuals();
            AvailableSeatsLabel.Text += ""+ AvailableSeats;
            OccupiedSeatsLabel.Text += "" + OccupiedSeats;
        }  
        private void CreateVisuals()
        {
            OccupiedSeats = 0;
            AvailableSeats = 0;
            int seatGap = 46;
            int seatCount = 1;
            Database_functions check = new();

            for (int i = 0; i < CreatePage.numRow; i++)
            {
                for (int j = 0; j < CreatePage.numCol; j++)
                {
                    var btnSeat = new SeatButton();
                    btnSeat.Location = new System.Drawing.Point((538 - (18 * (CreatePage.numCol))) + (seatGap * j), (550 - (6 *(CreatePage.numRow)) + (seatGap * i)));
                    btnSeat.Name = "seat" + seatCount.ToString();
                    btnSeat.Size = new System.Drawing.Size(45, 45);
                    btnSeat.TabIndex = 10;
                    btnSeat.Text = seatCount.ToString();

                    if (check.SeatStatus(seatCount))
                    {
                        btnSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(164)))), ((int)(((byte)(36)))));
                        btnSeat.Click += new EventHandler(ManualAssign);
                        AvailableSeats++;
                    }
                    else
                    {
                        btnSeat.Click += new EventHandler(ManualView);
                        btnSeat.BackColor = Color.Red;
                        OccupiedSeats++;
                    }


                    btnSeat.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
                    btnSeat.FlatAppearance.BorderSize = 0;
                    btnSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btnSeat.Font = new System.Drawing.Font("Montserrat", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
                    btnSeat.ForeColor = System.Drawing.Color.White;

                    btnSeat.UseVisualStyleBackColor = false;
                    btnSeat.Tag = seatCount;
                    btnSeat.SeatNumber = seatCount;
                    this.Controls.Add(btnSeat);
                    seatCount++;
                }
            }
        }

        private void AssignPage_FormClosing(object sender, FormClosingEventArgs e)
        {

        if (!string.Equals((sender as Button)?.Name, @"CloseButton"))
        {
            Environment.Exit(Environment.ExitCode);          
        }
        }

        private void AssignPage_Load_1(object sender, EventArgs e)
        {
            labelSeatNameAssign.Text = "" + CreatePage.CreationName + "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignPage_FormClosing);
        }

        private void btnSaveAssign_Click(object sender, EventArgs e)
        {
            TitleScreen back = new();
            back.Show();
            this.Dispose();
        }

        private void btnDeleteAssign_Click(object sender, EventArgs e)
        {
            Database_functions assignPage = new();
            assignPage.DeleteCreation();
            TitleScreen back = new();
            back.Show();
            this.Dispose();
        }
        private void btnIndivAssign_Click(object sender, EventArgs e)
        {
            if (SeatNo == 0)
            {
                SeatNo = 1;
            }
            Database_functions get = new();
            while (!get.SeatStatus(SeatNo))
            {
                SeatNo++;
            }
            if (AvailableSeats == 0)
            {
                labelPromptAssign.Text = "Max Limit Exceeded.";
                return;
            }
            else if (SeatNo > CreatePage.NumSeats)
            {
                get.FirstNullSeatNo();
            }
            EditInfoDetails editInfoDetails = new();
            labelPromptAssign.Text = "Assigning in progress...";
            Task.Delay(500).Wait();
            editInfoDetails.ShowDialog();
            labelPromptAssign.Text = "Welcome!";
            AssignPage refresh = new();
            refresh.Show();
            this.Dispose();
        }

        private void labelSeatNameAssign_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNoGroupAssign_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPromptAssign_Click(object sender, EventArgs e)
        {

        }

     

        private void btnGroupAssign_Click(object sender, EventArgs e)
        {
            try
            {
                groupNum = Int32.Parse(txtNoGroupAssign.Text);
            }
            catch (System.FormatException)                                    //When user clicks on group without inputting a group no.
            {
                labelPromptAssign.Text = "Please input number of people in the group";
                return;
            }
            if(groupNum < 2 || groupNum > 30)
            {
                labelPromptAssign.Text = "Group number must be at least 2 and not greater than 30";
                return;
            }
            else if (AvailableSeats < groupNum)
            {
                labelPromptAssign.Text = "Max Limit Exceeded.";
                return;
            }
            else if (SeatNo+groupNum-1 > CreatePage.NumSeats)
            {
                SeatNo = 1;
            }
            Database_functions Find = new();
            SeatNo = Find.FirstNullGroupSeatNo(SeatNo, CreatePage.NumSeats);
            if(SeatNo == 0)
            {
                labelPromptAssign.Text = "No " + groupNum + " consecutive seats available. Click again to search from start";
                return;
            }
            EditInfoDetailsGroup group = new();
            labelPromptAssign.Text = "Assigning in progress...";
            Task.Delay(500).Wait();
            group.ShowDialog();
            labelPromptAssign.Text = "Welcome!";
            AssignPage refresh = new();
            refresh.Show();
            this.Dispose();
        }

        public class SeatButton : Button
        {
            private int seatNumber;
            private bool seatOccupied;
            public int SeatNumber
            {
                get { return seatNumber; }
                set { seatNumber = value; }
            }
            public bool isOccupied
            {
                get { return seatOccupied; }
                set { seatOccupied = value; }
            }
        }

        private void ManualAssign(object sender, EventArgs e)
        {
            SeatButton? btnSeat = sender as SeatButton;
            if (btnSeat != null)
            {
                SeatNo = (int)btnSeat.Tag;
            }
            EditInfoDetails editInfoDetails = new();
            labelPromptAssign.Text = "Assigning in progress...";
            editInfoDetails.ShowDialog();
            AssignPage refresh = new();
            refresh.Show();
            this.Dispose();
            labelPromptAssign.Text = "Welcome!";
        }

        private void ManualView(object sender, EventArgs e)
        {
            SeatButton? btnSeat = sender as SeatButton;
            if (btnSeat != null)
            {
                SeatNo = (int)btnSeat.Tag;
            }
            InfoPage infoPage = new();
            labelPromptAssign.Text = "Viewing Info..";
            infoPage.ShowDialog();
            AssignPage refresh = new();
            refresh.Show();
            this.Dispose();
            labelPromptAssign.Text = "Welcome!";
        }

       
        //Form Title Bar

        //Overridden methods

        //Private methods

    }
    }