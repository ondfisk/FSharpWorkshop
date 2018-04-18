// Lists and sequences
[ "Peter" ; "Paul" ; "Mary" ]
[| 1 ; 2 ; 3 |]

[1..5]        

[1 .. 3 .. 11]  

[for i = 10 downto 1 do yield i]

[|'a'..'z'|] 

seq { 1..42 }  

let evensSeq n =
    seq { for x in 1..n do if x % 2 = 0 then yield x }

let squarePoints n =
    seq { for x in 1 .. n do
          for y in 1 .. n  -> x,y }

printf "%A" (squarePoints 3)

open System

let tryParse s = 
    match Int32.TryParse s with
     | true, i -> Some i
     | false, _ -> None

["foo" ; "42" ; "bar" ; "0"] 
    |> List.map tryParse
    |> List.choose id
    
let vec1 = [1;2;3]
let vec2 = [4;5;6]
let products = [for x in vec1 do for y in vec2 -> x * y]

let stutter n count =
    [
        for x in [1..count] do
            if x % n = 0 then
                yield! Seq.init 5 (fun _ -> x)
            else
                yield x
    ]

printfn "%A" <| stutter 3 10

List.init 5 (fun index -> index * 3)
List.filter (fun x -> x > 3) [0..5]
List.allPairs [0..5] [0..1]
List.concat [ [0..1] ; [2..3] ; [4..5] ]
List.empty
List.isEmpty []
List.collect (fun x -> [for i in 10..10..30 -> x * i]) [0..5]
List.find (fun x -> x = 7) [0..5]
List.tryFind (fun x -> x = 3) [0..5]
List.head [0..5]
List.tail [0..5]

// List.fold
let data = [("Cats",4);
            ("Dogs",5);
            ("Mice",3);
            ("Elephants",2)]
let count = List.fold (fun acc (_,x) -> acc+x) 0 data

data |> List.sumBy (fun (_,c) -> c)

List.pick (fun x -> if x > 2 then Some x else None) [0..5]
List.filter (fun x -> x > 2) [0..5] |> List.head

List.sort [4;2;1;3]

List.reduce (fun acc elem -> acc + elem) [0..5]
List.reduce (+) [0..5]

List.windowed 3 [2..10]
List.zip3 ['a'..'f'] [1..6] [for i = 6 downto 1 do yield i]

let fibonacci = Seq.unfold (fun (a, b) -> Some(a, (b, a + b))) (0,1)

fibonacci |> Seq.take 20 |> Seq.toList

// yield!