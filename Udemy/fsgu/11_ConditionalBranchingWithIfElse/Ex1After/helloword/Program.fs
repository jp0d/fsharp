open System

// We didn't make any code changes in this exercise.

[<EntryPoint>]
let main argv =
    // The bug is that this line will fail if no command line arguments are entered.
    let person = argv.[0]
    printfn "Hello %s from my F# program!" person
    0