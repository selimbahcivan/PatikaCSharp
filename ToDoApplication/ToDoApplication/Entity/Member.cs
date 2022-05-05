using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication.Models
{
    internal class Member
    {
        private static readonly Dictionary<int, string> members = new Dictionary<int, string>()
        {
            {1,"Yavuz" },
            {2,"Ömer" },
            {3,"Hüseyin" },
            {4,"Zeynep" },
            {5,"Kübra" }
        };

        public static Dictionary<int, string> Members { get => members; }
    }
}
