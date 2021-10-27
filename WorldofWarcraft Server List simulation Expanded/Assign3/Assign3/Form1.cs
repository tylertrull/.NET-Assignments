//Written by: Ian Sullivan and Tyler Trull
//Form1.cs
//Date Due: 2/25/20

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign3
{
    public partial class Form1 : Form
    {
        private static uint MAX_LEVEL = 60;

        public static Dictionary<uint, Player> playerDictionary = new Dictionary<uint, Player>(); // player dictionary
        public static Dictionary<uint, guild> guildDictionary = new Dictionary<uint, guild>(); // guild dictionary
        //Struct for a guild
        public struct guild
        {
            public guild(int guildid, int guildtype, string guildname, string serverName)
            {
                id = guildid;
                type = guildtype;
                name = guildname;
                server = serverName;
            }

            public int id { get; }
            public int type { get; }
            public string name { get; }
            public string server { get; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        //Sets values for form boxes
        private void Form1_Load(object sender, EventArgs e)
        {
            MinBox.Minimum = 0;
            MinBox.Maximum = MAX_LEVEL;
            MaxBox.Minimum = 0;
            MaxBox.Maximum = MAX_LEVEL;

            ReadGuilds(); //Must come first so players can be made properly
            ReadPlayers(); //Read the player file and store
            reloadPlayerList();
            reloadGuildList();
        }

        //Reads the playerfile and inserts a bunch of player objects into the player dictionary
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
                string server = "";//It stays empty if nothing happens to it.

                foreach (KeyValuePair<uint, guild> guildValue in guildDictionary)
                {
                    //Console.WriteLine(Convert.ToUInt32(words[7]) + " - " + guildValue.Key);
                    if (Convert.ToUInt32(words[7]) == guildValue.Key)
                    {
                        //Console.WriteLine("Hey I returned this!");
                        server = guildValue.Value.server;
                    }
                }

                //Create our player
                Player newPlayer = new Player(Convert.ToUInt32(words[0]), words[1], (Convert.ToUInt32(words[2])),
                    (Convert.ToUInt32(words[3])), Convert.ToUInt32(words[5]), Convert.ToUInt32(words[6]), Convert.ToUInt32(words[7]), Convert.ToUInt32(words[4]), server);


                //Add the player into the dictionary ith the id being the key
                playerDictionary.Add(newPlayer.Id.GetValueOrDefault(), newPlayer);
            }


        }

        //Reads the file of guilds into a guild dictionary
        public void ReadGuilds()
        {

            string[] lines = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "guilds.txt"));
            Console.WriteLine("Reading Guilds...");
            foreach (string line in lines)
            {
                string[] words = line.Split('\t');
                string[] guildNames = words[2].Split('-');
                //Query.Text += guildNames[0] + " " + guildNames[1] + "\n";
                //Creates a guild based on the struct
                guild g = new guild(Convert.ToInt32(words[0]), Convert.ToInt32(words[1]), guildNames[0], guildNames[1]);
                //Adds the guild to the dictionary
                guildDictionary.Add(Convert.ToUInt32(g.id), g);
            }
        }

        //Reloads the player list from the dictionary.
        //Usually called whenever the playerDictionary is updated or we've changed the listbox temporarily 
        private void reloadPlayerList()
        {
            var sb = new StringBuilder();
            foreach (KeyValuePair<uint, Player> player in playerDictionary.OrderBy(key => key.Key))
            {
                sb.Clear();
                sb.Append(String.Format("{0,-15}  {1,-10}  {2,-5}", player.Value.Name, player.Value.PlayerClass, player.Value.Level)); //This is where you need to change the formatting
                string newItem = sb.ToString();

            }
        }

        //Reloads the guild list from the dictionary.
        private void reloadGuildList()
        {


            foreach (KeyValuePair<uint, guild> guild in guildDictionary.OrderBy(key => key.Key))
            {
                string[] splitstring = guild.Value.name.Split('-');
                //guildListBox.Items.Add(String.Format("{0,-25} [{1}]", splitstring[0], splitstring[1])); //You probably need to change the formatting here.
            }

        }

        //Clears out the Query text box.
        //Then it uses a LINQ to find all players with the server and class member provided
        //It then formats that into the Query box giving an error if the user didn't provide enough info
        private void button1_Click(object sender, EventArgs e)
        {
            Query.Clear(); //Clear out the query before printing.

            if (ClassBox.Text != "" && ServerBox.Text != "")
            {
                string classvalue = ClassBox.Text;
                string servervalue = ServerBox.Text;

                //Create LINQ statement that gets every person of classvalue that is in servervalue

                var SortedPlayerQuery =
                    from player in playerDictionary
                    where (player.Value.PlayerClass.ToString() == ClassBox.Text)
                    where (player.Value.Server == ServerBox.Text)
                    orderby player.Value.Level ascending
                    select player;

                //Then print the tostring of all the players that fit that criteria
                Query.Text = "All " + classvalue + "(s) from " + servervalue + "\n";
                Query.Text += "-------------------------------------------------------------------\n";


                foreach (KeyValuePair<uint, Player> player in SortedPlayerQuery)
                {
                    string guildName = "no guild";

                    foreach (KeyValuePair<uint, guild> g in guildDictionary)
                    {
                        if (player.Value.GuildID == g.Value.id)
                        {
                            guildName = g.Value.name;
                        }
                    }


                    Query.Text += String.Format("Name: {0,14}   ({1,8}  - {2,6})  Race: {3,8} Level: {4,2}  <{5}>\n",
                        player.Value.Name, player.Value.PlayerClass.ToString(), player.Value.PlayerRole.ToString(), player.Value.Race.ToString(), player.Value.Level.ToString(),
                        guildName);
                }

                Query.Text += "END RESULTS\n";
                Query.Text += "-------------------------------------------------------------------\n";

            }
            else
            {
                Query.Text = "Either Class or Server is empty. Please select a value and then try again.";
            }

        }

        //Uses .Count and LINQ queries to count and then determine the race % breakdown of all players on a given server
        private void button2_Click(object sender, EventArgs e)
        {
            int Orc = 0;
            int Troll = 0;
            int Tauren = 0;
            int Forsaken = 0;
            int Total = 0;
            if (ServerBox2.Text != "")
            {
                string serverValue = ServerBox2.Text;

                //Create LINQ statement that gets all players from servervalue
                //With those players count the total number of orcs, trolls, taurens, and forsakens
                Orc =
                    (from player in playerDictionary
                     where (player.Value.Race.ToString() == "Orc")
                     where (player.Value.Server == serverValue)
                     select player).Count();
                Troll =
                    (from player in playerDictionary
                     where (player.Value.Race.ToString() == "Troll")
                     where (player.Value.Server == serverValue)
                     select player).Count();
                Tauren =
                    (from player in playerDictionary
                     where (player.Value.Race.ToString() == "Tauren")
                     where (player.Value.Server == serverValue)
                     select player).Count();
                Forsaken =
                    (from player in playerDictionary
                     where (player.Value.Race.ToString() == "Forsaken")
                     where (player.Value.Server == serverValue)
                     select player).Count();


                Total = Orc + Troll + Tauren + Forsaken;
                double orcPercent = (double)Orc / Total;
                double trollPercent = (double)Troll / Total;
                double taurenPercent = (double)Tauren / Total;
                double forsakenPercent = (double)Forsaken / Total;

                Query.Text = "Percentage of Each Race from " + serverValue + "\n";
                Query.Text += "---------------------------------------------------------------\n";
                Query.Text += String.Format("{0,-8}:    {1,4:P2}\n", "Orc", orcPercent);
                Query.Text += String.Format("{0,-8}:    {1,4:P2}\n", "Troll", trollPercent);
                Query.Text += String.Format("{0,-8}:    {1,4:P2}\n", "Tauren", taurenPercent);
                Query.Text += String.Format("{0,-8}:    {1,4:P2}\n", "Forsaken", forsakenPercent);
                Query.Text += "END RESULTS\n";
                Query.Text += "---------------------------------------------------------------\n";

            }
            else
            {
                Query.Text = "The Serverbox is empty. Please select a server and then try again.";
            }
        }

        //Uses a min and max level plus a role and server
        //It queries for all of the players of Role on a Server
        //It then prints them
        private void button3_Click(object sender, EventArgs e)
        {
            Query.Text = "";

            if (RoleBox.Text != "" && ServerBox3.Text != "")
            {
                string roleValue = RoleBox.Text;
                string serverValue = ServerBox3.Text;
                int minLevel = (int)MinBox.Value;
                int maxLevel = (int)MaxBox.Value;

                var SelectedPlayerQuery =
                    from player in playerDictionary
                    where (player.Value.Server == serverValue)
                    where (player.Value.PlayerRole.ToString() == roleValue)
                    where (player.Value.Level >= minLevel && player.Value.Level <= maxLevel)
                    orderby player.Value.Level ascending
                    select player;


                //Create LINQ statement that gets all players of rolevalue that are in server servervalue
                //Then check if their level is between minlevel and maxlevel
                //Call tostring if they do meet this criteria

                Query.Text = "All " + roleValue + " from [" + serverValue + "], Levels " + minLevel.ToString() + " to " + maxLevel.ToString() + "\n";
                Query.Text += "-----------------------------------------------------------------------------------\n";
                foreach (KeyValuePair<uint, Player> player in SelectedPlayerQuery)
                {
                    string guildName = "no guild";

                    foreach(KeyValuePair<uint, guild> g in guildDictionary)
                    {
                        if (player.Value.GuildID == g.Value.id)
                        {
                            guildName = g.Value.name;
                        }
                    }


                    Query.Text += String.Format("Name: {0,14}   ({1,8}  - {2,6})  Race: {3,8} Level: {4,2}  <{5}>\n",
                        player.Value.Name, player.Value.PlayerClass.ToString(), player.Value.PlayerRole.ToString(), player.Value.Race.ToString(), player.Value.Level.ToString(),
                        guildName);
                }
                Query.Text += "END RESULTS\n";
                Query.Text += "-----------------------------------------------------------------------------------\n";

            }
            else
            {
                Query.Text = "The Rolebox or Serverbox is empty. Please select both a Role and Server and then try again.";
            }
        }

        //Simply Queries all guilds on a given server by the guild type.
        //Prints them after
        private void button4_Click(object sender, EventArgs e)
        {
            Query.Clear();

            if (TypeBox.Text != "")
            {
                int typevalue = TypeBox.SelectedIndex;

                var SelectedGuilds =
                    from g in guildDictionary
                    where (g.Value.type == typevalue)
                    orderby g.Value.name ascending
                    group g by g.Value.server;


                Query.Text += "All " + TypeBox.Text + "-Type of Guilds\n";
                Query.Text += "------------------------------------------------------------------------------\n";
                foreach(var GroupByServer in SelectedGuilds)
                {
                    Query.Text += GroupByServer.Key + "\n";
                    foreach(KeyValuePair<uint, guild> g in GroupByServer)
                    {
                        Query.Text += "        <" + g.Value.name + ">\n";
                    }
                }

                Query.Text += "END RESULTS\n";
                Query.Text += "------------------------------------------------------------------------------\n";
            }
            else
            {
                Query.Text = "The Typebox is empty. Please select a type and then try again.";
            }
        }

        //It takes a check input
        //It uses the role given by the check to determine which query to use
        //The queries simply search for the classes within the role and check to make sure the player doesn't currently have the selected role.
        //It then prints any players matching that criterion
        private void button5_Click(object sender, EventArgs e)
        {
            string rolevalue = "";
            if (TankButton.Checked || HealerButton.Checked || DamageButton.Checked)
            {
                foreach(var control in RoleGroupBox.Controls)
                {
                    RadioButton radio = control as RadioButton;
                    if(radio != null && radio.Checked)
                    {
                        rolevalue = radio.Text;
                    }
                }
                
                //Uses a different query and print based on which role is selected
                switch (rolevalue)
                {

                    case "Tank":

                        var TankQuery =
                            from player in playerDictionary
                            where ((player.Value.PlayerClass.ToString() == "Warrior" || player.Value.PlayerClass.ToString() == "Druid" ||
                            player.Value.PlayerClass.ToString() == "Paladin") && player.Value.PlayerRole.ToString() != "Tank")
                            orderby player.Value.Level ascending
                            select player;

                        Query.Text = "All Eligible Players Not Fulfilling the Tank Role\n";
                        Query.Text += "--------------------------------------------------------------------\n";
                        foreach (KeyValuePair<uint, Player> player in TankQuery)
                        {
                            string guildName = "no guild";

                            foreach (KeyValuePair<uint, guild> g in guildDictionary)
                            {
                                if (player.Value.GuildID == g.Value.id)
                                {
                                    guildName = g.Value.name;
                                }
                            }


                            Query.Text += String.Format("Name: {0,14}   ({1,8}  - {2,6})  Race: {3,8} Level: {4,2}  <{5}>\n",
                                player.Value.Name, player.Value.PlayerClass.ToString(), player.Value.PlayerRole.ToString(), player.Value.Race.ToString(), player.Value.Level.ToString(),
                                guildName);
                        }
                        Query.Text += "END RESULTS\n";
                        Query.Text += "--------------------------------------------------------------------\n";

                        break;

                    case "Healer":

                        var HealerQuery =
                            from player in playerDictionary
                            where ((player.Value.PlayerClass.ToString() == "Priest" || player.Value.PlayerClass.ToString() == "Druid" ||
                            player.Value.PlayerClass.ToString() == "Paladin" || player.Value.PlayerClass.ToString() == "Shaman")
                            && player.Value.PlayerRole.ToString() != "Healer")
                            orderby player.Value.Level ascending
                            select player;

                        Query.Text = "All Eligible Players Not Fulfilling the Healer Role\n";
                        Query.Text += "--------------------------------------------------------------------\n";
                        foreach (KeyValuePair<uint, Player> player in HealerQuery)
                        {
                            string guildName = "no guild";

                            foreach (KeyValuePair<uint, guild> g in guildDictionary)
                            {
                                if (player.Value.GuildID == g.Value.id)
                                {
                                    guildName = g.Value.name;
                                }
                            }


                            Query.Text += String.Format("Name: {0,14}   ({1,8}  - {2,6})  Race: {3,8} Level: {4,2}  <{5}>\n",
                                player.Value.Name, player.Value.PlayerClass.ToString(), player.Value.PlayerRole.ToString(), player.Value.Race.ToString(), player.Value.Level.ToString(),
                                guildName);
                        }
                        Query.Text += "END RESULTS\n";
                        Query.Text += "--------------------------------------------------------------------\n";

                        break;

                    case "Damage":

                        var DPSQuery =
                            from player in playerDictionary
                            where (player.Value.PlayerRole.ToString() != "Damage") //Every class can be dps so we're just looking for anyone who isn't labeled Damage
                            orderby player.Value.Level ascending
                            select player;

                        Query.Text = "All Eligible Players Not Fulfilling the Damage Role\n";
                        Query.Text += "--------------------------------------------------------------------\n";
                        foreach (KeyValuePair<uint, Player> player in DPSQuery)
                        {
                            string guildName = "no guild";

                            foreach (KeyValuePair<uint, guild> g in guildDictionary)
                            {
                                if (player.Value.GuildID == g.Value.id)
                                {
                                    guildName = g.Value.name;
                                }
                            }


                            Query.Text += String.Format("Name: {0,14}   ({1,8}  - {2,6})  Race: {3,8} Level: {4,2}  <{5}>\n",
                                player.Value.Name, player.Value.PlayerClass.ToString(), player.Value.PlayerRole.ToString(), player.Value.Race.ToString(), player.Value.Level.ToString(),
                                guildName);
                        }
                        Query.Text += "END RESULTS\n";
                        Query.Text += "--------------------------------------------------------------------\n";

                        break;

                    default: 
                        Query.Text = "There was an error with the selected role";
                        break;
                }


            }
            else
            {
                Query.Text = "No role was selected. Please select a role and try again";
            }

        }

        //It first finds all players and then sorts them by guild
        //It then counts all of the players in each guild
        //It then counts all of the players of max level in each guild
        //It then searches for the guild name and does some math with the found numbers
        //It then prints the results
        private void button6_Click(object sender, EventArgs e)
        {

            Query.Text = "Percentage of Max Level Players in ALL guilds\n";
            Query.Text += "------------------------------------------------------------\n";

            var PlayerQuery =
                    from player in playerDictionary
                    orderby player.Value.Level ascending
                    group player by player.Value.GuildID;
           

            foreach(var GroupByGuild in PlayerQuery)
            {
                string gName = "";
                double maxLevelPercent = 0;

                double playerCount =
                    (from pc in playerDictionary
                    where (GroupByGuild.Key == pc.Value.GuildID)
                    select pc).Count(); //Count the number of players in the guild

                if (playerCount > 0) //As long as the guild has players
                {
                    double maxLevelCount =
                        (from ml in playerDictionary
                         where (GroupByGuild.Key == ml.Value.GuildID && ml.Value.Level == 60) //They're in the guild and level 60
                         select ml).Count();//Find the amount of max level players in this guild

                    foreach(KeyValuePair<uint, guild> g in guildDictionary)
                    {
                        if(GroupByGuild.Key == g.Key)
                        {
                            gName = g.Value.name; //This obtains the actual guild name
                        }
                    }

                    maxLevelPercent = maxLevelCount / playerCount;


                    Query.Text += String.Format("{0,-25}  {1,-10:P2}\n", "<" + gName + ">", maxLevelPercent);
                    

                }
                    
            }

            Query.Text += "END RESULTS\n";
            Query.Text += "------------------------------------------------------------\n";

            
        }

        //Simply makes sure that when the minbox is changed it isn't greater than the max box
        private void MinBox_ValueChanged(object sender, EventArgs e)
        {
            if(MinBox.Value > MaxBox.Value)
            {
                MaxBox.Value = MinBox.Value;
            }
        }

        //Simply makes sure that when the maxbox is changed it isn't less than the minbox
        private void MaxBox_ValueChanged(object sender, EventArgs e)
        {
            if(MaxBox.Value < MinBox.Value)
            {
                MinBox.Value = MaxBox.Value;
            }
        }
    }
}
