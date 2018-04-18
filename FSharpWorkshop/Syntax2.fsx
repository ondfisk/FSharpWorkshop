// Source: https://fsharpforfunandprofit.com/posts/fsharp-in-60-seconds

// Point free (tacit style)
let doubleAndIncr = fun x -> x * 2 + 1

let doubleAndIncr2 x = ((*) 2 >> (+) 1) x

let doubleAndIncr3 = (*) 2 >> (+) 1

// Currying
let evens = List.filter (fun x -> x%2 = 0)

List.filter (fun x -> x = 2) [0..2]

// String.Format
let number = 42
let answer = "answer"
printfn "%i: The %s to life the universe and everything" number answer

sprintf "%i: The %s to life the universe and everything" number answer

let simplePatternMatch x =
   match x with
    | "a" -> printfn "x is a"
    | "b" -> printfn "x is b"
    | _ -> printfn "x is something else"

let validValue = Some 99
let invalidValue = None

let optionPatternMatch input =
   match input with
    | Some i -> printfn "input is an int=%i" i
    | None -> printfn "input is missing"

optionPatternMatch validValue
optionPatternMatch invalidValue

let mutable z = 23
z <- 44

// Recursion
let rec fib a b =
    seq {
        yield b
        yield! fib b (a + b)
    }
 
let rec nthPowerOf2 n =
    if n = 0 then 1 else 2 * nthPowerOf2 (n - 1)

