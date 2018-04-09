using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctPalindromeSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
           while(true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------");
                string sentence = string.Empty;
                sentence= Console.ReadLine();
                foreach (string word in sentence.Split(' '))
                {
                    IDictionary<string, int> dict = new Dictionary<string, int>();
                    for (int i = 0; i < word.Length ; i++)
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        string forming = string.Empty;
                        for (int j = i; j < word.Length; j++)
                        {
                            stringBuilder.Append(word[j]);
                            forming = stringBuilder.ToString();
                            if(IsPalindrome(forming))
                            {
                                if(!dict.ContainsKey(forming))
                                {
                                    dict.Add(forming, j);
                                }
                            }
                        }
                    }


                    foreach (KeyValuePair<string, int> entry in dict)
                    {
                        Console.WriteLine(entry.Key);
                    }
                }
            }
        }
        public static bool IsPalindrome(string _inputstr)
        {
            string _reversestr = string.Empty;
            if (_inputstr != null)
            {
                for (int i = _inputstr.Length - 1; i >= 0; i--)
                {
                    _reversestr += _inputstr[i].ToString();
                }
                if (_reversestr == _inputstr)
                {

                    return true;
                }
                else
                {
                }
            }
            return false;
        }
    }
}
