module MoveTests

open System
open Xunit
open SolveTheBreach.Libs

let spaces = 3
let originalPosition = Position.D5
let assertMove expected dir =
    let actual = Move.Move originalPosition dir spaces
    Assert.Equal(expected, actual)    

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