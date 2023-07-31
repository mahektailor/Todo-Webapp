using System;

namespace TodoAppWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = Startup.InitializeApp(args);

            // Run the web application
            app.Run();
        }
    }
}
