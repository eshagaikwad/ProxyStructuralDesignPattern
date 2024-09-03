using ProxySharedFolder.Model;

public class Program
{
    public static void Main(string[] args)
    { 
        Employee employee1=new Employee("esha","Esha1123","CEO");
        Employee employee2 = new Employee("preet", "Preet2323", "Developer");

        Console.WriteLine("CEO Asking for Permission: ");
        SharedFolderProxy sharedFolderProxy1 = new SharedFolderProxy(employee1);
        sharedFolderProxy1.PerformRWOperation();

        Console.WriteLine();

        Console.WriteLine("Developer Asking for Permission: ");
        SharedFolderProxy sharedFolderProxy2 = new SharedFolderProxy(employee2);
        sharedFolderProxy2.PerformRWOperation();
    }

}