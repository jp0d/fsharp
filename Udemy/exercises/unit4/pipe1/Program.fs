// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let sayHello person =
    printfn "Hello %s from my F# program!" person

let isValid person =
    not(String.IsNullOrWhiteSpace person)  // same as `String.IsNullOrWhiteSpace person |> not`

let isAllowed person =
    person <> "Eve"

[<EntryPoint>]
let main argv =
    argv 
    |> Array.filter isValid
    |> Array.filter isAllowed
    |> Array.iter sayHello
    printfn "Nice to meet you!"
    0 // return an integer exit code