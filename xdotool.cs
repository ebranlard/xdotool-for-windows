// Note: to compile with Mono you need:  mcs /r:System.Windows.Forms.dll 
using System; // For IntPtr
using System.Runtime.InteropServices; // DllImport
using System.Diagnostics; // Process
using System.Windows.Forms; // SendKeys

public class xdotool
{

    // --------------------------------------------------------------------------------
    // --- Send Keys
    // --------------------------------------------------------------------------------
    public static int SendTheseKeys(string keys){
        //#SendKeys.SendWait(keys);
        SendKeys.SendWait(keys);
        Console.WriteLine("Key sent: "+ keys);
        //SendKeys.SendWait("^v");
        return 0;
    }


    // --------------------------------------------------------------------------------
    // --- Print command usage 
    // --------------------------------------------------------------------------------
    public static void print_usage(){
        Console.WriteLine("");
        Console.WriteLine("usage: xdotool [options] cmd [args]");
        Console.WriteLine("");
        Console.WriteLine("options:");
        Console.WriteLine("  -h         : show this help");
        Console.WriteLine("");
        Console.WriteLine("cmd:");
        Console.WriteLine("  key <KEYS>: send keys");
        Console.WriteLine("");
    
    }

    // --------------------------------------------------------------------------------
    // --- Main Program 
    // --------------------------------------------------------------------------------
    public static int Main(string[] args)
    {
        int status=0; // Return status for Main

        // --------------------------------------------------------------------------------
        // --- Parsing arguments 
        // --------------------------------------------------------------------------------
        int nArgs=args.Length;
        if (nArgs==0){
            Console.WriteLine("Error: insufficient command line arguments");
            print_usage();
            return 0;
        }
        int i=0;
        while (i<nArgs) {
            string s=args[i];
            switch(s){
                case "-h": // Help
                    print_usage();
                    i=i+1;
                    break;
                case "key": // Send Keys
                    if (i+1<nArgs) {
                        status=SendTheseKeys(args[i+1]);
                        i=i+2;
                    }else{
                        Console.WriteLine("Error: command key needs to be followed by a string of keys");
                        status=-1;
                    }
                    break;
                default:
                    Console.WriteLine("Skipped argument: "+ args[i]);
                    i++;
                    break;
            }
            if (status!=0) {
                // If an error occured, print usage and exit
                print_usage();
                return status;
            }
        }
        //
        return status;
    }



}
