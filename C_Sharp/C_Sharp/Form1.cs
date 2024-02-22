using C_Sharp.Forms;

namespace C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            var frmDel = new frmDelegate();
            frmDel.ShowDialog();
        }
    }
}
