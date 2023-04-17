using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Logging
{
    public class Logger
    {
        public static void LogException(Exception ex, string message = "")
        {
            if (string.IsNullOrEmpty(message))
                message = "An error occured:";
            Console.Error.WriteLine($"{message} {ex.Message}");
            Console.WriteLine(new System.Diagnostics.StackTrace().ToString());
            MessageBox.Show($"{message} {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
