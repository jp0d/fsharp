open System

[<EntryPoint>]
let main argv =

    let numbers = [|1; 2; 4; 8; 16|]
 
    let moreNumbers = 
        [|
            for i in 0..4 -> pown 2 i
        |]
 
    let yetMoreNumbers = Array.init 5 (fun i -> pown 2 i)        
 
    let total =
        [| for i in 1..1000 -> i * i |]
        |> Array.sum
 
    let thirdNumber = yetMoreNumbers.[2]
    yetMoreNumbers.[1] <- 99

    0