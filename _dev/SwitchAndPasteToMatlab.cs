// //declarations
using System; // For IntPtr
using System.Runtime.InteropServices; // DllImport
using System.Diagnostics; // Process
using System.Windows.Forms; // SendKeys
// using System.Windows.Automation; //  UIAutomationClient.dll 
// using System.Threading; // For Thread.Sleep

class Program
{
    //dll import (can't be in method, but needs to be in class
    [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd);
    static void Main()
    {
        // --------------------------------------------------------------------------------
        // ---  
        // --------------------------------------------------------------------------------
        String procName = "MATLAB";
        //function which calls switchWindow() is here but not important
        // // 
        Process[] procs = Process.GetProcessesByName(procName);
        int nProcs = procs.Length;
        if (nProcs < 1) {
            Console.WriteLine("No process found for name: {0}", procName);
        }else{
            // We'll use the first window we found
            Process proc=procs[0];
            if (nProcs >1) {
                Console.WriteLine("{0} processes found with name: {0}",nProcs,procName);
                Console.WriteLine("Using first process:");
                Console.WriteLine("Process Name: {0} ID: {1} Title: {2}", proc.ProcessName, proc.Id, proc.MainWindowTitle);
            }
            // --- Switching to window using user32.dll function
            SwitchToThisWindow(proc.MainWindowHandle);
            SendKeys.SendWait("{Escape}");
            SendKeys.SendWait("^v");

            // --- Alternative method using AutomationElement
//             AutomationElement element = AutomationElement.FromHandle(proc.MainWindowHandle);
//             if (element != null) { element.SetFocus(); }
        } // Proc Window found
    }
}
