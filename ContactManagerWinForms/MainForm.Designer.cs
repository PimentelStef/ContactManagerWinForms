namespace ContactManagerWinForms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            grpInput = new GroupBox();
            btnUpdateContact = new Button();
            btnAddContact = new Button();
            dtpBirthDate = new DateTimePicker();
            label5 = new Label();
            cmbGender = new ComboBox();
            label4 = new Label();
            mtbPhone = new MaskedTextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            grpActions = new GroupBox();
            btnExportCsv = new Button();
            chkConfirmDelete = new CheckBox();
            btnClearAll = new Button();
            btnRemoveSelected = new Button();
            grpFilter = new GroupBox();
            btnResetFilter = new Button();
            btnApplyFilter = new Button();
            txtSearch = new TextBox();
            cmbFilterGender = new ComboBox();
            dgContacts = new DataGridView();
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colBirthDate = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            errorProvider = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblCounts = new ToolStripStatusLabel();
            grpInput.SuspendLayout();
            grpActions.SuspendLayout();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnUpdateContact);
            grpInput.Controls.Add(btnAddContact);
            grpInput.Controls.Add(dtpBirthDate);
            grpInput.Controls.Add(label5);
            grpInput.Controls.Add(cmbGender);
            grpInput.Controls.Add(label4);
            grpInput.Controls.Add(mtbPhone);
            grpInput.Controls.Add(label3);
            grpInput.Controls.Add(txtEmail);
            grpInput.Controls.Add(label2);
            grpInput.Controls.Add(txtFullName);
            grpInput.Controls.Add(label1);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(450, 230);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Add/Update Contact";
            // 
            // btnUpdateContact
            // 
            btnUpdateContact.Enabled = false;
            btnUpdateContact.Location = new Point(212, 174);
            btnUpdateContact.Name = "btnUpdateContact";
            btnUpdateContact.Size = new Size(136, 23);
            btnUpdateContact.TabIndex = 11;
            btnUpdateContact.Text = "Update Selected";
            btnUpdateContact.UseVisualStyleBackColor = true;
            btnUpdateContact.Click += btnUpdateContact_Click;
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(51, 174);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(136, 23);
            btnAddContact.TabIndex = 10;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(6, 125);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(107, 23);
            dtpBirthDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 107);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "Birth Date";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Non-binary", "Prefer not to say" });
            cmbGender.Location = new Point(212, 81);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(181, 23);
            cmbGender.TabIndex = 7;
            cmbGender.SelectedIndexChanged += InputChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 63);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(6, 81);
            mtbPhone.Mask = "00000000000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(181, 23);
            mtbPhone.TabIndex = 5;
            mtbPhone.TextChanged += InputChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(212, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "name@example.com";
            txtEmail.Size = new Size(181, 23);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += InputChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 19);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(6, 37);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Juan Dela Cruz";
            txtFullName.Size = new Size(181, 23);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += InputChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnExportCsv);
            grpActions.Controls.Add(chkConfirmDelete);
            grpActions.Controls.Add(btnClearAll);
            grpActions.Controls.Add(btnRemoveSelected);
            grpActions.Location = new Point(12, 248);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(450, 130);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Actions";
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(120, 91);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(153, 23);
            btnExportCsv.TabIndex = 3;
            btnExportCsv.Text = "Export Visible to CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Checked = true;
            chkConfirmDelete.CheckState = CheckState.Checked;
            chkConfirmDelete.Location = new Point(120, 51);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(153, 19);
            chkConfirmDelete.TabIndex = 2;
            chkConfirmDelete.Text = "Confirm before deletion";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(212, 22);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(136, 23);
            btnClearAll.TabIndex = 1;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Enabled = false;
            btnRemoveSelected.Location = new Point(51, 22);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(136, 23);
            btnRemoveSelected.TabIndex = 0;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnResetFilter);
            grpFilter.Controls.Add(btnApplyFilter);
            grpFilter.Controls.Add(txtSearch);
            grpFilter.Controls.Add(cmbFilterGender);
            grpFilter.Location = new Point(522, 12);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(450, 130);
            grpFilter.TabIndex = 2;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter/Search";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(209, 90);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(98, 23);
            btnResetFilter.TabIndex = 3;
            btnResetFilter.Text = "Reset Filter";
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(105, 90);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(98, 23);
            btnApplyFilter.TabIndex = 2;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Name or Email...";
            txtSearch.Size = new Size(301, 23);
            txtSearch.TabIndex = 1;
            // 
            // cmbFilterGender
            // 
            cmbFilterGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterGender.FormattingEnabled = true;
            cmbFilterGender.Items.AddRange(new object[] { "All", "Male", "Female", "Non-binary", "Prefer not to say" });
            cmbFilterGender.Location = new Point(6, 48);
            cmbFilterGender.Name = "cmbFilterGender";
            cmbFilterGender.Size = new Size(121, 23);
            cmbFilterGender.TabIndex = 0;
            // 
            // dgContacts
            // 
            dgContacts.AllowUserToAddRows = false;
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Columns.AddRange(new DataGridViewColumn[] { colFullName, colEmail, colPhone, colGender, colBirthDate, colCreatedAt });
            dgContacts.Dock = DockStyle.Bottom;
            dgContacts.Location = new Point(0, 469);
            dgContacts.MultiSelect = false;
            dgContacts.Name = "dgContacts";
            dgContacts.ReadOnly = true;
            dgContacts.RowHeadersWidth = 62;
            dgContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgContacts.Size = new Size(984, 142);
            dgContacts.TabIndex = 3;
            dgContacts.SelectionChanged += dgContacts_SelectionChanged;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 8;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.Width = 150;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 150;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 150;
            // 
            // colGender
            // 
            colGender.HeaderText = "Gender";
            colGender.MinimumWidth = 8;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            colGender.Width = 150;
            // 
            // colBirthDate
            // 
            colBirthDate.HeaderText = "Birth Date";
            colBirthDate.MinimumWidth = 8;
            colBirthDate.Name = "colBirthDate";
            colBirthDate.ReadOnly = true;
            colBirthDate.Width = 150;
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "Created At";
            colCreatedAt.MinimumWidth = 8;
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;
            colCreatedAt.Width = 150;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblCounts });
            statusStrip1.Location = new Point(0, 447);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Ready";
            // 
            // lblCounts
            // 
            lblCounts.Name = "lblCounts";
            lblCounts.Size = new Size(101, 17);
            lblCounts.Text = "Visible: 0 / Total: 0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(statusStrip1);
            Controls.Add(dgContacts);
            Controls.Add(grpFilter);
            Controls.Add(grpActions);
            Controls.Add(grpInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact Manager";
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            grpActions.ResumeLayout(false);
            grpActions.PerformLayout();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpInput;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtFullName;
        private Label label1;
        private Label label4;
        private MaskedTextBox mtbPhone;
        private ComboBox cmbGender;
        private Button btnUpdateContact;
        private Button btnAddContact;
        private DateTimePicker dtpBirthDate;
        private Label label5;
        private GroupBox grpActions;
        private Button btnExportCsv;
        private CheckBox chkConfirmDelete;
        private Button btnClearAll;
        private Button btnRemoveSelected;
        private GroupBox grpFilter;
        private ComboBox cmbFilterGender;
        private Button btnResetFilter;
        private Button btnApplyFilter;
        private TextBox txtSearch;
        private DataGridView dgContacts;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colBirthDate;
        private DataGridViewTextBoxColumn colCreatedAt;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblCounts;
    }
}
