using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Xml;
using System.IO;

namespace SimplyRugby
{
    public partial class Roster : Window
    {
        public bool Admin { get; set; } //keeps track of what type of user is logged in
        public int AgeRangeSelected { get; set; } //keeps track of the age range selected
        public bool MemberSelected { get; set; } //keeps track whether a player is selecetd or not
        public DataRowView SelectedPlayer { get; set; } //stores the datarowview of the selected player with all their details

        public Roster(bool admin)
        {
            InitializeComponent();

            Admin = admin; //stores the user type login for later use
            AgeRangeSelected = -1; //instantiates age sekecetd to nothing as user has not picked one yet

            //displays on lable what type of user has logged in
            if (admin) LBL_UserType.Content = "Admin";
            else LBL_UserType.Content = "Coach";
        }

        private DataView CreateXMLDataView() //creates and returns a dataview
        {
            try
            {
                string xmlFile = Directory.GetCurrentDirectory() + "/memberdata.xml"; //opens up file with member details
                DataSet dataSet = new DataSet(); //instantiates a dataset
                dataSet.ReadXml(xmlFile); //reads the xml document into the dataset
                DataView dataView = new DataView(dataSet.Tables[0]); //creates a dataview from the table insdie the dataset

                return dataView;
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }

        private void DisplayMembers(DataView dataView, int age)
        {
            if(dataView != null)
            {
                //determines what the age group should be filtered
                if (AgeRangeSelected > 20) dataView.RowFilter = string.Format("squad LIKE '%senior%'"); //if age is above 20 then show only the sneior team
                else dataView.RowFilter = string.Format("squad LIKE '%" + age + "%'"); //since we have a int age we can slot it into the filter. this will filter to show only the selected age

                RosterDataGrid.ItemsSource = dataView; //binds the dataview with players to the datagrid for displaying
                for (int i = 1; i < 7; i++) RosterDataGrid.Columns[i].Visibility = Visibility.Collapsed; //this will hide all the columns except the name
                RosterDataGrid.Columns[0].Width = 140; //sets column width so it takes up the whole of datagrid
                RosterDataGrid.CanUserAddRows = false; //disables the ability for user to add their own rows from the datagrid
                RosterDataGrid.IsReadOnly = true;
                RosterDataGrid.CanUserResizeColumns = false;
            }

        }

        private void BTN_Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow(); //creates the mainwindow
            mw.Show(); //displays the main windiw
            Close(); //close current windw
        }

        private void BTN_PlayerForm_Click(object sender, RoutedEventArgs e)
        {
            //if a member is sleceted call this
            if (MemberSelected)
            {
                PlayerForm pf = new PlayerForm(this, SelectedPlayer, Admin); //pass in the selected data row view of the player as well as this calss and the admin login bool
                pf.Show(); //show the player form window
            }
            else //if not selecetd call this
            {
                PlayerForm pf = new PlayerForm(this, null, Admin); //pass in a null value for the selected player as well as this class and the admin login bool
                pf.Show(); //show the player form window
            }
        }

        private void BTN_PlayerProfile_Click(object sender, RoutedEventArgs e)
        {
            if (MemberSelected) //only allow if member is selected
            {
                PlayerProfile pp = new PlayerProfile(this, SelectedPlayer, Admin); //pass in the slected member data row view, this class and the admin login bool
                pp.Show(); //show player profile window
            }
            else
            {
                MessageBox.Show("Member must be selected first from roster.", "Error! Member not slected"); //show error message if member is not selected
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) //triggers if user changes age selected in drop down menu
        {
            int i = COMBOBOX_Age.SelectedIndex; //selected index in drop down menu

            //switch case will set AgeRangeSelected to correct age depending in the index selected 
            switch (i)
            {
                case 0:
                    AgeRangeSelected = 15;
                    break;
                case 1:
                    AgeRangeSelected = 16;
                    break;
                case 2:
                    AgeRangeSelected = 18;
                    break;
                case 3:
                    AgeRangeSelected = 20;
                    break;
                default:
                    AgeRangeSelected = 21;
                    break;
            }

            DisplayMembers(CreateXMLDataView(), AgeRangeSelected); //calls the DisplayMember function and passses it 2 arguments. First it calls function to create a dataview then the age selected from drop down menu
        }

        private void RosterDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MemberSelected = true; //member is now selected

            SelectedPlayer = (DataRowView)RosterDataGrid.SelectedItem; //create a datarowview of the currently selected player (allows to pass all the players details across windows)
        }

        public void RefreshDataGrid()
        {
            //refreshes the datagrid window by calling the displaymembers functiob again with the already set age
            DisplayMembers(CreateXMLDataView(), AgeRangeSelected);
            MemberSelected = false;
        }

        private void BTN_RightArrow_Click(object sender, RoutedEventArgs e)
        {
            if (COMBOBOX_Age.SelectedIndex < 4) COMBOBOX_Age.SelectedIndex += 1; //increments the dropdown menu index by 1(age range moves higher)
        }

        private void BTN_LeftArrow_Click(object sender, RoutedEventArgs e)
        {
            if (COMBOBOX_Age.SelectedIndex > 0) COMBOBOX_Age.SelectedIndex -= 1; //minuses the dropdown menu index by 1 (age range moves lower)
        }

        private void BTN_Remove_Click(object sender, RoutedEventArgs e)
        {
            if (Admin)
            {
                if (MemberSelected) //only allow removal if member is selected
                {
                    XmlDocument xmlMemberData = new XmlDocument(); //instaniate a xmldoxument to hold the member details xml domcument
                    xmlMemberData.Load(Directory.GetCurrentDirectory() + "/memberdata.xml"); //load the member data from given dierctory
                    int sru = Convert.ToInt32((SelectedPlayer["sru"])); //stores the members sru

                    XmlElement el = (XmlElement)xmlMemberData.SelectSingleNode("/members/member[sru=" + sru + "]"); //selects one node that matches the sru of the selected player
                    if (el != null) { el.ParentNode.RemoveChild(el); } //if node exists delete the whole node

                    xmlMemberData.Save(Directory.GetCurrentDirectory() + "/memberdata.xml"); //save file

                    XmlDocument xmlSkillData = new XmlDocument(); //instaniate a xmldoxument to hold the member skill details xml domcument
                    xmlSkillData.Load(Directory.GetCurrentDirectory() + "/skilldata.xml"); //load the member data from given dierctory

                    XmlElement el2 = (XmlElement)xmlSkillData.SelectSingleNode("/skills/skillset[sru=" + sru + "]"); //selects one node that matches the sru of the selected player
                    if (el2 != null) { el2.ParentNode.RemoveChild(el2); } //if node exists delete the whole node

                    xmlSkillData.Save(Directory.GetCurrentDirectory() + "/skilldata.xml"); //save file

                    RefreshDataGrid(); //refresh the grid to show removal of member
                }
                else MessageBox.Show("Select a member from roster to remove first.", "Member not selected!"); //display error message asking to selected a player first
            }
            else
            {
                MessageBox.Show("Only the admin can remove member forms.");
            }
        }

        private void BTN_Refresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
