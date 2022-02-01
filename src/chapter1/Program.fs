// 1.1
let g n = n + 4

// 1.2
let h (x, y) = System.Math.Sqrt(x * x + y * y)

// 1.3
let g_exp = fun n -> n + 4
let h_exp = fun (x,y) -> System.Math.Sqrt(x * x + y * y)

// 1.4
let rec f n =
    match n with
    | 0 -> 0
    | x when x > 0 -> x + f (n - 1)
    | _ -> failwith "argument should be positive number"

// 1.5
let rec fib n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | x -> fib(x-1) + fib(x-2)
    
[<EntryPoint>]
let main argv =
    let result = fib 7
    printfn "%A" result 
    0
