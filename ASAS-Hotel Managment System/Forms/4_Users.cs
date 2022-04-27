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
    public partial class _4_Users : Form
    {
        public _4_Users()
        {
            InitializeComponent();
            var approvedColumn = new DataGridViewImageColumn
            {
                Name = "Approved",
                HeaderText = "صلاحيه مدير",
                DataPropertyName = "Approved"
            };

            var approvedColumn1 = new DataGridViewImageColumn
            {
                Name = "Approved1",
                HeaderText = "صلاحيه موظف",
                DataPropertyName = "Approved1"
            };
        }
        //Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext(@"Data Source =AlSHAMELTECK-\TEAM; Initial Catalog = HOTEL; Integrated Security = True");

        Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext();

        private void _4_Users_Load(object sender, EventArgs e)
        {
           
            var user = (from userr in db.Users
                        select new
                       {
                            userr.ID,
                            userr.Full_Name,
                            userr.Username,
                            userr.password,
                            userr.Phone_Number,
                            userr.Salary,
                            userr.IS_Admin,
                            userr.IS_User,
                            Approved = userr.IS_Admin.ToString() == "true" ? Resources.ok : Resources.cancel,
                            Approved1 = userr.IS_User.ToString() == "true" ? Resources.ok : Resources.cancel
                        }).ToList();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = user;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "الاسم الكامل";
            dataGridView1.Columns[2].HeaderText = "اسم المستخدم";
            dataGridView1.Columns[3].HeaderText = "كلمه المرور";
            dataGridView1.Columns[4].HeaderText = "رقم الجوال";
            dataGridView1.Columns[5].HeaderText = "الراتب";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "صلاحيه مدير";
            dataGridView1.Columns[9].HeaderText = "صلاحيه موظف";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Database.LINQ.User us = new Database.LINQ.User();
                us.Full_Name = txt_Fullname.Text;
                us.password = txt_password.Text;
                us.Salary = int.Parse(txt_Salary.Text);
                us.Phone_Number = int.Parse(txt_phone.Text);
                us.Username = txt_username.Text;

                if (CB_Auth.SelectedItem.ToString() == "مدير")
                {

                    us.IS_Admin = true;
                }
                if (CB_Auth.SelectedItem.ToString() == "موظف")
                {

                    us.IS_User = true;
                }
                db.Users.InsertOnSubmit(us);
                db.SubmitChanges();
                MessageBox.Show("تمت الاضافة بنجاح");
                txt_Fullname.Clear();
                txt_username.Clear();
                txt_phone.Clear();
                txt_Salary.Clear();
                txt_password.Clear();
                CB_Auth.Text = "";
                var user = (from userr in db.Users
                            select new
                            {
                                userr.ID,
                                userr.Full_Name,
                                userr.Username,
                                userr.password,
                                userr.Phone_Number,
                                userr.Salary,
                                userr.IS_Admin,
                                userr.IS_User,
                                Approved = userr.IS_Admin.ToString() == "true" ? Resources.ok : Resources.cancel,
                                Approved1 = userr.IS_User.ToString() == "true" ? Resources.ok : Resources.cancel
                            }).ToList();
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = user;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "الاسم الكامل";
                dataGridView1.Columns[2].HeaderText = "اسم المستخدم";
                dataGridView1.Columns[3].HeaderText = "كلمه المرور";
                dataGridView1.Columns[4].HeaderText = "رقم الجوال";
                dataGridView1.Columns[5].HeaderText = "الراتب";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].HeaderText = "صلاحيه مدير";
                dataGridView1.Columns[9].HeaderText = "صلاحيه موظف";
            }
            catch
            {
                MessageBox.Show("يجب تعبئة جميع الحقول بشكل صحيح");
            }
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            try
            {
                var res = from comp in db.Reservations

                          select comp;
                foreach (var i in res)
                {
                    if (i.User_ID == int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())
    )
                    {
                        i.User_ID = null;
                    }
                }




                db.SubmitChanges();



                var bid = from comp in db.baid_amounts

                          select comp;
                foreach (var i in bid)
                {
                    if (i.user_id == int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())
    )
                    {
                        i.user_id = null;
                    }
                }
                db.SubmitChanges();
                DialogResult reason = MessageBox.Show("هل انت متاكد من حذف المستخدم ", "حذف مستخدم", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reason.Equals(DialogResult.OK))
            {
                    Database.LINQ.Room rom = db.Rooms.Single(s => s.ID == int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    db.Rooms.DeleteOnSubmit(rom);
                    var rrom = from comp in db.Reservations

                              select comp;
                    foreach (var i in rrom)
                    {
                        if (i.Rooms_ID == rom.ID)
                        {
                            i.Rooms_ID = null;
                        }
                    }


                    Database.LINQ.User uss = db.Users.Single(s => s.ID == int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                db.Users.DeleteOnSubmit(uss);
                db.SubmitChanges();
                MessageBox.Show("تم الحذف بنجاح");

                var user = (from userr in db.Users
                            select new
                            {
                                userr.ID,
                                userr.Full_Name,
                                userr.Username,
                                userr.password,
                                userr.Phone_Number,
                                userr.Salary,
                                userr.IS_Admin,
                                userr.IS_User,
                                Approved = userr.IS_Admin.ToString() == "true" ? Resources.ok : Resources.cancel,
                                Approved1 = userr.IS_User.ToString() == "true" ? Resources.ok : Resources.cancel
                            }).ToList();
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = user;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "الاسم الكامل";
                dataGridView1.Columns[2].HeaderText = "اسم المستخدم";
                dataGridView1.Columns[3].HeaderText = "كلمه المرور";
                dataGridView1.Columns[4].HeaderText = "رقم الجوال";
                dataGridView1.Columns[5].HeaderText = "الراتب";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].HeaderText = "صلاحيه مدير";
                dataGridView1.Columns[9].HeaderText = "صلاحيه موظف";
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
}

        private void txt_edit_Click(object sender, EventArgs e)
        {
            try {
                Database.LINQ.User us = db.Users.Single(s => s.ID == int.Parse(txt_ID.Text));
                us.Full_Name = txt_Fullname.Text;
                us.password = txt_password.Text;
                us.Phone_Number = int.Parse(txt_phone.Text);
                us.Salary = int.Parse(txt_Salary.Text);
                us.Username = txt_username.Text;
                if (CB_Auth.SelectedItem.ToString() == "مدير")
                {

                    us.IS_Admin = true;
                    us.IS_User = null;
                }
                if (CB_Auth.SelectedItem.ToString() == "موظف")
                {

                    us.IS_User = true;
                    us.IS_Admin = null;
                }

                db.SubmitChanges();
                MessageBox.Show("تم التعديل بنجاح");
                txt_ID.Clear();
                txt_ID.Visible = false;
                var user = (from userr in db.Users
                            select new
                            {
                                userr.ID,
                                userr.Full_Name,
                                userr.Username,
                                userr.password,
                                userr.Phone_Number,
                                userr.Salary,
                                userr.IS_Admin,
                                userr.IS_User,
                                Approved = userr.IS_Admin.ToString() == "true" ? Resources.ok : Resources.cancel,
                                Approved1 = userr.IS_User.ToString() == "true" ? Resources.ok : Resources.cancel
                            }).ToList();
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = user;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "الاسم الكامل";
                dataGridView1.Columns[2].HeaderText = "اسم المستخدم";
                dataGridView1.Columns[3].HeaderText = "كلمه المرور";
                dataGridView1.Columns[4].HeaderText = "رقم الجوال";
                dataGridView1.Columns[5].HeaderText = "الراتب";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].HeaderText = "صلاحيه مدير";
                dataGridView1.Columns[9].HeaderText = "صلاحيه موظف";
                txt_Fullname.Clear();
                txt_username.Clear();
                txt_phone.Clear();
                txt_Salary.Clear();
                txt_password.Clear();
                CB_Auth.Text = "";
                
            }
            catch
            {
                MessageBox.Show("يجب اختيار حقل اولا");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //txt_ID.Visible = true;
                txt_password.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_username.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_Salary.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_phone.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_Fullname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    if (this.dataGridView1.CurrentRow.Cells[6].Value.ToString() == "True")
                    {
                        CB_Auth.Text = "مدير";
                    }
                }
                catch
                {
                  if(this.dataGridView1.CurrentRow.Cells[7].Value.ToString() == "True")
                {
                        CB_Auth.Text = "موظف";
                    }
                }
            
        }
            catch
            {
                MessageBox.Show("يجب اختيار الحق بشكل صحيح");
            }
}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Fullname.Clear();
            CB_Auth.Text = "";
            txt_username.Clear();
            txt_password.Clear();
            txt_ID.Clear();
            txt_phone.Clear();
            txt_Salary.Clear();
        }

        private void CB_Auth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
