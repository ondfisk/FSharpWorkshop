// Source: https://fsharpforfunandprofit.com/posts/fsharp-in-60-seconds

// single line comments

(* multi line 
   comments *)

// import/using
open System

let myInt = 5
let myInt64 = 453209708881894128L
let myBigInt = 123490873015123049581230293184123041209887098791230948113251235213I
let myFloat = 3.14
let myFloat32 = 3.14f
let myDecimal = 32251514.134513461346243m

let myString = "hello"
let myVerbatimString = @"\v\e\r\b\a\t\i\m"
let myTripleQuotedString = """ Anything but 
                               "three" 'consecutive' 
                               \quotes """

let xml = """ <input type="text" /> """


let myObj = obj()
let myUnit = ()

let myBool = true
let notMyBool = not myBool
let twoTuple = 1,2
let threeTuple = "a",2,true

let twoToFive = [2;3;4;5]       

let oneToFive = 1 :: twoToFive   

let zeroToFive = [0;1] @ twoToFive   

let zeroToSix = [0..6]

let square x = x * x  

let add x y = x + y 

add 2 3

let add2 = add 2

let zeroTo n = [0..n]

let evens list =
   let isEven x = x%2 = 0     
   List.filter isEven list

evens oneToFive              

let sumOfSquaresTo100 =
   List.sum ( List.map square [1..100] )

let sumOfSquaresTo100piped =
   [1..100] |> 
   List.map square |> 
   List.sum
   
let sumOfSquaresTo100withFun =
   [1..100] |> List.map (fun x->x*x) |> List.sum

let f = fun x -> x*2

// "ToString()"
string 42

// "int.Parse"
int "42"

// Type annotation
let split (s : string) (c : char) = 
    s.Split c

