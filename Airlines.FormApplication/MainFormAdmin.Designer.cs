namespace Airlines.FormApplication
{
    partial class MainFormAdmin
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
            this.userDgv = new System.Windows.Forms.DataGridView();
            this.officeCbx = new System.Windows.Forms.ComboBox();
            this.changeroleBtn = new System.Windows.Forms.Button();
            this.disableuserBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adduserBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // userDgv
            // 
            this.userDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDgv.Location = new System.Drawing.Point(12, 57);
            this.userDgv.Name = "userDgv";
            this.userDgv.Size = new System.Drawing.Size(703, 367);
            this.userDgv.TabIndex = 0;
            // 
            // officeCbx
            // 
            this.officeCbx.FormattingEnabled = true;
            this.officeCbx.Location = new System.Drawing.Point(80, 12);
            this.officeCbx.Name = "officeCbx";
            this.officeCbx.Size = new System.Drawing.Size(155, 28);
            this.officeCbx.TabIndex = 1;
            this.officeCbx.SelectedIndexChanged += new System.EventHandler(this.officeCbx_SelectedIndexChanged);
            // 
            // changeroleBtn
            // 
            this.changeroleBtn.Location = new System.Drawing.Point(12, 430);
            this.changeroleBtn.Name = "changeroleBtn";
            this.changeroleBtn.Size = new System.Drawing.Size(103, 39);
            this.changeroleBtn.TabIndex = 2;
            this.changeroleBtn.Text = "Change role";
            this.changeroleBtn.UseVisualStyleBackColor = true;
            this.changeroleBtn.Click += new System.EventHandler(this.changeroleBtn_Click);
            // 
            // disableuserBtn
            // 
            this.disableuserBtn.Location = new System.Drawing.Point(151, 430);
            this.disableuserBtn.Name = "disableuserBtn";
            this.disableuserBtn.Size = new System.Drawing.Size(203, 39);
            this.disableuserBtn.TabIndex = 2;
            this.disableuserBtn.Text = "Enable/Disable Login";
            this.disableuserBtn.UseVisualStyleBackColor = true;
            this.disableuserBtn.Click += new System.EventHandler(this.disableuserBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Office";
            // 
            // adduserBtn
            // 
            this.adduserBtn.Location = new System.Drawing.Point(488, 13);
            this.adduserBtn.Name = "adduserBtn";
            this.adduserBtn.Size = new System.Drawing.Size(103, 39);
            this.adduserBtn.TabIndex = 4;
            this.adduserBtn.Text = "Add user";
            this.adduserBtn.UseVisualStyleBackColor = true;
            this.adduserBtn.Click += new System.EventHandler(this.adduserBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(612, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(103, 39);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 481);
            this.ControlBox = false;
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.adduserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disableuserBtn);
            this.Controls.Add(this.changeroleBtn);
            this.Controls.Add(this.officeCbx);
            this.Controls.Add(this.userDgv);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFormAdmin";
            this.Text = "MainFormAdmin";
            this.Load += new System.EventHandler(this.MainFormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userDgv;
        private System.Windows.Forms.ComboBox officeCbx;
        private System.Windows.Forms.Button changeroleBtn;
        private System.Windows.Forms.Button disableuserBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adduserBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}