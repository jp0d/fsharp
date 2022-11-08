
let text = "Hello, world"

text.Length

let currentTime = System.DateTime.UtcNow
    
//printfn currentTime.TimeOfDay
//printf currentTime.TimeOfDay.ToString()

//Printf.kbprintf currentTime.TimeOfDay

let greetPerson name age =
    sprintf "Hello, %s. You are %d years old" name age

let countWords (text:string) =
    text.Split().Length


let age = 35
let website = System.Uri "http://fsharp.org"
let addnum (first:int) = // , second:int
    first + 100 //+ second

let add (first, second) = first + second

let add2 first second =
    first + second



open System

let doStuffWithTwoNumbers first second =
    let added = first + second
    Console.WriteLine("{0} + {1} = {2}", first, second, added)
    let doubled = added * 2
    doubled
    
doStuffWithTwoNumbers 10 20
    

let year = DateTime.Now.Year
let age = year - 1979
let estimatedAge = sprintf "You are about %d years old!" age

let estimatedAge =
    let age =
        let year = DateTime.Now.Year
        year - 1979
    sprintf "You are about %d years old!" age


let estimatedAge birthYear =
    let age =
        let year = DateTime.Now.Year
        year - birthYear
    sprintf "You are about %d years old!" age


let estimateAges(familyName, year1, year2, year3) =
    let calculateAge yearOfBirth =
        let year = System.DateTime.Now.Year
        year - yearOfBirth
    let estimatedAge1 = calculateAge year1
    let estimatedAge2 = calculateAge year2
    let estimatedAge3 = calculateAge year3
    
    let averageAge = (estimatedAge1 + estimatedAge2 + estimatedAge3) / 3
    
    sprintf "Average age for family %s is %d" familyName averageAge











