open System
open System.IO
open StudentScores

type Student =
    {
        Surname : string
        Givenname : string
        Id : string
        MeanScore : float
        MinScore : float
        MaxScore : float
    }

module Student =

    let namePart i (s : string) =
        let elements = s.Split(',')
        elements.[i].Trim()

    let fromString (s : string) =
        let elements = s.Split('\t')
        let name = elements.[0]
        // TODO: Inefficient, splits a string twice.
        let given = namePart 1 name
        let sur = namePart 0 name
        let id = elements.[1]    
        let scores =
            elements
            |> Array.skip 2
            |> Array.map (Float.fromStringOr 50.0)
        let meanScore = scores |> Array.average
        let minScore = scores |> Array.min
        let maxScore = scores |> Array.max
        {
            Surname = sur
            Givenname = given
            Id = id
            MeanScore = meanScore
            MinScore = minScore
            MaxScore = maxScore
        }        

    let printSummary (student : Student) =
        printfn "%s, %s\t%s\t%0.1f\t%0.1f\t%0.1f" student.Surname student.Givenname student.Id student.MeanScore student.MinScore student.MaxScore

let summarize filePath = 
    let rows = File.ReadAllLines filePath
    let studentCount = (rows |> Array.length) - 1
    printfn "Student count: %i" studentCount
    rows
    |> Array.skip 1
    |> Array.map Student.fromString
    |> Array.sortByDescending (fun student -> student.MeanScore)
    |> Array.iter Student.printSummary

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]
        if File.Exists filePath then
            printfn "Processing %s" filePath
            summarize filePath
            0
        else
            printfn "File not found: %s" filePath
            2
    else
        printfn "Please specify a file."
        1
