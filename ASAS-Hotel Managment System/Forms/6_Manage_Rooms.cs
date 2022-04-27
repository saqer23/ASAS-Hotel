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
    public partial class _6_Manage_Rooms : Form
    {
        public _6_Manage_Rooms()
        {
            InitializeComponent();
        }
        //Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext(@"Data Source =AlSHAMELTECK-\TEAM; Initial Catalog = HOTEL; Integrated Security = True");

        Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext();
        private void _6_Manage_Rooms_Load(object sender, EventArgs e)
        {


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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Database.LINQ.Room rom = new Database.LINQ.Room();
                rom.R_number = int.Parse(txt_R_number.Text);
                if (CB_Bath.SelectedItem.ToString() == "نعم")
                {
                    rom.inside_Bath_Room = true;
                }
                if (CB_Bath.SelectedItem.ToString() == "لا")
                {
                    rom.inside_Bath_Room = false;
                }
                rom.IS_Active = false;
                rom.IS_Baid = true;
                rom.IS_Cleaned = true;
                db.Rooms.InsertOnSubmit(rom);
                db.SubmitChanges();
                MessageBox.Show("تمت اضافة الغرفة بنجاح");

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
                MessageBox.Show("يجب تعبئة الحقول بشكل صحيح");
            }
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult reason = MessageBox.Show("هل انت متاكد من حذف الغرفة ", "حذف غرفة", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reason.Equals(DialogResult.OK))
            {
                if (this.dataGridView1.CurrentRow.Cells[3].Value.ToString() == "True")
                {
                    MessageBox.Show("لا يمكن حذف الغرفة حتى يخرج الزبون من الغرفة.");
                }
                else
                {
                    Database.LINQ.Room rom = db.Rooms.Single(s => s.ID == int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    db.Rooms.DeleteOnSubmit(rom);
                    var res = from comp in db.Reservations

                              select comp;
                    foreach (var i in res)
                    {
                        if (i.Rooms_ID == rom.ID)
                        {
                            i.Rooms_ID = null;
                        }
                    }
                    db.SubmitChanges();
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
            }
            catch
            {

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.CurrentRow.Cells[3].Value.ToString() == "True")
                {
                    MessageBox.Show("لايمكن تعديل الغرفة حتى يخرج الزبون منها");
                }
                else
                {
                    txt_ID.Visible = true;
                    txt_R_number.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    if (this.dataGridView1.CurrentRow.Cells[2].Value.ToString() == "True")
                    {
                        CB_Bath.Text = "نعم";
                    }
                    else
                    {
                        CB_Bath.Text = "لا";
                    }
                }
            }
            catch
            {
                MessageBox.Show("يجب اختير الحقول بشكل صحيح");
            }
        }

        private void txt_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Database.LINQ.Room rom = db.Rooms.Single(s => s.ID == int.Parse(txt_ID.Text));
                rom.R_number = int.Parse(txt_R_number.Text);

                if (CB_Bath.SelectedItem.ToString() == "نعم")
                {
                    rom.inside_Bath_Room = true;
                }
                if (CB_Bath.SelectedItem.ToString() == "لا")
                {
                    rom.inside_Bath_Room = false;
                }
                db.SubmitChanges();
                MessageBox.Show("تم العديل بنجاح");
                txt_ID.Clear();
                txt_ID.Visible = false;
                txt_R_number.Clear();
                CB_Bath.Text = "";
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
                MessageBox.Show("يجب اختيار حقل اولا");
            }

        }
    }
}