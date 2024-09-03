using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySharedFolder.Model
{
    public class SharedFolderProxy : ISharedFolder
    {
        Employee Employee;
        ISharedFolder Folder;
        public SharedFolderProxy(Employee Employee)
        {
            this.Employee = Employee;
        }
        public void PerformRWOperation()
        {
            if (Employee.Role.ToUpper() == "CEO" || Employee.Role.ToUpper() == "MANAGER")
            {
                Folder = new SharedFolder();   //initializing the object of sharedFoler to call its methods
                Folder.PerformRWOperation();
            }
            else
            {
                Console.WriteLine("PERMISSION NOT GRANTED");
            }
        }

    }
}
