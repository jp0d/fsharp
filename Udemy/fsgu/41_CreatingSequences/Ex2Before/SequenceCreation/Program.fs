open System

module Dates =
 
    let from (startDate : DateTime) =
        Seq.initInfinite (fun i -> startDate.AddDays(float i))

module MathSequence =
 
    let pell =
        (0, 0, 0)
        |> Seq.unfold (fun (n, pn2, pn1) ->
            let pn =
                match n with
                | 0 | 1 
                    -> n
                | _ 
                    -> 2*pn1 + pn2
            let n' = n + 1
            Some(pn, (n', pn1, pn)))        
 
[<EntryPoint>]
let main argv =
 
    // Dates.from DateTime.Now
    // |> Seq.filter (fun d -> d.Month = 1 && d.Day = 1)
    // |> Seq.truncate 10
    // |> Seq.iter (fun d -> printfn "%i %s" d.Year (d.DayOfWeek.ToString()))

    MathSequence.pell
    |> Seq.truncate 10
    |> Seq.iter (fun x -> printf "%i, " x)

    printfn "..."
 
    0 
