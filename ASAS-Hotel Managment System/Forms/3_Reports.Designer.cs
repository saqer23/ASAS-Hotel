namespace ASAS_Hotel_Managment_System.Forms
{
    partial class _3_Reports
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_user_report = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkbox_datetime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_date_from = new System.Windows.Forms.DateTimePicker();
            this.btn_topuser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date_to = new System.Windows.Forms.DateTimePicker();
            this.btn_users = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_users = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_customers = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtp_time_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_time_from = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_withdrawal = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 16);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(890, 476);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.crystalReportViewer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(134, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(896, 495);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btn_user_report
            // 
            this.btn_user_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_user_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_report.Location = new System.Drawing.Point(3, 389);
            this.btn_user_report.Name = "btn_user_report";
            this.btn_user_report.Size = new System.Drawing.Size(128, 35);
            this.btn_user_report.TabIndex = 2;
            this.btn_user_report.Text = "تقارير المستخدم";
            this.btn_user_report.UseVisualStyleBackColor = true;
            this.btn_user_report.Click += new System.EventHandler(this.btn_user_report_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 20);
            this.panel4.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkbox_datetime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 30);
            this.panel1.TabIndex = 5;
            // 
            // chkbox_datetime
            // 
            this.chkbox_datetime.AutoSize = true;
            this.chkbox_datetime.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbox_datetime.Location = new System.Drawing.Point(0, 0);
            this.chkbox_datetime.Margin = new System.Windows.Forms.Padding(0);
            this.chkbox_datetime.Name = "chkbox_datetime";
            this.chkbox_datetime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chkbox_datetime.Size = new System.Drawing.Size(25, 30);
            this.chkbox_datetime.TabIndex = 12;
            this.chkbox_datetime.UseVisualStyleBackColor = true;
            this.chkbox_datetime.CheckedChanged += new System.EventHandler(this.chkbox_datetime_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "من";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_date_from
            // 
            this.dtp_date_from.Checked = false;
            this.dtp_date_from.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtp_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_from.Location = new System.Drawing.Point(3, 53);
            this.dtp_date_from.Name = "dtp_date_from";
            this.dtp_date_from.Size = new System.Drawing.Size(128, 20);
            this.dtp_date_from.TabIndex = 9;
            this.dtp_date_from.Value = new System.DateTime(2020, 1, 1, 1, 1, 0, 0);
            // 
            // btn_topuser
            // 
            this.btn_topuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_topuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_topuser.Location = new System.Drawing.Point(3, 279);
            this.btn_topuser.Name = "btn_topuser";
            this.btn_topuser.Size = new System.Drawing.Size(128, 35);
            this.btn_topuser.TabIndex = 3;
            this.btn_topuser.Text = "المستخدم الاكثر دخلا";
            this.btn_topuser.UseVisualStyleBackColor = true;
            this.btn_topuser.Click += new System.EventHandler(this.btn_topuser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 30);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "الى";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_date_to
            // 
            this.dtp_date_to.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtp_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_to.Location = new System.Drawing.Point(3, 123);
            this.dtp_date_to.Name = "dtp_date_to";
            this.dtp_date_to.Size = new System.Drawing.Size(128, 20);
            this.dtp_date_to.TabIndex = 8;
            // 
            // btn_users
            // 
            this.btn_users.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Location = new System.Drawing.Point(3, 224);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(128, 35);
            this.btn_users.TabIndex = 1;
            this.btn_users.Text = "اجمالي المستخدمين";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 20);
            this.panel3.TabIndex = 7;
            // 
            // cb_users
            // 
            this.cb_users.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_users.FormattingEnabled = true;
            this.cb_users.Location = new System.Drawing.Point(3, 183);
            this.cb_users.Name = "cb_users";
            this.cb_users.Size = new System.Drawing.Size(128, 21);
            this.cb_users.TabIndex = 4;
            this.cb_users.SelectedIndexChanged += new System.EventHandler(this.cb_users_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_withdrawal);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.btn_user_report);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.btn_customers);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.btn_topuser);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.btn_users);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.cb_users);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.dtp_time_to);
            this.groupBox1.Controls.Add(this.dtp_date_to);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.dtp_time_from);
            this.groupBox1.Controls.Add(this.dtp_date_from);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(134, 495);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 20);
            this.panel5.TabIndex = 13;
            // 
            // btn_customers
            // 
            this.btn_customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.Location = new System.Drawing.Point(3, 334);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(128, 35);
            this.btn_customers.TabIndex = 15;
            this.btn_customers.Text = "العملاء";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 314);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(128, 20);
            this.panel7.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 259);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(128, 20);
            this.panel6.TabIndex = 14;
            // 
            // dtp_time_to
            // 
            this.dtp_time_to.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtp_time_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time_to.Location = new System.Drawing.Point(3, 143);
            this.dtp_time_to.Name = "dtp_time_to";
            this.dtp_time_to.Size = new System.Drawing.Size(128, 20);
            this.dtp_time_to.TabIndex = 11;
            // 
            // dtp_time_from
            // 
            this.dtp_time_from.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtp_time_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time_from.Location = new System.Drawing.Point(3, 73);
            this.dtp_time_from.Name = "dtp_time_from";
            this.dtp_time_from.Size = new System.Drawing.Size(128, 20);
            this.dtp_time_from.TabIndex = 10;
            this.dtp_time_from.Value = new System.DateTime(2020, 1, 1, 1, 1, 0, 0);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 424);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(128, 20);
            this.panel8.TabIndex = 14;
            // 
            // btn_withdrawal
            // 
            this.btn_withdrawal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_withdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdrawal.Location = new System.Drawing.Point(3, 444);
            this.btn_withdrawal.Name = "btn_withdrawal";
            this.btn_withdrawal.Size = new System.Drawing.Size(128, 35);
            this.btn_withdrawal.TabIndex = 16;
            this.btn_withdrawal.Text = "السحوبات";
            this.btn_withdrawal.UseVisualStyleBackColor = true;
            this.btn_withdrawal.Click += new System.EventHandler(this.btn_withdrawal_Click);
            // 
            // _3_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "_3_Reports";
            this.Text = "_3_Reports";
            this.Load += new System.EventHandler(this._3_Reports_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_user_report;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_date_from;
        private System.Windows.Forms.Button btn_topuser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date_to;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_users;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtp_time_to;
        private System.Windows.Forms.DateTimePicker dtp_time_from;
        private System.Windows.Forms.CheckBox chkbox_datetime;
        private System.Windows.Forms.Button btn_withdrawal;
        private System.Windows.Forms.Panel panel8;
    }
}