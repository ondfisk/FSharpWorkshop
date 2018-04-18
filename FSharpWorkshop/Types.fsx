open System.Drawing

// Source: https://fsharpforfunandprofit.com/posts/fsharp-in-60-seconds

let twoTuple = 1,2

type Person = { First : string ; Last : string }

let person1 = { First = "john" ; Last = "Doe" }

let fixedName = { person1 with First = "John" }

type Tempt = 
    | DegreesC of float
    | DegreesF of float
    | DegreesK of float
let temp = DegreesF 98.6

type Employee = 
  | Worker of Person
  | Manager of Person * Employee list
let jdoe = { First = "John" ; Last = "Doe" }
let worker = Worker jdoe
let manager = { First = "Emperor" ; Last = "Palpatine" }

type ContainerClass (length:float, width:float, height:float, ?position:Point) =
    let mutable weight = 0.0

    member this.Length = length
    member this.Width = width
    member this.Height = height
    member this.Position = position

    member this.AddCargo c =
        weight <- weight + c
    
    member this.Move p =
        ContainerClass(length, width, height, p)
    
[<Measure>] 
type meter

[<Measure>] 
type ton

[<Measure>] type foot   // Imperial foot = 30.4 cm
[<Measure>] type lb     // Imperial pound = 454 grams

type ContainerRecord<[<Measure>] 'l, [<Measure>] 'm> = 
     {
         Length:float<'l> ; 
         Width:float<'l> ; 
         Height:float<'l> ; 
         Weight:float<'m>
     }

let default20footContainer = 
    {
        Length = 20.0<foot> ; 
        Width = 8.0<foot> ; 
        Height = 8.5<foot> ; 
        Weight = 0.0<ton>
    }

let myContainer = {default20footContainer with Weight = 10.0<ton>}

let unloadContainer con = {con with Weight = 0.0<ton>}
let loadContainer m con = {con with Weight = m} 


printfn "Printing an int %i, a float %f, a bool %b" 1 2.0 true
printfn "A string %s, and something generic %A" "hello" [1;2;3;4]

printfn "twoTuple=%A,\nPerson=%A,\nTemp=%A,\nEmployee=%A" 
         twoTuple person1 temp worker

// Exceptions (avoid if you can - use option to represent failed computations
let die42 i = function
    | 42 -> failwithf "%i you are dead!" i
    | _ -> ()


type intToIntToInt = int -> int -> int
type intToIntList = int -> int list
type intToIntOption = int -> int option
type intDies = int -> unit

