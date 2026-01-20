using System.ComponentModel;
using System.Drawing;
using System.Text;

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

            btnAddContact.Enabled = false;
            btnUpdateContact.Enabled = false;
            btnRemoveSelected.Enabled = false;

            lblStatus.Text = "Ready";
            UpdateCounts();
        }

        private void InitializeDataBinding()
        {
            _contactsSource = new BindingSource();
            _contactsSource.DataSource = _contacts;
            dgContacts.DataSource = _contactsSource;

            ConfigureDataGridViewColumns();
            UpdateCounts();

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
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                lblStatus.Text = "Full name is required!";
                return;
            }

            if (_contacts.Any(c => c.Email == txtEmail.Text))
            {
                lblStatus.Text = "Email already exists!";
                return;
            }

            Contact contact = new Contact
            {
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Phone = mtbPhone.Text,
                Gender = cmbGender.Text,
                BirthDate = dtpBirthDate.Value
            };

            _contacts.Add(contact);

            lblStatus.Text = $"Added: {contact.FullName}";
            UpdateCounts();
            ClearInputs();
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            if (_contactsSource.Current is not Contact selected)
            {
                lblStatus.Text = "No contact selected!";
                return;
            }

            selected.FullName = txtFullName.Text;
            selected.Email = txtEmail.Text;
            selected.Phone = mtbPhone.Text;
            selected.Gender = cmbGender.Text;
            selected.BirthDate = dtpBirthDate.Value;

            _contactsSource.ResetCurrentItem();

            lblStatus.Text = $"Updated: {selected.FullName}";
            UpdateCounts();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (_contactsSource.Current is not Contact selected)
            {
                lblStatus.Text = "No contact selected!";
                return;
            }

            _contacts.Remove(selected);

            lblStatus.Text = "Contact removed!";
            UpdateCounts();
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
            UpdateCounts();
            statusStrip1.Text = "All contacts cleared!";
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            var filtered = _contacts
                .Where(c =>
                    (cmbFilterGender.Text == "All" || c.Gender == cmbFilterGender.Text) &&
                    (c.FullName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                     c.Email.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            _contactsSource.DataSource = new BindingList<Contact>(filtered);

            lblStatus.Text = "Filter applied!";
            UpdateCounts();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            _contactsSource.DataSource = _contacts;
            lblStatus.Text = "Filter reset!";
            UpdateCounts();
        }

        private void dgContacts_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dgContacts.SelectedRows.Count > 0;

            btnUpdateContact.Enabled = hasSelection;
            btnRemoveSelected.Enabled = hasSelection;

            if (!hasSelection) return;

            var c = dgContacts.SelectedRows[0].DataBoundItem as Contact;
            if (c == null) return;

            txtFullName.Text = c.FullName;
            txtEmail.Text = c.Email;
            mtbPhone.Text = c.Phone;
            cmbGender.Text = c.Gender;
            dtpBirthDate.Value = c.BirthDate ?? DateTime.Today;

            statusStrip1.Text = $"{c.FullName} | Email: {c.Email}";
        }
        private void InputChanged(object sender, EventArgs e)
        {
            btnAddContact.Enabled = ValidateInputs();
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
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.Title = "Export to CSV";
                sfd.FileName = "Contacts.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportDataGridViewToCSV(dgContacts, sfd.FileName);
                        MessageBox.Show("Export successful!", "CSV Export",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error exporting CSV:\n" + ex.Message,
                            "Export Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ExportDataGridViewToCSV(DataGridView dgv, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // Headers
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(dgv.Columns[i].HeaderText);
                if (i < dgv.Columns.Count - 1)
                    sb.Append(",");
            }
            sb.AppendLine();

            // Rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sb.Append(row.Cells[i].Value?.ToString());
                        if (i < dgv.Columns.Count - 1)
                            sb.Append(",");
                    }
                    sb.AppendLine();
                }
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }
        private void UpdateCounts()
        {
            lblCounts.Text = $"Visible: {_contactsSource.Count} / Total: {_contacts.Count}";
        }
        private void DisplayStatus(string message)
        {
            lblStatus.Text = message;
        }
    }
}