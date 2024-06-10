namespace _2BFI_Seat_Ticketing
{
    partial class AssignPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignPage));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSeatNameAssign = new System.Windows.Forms.Label();
            this.btnDeleteAssign = new System.Windows.Forms.Button();
            this.btnSaveAssign = new System.Windows.Forms.Button();
            this.btnIndivAssign = new System.Windows.Forms.Button();
            this.txtNoGroupAssign = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPromptAssign = new System.Windows.Forms.Label();
            this.AvailableSeatsLabel = new System.Windows.Forms.Label();
            this.OccupiedSeatsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(71, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "2BFI SEAT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(65, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "TICKETING";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelSeatNameAssign);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 101);
            this.panel1.TabIndex = 5;
            // 
            // labelSeatNameAssign
            // 
            this.labelSeatNameAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSeatNameAssign.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSeatNameAssign.Location = new System.Drawing.Point(773, 12);
            this.labelSeatNameAssign.Name = "labelSeatNameAssign";
            this.labelSeatNameAssign.Size = new System.Drawing.Size(321, 67);
            this.labelSeatNameAssign.TabIndex = 6;
            this.labelSeatNameAssign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSeatNameAssign.Click += new System.EventHandler(this.labelSeatNameAssign_Click);
            // 
            // btnDeleteAssign
            // 
            this.btnDeleteAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDeleteAssign.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDeleteAssign.FlatAppearance.BorderSize = 0;
            this.btnDeleteAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAssign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAssign.Location = new System.Drawing.Point(969, 219);
            this.btnDeleteAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAssign.Name = "btnDeleteAssign";
            this.btnDeleteAssign.Size = new System.Drawing.Size(147, 54);
            this.btnDeleteAssign.TabIndex = 0;
            this.btnDeleteAssign.TabStop = false;
            this.btnDeleteAssign.Text = "DELETE";
            this.btnDeleteAssign.UseVisualStyleBackColor = false;
            this.btnDeleteAssign.Click += new System.EventHandler(this.btnDeleteAssign_Click);
            // 
            // btnSaveAssign
            // 
            this.btnSaveAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSaveAssign.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSaveAssign.FlatAppearance.BorderSize = 0;
            this.btnSaveAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAssign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveAssign.Location = new System.Drawing.Point(969, 150);
            this.btnSaveAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveAssign.Name = "btnSaveAssign";
            this.btnSaveAssign.Size = new System.Drawing.Size(147, 54);
            this.btnSaveAssign.TabIndex = 0;
            this.btnSaveAssign.TabStop = false;
            this.btnSaveAssign.Text = "SAVE";
            this.btnSaveAssign.UseVisualStyleBackColor = false;
            this.btnSaveAssign.Click += new System.EventHandler(this.btnSaveAssign_Click);
            // 
            // btnIndivAssign
            // 
            this.btnIndivAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnIndivAssign.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnIndivAssign.FlatAppearance.BorderSize = 0;
            this.btnIndivAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndivAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIndivAssign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIndivAssign.Location = new System.Drawing.Point(422, 214);
            this.btnIndivAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIndivAssign.Name = "btnIndivAssign";
            this.btnIndivAssign.Size = new System.Drawing.Size(188, 54);
            this.btnIndivAssign.TabIndex = 0;
            this.btnIndivAssign.TabStop = false;
            this.btnIndivAssign.Text = "Individual";
            this.btnIndivAssign.UseVisualStyleBackColor = false;
            this.btnIndivAssign.Click += new System.EventHandler(this.btnIndivAssign_Click);
            // 
            // txtNoGroupAssign
            // 
            this.txtNoGroupAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtNoGroupAssign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoGroupAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNoGroupAssign.Location = new System.Drawing.Point(752, 219);
            this.txtNoGroupAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoGroupAssign.Name = "txtNoGroupAssign";
            this.txtNoGroupAssign.Size = new System.Drawing.Size(66, 40);
            this.txtNoGroupAssign.TabIndex = 7;
            this.txtNoGroupAssign.TextChanged += new System.EventHandler(this.txtNoGroupAssign_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(136, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 36);
            this.label9.TabIndex = 6;
            this.label9.Text = "Automatic Assign:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(639, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "Group";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnGroupAssign_Click);
            // 
            // labelPromptAssign
            // 
            this.labelPromptAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPromptAssign.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPromptAssign.Location = new System.Drawing.Point(412, 107);
            this.labelPromptAssign.Name = "labelPromptAssign";
            this.labelPromptAssign.Size = new System.Drawing.Size(406, 94);
            this.labelPromptAssign.TabIndex = 8;
            this.labelPromptAssign.Text = "Welcome!";
            this.labelPromptAssign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPromptAssign.Click += new System.EventHandler(this.labelPromptAssign_Click);
            // 
            // AvailableSeatsLabel
            // 
            this.AvailableSeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvailableSeatsLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.AvailableSeatsLabel.Location = new System.Drawing.Point(136, 120);
            this.AvailableSeatsLabel.Name = "AvailableSeatsLabel";
            this.AvailableSeatsLabel.Size = new System.Drawing.Size(247, 42);
            this.AvailableSeatsLabel.TabIndex = 11;
            this.AvailableSeatsLabel.Text = "Available Seats:";
            this.AvailableSeatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OccupiedSeatsLabel
            // 
            this.OccupiedSeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OccupiedSeatsLabel.ForeColor = System.Drawing.Color.Salmon;
            this.OccupiedSeatsLabel.Location = new System.Drawing.Point(136, 159);
            this.OccupiedSeatsLabel.Name = "OccupiedSeatsLabel";
            this.OccupiedSeatsLabel.Size = new System.Drawing.Size(247, 42);
            this.OccupiedSeatsLabel.TabIndex = 12;
            this.OccupiedSeatsLabel.Text = "Occupied Seats:";
            this.OccupiedSeatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AssignPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1354, 853);
            this.Controls.Add(this.OccupiedSeatsLabel);
            this.Controls.Add(this.AvailableSeatsLabel);
            this.Controls.Add(this.labelPromptAssign);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNoGroupAssign);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIndivAssign);
            this.Controls.Add(this.btnSaveAssign);
            this.Controls.Add(this.btnDeleteAssign);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1080, 768);
            this.Name = "AssignPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2BFI Seat Ticketing";
            this.Load += new System.EventHandler(this.AssignPage_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private Button btnDeleteAssign;
        private Button btnSaveAssign;
        private Button btnIndivAssign;
        private TextBox txtNoGroupAssign;
        private Label labelSeatNameAssign;
        private Label label9;
        private Button button1;
        private Label labelPromptAssign;
        private Label AvailableSeatsLabel;
        private Label OccupiedSeatsLabel;
    }
}