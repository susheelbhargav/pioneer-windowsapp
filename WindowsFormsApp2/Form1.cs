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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void COMPANYDETAILS_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                string Firstname = FirstNametextbox.Text;
                string Lastname = LastNametextbox.Text;
                string Emailid = Emailidtextbox.Text;
                long MobileNumber = Convert.ToInt64(MobileNumbertextbox.Text);
                long AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumbertextbox.Text);
                string Address1 = Address1textbox.Text;
                string Address2 = Address2textbox.Text;
                string CurrentCountry = CurrentCountrytextbox.Text;
                string HomeCountry = HomeCountrytextbox.Text;
                int Zipcode = Convert.ToInt32(ZipCodetextbox.Text);
                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string mysql = "INSERT INTO EmployeeDetails(FirstName,LastName,Emailid,MobileNumber,AlternateMobileNumber,Address1,Address2,CurrentCountry,HomeCountry,ZipCode) VAlUES ('" + Firstname + "','" + Lastname + "','" + Emailid + "','" + MobileNumber + "','" + AlternateMobileNumber + "','" + Address1 + "','" + Address2 + "','" + CurrentCountry + "','" + HomeCountry + "'," + Zipcode + ")";
                SqlCommand command = new SqlCommand(mysql, mysqlconnection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();





            }
            catch (Exception x)
            {
                MessageBox.Show("an error has occured:" + x.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeName = EmployeeNametextbox.Text;
                long ContactNumber = Convert.ToInt64(ContactNumbertextbox.Text);
                string Website = Websitetextbox.Text;
                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string mysql = "INSERT INTO COMPANYDETAILS(EmployeeName,ContactNumber,Website) VALUES ('" + EmployeeName + "','" + ContactNumber + "','" + Website + "')";
                SqlCommand command = new SqlCommand(mysql, mysqlconnection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();


            }
            catch (Exception x)
            {
                MessageBox.Show("an error has occured:" + x.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string UI = Uitextbox.Text;
                string ProgrammingLanguage = ProgrammingLanguagetextbox.Text;
                string OrmTechnologies = OrmTechnologiestextbox.Text;
                string DataBases = Databasestextbox.Text;
                string TechinicalDetailsUI = TechnicalDetailsUitextbox.Text;
                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string mysql = "INSERT INTO TECHNICALDETAILS (UI,ProgrammingLanguage,OrmTechnologies,Databases,TechnicalDetailsUI) VALUES ('" + UI + "','" + ProgrammingLanguage + "','" + OrmTechnologies + "','" + DataBases + "','" + TechinicalDetailsUI + "')";
                SqlCommand command = new SqlCommand(mysql, mysqlconnection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("an error has occured:" + x.Message);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                string projectName = ProjectNametextbox.Text;
                string clientName = ClientNametextbox.Text;
                string Role = Roletextbox.Text;
                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string mysql = "INSERT INTO PROJECTDETAILS(ProjectName,ClientName,Role) VALUES ('" + ProjectName + "','" + ClientName + "','" + Role + "')";
                SqlCommand command = new SqlCommand(mysql, mysqlconnection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();



            }
            catch (Exception x)

            {
                MessageBox.Show("an error has occured:" + x.Message);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string CourseType = Coursetypetextbox.Text;
                string CourseSpecialization = Coursespecializationtextbox.Text;
                long YearOfPass = Convert.ToInt64(YearOfPasstextbox.Text);
                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string mysql = "INSERT INTO EDUCATIONALDETAILS(CourseType,CourseSpecialization,YearOfPass) VALUES ('" + CourseType + "','" + CourseSpecialization + "','" + YearOfPass + "')";
                SqlCommand command = new SqlCommand(mysql, mysqlconnection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("an error has occured:" + x.Message);

            }


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNametextbox.Text = string.Empty;
                LastNametextbox.Text = string.Empty;
                Emailidtextbox.Text = string.Empty;
                MobileNumbertextbox.Text = string.Empty;
                AlternateMobileNumbertextbox.Text = string.Empty;
                Address1textbox.Text = string.Empty;
                Address2textbox.Text = string.Empty;
                CurrentCountrytextbox.Text = string.Empty;
                HomeCountrytextbox.Text = string.Empty;
                ZipCodetextbox.Text = string.Empty;

            }
            catch (Exception x)
            {
                MessageBox.Show("an error has occured:" + x.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeNametextbox.Text = string.Empty;
                ContactNumbertextbox.Text = string.Empty;
                Websitetextbox.Text = string.Empty;
            }
            catch (Exception x)
            {
                MessageBox.Show("an error has occured:" + x.Message);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Uitextbox.Text = string.Empty;
            ProgrammingLanguagetextbox.Text = string.Empty;
            OrmTechnologiestextbox.Text = string.Empty;
            Databasestextbox.Text = string.Empty;
            TechnicalDetailsUitextbox.Text = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Coursetypetextbox.Text = string.Empty;
            Coursespecializationtextbox.Text = string.Empty;
            YearOfPasstextbox.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ProjectNametextbox.Text = string.Empty;
            ClientNametextbox.Text = string.Empty;
            Roletextbox.Text = string.Empty;
        }
    }
}








