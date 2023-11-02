using System;
using System.IO.Pipes;

// nt auth system cmd: setx PATH "%PATH%;C:\Users\username\elevsw\elevhelper" /m
// replace that with the path of where the elev.exe is.

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: elev.exe <programPath>");
            return;
        }

        string programPath = args[0];

        using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "ProcElevPipe", PipeDirection.InOut))
        {
            try
            {
                pipeClient.Connect();
                using (StreamWriter writer = new StreamWriter(pipeClient))
                using (StreamReader reader = new StreamReader(pipeClient))
                {
                    writer.WriteLine(programPath);
                    writer.Flush();

                    string response = reader.ReadLine();
                    Console.WriteLine("Response: " + response);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}