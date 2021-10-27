/* Coded by: Ian Sullivan and Tyler Trull
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign2
{
    public partial class Form1 : Form
    {

        public static Dictionary<uint, Player> playerDictionary = new Dictionary<uint, Player>(); // player dictionary
        public static Dictionary<uint, string> guildDictionary = new Dictionary<uint, string>(); // guild dictionary
        


        public Form1()
        {
            InitializeComponent();
        }

        //On the form load it needs to read both the guild and player files then load them into the listboxes
        public void Form1_Load(object sender, EventArgs e)
        {
            ReadPlayers(); //Read the player file and store
            ReadGuilds();
            //Console.WriteLine("Hey I loaded the players?!");
            reloadPlayerList();
            reloadGuildList();

        }

        //Reads the file of players into a list of player objects
        private static void ReadPlayers()
        {
            //Reads the file
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\isull\Desktop\ALAST\Github\IT_Assigns\players.txt");
            string[] lines = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "players.txt"));
            Console.WriteLine("Reading players...");
            //Splits textfile into lines
            foreach (string line in lines)
            {
                //Splits line into words
                string[] words = line.Split('\t');

                //Create our player
                Player newPlayer = new Player(Convert.ToUInt32(words[0]), words[1], ((Player.Racial)Convert.ToUInt32(words[2])),
                    ((Player.Class)Convert.ToUInt32(words[3])), Convert.ToUInt32(words[4]), Convert.ToUInt32(words[5]), Convert.ToUInt32(words[6]));
                //Add the player into the dictionary ith the id being the key
                playerDictionary.Add(newPlayer.Id.GetValueOrDefault(), newPlayer);
            }

            
        }

        //Reads the file of guilds into a guild dictionary
        public static void ReadGuilds()
        {
            
            string[] lines = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "guilds.txt"));
            Console.WriteLine("Reading Guilds...");
            foreach (string line in lines)
            {
                string[] words = line.Split('\t');
                guildDictionary.Add(Convert.ToUInt32(words[0]), words[1]);
            }
        }

        //Reloads the player list from the dictionary.
        //Usually called whenever the playerDictionary is updated or we've changed the listbox temporarily 
        private void reloadPlayerList()
        {
            var sb = new StringBuilder();
            playerListBox.Items.Clear();
            foreach (KeyValuePair<uint, Player> player in playerDictionary.OrderBy(key => key.Key))
            {
                sb.Clear();
                sb.Append(String.Format("{0,-15}  {1,-10}  {2,-5}", player.Value.Name, player.Value.PlayerClass, player.Value.Level)); //This is where you need to change the formatting
                string newItem = sb.ToString();
                playerListBox.Items.Add(newItem);

            }
        }

        //Reloads the guild list from the dictionary.
        private void reloadGuildList()
        {

            guildListBox.Items.Clear();

            foreach (KeyValuePair<uint, string> guild in guildDictionary.OrderBy(key => key.Key))
            {
                string[] splitstring = guild.Value.Split('-');
                guildListBox.Items.Add(String.Format("{0,-25} [{1}]", splitstring[0], splitstring[1])); //You probably need to change the formatting here.
            }

        }

        //Called when the guild list box index is changed
        //Just displays the selected item to output
        private void guildListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (guildListBox.SelectedItem != null)
            {
                Output_textbox.Text = guildListBox.SelectedItem as String; //You might need to change the formatting here look at the assignment thingy
            }
            

        }

        //Called when guild disband is clicked
        //It loops through the dictionary till it matches a guild then loops through the player dictionary looking for that guilds key
        //If it finds players with that key it sets them to null essentially kicking them from the guild.
        private void GuildDisband_Click(object sender, EventArgs e)
        {
            Output_textbox.Clear();
            int disbandCounter = 0;

            if (guildListBox.SelectedItem != null)
            {

                foreach (KeyValuePair<uint, string> guild in guildDictionary)
                {
                    string[] splitstring = guild.Value.Split('-');
                    string guildformated = String.Format("{0,-25} [{1}]", splitstring[0], splitstring[1]);

                    if (guildformated == guildListBox.SelectedItem as string)
                    {

                        foreach (KeyValuePair<uint, Player> player in playerDictionary)
                        {

                            if (guild.Key == player.Value.GuildID)
                            {

                                player.Value.GuildID = null; //No more guild for you
                                disbandCounter++; //Count up 1

                            }

                        }

                    }

                }

                Output_textbox.Text = disbandCounter + " players have been disbanded from " + guildListBox.SelectedItem + "\n";

                //Remove the guild from the dictionary
                uint guildKey = 0;

                foreach (KeyValuePair<uint, string> guild in guildDictionary)
                {

                    if (guildListBox.SelectedItem as string == guild.Value)
                    {

                        guildKey = guild.Key;

                    }

                }

                guildDictionary.Remove(guildKey);
                guildListBox.Items.Remove(guildListBox.SelectedItem); //Remove the guild from the list



            } else
            {
                Output_textbox.AppendText("ERROR DISBANDING GUILD: Please select an item from the guild list box before trying to remove something!");
            }
        }


        //This function is important to format.

        //Called when print guild roster is clicked
        //It just checks for the guilds id in the playerDictionary
        //It then formats and prints those players to output
        private void PrintGuildRoster_Click(object sender, EventArgs e)
        {
            Output_textbox.Clear();

            //A guild has to be selected
            if (guildListBox.SelectedItem != null)
            {
                Output_textbox.AppendText("Guild Listing for " + guildListBox.SelectedItem + "\n ------------------------------------------------------ \n");

                foreach (KeyValuePair<uint, string> guild in guildDictionary)
                {
                    //Converts the guild value to that of the value displayed in guildtext to make formating easier
                    string[] splitstring = guild.Value.Split('-');
                    string guildformated = String.Format("{0,-25} [{1}]", splitstring[0], splitstring[1]);
                    //Check the guild dictionary for the guilds id
                    if (guildformated == guildListBox.SelectedItem as string)
                    {
                        //Checks the player dictionary
                        foreach (KeyValuePair<uint, Player> player in playerDictionary.OrderBy(item => item.Value.Name))
                        {

                            //For each player check if their guild id matches
                            if (guild.Key == player.Value.GuildID)
                            {

                                //This needs to be formatted and probably also sorted alphabetically but that might be optional?
                                Output_textbox.AppendText(String.Format("Name: {0,-15} Race:{1,-15}Level:{2, -15}Guild:{3, -15} \n",player.Value.Name, player.Value.Race, player.Value.Level, guildListBox.SelectedItem));

                            }

                        }

                    }


                }
                //If a value wasn't selected print an error
            }
            else
            {
                Output_textbox.AppendText("ERROR NO GUILD: Please select a guild from the list of guilds on the right and try again!");
            }
        }

        //Called when Join guild is clicked
        //Makes sure that both a player and a guild are selected
        //It then uses the guildDictionary Value to compare to the selected item.
        //Make sure if you change how the value is stored you change this function Tyler
        //It sets the player selecteds guild id to the guild key
        private void JoinGuild_Click(object sender, EventArgs e)
        {

            Output_textbox.Clear();
            string selectedItem;
            string[] words;

            if ((playerListBox.SelectedIndex != -1) && (guildListBox.SelectedItem != null))
            {
                

                foreach(KeyValuePair<uint, string> guild in guildDictionary)
                {

                    string[] splitstring = guild.Value.Split('-');
                    string guildformated = String.Format("{0,-25} [{1}]", splitstring[0], splitstring[1]);

                    if (guildformated == guildListBox.SelectedItem as string)
                    {

                        foreach(KeyValuePair<uint, Player> player in playerDictionary)
                        {
                            selectedItem = playerListBox.GetItemText(playerListBox.SelectedItem);
                            words = selectedItem.Split(' ');

                            //Output_textbox.Text += player.Value.Name;
                            //Output_textbox.Text += words[0] + "\n";

                            if (player.Value.Name == words[0])
                            {

                                player.Value.GuildID = guild.Key; //Set their guildid aka join the guild
                                Output_textbox.Text = player.Value.Name + " joined the guild " + guildListBox.SelectedItem as string + "!";

                            }

                        }

                    }

                }


            } else
            {
                Output_textbox.Text = "ERROR JOINING GUILD: please select both a player and a guild from the lists to the right.";
            }

        }

        //If the playerlistboxs selected item changes just print it to output.
        private void PlayerListBox_Change(object sender, EventArgs e)
        {
            if (playerListBox.SelectedItem != null)
            {
                string[] splitstring = playerListBox.SelectedItem.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                Output_textbox.Text = String.Format("Name: {0,-15} Race: {1,-15} Level: {2,-15} ", splitstring[0], splitstring[1], splitstring[2]);
            }
        }

        //Called when leave guild is clicked
        //Checks to make sure a player is selected
        //It then loops through the playerDictionary and sets the players guild ID to null
        private void LeaveGuild_Click(object sender, EventArgs e)
        {

            if (playerListBox.SelectedItem != null)
            {

                foreach (KeyValuePair<uint, Player> player in playerDictionary)
                {

                    string selectedItem = playerListBox.GetItemText(playerListBox.SelectedItem);
                    string[] words = selectedItem.Split(' ');

                    //Output_textbox.Text += player.Value.Name;
                    //Output_textbox.Text += words[0] + "\n";

                    if (player.Value.Name == words[0])
                    {

                        player.Value.GuildID = null; //Set their guildid aka join the guild
                        Output_textbox.Text = player.Value.Name + " has left their guild!";

                    }

                }


            } else
            {
                Output_textbox.Text = "ERROR LEAVING GUILD: Please select a player from the list to the right!";
            }

        }

        //This one's kind of complicated.
        //If you change how anything gets stored into dictionaries at least make sure this works.
        //At the end of all your changes make sure this works. It's the easiest thing to break.
        //Both of these need their formatting changed.
        //Basically it has four states. Zero, player search, guild search, both
        //Zero has no values given they just clicked the button because they like buttons. It just reloads the player and guild lists.
        //Player searches for the string given at the front of each player in playerDictionary. It only needs part of the player name but can handle exact searches.
        //Guild searches for exact searches only. If Zappyboi is written like that it will find nothing. ZappyBoi only. It searches for the server name.
        //Both applies the above logic at the same time.
        //If nothing is found it will print an error unique to the sitaution.
        private void ApplySearchCriteria_Click(object sender, EventArgs e)
        {

            playerListBox.Items.Clear();
            guildListBox.Items.Clear();
            //Clear them to filter new items in

            //So I need to first make two combo boxes search by name and search by server
            //Then I need to basically check to see if they're null if null give every result
            //Honestly just read the assignment 
            if (SearchPlayer_Textbox == null && SearchGuild_Combobox == null) //Might have to changethis to be ""
            {

                reloadGuildList();
                reloadPlayerList();

            } else if (SearchPlayer_Textbox != null && SearchGuild_Combobox == null)
            {

                reloadGuildList(); //They blanked it so no filter
                bool playerFound = false; //If any player is found this is set to true

                foreach (KeyValuePair<uint, Player> player in playerDictionary)
                {

                    if (player.Value.Name.StartsWith(SearchPlayer_Textbox.Text))
                    {

                        var sb = new StringBuilder();

                        sb.Clear();
                        sb.Append(String.Format("{0,-15} {1, -10} {2, -5}", player.Value.Name, player.Value.PlayerClass, player.Value.Level)); // NEED FORMATTING HERE
                        string newItem = sb.ToString();

                        playerListBox.Items.Add(newItem);
                        playerFound = true;

                    }

                }

                if(playerFound == false)
                {

                    Output_textbox.Text = "ERROR FINDING PLAYER: No players found please search using either the exact name or the first part of a name.";
                    reloadPlayerList(); //Nothing found reload the list

                }

            } else if (SearchPlayer_Textbox == null && SearchGuild_Combobox != null)
            {

                reloadPlayerList(); //It's blank so reload it
                bool guildFound = false; //If any guild is found this is set to true;

                foreach(KeyValuePair<uint, string> guild in guildDictionary)
                {

                    string[] words = guild.Value.Split('-');

                    if (words[1] == SearchGuild_Combobox.Text)
                    {

                        guildListBox.Items.Add(guild.Value);
                        guildFound = true;

                    }

                }

                if (guildFound == false)
                {

                    reloadGuildList(); //Nothings found so reload the guild list
                    Output_textbox.Text = "ERROR FINDING GUILD: No guilds matched your search. Please search the exact name of the server and nothing else.";

                }

            } else if (SearchPlayer_Textbox != null && SearchGuild_Combobox != null) {

                bool playerFound = false; //If a player is found this is set to true
                bool guildFound = false; //If a guild is found this is set to true

                foreach (KeyValuePair<uint, Player> player in playerDictionary)
                {

                    if (player.Value.Name.StartsWith(SearchPlayer_Textbox.Text))
                    {

                        var sb = new StringBuilder();

                        sb.Clear();
                        sb.Append(String.Format("{0,-15} {1, 8} {2, 18}", player.Value.Name, player.Value.PlayerClass, player.Value.Level)); // NEED FORMATTING HERE
                        string newItem = sb.ToString();

                        playerListBox.Items.Add(newItem);
                        playerFound = true;

                    }

                }

                if (playerFound == false)
                {

                    Output_textbox.Text = "ERROR FINDING PLAYER: No players found please search using either the exact name or the first part of a name.";
                    reloadPlayerList(); //Nothing found reload the list

                }

                foreach (KeyValuePair<uint, string> guild in guildDictionary)
                {

                    string[] words = guild.Value.Split('-');

                    if (words[1] == SearchGuild_Combobox.Text)
                    {

                        guildListBox.Items.Add(guild.Value);
                        guildFound = true;

                    }

                }

                if (guildFound == false)
                {

                    reloadGuildList(); //Nothings found so reload the guild list
                    Output_textbox.Text = "ERROR FINDING GUILD: No guilds matched your search. Please search the exact name of the server and nothing else.";

                }

                if (guildFound == false && playerFound == false)
                {

                    Output_textbox.Text = "ERROR FINDING SEARCHES: No guilds or players matched your results. Please search either the exact name or beginning of players names and only the exact name of the guild server.";

                }

            }


        }

        //Called when add player is clicked
        //Checks to make sure all the boxes are filled out
        //There's a degree of sanity checking here but it can be broken for sure.
        //Names can be whatever you want them to be but it was not a requirement to sanatize names.
        //It generates a unique id using GenerateUniqueID and then finds the values in uint for each of the given roles,classes,races
        //It then generates a new player class and stores it in the playerDictionary and reloads the playerlist.
        private void AddPlayer_Click(object sender, EventArgs e)
        {

            Output_textbox.Clear();

            //If all the things are at least set
            if (NewName_Textbox != null && NewClass_Combobox != null && NewRace_Combobox != null && NewRole_Combobox != null)
            {

                uint UniqueID = GenerateUniqueID();
                uint NewRace = CheckNewRace(NewRace_Combobox.Text);
                uint NewClass = CheckNewClass(NewClass_Combobox.Text);
                uint NewRole = CheckNewRole(NewRole_Combobox.Text);


                Player newPlayer = new Player(UniqueID, NewName_Textbox.Text, NewRace, NewClass, 0, 0, null, NewRole);
                playerDictionary.Add(UniqueID, newPlayer); //Add them to the list
                reloadPlayerList();

                NewName_Textbox.Clear();
                NewClass_Combobox.Text = "";
                NewRace_Combobox.Text = "";
                NewRole_Combobox.Text = "";

            } else
            {
                Output_textbox.Text = "ERROR MAKING NEW CHARACTER: Please make sure you've filled out all four create new player boxes!";
            }
        }

        //Used to find the uint for the given role
        //Defaults to DPS since every class can be dps
        private uint CheckNewRole(string newRole)
        {

            uint roleReturn;

            switch (newRole)
            {

                case "Tank":
                case "tank":

                    roleReturn = 0;
                    break;

                case "Healer":
                case "healer":

                    roleReturn = 1;
                    break;

                case "Dps":
                case "dps":
                case "DPS":

                    roleReturn = 2;
                    break;

                default:

                    roleReturn = 2; //Everyone can be a dps.
                    break;
            }

            return roleReturn;

        }

        //Used to find the uint for the given race
        //Defaults to orc since it's first
        private uint CheckNewRace(string newRace)
        {

            uint raceReturn;

            switch (newRace)
            {

                case "Orc":
                case "orc":

                    raceReturn = 0;
                    break;

                case "Troll":
                case "troll":

                    raceReturn = 1;
                    break;

                case "Tauren":
                case "tauren":

                    raceReturn = 2;
                    break;

                case "Forsaken":
                case "forsaken":

                    raceReturn = 3;
                    break;

                default:

                    raceReturn = 0; //Default to orc if they're inputing random garbage.
                    break;

            }

            return raceReturn;

        }

        //Used to find the uint for the given class
        //Defaults to warrior since it's first.
        private uint CheckNewClass(string newClass)
        {
            uint classReturn;

            switch (newClass)
            {

                case "Warrior":
                case "warrior":

                    classReturn = 0;
                    break;

                case "Mage":
                case "mage":

                    classReturn = 1;
                    break;

                case "Druid":
                case "druid":

                    classReturn = 2;
                    break;

                case "Priest":
                case "priest":

                    classReturn = 3;
                    break;

                case "Warlock":
                case "warlock":

                    classReturn = 4;
                    break;

                case "Rouge":
                case "rouge":

                    classReturn = 5;
                    break;

                case "Paladin":
                case "paladin":

                    classReturn = 6;
                    break;

                case "Hunter":
                case "hunter":

                    classReturn = 7;
                    break;

                case "Shaman":
                case "shaman":

                    classReturn = 8;
                    break;

                default:

                    classReturn = 0;
                    break;
                    //If they input random garbage just give them warrior as punishment

            }

            

            return classReturn;

        }

        //Generates a unique id for a player
        //Looks through the player dictionary to check, increment and find a new player id.
        private uint GenerateUniqueID()
        {
            uint newID = 0;
            bool repeat = false;

            while (repeat)
            {

                foreach (KeyValuePair<uint, Player> player in playerDictionary)
                {

                    if (newID == player.Key)
                    {
                        repeat = true;
                        newID++; //It doesn't really matter if it just runs up the line because repeat will only happen once but it's kind of efficient because it'll increment if it matches 0 1 2 yadda yadda till it doesn't
                        //Then it'll check again to be sure there wasn't some weird out of place thing. It'll work for this project.
                    }

                }

            }

            return newID;

        }

        //Called when add guild is clicked
        //Checks to make sure all the boxes have values in them.
        //Almost zero error checking here. It was not required.
        //You can make a Zappyboi you can even probably make two ZappyBois?
        //You can make whatever you want for a name but it will generate a unique ID for the guild.
        //You can even techincally make a brand new server here and it will work as normal everywhere else.
        private void AddGuild_Click(object sender, EventArgs e)
        {

            Output_textbox.Clear();

            if (GuildName_Textbox != null && GuildType_Combobox != null && Server_Combobox != null)
            {

                uint uniqueID = GenerateUniqueGuildID();

                string guildString;

                guildString = GuildName_Textbox.Text + "-" + Server_Combobox.Text; //THIS IS WHERE I PUT THE NEW GUILD STRING INTO THE DICTIONARY
                guildDictionary.Add(uniqueID, guildString);
                reloadGuildList();

                GuildName_Textbox.Text = "";
                GuildType_Combobox.Text = "";
                Server_Combobox.Text = "";

            }

        }

        //Used to generate the unique guild ID
        //Works almost exactly the same as generateuniqueID
        private uint GenerateUniqueGuildID()
        {
            uint newID = 0;
            bool repeat = false;

            while (repeat)
            {

                foreach (KeyValuePair<uint, string> guild in guildDictionary)
                {

                    if (newID == guild.Key)
                    {
                        repeat = true;
                        newID++; //It doesn't really matter if it just runs up the line because repeat will only happen once but it's kind of efficient because it'll increment if it matches 0 1 2 yadda yadda till it doesn't
                        //Then it'll check again to be sure there wasn't some weird out of place thing. It'll work for this project.
                    }

                }

            }

            return newID;

        }
    }
}
