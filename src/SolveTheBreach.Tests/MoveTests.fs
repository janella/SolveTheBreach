module MoveTests

open System
open Xunit
open SolveTheBreach.Libs

let safeSpaces = 3
let unsafeSpaceMove = 5
let originalPosition = Position.D5
let doMove dir spaces =
    Move.Move originalPosition dir spaces

let assertMove expected dir =
    let actual = doMove dir safeSpaces
    Assert.Equal(expected, actual)

let assertFail dir =
    let toFail = fun () -> doMove dir unsafeSpaceMove |> ignore
    Assert.Throws<ArgumentOutOfRangeException>(toFail)

[<Fact>]
let ``Move.Move moves a number of spaces N`` () =
    assertMove Position.D8 Direction.DirN

[<Fact>]
let ``Move.Move moves a number of spaces W`` () =
    assertMove Position.A5 Direction.DirW

[<Fact>]
let ``Move.Move moves a number of spaces E`` () =
    assertMove Position.G5 Direction.DirE

[<Fact>]
let ``Move.Move moves a number of spaces S`` () =
    assertMove Position.D2 Direction.DirS

[<Fact>]
let ``Move.Move fails moving off N boundary`` () =
    assertFail Direction.DirS |> ignore

[<Fact>]
let ``Move.Move fails moving off W boundary`` () =
    assertFail Direction.DirS |> ignore

[<Fact>]
let ``Move.Move fails moving off E boundary`` () =
    assertFail Direction.DirS |> ignore

[<Fact>]
let ``Move.Move fails moving off S boundary`` () =
    assertFail Direction.DirS |> ignore
