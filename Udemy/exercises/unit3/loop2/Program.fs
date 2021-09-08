// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System


[<EntryPoint>]
let main argv =
    for person in argv do
        printfn "Hellow %s from my F# program!" person
    printfn "Nice to meet you!" 
    0 // return an integer exit code
