module Tests

open Program
open System
open Xunit
open System.IO
open FsUnit.Xunit

[<Fact>]
let ``main prints "Hello World from F#!"`` () =
    use writer = new StringWriter()
    Console.SetOut writer

    main [||] |> ignore

    let output = writer.GetStringBuilder().ToString().Trim()

    output |> should equal "Hello World from F#!"

