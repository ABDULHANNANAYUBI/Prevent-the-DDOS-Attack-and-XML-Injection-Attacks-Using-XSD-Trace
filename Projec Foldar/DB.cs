using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace Finite_Automata
{
    public static class DB
    {
        public static List<User> users;

        [Obsolete]
        static DB()
        {
            string username = string.Empty;
            string IP = string.Empty;
            string password = string.Empty;
            users = new List<User>();

            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream("db.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Database");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                username = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                IP = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                password = xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                User user = new User(username, password, IP, TimeGenerator.RandomDay(), DateTime.Now, 0);
                users.Add(user);
            }

        }
        public static void Add(User user)
        {
            users.Add(user);          
        }
    }
}
