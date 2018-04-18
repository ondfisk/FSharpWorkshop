// setup the active patterns
let (|MultOf3|_|) i = if i % 3 = 0 then Some MultOf3 else None
let (|MultOf5|_|) i = if i % 5 = 0 then Some MultOf5 else None

// the main function
let fizzBuzz i = 
  match i with
  | MultOf3 & MultOf5 -> printf "FizzBuzz, " 
  | MultOf3 -> printf "Fizz, " 
  | MultOf5 -> printf "Buzz, " 
  | _ -> printf "%i, " i
  
// test
[1..20] |> List.iter fizzBuzz 


let arabicToRoman n =
    let replace (f : string) (r : string) (s : string) = s.Replace(f, r)
    String.replicate n "I" |>
    replace "IIIII" "V" |>
    replace "VV" "X" |>
    replace "XXXXX" "L" |>
    replace "LL" "C" |>
    replace "CCCCC" "D" |>
    replace "DD" "M" |> 
    replace "IIII" "IV" |>
    replace "VIV" "IX" |>
    replace "XXXX" "XL" |>
    replace "LXL" "XC" |>
    replace "CCCC" "CD" |>
    replace "DCD" "CM"


