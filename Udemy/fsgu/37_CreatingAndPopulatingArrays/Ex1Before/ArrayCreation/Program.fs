open System

[<EntryPoint>]
let main argv =

    let isEven x =
        x % 2 = 0

    let todayIsThursday() =
        DateTime.Now.DayOfWeek = DayOfWeek.Thursday
 
    let numbers = 
        [|
            if todayIsThursday() then 42
            for i in 1..9 do
                let x = i * i
                if x |> isEven then
                    x
            999
         |]

    printfn "%A" numbers
 
    0 

