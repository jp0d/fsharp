open System
open Classes
 
[<EntryPoint>]
let main argv =
    let namePrompt = ConsolePrompt("Please enter your name", 3)
    let name = namePrompt.GetValue()
    printfn "Hello %s" name
 
    let colorPrompt = ConsolePrompt("What is your favorite color (press Enter if you don't have one)", 1)
    let favouriteColor = colorPrompt.GetValue()
 
    let person = Person(name, favouriteColor)
    printfn "%s" (person.Description())
    
    0