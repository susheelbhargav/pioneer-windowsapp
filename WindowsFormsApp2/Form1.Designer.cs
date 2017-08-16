using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EMPLOYEEDETAILS = new System.Windows.Forms.TabPage();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ZipCode = new System.Windows.Forms.Label();
            this.ZipCodetextbox = new System.Windows.Forms.TextBox();
            this.HomeCountry = new System.Windows.Forms.Label();
            this.HomeCountrytextbox = new System.Windows.Forms.TextBox();
            this.CurrentCountry = new System.Windows.Forms.Label();
            this.CurrentCountrytextbox = new System.Windows.Forms.TextBox();
            this.Address2 = new System.Windows.Forms.Label();
            this.Address2textbox = new System.Windows.Forms.TextBox();
            this.Address1 = new System.Windows.Forms.Label();
            this.Address1textbox = new System.Windows.Forms.TextBox();
            this.AlternateMobileNumber = new System.Windows.Forms.Label();
            this.AlternateMobileNumbertextbox = new System.Windows.Forms.TextBox();
            this.MobileNumber = new System.Windows.Forms.Label();
            this.MobileNumbertextbox = new System.Windows.Forms.TextBox();
            this.EmailId = new System.Windows.Forms.Label();
            this.Emailidtextbox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.LastNametextbox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.FirstNametextbox = new System.Windows.Forms.TextBox();
            this.EmployeeId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.COMPANYDETAILS = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Websitetextbox = new System.Windows.Forms.TextBox();
            this.ContactNumbertextbox = new System.Windows.Forms.TextBox();
            this.EmployeeNametextbox = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.website = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TECHNICALDETAILS = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TechnicalDetailsUi = new System.Windows.Forms.Label();
            this.TechnicalDetailsUitextbox = new System.Windows.Forms.TextBox();
            this.Databases = new System.Windows.Forms.Label();
            this.Databasestextbox = new System.Windows.Forms.TextBox();
            this.OrmTechnologies = new System.Windows.Forms.Label();
            this.OrmTechnologiestextbox = new System.Windows.Forms.TextBox();
            this.ProgrammingLanguage = new System.Windows.Forms.Label();
            this.ProgrammingLanguagetextbox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Uitextbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.EDUCATIONALDETAILS = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.YearOfPass = new System.Windows.Forms.Label();
            this.YearOfPasstextbox = new System.Windows.Forms.TextBox();
            this.CourseSpecialization = new System.Windows.Forms.Label();
            this.Coursespecializationtextbox = new System.Windows.Forms.TextBox();
            this.CourseType = new System.Windows.Forms.Label();
            this.Coursetypetextbox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.PROJECTDETAILS = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Role = new System.Windows.Forms.Label();
            this.Roletextbox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.Label();
            this.ClientNametextbox = new System.Windows.Forms.TextBox();
            this.ProjectNametextbox = new System.Windows.Forms.TextBox();
            this.ProjectName = new System.Windows.Forms.Label();
            this.ProjectId = new System.Windows.Forms.Label();
            this.ProjectIdtextbox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.EMPLOYEEDETAILS.SuspendLayout();
            this.COMPANYDETAILS.SuspendLayout();
            this.TECHNICALDETAILS.SuspendLayout();
            this.EDUCATIONALDETAILS.SuspendLayout();
            this.PROJECTDETAILS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EMPLOYEEDETAILS);
            this.tabControl1.Controls.Add(this.COMPANYDETAILS);
            this.tabControl1.Controls.Add(this.TECHNICALDETAILS);
            this.tabControl1.Controls.Add(this.EDUCATIONALDETAILS);
            this.tabControl1.Controls.Add(this.PROJECTDETAILS);
            this.tabControl1.Location = new System.Drawing.Point(29, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // EMPLOYEEDETAILS
            // 
            this.EMPLOYEEDETAILS.Controls.Add(this.Clear);
            this.EMPLOYEEDETAILS.Controls.Add(this.Save);
            this.EMPLOYEEDETAILS.Controls.Add(this.ZipCode);
            this.EMPLOYEEDETAILS.Controls.Add(this.ZipCodetextbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.HomeCountry);
            this.EMPLOYEEDETAILS.Controls.Add(this.HomeCountrytextbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.CurrentCountry);
            this.EMPLOYEEDETAILS.Controls.Add(this.CurrentCountrytextbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.Address2);
            this.EMPLOYEEDETAILS.Controls.Add(this.Address2textbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.Address1);
            this.EMPLOYEEDETAILS.Controls.Add(this.Address1textbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.AlternateMobileNumber);
            this.EMPLOYEEDETAILS.Controls.Add(this.AlternateMobileNumbertextbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.MobileNumber);
            this.EMPLOYEEDETAILS.Controls.Add(this.MobileNumbertextbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.EmailId);
            this.EMPLOYEEDETAILS.Controls.Add(this.Emailidtextbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.LastName);
            this.EMPLOYEEDETAILS.Controls.Add(this.LastNametextbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.FirstName);
            this.EMPLOYEEDETAILS.Controls.Add(this.FirstNametextbox);
            this.EMPLOYEEDETAILS.Controls.Add(this.EmployeeId);
            this.EMPLOYEEDETAILS.Controls.Add(this.textBox1);
            this.EMPLOYEEDETAILS.Location = new System.Drawing.Point(4, 22);
            this.EMPLOYEEDETAILS.Name = "EMPLOYEEDETAILS";
            this.EMPLOYEEDETAILS.Padding = new System.Windows.Forms.Padding(3);
            this.EMPLOYEEDETAILS.Size = new System.Drawing.Size(612, 346);
            this.EMPLOYEEDETAILS.TabIndex = 0;
            this.EMPLOYEEDETAILS.Text = "EMPLOYEEDETAILS";
            this.EMPLOYEEDETAILS.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(316, 320);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(77, 317);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 22;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZipCode
            // 
            this.ZipCode.AutoSize = true;
            this.ZipCode.Location = new System.Drawing.Point(77, 283);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(54, 13);
            this.ZipCode.TabIndex = 21;
            this.ZipCode.Text = "ZIPCODE";
            // 
            // ZipCodetextbox
            // 
            this.ZipCodetextbox.Location = new System.Drawing.Point(316, 283);
            this.ZipCodetextbox.Name = "ZipCodetextbox";
            this.ZipCodetextbox.Size = new System.Drawing.Size(118, 20);
            this.ZipCodetextbox.TabIndex = 20;
            // 
            // HomeCountry
            // 
            this.HomeCountry.AutoSize = true;
            this.HomeCountry.Location = new System.Drawing.Point(77, 257);
            this.HomeCountry.Name = "HomeCountry";
            this.HomeCountry.Size = new System.Drawing.Size(92, 13);
            this.HomeCountry.TabIndex = 19;
            this.HomeCountry.Text = "HOMECOUNTRY";
            // 
            // HomeCountrytextbox
            // 
            this.HomeCountrytextbox.Location = new System.Drawing.Point(316, 257);
            this.HomeCountrytextbox.Name = "HomeCountrytextbox";
            this.HomeCountrytextbox.Size = new System.Drawing.Size(118, 20);
            this.HomeCountrytextbox.TabIndex = 18;
            // 
            // CurrentCountry
            // 
            this.CurrentCountry.AutoSize = true;
            this.CurrentCountry.Location = new System.Drawing.Point(74, 231);
            this.CurrentCountry.Name = "CurrentCountry";
            this.CurrentCountry.Size = new System.Drawing.Size(113, 13);
            this.CurrentCountry.TabIndex = 17;
            this.CurrentCountry.Text = "CURRENTCOUNTRY";
            // 
            // CurrentCountrytextbox
            // 
            this.CurrentCountrytextbox.Location = new System.Drawing.Point(316, 231);
            this.CurrentCountrytextbox.Name = "CurrentCountrytextbox";
            this.CurrentCountrytextbox.Size = new System.Drawing.Size(118, 20);
            this.CurrentCountrytextbox.TabIndex = 16;
            // 
            // Address2
            // 
            this.Address2.AutoSize = true;
            this.Address2.Location = new System.Drawing.Point(74, 207);
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(65, 13);
            this.Address2.TabIndex = 15;
            this.Address2.Text = "ADDRESS2";
            // 
            // Address2textbox
            // 
            this.Address2textbox.Location = new System.Drawing.Point(316, 207);
            this.Address2textbox.Name = "Address2textbox";
            this.Address2textbox.Size = new System.Drawing.Size(118, 20);
            this.Address2textbox.TabIndex = 14;
            // 
            // Address1
            // 
            this.Address1.AutoSize = true;
            this.Address1.Location = new System.Drawing.Point(74, 181);
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(65, 13);
            this.Address1.TabIndex = 13;
            this.Address1.Text = "ADDRESS1";
            // 
            // Address1textbox
            // 
            this.Address1textbox.Location = new System.Drawing.Point(316, 181);
            this.Address1textbox.Name = "Address1textbox";
            this.Address1textbox.Size = new System.Drawing.Size(118, 20);
            this.Address1textbox.TabIndex = 12;
            // 
            // AlternateMobileNumber
            // 
            this.AlternateMobileNumber.AutoSize = true;
            this.AlternateMobileNumber.Location = new System.Drawing.Point(74, 155);
            this.AlternateMobileNumber.Name = "AlternateMobileNumber";
            this.AlternateMobileNumber.Size = new System.Drawing.Size(158, 13);
            this.AlternateMobileNumber.TabIndex = 11;
            this.AlternateMobileNumber.Text = "ALTERNATEMOBILENUMBER";
            // 
            // AlternateMobileNumbertextbox
            // 
            this.AlternateMobileNumbertextbox.Location = new System.Drawing.Point(316, 155);
            this.AlternateMobileNumbertextbox.Name = "AlternateMobileNumbertextbox";
            this.AlternateMobileNumbertextbox.Size = new System.Drawing.Size(118, 20);
            this.AlternateMobileNumbertextbox.TabIndex = 10;
            // 
            // MobileNumber
            // 
            this.MobileNumber.AutoSize = true;
            this.MobileNumber.Location = new System.Drawing.Point(74, 129);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(94, 13);
            this.MobileNumber.TabIndex = 9;
            this.MobileNumber.Text = "MOBILENUMBER";
            this.MobileNumber.Click += new System.EventHandler(this.label5_Click);
            // 
            // MobileNumbertextbox
            // 
            this.MobileNumbertextbox.Location = new System.Drawing.Point(316, 129);
            this.MobileNumbertextbox.Name = "MobileNumbertextbox";
            this.MobileNumbertextbox.Size = new System.Drawing.Size(118, 20);
            this.MobileNumbertextbox.TabIndex = 8;
            // 
            // EmailId
            // 
            this.EmailId.AutoSize = true;
            this.EmailId.Location = new System.Drawing.Point(74, 103);
            this.EmailId.Name = "EmailId";
            this.EmailId.Size = new System.Drawing.Size(50, 13);
            this.EmailId.TabIndex = 7;
            this.EmailId.Text = "EMAILID";
            this.EmailId.Click += new System.EventHandler(this.label4_Click);
            // 
            // Emailidtextbox
            // 
            this.Emailidtextbox.Location = new System.Drawing.Point(316, 103);
            this.Emailidtextbox.Name = "Emailidtextbox";
            this.Emailidtextbox.Size = new System.Drawing.Size(118, 20);
            this.Emailidtextbox.TabIndex = 6;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(74, 74);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(65, 13);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "LASTNAME";
            // 
            // LastNametextbox
            // 
            this.LastNametextbox.Location = new System.Drawing.Point(316, 74);
            this.LastNametextbox.Name = "LastNametextbox";
            this.LastNametextbox.Size = new System.Drawing.Size(118, 20);
            this.LastNametextbox.TabIndex = 4;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(74, 48);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(69, 13);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "FIRSTNAME";
            // 
            // FirstNametextbox
            // 
            this.FirstNametextbox.Location = new System.Drawing.Point(316, 48);
            this.FirstNametextbox.Name = "FirstNametextbox";
            this.FirstNametextbox.Size = new System.Drawing.Size(118, 20);
            this.FirstNametextbox.TabIndex = 2;
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Location = new System.Drawing.Point(74, 22);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(76, 13);
            this.EmployeeId.TabIndex = 1;
            this.EmployeeId.Text = "EMPLOYEEID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // COMPANYDETAILS
            // 
            this.COMPANYDETAILS.Controls.Add(this.button4);
            this.COMPANYDETAILS.Controls.Add(this.button3);
            this.COMPANYDETAILS.Controls.Add(this.Websitetextbox);
            this.COMPANYDETAILS.Controls.Add(this.ContactNumbertextbox);
            this.COMPANYDETAILS.Controls.Add(this.EmployeeNametextbox);
            this.COMPANYDETAILS.Controls.Add(this.textBox12);
            this.COMPANYDETAILS.Controls.Add(this.website);
            this.COMPANYDETAILS.Controls.Add(this.ContactNumber);
            this.COMPANYDETAILS.Controls.Add(this.EmployeeName);
            this.COMPANYDETAILS.Controls.Add(this.label12);
            this.COMPANYDETAILS.Location = new System.Drawing.Point(4, 22);
            this.COMPANYDETAILS.Name = "COMPANYDETAILS";
            this.COMPANYDETAILS.Padding = new System.Windows.Forms.Padding(3);
            this.COMPANYDETAILS.Size = new System.Drawing.Size(612, 346);
            this.COMPANYDETAILS.TabIndex = 1;
            this.COMPANYDETAILS.Text = "COMPANYDETAILS";
            this.COMPANYDETAILS.UseVisualStyleBackColor = true;
            this.COMPANYDETAILS.Click += new System.EventHandler(this.COMPANYDETAILS_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(331, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Websitetextbox
            // 
            this.Websitetextbox.Location = new System.Drawing.Point(331, 172);
            this.Websitetextbox.Name = "Websitetextbox";
            this.Websitetextbox.Size = new System.Drawing.Size(100, 20);
            this.Websitetextbox.TabIndex = 9;
            // 
            // ContactNumbertextbox
            // 
            this.ContactNumbertextbox.Location = new System.Drawing.Point(331, 113);
            this.ContactNumbertextbox.Name = "ContactNumbertextbox";
            this.ContactNumbertextbox.Size = new System.Drawing.Size(100, 20);
            this.ContactNumbertextbox.TabIndex = 7;
            // 
            // EmployeeNametextbox
            // 
            this.EmployeeNametextbox.Location = new System.Drawing.Point(331, 84);
            this.EmployeeNametextbox.Name = "EmployeeNametextbox";
            this.EmployeeNametextbox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNametextbox.TabIndex = 6;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(331, 53);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 5;
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Location = new System.Drawing.Point(132, 172);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(56, 13);
            this.website.TabIndex = 4;
            this.website.Text = "WEBSITE";
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSize = true;
            this.ContactNumber.Location = new System.Drawing.Point(132, 113);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(105, 13);
            this.ContactNumber.TabIndex = 2;
            this.ContactNumber.Text = "CONTACTNUMBER";
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Location = new System.Drawing.Point(132, 84);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(96, 13);
            this.EmployeeName.TabIndex = 1;
            this.EmployeeName.Text = "EMPLOYEENAME";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "EMPLOYEEID";
            // 
            // TECHNICALDETAILS
            // 
            this.TECHNICALDETAILS.Controls.Add(this.button6);
            this.TECHNICALDETAILS.Controls.Add(this.button5);
            this.TECHNICALDETAILS.Controls.Add(this.TechnicalDetailsUi);
            this.TECHNICALDETAILS.Controls.Add(this.TechnicalDetailsUitextbox);
            this.TECHNICALDETAILS.Controls.Add(this.Databases);
            this.TECHNICALDETAILS.Controls.Add(this.Databasestextbox);
            this.TECHNICALDETAILS.Controls.Add(this.OrmTechnologies);
            this.TECHNICALDETAILS.Controls.Add(this.OrmTechnologiestextbox);
            this.TECHNICALDETAILS.Controls.Add(this.ProgrammingLanguage);
            this.TECHNICALDETAILS.Controls.Add(this.ProgrammingLanguagetextbox);
            this.TECHNICALDETAILS.Controls.Add(this.label18);
            this.TECHNICALDETAILS.Controls.Add(this.Uitextbox);
            this.TECHNICALDETAILS.Controls.Add(this.label17);
            this.TECHNICALDETAILS.Controls.Add(this.textBox17);
            this.TECHNICALDETAILS.Location = new System.Drawing.Point(4, 22);
            this.TECHNICALDETAILS.Name = "TECHNICALDETAILS";
            this.TECHNICALDETAILS.Padding = new System.Windows.Forms.Padding(3);
            this.TECHNICALDETAILS.Size = new System.Drawing.Size(612, 346);
            this.TECHNICALDETAILS.TabIndex = 2;
            this.TECHNICALDETAILS.Text = "TECHNICALDETAILS";
            this.TECHNICALDETAILS.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(359, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "CLEAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(193, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "SAVE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TechnicalDetailsUi
            // 
            this.TechnicalDetailsUi.AutoSize = true;
            this.TechnicalDetailsUi.Location = new System.Drawing.Point(190, 185);
            this.TechnicalDetailsUi.Name = "TechnicalDetailsUi";
            this.TechnicalDetailsUi.Size = new System.Drawing.Size(123, 13);
            this.TechnicalDetailsUi.TabIndex = 11;
            this.TechnicalDetailsUi.Text = "TECHNICALDETAILSUI";
            // 
            // TechnicalDetailsUitextbox
            // 
            this.TechnicalDetailsUitextbox.Location = new System.Drawing.Point(359, 185);
            this.TechnicalDetailsUitextbox.Name = "TechnicalDetailsUitextbox";
            this.TechnicalDetailsUitextbox.Size = new System.Drawing.Size(100, 20);
            this.TechnicalDetailsUitextbox.TabIndex = 10;
            // 
            // Databases
            // 
            this.Databases.AutoSize = true;
            this.Databases.Location = new System.Drawing.Point(190, 159);
            this.Databases.Name = "Databases";
            this.Databases.Size = new System.Drawing.Size(71, 13);
            this.Databases.TabIndex = 9;
            this.Databases.Text = "DATABASES";
            // 
            // Databasestextbox
            // 
            this.Databasestextbox.Location = new System.Drawing.Point(359, 159);
            this.Databasestextbox.Name = "Databasestextbox";
            this.Databasestextbox.Size = new System.Drawing.Size(100, 20);
            this.Databasestextbox.TabIndex = 8;
            // 
            // OrmTechnologies
            // 
            this.OrmTechnologies.AutoSize = true;
            this.OrmTechnologies.Location = new System.Drawing.Point(190, 133);
            this.OrmTechnologies.Name = "OrmTechnologies";
            this.OrmTechnologies.Size = new System.Drawing.Size(116, 13);
            this.OrmTechnologies.TabIndex = 7;
            this.OrmTechnologies.Text = "ORMTECHNOLOGIES";
            // 
            // OrmTechnologiestextbox
            // 
            this.OrmTechnologiestextbox.Location = new System.Drawing.Point(359, 133);
            this.OrmTechnologiestextbox.Name = "OrmTechnologiestextbox";
            this.OrmTechnologiestextbox.Size = new System.Drawing.Size(100, 20);
            this.OrmTechnologiestextbox.TabIndex = 6;
            // 
            // ProgrammingLanguage
            // 
            this.ProgrammingLanguage.AutoSize = true;
            this.ProgrammingLanguage.Location = new System.Drawing.Point(190, 107);
            this.ProgrammingLanguage.Name = "ProgrammingLanguage";
            this.ProgrammingLanguage.Size = new System.Drawing.Size(149, 13);
            this.ProgrammingLanguage.TabIndex = 5;
            this.ProgrammingLanguage.Text = "PROGRAMMINGLANGUAGE";
            // 
            // ProgrammingLanguagetextbox
            // 
            this.ProgrammingLanguagetextbox.Location = new System.Drawing.Point(359, 107);
            this.ProgrammingLanguagetextbox.Name = "ProgrammingLanguagetextbox";
            this.ProgrammingLanguagetextbox.Size = new System.Drawing.Size(100, 20);
            this.ProgrammingLanguagetextbox.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(190, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "UI";
            // 
            // Uitextbox
            // 
            this.Uitextbox.Location = new System.Drawing.Point(359, 81);
            this.Uitextbox.Name = "Uitextbox";
            this.Uitextbox.Size = new System.Drawing.Size(100, 20);
            this.Uitextbox.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(187, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "EMPLOYEEID";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(359, 55);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 0;
            // 
            // EDUCATIONALDETAILS
            // 
            this.EDUCATIONALDETAILS.Controls.Add(this.button7);
            this.EDUCATIONALDETAILS.Controls.Add(this.button8);
            this.EDUCATIONALDETAILS.Controls.Add(this.YearOfPass);
            this.EDUCATIONALDETAILS.Controls.Add(this.YearOfPasstextbox);
            this.EDUCATIONALDETAILS.Controls.Add(this.CourseSpecialization);
            this.EDUCATIONALDETAILS.Controls.Add(this.Coursespecializationtextbox);
            this.EDUCATIONALDETAILS.Controls.Add(this.CourseType);
            this.EDUCATIONALDETAILS.Controls.Add(this.Coursetypetextbox);
            this.EDUCATIONALDETAILS.Controls.Add(this.label23);
            this.EDUCATIONALDETAILS.Controls.Add(this.textBox23);
            this.EDUCATIONALDETAILS.Location = new System.Drawing.Point(4, 22);
            this.EDUCATIONALDETAILS.Name = "EDUCATIONALDETAILS";
            this.EDUCATIONALDETAILS.Padding = new System.Windows.Forms.Padding(3);
            this.EDUCATIONALDETAILS.Size = new System.Drawing.Size(612, 346);
            this.EDUCATIONALDETAILS.TabIndex = 3;
            this.EDUCATIONALDETAILS.Text = "EDUCATIONALDETAILS";
            this.EDUCATIONALDETAILS.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(165, 191);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "SAVE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(351, 191);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "CLEAR";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // YearOfPass
            // 
            this.YearOfPass.AutoSize = true;
            this.YearOfPass.Location = new System.Drawing.Point(162, 129);
            this.YearOfPass.Name = "YearOfPass";
            this.YearOfPass.Size = new System.Drawing.Size(78, 13);
            this.YearOfPass.TabIndex = 7;
            this.YearOfPass.Text = "YEAROFPASS";
            // 
            // YearOfPasstextbox
            // 
            this.YearOfPasstextbox.Location = new System.Drawing.Point(351, 129);
            this.YearOfPasstextbox.Name = "YearOfPasstextbox";
            this.YearOfPasstextbox.Size = new System.Drawing.Size(100, 20);
            this.YearOfPasstextbox.TabIndex = 6;
            // 
            // CourseSpecialization
            // 
            this.CourseSpecialization.AutoSize = true;
            this.CourseSpecialization.Location = new System.Drawing.Point(162, 103);
            this.CourseSpecialization.Name = "CourseSpecialization";
            this.CourseSpecialization.Size = new System.Drawing.Size(139, 13);
            this.CourseSpecialization.TabIndex = 5;
            this.CourseSpecialization.Text = "COURSESPECIALIZATION";
            // 
            // Coursespecializationtextbox
            // 
            this.Coursespecializationtextbox.Location = new System.Drawing.Point(351, 103);
            this.Coursespecializationtextbox.Name = "Coursespecializationtextbox";
            this.Coursespecializationtextbox.Size = new System.Drawing.Size(100, 20);
            this.Coursespecializationtextbox.TabIndex = 4;
            // 
            // CourseType
            // 
            this.CourseType.AutoSize = true;
            this.CourseType.Location = new System.Drawing.Point(162, 77);
            this.CourseType.Name = "CourseType";
            this.CourseType.Size = new System.Drawing.Size(80, 13);
            this.CourseType.TabIndex = 3;
            this.CourseType.Text = "COURSETYPE";
            // 
            // Coursetypetextbox
            // 
            this.Coursetypetextbox.Location = new System.Drawing.Point(351, 77);
            this.Coursetypetextbox.Name = "Coursetypetextbox";
            this.Coursetypetextbox.Size = new System.Drawing.Size(100, 20);
            this.Coursetypetextbox.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(162, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "EMPLOYEEID";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(351, 51);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 20);
            this.textBox23.TabIndex = 0;
            // 
            // PROJECTDETAILS
            // 
            this.PROJECTDETAILS.Controls.Add(this.button10);
            this.PROJECTDETAILS.Controls.Add(this.button9);
            this.PROJECTDETAILS.Controls.Add(this.Role);
            this.PROJECTDETAILS.Controls.Add(this.Roletextbox);
            this.PROJECTDETAILS.Controls.Add(this.label31);
            this.PROJECTDETAILS.Controls.Add(this.textBox31);
            this.PROJECTDETAILS.Controls.Add(this.ClientName);
            this.PROJECTDETAILS.Controls.Add(this.ClientNametextbox);
            this.PROJECTDETAILS.Controls.Add(this.ProjectNametextbox);
            this.PROJECTDETAILS.Controls.Add(this.ProjectName);
            this.PROJECTDETAILS.Controls.Add(this.ProjectId);
            this.PROJECTDETAILS.Controls.Add(this.ProjectIdtextbox);
            this.PROJECTDETAILS.Controls.Add(this.label27);
            this.PROJECTDETAILS.Controls.Add(this.textBox27);
            this.PROJECTDETAILS.Location = new System.Drawing.Point(4, 22);
            this.PROJECTDETAILS.Name = "PROJECTDETAILS";
            this.PROJECTDETAILS.Padding = new System.Windows.Forms.Padding(3);
            this.PROJECTDETAILS.Size = new System.Drawing.Size(612, 346);
            this.PROJECTDETAILS.TabIndex = 4;
            this.PROJECTDETAILS.Text = "PROJECTDETAILS";
            this.PROJECTDETAILS.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(378, 247);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "CLEAR";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(192, 247);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "SAVE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(189, 189);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(36, 13);
            this.Role.TabIndex = 11;
            this.Role.Text = "ROLE";
            // 
            // Roletextbox
            // 
            this.Roletextbox.Location = new System.Drawing.Point(378, 189);
            this.Roletextbox.Name = "Roletextbox";
            this.Roletextbox.Size = new System.Drawing.Size(100, 20);
            this.Roletextbox.TabIndex = 10;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(189, 163);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(61, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "LOCATION";
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(378, 163);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(100, 20);
            this.textBox31.TabIndex = 8;
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(189, 137);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(76, 13);
            this.ClientName.TabIndex = 7;
            this.ClientName.Text = "CLIENTNAME";
            // 
            // ClientNametextbox
            // 
            this.ClientNametextbox.Location = new System.Drawing.Point(378, 137);
            this.ClientNametextbox.Name = "ClientNametextbox";
            this.ClientNametextbox.Size = new System.Drawing.Size(100, 20);
            this.ClientNametextbox.TabIndex = 6;
            // 
            // ProjectNametextbox
            // 
            this.ProjectNametextbox.Location = new System.Drawing.Point(378, 111);
            this.ProjectNametextbox.Name = "ProjectNametextbox";
            this.ProjectNametextbox.Size = new System.Drawing.Size(100, 20);
            this.ProjectNametextbox.TabIndex = 5;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Location = new System.Drawing.Point(189, 111);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(87, 13);
            this.ProjectName.TabIndex = 4;
            this.ProjectName.Text = "PROJECTNAME";
            // 
            // ProjectId
            // 
            this.ProjectId.AutoSize = true;
            this.ProjectId.Location = new System.Drawing.Point(189, 85);
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.Size = new System.Drawing.Size(67, 13);
            this.ProjectId.TabIndex = 3;
            this.ProjectId.Text = "PROJECTID";
            // 
            // ProjectIdtextbox
            // 
            this.ProjectIdtextbox.Location = new System.Drawing.Point(378, 85);
            this.ProjectIdtextbox.Name = "ProjectIdtextbox";
            this.ProjectIdtextbox.Size = new System.Drawing.Size(100, 20);
            this.ProjectIdtextbox.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(186, 59);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "EMPLOYEEID";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(378, 59);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(100, 20);
            this.textBox27.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 427);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.EMPLOYEEDETAILS.ResumeLayout(false);
            this.EMPLOYEEDETAILS.PerformLayout();
            this.COMPANYDETAILS.ResumeLayout(false);
            this.COMPANYDETAILS.PerformLayout();
            this.TECHNICALDETAILS.ResumeLayout(false);
            this.TECHNICALDETAILS.PerformLayout();
            this.EDUCATIONALDETAILS.ResumeLayout(false);
            this.EDUCATIONALDETAILS.PerformLayout();
            this.PROJECTDETAILS.ResumeLayout(false);
            this.PROJECTDETAILS.PerformLayout();
            this.ResumeLayout(false);

        }

        private void NewMethod()
        {
            this.Location = new System.Windows.Forms.Label();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EMPLOYEEDETAILS;
        private System.Windows.Forms.TabPage COMPANYDETAILS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage TECHNICALDETAILS;
        private System.Windows.Forms.TabPage EDUCATIONALDETAILS;
        private System.Windows.Forms.TabPage PROJECTDETAILS;
        private System.Windows.Forms.Label EmailId;
        private System.Windows.Forms.TextBox Emailidtextbox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox LastNametextbox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox FirstNametextbox;
        private System.Windows.Forms.Label EmployeeId;
        private System.Windows.Forms.Label MobileNumber;
        private System.Windows.Forms.TextBox MobileNumbertextbox;
        private System.Windows.Forms.Label ZipCode;
        private System.Windows.Forms.TextBox ZipCodetextbox;
        private System.Windows.Forms.Label HomeCountry;
        private System.Windows.Forms.TextBox HomeCountrytextbox;
        private System.Windows.Forms.Label CurrentCountry;
        private System.Windows.Forms.TextBox CurrentCountrytextbox;
        private System.Windows.Forms.Label Address2;
        private System.Windows.Forms.TextBox Address2textbox;
        private System.Windows.Forms.Label Address1;
        private System.Windows.Forms.TextBox Address1textbox;
        private System.Windows.Forms.Label AlternateMobileNumber;
        private System.Windows.Forms.TextBox AlternateMobileNumbertextbox;
        private System.Windows.Forms.TextBox Websitetextbox;
        private System.Windows.Forms.TextBox ContactNumbertextbox;
        private System.Windows.Forms.TextBox EmployeeNametextbox;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label website;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.Label Location;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Uitextbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label ProgrammingLanguage;
        private System.Windows.Forms.TextBox ProgrammingLanguagetextbox;
        private System.Windows.Forms.Label OrmTechnologies;
        private System.Windows.Forms.TextBox OrmTechnologiestextbox;
        private System.Windows.Forms.Label Databases;
        private System.Windows.Forms.TextBox Databasestextbox;
        private System.Windows.Forms.Label TechnicalDetailsUi;
        private System.Windows.Forms.TextBox TechnicalDetailsUitextbox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label CourseType;
        private System.Windows.Forms.TextBox Coursetypetextbox;
        private System.Windows.Forms.Label YearOfPass;
        private System.Windows.Forms.TextBox YearOfPasstextbox;
        private System.Windows.Forms.Label CourseSpecialization;
        private System.Windows.Forms.TextBox Coursespecializationtextbox;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.TextBox ClientNametextbox;
        private System.Windows.Forms.TextBox ProjectNametextbox;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.Label ProjectId;
        private System.Windows.Forms.TextBox ProjectIdtextbox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.TextBox Roletextbox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        
        

        
        

    }
}

