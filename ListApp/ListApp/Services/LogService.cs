using System;
using System.Diagnostics;

namespace Kapamilya.Services
{
    public class LogService
    {
        public static void SetDebug(string message)
        {
            string datetime = DateTime.Now.ToLongTimeString();
            Debug.WriteLine($"{datetime} : {message}");
        }
    }
}