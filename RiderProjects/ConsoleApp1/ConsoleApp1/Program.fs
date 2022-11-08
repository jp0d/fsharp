
// For more information see https://aka.ms/fsharp-console-apps
[<EntryPoint>]
let main argv =
    let items = argv.Length
    printfn "Passed in %d items: %A" items argv
    
    0 // return an integer exit code



