using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302203114
{
    public class SimpleDataBase<T>
    {
        List<T> storedData;
        List<DateTime> inputDates;
        
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void addNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAlldata()
        {
            foreach (var data in storedData)
            {
                Console.WriteLine(data);
            }
            foreach (var data in inputDates)
            {
                Console.WriteLine(data);
            }
        }
    }
}
