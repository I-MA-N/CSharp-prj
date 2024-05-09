namespace prj
{
    partial class frm_Admin
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
            this.btn_SeeUsers = new System.Windows.Forms.Button();
            this.group_Data = new System.Windows.Forms.GroupBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.btn_SeeMessages = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.group_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SeeUsers
            // 
            this.btn_SeeUsers.Location = new System.Drawing.Point(92, 244);
            this.btn_SeeUsers.Name = "btn_SeeUsers";
            this.btn_SeeUsers.Size = new System.Drawing.Size(101, 23);
            this.btn_SeeUsers.TabIndex = 2;
            this.btn_SeeUsers.Text = "See All Users";
            this.btn_SeeUsers.UseVisualStyleBackColor = true;
            this.btn_SeeUsers.Click += new System.EventHandler(this.btn_SeeUsers_Click);
            // 
            // group_Data
            // 
            this.group_Data.Controls.Add(this.txt_Age);
            this.group_Data.Controls.Add(this.lbl_Age);
            this.group_Data.Controls.Add(this.txt_LastName);
            this.group_Data.Controls.Add(this.lbl_FirstName);
            this.group_Data.Controls.Add(this.txt_FirstName);
            this.group_Data.Controls.Add(this.lbl_LastName);
            this.group_Data.Location = new System.Drawing.Point(42, 58);
            this.group_Data.Name = "group_Data";
            this.group_Data.Size = new System.Drawing.Size(200, 129);
            this.group_Data.TabIndex = 3;
            this.group_Data.TabStop = false;
            this.group_Data.Text = "Data";
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(72, 97);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(122, 20);
            this.txt_Age.TabIndex = 14;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(6, 100);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(32, 13);
            this.lbl_Age.TabIndex = 3;
            this.lbl_Age.Text = "Age: ";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(72, 64);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(122, 20);
            this.txt_LastName.TabIndex = 13;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(6, 33);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(60, 13);
            this.lbl_FirstName.TabIndex = 1;
            this.lbl_FirstName.Text = "FirstName: ";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(72, 30);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(122, 20);
            this.txt_FirstName.TabIndex = 12;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(6, 67);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(61, 13);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "LastName: ";
            // 
            // btn_SeeMessages
            // 
            this.btn_SeeMessages.Location = new System.Drawing.Point(148, 209);
            this.btn_SeeMessages.Name = "btn_SeeMessages";
            this.btn_SeeMessages.Size = new System.Drawing.Size(101, 23);
            this.btn_SeeMessages.TabIndex = 1;
            this.btn_SeeMessages.Text = "See Messages";
            this.btn_SeeMessages.UseVisualStyleBackColor = true;
            this.btn_SeeMessages.Click += new System.EventHandler(this.btn_SeeMessages_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(36, 209);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 0;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Location = new System.Drawing.Point(99, 33);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(86, 13);
            this.lbl_Welcome.TabIndex = 4;
            this.lbl_Welcome.Text = "Welcome admin!";
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.btn_SeeUsers);
            this.Controls.Add(this.group_Data);
            this.Controls.Add(this.btn_SeeMessages);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.lbl_Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frm_Admin_Load);
            this.group_Data.ResumeLayout(false);
            this.group_Data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SeeUsers;
        private System.Windows.Forms.GroupBox group_Data;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Button btn_SeeMessages;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label lbl_Welcome;
    }
}