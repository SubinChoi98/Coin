using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Coin
{
    internal class DataManager
    {
        public static List<Users> Users = new List<Users>();

        static DataManager()
        {
            Load();
            Login();
        }
        public static void Load()
        {
            try
            {
                
            }
            catch (FileNotFoundException exception)
            {
                Save();
            }
        }
        public static void Save()
        {

            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var item in Users)
            {
                usersOutput += "<user>\n";
                usersOutput += " <id>" + item.Id + "</id>\n";
                usersOutput += " <password>" + item.Password + "</password>\n";
                usersOutput += " <APIKey1>" + item.APIKey1 + "</APIKey1>\n";
                usersOutput += " <APIKey2>" + item.APIKey2 + "</APIKey2>\n";
                usersOutput += "</user>\n";
            }
            usersOutput += "</users>";

            File.WriteAllText(@"../../data/Users.xml", usersOutput);

        }

        public static void Login()
        {
            try
            {
                string usersOutput = File.ReadAllText(@"../../data/Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users = (from item in usersXElement.Descendants("user")
                            select new Users()
                            {
                                Id = item.Element("id").Value,
                                Password = item.Element("password").Value,
                                APIKey1 = item.Element("APIKey1").Value,
                                APIKey2 = item.Element("APIKey2").Value
                            }).ToList<Users>();
            }
            catch (FileNotFoundException exception)
            {

            }
        }

        public static void UsersSignUp()
        {
            string signUp = "";
            signUp += "<users>\n";
            foreach (var item in Users)
            {
                signUp += "<users>\n";
                signUp += " <id>" + item.Id + "</id>\n";
                signUp += " <password>" + item.Password + "</password>\n";
                signUp += " <APIKey1>" + item.APIKey1 + "</APIKey1>\n";
                signUp += " <APIKey2>" + item.APIKey2 + "</APIKey2>\n";
                signUp += "</users>\n";
            }
            signUp += "</users>";

            File.WriteAllText(@"../../data/Users.xml", signUp);
        }
    }
}
