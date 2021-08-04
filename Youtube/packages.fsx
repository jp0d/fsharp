(* https://www.youtube.com/watch?v=tbddnayZpU4&list=PLdo4fOcmZ0oUFghYOp89baYFBTGxUkC7Z&index=4 *)

#r "nuget:FSharp.Data,4.1.1"

open FSharp.Data

let html = Http.RequestString("https://docs.microsoft.com/dotnet/fsharp/")

printfn $"{html}"

