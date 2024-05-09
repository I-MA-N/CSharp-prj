namespace prj
{
    partial class frm_SeeMessages
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.grid_Messages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Messages)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(100, 241);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(101, 27);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Delete Selected";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Add
            // 
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Location = new System.Drawing.Point(34, 248);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(45, 13);
            this.lbl_Add.TabIndex = 18;
            this.lbl_Add.Text = "Actions:";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(34, 27);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(91, 13);
            this.lbl_Count.TabIndex = 19;
            this.lbl_Count.Text = "Messages count: ";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(37, 310);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(47, 23);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click_1);
            // 
            // grid_Messages
            // 
            this.grid_Messages.AllowUserToAddRows = false;
            this.grid_Messages.AllowUserToDeleteRows = false;
            this.grid_Messages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Messages.Location = new System.Drawing.Point(37, 68);
            this.grid_Messages.Name = "grid_Messages";
            this.grid_Messages.ReadOnly = true;
            this.grid_Messages.Size = new System.Drawing.Size(443, 150);
            this.grid_Messages.TabIndex = 11;
            // 
            // frm_SeeMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 361);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_Add);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.grid_Messages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_SeeMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frm_SeeMessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Messages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView grid_Messages;
    }
}