open System

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]
        printfn "Processing %s" filePath
        0
    else
        printfn "Please specify a file."
        1
