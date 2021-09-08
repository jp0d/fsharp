// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp


open System

[<EntryPoint>]
let main argv =
    let person =
        if argv.Length > 0 then
            argv.[0]
        else
            "Anonymous Person"
    printfn "Hello %s from my F# program!" person
    0
