
let mutable a = 10
a <- 20

let items = [1..5]

List.append items [6]

items

let prefix prefixStr baseStr = 
    prefixStr + ", " + baseStr


prefix "hello" "JK"

//won't compile
prefix "hello" 12

(* Pipeline operator redirects a value into another function *)
let names = ["JK"; "Shikha"; "Pritam"; "Priti"]

names
|> Seq.map(prefix "Hello")

(* Find out what the following does. I think returns 4 funtions *)
names
|> Seq.map prefix 

(* Using Currying property to create new functions *)
let prefixWithHello = prefix "Hello"

names
|> Seq.map prefixWithHello

let exclaim s = s + "!"

names
|> Seq.map prefixWithHello
|> Seq.map exclaim
|> Seq.sort

(* Takes the output of prefixWithHello and passes it to exclaim and returns another function *)
(* The direction of the >> indicates the flow direction *)
let bigHello = prefixWithHello >> exclaim

names
|> Seq.map bigHello
|> Seq.sort

// Seq are lazily evaluated
names
|> Seq.map (fun x -> printfn "Mapped over %s" x; bigHello x)
|> Seq.sort

let hellos = 
    names
    |> Seq.map (fun x -> printfn "Mapped over %s" x; bigHello x)
    |> Seq.sort

hellos

let hellos = 
    names
    |> Seq.map (fun x -> printfn "Mapped over %s" x; bigHello x)
    |> Seq.sort
    |> Seq.iter (printfn "%s")



