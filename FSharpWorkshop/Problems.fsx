// Find the sum of all the multiples of 3 or 5 below 1000.

let problem1 n =
    [1..n-1] |> 
    List.filter (fun x -> x % 3 = 0 || x % 5 = 0) |>
    List.sum

// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
let problem6 n =
    let square x = x * x
    let squaredSum = [1..n] |> List.sum |> square
    let sumOfSquares = [1..n] |> List.map square |> List.sum
    squaredSum - sumOfSquares

(*
sum:          1+2+3+...+n = n * (n + 1) / 2 
sumOfSquares: 1^2 + 2^2 + 3^2 + ... + n^2 = 1/6*n(n+1)(2n+1)
*)

let problem6' n =
    let squaredSum = n * (n + 1) / 2 |> (fun x -> x * x)
    let sumOfSquares = (2 * n*n*n + 3 * n*n + n) / 6
    squaredSum - sumOfSquares

problem6' 100

open System

// Find the largest palindrome made from the product of two 3-digit numbers.

let problem4 =
    let isPalindrome x =
        let s = string x
        let r = s |> Seq.rev |> String.Concat
        s = r
    seq { for x in [ 100 .. 999 ] do
          for y in [ x .. 999 ] do
            yield x * y } |>
    Seq.filter isPalindrome |> Seq.max

let problem4' =
    let isPalindrome x =
        let s = string x
        let r = s |> Seq.rev |> Seq.map string |> Seq.reduce (+)
        s = r
    List.allPairs [100..999] [100..999] |>
    List.map (fun (x, y) -> x*y) |>
    List.filter isPalindrome |> List.max


// Answer: 906609

let rec fac n = 
    match n with
    | 0 -> 1
    | x when x < 0 -> failwith "You cannot do factorial on a negative value"
    | m -> m * fac (m-1)

let fac' n = 
    if n = 0 then 1 else [1..n] |> List.reduce (*)

// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?

open System
open System.Text.RegularExpressions

let number = @"73167176531330624919225119674426574742355349194934
               96983520312774506326239578318016984801869478851843
               85861560789112949495459501737958331952853208805511
               12540698747158523863050715693290963295227443043557
               66896648950445244523161731856403098711121722383113
               62229893423380308135336276614282806444486645238749
               30358907296290491560440772390713810515859307960866
               70172427121883998797908792274921901699720888093776
               65727333001053367881220235421809751254540594752243
               52584907711670556013604839586446706324415722155397
               53697817977846174064955149290862569321978468622482
               83972241375657056057490261407972968652414535100474
               82166370484403199890008895243450658541227588666881
               16427171479924442928230863465674813919123162824586
               17866458359124566529476545682848912883142607690042
               24219022671055626321111109370544217506941658960408
               07198403850962455444362981230987879927244284909188
               84580156166097919133875499200524063689912560717606
               05886116467109405077541002256983155200055935729725
               71636269561882670428252483600823257530420752963450"

let problem8 = 
    Regex.Replace(number, @"\s+", "") 
    |> Seq.windowed(13) 
    |> Seq.map (fun s -> 
        s |> Seq.map Char.GetNumericValue 
          |> Seq.map int 
          |> Seq.reduce (*)) 
    |> Seq.max

let problem8' =
    number |> Seq.filter (Char.IsWhiteSpace >> not) 
    |> Seq.windowed(13) 
    |> Seq.map (fun s -> 
        s |> Seq.map (Char.GetNumericValue >> int)
          |> Seq.reduce (*)) 
    |> Seq.max
