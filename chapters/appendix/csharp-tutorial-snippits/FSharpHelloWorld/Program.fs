open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F# on AWS" // Call the function
    printfn "Hello world %s" message
    0 // return an integer exit code