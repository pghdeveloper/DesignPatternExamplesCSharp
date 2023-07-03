using System.Text;

namespace WebApiDifferentPatterns.Logger;

public sealed class Log : ILog
{
    private Log()
    {
    }
    //Creating Log Instance using Eager Loading
    private static readonly Log LogInstance = new Log();
    //Returning the Singleton LogInstance
    //This Method is Thread Safe as it uses Eager Loading
    public static Log GetInstance()
    {
        return LogInstance;
    }
    //This Method Log the Exception Details in a Log File
    public void LogException(string message)
    {
        //Create the Dynamic File Name
        string fileName = $"Exception_{DateTime.Now:yyyy-MM-dd}.log";
        //Create the Path where you want to Create the Log file
        string logFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\{fileName}";
        //Build the String Object using StringBuilder for a Better Performance
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("----------------------------------------");
        sb.AppendLine(DateTime.Now.ToString());
        sb.AppendLine(message);
        //Write the StringBuilder Message into the Log File Path using StreamWriter Object
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.Write(sb.ToString());
            writer.Flush();
        }
    }
}