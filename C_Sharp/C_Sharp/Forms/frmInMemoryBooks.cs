
using InMemoryDB;

namespace C_Sharp.Forms
{
    public partial class frmInMemoryBooks : Form
    {
        static InMemoryDataBase dataBase = new InMemoryDataBase();//static to preserve modified data
        public frmInMemoryBooks()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {

           // dataBase = new InMemoryDataBase();
            foreach (var item in dataBase.Books)
            {
                gridBooks.Rows.Add(item.Id, item.Title, item.PublishingYear, item.Author.FullName);

            }
        }

        private void btnFrmNewBook_Click(object sender, EventArgs e)
        {
            var frmNewBook = new frmNewInBook(dataBase, this);
            frmNewBook.Show();

        }
    }
}
