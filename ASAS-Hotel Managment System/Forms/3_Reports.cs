using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASAS_Hotel_Managment_System.Forms
{
    public partial class _3_Reports : Form
    {

        public _3_Reports()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HOTEL;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source =AlSHAMELTECK-\TEAM; Initial Catalog = HOTEL; Integrated Security = True");

        Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext();
        //Database.LINQ.HotelDataContext db = new Database.LINQ.HotelDataContext(@"Data Source =AlSHAMELTECK-\TEAM; Initial Catalog = HOTEL; Integrated Security = True");



        private void _3_Reports_Load(object sender, EventArgs e)
        {
            dtp_date_to.Value = DateTime.Now;
            dtp_time_to.Value = DateTime.Now;
            var compo = from comp in db.Users
                        orderby comp.ID descending
                        select comp;

            foreach (var i in compo)
            {
                cb_users.Items.Add(i.Full_Name);

            }
            _1_Login master = (_1_Login)Application.OpenForms["_1_Login"];

            if (master.authen == "true")
            {
                btn_user_report.Enabled = false;
            }
            else
            {
                btn_user_report.Enabled = true;
                btn_topuser.Enabled = false;
                btn_users.Enabled = false;
                btn_customers.Enabled = false;
                cb_users.Enabled = false;

            }

        }

        private int user_report_id;
        private void cb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            var compo = from comp in db.Users
                        orderby comp.ID descending
                        select comp;

            foreach (var i in compo)
            {
                if (cb_users.Text == i.Full_Name)
                {
                    user_report_id = i.ID;
                    
                }

            }
            if (chkbox_datetime.Checked == true)
            {
 

                string sql = "SELECT [User].Full_Name, Reservation.R_Number, Reservation.Entering_Time, Reservation.Exiting_Time, Reservation.Name, Reservation.Details, Reservation.Price, baid_amount.baid_amount FROM [User] INNER JOIN Reservation ON [User].ID = Reservation.User_ID INNER JOIN baid_amount ON [User].ID = baid_amount.user_id AND Reservation.ID = baid_amount.reservertion_id where [User].ID=" + user_report_id  +"and Entering_Time between" + "'" + dtp_date_from.Text.ToString() + " " + dtp_time_from.Text.ToString() + "'" + " and " + "'" + dtp_date_to.Text.ToString() + " " + dtp_time_to.Text.ToString() + "'" + "order by Reservation.Entering_Time desc";
                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["users_info"]);

                Reports.Users o = new Reports.Users();
                o.SetDataSource(DS.Tables["users_info"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();
            }
            else
            {
                string sql = "SELECT [User].Full_Name, Reservation.R_Number, Reservation.Entering_Time, Reservation.Exiting_Time, Reservation.Name, Reservation.Details, Reservation.Price, baid_amount.baid_amount FROM [User] INNER JOIN Reservation ON [User].ID = Reservation.User_ID INNER JOIN baid_amount ON [User].ID = baid_amount.user_id AND Reservation.ID = baid_amount.reservertion_id where [User].ID="+ user_report_id + "order by Reservation.Entering_Time desc";
                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["users_info"]);

                Reports.Users o = new Reports.Users();
                o.SetDataSource(DS.Tables["users_info"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh(); 
            }
            
          

        }

        private void btn_user_report_Click(object sender, EventArgs e)
        {
            if (chkbox_datetime.Checked == true)
            {
                _1_Login master = (_1_Login)Application.OpenForms["_1_Login"];

                string sql = "SELECT[User].Full_Name,Reservation.R_Number,baid_amount.baid_amount ,baid_amount.[date] FROM  [User] INNER JOIN Reservation ON [User].ID = Reservation.User_ID INNER JOIN baid_amount ON Reservation.ID = baid_amount.reservertion_id where [User].ID=" + master.User_id + "and Entering_Time between" + "'" + dtp_date_from.Text.ToString() + " " + dtp_time_from.Text.ToString() + "'" + " and " + "'" + dtp_date_to.Text.ToString() + " " + dtp_time_to.Text.ToString() + "'" + "order by baid_amount.[date] desc";

                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["User_DT"]);

                Reports.user_Report o = new Reports.user_Report();
                o.SetDataSource(DS.Tables["User_DT"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();
            }
            else
            {
                _1_Login master = (_1_Login)Application.OpenForms["_1_Login"];

                string sql = "SELECT[User].Full_Name,Reservation.R_Number,baid_amount.baid_amount ,baid_amount.[date] FROM  [User] INNER JOIN Reservation ON [User].ID = Reservation.User_ID INNER JOIN baid_amount ON Reservation.ID = baid_amount.reservertion_id where [User].ID="+master.User_id + "order by baid_amount.[date] desc";
                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["User_DT"]);

                Reports.user_Report o = new Reports.user_Report();
                o.SetDataSource(DS.Tables["User_DT"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();
            }
            

        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            new Forms.temp_rep().ShowDialog();
            if (chkbox_datetime.Checked == true)
            {
                
                string sql = "SELECT[User].Full_Name,count(Reservation.R_Number) as R_Number,sum(baid_amount.baid_amount)as baid_amount FROM[User] INNER JOIN Reservation ON[User].ID = Reservation.User_ID INNER JOIN baid_amount ON Reservation.ID = baid_amount.reservertion_id where date between" + "'" + dtp_date_from.Text.ToString() + " " + dtp_time_from.Text.ToString() + "'" + " and " + "'" + dtp_date_to.Text.ToString() + " " + dtp_time_to.Text.ToString() + "'" + " group by[User].Full_Name order by as baid_amount desc";

                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["User_DT"]);

                Reports.Total_Users_Day o = new Reports.Total_Users_Day();
                o.SetDataSource(DS.Tables["User_DT"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();
            }
            else
            {



                string sql = "SELECT[User].Full_Name,count(Reservation.R_Number) as R_Number,sum(baid_amount.baid_amount)as baid_amount FROM[User] INNER JOIN Reservation ON[User].ID = Reservation.User_ID INNER JOIN baid_amount ON Reservation.ID = baid_amount.reservertion_id group by[User].Full_Name order by baid_amount desc";
            Database.DS.User_DS DS = new Database.DS.User_DS();
            SqlDataAdapter dad = new SqlDataAdapter(sql, con);
            dad.Fill(DS.Tables["User_DT"]);


            Reports.Total_Users_Day o = new Reports.Total_Users_Day();
            o.SetDataSource(DS.Tables["User_DT"]);

            crystalReportViewer1.ReportSource = o;
            crystalReportViewer1.Refresh();

            }
        }

        private void btn_topuser_Click(object sender, EventArgs e)
        {
            if (chkbox_datetime.Checked == true)
            {
 

                string sql = "SELECT [User].Full_Name, Reservation.R_Number, Reservation.Entering_Time, Reservation.Exiting_Time, Reservation.Name, Reservation.Details, Reservation.Price, baid_amount.baid_amount,SUM(baid_amount.baid_amount)As total_total FROM [User] INNER JOIN Reservation ON [User].ID = Reservation.User_ID INNER JOIN baid_amount ON [User].ID = baid_amount.user_id AND Reservation.ID = baid_amount.reservertion_id where [User].Full_Name=(select top 1 [User].Full_Name FROM [User] INNER JOIN baid_amount on [User].ID = baid_amount.user_id group by Full_Name,baid_amount.baid_amount order by SUM(baid_amount.baid_amount) desc)"+ "and Entering_Time between" + "'" + dtp_date_from.Text.ToString() + " " + dtp_time_from.Text.ToString() + "'" + " and " + "'" + dtp_date_to.Text.ToString() + " " + dtp_time_to.Text.ToString() + "'" + " group by  Full_Name,Reservation.R_Number,Reservation.Entering_Time,Reservation.Exiting_Time,Reservation.Name,Reservation.Details,Reservation.Price,baid_amount.baid_amount order by Reservation.Entering_Time desc";
                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["TopUserDT"]);

                Reports.Users o = new Reports.Users();
                o.SetDataSource(DS.Tables["TopUserDT"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();
            }
            else
            {
 

                string sql = "SELECT [User].Full_Name, Reservation.R_Number, Reservation.Entering_Time, Reservation.Exiting_Time, Reservation.Name, Reservation.Details, Reservation.Price, baid_amount.baid_amount,SUM(baid_amount.baid_amount)As total_total FROM [User] INNER JOIN Reservation ON [User].ID = Reservation.User_ID INNER JOIN baid_amount ON [User].ID = baid_amount.user_id AND Reservation.ID = baid_amount.reservertion_id where [User].Full_Name=(select top 1 [User].Full_Name FROM [User] INNER JOIN baid_amount on [User].ID = baid_amount.user_id group by Full_Name,baid_amount.baid_amount order by SUM(baid_amount.baid_amount) desc) group by  Full_Name,Reservation.R_Number,Reservation.Entering_Time,Reservation.Exiting_Time,Reservation.Name,Reservation.Details,Reservation.Price,baid_amount.baid_amount order by Reservation.Entering_Time desc";
                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["TopUserDT"]);

                Reports.Users o = new Reports.Users();
                o.SetDataSource(DS.Tables["TopUserDT"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();
            }
    
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            if (chkbox_datetime.Checked == true)
            {
 
                string sql = "SELECT [User].Full_Name, Reservation.R_Number, Reservation.Entering_Time, Reservation.Exiting_Time, Reservation.Name FROM [User] INNER JOIN Reservation ON [User].ID = Reservation.User_ID INNER JOIN baid_amount ON [User].ID = baid_amount.user_id AND Reservation.ID = baid_amount.reservertion_id where Entering_Time between" + "'" + dtp_date_from.Text.ToString() + " " + dtp_time_from.Text.ToString() + "'" + " and " + "'" + dtp_date_to.Text.ToString() + " " + dtp_time_to.Text.ToString() + "'" + " order by Reservation.Entering_Time desc";
                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["customer_DT"]);

                Reports.customer o = new Reports.customer();
                o.SetDataSource(DS.Tables["customer_DT"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();
            }
            else
            {
 
                string sql = "SELECT [User].Full_Name, Reservation.R_Number, Reservation.Entering_Time, Reservation.Exiting_Time, Reservation.Name FROM [User] INNER JOIN Reservation ON [User].ID = Reservation.User_ID INNER JOIN baid_amount ON [User].ID = baid_amount.user_id AND Reservation.ID = baid_amount.reservertion_id order by Reservation.Entering_Time desc";
                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["User_DT"]);

                Reports.customer o = new Reports.customer();
                o.SetDataSource(DS.Tables["User_DT"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();
            }

        }

        private void chkbox_datetime_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkbox_datetime.Checked == true)
            {
                label2.Enabled = true;
                label3.Enabled = true;
                dtp_date_from.Enabled = true;
                dtp_date_to.Enabled = true;
                dtp_time_from.Enabled = true;
                dtp_time_to.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
                label3.Enabled = false;
                dtp_date_from.Enabled = false;
                dtp_date_to.Enabled = false;
                dtp_time_from.Enabled = false;
                dtp_time_to.Enabled = false;

            }
        }

        private void btn_withdrawal_Click(object sender, EventArgs e)
        {
            if (chkbox_datetime.Checked == true)
            {
                string sql = "SELECT name,user_name,amount,details,[date] FROM Cash_Withdrawal where date between" + "'" + dtp_date_from.Text.ToString() + " " + dtp_time_from.Text.ToString() + "'" + " and " + "'" + dtp_date_to.Text.ToString() + " " + dtp_time_to.Text.ToString() + "'";

                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["Withd"]);

                Reports.Cash_Withdrawal o = new Reports.Cash_Withdrawal();
                o.SetDataSource(DS.Tables["Withd"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();
            }
            else
            {

                string sql = "SELECT name, user_name, amount, details, [date] FROM  Cash_Withdrawal";

                Database.DS.User_DS DS = new Database.DS.User_DS();
                SqlDataAdapter dad = new SqlDataAdapter(sql, con);
                dad.Fill(DS.Tables["Withd"]);

                Reports.Cash_Withdrawal o = new Reports.Cash_Withdrawal();
                o.SetDataSource(DS.Tables["Withd"]);

                crystalReportViewer1.ReportSource = o;
                crystalReportViewer1.Refresh();


            }
        }
    }
}
