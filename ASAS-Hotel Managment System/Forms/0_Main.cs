using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASAS_Hotel_Managment_System.Forms
{
    public partial class _0_Main : Form
    {
        public _0_Main()
        {
            InitializeComponent();
        }
        string image_nameDB = "";
        //Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext(@"Data Source =AlSHAMELTECK-\TEAM; Initial Catalog = HOTEL; Integrated Security = True");

       Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext();
        private Form activeForm = null;
        string chBGimage = "";

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCihildContainer.BackgroundImage = null;
            label1.Visible = false;
            panelCihildContainer.Controls.Add(activeForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public string imagefromdblog = "";
        private void _0_Main_Load(object sender, EventArgs e)
        {

            try
            {

                var compoo = (from comp in db.Settings
                              select comp).First();


                image_nameDB = compoo.main_image_db;
                imagefromdblog = compoo.login_image_db;
                var AssemblyfullPath = string.Format(@"{0}\ASAS\Hotel Management\Images\{1}", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, image_nameDB);

                //txt_username.Text = AssemblyfullPath;
                chBGimage = AssemblyfullPath;
                panelCihildContainer.BackgroundImage = Image.FromFile(AssemblyfullPath);
            }
            catch
            {

            }


        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms._5_Booking());
        }

        private void btn_manage_rooms_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms._6_Manage_Rooms());
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms._4_Users());

        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms._3_Reports());

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
           new Forms._2_About().ShowDialog();

        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            DialogResult reason = MessageBox.Show("هل انت متاكد من تسجيل الخروج ", "أغلاق Hotel Management System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reason.Equals(DialogResult.OK))
            {
                this.Close();
                _1_Login login = (_1_Login)Application.OpenForms["_1_Login"];
                login.Show();
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

            string image_path = @"C:\\";
            OpenFileDialog ofd_image = new OpenFileDialog();
            ofd_image.Title = "اختيار صوره";
            ofd_image.InitialDirectory = image_path;
            ofd_image.Multiselect = false;
            //ofd_image.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            ofd_image.Filter = "Image files (*.png)|*.png";
            if (ofd_image.ShowDialog() != DialogResult.Cancel)
            {
                image_path = Path.GetDirectoryName(ofd_image.FileName);
                panelCihildContainer.BackgroundImage = Image.FromFile(ofd_image.FileName);
                var AssemblyfullPath = string.Format(@"{0}\ASAS\Hotel Management\Images\{1}", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, image_nameDB);
                try
                {
                    try
                    {
                        File.Copy(Path.GetFullPath(ofd_image.FileName), AssemblyfullPath);
                    }
                    catch
                    {

                    }


                    Database.LINQ.Setting ss = db.Settings.Single(s => s.main_image_db == image_nameDB);
                    db.Settings.DeleteOnSubmit(ss);
                    db.SubmitChanges();

                    Database.LINQ.Setting ca = new Database.LINQ.Setting();
                    ca.main_image_db = ofd_image.SafeFileName;
                    ca.login_image_db = imagefromdblog;
                    db.Settings.InsertOnSubmit(ca);
                    db.SubmitChanges();
                }
                catch
                {

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            { 
            activeForm.Close();
            label1.Visible = true;
            panelCihildContainer.BackgroundImage = Image.FromFile(chBGimage);
            }
            catch
            {

            }



        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            new Forms._7_Inv().ShowDialog();

        }
    }
}
