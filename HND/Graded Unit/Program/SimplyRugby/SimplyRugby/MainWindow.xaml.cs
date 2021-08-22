using System;
using System.Text;
using System.Windows;
using System.IO;
using System.Xml;

namespace SimplyRugby
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            COMBO_User.SelectedIndex = 0;

            if (!File.Exists(Directory.GetCurrentDirectory() + "/memberdata.xml")) //checks if the file with member data exists
            {
                CreateNewMemberXMLFile(); //calls function to create member data xml document
            }

            if (!File.Exists(Directory.GetCurrentDirectory() + "/skilldata.xml")) //checks if the file with member skills exists
            {
                CreateNewSkillXMLFile(); //calls function to create skill xml document
            }
        }

        private void CreateNewMemberXMLFile()
        {
            XmlWriterSettings settings = new XmlWriterSettings //settings for createing xml documetns
            {
                Indent = true //enables indentation in document to allow easier viewing
            };

            using (XmlWriter writer = XmlWriter.Create(Directory.GetCurrentDirectory() + "/memberdata.xml", settings)) //using the xmlwriter resource create file at given directory
            {
                //this will create a test entry into the member data sheet
                writer.WriteStartDocument();
                writer.WriteStartElement("members");

                writer.WriteStartElement("member");
                writer.WriteElementString("name", "Test Member");
                writer.WriteElementString("email", "testmember@gmail.com");
                writer.WriteElementString("sru", "12344321");
                writer.WriteElementString("dob", "22/08/1998");
                writer.WriteElementString("squad", "20s");
                writer.WriteElementString("phonenumber", "07723456786");
                writer.WriteElementString("parentalconsent", "N/A (Age over 18)");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Flush();
                writer.Close();
            }
        }

        private void CreateNewSkillXMLFile()
        {
            XmlWriterSettings settings = new XmlWriterSettings //settings for createing xml documetns
            {
                Indent = true //enables indentation in document to allow easier viewing
            };

            using (XmlWriter writer = XmlWriter.Create(Directory.GetCurrentDirectory() + "/skilldata.xml", settings)) //using the xmlwriter resource create file at given directory
            {
                //this will create a test entry into the skills set sheet
                writer.WriteStartDocument();
                writer.WriteStartElement("skills");

                writer.WriteStartElement("skillset");
                writer.WriteElementString("sru", "12344321");
                writer.WriteElementString("standard", "4");
                writer.WriteElementString("spin", "4");
                writer.WriteElementString("pop", "4");
                writer.WriteElementString("passingcomment", "comment 1");
                writer.WriteElementString("front", "4");
                writer.WriteElementString("rear", "4");
                writer.WriteElementString("side", "4");
                writer.WriteElementString("scrabble", "4");
                writer.WriteElementString("tacklingcomment", "comment 2");
                writer.WriteElementString("drop", "4");
                writer.WriteElementString("punt", "4");
                writer.WriteElementString("grubber", "4");
                writer.WriteElementString("goal", "4");
                writer.WriteElementString("kickingcomment", "comment 3");
                writer.WriteElementString("lastedited", "03/03/2018");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Flush();
                writer.Close();
            }
        }

        private void Login(bool admin)
        {
            Roster r = new Roster(admin); //crates roster window and passes whether an admin login was used or not
            r.Show(); //opens up the roster window
            Close(); //closes current login page
        }

        private void BTN_Login_Click(object sender, RoutedEventArgs e)
        {
            //checks what logins are being used
            if (COMBO_User.Text == "Coach" && PasswordBox.Password.ToString() == "coachlogin") Login(false); //if coach login is used and the right password is used the correct (false) login will passed to function
            else if (COMBO_User.Text == "Admin" && PasswordBox.Password.ToString() == "adminlogin") Login(true); //if admin login is used and the right password is used the correct (true) login will passed to function
            else MessageBox.Show("The password you have entered for: " + COMBO_User.Text + " user is inccorect, please try again", "Wrong password"); //if password is not correct a message will show
        }

        private void BTN_Admin_Click(object sender, RoutedEventArgs e)
        {
            Login(true);
        }

        private void BTN_Coach_Click(object sender, RoutedEventArgs e)
        {
            Login(false);
        }
    }
}
