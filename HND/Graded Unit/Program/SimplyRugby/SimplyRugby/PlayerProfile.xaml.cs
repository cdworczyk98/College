using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.IO;

namespace SimplyRugby
{
    public partial class PlayerProfile : Window
    {
        public Roster Roster { get; set; } //keep roster window refrence
        public String MemberSRU { get; set; } //keeps a hold of the player sru thats the profile belongs to

        public PlayerProfile(Roster r, DataRowView dataRowView, bool admin)
        {
            InitializeComponent();

            Roster = r; //sets roster windiw refrence

            DisplayDetails(dataRowView); //calls fucntion to display player skills

            if (admin) DisableEditing(); //if admin login was used disable editing
        }

        private void DisableEditing()
        {
            //disable all the field editing
            SkillBox_Standard.IsEnabled = false;
            SkillBox_Spin.IsEnabled = false;
            SkillBox_Pop.IsEnabled = false;
            TXTBOX_Passing.IsEnabled = false;
            SkillBox_Front.IsEnabled = false;
            SkillBox_Rear.IsEnabled = false;
            SkillBox_Side.IsEnabled = false;
            SkillBox_Scrabble.IsEnabled = false;
            TXTBOX_Tackling.IsEnabled = false;
            SkillBox_Drop.IsEnabled = false;
            SkillBox_Punt.IsEnabled = false;
            SkillBox_Grubber.IsEnabled = false;
            SkillBox_Goal.IsEnabled = false;
            TXTBOX_Kicking.IsEnabled = false;
            BTN_Save.IsEnabled = false;
        }

        private void DisplayDetails(DataRowView drv)
        {
            //opens and laods the xml skill document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Directory.GetCurrentDirectory() + "/skilldata.xml");

            //using the passed in datarowview we display the name and squad on screen as well as save the player sru to search for their skill data
            LBL_Name.Content = (drv["name"]).ToString();
            LBL_Squad.Content = (drv["squad"]).ToString();
            MemberSRU = (drv["sru"]).ToString();

            //create a list of all the elements that will be edited
            XmlNodeList sruList = xmlDoc.GetElementsByTagName("sru");
            XmlNodeList standardList = xmlDoc.GetElementsByTagName("standard");
            XmlNodeList spinList = xmlDoc.GetElementsByTagName("spin");
            XmlNodeList popList = xmlDoc.GetElementsByTagName("pop");
            XmlNodeList passingCommentsList = xmlDoc.GetElementsByTagName("passingcomment");
            XmlNodeList frontList = xmlDoc.GetElementsByTagName("front");
            XmlNodeList rearList = xmlDoc.GetElementsByTagName("rear");
            XmlNodeList sideList = xmlDoc.GetElementsByTagName("side");
            XmlNodeList scrabbleList = xmlDoc.GetElementsByTagName("scrabble");
            XmlNodeList tacklingcommentsList = xmlDoc.GetElementsByTagName("tacklingcomment");
            XmlNodeList dropList = xmlDoc.GetElementsByTagName("drop");
            XmlNodeList puntsList = xmlDoc.GetElementsByTagName("punt");
            XmlNodeList grubberList = xmlDoc.GetElementsByTagName("grubber");
            XmlNodeList goalList = xmlDoc.GetElementsByTagName("goal");
            XmlNodeList kickingList = xmlDoc.GetElementsByTagName("kickingcomment");
            XmlNodeList editList = xmlDoc.GetElementsByTagName("lastedited");

            for (int i = 0; i <= sruList.Count; i++) //loop the amount of sru's there are (one for each player)
            {
                if (sruList[i].InnerText == MemberSRU) //if the sru in document matches the player sru then we found a match
                {
                    //display all the player skills data on screen
                    SkillBox_Standard.SelectedIndex = Convert.ToInt32(standardList[i].InnerText) - 1;
                    SkillBox_Spin.SelectedIndex = Convert.ToInt32(spinList[i].InnerText) - 1;
                    SkillBox_Pop.SelectedIndex = Convert.ToInt32(popList[i].InnerText) - 1;
                    TXTBOX_Passing.Text = passingCommentsList[i].InnerText;
                    SkillBox_Front.SelectedIndex = Convert.ToInt32(frontList[i].InnerText) - 1;
                    SkillBox_Rear.SelectedIndex = Convert.ToInt32(rearList[i].InnerText) - 1;
                    SkillBox_Side.SelectedIndex = Convert.ToInt32(sideList[i].InnerText) - 1;
                    SkillBox_Scrabble.SelectedIndex = Convert.ToInt32(scrabbleList[i].InnerText) - 1;
                    TXTBOX_Tackling.Text = tacklingcommentsList[i].InnerText;
                    SkillBox_Drop.SelectedIndex = Convert.ToInt32(dropList[i].InnerText) - 1;
                    SkillBox_Punt.SelectedIndex = Convert.ToInt32(puntsList[i].InnerText) - 1;
                    SkillBox_Grubber.SelectedIndex = Convert.ToInt32(grubberList[i].InnerText) - 1;
                    SkillBox_Goal.SelectedIndex = Convert.ToInt32(goalList[i].InnerText) - 1;
                    TXTBOX_Kicking.Text = kickingList[i].InnerText;
                    LBL_LastEdited.Content = editList[i].InnerText;

                    break;
                }
            }
        }

        private void BTN_Back_Click(object sender, RoutedEventArgs e)
        {
            Roster.Show(); //show the roster window
            Close(); //close window
        }

        private void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            //opens and laods the xml skill document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Directory.GetCurrentDirectory() + "/skilldata.xml");

            //create a list of all the elements that will be edited
            XmlNodeList sruList = xmlDoc.GetElementsByTagName("sru");
            XmlNodeList standardList = xmlDoc.GetElementsByTagName("standard");
            XmlNodeList spinList = xmlDoc.GetElementsByTagName("spin");
            XmlNodeList popList = xmlDoc.GetElementsByTagName("pop");
            XmlNodeList passingCommentsList = xmlDoc.GetElementsByTagName("passingcomment");
            XmlNodeList frontList = xmlDoc.GetElementsByTagName("front");
            XmlNodeList rearList = xmlDoc.GetElementsByTagName("rear");
            XmlNodeList sideList = xmlDoc.GetElementsByTagName("side");
            XmlNodeList scrabbleList = xmlDoc.GetElementsByTagName("scrabble");
            XmlNodeList tacklingcommentsList = xmlDoc.GetElementsByTagName("tacklingcomment");
            XmlNodeList dropList = xmlDoc.GetElementsByTagName("drop");
            XmlNodeList puntsList = xmlDoc.GetElementsByTagName("punt");
            XmlNodeList grubberList = xmlDoc.GetElementsByTagName("grubber");
            XmlNodeList goalList = xmlDoc.GetElementsByTagName("goal");
            XmlNodeList kickingList = xmlDoc.GetElementsByTagName("kickingcomment");
            XmlNodeList editedList = xmlDoc.GetElementsByTagName("lastedited");

            for (int i = 0; i < sruList.Count; i++) //loop the amount of sru's there are (one for each player)
            {
                if (sruList[i].InnerText == MemberSRU) //if the sru in document matches the player sru then we found a match
                {
                    //save all the fields to the document
                    standardList[i].InnerText = (SkillBox_Standard.SelectedIndex + 1).ToString();
                    spinList[i].InnerText = (SkillBox_Spin.SelectedIndex + 1).ToString();
                    popList[i].InnerText = (SkillBox_Pop.SelectedIndex + 1).ToString();
                    passingCommentsList[i].InnerText = TXTBOX_Passing.Text;
                    frontList[i].InnerText = (SkillBox_Front.SelectedIndex + 1).ToString();
                    rearList[i].InnerText = (SkillBox_Rear.SelectedIndex + 1).ToString();
                    sideList[i].InnerText = (SkillBox_Side.SelectedIndex + 1).ToString();
                    scrabbleList[i].InnerText = (SkillBox_Scrabble.SelectedIndex + 1).ToString();
                    tacklingcommentsList[i].InnerText = TXTBOX_Tackling.Text;
                    dropList[i].InnerText = (SkillBox_Drop.SelectedIndex + 1).ToString();
                    puntsList[i].InnerText = (SkillBox_Punt.SelectedIndex + 1).ToString();
                    grubberList[i].InnerText = (SkillBox_Grubber.SelectedIndex + 1).ToString();
                    goalList[i].InnerText = (SkillBox_Goal.SelectedIndex + 1).ToString();
                    kickingList[i].InnerText = TXTBOX_Kicking.Text;
                    editedList[i].InnerText = DateTime.Now.Date.ToShortDateString();
                }
            }

            xmlDoc.Save(Directory.GetCurrentDirectory() + "/skilldata.xml"); //save document

            MessageBox.Show("Player profile saved!", "Saved!");
        }
    }
}
