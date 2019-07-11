using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            RetrieveRecord retrieveRecord = new RetrieveRecord();
            retrieveRecord.RetrieveRecordSelect();
        }
    }
}
