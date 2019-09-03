namespace Jeffries_BOCES1
{
    partial class SelectTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTask));
            this.cboTaskDisplay = new System.Windows.Forms.ComboBox();
            this.picTask = new System.Windows.Forms.PictureBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTask)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTaskDisplay
            // 
            this.cboTaskDisplay.FormattingEnabled = true;
            this.cboTaskDisplay.Location = new System.Drawing.Point(241, 48);
            this.cboTaskDisplay.Name = "cboTaskDisplay";
            this.cboTaskDisplay.Size = new System.Drawing.Size(323, 37);
            this.cboTaskDisplay.TabIndex = 0;
            this.cboTaskDisplay.SelectedIndexChanged += new System.EventHandler(this.cboTaskDisplay_SelectedIndexChanged);
            // 
            // picTask
            // 
            this.picTask.Location = new System.Drawing.Point(262, 108);
            this.picTask.Name = "picTask";
            this.picTask.Size = new System.Drawing.Size(280, 220);
            this.picTask.TabIndex = 1;
            this.picTask.TabStop = false;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(292, 337);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(221, 43);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "Begin Task";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(12, 427);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.LightSalmon;
            this.lblStart.Location = new System.Drawing.Point(258, 400);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(130, 29);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start Time:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.PowderBlue;
            this.lblEnd.Location = new System.Drawing.Point(258, 436);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(124, 29);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "End Time:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(12, 9);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(137, 29);
            this.lblFirst.TabIndex = 6;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(12, 48);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(134, 29);
            this.lblLast.TabIndex = 7;
            this.lblLast.Text = "Last Name:";
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(570, 48);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.ReadOnly = true;
            this.txtTaskId.Size = new System.Drawing.Size(71, 34);
            this.txtTaskId.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(623, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SelectTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.picTask);
            this.Controls.Add(this.cboTaskDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SelectTask";
            this.Text = "SelecteTask";
            this.Load += new System.EventHandler(this.SelectTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTaskDisplay;
        private System.Windows.Forms.PictureBox picTask;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.Button btnSave;
    }
}