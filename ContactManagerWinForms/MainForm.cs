using System.ComponentModel;
using System.Drawing;

namespace ContactManagerWinForms
{
    public partial class MainForm : Form
    {
        private readonly BindingList<Contact> _contacts = new();
        private BindingSource _contactsSource;
        public MainForm()
        {
            InitializeComponent();
            InitializeDataBinding();
        }

        private void InitializeDataBinding()
        {
            dgContacts.AutoGenerateColumns = false;

            _contactsSource = new BindingSource();
            _contactsSource.DataSource = _contacts;

            dgContacts.DataSource = _contactsSource;

            ConfigureDataGridViewColumns();
            UpdateStatusCounts();

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

        private bool ValidateInputs(Contact ignoreContact = null)
        {
            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Full name is required!");
                isValid = false;
            }
            else if (txtFullName.Text.Any(char.IsDigit))
            {
                errorProvider.SetError(txtFullName, "Full name must not contain digits...");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Email is required!");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtEmail.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(txtEmail, "Invalid email format!");
                isValid = false;
            }
            else
            {
                bool duplicate = _contacts.Any(c =>
                    c.Email.Equals(txtEmail.Text, StringComparison.OrdinalIgnoreCase)
                    && c != ignoreContact);

                if (duplicate)
                {
                    errorProvider.SetError(txtEmail, "Email already exists!");
                    isValid = false;
                }
            }

            if (cmbGender.SelectedIndex < 0)
            {
                errorProvider.SetError(cmbGender, "Select gender");
                isValid = false;
            }

            return isValid;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                lblStatus.Text = "Validation failed! Please fix errors...";
                return;
            }

            var contact = new Contact
            {
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = mtbPhone.Text,
                Gender = cmbGender.Text,
                BirthDate = dtpBirthDate.Value
            };

            _contacts.Add(contact);

            ClearInputs();
            UpdateStatusCounts();

            lblStatus.Text = $"Added: {contact.FullName}";
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            if (dgContacts.SelectedRows.Count == 0)
            {
                lblStatus.Text = "No contact selected!";
                return;
            }

            var selected = dgContacts.SelectedRows[0].DataBoundItem as Contact;
            if (selected == null) return;

            if (!ValidateInputs(selected))
            {
                lblStatus.Text = "Validation failed! Cannot update...";
                return;
            }

            selected.FullName = txtFullName.Text.Trim();
            selected.Email = txtEmail.Text.Trim();
            selected.Phone = mtbPhone.Text;
            selected.Gender = cmbGender.Text;
            selected.BirthDate = dtpBirthDate.Value;

            _contactsSource.ResetBindings(false);
            UpdateStatusCounts();

            lblStatus.Text = $"Updated: {selected.FullName}";
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgContacts.SelectedRows.Count == 0)
            {
                lblStatus.Text = "No contact selected!";
                return;
            }

            if (chkConfirmDelete.Checked)
            {
                var confirm = MessageBox.Show(
                    "Are you sure you want to delete the selected contact?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;
            }

            var contact = dgContacts.SelectedRows[0].DataBoundItem as Contact;
            if (contact != null)
                _contacts.Remove(contact);

            UpdateStatusCounts();
            lblStatus.Text = "Contact removed!";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (_contacts.Count == 0) return;

            var confirm = MessageBox.Show(
                "Clear all contacts?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            _contacts.Clear();
            UpdateStatusCounts();
            lblStatus.Text = "All contacts cleared!";
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string gender = cmbFilterGender.Text;
            string search = txtSearch.Text.Trim().ToLower();

            var filtered = _contacts.Where(c =>
                (gender == "All" || c.Gender == gender) &&
                (string.IsNullOrEmpty(search) ||
                 c.FullName.ToLower().Contains(search) ||
                 c.Email.ToLower().Contains(search))
            ).ToList();

            _contactsSource.DataSource = new BindingList<Contact>(filtered);
            UpdateStatusCounts();

            lblStatus.Text = "Filter applied!";
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            cmbFilterGender.SelectedIndex = 0;
            txtSearch.Clear();

            _contactsSource.DataSource = _contacts;
            UpdateStatusCounts();

            lblStatus.Text = "Filter reset!";
        }

        private void dgContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgContacts.SelectedRows.Count == 0) return;

            var c = dgContacts.SelectedRows[0].DataBoundItem as Contact;
            if (c == null) return;

            txtFullName.Text = c.FullName;
            txtEmail.Text = c.Email;
            mtbPhone.Text = c.Phone;
            cmbGender.Text = c.Gender;
            dtpBirthDate.Value = c.BirthDate ?? DateTime.Today;

            lblStatus.Text = $"{c.FullName} | Email: {c.Email}";
        }
        private void InputChanged(object sender, EventArgs e)
        {
            bool valid = ValidateInputs();

            btnAddContact.Enabled = valid;
            btnUpdateContact.Enabled = valid && dgContacts.SelectedRows.Count > 0;
        }

        private void ClearInputs()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            mtbPhone.Clear();
            cmbGender.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Today;
            errorProvider.Clear();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "Contacts.csv"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            var lines = new List<string>
            {
                "FullName,Email,Phone,Gender,BirthDate,CreatedAt"
            };

            foreach (var c in (List<Contact>)dgContacts.DataSource)
            {
                lines.Add($"{c.FullName},{c.Email},{c.Phone},{c.Gender},{c.BirthDate:d},{c.CreatedAt:g}");
            }

            File.WriteAllLines(sfd.FileName, lines);
            MessageBox.Show("Export successful!");
        }
        private void UpdateStatusCounts()
        {
            lblCounts.Text = $"Visible: {_contactsSource.Count} / Total: {_contacts.Count}";
        }
    }
}