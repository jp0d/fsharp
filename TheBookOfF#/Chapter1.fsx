namespace TheBookOfFSharp

module Chapter1 =

    let testNumber = 10

    let evenOrOdd = if testNumber % 2 = 0 then "even" else "odd"

    printfn "%s" evenOrOdd


[<EntryPoint>]
let main argv = 
    printfn "%s" evenOrOdd

