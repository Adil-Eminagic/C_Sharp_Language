using InMemoryDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp.Forms
{
    public partial class frmNewInBook : Form
    {
        private InMemoryDataBase _data;
        public frmNewInBook(InMemoryDataBase dataBase)
        {
            InitializeComponent();
            _data = dataBase;
            InitializeAuthors();
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
                string author= cmbAuthor.SelectedItem.ToString();
                _data.Books.Add(new InMemoryDB.Entities.Book()
                {
                    Id = _data.Books.Count + 1,
                    Title = txtTitle.Text,
                    PublishingYear = int.Parse(txtPubYear.Text),
                    Author = _data.Authors[author[0]]
                });
            }

               
        }

        private bool ValidateField()
        {
            if (cmbAuthor.SelectedItem == null) return false;
            if (string.IsNullOrWhiteSpace(txtTitle.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || int.TryParse(txtTitle.Text, out int num) == false) return false;

            return true;
        }
    }
}
