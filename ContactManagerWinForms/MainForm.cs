using System.Drawing;
using System.ComponentModel;

namespace ContactManagerWinForms
{
    public partial class MainForm : Form
    {
        // In-memory data store
        private readonly BindingList<Contact> _contacts = new();

        // Binding source for DataGridView (supports filtering & sorting)
        private BindingSource _contactsSource;
        public MainForm()
        {
            InitializeComponent();
            InitializeDataBinding();
        }

        private void InitializeDataBinding()
        {
            _contactsSource = new BindingSource();
            _contactsSource.DataSource = _contacts;

            dgContacts.DataSource = _contactsSource;

            ConfigureDataGridViewColumns();
            UpdateStatusCounts();

            _contacts.Add(new Contact
            {
                FullName = "Juan Dela Cruz",
                Email = "juan@example.com",
                Phone = "09171234567",
                Gender = "Male",
                BirthDate = new DateTime(2000, 1, 1)
            });

            dgContacts.AutoGenerateColumns = false;
        }

        private void ConfigureDataGridViewColumns()
        {
            colFullName.DataPropertyName = nameof(Contact.FullName);
            colEmail.DataPropertyName = nameof(Contact.Email);
            colPhone.DataPropertyName = nameof(Contact.Phone);
            colGender.DataPropertyName = nameof(Contact.Gender);
            colBirthDate.DataPropertyName = nameof(Contact.BirthDate);
            colCreatedAt.DataPropertyName = nameof(Contact.CreatedAt);

            colBirthDate.DefaultCellStyle.Format = "d";
            colCreatedAt.DefaultCellStyle.Format = "g";
        }

        private void UpdateStatusCounts()
        {
            lblCounts.Text = $"Visible: {_contactsSource.Count} / Total: {_contacts.Count}";
        }
    }
}
