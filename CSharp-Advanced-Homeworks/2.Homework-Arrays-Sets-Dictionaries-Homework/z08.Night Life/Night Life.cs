using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class NightLife
{
    static void Main(string[] args)
    {
        var database = new Dictionary<string, Dictionary<string, List<string>>>();
        string[] command = Console.ReadLine().Split(';');

        do
        {
            string city = command[0];
            string venue = command[1];
            string performer = command[2];
            if (database.ContainsKey(city))
            {
                if (database[city].ContainsKey(venue))
                {
                    if (!Performers(performer, database[city][venue]))
                    {
                        database[city][venue].Add(performer);
                        database[city][venue].Sort();
                    }
                }
                else
                {
                    database[city].Add(venue, new List<string>());
                    database[city][venue].Add(performer);
                }
            }
            else
            {
                database.Add(city, new Dictionary<string, List<string>>());
                database[city].Add(venue, new List<string>());
                database[city][venue].Add(performer);
            }

            command = Console.ReadLine().Split(';');

        } while (command[0] != "END");

        foreach (string item in database.Keys)
        {
            Console.WriteLine(item);
            var venueList = database[item].Keys.ToList();
            venueList.Sort();
            foreach (string venue in venueList)
            {
                Console.WriteLine("->{0}: {1}", venue, string.Join(", ", database[item][venue]));
            }
        }

    }

    static bool Performers(string s, List<string> l)
    {
        bool isPerforming = false;
        for (int i = 0; i < l.Count; i++)
        {
            if (s == l[i])
            {
                isPerforming = true;
                break;
            }
        }
        return isPerforming;
    }

}