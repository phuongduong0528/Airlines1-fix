namespace Airlines.FormApplication
{
    partial class MainFormUser
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
            this.useractivityDgv = new System.Windows.Forms.DataGridView();
            this.statusLbl = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.useractivityDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // useractivityDgv
            // 
            this.useractivityDgv.AllowUserToAddRows = false;
            this.useractivityDgv.AllowUserToDeleteRows = false;
            this.useractivityDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.useractivityDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.useractivityDgv.Location = new System.Drawing.Point(13, 65);
            this.useractivityDgv.Name = "useractivityDgv";
            this.useractivityDgv.ReadOnly = true;
            this.useractivityDgv.Size = new System.Drawing.Size(655, 349);
            this.useractivityDgv.TabIndex = 0;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(9, 19);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(50, 20);
            this.statusLbl.TabIndex = 1;
            this.statusLbl.Text = "Status";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(552, 31);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(104, 28);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // MainFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 426);
            this.ControlBox = false;
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.useractivityDgv);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFormUser";
            this.Text = "MainFormUser";
            this.Load += new System.EventHandler(this.MainFormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.useractivityDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView useractivityDgv;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button logoutBtn;
    }
}