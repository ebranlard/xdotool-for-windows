// Note: to compile with Mono you need:  mcs /r:System.Windows.Forms.dll 
// 
// 
// using System; // For IntPtr
using System.Windows.Forms; // SendKeys

class Program
{
    static void Main()
    {
            SendKeys.SendWait("^v");
    }
}
