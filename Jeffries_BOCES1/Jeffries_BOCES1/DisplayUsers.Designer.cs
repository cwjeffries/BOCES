namespace Jeffries_BOCES1
{
    partial class DisplayUsers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.cboTeacherName = new System.Windows.Forms.ComboBox();
            this.grdStudentDisplay = new System.Windows.Forms.DataGridView();
            this.bOCESDataSet = new Jeffries_BOCES1.BOCESDataSet();
            this.tblDisplayUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAdapterDisplayUsers = new Jeffries_BOCES1.BOCESDataSetTableAdapters.tblAdapterDisplayUsers();
            this.tableAdapterManager = new Jeffries_BOCES1.BOCESDataSetTableAdapters.TableAdapterManager();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.LoginUser = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOCESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDisplayUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(12, 433);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 39);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.BackColor = System.Drawing.Color.Transparent;
            this.lblTeacherName.Location = new System.Drawing.Point(654, 301);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(180, 29);
            this.lblTeacherName.TabIndex = 18;
            this.lblTeacherName.Text = "Teacher Name:";
            // 
            // cboTeacherName
            // 
            this.cboTeacherName.FormattingEnabled = true;
            this.cboTeacherName.Location = new System.Drawing.Point(840, 298);
            this.cboTeacherName.Name = "cboTeacherName";
            this.cboTeacherName.Size = new System.Drawing.Size(227, 37);
            this.cboTeacherName.TabIndex = 19;
            this.cboTeacherName.SelectedIndexChanged += new System.EventHandler(this.cboTeacherName_SelectedIndexChanged_1);
            // 
            // grdStudentDisplay
            // 
            this.grdStudentDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.Age,
            this.SchoolYear,
            this.UserPicture,
            this.LoginUser});
            this.grdStudentDisplay.Location = new System.Drawing.Point(12, 12);
            this.grdStudentDisplay.Name = "grdStudentDisplay";
            this.grdStudentDisplay.Size = new System.Drawing.Size(770, 280);
            this.grdStudentDisplay.TabIndex = 20;
            this.grdStudentDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudentDisplay_CellContentClick);
            // 
            // bOCESDataSet
            // 
            this.bOCESDataSet.DataSetName = "BOCESDataSet";
            this.bOCESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDisplayUsersBindingSource
            // 
            this.tblDisplayUsersBindingSource.DataMember = "tblDisplayUsers";
            this.tblDisplayUsersBindingSource.DataSource = this.bOCESDataSet;
            // 
            // tblAdapterDisplayUsers
            // 
            this.tblAdapterDisplayUsers.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.StudentTaskAndTimesTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Jeffries_BOCES1.BOCESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // picTeacher
            // 
            this.picTeacher.Location = new System.Drawing.Point(788, 12);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(279, 280);
            this.picTeacher.TabIndex = 21;
            this.picTeacher.TabStop = false;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // SchoolYear
            // 
            this.SchoolYear.HeaderText = "School Year";
            this.SchoolYear.Name = "SchoolYear";
            this.SchoolYear.ReadOnly = true;
            // 
            // UserPicture
            // 
            this.UserPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.UserPicture.DefaultCellStyle = dataGridViewCellStyle1;
            this.UserPicture.HeaderText = "Picture";
            this.UserPicture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Width = 94;
            // 
            // LoginUser
            // 
            this.LoginUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.LoginUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.LoginUser.FillWeight = 150F;
            this.LoginUser.HeaderText = "Login";
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoginUser.Text = "Login...";
            this.LoginUser.UseColumnTextForButtonValue = true;
            // 
            // DisplayUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1079, 484);
            this.Controls.Add(this.picTeacher);
            this.Controls.Add(this.grdStudentDisplay);
            this.Controls.Add(this.cboTeacherName);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DisplayUsers";
            this.Text = "DisplayUsers";
            this.Load += new System.EventHandler(this.DisplayUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOCESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDisplayUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOCESDataSet bOCESDataSet;
        private System.Windows.Forms.BindingSource tblDisplayUsersBindingSource;
        private BOCESDataSetTableAdapters.tblAdapterDisplayUsers tblAdapterDisplayUsers;
        private BOCESDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.ComboBox cboTeacherName;
        private System.Windows.Forms.DataGridView grdStudentDisplay;
        private System.Windows.Forms.PictureBox picTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolYear;
        private System.Windows.Forms.DataGridViewImageColumn UserPicture;
        private System.Windows.Forms.DataGridViewButtonColumn LoginUser;
    }
}