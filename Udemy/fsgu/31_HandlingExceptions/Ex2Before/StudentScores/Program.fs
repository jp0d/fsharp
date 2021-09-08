open System
open System.IO
open StudentScores

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]
        if File.Exists filePath then
            printfn "Processing %s" filePath
            try
                Summary.summarize filePath
                0
            with
            | :? FormatException as e ->
                printfn "Error: %s" e.Message
                printfn "The file was not in the expected format."
                1
            | :? IOException as e ->
                printfn "Error: %s" e.Message
                printfn "If the file is open in another program, please close it."
                2                
        else
            printfn "File not found: %s" filePath
            3
    else
        printfn "Please specify a file."
        4
