using System;
					
public class Program
{
    static string devicePower = "default";
    static string deviceError = "default";
    static string deviceWifi = "default";

    static bool powerStatus = false;
    static bool errorStatus = false;
    static bool wifiStatus = false;
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
        if (devicePower.Trim().ToLower == "yes")
        {
            powerStatus = true;

        }
        else if(devicePower.Trim().ToLower == "no")
        {
            powerStatus = false;
        }
        else
        {
            powerStatus = false;
        }



	}



   

    void ShowSupportMessage(string issue, bool urgent = false, string technician = "General Help")
    {
        

    }

}