namespace Airlines.FormApplication
{
    partial class EditUserForm
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
            this.adminRbt = new System.Windows.Forms.RadioButton();
            this.userRbt = new System.Windows.Forms.RadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(128, 18);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(221, 26);
            this.emailTxb.TabIndex = 0;
            // 
            // firstnameTxb
            // 
            this.firstnameTxb.Location = new System.Drawing.Point(128, 77);
            this.firstnameTxb.Name = "firstnameTxb";
            this.firstnameTxb.Size = new System.Drawing.Size(221, 26);
            this.firstnameTxb.TabIndex = 0;
            // 
            // lastnameTxb
            // 
            this.lastnameTxb.Location = new System.Drawing.Point(128, 138);
            this.lastnameTxb.Name = "lastnameTxb";
            this.lastnameTxb.Size = new System.Drawing.Size(221, 26);
            this.lastnameTxb.TabIndex = 0;
            // 
            // officeCbx
            // 
            this.officeCbx.FormattingEnabled = true;
            this.officeCbx.Location = new System.Drawing.Point(128, 205);
            this.officeCbx.Name = "officeCbx";
            this.officeCbx.Size = new System.Drawing.Size(221, 28);
            this.officeCbx.TabIndex = 1;
            // 
            // adminRbt
            // 
            this.adminRbt.AutoSize = true;
            this.adminRbt.Location = new System.Drawing.Point(138, 270);
            this.adminRbt.Name = "adminRbt";
            this.adminRbt.Size = new System.Drawing.Size(116, 24);
            this.adminRbt.TabIndex = 2;
            this.adminRbt.TabStop = true;
            this.adminRbt.Text = "Administrator";
            this.adminRbt.UseVisualStyleBackColor = true;
            // 
            // userRbt
            // 
            this.userRbt.AutoSize = true;
            this.userRbt.Location = new System.Drawing.Point(138, 300);
            this.userRbt.Name = "userRbt";
            this.userRbt.Size = new System.Drawing.Size(58, 24);
            this.userRbt.TabIndex = 2;
            this.userRbt.TabStop = true;
            this.userRbt.Text = "User";
            this.userRbt.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(43, 360);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(114, 49);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(199, 360);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(114, 49);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Office";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 467);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.userRbt);
            this.Controls.Add(this.adminRbt);
            this.Controls.Add(this.officeCbx);
            this.Controls.Add(this.lastnameTxb);
            this.Controls.Add(this.firstnameTxb);
            this.Controls.Add(this.emailTxb);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.TextBox firstnameTxb;
        private System.Windows.Forms.TextBox lastnameTxb;
        private System.Windows.Forms.ComboBox officeCbx;
        private System.Windows.Forms.RadioButton adminRbt;
        private System.Windows.Forms.RadioButton userRbt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}