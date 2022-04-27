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
    public partial class temp_rep : Form
    {
        public temp_rep()
        {
            InitializeComponent();
        }
        Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext();

        private void temp_rep_Load(object sender, EventArgs e)
        {
            var prodctype = from s in db.baid_amounts
                          
                            join d in db.Users

                            on s.user_id equals d.ID into empDept


                            from ed in empDept.DefaultIfEmpty()
                            

                            join qw in db.Reservations

                          on s.reservertion_id equals qw.ID into empDeptt

                            from qq in empDeptt.DefaultIfEmpty()

                            select new
                            {
                                
                                ed.Full_Name,
                                s.baid_amount1,
                                qq.R_Number



                            };
            dataGridView1.DataSource = prodctype;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var prodctype = from s in db.baid_amounts

                                join d in db.Users

                                on s.user_id equals d.ID into empDept


                                from ed in empDept.DefaultIfEmpty()
                                where ed.Username.Contains(textBox1.Text)

                                join qw in db.Reservations

                              on s.reservertion_id equals qw.ID into empDeptt

                                from qq in empDeptt.DefaultIfEmpty()

                                select new
                                {

                                    ed.Full_Name,
                                    s.baid_amount1,
                                    qq.R_Number



                                };
                dataGridView1.DataSource = prodctype;
            }
            catch
            {
                var prodctype = from s in db.baid_amounts

                                join d in db.Users

                                on s.user_id equals d.ID into empDept


                                from ed in empDept.DefaultIfEmpty()
                               

                                join qw in db.Reservations

                              on s.reservertion_id equals qw.ID into empDeptt

                                from qq in empDeptt.DefaultIfEmpty()

                                select new
                                {

                                    ed.Full_Name,
                                    s.baid_amount1,
                                    qq.R_Number



                                };
                dataGridView1.DataSource = prodctype;
            }
    }
    }
}