
//Coded by Ian Sullivan and Tyler Trull
//Player.cs
//Date Due: 2/25/20

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    public class Player
    {

        public enum Racial
        {
            Orc, Troll, Tauren, Forsaken
        };

        public enum Class
        {
            Warrior, //tank or dps
            Mage, // Dps
            Druid, //Tank, healer , dps
            Priest, //Healer dps
            Warlock, //dps
            Rouge, //dps
            Paladin, //dps healer tank
            Hunter, //dps
            Shaman // Healer dps
        };

        public enum Role
        {
            Tank, Healer, Damage
        };

        private static uint MAX_LEVEL = 60;


        private uint? id;
        private string name;
        private Racial? race;
        private uint level;
        private uint exp;
        private uint? guildID;
        private Class? playerClass;
        private Role? playerRole;
        private string server;
        //private uint?[] gear = new uint?[GEAR_SLOTS]; //Creates a 14 slot array. One slot for each item including the rings/trinkets
        //private List<Item> inventory = new List<Item>(new Item[MAX_INVENTORY_SIZE]); //Creates a list of items to be the inventory
        //an inventory of 28 null items
        //These two keep track of the last slot equiped with an it

        //Get / Set properties for all the private data types

        public uint? Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public Racial? Race
        {
            get { return race; }
            private set
            {
                if ((int)value >= 0 && (int)value <= 12)
                {
                    race = value;
                }
                else
                {
                    race = null;
                }
            }
        }

        public uint Level
        {
            get { return level; }
            set
            {
                if (value > 0 && value <= MAX_LEVEL)
                {
                    level = value;
                }
                else
                {
                    level = 0;
                }
            }
        }

        public uint Exp
        {
            get { return exp; }
            set
            {
                exp += value;
                if (exp >= (level * 1000))
                {
                    exp -= level * 1000;
                    level++;
                }
            }
        }

        public uint? GuildID
        {
            get { return guildID; }
            set { guildID = value; }
        }

        public Class? PlayerClass
        {
            get { return playerClass; }
            private set
            {
                //This might be an error I'm kind of tired not sure
                if ((int)value >= 0 && (int)value <= 8)
                {
                    playerClass = value;
                }
                else
                {
                    playerClass = null;
                }
            }
        }

        public Role? PlayerRole
        {
            get { return playerRole; }
            private set
            {
                if ((int)value >= 0 && (int)value <= 2)
                {
                    playerRole = value;
                }
                else
                {
                    playerRole = null;
                }
            }
        }

        //This currently is nullable but might have to be.
        //I was getting a version error preventing me from using nullable with string.
        public string Server
        {
            get { return server; }
            private set
            {
                server = value;
            }
        }

        //Default Constructor
        public Player()
        {
            Id = 0;
            Name = "";
            Race = Racial.Orc;
            Level = 0;
            Exp = 0;
            guildID = 0;
            
            //sets all gear slots to null
        }

        //Constructor for the player
        public Player(uint newId, string newName, Racial newRace, Class newClass, uint newLevel, uint newExp, uint newguildID)
        {
            Id = newId;
            Name = newName;
            Race = newRace;
            PlayerClass = newClass;
            Level = newLevel;
            Exp = newExp;
            guildID = newguildID;
            playerRole = null;
           

        }

        //Player constructor used to take in an int for newrace if need be
        public Player(uint newId, string newName, uint newRace, uint newClass, uint newLevel, uint newExp, uint newguildID)
        {
            Id = newId;
            Name = newName;
            Race = (Racial)newRace;
            PlayerClass = (Class)newClass;
            Level = newLevel;
            Exp = newExp;
            guildID = newguildID;
            playerRole = null;
            

        }

        //Player constructor used to take in an int for newrace if need be
        public Player(uint newId, string newName, uint newRace, uint newClass, uint newLevel, uint newExp, uint? newguildID, uint newRole, string server)
        {
            Id = newId;
            Name = newName;
            Race = (Racial)newRace;
            PlayerClass = (Class)newClass;
            Level = newLevel;
            Exp = newExp;
            guildID = newguildID;
            PlayerRole = (Role)newRole;
            Server = server;
            

        }

        //Standard override for tostring to make printing easier
        public override string ToString()
        {
            return "Name: " + name + "\t Race: " + race + "\t Class: " + playerClass + "\t Level: " + level + "\t Guild: " + guildID;
        }

    }
}
