let g n = n + 4
let h (x, y) = System.Math.Sqrt(x * x + y * y)

[<EntryPoint>]
let main argv =
    printfn "%A" (g 8)
    0
