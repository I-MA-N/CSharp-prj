namespace prj
{
    partial class frm_SendMessage
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.txt_Body = new System.Windows.Forms.TextBox();
            this.lbl_To = new System.Windows.Forms.Label();
            this.combo_Admins = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(30, 34);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(100, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Send your message";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(95, 86);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(200, 20);
            this.txt_Subject.TabIndex = 1;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(30, 86);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_Subject.TabIndex = 2;
            this.lbl_Subject.Text = "Subject:";
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Location = new System.Drawing.Point(30, 125);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(54, 13);
            this.lbl_Body.TabIndex = 4;
            this.lbl_Body.Text = "Body text:";
            // 
            // txt_Body
            // 
            this.txt_Body.Location = new System.Drawing.Point(95, 125);
            this.txt_Body.Multiline = true;
            this.txt_Body.Name = "txt_Body";
            this.txt_Body.Size = new System.Drawing.Size(200, 140);
            this.txt_Body.TabIndex = 3;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(30, 284);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(54, 13);
            this.lbl_To.TabIndex = 5;
            this.lbl_To.Text = "To admin:";
            // 
            // combo_Admins
            // 
            this.combo_Admins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Admins.DropDownWidth = 200;
            this.combo_Admins.FormattingEnabled = true;
            this.combo_Admins.Location = new System.Drawing.Point(95, 284);
            this.combo_Admins.Name = "combo_Admins";
            this.combo_Admins.Size = new System.Drawing.Size(200, 21);
            this.combo_Admins.TabIndex = 6;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(220, 343);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 25);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(33, 344);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(70, 22);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frm_SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 401);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.combo_Admins);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.txt_Body);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_SendMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frm_SendMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Label lbl_Body;
        private System.Windows.Forms.TextBox txt_Body;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.ComboBox combo_Admins;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Back;
    }
}