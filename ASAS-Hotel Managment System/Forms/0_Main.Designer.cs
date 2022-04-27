using System.Windows.Forms;

namespace ASAS_Hotel_Managment_System.Forms
{
    partial class _0_Main
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
            //DialogResult reason = MessageBox.Show("هل انت متاكد من اغلاق البرنامج ", "أغلاق Hotel Management System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (disposing && (components != null))
            {
                components.Dispose();
                _1_Login master = (_1_Login)Application.OpenForms["_1_Login"];
                master.Show();
                
                
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_0_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_inv = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_manage_rooms = new System.Windows.Forms.Button();
            this.btn_logoff = new System.Windows.Forms.Button();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_reports = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelCihildContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(1004, 100);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11013F));
            this.tableLayoutPanel1.Controls.Add(this.btn_inv, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_users, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_manage_rooms, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_logoff, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_add_book, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_about, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_reports, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 94);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btn_inv
            // 
            this.btn_inv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inv.Location = new System.Drawing.Point(443, 3);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(104, 88);
            this.btn_inv.TabIndex = 14;
            this.btn_inv.Text = "السحوبات";
            this.btn_inv.UseVisualStyleBackColor = true;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
            // 
            // btn_users
            // 
            this.btn_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Location = new System.Drawing.Point(553, 3);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(104, 88);
            this.btn_users.TabIndex = 8;
            this.btn_users.Text = "المستخدمين";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "تغيير الصوره";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_manage_rooms
            // 
            this.btn_manage_rooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_manage_rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_rooms.Location = new System.Drawing.Point(663, 3);
            this.btn_manage_rooms.Name = "btn_manage_rooms";
            this.btn_manage_rooms.Size = new System.Drawing.Size(104, 88);
            this.btn_manage_rooms.TabIndex = 7;
            this.btn_manage_rooms.Text = "اداره الغرف";
            this.btn_manage_rooms.UseVisualStyleBackColor = true;
            this.btn_manage_rooms.Click += new System.EventHandler(this.btn_manage_rooms_Click);
            // 
            // btn_logoff
            // 
            this.btn_logoff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_logoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logoff.Location = new System.Drawing.Point(113, 3);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.Size = new System.Drawing.Size(104, 88);
            this.btn_logoff.TabIndex = 11;
            this.btn_logoff.Text = "تسجيل الخروج";
            this.btn_logoff.UseVisualStyleBackColor = true;
            this.btn_logoff.Click += new System.EventHandler(this.btn_logoff_Click);
            // 
            // btn_add_book
            // 
            this.btn_add_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_book.Location = new System.Drawing.Point(773, 3);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(104, 88);
            this.btn_add_book.TabIndex = 6;
            this.btn_add_book.Text = "حجز غرفه \\ جناح";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_about
            // 
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Location = new System.Drawing.Point(223, 3);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(104, 88);
            this.btn_about.TabIndex = 12;
            this.btn_about.Text = "عن البرنامج";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(883, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 94);
            this.label2.TabIndex = 13;
            this.label2.Text = "الرئيسيه";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.Location = new System.Drawing.Point(333, 3);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(104, 88);
            this.btn_reports.TabIndex = 9;
            this.btn_reports.Text = "التقارير";
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelCihildContainer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1004, 361);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panelCihildContainer
            // 
            this.panelCihildContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCihildContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCihildContainer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCihildContainer.Location = new System.Drawing.Point(5, 18);
            this.panelCihildContainer.Name = "panelCihildContainer";
            this.panelCihildContainer.Size = new System.Drawing.Size(994, 338);
            this.panelCihildContainer.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // _0_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_0_Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Managment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._0_Main_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_logoff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelCihildContainer;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btn_manage_rooms;
        public System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Button btn_inv;
    }
}