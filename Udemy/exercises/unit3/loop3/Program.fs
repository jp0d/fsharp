// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let sayHello person =
    printfn "Hello %s from my F# program!" person

[<EntryPoint>]
let main argv =
    Array.iter sayHello argv
    printfn "Nice to meet you!"
    0 // return an integer exit code
