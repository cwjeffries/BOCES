namespace Jeffries_BOCES1
{
    partial class ManageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudent));
            this.cboTeacherName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblClassYear = new System.Windows.Forms.Label();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtClassYear = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.grdStudentDisplay = new System.Windows.Forms.DataGridView();
            this.TeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStudentCreate = new System.Windows.Forms.GroupBox();
            this.lblgrdTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDirections = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentDisplay)).BeginInit();
            this.grpStudentCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTeacherName
            // 
            this.cboTeacherName.FormattingEnabled = true;
            this.cboTeacherName.Location = new System.Drawing.Point(191, 6);
            this.cboTeacherName.Name = "cboTeacherName";
            this.cboTeacherName.Size = new System.Drawing.Size(220, 37);
            this.cboTeacherName.TabIndex = 1;
            this.cboTeacherName.SelectedIndexChanged += new System.EventHandler(this.cboTeacherName_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(360, 434);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(520, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(680, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.Location = new System.Drawing.Point(6, 35);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(108, 24);
            this.lblTeacherID.TabIndex = 6;
            this.lblTeacherID.Text = "Teacher ID:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 75);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 24);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 117);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(104, 24);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(6, 155);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 24);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age:";
            // 
            // lblClassYear
            // 
            this.lblClassYear.AutoSize = true;
            this.lblClassYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassYear.Location = new System.Drawing.Point(6, 195);
            this.lblClassYear.Name = "lblClassYear";
            this.lblClassYear.Size = new System.Drawing.Size(104, 24);
            this.lblClassYear.TabIndex = 10;
            this.lblClassYear.Text = "Class Year:";
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(120, 27);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(124, 34);
            this.txtTeacherID.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(124, 34);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 107);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(124, 34);
            this.txtLastName.TabIndex = 13;
            // 
            // txtClassYear
            // 
            this.txtClassYear.Location = new System.Drawing.Point(120, 187);
            this.txtClassYear.Name = "txtClassYear";
            this.txtClassYear.Size = new System.Drawing.Size(124, 34);
            this.txtClassYear.TabIndex = 14;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(120, 147);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(124, 34);
            this.txtAge.TabIndex = 15;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(5, 9);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(180, 29);
            this.lblTeacherName.TabIndex = 16;
            this.lblTeacherName.Text = "Teacher Name:";
            // 
            // grdStudentDisplay
            // 
            this.grdStudentDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherID,
            this.FirstName,
            this.LastName,
            this.Age,
            this.ClassYear});
            this.grdStudentDisplay.Location = new System.Drawing.Point(287, 49);
            this.grdStudentDisplay.Name = "grdStudentDisplay";
            this.grdStudentDisplay.Size = new System.Drawing.Size(547, 160);
            this.grdStudentDisplay.TabIndex = 17;
            // 
            // TeacherID
            // 
            this.TeacherID.HeaderText = "Teacher ID";
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
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // ClassYear
            // 
            this.ClassYear.HeaderText = "Class Year";
            this.ClassYear.Name = "ClassYear";
            // 
            // grpStudentCreate
            // 
            this.grpStudentCreate.Controls.Add(this.lblTeacherID);
            this.grpStudentCreate.Controls.Add(this.lblFirstName);
            this.grpStudentCreate.Controls.Add(this.lblLastName);
            this.grpStudentCreate.Controls.Add(this.txtAge);
            this.grpStudentCreate.Controls.Add(this.lblAge);
            this.grpStudentCreate.Controls.Add(this.txtClassYear);
            this.grpStudentCreate.Controls.Add(this.lblClassYear);
            this.grpStudentCreate.Controls.Add(this.txtLastName);
            this.grpStudentCreate.Controls.Add(this.txtTeacherID);
            this.grpStudentCreate.Controls.Add(this.txtFirstName);
            this.grpStudentCreate.Location = new System.Drawing.Point(5, 49);
            this.grpStudentCreate.Name = "grpStudentCreate";
            this.grpStudentCreate.Size = new System.Drawing.Size(276, 235);
            this.grpStudentCreate.TabIndex = 18;
            this.grpStudentCreate.TabStop = false;
            this.grpStudentCreate.Text = "Enter Student Info";
            // 
            // lblgrdTitle
            // 
            this.lblgrdTitle.AutoSize = true;
            this.lblgrdTitle.Location = new System.Drawing.Point(482, 212);
            this.lblgrdTitle.Name = "lblgrdTitle";
            this.lblgrdTitle.Size = new System.Drawing.Size(192, 29);
            this.lblgrdTitle.TabIndex = 19;
            this.lblgrdTitle.Text = "Current Students";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_1);
            // 
            // lblDirections
            // 
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(498, 367);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(336, 64);
            this.lblDirections.TabIndex = 20;
            this.lblDirections.Text = "When updating or deleting students input their first and last name into the text " +
    "boxes under \"Enter Student Info\"";
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 481);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblgrdTitle);
            this.Controls.Add(this.grpStudentCreate);
            this.Controls.Add(this.grdStudentDisplay);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboTeacherName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentDisplay)).EndInit();
            this.grpStudentCreate.ResumeLayout(false);
            this.grpStudentCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTeacherName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblClassYear;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtClassYear;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.DataGridView grdStudentDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassYear;
        private System.Windows.Forms.GroupBox grpStudentCreate;
        private System.Windows.Forms.Label lblgrdTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDirections;
    }
}