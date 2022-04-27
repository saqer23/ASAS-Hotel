namespace ASAS_Hotel_Managment_System.Forms
{
    partial class _5_Booking
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_Edit_book = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.txt_Room_num = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Payment = new System.Windows.Forms.TextBox();
            this.txt_Remains = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Add_book = new System.Windows.Forms.Button();
            this.la_User_name = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.la_Time = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.la_Date = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Select_Room = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_exit_book = new System.Windows.Forms.Button();
            this.btn_Delete_book = new System.Windows.Forms.Button();
            this.txt_room_num2 = new System.Windows.Forms.TextBox();
            this.txt_room_num3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_cleannig = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_Edit_book
            // 
            this.btn_Edit_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Edit_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_book.Location = new System.Drawing.Point(307, 433);
            this.btn_Edit_book.Name = "btn_Edit_book";
            this.btn_Edit_book.Size = new System.Drawing.Size(92, 41);
            this.btn_Edit_book.TabIndex = 58;
            this.btn_Edit_book.Text = "تعديل الحجز";
            this.btn_Edit_book.UseVisualStyleBackColor = true;
            this.btn_Edit_book.Click += new System.EventHandler(this.btn_Edit_book_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 47);
            this.label9.TabIndex = 56;
            this.label9.Text = "الأسم";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(307, 245);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(92, 26);
            this.txt_Name.TabIndex = 55;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_Notes
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Notes, 4);
            this.txt_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Notes.Location = new System.Drawing.Point(111, 386);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(386, 41);
            this.txt_Notes.TabIndex = 53;
            this.txt_Notes.Text = "ملاحظات";
            this.txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Room_num
            // 
            this.txt_Room_num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Room_num.Enabled = false;
            this.txt_Room_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Room_num.Location = new System.Drawing.Point(405, 245);
            this.txt_Room_num.Name = "txt_Room_num";
            this.txt_Room_num.Size = new System.Drawing.Size(92, 26);
            this.txt_Room_num.TabIndex = 39;
            this.txt_Room_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Price
            // 
            this.txt_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(209, 245);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(92, 26);
            this.txt_Price.TabIndex = 41;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // txt_Payment
            // 
            this.txt_Payment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Payment.Location = new System.Drawing.Point(111, 245);
            this.txt_Payment.Name = "txt_Payment";
            this.txt_Payment.Size = new System.Drawing.Size(92, 26);
            this.txt_Payment.TabIndex = 42;
            this.txt_Payment.TextChanged += new System.EventHandler(this.txt_Payment_TextChanged);
            // 
            // txt_Remains
            // 
            this.txt_Remains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Remains.Enabled = false;
            this.txt_Remains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remains.Location = new System.Drawing.Point(13, 245);
            this.txt_Remains.Name = "txt_Remains";
            this.txt_Remains.Size = new System.Drawing.Size(92, 26);
            this.txt_Remains.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 47);
            this.label5.TabIndex = 32;
            this.label5.Text = "رقم الغرفه";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 47);
            this.label4.TabIndex = 35;
            this.label4.Text = "السعر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 47);
            this.label3.TabIndex = 36;
            this.label3.Text = "الدفع";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 47);
            this.label6.TabIndex = 37;
            this.label6.Text = "المتبقي";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_Add_book
            // 
            this.btn_Add_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_book.Location = new System.Drawing.Point(405, 433);
            this.btn_Add_book.Name = "btn_Add_book";
            this.btn_Add_book.Size = new System.Drawing.Size(92, 41);
            this.btn_Add_book.TabIndex = 38;
            this.btn_Add_book.Text = "اضافة حجز";
            this.btn_Add_book.UseVisualStyleBackColor = true;
            this.btn_Add_book.Click += new System.EventHandler(this.btn_Add_book_Click);
            // 
            // la_User_name
            // 
            this.la_User_name.AutoSize = true;
            this.la_User_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.la_User_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_User_name.Location = new System.Drawing.Point(209, 66);
            this.la_User_name.Name = "la_User_name";
            this.la_User_name.Size = new System.Drawing.Size(92, 33);
            this.la_User_name.TabIndex = 48;
            this.la_User_name.Text = "ASAS Team";
            this.la_User_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.la_User_name.Click += new System.EventHandler(this.la_User_name_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(209, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 33);
            this.label11.TabIndex = 50;
            this.label11.Text = "الموظف";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // la_Time
            // 
            this.la_Time.AutoSize = true;
            this.la_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.la_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_Time.Location = new System.Drawing.Point(111, 66);
            this.la_Time.Name = "la_Time";
            this.la_Time.Size = new System.Drawing.Size(92, 33);
            this.la_Time.TabIndex = 52;
            this.la_Time.Text = "10:10:10";
            this.la_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(111, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 33);
            this.label12.TabIndex = 51;
            this.label12.Text = "الوقت";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // la_Date
            // 
            this.la_Date.AutoSize = true;
            this.la_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.la_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_Date.Location = new System.Drawing.Point(13, 66);
            this.la_Date.Name = "la_Date";
            this.la_Date.Size = new System.Drawing.Size(92, 33);
            this.la_Date.TabIndex = 49;
            this.la_Date.Text = "10:10:1010";
            this.la_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 33);
            this.label8.TabIndex = 47;
            this.label8.Text = "التاريخ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 33);
            this.label1.TabIndex = 45;
            this.label1.Text = "غرفه \\ جناح";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_Select_Room
            // 
            this.CB_Select_Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Select_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Select_Room.FormattingEnabled = true;
            this.CB_Select_Room.Items.AddRange(new object[] {
            "غرفة",
            "جناح"});
            this.CB_Select_Room.Location = new System.Drawing.Point(503, 36);
            this.CB_Select_Room.Name = "CB_Select_Room";
            this.CB_Select_Room.Size = new System.Drawing.Size(485, 28);
            this.CB_Select_Room.TabIndex = 44;
            this.CB_Select_Room.SelectedIndexChanged += new System.EventHandler(this.CB_Select_Room_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 33);
            this.label2.TabIndex = 46;
            this.label2.Text = "الغرف";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(503, 102);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 7);
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(485, 372);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0014F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0014F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.9994F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.9994F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0014F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.997F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.CB_Select_Room, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.la_Date, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.la_Time, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.la_User_name, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Remains, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Payment, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Price, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Room_num, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Add_book, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.btn_Edit_book, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.btn_exit_book, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.btn_Delete_book, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_room_num2, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_room_num3, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_Notes, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.btn_cleannig, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btn_clear, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005529F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00553F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00553F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.827937F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.827937F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.827937F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.827937F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.827937F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.827937F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn_exit_book
            // 
            this.btn_exit_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_exit_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit_book.Location = new System.Drawing.Point(209, 433);
            this.btn_exit_book.Name = "btn_exit_book";
            this.btn_exit_book.Size = new System.Drawing.Size(92, 41);
            this.btn_exit_book.TabIndex = 62;
            this.btn_exit_book.Text = "حذف";
            this.btn_exit_book.UseVisualStyleBackColor = true;
            this.btn_exit_book.Click += new System.EventHandler(this.txt_exit_book_Click);
            // 
            // btn_Delete_book
            // 
            this.btn_Delete_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_book.Location = new System.Drawing.Point(111, 433);
            this.btn_Delete_book.Name = "btn_Delete_book";
            this.btn_Delete_book.Size = new System.Drawing.Size(92, 41);
            this.btn_Delete_book.TabIndex = 59;
            this.btn_Delete_book.Text = "مغادرة";
            this.btn_Delete_book.UseVisualStyleBackColor = true;
            this.btn_Delete_book.Click += new System.EventHandler(this.btn_Delete_book_Click);
            // 
            // txt_room_num2
            // 
            this.txt_room_num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_room_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_num2.Location = new System.Drawing.Point(405, 339);
            this.txt_room_num2.Name = "txt_room_num2";
            this.txt_room_num2.Size = new System.Drawing.Size(92, 26);
            this.txt_room_num2.TabIndex = 60;
            this.txt_room_num2.TextChanged += new System.EventHandler(this.txt_room_num2_TextChanged);
            // 
            // txt_room_num3
            // 
            this.txt_room_num3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_room_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_num3.Location = new System.Drawing.Point(307, 339);
            this.txt_room_num3.Name = "txt_room_num3";
            this.txt_room_num3.Size = new System.Drawing.Size(92, 26);
            this.txt_room_num3.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 47);
            this.label7.TabIndex = 64;
            this.label7.Text = "الغرفه 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(307, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 47);
            this.label10.TabIndex = 64;
            this.label10.Text = "الغرفه3";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cleannig
            // 
            this.btn_cleannig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cleannig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleannig.Location = new System.Drawing.Point(13, 386);
            this.btn_cleannig.Name = "btn_cleannig";
            this.btn_cleannig.Size = new System.Drawing.Size(92, 41);
            this.btn_cleannig.TabIndex = 65;
            this.btn_cleannig.Text = "تنظيف";
            this.btn_cleannig.UseVisualStyleBackColor = true;
            this.btn_cleannig.Click += new System.EventHandler(this.btn_cleannig_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(13, 433);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(92, 41);
            this.btn_clear.TabIndex = 63;
            this.btn_clear.Text = "مسح البيانات";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // _5_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "_5_Booking";
            this.Text = "_5_Booking";
            this.Load += new System.EventHandler(this._5_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_Edit_book;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Select_Room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label la_Date;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label la_Time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Add_book;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Remains;
        private System.Windows.Forms.TextBox txt_Payment;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Room_num;
        private System.Windows.Forms.Button btn_Delete_book;
        private System.Windows.Forms.TextBox txt_room_num2;
        private System.Windows.Forms.TextBox txt_room_num3;
        private System.Windows.Forms.Button btn_exit_book;
        public System.Windows.Forms.Label la_User_name;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_cleannig;
    }
}