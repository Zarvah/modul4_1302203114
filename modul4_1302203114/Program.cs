using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302203114
{
    public class Program
    {
        static void Main()
        {
            SimpleDataBase<double> DB = new SimpleDataBase<double>();
            DB.addNewData(12);
            DB.addNewData(44);
            DB.addNewData(43);
            DB.PrintAlldata();
           
        }
    }
    
}
