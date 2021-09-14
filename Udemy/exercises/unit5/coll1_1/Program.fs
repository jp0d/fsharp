// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.IO

let summarise filePath = 
    printfn "Processing %s" filePath
    let rows = System.IO.File.ReadAllLines filePath
    let studenCount = (rows |> Array.length) - 1 // can use rows.Length
    printfn "Student count %i" studenCount

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]
        if System.IO.File.Exists filePath then
            printfn "Processing %s" filePath
            summarise filePath
            0
        else
            printfn "File %s doesn't exist" filePath
            1
    else
        printfn "Please specifiy a file"
        2
    0 // return an integer exit code


(*
[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]
        if System.IO.File.Exists filePath then
            printfn "Processing %s" filePath
            let rows = System.IO.File.ReadAllLines filePath
            let studenCount = (rows |> Array.length) - 1 // can use rows.Length
            printfn "Student count %i" studenCount
            0
        else
            printfn "File %s doesn't exist" filePath
            1
    else
        printfn "Please specifiy a file"
        2
    0 // return an integer exit code

*)
