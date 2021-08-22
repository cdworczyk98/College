using System;
using System.Windows;
using System.Windows.Input;
using System.Xml;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace SimplyRugby
{
    public partial class PlayerForm : Window
    {
        public Roster RosterWindow { get; set; } //stores the refrence to the roster window
        public bool AddNewPlayer { get; set; } //keeps track if the user is adding a new player or not
        public int MemberSRU { get; set; } //stores the member sru
        public bool Admin { get; set; } //keeps track of what type of user is logged in

        public PlayerForm(Roster r, DataRowView dataRowView, bool admin)
        {
            InitializeComponent();

            RosterWindow = r; //set the passed in refrence to roster window
            AddNewPlayer = false; //initalise to false
            Admin = admin; //set the passed in admin boolean

            BTN_SRUQuestion.Visibility = Visibility.Hidden; //hides the sru help button
            LBL_Alert.Content = ""; //clears the alert label
            DOBPicker.DisplayDateEnd = DateTime.Now.Date; //sets the date picker so no future dates can be selected
            DOBPicker.DisplayDateStart = new DateTime(1940, 01, 01); //sets the date picker so no earlier year date than 1940 is shown

            if (dataRowView != null) DisplayDetails(dataRowView); //if datarowview is not null then call the display member function

            if (!admin) DisableEditing(); //if admin login was not used then disable all editing ability
        }

        private void DisableEditing()
        {
            //disables all the fields so they cannot be edited by the coach only viewed

            BTN_NewPlayer.IsEnabled = false;
            BTN_Save.IsEnabled = false;

            TXTBOX_Name.IsEnabled = false;
            TXTBOX_Email.IsEnabled = false;
            TXTBOX_SRU.IsEnabled = false;

            DOBPicker.IsEnabled = false;

            COMBOX_Consent.IsEnabled = false;
        }

        private void DisplayDetails(DataRowView drv)
        {
            string consent = (drv["parentalconsent"]).ToString(); //extracts the parental consent field and sets it to a variable

            //depending on the consent, the switch case will assign the correct index to drop down menu to show the consent
            switch (consent)
            {
                case "Yes":
                    COMBOX_Consent.SelectedIndex = 0;
                    break;
                case "No":
                    COMBOX_Consent.SelectedIndex = 1;
                    break;
                default:
                    COMBOX_Consent.SelectedIndex = 2;
                    break;
            }

            //extract the player details from datarowview and display them in their fields
            TXTBOX_Name.Text = (drv["name"]).ToString();
            TXTBOX_Email.Text = (drv["email"]).ToString();
            TXTBOX_SRU.Text = (drv["sru"]).ToString();
            TXTBOX_Phone.Text = (drv["phonenumber"]).ToString();
            DOBPicker.SelectedDate = Convert.ToDateTime((drv["dob"]).ToString());

            MemberSRU = Convert.ToInt32((drv["sru"])); //assigns the member sru to a varaible to track

            BTN_SRUQuestion.Visibility = Visibility.Visible; //display the sru help button which will display reason why you cannt edit sru once member has been created
            TXTBOX_SRU.IsEnabled = false; //disable the editing of sru box
        }

        private void BTN_Back_Click(object sender, RoutedEventArgs e)
        {
            RosterWindow.Show(); //show the roster windiw
            RosterWindow.RefreshDataGrid(); //refresh the datagrid (in case user has made any changes to memebr or ahs added a new one)
            Close(); //close current window
        }

        private void BTN_NewPlayer_Click(object sender, RoutedEventArgs e)
        {
            LBL_Alert.Content = "Adding new player, remember to click save!"; //display message that the user is entering the addnewmember mode
            AddNewPlayer = true; //set addnewplayer to true as a different path will be taken later on in the save function due to this

            //clear all the fields
            TXTBOX_Name.Text = "";
            TXTBOX_Email.Text = "";
            TXTBOX_SRU.Text = "";
            COMBOX_Consent.SelectedIndex = -1;
            TXTBOX_SRU.IsEnabled = true;
            DOBPicker.SelectedDate = DateTime.Now.Date;

            BTN_SRUQuestion.Visibility = Visibility.Hidden; //hide the sru help button

        }

        private void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            bool emptyFields = EmptyFields(); //the emptyfields variable is set to the result of the emptyfields() return function

            if (!emptyFields) //only proceed if there are no empty fields
            {
                bool consentRequired = false; //instantiate the consent variable to be used later on

                int age = CalculateAge(); //set age to the return value of CalculateAge() fuinction
                bool duplicateSRU = SRUTaken(TXTBOX_SRU.Text); //set boolean to the return value of the SRUTaken() function which checks for duplicate sru
                bool validEmail = IsValidEmail(TXTBOX_Email.Text); //set boolean to the return value of the IsValidEmail() function which check if emila is valid
                bool validSRULength = (TXTBOX_SRU.Text.Length == 8); //checks if the SRU is 8 numbers long if not then this will flag up as false
                bool validPhoneLength = (TXTBOX_Phone.Text.Length == 11); //checks if the phone number is 11 numbers long if not then this will flag up as false

                if (!validSRULength) MessageBox.Show("Please make sure you have entered the SRU correctly", "Invalid SRU Length"); //if invalid sru length display the error message

                if (duplicateSRU && AddNewPlayer) MessageBox.Show("A duplicate SRU was detected please try again."); //if new player is being added and a duplicate sru has been detected display the error message

                if (!validEmail) MessageBox.Show("Invalid email, please make sure you have entered it correctly", "Invalid email!");

                if (!validPhoneLength) MessageBox.Show("The phone number you entered is not vlaid please try again!", "Invalid Phone Number");

                XmlDocument xmlDoc = new XmlDocument(); //instantiate the xmldocument to read the member data into it
                xmlDoc.Load(Directory.GetCurrentDirectory() + "/memberdata.xml"); //load the member data from the given directory

                if (AddNewPlayer && !duplicateSRU && validEmail && validSRULength && validPhoneLength) //this will only call if a new player is being added without a duplicate sru and a valid email
                {
                    if (age >= 18 && COMBOX_Consent.SelectedIndex != 2) //if the age is 18 or above and the consent dropdown menu is not selected to be N/A then infrom user of the automatic change
                    {
                        MessageBox.Show("Member is over the age of 18, therefore a parental consent is not required. The field has been changed automatically to the appropriate one."); //display messgae to user
                        consentRequired = false; //set consent required to false
                    }
                    else if (age < 18) //if age is less than 18
                    {
                        consentRequired = true; //set consent required to true
                    }

                    XmlNodeList sruList = xmlDoc.GetElementsByTagName("sru");//create an list of all the sru elements

                    //this sets up all the xml node elements where the data will be stored (name,email,sry,dob)
                    XmlNode member = xmlDoc.CreateElement("member"); //creates the element member which will be the parent of all the member details

                    XmlNode name = xmlDoc.CreateElement("name"); //create name element
                    name.InnerText = TXTBOX_Name.Text; //set the text in xml document to be the text in name box
                    member.AppendChild(name); //make the name elemnt the child of member element
                    XmlNode email = xmlDoc.CreateElement("email");
                    email.InnerText = TXTBOX_Email.Text;
                    member.AppendChild(email);
                    XmlNode sru = xmlDoc.CreateElement("sru");
                    sru.InnerText = TXTBOX_SRU.Text;
                    member.AppendChild(sru);
                    XmlNode dob = xmlDoc.CreateElement("dob");
                    dob.InnerText = DOBPicker.SelectedDate.Value.Date.ToShortDateString(); //converts the date to a short date (dd/mm/yyyy)
                    member.AppendChild(dob);
                    XmlNode phonenumber = xmlDoc.CreateElement("phonenumber");
                    phonenumber.InnerText = TXTBOX_Phone.Text; //converts the date to a short date (dd/mm/yyyy)
                    member.AppendChild(phonenumber);

                    //depending on the age this block of code will save the correct age to the document
                    XmlNode squad = xmlDoc.CreateElement("squad");
                    if (age <= 15) squad.InnerText = "15s";
                    else if (age <= 16) squad.InnerText = "16s";
                    else if (age <= 18) squad.InnerText = "18s";
                    else if (age <= 20) squad.InnerText = "20s";
                    else squad.InnerText = "senior";
                    member.AppendChild(squad);

                    XmlNode pConsent = xmlDoc.CreateElement("parentalconsent");
                    if (!consentRequired) //if parent consent not
                    {
                        pConsent.InnerText = "N/A (Age over 18)";
                    }
                    else //else save either "Yes" or "No" to document
                    {
                        pConsent.InnerText = COMBOX_Consent.Text;
                    }
                    member.AppendChild(pConsent);

                    xmlDoc.DocumentElement.AppendChild(member); //add the whole member element with all its children to document
                    xmlDoc.Save(Directory.GetCurrentDirectory() + "/memberdata.xml"); //save document

                    LBL_Alert.Content = "New member saved succesfully."; //alert user of successfull save

                    CreatePlayerProfile();

                    AddNewPlayer = false; //set addnewplayer to false again
                }
                else if (!AddNewPlayer && validEmail && validPhoneLength) //calls this if a new player is not being added and instead one is being updated
                {
                    if (age >= 18 && COMBOX_Consent.SelectedIndex != 2) //if the age is 18 or above and the consent dropdown menu is not selected to be N/A then infrom user of the automatic change
                    {
                        MessageBox.Show("Member is over the age of 18, therefore a parental consent is not required. The field has been changed automatically to the appropriate one."); //display messgae to user
                        consentRequired = false; //set consent required to false
                    }
                    else if (age < 18) //if age is less than 18
                    {
                        consentRequired = true; //set consent required to true
                    }

                    //creates a list of all the elements by their tag
                    XmlNodeList nameList = xmlDoc.GetElementsByTagName("name");
                    XmlNodeList emailList = xmlDoc.GetElementsByTagName("email");
                    XmlNodeList sruList = xmlDoc.GetElementsByTagName("sru");
                    XmlNodeList dobList = xmlDoc.GetElementsByTagName("dob");
                    XmlNodeList squadList = xmlDoc.GetElementsByTagName("squad");
                    XmlNodeList consentList = xmlDoc.GetElementsByTagName("parentalconsent");
                    XmlNodeList phoneList = xmlDoc.GetElementsByTagName("phonenumber");

                    for (int i = 0; i < sruList.Count; i++) //loops the amount if sru numbers are there (one for each member)
                    {
                        if (sruList[i].InnerText == MemberSRU.ToString()) //if the current players sru matches then we have found the correct index, we can now edit the fields
                        {
                            //goes and updates each of the users info to the ones currently in textboxes
                            nameList[i].InnerText = TXTBOX_Name.Text;
                            emailList[i].InnerText = TXTBOX_Email.Text;
                            dobList[i].InnerText = DOBPicker.SelectedDate.Value.Date.ToShortDateString();
                            phoneList[i].InnerText = TXTBOX_Phone.Text;
                            if (!consentRequired)
                            {
                                consentList[i].InnerText = "N/A (Age over 18)";
                            }
                            else
                            {
                                consentList[i].InnerText = COMBOX_Consent.Text;
                            }


                            if (age <= 15) squadList[i].InnerText = "15s";
                            else if (age == 16) squadList[i].InnerText = "16s";
                            else if (age <= 18) squadList[i].InnerText = "18s";
                            else if (age <= 20) squadList[i].InnerText = "20s";
                            else if (age > 20) squadList[i].InnerText = "senior";
                        }
                    }

                    xmlDoc.Save(Directory.GetCurrentDirectory() + "/memberdata.xml"); //save to document

                    LBL_Alert.Content = "Member info updated successfully."; //alert user of successfull save
                }
            }
            else
            {
                MessageBox.Show("A field has been left empty, please fill all the fields in."); //if a field is empty then show user error message
            }
        }

        private bool EmptyFields()
        {
            if (TXTBOX_Name.Text == "" || TXTBOX_SRU.Text == "" || TXTBOX_Email.Text == "" || COMBOX_Consent.SelectedIndex == -1 || TXTBOX_Phone.Text == "") return true; //checks if any of the fields have been left empty and return true if yes

            return false; //else return false
        }

        private bool SRUTaken(string sru) //checks to see if the sru entered already exists
        {
            XmlDocument xmlDoc = new XmlDocument(); //initiate the xmldocument to read xml document into
            xmlDoc.Load(Directory.GetCurrentDirectory() + "/memberdata.xml"); //laod the member details document

            XmlNodeList sruList = xmlDoc.GetElementsByTagName("sru"); //create a list af all the elements tagged "sru"

            for (int i = 0; i < sruList.Count; i++) //loop throught the whole list
            {
                if (sruList[i].InnerText == sru) //if the sru in document matches the passed in sru return true
                {
                    return true;
                }
            }

            return false; //else return false
        }

        private bool IsValidEmail(string email)
        {
            //this will try and prepare to send to n email address
            try
            {
                var addr = new MailAddress(email); //sets the email address 
                return addr.Address == email; //if its a valid email and the set address matches the address given to this fuinction then return true
            }
            catch (Exception)
            {
                return false; //else return false
            }
        }

        private int CalculateAge()
        {
            DateTime bDay = DOBPicker.SelectedDate.Value.Date; //set the bday to the slected date in date picker
            DateTime now = DateTime.Now.Date; //set the current date

            int age = now.Year - bDay.Year; //firstly it takes away the birth year from the todays year, this gives a basic estimate of age (need to consider months and days next)

            if (now.Month < bDay.Month || (now.Month == bDay.Month && now.Day < bDay.Day)) //if the birth month is not past todays month OR the birth month is current month BUT the birth day is not past the current day then take 1 away from age (user has not yet reach their birthday)
            {
                age--; //take 1 away from month
            }

            return age;
        }

        private void CreatePlayerProfile()
        {
            //opens and laods the xml skill document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Directory.GetCurrentDirectory() + "/skilldata.xml");

            //creates a all the elemtns for a defualt memeber entry
            XmlNode skillset = xmlDoc.CreateElement("skillset");
            XmlNode sru = xmlDoc.CreateElement("sru");
            sru.InnerText = TXTBOX_SRU.Text;
            skillset.AppendChild(sru);
            XmlNode standard = xmlDoc.CreateElement("standard");
            standard.InnerText = "1";
            skillset.AppendChild(standard);
            XmlNode spin = xmlDoc.CreateElement("spin");
            spin.InnerText = "1";
            skillset.AppendChild(spin);
            XmlNode pop = xmlDoc.CreateElement("pop");
            pop.InnerText = "1";
            skillset.AppendChild(pop);
            XmlNode passingcomment = xmlDoc.CreateElement("passingcomment");
            passingcomment.InnerText = "passing 1";
            skillset.AppendChild(passingcomment);
            XmlNode front = xmlDoc.CreateElement("front");
            front.InnerText = "1";
            skillset.AppendChild(front);
            XmlNode rear = xmlDoc.CreateElement("rear");
            rear.InnerText = "1";
            skillset.AppendChild(rear);
            XmlNode side = xmlDoc.CreateElement("side");
            side.InnerText = "1";
            skillset.AppendChild(side);
            XmlNode scrabble = xmlDoc.CreateElement("scrabble");
            scrabble.InnerText = "1";
            skillset.AppendChild(scrabble);
            XmlNode tacklingcomment = xmlDoc.CreateElement("tacklingcomment");
            tacklingcomment.InnerText = "tackling commnet";
            skillset.AppendChild(tacklingcomment);
            XmlNode drop = xmlDoc.CreateElement("drop");
            drop.InnerText = "1";
            skillset.AppendChild(drop);
            XmlNode punt = xmlDoc.CreateElement("punt");
            punt.InnerText = "1";
            skillset.AppendChild(punt);
            XmlNode grubber = xmlDoc.CreateElement("grubber");
            grubber.InnerText = "1";
            skillset.AppendChild(grubber);
            XmlNode goal = xmlDoc.CreateElement("goal");
            goal.InnerText = "1";
            skillset.AppendChild(goal);
            XmlNode kickingcommment = xmlDoc.CreateElement("kickingcomment");
            kickingcommment.InnerText = "kicking comment";
            skillset.AppendChild(kickingcommment);
            XmlNode lastedited = xmlDoc.CreateElement("lastedited");
            lastedited.InnerText = DateTime.Now.Date.ToShortDateString();
            skillset.AppendChild(lastedited);


            xmlDoc.DocumentElement.AppendChild(skillset); //save the skillset  element all all its children to the document
            xmlDoc.Save(Directory.GetCurrentDirectory() + "/skilldata.xml"); //save file
        }

        private void BTN_SRUQuestion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The SRU cannot be edited once created. You will have to remove memeber first then create a new form.", "SRU Editing disabled"); //display help message explaining why the sru textbox is not enabled
        }

        private void TXTBOX_SRU_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text); //this will restrict the character input into the SRU box (only numbers are allowed from 0-9)
        }

        private void TXTBOX_Phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text); //this will restrict the character input into the phone number box (only numbers are allowed from 0-9)
        }
    }
}
