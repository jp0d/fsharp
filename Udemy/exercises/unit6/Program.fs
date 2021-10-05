// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.IO

type Student =
{
    Name : string
    ID : string
    MeanScore : float
    MaxScore : float
    MinScore : float
}

module Student = 

    let fromString (s: string) = 
        let elements = s.Split('\t')
        let name = elements.[0]
        let id = elements.[1]
        let score =
            elements
            |> Array.skip 2
            |> Array.map float
            
        let meanScore = score |> Array.average // or use Array.averageBy float and get rid off the previous line
        let minScore = score |> Array.min
        let maxScore = score |> Array.max
        {
            Name = name
            ID = id
            MeanScore = meanScore
            MaxScore = maxScore
            MinScore = minScore
        }
    
    let printSummary (student : Student) =
        printfn "%s\t%s\t%0.2f\t%0.2f\t%0.2f" student.Name student.ID student.MeanScore student.MinScore student.MaxScore

let summarise filePath = 
    printfn "Processing %s" filePath
    let rows = System.IO.File.ReadAllLines filePath
    let studenCount = (rows |> Array.length) - 1 // can use rows.Length
    printfn "Student count %i" studenCount
    rows
    |> Array.skip 1
    |> Array.Map Student.fromString
    |> Array.iter Student.printSummary



[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]
        if System.IO.File.Exists filePath then
            printfn "Processing %s" filePath
            summarise filePath
            0
        else
            printfn "File %s doesn't exist" filePath
            1
    else
        printfn "Please specifiy a file"
        2
    0  // return an integer exit code