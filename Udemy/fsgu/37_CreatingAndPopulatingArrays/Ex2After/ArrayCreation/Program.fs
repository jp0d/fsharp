open System

[<EntryPoint>]
let main argv =

    let total =
        Array.init 1000 (fun i ->
            let x = i + 1
            x * x)
        |> Array.sum

    printfn "The total is: %i" total 

    0

