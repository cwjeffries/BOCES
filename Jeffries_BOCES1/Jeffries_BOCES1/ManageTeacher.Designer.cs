namespace Jeffries_BOCES1
{
    partial class ManageTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTeacher));
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.cboTeacherName = new System.Windows.Forms.ComboBox();
            this.grpTeacherCreate = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDirections = new System.Windows.Forms.Label();
            this.grdTeacherDisplay = new System.Windows.Forms.DataGridView();
            this.TeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grpTeacherCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeacherDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(5, 9);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(180, 29);
            this.lblTeacherName.TabIndex = 0;
            this.lblTeacherName.Text = "Teacher Name:";
            // 
            // cboTeacherName
            // 
            this.cboTeacherName.FormattingEnabled = true;
            this.cboTeacherName.Location = new System.Drawing.Point(191, 6);
            this.cboTeacherName.Name = "cboTeacherName";
            this.cboTeacherName.Size = new System.Drawing.Size(209, 37);
            this.cboTeacherName.TabIndex = 1;
            this.cboTeacherName.SelectedIndexChanged += new System.EventHandler(this.cboTeacherName_SelectedIndexChanged);
            // 
            // grpTeacherCreate
            // 
            this.grpTeacherCreate.Controls.Add(this.txtPhone);
            this.grpTeacherCreate.Controls.Add(this.txtEmail);
            this.grpTeacherCreate.Controls.Add(this.txtLastName);
            this.grpTeacherCreate.Controls.Add(this.txtFirstName);
            this.grpTeacherCreate.Controls.Add(this.lblPhone);
            this.grpTeacherCreate.Controls.Add(this.lblEmail);
            this.grpTeacherCreate.Controls.Add(this.lblLast);
            this.grpTeacherCreate.Controls.Add(this.lblFirst);
            this.grpTeacherCreate.Location = new System.Drawing.Point(5, 44);
            this.grpTeacherCreate.Name = "grpTeacherCreate";
            this.grpTeacherCreate.Size = new System.Drawing.Size(260, 204);
            this.grpTeacherCreate.TabIndex = 2;
            this.grpTeacherCreate.TabStop = false;
            this.grpTeacherCreate.Text = "Enter Teacher Info";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(335, 434);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Teacher";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(495, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Teacher";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(655, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Teacher";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDirections
            // 
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(440, 347);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(369, 84);
            this.lblDirections.TabIndex = 7;
            this.lblDirections.Text = "When updating or deleting teachers input their first and last name into the \"Ente" +
    "r Teacher Info\", and make sure to update any affected students prior to deleting" +
    " a teacher";
            // 
            // grdTeacherDisplay
            // 
            this.grdTeacherDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeacherDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Phone});
            this.grdTeacherDisplay.Location = new System.Drawing.Point(271, 44);
            this.grdTeacherDisplay.Name = "grdTeacherDisplay";
            this.grdTeacherDisplay.Size = new System.Drawing.Size(547, 160);
            this.grdTeacherDisplay.TabIndex = 8;
            // 
            // TeacherID
            // 
            this.TeacherID.HeaderText = "TeacherID";
            this.TeacherID.Name = "TeacherID";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone Number";
            this.Phone.Name = "Phone";
            // 
            // lblTeachers
            // 
            this.lblTeachers.AutoSize = true;
            this.lblTeachers.Location = new System.Drawing.Point(467, 207);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(200, 29);
            this.lblTeachers.TabIndex = 9;
            this.lblTeachers.Text = "Current Teachers";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(3, 45);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(106, 24);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(3, 85);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(104, 24);
            this.lblLast.TabIndex = 1;
            this.lblLast.Text = "Last Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(3, 165);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 24);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(134, 34);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(115, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(134, 34);
            this.txtLastName.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 34);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(80, 157);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(169, 34);
            this.txtPhone.TabIndex = 7;
            // 
            // ManageTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 481);
            this.Controls.Add(this.lblTeachers);
            this.Controls.Add(this.grdTeacherDisplay);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpTeacherCreate);
            this.Controls.Add(this.cboTeacherName);
            this.Controls.Add(this.lblTeacherName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManageTeacher";
            this.Text = "ManageTeacher";
            this.Load += new System.EventHandler(this.ManageTeacher_Load);
            this.grpTeacherCreate.ResumeLayout(false);
            this.grpTeacherCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeacherDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.ComboBox cboTeacherName;
        private System.Windows.Forms.GroupBox grpTeacherCreate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.DataGridView grdTeacherDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Label lblTeachers;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirst;
    }
}