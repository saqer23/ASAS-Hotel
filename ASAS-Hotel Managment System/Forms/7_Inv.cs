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
    public partial class _7_Inv : Form
    {
        public _7_Inv()
        {
            InitializeComponent();
        }
        Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext();

        private void _7_Inv_Load(object sender, EventArgs e)
        {
            _1_Login master = (_1_Login)Application.OpenForms["_1_Login"];
            txt_Kashear.Text = master.fullname;

            if (master.authen == "true")
            {
                btn_delet.Enabled = true;
                btn_edit.Enabled = true;

            }
            else
            {
                btn_delet.Enabled = false;
                btn_edit.Enabled = false;

            }
            var room = (from comp in db.Cash_Withdrawals

                        select new
                        {
                            comp.cash_id,
                            comp.name,
                            comp.user_name,
                            comp.amount,
                            comp.details,
                            comp.date
                        });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = room;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "الاسم الكامل";
            dataGridView1.Columns[2].HeaderText = "اسم الكاشير";
            dataGridView1.Columns[3].HeaderText = "المبلغ المسحوب";
            dataGridView1.Columns[4].HeaderText = "التفاصيل";
            dataGridView1.Columns[5].HeaderText = "التاريخ"; 


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_Price.Clear();
            txt_detail.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Database.LINQ.Cash_Withdrawal csh = new Database.LINQ.Cash_Withdrawal();
                csh.name = txt_name.Text;
                csh.user_name = txt_Kashear.Text;
                csh.amount = int.Parse(txt_Price.Text);
                csh.details = txt_detail.Text;
                csh.date = DateTime.Now;
                db.Cash_Withdrawals.InsertOnSubmit(csh);
                db.SubmitChanges();
                MessageBox.Show("تمت اضافة الغرفة بنجاح");
                txt_id.Clear();
                txt_name.Clear();
                txt_Price.Clear();
                txt_detail.Clear();
                var room = from comp in db.Cash_Withdrawals

                           select comp;
                dataGridView1.DataSource = room;
            }
            catch
            {
                MessageBox.Show("يجب تعبئة الحقول بشكل صحيح");
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_Kashear.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_Price.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_detail.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("يجب اختيار حقل بشكل صحيح");
            }
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            DialogResult reason = MessageBox.Show("هل انت متاكد من الحذف  ", "حذف سحبية", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reason.Equals(DialogResult.OK))
            {

                Database.LINQ.Cash_Withdrawal rom = db.Cash_Withdrawals.Single(s => s.cash_id == int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                db.Cash_Withdrawals.DeleteOnSubmit(rom);
                db.SubmitChanges();
                MessageBox.Show("تم الحذف بنجاح");
                txt_id.Clear();
                txt_name.Clear();
                txt_Price.Clear();
                txt_detail.Clear();
                var room = from comp in db.Cash_Withdrawals

                           select comp;
                dataGridView1.DataSource = room;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Database.LINQ.Cash_Withdrawal rom = db.Cash_Withdrawals.Single(s => s.cash_id == int.Parse(txt_id.Text));
                rom.name = txt_name.Text;
                rom.user_name = txt_Kashear.Text;
                rom.amount = int.Parse(txt_Price.Text);
                rom.details = txt_detail.Text;


                db.SubmitChanges();
                MessageBox.Show("تم العديل بنجاح");
                txt_id.Clear();
                txt_name.Clear();
                txt_Price.Clear();
                txt_detail.Clear();
            }
            catch
            {
                MessageBox.Show("يجب تعبئة الحقول بشكل صحيح");
            }
        }
    }
}
