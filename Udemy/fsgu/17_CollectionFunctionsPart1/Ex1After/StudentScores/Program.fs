open System

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]
        printfn "Processing %s" filePath
        let rows = IO.File.ReadAllLines filePath
        let studentCount = (rows |> Array.length) - 1
        printfn "Student count: %i" studentCount
        0
    else
        printfn "Please specify a file."
        1
