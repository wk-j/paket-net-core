module Hello

open FSharp.Data

type A = JsonProvider<"{}">

[<EntryPoint>]
let main argv =
    A.Parse("{}") |> printfn "%A"
    0 // return an integer exit code
