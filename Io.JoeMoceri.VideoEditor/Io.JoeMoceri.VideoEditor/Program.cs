using System;

namespace Io.JoeMoceri.VideoEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var app = new App();

                app.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
