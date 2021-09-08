﻿open System
open System.IO

let printMeanScore (row : string) =
    let elements = row.Split('\t')
    let name = elements.[0]
    let id = elements.[1]
    let scores =
        elements
        |> Array.skip 2
        |> Array.map float
    let meanScore = scores |> Array.average
    let minScore = scores |> Array.min
    let maxScore = scores |> Array.max
    printfn "%s\t%s\t%0.1f\t%0.1f\t%0.1f" name id meanScore minScore maxScore

let summarize filePath = 
    let rows = File.ReadAllLines filePath
    let studentCount = (rows |> Array.length) - 1
    printfn "Student count: %i" studentCount
    rows
    |> Array.skip 1
    |> Array.iter printMeanScore

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]
        if File.Exists filePath then
            printfn "Processing %s" filePath
            summarize filePath
            0
        else
            printfn "File not found: %s" filePath
            2
    else
        printfn "Please specify a file."
        1
