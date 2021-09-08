open System

let quote symbol s =
    sprintf "%c%s%c" symbol s symbol
 
let singleQuote = // TODO
let doubleQuote = // TODO
 
[<EntryPoint>]
let main argv =
    printfn "%s" (singleQuote "It was the best of times, it was the worst of times.")
    printfn "%s" (doubleQuote "It was the best of times, it was the worst of times.")
    0 
