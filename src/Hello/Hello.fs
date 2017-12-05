module Hello

open FSharp.Data

type A = JsonProvider<"""{ "a": 100, "b": 200 }""">

[<EntryPoint>]
let main argv =
    let rs = A.Parse("""{ "a": 300, "b": 600 }""") 
    rs.A |> printfn "%A"
    rs.B |> printfn "%A"
    0 // return an integer exit code
