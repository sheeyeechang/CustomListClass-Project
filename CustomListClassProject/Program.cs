using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customIntList = new CustomList<int>();
            customIntList.Add(1);
            customIntList.Add(7);
            customIntList.Add(3);
            customIntList.Add(4);
            customIntList.Add(5);
            customIntList.Add(6);

        }
    }
}
