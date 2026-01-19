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
            lblStatus = new StatusStrip();
            lblCounts = new StatusStrip();
            errorProvider = new ErrorProvider(components);
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colBirthDate = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            lblStatus1 = new ToolStripStatusLabel();
            lblCounts1 = new ToolStripStatusLabel();
            grpInput.SuspendLayout();
            grpActions.SuspendLayout();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            lblStatus.SuspendLayout();
            lblCounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
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
            grpInput.Location = new Point(17, 20);
            grpInput.Margin = new Padding(4, 5, 4, 5);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(4, 5, 4, 5);
            grpInput.Size = new Size(643, 383);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Add/Update Contact";
            // 
            // btnUpdateContact
            // 
            btnUpdateContact.Enabled = false;
            btnUpdateContact.Location = new Point(303, 290);
            btnUpdateContact.Margin = new Padding(4, 5, 4, 5);
            btnUpdateContact.Name = "btnUpdateContact";
            btnUpdateContact.Size = new Size(194, 38);
            btnUpdateContact.TabIndex = 11;
            btnUpdateContact.Text = "Update Selected";
            btnUpdateContact.UseVisualStyleBackColor = true;
            btnUpdateContact.Click += btnUpdateContact_Click;
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(73, 290);
            btnAddContact.Margin = new Padding(4, 5, 4, 5);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(194, 38);
            btnAddContact.TabIndex = 10;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(9, 208);
            dtpBirthDate.Margin = new Padding(4, 5, 4, 5);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(151, 31);
            dtpBirthDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 178);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 8;
            label5.Text = "Birth Date";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Non-binary", "Prefer not to say" });
            cmbGender.Location = new Point(303, 135);
            cmbGender.Margin = new Padding(4, 5, 4, 5);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(257, 33);
            cmbGender.TabIndex = 7;
            cmbGender.SelectedIndexChanged += InputChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 105);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(9, 135);
            mtbPhone.Margin = new Padding(4, 5, 4, 5);
            mtbPhone.Mask = "00000000000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(257, 31);
            mtbPhone.TabIndex = 5;
            mtbPhone.TextChanged += InputChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(303, 62);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "name@example.com";
            txtEmail.Size = new Size(257, 31);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += InputChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(9, 62);
            txtFullName.Margin = new Padding(4, 5, 4, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Juan Dela Cruz";
            txtFullName.Size = new Size(257, 31);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += InputChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnExportCsv);
            grpActions.Controls.Add(chkConfirmDelete);
            grpActions.Controls.Add(btnClearAll);
            grpActions.Controls.Add(btnRemoveSelected);
            grpActions.Location = new Point(17, 413);
            grpActions.Margin = new Padding(4, 5, 4, 5);
            grpActions.Name = "grpActions";
            grpActions.Padding = new Padding(4, 5, 4, 5);
            grpActions.Size = new Size(643, 217);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Actions";
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(171, 152);
            btnExportCsv.Margin = new Padding(4, 5, 4, 5);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(219, 38);
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
            chkConfirmDelete.Location = new Point(171, 85);
            chkConfirmDelete.Margin = new Padding(4, 5, 4, 5);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(228, 29);
            chkConfirmDelete.TabIndex = 2;
            chkConfirmDelete.Text = "Confirm before deletion";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(303, 37);
            btnClearAll.Margin = new Padding(4, 5, 4, 5);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(194, 38);
            btnClearAll.TabIndex = 1;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Enabled = false;
            btnRemoveSelected.Location = new Point(73, 37);
            btnRemoveSelected.Margin = new Padding(4, 5, 4, 5);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(194, 38);
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
            grpFilter.Location = new Point(746, 20);
            grpFilter.Margin = new Padding(4, 5, 4, 5);
            grpFilter.Name = "grpFilter";
            grpFilter.Padding = new Padding(4, 5, 4, 5);
            grpFilter.Size = new Size(643, 217);
            grpFilter.TabIndex = 2;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter/Search";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(299, 150);
            btnResetFilter.Margin = new Padding(4, 5, 4, 5);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(140, 38);
            btnResetFilter.TabIndex = 3;
            btnResetFilter.Text = "Reset Filter";
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(150, 150);
            btnApplyFilter.Margin = new Padding(4, 5, 4, 5);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(140, 38);
            btnApplyFilter.TabIndex = 2;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(9, 32);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Name or Email...";
            txtSearch.Size = new Size(428, 31);
            txtSearch.TabIndex = 1;
            // 
            // cmbFilterGender
            // 
            cmbFilterGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterGender.FormattingEnabled = true;
            cmbFilterGender.Items.AddRange(new object[] { "All", "Male", "Female", "Non-binary", "Prefer not to say" });
            cmbFilterGender.Location = new Point(9, 80);
            cmbFilterGender.Margin = new Padding(4, 5, 4, 5);
            cmbFilterGender.Name = "cmbFilterGender";
            cmbFilterGender.Size = new Size(171, 33);
            cmbFilterGender.TabIndex = 0;
            // 
            // dgContacts
            // 
            dgContacts.AllowUserToAddRows = false;
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Columns.AddRange(new DataGridViewColumn[] { colFullName, colEmail, colPhone, colGender, colBirthDate, colCreatedAt });
            dgContacts.Dock = DockStyle.Bottom;
            dgContacts.Location = new Point(0, 781);
            dgContacts.Margin = new Padding(4, 5, 4, 5);
            dgContacts.MultiSelect = false;
            dgContacts.Name = "dgContacts";
            dgContacts.ReadOnly = true;
            dgContacts.RowHeadersWidth = 62;
            dgContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgContacts.Size = new Size(1406, 237);
            dgContacts.TabIndex = 3;
            dgContacts.SelectionChanged += dgContacts_SelectionChanged;
            // 
            // lblStatus
            // 
            lblStatus.ImageScalingSize = new Size(24, 24);
            lblStatus.Items.AddRange(new ToolStripItem[] { lblStatus1 });
            lblStatus.Location = new Point(0, 749);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(1, 0, 20, 0);
            lblStatus.Size = new Size(1406, 32);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Ready";
            // 
            // lblCounts
            // 
            lblCounts.ImageScalingSize = new Size(24, 24);
            lblCounts.Items.AddRange(new ToolStripItem[] { lblCounts1 });
            lblCounts.Location = new Point(0, 717);
            lblCounts.Name = "lblCounts";
            lblCounts.Padding = new Padding(1, 0, 20, 0);
            lblCounts.Size = new Size(1406, 32);
            lblCounts.TabIndex = 5;
            lblCounts.Text = "Visible: 0/Total: 0";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
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
            // lblStatus1
            // 
            lblStatus1.Name = "lblStatus1";
            lblStatus1.Size = new Size(60, 25);
            lblStatus1.Text = "Ready";
            // 
            // lblCounts1
            // 
            lblCounts1.Name = "lblCounts1";
            lblCounts1.Size = new Size(1339, 25);
            lblCounts1.Spring = true;
            lblCounts1.Text = "Visible: 0/Total: 0";
            lblCounts1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 1018);
            Controls.Add(lblCounts);
            Controls.Add(lblStatus);
            Controls.Add(dgContacts);
            Controls.Add(grpFilter);
            Controls.Add(grpActions);
            Controls.Add(grpInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
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
            lblStatus.ResumeLayout(false);
            lblStatus.PerformLayout();
            lblCounts.ResumeLayout(false);
            lblCounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
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
        private StatusStrip lblStatus;
        private StatusStrip lblCounts;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colBirthDate;
        private DataGridViewTextBoxColumn colCreatedAt;
        private ToolStripStatusLabel lblStatus1;
        private ToolStripStatusLabel lblCounts1;
    }
}
