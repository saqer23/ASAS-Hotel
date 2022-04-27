using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ASAS_Hotel_Managment_System.Forms
{
    public partial class _1_Login : Form
    {
        public _1_Login()
        {
            InitializeComponent();
        }
        string image_nameDB = "";
        Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext();
        
        //Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext(@"Data Source =AlSHAMELTECK-\TEAM; Initial Catalog = HOTEL; Integrated Security = True");
        public string fullname = "";
        public int User_id;
        public string authen = "";
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var user = (from s in db.Users
                            where s.Username == txt_username.Text &&
                            s.password == txt_password.Text
                            select s).First();
                fullname = user.Full_Name;
                User_id = user.ID;
                if (user.IS_Admin == true)
                {
                    authen = "true";
                }
                else
                {
                    authen = "null";

                }

                _0_Main main = new _0_Main();

                if (user.IS_User == true)
                {
                    main.btn_manage_rooms.Enabled = false;
                    main.btn_users.Enabled = false;
                }
                this.Hide();

                main.Show();

            }
            catch
            {
                MessageBox.Show("عذرا اسم المستخدم او كلمة المرور خطأ");
            }
        }
        public string imagefromdb = "";
        private void _1_Login_Load(object sender, EventArgs e)
        {
            try
            {

                var compoo = (from comp in db.Settings
                             select comp).First();

            image_nameDB = compoo.login_image_db;
                imagefromdb = compoo.main_image_db;

                var AssemblyfullPath = string.Format(@"{0}\ASAS\Hotel Management\Images\{1}", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, image_nameDB);

            //txt_username.Text = AssemblyfullPath;
            pictureBox1.Image = Image.FromFile(AssemblyfullPath);
            }
            catch
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
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
                pictureBox1.Image = Image.FromFile(ofd_image.FileName);
                var AssemblyfullPath = string.Format(@"{0}\ASAS\Hotel Management\Images\{1}", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, ofd_image.SafeFileName);
                try
                {
                    try
                    {
                        File.Copy(Path.GetFullPath(ofd_image.FileName), AssemblyfullPath);
                        


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                    
                    Database.LINQ.Setting ss = db.Settings.Single(s => s.login_image_db == image_nameDB);
                    db.Settings.DeleteOnSubmit(ss);
                    db.SubmitChanges();

                    Database.LINQ.Setting ca = new Database.LINQ.Setting();
                    ca.login_image_db = ofd_image.SafeFileName;
                    ca.main_image_db = imagefromdb;

                    db.Settings.InsertOnSubmit(ca);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

            }

    }
}
