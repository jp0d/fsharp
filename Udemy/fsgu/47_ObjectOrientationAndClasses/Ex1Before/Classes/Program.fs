
open System
open Classes

[<EntryPoint>]
let main argv =
    let namePrompt = ConsolePrompt("Please enter your name", 3)
    namePrompt.BeepOnError <- false
    namePrompt.ColorScheme <- ConsoleColor.Cyan, ConsoleColor.DarkGray
    let name = namePrompt.GetValue()
    printfn "Hello %s" name
    0