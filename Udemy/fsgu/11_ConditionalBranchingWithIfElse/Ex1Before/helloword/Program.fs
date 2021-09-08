open System

[<EntryPoint>]
let main argv =
    let person = argv.[0]
    printfn "Hello %s from my F# program!" person
    0