using Green.View;
using System.Resources;

namespace Green.Utility;

internal class MessageManager
{
    internal ResourceManager ResourceManager { get; }

    public MessageManager()
    {
        ResourceManager = new ResourceManager("Green.Resource.GeneralMessageResource", typeof(Screen).Assembly);
    }

    internal string GetMessage(string resourceName)
    {
        return ResourceManager.GetString(resourceName)!;
    }
    internal void ShowSucessMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nMensagem: " + GetMessage(message));
        Console.ResetColor();
        Thread.Sleep(3000);
    }

    internal void ShowSucessMessage(string message, string word)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nMensagem: " + String.Format(GetMessage(message), word));
        Console.ResetColor();
        Thread.Sleep(3000);
    }

    internal void ShowAlertMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nMensagem: " + GetMessage(message));
        Console.ResetColor();
        Thread.Sleep(2000);
    }

    internal void ShowErroMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nMensagem: " + GetMessage(message));
        Console.ResetColor();
        Thread.Sleep(1000);
    }
}
