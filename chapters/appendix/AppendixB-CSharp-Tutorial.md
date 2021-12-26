## Getting started with .NET

Start with the interactive documentation for [Hello World in the browser]
(https://docs.microsoft.com/en-us/learn/modules/csharp-write-first/2-exercise-hello-world)

### Hello World in Github Codespaces for C#

Next up, try out Github Codespaces and the [Visual Studio Code tutorial](https://code.visualstudio.com/docs/languages/dotnet).

First, create a new console app from the CLI and name it HelloWorld
```powershell
dotnet new console -n HelloWorld
```

This step creates a console project. Next, change the code in `Program.cs` to the following example.

```csharp
using System;

namespace HelloWorld
{
 class Program
 {
 static void Main(string[] args)
 {
 Console.WriteLine("Hello World C# on AWS!");
 }
 }
}
```

Next, cd into the directory `cd HelloWorld` and run the code: `dotnet run`. The output of the command will be the following.

```
Hello World C# on AWS!
```

### Hello World in Github Codespaces for F#

Create a new F# console app.

```powershell
dotnet new console -lang "F#" -n FSharpHelloWorld
```

Change the code to the following:

```fsharp
open System

// Define a function to construct a message to print
let from whom =
 sprintf "from %s" whom

[<EntryPoint>]
let main argv =
 let message = from "F# on AWS" // Call the function
 printfn "Hello world %s" message
 0 // return an integer exit code
```


Next, cd into the directory `cd FSharpHelloWorld` and run it `dotnet run`.
The output will be the following: `Hello world from F# on AWS`.


