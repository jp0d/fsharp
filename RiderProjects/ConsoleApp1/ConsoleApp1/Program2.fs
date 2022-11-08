
open System
let main argv =
    let doStuffWithTwoNumbers first second =
        let added = first + second
        Console.WriteLine("{0} + {1} = {2}", first, second, added)
        let doubled = added * 2
        doubled
    
    doStuffWithTwoNumbers 10 20    
    
    0 // return an integer exit code