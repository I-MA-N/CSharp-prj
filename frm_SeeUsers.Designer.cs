namespace prj
{
    partial class frm_SeeUsers
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.grid_Users = new System.Windows.Forms.DataGridView();
            this.group_Inputs = new System.Windows.Forms.GroupBox();
            this.group_Inputs2 = new System.Windows.Forms.GroupBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Users)).BeginInit();
            this.group_Inputs.SuspendLayout();
            this.group_Inputs2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(351, 248);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 27);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(12, 99);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(29, 13);
            this.lbl_Age.TabIndex = 43;
            this.lbl_Age.Text = "Age:";
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(79, 95);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(105, 20);
            this.txt_Age.TabIndex = 42;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(12, 62);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 41;
            this.lbl_LastName.Text = "LastName:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(79, 58);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(105, 20);
            this.txt_LastName.TabIndex = 40;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(12, 25);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 39;
            this.lbl_FirstName.Text = "FirstName:";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(79, 21);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(105, 20);
            this.txt_FirstName.TabIndex = 38;
            // 
            // lbl_Add
            // 
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Location = new System.Drawing.Point(34, 255);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(45, 13);
            this.lbl_Add.TabIndex = 7;
            this.lbl_Add.Text = "Actions:";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(34, 34);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(70, 13);
            this.lbl_Count.TabIndex = 9;
            this.lbl_Count.Text = "Users count: ";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(37, 451);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(47, 23);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // grid_Users
            // 
            this.grid_Users.AllowUserToAddRows = false;
            this.grid_Users.AllowUserToDeleteRows = false;
            this.grid_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Users.Location = new System.Drawing.Point(37, 75);
            this.grid_Users.Name = "grid_Users";
            this.grid_Users.ReadOnly = true;
            this.grid_Users.Size = new System.Drawing.Size(443, 150);
            this.grid_Users.TabIndex = 0;
            this.grid_Users.SelectionChanged += new System.EventHandler(this.grid_Users_SelectionChanged);
            // 
            // group_Inputs
            // 
            this.group_Inputs.Controls.Add(this.txt_FirstName);
            this.group_Inputs.Controls.Add(this.lbl_FirstName);
            this.group_Inputs.Controls.Add(this.txt_LastName);
            this.group_Inputs.Controls.Add(this.lbl_LastName);
            this.group_Inputs.Controls.Add(this.txt_Age);
            this.group_Inputs.Controls.Add(this.lbl_Age);
            this.group_Inputs.Location = new System.Drawing.Point(37, 291);
            this.group_Inputs.Name = "group_Inputs";
            this.group_Inputs.Size = new System.Drawing.Size(200, 132);
            this.group_Inputs.TabIndex = 3;
            this.group_Inputs.TabStop = false;
            this.group_Inputs.Visible = false;
            // 
            // group_Inputs2
            // 
            this.group_Inputs2.Controls.Add(this.lbl_Password);
            this.group_Inputs2.Controls.Add(this.txt_Password);
            this.group_Inputs2.Controls.Add(this.lbl_Username);
            this.group_Inputs2.Controls.Add(this.txt_Username);
            this.group_Inputs2.Location = new System.Drawing.Point(280, 291);
            this.group_Inputs2.Name = "group_Inputs2";
            this.group_Inputs2.Size = new System.Drawing.Size(200, 99);
            this.group_Inputs2.TabIndex = 4;
            this.group_Inputs2.TabStop = false;
            this.group_Inputs2.Visible = false;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(13, 63);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 52;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(76, 59);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(105, 20);
            this.txt_Password.TabIndex = 51;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(13, 24);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Username.TabIndex = 50;
            this.lbl_Username.Text = "Username:";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(76, 21);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(105, 20);
            this.txt_Username.TabIndex = 49;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(91, 248);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(101, 27);
            this.btn_Change.TabIndex = 1;
            this.btn_Change.Text = "Change Selected";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(405, 396);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 27);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Visible = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(221, 248);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(101, 27);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete Selected";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_SeeUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 511);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.group_Inputs2);
            this.Controls.Add(this.group_Inputs);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Add);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.grid_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_SeeUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frm_SeeUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Users)).EndInit();
            this.group_Inputs.ResumeLayout(false);
            this.group_Inputs.PerformLayout();
            this.group_Inputs2.ResumeLayout(false);
            this.group_Inputs2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView grid_Users;
        private System.Windows.Forms.GroupBox group_Inputs;
        private System.Windows.Forms.GroupBox group_Inputs2;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Delete;
    }
}