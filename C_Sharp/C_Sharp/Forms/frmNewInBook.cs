using InMemoryDB;


namespace C_Sharp.Forms
{
    public partial class frmNewInBook : Form
    {
        private InMemoryDataBase _data;
        private frmInMemoryBooks _bookForm;
        public frmNewInBook(InMemoryDataBase dataBase, frmInMemoryBooks bookForm)
        {
            InitializeComponent();
            _data = dataBase;
            InitializeAuthors();
            _bookForm = bookForm;
        }

        private void InitializeAuthors()
        {
            foreach (var auth in _data.Authors)
            {
                cmbAuthor.Items.Add(auth.Id + ". " + auth.FullName);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (ValidateField())
            {

                int authorindex = int.Parse(cmbAuthor.Text.Substring(0,1));
                _data.Books.Add(new InMemoryDB.Entities.Book()
                {
                    Id = _data.Books.Count + 1,
                    Title = txtTitle.Text,
                    PublishingYear = int.Parse(txtPubYear.Text),
                    Author = _data.Authors[authorindex-1]
                });
                MessageBox.Show("Successfully added book.");
                this.Close();
                _bookForm.Close();
                var frmBook= new frmInMemoryBooks();
                frmBook.Show();
            }
            else
            {
                MessageBox.Show("Error");

            }


        }

        private bool ValidateField()
        {
            if (cmbAuthor.SelectedItem == null) return false;
            if (string.IsNullOrWhiteSpace(txtTitle.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtPubYear.Text) || int.TryParse(txtPubYear.Text, out int num) == false) return false;

            return true;
        }
    }
}
