using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySharedFolder.Model
{
    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperation()
        {
            Console.WriteLine("Access Granted to preform read Write Operation");

        }
    }
}
