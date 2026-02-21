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

        // device error boool
        if (deviceError.Trim().ToLower == "yes")
        {
            errorStatus = true;

        }
        else if(deviceError.Trim().ToLower == "no")
        {
            errorStatus = false;
        }
        else
        {
            errorStatus = false;
        }

        // wifi bool
        if (deviceWifi.Trim().ToLower == "yes")
        {
            wifiStatus = true;

        }
        else if(deviceWifi.Trim().ToLower == "no")
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
        }

        if(powerStatus == false || errorStatus == true )
        {
        Console.WriteLine("Check your power cable.");
        }

        if(powerStatus == false || errorStatus == true || wifiStatus == false)
        {
        Console.WriteLine("Contact support.");

        ShowSupportMessage();
        }


        
   

    void ShowSupportMessage(string issue, bool urgent = false, string technician = "General Help")
    {
// Using a standard if-else statement
if (age >= 18) {
    message = "You are an adult";
} else {
    message = "You are a minor";
}

// Using the ternary operator to achieve the same result
string messageTernary = (age >= 18) ? "You are an adult" : "You are a minor";  

Console.WriteLine(messageTernary);
// Output: You are an adult

    }

}