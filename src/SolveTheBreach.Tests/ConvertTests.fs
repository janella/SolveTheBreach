module ConvertTests

open System
open Xunit
open SolveTheBreach.Libs

[<Fact>]
let ``Convert.Pos converts int to enum`` () =
    let expected = Position.A8
    let actual = Convert.Position(0)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Convert.Pos converts a rank and file to enum`` () =
    let expected = Position.B5
    let actual = Convert.PositionRankFile Rank.Rank5 File.FileB
    Assert.Equal(expected, actual)