namespace Venier.PeopleList.ManageUI
{
    partial class Form1
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
            this.lTitle = new System.Windows.Forms.Label();
            this.lSubTitle = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lBirthDate = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(12, 27);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(196, 29);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "USER DETAILS";
            // 
            // lSubTitle
            // 
            this.lSubTitle.AutoSize = true;
            this.lSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubTitle.Location = new System.Drawing.Point(15, 56);
            this.lSubTitle.Name = "lSubTitle";
            this.lSubTitle.Size = new System.Drawing.Size(179, 17);
            this.lSubTitle.TabIndex = 1;
            this.lSubTitle.Text = "Insert your personal details";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(34, 94);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(45, 17);
            this.lName.TabIndex = 2;
            this.lName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 22);
            this.txtName.TabIndex = 3;
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(34, 127);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(65, 17);
            this.lSurname.TabIndex = 4;
            this.lSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(114, 124);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(166, 22);
            this.txtSurname.TabIndex = 5;
            // 
            // lBirthDate
            // 
            this.lBirthDate.AutoSize = true;
            this.lBirthDate.Location = new System.Drawing.Point(34, 162);
            this.lBirthDate.Name = "lBirthDate";
            this.lBirthDate.Size = new System.Drawing.Size(69, 17);
            this.lBirthDate.TabIndex = 6;
            this.lBirthDate.Text = "Birth date";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(114, 159);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(166, 22);
            this.txtBirthDate.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(114, 196);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 22);
            this.txtAddress.TabIndex = 8;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(34, 199);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(60, 17);
            this.lAddress.TabIndex = 9;
            this.lAddress.Text = "Address";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(204, 247);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 31);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 307);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.lBirthDate);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lSubTitle);
            this.Controls.Add(this.lTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lSubTitle;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lBirthDate;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Button btnSend;
    }
}

