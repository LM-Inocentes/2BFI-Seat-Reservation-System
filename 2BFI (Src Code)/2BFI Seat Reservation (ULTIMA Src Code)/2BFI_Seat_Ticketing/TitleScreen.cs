using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _2BFI_Seat_Ticketing
{
    public partial class TitleScreen : Form
    {
        //Fields

        public TitleScreen()
        {
            InitializeComponent();
        }

        private void TitleScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreatePage createPage = new CreatePage();
            createPage.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadPage loadPage = new LoadPage();
            loadPage.ShowDialog();
        }

        private void TitleScreen_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TitleScreen_FormClosing);
        }

        //Form Title Bar

        //Overridden methods

        //Private methods

    }
}