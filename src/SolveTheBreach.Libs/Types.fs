namespace SolveTheBreach.Libs

[<AutoOpen>]
module Types = 
    open System

    type Move = int
    let NoMovement = 0

    type Position = 
            | A8 = 0
            | B8 = 1
            | C8 = 2
            | D8 = 3
            | E8 = 4
            | F8 = 5
            | G8 = 6
            | H8 = 7
            | A7 = 8
            | B7 = 9
            | C7 = 10
            | D7 = 11
            | E7 = 12
            | F7 = 13
            | G7 = 14
            | H7 = 15
            | A6 = 16
            | B6 = 17
            | C6 = 18
            | D6 = 19
            | E6 = 20
            | F6 = 21
            | G6 = 22
            | H6 = 23
            | A5 = 24
            | B5 = 25
            | C5 = 26
            | D5 = 27
            | E5 = 28
            | F5 = 29
            | G5 = 30
            | H5 = 31
            | A4 = 32
            | B4 = 33
            | C4 = 34
            | D4 = 35
            | E4 = 36
            | F4 = 37
            | G4 = 38
            | H4 = 39
            | A3 = 40
            | B3 = 41
            | C3 = 42
            | D3 = 43
            | E3 = 44
            | F3 = 45
            | G3 = 46
            | H3 = 47
            | A2 = 48
            | B2 = 49
            | C2 = 50
            | D2 = 51
            | E2 = 52
            | F2 = 53
            | G2 = 54
            | H2 = 55
            | A1 = 56
            | B1 = 57
            | C1 = 58
            | D1 = 59
            | E1 = 60
            | F1 = 61
            | G1 = 62
            | H1 = 63
            | OUTOFBOUNDS = 64
                        
    type Rank =
        | Rank8 = 0
        | Rank7 = 1
        | Rank6 = 2
        | Rank5 = 3
        | Rank4 = 4
        | Rank3 = 5
        | Rank2 = 6
        | Rank1 = 7
        | EMPTY = 8
    
    type File = 
        | FileA = 0
        | FileB = 1
        | FileC = 2
        | FileD = 3
        | FileE = 4
        | FileF = 5
        | FileG = 6
        | FileH = 7
        | EMPTY = 8

    type Direction = 
        | DirN = -8
        | DirE = 1
        | DirS = 8
        | DirW = -1
        
    type DirectionModifier = 
        | DirN = -1
        | DirE = 1
        | DirS = 1
        | DirW = -1

    let DirectionToModifier dir = 
        match dir with
        | Direction.DirN -> DirectionModifier.DirN
        | Direction.DirW -> DirectionModifier.DirW
        | Direction.DirE -> DirectionModifier.DirE
        | Direction.DirS -> DirectionModifier.DirS
        | _ -> raise (ArgumentOutOfRangeException("Not a valid Direction"))