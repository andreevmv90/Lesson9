using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringProject
{
    public class StringSearcher
    {
        public delegate void MessageHandler(string message);
        public event MessageHandler Notify;

        public void Search(List<string> list, string pattern)
        {
            bool flag = default;

            for (var i = 0; i < list.Count; i++)
            {
                if (Regex.Matches(list[i], pattern).Count > 0)
                {
                    Notify?.Invoke(list[i]);
                    flag = true;
                    break;
                }    
            }
            if (!flag) Notify?.Invoke("No matches");

        }
    }
}
