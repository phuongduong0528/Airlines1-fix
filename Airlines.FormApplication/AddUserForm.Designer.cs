namespace Airlines.FormApplication
{
    partial class AddUserForm
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
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.firstnameTxb = new System.Windows.Forms.TextBox();
            this.lastnameTxb = new System.Windows.Forms.TextBox();
            this.officeCbx = new System.Windows.Forms.ComboBox();
            this.birthdateDtp = new System.Windows.Forms.DateTimePicker();
            this.passTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(125, 48);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(227, 26);
            this.emailTxb.TabIndex = 0;
            // 
            // firstnameTxb
            // 
            this.firstnameTxb.Location = new System.Drawing.Point(125, 101);
            this.firstnameTxb.Name = "firstnameTxb";
            this.firstnameTxb.Size = new System.Drawing.Size(227, 26);
            this.firstnameTxb.TabIndex = 0;
            // 
            // lastnameTxb
            // 
            this.lastnameTxb.Location = new System.Drawing.Point(125, 156);
            this.lastnameTxb.Name = "lastnameTxb";
            this.lastnameTxb.Size = new System.Drawing.Size(227, 26);
            this.lastnameTxb.TabIndex = 0;
            // 
            // officeCbx
            // 
            this.officeCbx.FormattingEnabled = true;
            this.officeCbx.Location = new System.Drawing.Point(125, 214);
            this.officeCbx.Name = "officeCbx";
            this.officeCbx.Size = new System.Drawing.Size(227, 28);
            this.officeCbx.TabIndex = 1;
            // 
            // birthdateDtp
            // 
            this.birthdateDtp.CustomFormat = "dd/MM/yyyy";
            this.birthdateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdateDtp.Location = new System.Drawing.Point(125, 274);
            this.birthdateDtp.Name = "birthdateDtp";
            this.birthdateDtp.Size = new System.Drawing.Size(227, 26);
            this.birthdateDtp.TabIndex = 2;
            // 
            // passTxb
            // 
            this.passTxb.Location = new System.Drawing.Point(125, 334);
            this.passTxb.Name = "passTxb";
            this.passTxb.Size = new System.Drawing.Size(227, 26);
            this.passTxb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(60, 384);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 42);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(229, 384);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(109, 42);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 445);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTxb);
            this.Controls.Add(this.birthdateDtp);
            this.Controls.Add(this.officeCbx);
            this.Controls.Add(this.lastnameTxb);
            this.Controls.Add(this.firstnameTxb);
            this.Controls.Add(this.emailTxb);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.TextBox firstnameTxb;
        private System.Windows.Forms.TextBox lastnameTxb;
        private System.Windows.Forms.ComboBox officeCbx;
        private System.Windows.Forms.DateTimePicker birthdateDtp;
        private System.Windows.Forms.TextBox passTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}