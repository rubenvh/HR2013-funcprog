// 1.1
let g n = n + 4

// 1.2
let h (x, y) = System.Math.Sqrt(x * x + y * y)

// 1.3
let g_exp = fun n -> n + 4
let h_exp = fun (x,y) -> System.Math.Sqrt(x * x + y * y)

[<EntryPoint>]
let main argv =
    let result = h (1.0, 2.0)
    printfn "%A" result 
    0
