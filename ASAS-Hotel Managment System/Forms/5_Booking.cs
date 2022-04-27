using ASAS_Hotel_Managment_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASAS_Hotel_Managment_System.Forms
{
    public partial class _5_Booking : Form
    {
        public _5_Booking()
        {
            InitializeComponent();
            var approvedColumn = new DataGridViewImageColumn
            {
                Name = "Approved",
                HeaderText = "حمام داخلي",
                DataPropertyName = "Approved"
            };

            var approvedColumn1 = new DataGridViewImageColumn
            {
                Name = "Approved1",
                HeaderText = "متاحه - محجوزه",

                DataPropertyName = "Approved1"
            };
            var approvedColumn2 = new DataGridViewImageColumn
            {
                Name = "Approved2",
                HeaderText = "متاحه - محجوزه",

                DataPropertyName = "Approved2"
            };
            var approvedColumn3 = new DataGridViewImageColumn
            {
                Name = "Approved3",
                HeaderText = "متاحه - محجوزه",

                DataPropertyName = "Approved3"
            };

        }


        DateTime now = new DateTime();
        DateTime startm = new DateTime();
        DateTime endm = new DateTime();
        //Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext(@"Data Source =AlSHAMELTECK-\TEAM; Initial Catalog = HOTEL; Integrated Security = True");

        Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext();
        _1_Login master = (_1_Login)Application.OpenForms["_1_Login"];

        private void btn_Add_book_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_room_num2.Enabled == false)
                {
                    //endm = DateTime.Now.AddDays(int.Parse(txt_book_dayes.Text));
                    Database.LINQ.Booked_Room book = new Database.LINQ.Booked_Room();
                    book.R_num = int.Parse(txt_Room_num.Text);
                    book.name = txt_Name.Text;
                    book.Entrig_time = DateTime.Now;
                    //book.exing_time = endm.Date;
                    book.price = int.Parse(txt_Price.Text);
                    book.baid_amount = int.Parse(txt_Payment.Text);
                    book.name = txt_Name.Text;
                    db.Booked_Rooms.InsertOnSubmit(book);


                    Database.LINQ.Room rom = db.Rooms.Single(s => s.R_number == int.Parse(txt_Room_num.Text));
                    Database.LINQ.Reservation reserv = new Database.LINQ.Reservation();
                    reserv.Name = txt_Name.Text;
                    reserv.Rooms_ID = rom.ID;
                    reserv.R_Number = int.Parse(txt_Room_num.Text);
                    reserv.Entering_Time = DateTime.Now;
                    reserv.Price = int.Parse(txt_Price.Text);
                    reserv.User_ID = master.User_id;
                    rom.IS_Active = true;


                    //reserv.Exiting_Time = endm.Date;

                    reserv.Details = txt_Notes.Text;
                    reserv.Baid_Amount = int.Parse(txt_Payment.Text);
                    db.Reservations.InsertOnSubmit(reserv);

                    Database.LINQ.Room pr = db.Rooms.Single(s => s.R_number == int.Parse(txt_Room_num.Text));
                    pr.IS_Active = true;
                    db.SubmitChanges();

                    var colo = from c in db.Reservations
                               orderby c.ID descending
                               select c;
                    foreach (var i in colo)
                    {
                        if (i.R_Number == int.Parse(txt_Room_num.Text))
                        {
                            Database.LINQ.baid_amount baid = new Database.LINQ.baid_amount();
                            baid.reservertion_id = i.ID;
                            baid.user_id = master.User_id;
                            baid.date = DateTime.Now;
                            baid.baid_amount1 = int.Parse(txt_Payment.Text);
                            db.baid_amounts.InsertOnSubmit(baid);
                            break;
                        }
                    }
                    db.SubmitChanges();

                    MessageBox.Show("تمت الاضافة بنجاح");
                    txt_Room_num.Clear();
                    txt_Remains.Clear();
                    txt_Price.Clear();
                    txt_Payment.Clear();
                    txt_Notes.Clear();
                    txt_Name.Clear();
                    //txt_book_dayes.Clear();
                }
                else
                {
                    //endm = DateTime.Now.AddDays(int.Parse(txt_book_dayes.Text));
                    Database.LINQ.Booked_Room book = new Database.LINQ.Booked_Room();
                    book.R_num = int.Parse(txt_Room_num.Text);
                    book.name = txt_Name.Text;
                    book.Entrig_time = DateTime.Now;
                    //book.exing_time = endm.Date;
                    book.price = int.Parse(txt_Price.Text);
                    book.baid_amount = int.Parse(txt_Payment.Text);
                    book.name = txt_Name.Text;
                    db.Booked_Rooms.InsertOnSubmit(book);


                    Database.LINQ.Room rom = db.Rooms.Single(s => s.R_number == int.Parse(txt_Room_num.Text));
                    Database.LINQ.Reservation reserv = new Database.LINQ.Reservation();
                    reserv.Name = txt_Name.Text;
                    reserv.Rooms_ID = rom.ID;
                    reserv.R_Number = int.Parse(txt_Room_num.Text);
                    reserv.Entering_Time = DateTime.Now;
                    reserv.Price = int.Parse(txt_Price.Text);
                    rom.IS_Active = true;


                    //reserv.Exiting_Time = endm.Date;

                    reserv.Details = txt_Notes.Text;
                    reserv.Baid_Amount = int.Parse(txt_Payment.Text);
                    db.Reservations.InsertOnSubmit(reserv);

                    Database.LINQ.Room pr = db.Rooms.Single(s => s.R_number == int.Parse(txt_Room_num.Text));
                    pr.IS_Active = true;
                    db.SubmitChanges();
                    var colo = from c in db.Reservations
                               orderby c.ID descending
                               select c;
                    foreach (var i in colo)
                    {
                        if (i.R_Number == int.Parse(txt_Room_num.Text))
                        {
                            Database.LINQ.baid_amount baid = new Database.LINQ.baid_amount();
                            baid.reservertion_id = i.ID;
                            baid.user_id = master.User_id;
                            baid.date = DateTime.Now;
                            baid.baid_amount1 = int.Parse(txt_Payment.Text);
                            db.baid_amounts.InsertOnSubmit(baid);
                            break;
                        }
                    }

                    db.SubmitChanges();


                    ///////////////////////

                    if (txt_room_num2.Text != "")
                    {
                        Database.LINQ.Booked_Room bookk = new Database.LINQ.Booked_Room();
                        bookk.R_num = int.Parse(txt_room_num2.Text);
                        bookk.name = txt_Name.Text;
                        bookk.Entrig_time = DateTime.Now;
                        //bookk.exing_time = endm.Date;
                        //bookk.price = int.Parse(txt_Price.Text);
                        //bookk.baid_amount = int.Parse(txt_Payment.Text);
                        bookk.name = txt_Name.Text;
                        db.Booked_Rooms.InsertOnSubmit(bookk);


                        Database.LINQ.Room romm = db.Rooms.Single(s => s.R_number == int.Parse(txt_room_num2.Text));
                        Database.LINQ.Reservation reservv = new Database.LINQ.Reservation();
                        reservv.Name = txt_Name.Text;
                        reservv.Rooms_ID = romm.ID;
                        reservv.R_Number = int.Parse(txt_room_num2.Text);
                        reservv.Entering_Time = DateTime.Now;
                        //reservv.Price = int.Parse(txt_Price.Text);
                        romm.IS_Active = true;


                        //reservv.Exiting_Time = endm.Date;

                        reservv.Details = txt_Notes.Text;
                        //reservv.Baid_Amount = int.Parse(txt_Payment.Text);
                        db.Reservations.InsertOnSubmit(reservv);

                        Database.LINQ.Room prr = db.Rooms.Single(s => s.R_number == int.Parse(txt_room_num2.Text));
                        prr.IS_Active = true;
                        db.SubmitChanges();

                        foreach (var i in colo)
                        {
                            if (i.R_Number == int.Parse(txt_room_num2.Text))
                            {
                                Database.LINQ.baid_amount baid = new Database.LINQ.baid_amount();
                                baid.user_id = master.User_id;
                                baid.reservertion_id = i.ID;
                                baid.date = DateTime.Now;

                                db.baid_amounts.InsertOnSubmit(baid);
                                break;
                            }
                        }

                        db.SubmitChanges();


                    }
                    //////////////////
                    if (txt_room_num3.Text != "")
                    {
                        Database.LINQ.Booked_Room bookkk = new Database.LINQ.Booked_Room();
                        bookkk.R_num = int.Parse(txt_room_num3.Text);
                        bookkk.name = txt_Name.Text;
                        bookkk.Entrig_time = DateTime.Now;
                        //bookkk.exing_time = endm.Date;
                        //bookkk.price = int.Parse(txt_Price.Text);
                        //bookkk.baid_amount = int.Parse(txt_Payment.Text);
                        bookkk.name = txt_Name.Text;
                        db.Booked_Rooms.InsertOnSubmit(bookkk);


                        Database.LINQ.Room rommm = db.Rooms.Single(s => s.R_number == int.Parse(txt_room_num3.Text));
                        Database.LINQ.Reservation reservvv = new Database.LINQ.Reservation();
                        reservvv.Name = txt_Name.Text;
                        reservvv.Rooms_ID = rommm.ID;
                        reservvv.R_Number = int.Parse(txt_room_num3.Text);
                        reservvv.Entering_Time = DateTime.Now;
                        //reservvv.Price = int.Parse(txt_Price.Text);
                        rommm.IS_Active = true;


                        //reservvv.Exiting_Time = endm.Date;

                        reservvv.Details = txt_Notes.Text;
                        //reservvv.Baid_Amount = int.Parse(txt_Payment.Text);
                        db.Reservations.InsertOnSubmit(reservvv);

                        Database.LINQ.Room prrr = db.Rooms.Single(s => s.R_number == int.Parse(txt_room_num3.Text));
                        prrr.IS_Active = true;
                        db.SubmitChanges();
                        foreach (var i in colo)
                        {
                            if (i.R_Number == int.Parse(txt_room_num3.Text))
                            {
                                Database.LINQ.baid_amount baid = new Database.LINQ.baid_amount();
                                baid.user_id = master.User_id;
                                baid.reservertion_id = i.ID;
                                baid.date = DateTime.Now;

                                db.baid_amounts.InsertOnSubmit(baid);
                                break;
                            }
                        }
                        db.SubmitChanges();


                    }
                    db.SubmitChanges();

                    MessageBox.Show("تمت الاضافة بنجاح");
                    txt_room_num3.Clear();
                    txt_room_num2.Clear();
                    txt_Room_num.Clear();
                    txt_Remains.Clear();
                    txt_Price.Clear();
                    txt_Payment.Clear();
                    txt_Notes.Clear();
                    txt_Name.Clear();
                    //txt_book_dayes.Clear();

                }

                var room = (from comp in db.Rooms
                            orderby comp.R_number
                            select new
                            {
                                comp.ID,

                                comp.R_number,





                                comp.inside_Bath_Room,
                                Approved = comp.inside_Bath_Room == true ? Resources.ok : Resources.cancel,

                                comp.IS_Active,
                                Approved1 = comp.IS_Active == true ? Resources.ok : Resources.cancel,
                                comp.IS_Cleaned,

                                Approved2 = comp.IS_Cleaned == true ? Resources.ok : Resources.cancel,
                                comp.IS_Baid,
                                Approved3 = comp.IS_Baid == true ? Resources.ok : Resources.cancel








                            }).ToList();




                dataGridView1.DataSource = room;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "رقم الغرفه";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "حمام داخلي";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "محجوزه-متاحه";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "تم التنظيف";
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].HeaderText = "تم الدفع";

            }
            catch
            {

            }
        }

        private void _5_Booking_Load(object sender, EventArgs e)
        {
            var romi = from comp in db.Rooms

                       select comp;
            foreach (var z in romi)
            {
                try
                {
                    Database.LINQ.Booked_Room pr = db.Booked_Rooms.Single(s => s.R_num == z.R_number);

                    txt_Price.Text = pr.price.ToString();
                    txt_Payment.Text = pr.baid_amount.ToString();
                    txt_Name.Text = pr.name.ToString();
                    if (pr.price != null)
                    {
                        DateTime dt = DateTime.Now;
                        DateTime q = pr.Entrig_time.Value;
                        int i;
                        if (q.Hour == 13)
                        {
                            i = 0;
                        }
                        else
                        {
                            i = 1;
                        }



                        while (true)
                        {
                            if (q.Hour == 13)
                            {
                                i += 1;


                            }

                            if (q.Day == dt.Day && q.Month == dt.Month && q.Hour == dt.Hour)
                            {

                                break;

                            }

                            q = q.AddHours(1);
                        }

                        var w = i * pr.price;
                        w = w - int.Parse(txt_Payment.Text);
                        if (w <= 0)
                        {
                            z.IS_Baid = true;
                        }
                        if (w > 0)
                        {
                            z.IS_Baid = false;
                        }

                        db.SubmitChanges();
                        //if (int.Parse(txt_Remains.Text) < 0)
                        //{
                        //    int mines = int.Parse(txt_Remains.Text) * -1;
                        //    txt_Remains.Text = mines.ToString();
                        //}
                        txt_Payment.Clear();
                        txt_Price.Clear();
                        txt_Name.Clear();
                    }
                }
                catch
                {

                }

            }





                CB_Select_Room.Text = "غرفة";
            timer1.Start();


            var room = (from comp in db.Rooms
                        orderby comp.R_number
                        select new
                        {
                            comp.ID,

                            comp.R_number,





                            comp.inside_Bath_Room,
                            Approved = comp.inside_Bath_Room == true ? Resources.ok : Resources.cancel,

                            comp.IS_Active,
                            Approved1 = comp.IS_Active == true ? Resources.ok : Resources.cancel,
                            comp.IS_Cleaned,

                            Approved2 = comp.IS_Cleaned == true ? Resources.ok : Resources.cancel,
                            comp.IS_Baid,
                            Approved3 = comp.IS_Baid == true ? Resources.ok : Resources.cancel








                        }).ToList();




            dataGridView1.DataSource = room;
            //dataGridView1.Columns.Add(approvedColumn);
            //dataGridView1.Columns.Add(approvedColumn1);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "رقم الغرفه";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "حمام داخلي";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "محجوزه-متاحه";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "تم التنظيف";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].HeaderText = "تم الدفع";











            _1_Login master = (_1_Login)Application.OpenForms["_1_Login"];
            la_User_name.Text = master.fullname;


        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.CurrentRow.Cells[4].Value.ToString() == "False")
                {
                    btn_Add_book.Enabled = true;
                    btn_Delete_book.Enabled = false;
                    btn_Edit_book.Enabled = false;
                    btn_exit_book.Enabled = false;
                    txt_Name.Clear();
                    txt_Notes.Clear();
                    txt_Payment.Clear();
                    txt_Price.Clear();
                    txt_Remains.Clear();


                    //label7.Text = "ادخل ايام الحجز";
                    if (CB_Select_Room.SelectedItem.ToString() == "جناح")
                    {
                        if (txt_room_num2.Text != "")
                        {
                            txt_room_num3.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            return;
                        }
                        if (txt_Room_num.Text != "")
                        {
                            txt_room_num2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            return;
                        }

                        if (txt_Room_num.Text == "")
                        {
                            txt_Room_num.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            txt_room_num2.Clear();
                            txt_room_num3.Clear();
                        }
                    }
                    else
                    {
                        txt_Room_num.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    }

                }
                else
                {

                    btn_Add_book.Enabled = false;
                    btn_Delete_book.Enabled = true;
                    btn_Edit_book.Enabled = true;
                    btn_exit_book.Enabled = true;
                    //label7.Text = "اضافة ايام للحجز";

                    txt_Room_num.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    Database.LINQ.Booked_Room pr = db.Booked_Rooms.Single(s => s.R_num == int.Parse(txt_Room_num.Text));

                    btn_Edit_book.Enabled = true;
                    if (pr.price == null)
                    {

                        btn_Edit_book.Enabled = false;
                    }
                    txt_Price.Text = pr.price.ToString();
                    txt_Payment.Text = pr.baid_amount.ToString();
                    txt_Name.Text = pr.name.ToString();
                    
                    if (pr.price != null)
                    {
                        DateTime dt = DateTime.Now;
                        DateTime q = pr.Entrig_time.Value;
                        int i;
                        if (q.Hour == 13)
                        {
                            i = 0;
                        }
                        else
                        {
                            i = 1;
                        }



                        while (true)
                        {
                            if (q.Hour == 13)
                            {
                                i += 1;


                            }

                            if (q.Day == dt.Day && q.Month == dt.Month && q.Hour == dt.Hour)
                            {

                                break;

                            }

                            q = q.AddHours(1);
                        }

                        var w = i * pr.price;
                        w = w - int.Parse(txt_Payment.Text);
                        txt_Remains.Text = w.ToString();
                        //if (int.Parse(txt_Remains.Text) < 0)
                        //{
                        //    int mines = int.Parse(txt_Remains.Text) * -1;
                        //    txt_Remains.Text = mines.ToString();
                        //}
                        txt_Payment.Clear();
                        txt_Payment.Text = "0";
                    }
                }
            }
            catch
            {
                MessageBox.Show("يجب اختيار الغرفة بشكل صحيح");
            }
        }

        private void txt_Payment_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (int.Parse(txt_Payment.Text) < 0)
            //    {
            //        MessageBox.Show("يجب ادخال قيمة اكبر من الصفر");
            //        txt_Payment.Clear();
            //    }
            //    else
            //    {
            //        int remain = int.Parse(txt_Price.Text) - int.Parse(txt_Payment.Text);
            //        if (remain >= 0)
            //            txt_Remains.Text = remain.ToString();
            //        else
            //            txt_Remains.Clear();
            //    }
            //}
            //catch
            //{
            //    txt_Remains.Clear();
            //}
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (int.Parse(txt_Price.Text) < 0)
            //    {
            //        MessageBox.Show("يجب ادخال قيمة اكبر من الصفر");
            //        txt_Price.Clear();
            //    }
            //    else
            //    {
            //        int remain = int.Parse(txt_Price.Text) - int.Parse(txt_Payment.Text);
            //        if (remain >= 0)
            //            txt_Remains.Text = remain.ToString();
            //        else
            //            txt_Remains.Clear();
            //    }
            //}
            //catch
            //{
            //    txt_Remains.Clear();
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            now = DateTime.Now;
            //label4.Text = now.ToString();
            la_Date.Text = now.Date.ToString("yyyy/MM/dd");
            la_Time.Text = now.ToString("hh:mm tt");
        }

        private void StartToEnd_Tick(object sender, EventArgs e)
        {



            //var booked = from comp in db.Booked_Rooms
            //             select comp;

            //startm = DateTime.Now;

            //foreach (var i in booked)
            //{
            //    if (startm.Day == i.exing_time.Value.Day && startm.Hour >= 12 && startm.Year == i.exing_time.Value.Year && startm.Month == i.exing_time.Value.Month)
            //    {

            //        var moeny_left = i.price - i.baid_amount;
            //        MessageBox.Show(" انتهى وقت الحجز للغرفة " + i.R_num + "\n " + i.name + " :الاسم " + "\n  المبلغ المتبقي عليه " + moeny_left + "\n الرجاء القيام باخراج الزبون او قم بعمل حجز جديد", "تذكير");

            //    }
            //}






        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{

            //    if (Convert.ToString(row.Cells[3].Value) == "True")
            //    {

            //        row.DefaultCellStyle.BackColor = Color.Red;
            //    }
            //    else
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Green;
            //    }
            //}
        }

        private void btn_Edit_book_Click(object sender, EventArgs e)
        {
            try
            {
                Database.LINQ.Booked_Room pr = db.Booked_Rooms.Single(s => s.R_num == int.Parse(txt_Room_num.Text));
                ////pr.exing_time = pr.exing_time.Value.AddDays(int.Parse(txt_book_dayes.Text));
                pr.price = int.Parse(txt_Price.Text);
                pr.name = txt_Name.Text;
                pr.baid_amount += int.Parse(txt_Payment.Text);

                var colo = from c in db.Reservations
                           orderby c.ID descending
                           select c;
                foreach (var i in colo)
                {
                    if (i.R_Number == int.Parse(txt_Room_num.Text))
                    {
                        //i.Exiting_Time = pr.exing_time.Value.AddDays(int.Parse(txt_book_dayes.Text));
                        i.Price = int.Parse(txt_Price.Text);
                        i.Name = txt_Name.Text;
                        if (txt_Payment.Text != "" && txt_Payment.Text != "0")
                        {

                            i.Baid_Amount += int.Parse(txt_Payment.Text);
                            Database.LINQ.baid_amount baid = new Database.LINQ.baid_amount();
                            baid.user_id = master.User_id;
                            baid.reservertion_id = i.ID;
                            baid.date = DateTime.Now;
                            baid.baid_amount1 = int.Parse(txt_Payment.Text);
                            db.baid_amounts.InsertOnSubmit(baid);
                        }


                        break;
                    }
                }
                db.SubmitChanges();

                MessageBox.Show("تم تعديل البيانات بنجاح");




                var romi = from comp in db.Rooms

                           select comp;
                foreach (var z in romi)
                {
                    try
                    {
                        Database.LINQ.Booked_Room pro = db.Booked_Rooms.Single(s => s.R_num == z.R_number);

                        txt_Price.Text = pro.price.ToString();
                        txt_Payment.Text = pro.baid_amount.ToString();
                        txt_Name.Text = pro.name.ToString();
                        if (pro.price != null)
                        {
                            DateTime dt = DateTime.Now;
                            DateTime q = pro.Entrig_time.Value;
                            int i;
                            if (q.Hour == 13)
                            {
                                i = 0;
                            }
                            else
                            {
                                i = 1;
                            }



                            while (true)
                            {
                                if (q.Hour == 13)
                                {
                                    i += 1;


                                }

                                if (q.Day == dt.Day && q.Month == dt.Month && q.Hour == dt.Hour)
                                {

                                    break;

                                }

                                q = q.AddHours(1);
                            }

                            var w = i * pro.price;
                            w = w - int.Parse(txt_Payment.Text);
                            if (w <= 0)
                            {
                                z.IS_Baid = true;
                            }
                            if (w > 0)
                            {
                                z.IS_Baid = false;
                            }

                            db.SubmitChanges();
                            //if (int.Parse(txt_Remains.Text) < 0)
                            //{
                            //    int mines = int.Parse(txt_Remains.Text) * -1;
                            //    txt_Remains.Text = mines.ToString();
                            //}
                            txt_Payment.Clear();

                        }
                    }
                    catch
                    {

                    }
                }

                var room = (from comp in db.Rooms
                            orderby comp.R_number
                            select new
                            {
                                comp.ID,

                                comp.R_number,





                                comp.inside_Bath_Room,
                                Approved = comp.inside_Bath_Room == true ? Resources.ok : Resources.cancel,

                                comp.IS_Active,
                                Approved1 = comp.IS_Active == true ? Resources.ok : Resources.cancel,
                                comp.IS_Cleaned,

                                Approved2 = comp.IS_Cleaned == true ? Resources.ok : Resources.cancel,
                                comp.IS_Baid,
                                Approved3 = comp.IS_Baid == true ? Resources.ok : Resources.cancel








                            }).ToList();




                dataGridView1.DataSource = room;
                //dataGridView1.Columns.Add(approvedColumn);
                //dataGridView1.Columns.Add(approvedColumn1);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "رقم الغرفه";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "حمام داخلي";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "محجوزه-متاحه";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "تم التنظيف";
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].HeaderText = "تم الدفع"; txt_Room_num.Clear();
                txt_Remains.Clear();
                txt_Price.Clear();
                txt_Payment.Clear();
                txt_Notes.Clear();
                txt_Name.Clear();

            }
            catch
            {

            }
        }
                
            
            

        private void btn_Delete_book_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult reason = MessageBox.Show("هل انت متاكد من مغادرة الزبون ", "مغادرة", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (reason.Equals(DialogResult.OK))
                {


                    Database.LINQ.Booked_Room pr = db.Booked_Rooms.Single(s => s.R_num == int.Parse(txt_Room_num.Text));
                    Database.LINQ.Room rom = db.Rooms.Single(s => s.R_number == int.Parse(txt_Room_num.Text));
                    rom.IS_Active = false;
                    rom.IS_Cleaned = false;
                    db.Booked_Rooms.DeleteOnSubmit(pr);

                    var colo = from c in db.Reservations
                               orderby c.ID descending
                               select c;
                    foreach (var i in colo)
                    {
                        if (i.R_Number == int.Parse(txt_Room_num.Text))
                        {
                            i.Exiting_Time = DateTime.Now;
                            i.Baid_Amount += int.Parse(txt_Payment.Text);



                            break;
                        }
                    }
                    db.SubmitChanges();

                    db.SubmitChanges();
                    MessageBox.Show("تم الحذف بنجاح");
                    txt_Room_num.Clear();
                    txt_Remains.Clear();
                    txt_Price.Clear();
                    txt_Payment.Clear();
                    txt_Notes.Clear();
                    txt_Name.Clear();

                    var room = (from comp in db.Rooms
                                orderby comp.R_number
                                select new
                                {
                                    comp.ID,

                                    comp.R_number,





                                    comp.inside_Bath_Room,
                                    Approved = comp.inside_Bath_Room == true ? Resources.ok : Resources.cancel,

                                    comp.IS_Active,
                                    Approved1 = comp.IS_Active == true ? Resources.ok : Resources.cancel,
                                    comp.IS_Cleaned,

                                    Approved2 = comp.IS_Cleaned == true ? Resources.ok : Resources.cancel,
                                    comp.IS_Baid,
                                    Approved3 = comp.IS_Baid == true ? Resources.ok : Resources.cancel








                                }).ToList();




                    dataGridView1.DataSource = room;
                    //dataGridView1.Columns.Add(approvedColumn);
                    //dataGridView1.Columns.Add(approvedColumn1);
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "رقم الغرفه";
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].HeaderText = "حمام داخلي";
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].HeaderText = "محجوزه-متاحه";
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].HeaderText = "تم التنظيف";
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].HeaderText = "تم الدفع";


                }
            }
            catch
            {

            }
        }



        private void CB_Select_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Select_Room.SelectedItem.ToString() == "جناح")
            {
                label2.Text = "الاجنحه";
                txt_room_num2.Enabled = true;
                txt_room_num3.Enabled = true;
                label10.Enabled = true;
                label7.Enabled = true;

            }
            else
            {
                label2.Text = "الغرف";
                txt_room_num2.Enabled = false;
                txt_room_num3.Enabled = false;
                label10.Enabled = false;
                label7.Enabled = false;
            }
        }

        private void txt_exit_book_Click(object sender, EventArgs e)
        {
            //try
            //{
                DialogResult reason = MessageBox.Show("هل انت متاكد من حذف الزبون ", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (reason.Equals(DialogResult.OK))
                {


                    Database.LINQ.Booked_Room pr = db.Booked_Rooms.Single(s => s.R_num == int.Parse(txt_Room_num.Text));
                    Database.LINQ.Room rom = db.Rooms.Single(s => s.R_number == int.Parse(txt_Room_num.Text));
                    rom.IS_Active = false;
                rom.IS_Baid = true;
                    db.Booked_Rooms.DeleteOnSubmit(pr);

                    var colo = from c in db.Reservations
                               orderby c.ID descending
                               select c;
                    foreach (var i in colo)
                    {
                        if (i.R_Number == int.Parse(txt_Room_num.Text))
                        {
                            db.Reservations.DeleteOnSubmit(i);

                            var coloo = from c in db.baid_amounts
                                        orderby c.id descending
                                        select c;
                            foreach (var z in coloo)
                            {
                                if (i.ID == z.reservertion_id)
                                {
                                    db.baid_amounts.DeleteOnSubmit(z);



                                    break;
                                }
                            }



                            break;
                        }
                    }


                    db.SubmitChanges();
                    txt_Room_num.Clear();
                    txt_Remains.Clear();
                    txt_Price.Clear();
                    txt_Payment.Clear();
                    txt_Notes.Clear();
                    txt_Name.Clear();
                    MessageBox.Show("تم الحذف بنجاح");


                    var room = (from comp in db.Rooms
                                orderby comp.R_number
                                select new
                                {
                                    comp.ID,

                                    comp.R_number,





                                    comp.inside_Bath_Room,
                                    Approved = comp.inside_Bath_Room == true ? Resources.ok : Resources.cancel,

                                    comp.IS_Active,
                                    Approved1 = comp.IS_Active == true ? Resources.ok : Resources.cancel,
                                    comp.IS_Cleaned,

                                    Approved2 = comp.IS_Cleaned == true ? Resources.ok : Resources.cancel,
                                    comp.IS_Baid,
                                    Approved3 = comp.IS_Baid == true ? Resources.ok : Resources.cancel








                                }).ToList();




                    dataGridView1.DataSource = room;
                    //dataGridView1.Columns.Add(approvedColumn);
                    //dataGridView1.Columns.Add(approvedColumn1);
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "رقم الغرفه";
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].HeaderText = "حمام داخلي";
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].HeaderText = "محجوزه-متاحه";
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].HeaderText = "تم التنظيف";
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].HeaderText = "تم الدفع";

                }
            //}
            //catch
            //{

            //}

        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            //dataGridView1.SelectedCells(0);
            btn_Add_book.Enabled = true;
            btn_Delete_book.Enabled = true;
            btn_Edit_book.Enabled = true;
            btn_exit_book.Enabled = true;
            txt_Room_num.Clear();
            txt_Name.Clear();
            txt_Price.Clear();
            txt_Payment.Clear();
            txt_Remains.Clear();
            txt_Notes.Clear();
            txt_room_num2.Clear();
            txt_room_num3.Clear();
        }

        private void txt_room_num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cleannig_Click(object sender, EventArgs e)
        {
            try
            {
                Database.LINQ.Room rom = db.Rooms.Single(s => s.R_number == int.Parse(txt_Room_num.Text));
                rom.IS_Cleaned = true;
                db.SubmitChanges();
                MessageBox.Show("تم التعديل بنجاح");
                var room = (from comp in db.Rooms
                            orderby comp.R_number
                            select new
                            {
                                comp.ID,

                                comp.R_number,





                                comp.inside_Bath_Room,
                                Approved = comp.inside_Bath_Room == true ? Resources.ok : Resources.cancel,

                                comp.IS_Active,
                                Approved1 = comp.IS_Active == true ? Resources.ok : Resources.cancel,
                                comp.IS_Cleaned,

                                Approved2 = comp.IS_Cleaned == true ? Resources.ok : Resources.cancel,
                                comp.IS_Baid,
                                Approved3 = comp.IS_Baid == true ? Resources.ok : Resources.cancel








                            }).ToList();




                dataGridView1.DataSource = room;
                //dataGridView1.Columns.Add(approvedColumn);
                //dataGridView1.Columns.Add(approvedColumn1);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "رقم الغرفه";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "حمام داخلي";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "محجوزه-متاحه";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "تم التنظيف";
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].HeaderText = "تم الدفع";

            }
            catch
            {
                MessageBox.Show("يجب اختيار غرفة اولا");
            }
        }

        private void la_User_name_Click(object sender, EventArgs e)
        {

        }
    }
}

