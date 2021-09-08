open System

[<EntryPoint>]
let main argv =

    let initiallyZeros = Array.zeroCreate<int> 10
 
    initiallyZeros.[0] <- 42
    
    printfn "%A" initiallyZeros
    0 

