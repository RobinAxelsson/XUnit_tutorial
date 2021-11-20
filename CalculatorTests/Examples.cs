using System;

namespace CalculatorTests
{
    public static class Examples
    {
        public static string ExampleLoadTextFile(string file)
        {
            if (file.Length < 10) throw new ArgumentException("filename is to short", nameof(file));
            return "the file was correctly loaded";
        }
    }
}
