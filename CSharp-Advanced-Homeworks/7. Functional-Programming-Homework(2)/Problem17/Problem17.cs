using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class Problem17
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var companies = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ', '|', '-' }, StringSplitOptions.RemoveEmptyEntries);
                int numbers = int.Parse(input[1]); ;
                if (!companies.ContainsKey(input[0]))
                {
                    var temp = new Dictionary<string, int>();
                    temp.Add(input[2], numbers);
                    companies.Add(input[0], temp);
                }
                else
                {
                    if (!companies[input[0]].ContainsKey(input[2]))
                    {
                        companies[input[0]].Add(input[2], numbers);
                    }
                    else
                    {
                        companies[input[0]][input[2]] = companies[input[0]][input[2]] + numbers;
                    }
                }
            }
            foreach (KeyValuePair<string, Dictionary<string, int>> separateCompany in companies)
            {
                Console.Write("{0}: ", separateCompany.Key);
                string result = string.Empty;
                string temp = string.Empty;
                foreach (var item in separateCompany.Value)
                {
                    temp = string.Format("{0}-{1}, ", item.Key, item.Value);
                    result = result + temp;
                }
                Console.Write(result.Substring(0, result.Length - 2));
                Console.WriteLine();
            }

        }
    }
}
