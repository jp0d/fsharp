open System

[<EntryPoint>]
let main argv =

    let total =
        [| for i in 1..1000 -> i * i |]
        |> Array.sum

    printfn "The total is: %i" total 

    0

