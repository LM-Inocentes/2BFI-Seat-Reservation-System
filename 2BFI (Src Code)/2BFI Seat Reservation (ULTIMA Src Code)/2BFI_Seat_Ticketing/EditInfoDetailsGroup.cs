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
    public partial class EditInfoDetailsGroup : Form
    {
        public EditInfoDetailsGroup()
        {
            InitializeComponent();
            //MessageBox.Show(thisGroupNum.ToString());
            int gap = 180;
            for (int i = 0; i < AssignPage.groupNum; i++)
            {
                //Name TextBox
                var txtRun = new TextBox
                {
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Name = "txtName" + i.ToString(),
                    Location = new System.Drawing.Point(128, 73 + (gap * i)),
                    Size = new System.Drawing.Size(247, 29)
                };
                // Add the textbox control to the form's control collection         
                this.Controls.Add(txtRun);


                //Name Label
                var labelRun1 = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(27, 69 + (gap * i)),
                    Name = "labelName" + i.ToString(),
                    Size = new System.Drawing.Size(93, 33),
                    TabIndex = 0,
                    Text = "Name:"
                };
                this.Controls.Add(labelRun1);

                //Date Label
                var labelRun2 = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(42, 117 + (gap * i)),
                    Name = "labelDate" + i.ToString(),
                    Size = new System.Drawing.Size(78, 33),
                    TabIndex = 0,
                    Text = "Date:"
                };
                this.Controls.Add(labelRun2);

                //Seat Label
                var labelRun3 = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(152, 21 + (gap * i)),
                    Name = "labelSeat" + i.ToString(),
                    Size = new System.Drawing.Size(100, 33),
                    TabIndex = 0,
                    Text = "Seat # " + (i + AssignPage.SeatNo).ToString()
                };
                this.Controls.Add(labelRun3);

                //Seat Date
                var dateRun = new DateTimePicker
                {
                    CustomFormat = "MMM dd yyyy",
                    Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Format = System.Windows.Forms.DateTimePickerFormat.Custom,
                    ImeMode = System.Windows.Forms.ImeMode.NoControl,
                    Location = new System.Drawing.Point(128, 113 + (gap * i)),
                    Name = "dateSeat" + i.ToString(),
                    Size = new System.Drawing.Size(247, 36),
                    TabIndex = 3
                };
                this.Controls.Add(dateRun);
            }

            //Buttons
            var btnCancel = new Button();
            btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Open Sans Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnCancel.Location = new System.Drawing.Point(27, 183 + (gap * (AssignPage.groupNum - 1)));
            btnCancel.Name = "btnCancelEditInfoGroup";
            btnCancel.Size = new System.Drawing.Size(151, 51);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            this.Controls.Add(btnCancel);

            var btnAssign = new Button();
            btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            btnAssign.FlatAppearance.BorderSize = 0;
            btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAssign.Font = new System.Drawing.Font("Open Sans Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAssign.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnAssign.Location = new System.Drawing.Point(223, 183 + (gap * (AssignPage.groupNum - 1)));
            btnAssign.Name = "btnAssignEditInfoGroup";
            btnAssign.Size = new System.Drawing.Size(151, 51);
            btnAssign.TabIndex = 1;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += new System.EventHandler(btnAssign_Click);
            this.Controls.Add(btnAssign);
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string NameInfo, DateAssigned;
            Database_functions info = new();
            for (int i = 0; i < AssignPage.groupNum; i++)
            {
                NameInfo = ((TextBox)this.Controls["TxtName" + i.ToString()]).Text;
                DateAssigned = ((DateTimePicker)this.Controls["dateSeat" + i.ToString()]).Value.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                info.AddInfo(NameInfo, DateAssigned);
                AssignPage.SeatNo++;
            }
            this.Dispose();
        } 

        private void EditInfoDetailsGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
