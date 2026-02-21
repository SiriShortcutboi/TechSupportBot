using System;
					
public class Program
{
    static string devicePower = "default";
    static string deviceError = "default";
    static string deviceWifi = "default";

    static string issue = "default";

    static bool powerStatus = false;
    static bool errorStatus = false;
    static bool wifiStatus = false;

    

    static bool urgentStatus = false;
	public static void Main()
	{
		Console.WriteLine("Welcome to Tech Support, I'm going to ask you a few questions.\n" + 
        "Press Enter to start");
        Console.ReadKey();

        Console.WriteLine("Is the device turning on?");
        devicePower = Console.ReadLine();

        Console.WriteLine("Is there an error message?");
        deviceError =Console.ReadLine();

        Console.WriteLine("Is it connected to Wi-Fi?");
        deviceWifi = Console.ReadLine();

        //power status bool
        if (devicePower.Trim().ToLower() == "yes")
        {
            powerStatus = true;

        }
        else if (devicePower.Trim().ToLower() == "no")
        {
            powerStatus = false;
        }
        else
        {
            powerStatus = false;
        }

        // device error boool
        if (deviceError.Trim().ToLower() == "yes")
        {
            errorStatus = true;

        }
        else if (deviceError.Trim().ToLower() == "no")
        {
            errorStatus = false;
        }
        else
        {
            errorStatus = false;
        }

        // wifi bool
        if (deviceWifi.Trim().ToLower() == "yes")
        {
            wifiStatus = true;

        }
        else if (deviceWifi.Trim().ToLower() == "no")
        {
            wifiStatus = false;
        }
        else
        {
            wifiStatus = false;
        }


        //writelines to the user based on errors
        if(powerStatus == true && errorStatus == true && wifiStatus == false){
        Console.WriteLine("Try restarting your router.");
        issue = "wifi problems";
        }

        if(powerStatus == false || errorStatus == true )
        {
        Console.WriteLine("Check your power cable.");
        urgentStatus = false;
        issue = "Sufficient power is not available";
        }

        if(powerStatus == false || errorStatus == true || wifiStatus == false)
        {
        Console.WriteLine("Contact support. You may need a house call technician");
        urgentStatus = true; 
        issue = "You may have a few different issues. dont let the kids near this device";
        ShowSupportMessage(issue, urgentStatus);
        }


        
   }

        static void ShowSupportMessage(string issue, bool urgentStatus, string technician = "General Help")
        {
    
    string gottagoFast = urgentStatus ? "Urgent: YES - A technician will call you." : "General Help";

    Console.WriteLine(gottagoFast);
        }
    

}