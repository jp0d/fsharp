// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System


[<EntryPoint>]
let main argv =
    for i in 0..argv.Length-1 do
        let person = argv.[i]
        printfn "Hellow %s from my F# program!" person
    printfn "Nice to meet you!" 
    0 // return an integer exit code
