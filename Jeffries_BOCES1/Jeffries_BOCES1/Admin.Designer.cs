namespace Jeffries_BOCES1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnManageTeachers = new System.Windows.Forms.Button();
            this.btnManageTasks = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnManageImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(320, 151);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(237, 40);
            this.btnManageStudents.TabIndex = 0;
            this.btnManageStudents.Text = "Manage Students...";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnManageTeachers
            // 
            this.btnManageTeachers.Location = new System.Drawing.Point(320, 197);
            this.btnManageTeachers.Name = "btnManageTeachers";
            this.btnManageTeachers.Size = new System.Drawing.Size(237, 40);
            this.btnManageTeachers.TabIndex = 1;
            this.btnManageTeachers.Text = "Manage Teachers...";
            this.btnManageTeachers.UseVisualStyleBackColor = true;
            this.btnManageTeachers.Click += new System.EventHandler(this.btnManageTeachers_Click);
            // 
            // btnManageTasks
            // 
            this.btnManageTasks.Location = new System.Drawing.Point(320, 243);
            this.btnManageTasks.Name = "btnManageTasks";
            this.btnManageTasks.Size = new System.Drawing.Size(237, 40);
            this.btnManageTasks.TabIndex = 2;
            this.btnManageTasks.Text = "Manage Tasks...";
            this.btnManageTasks.UseVisualStyleBackColor = true;
            this.btnManageTasks.Click += new System.EventHandler(this.btnManageTasks_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Location = new System.Drawing.Point(320, 289);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(237, 40);
            this.btnGenerateReports.TabIndex = 3;
            this.btnGenerateReports.Text = "Manage Reports...";
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(13, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnManageImage
            // 
            this.btnManageImage.Location = new System.Drawing.Point(320, 105);
            this.btnManageImage.Name = "btnManageImage";
            this.btnManageImage.Size = new System.Drawing.Size(237, 40);
            this.btnManageImage.TabIndex = 5;
            this.btnManageImage.Text = "Manage Images";
            this.btnManageImage.UseVisualStyleBackColor = true;
            this.btnManageImage.Click += new System.EventHandler(this.btnManageImage_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 480);
            this.Controls.Add(this.btnManageImage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.btnManageTasks);
            this.Controls.Add(this.btnManageTeachers);
            this.Controls.Add(this.btnManageStudents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnManageTeachers;
        private System.Windows.Forms.Button btnManageTasks;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnManageImage;
    }
}