$code = @"
using System;
namespace HelloWorld
{
        public class Program
        {
                public static void Main(){
                        Console.WriteLine("Hello AWS Cloudshell!");
                }
        }
}
"@

Add-Type -TypeDefinition $code -Language CSharp
iex "[HelloWorld.Program]::Main()"