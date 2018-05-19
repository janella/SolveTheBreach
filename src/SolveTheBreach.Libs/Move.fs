namespace SolveTheBreach.Libs
open System

module Move =
    let AmIOffTheBoard posInLane dir spaces =
        let newPos = posInLane + (spaces * Convert.GetVal(Types.DirectionToModifier(dir)))
        newPos >= 0 && newPos < 8

    let VerifyMove currPos dir spaces =
        let (rank, file) = Convert.RankFilePosition currPos
        let rankVal = Convert.GetVal rank
        let fileVal = Convert.GetVal file
        match dir with
        | Direction.DirN | Direction.DirS -> AmIOffTheBoard rankVal dir spaces
        | Direction.DirW | Direction.DirE -> AmIOffTheBoard fileVal dir spaces
        | _ -> raise (ArgumentOutOfRangeException("Not a valid Direction"))

    let Move (currPos : Position) (direction : Direction) spaces =
        let isValid = VerifyMove currPos direction spaces
        if isValid then
            let movement = Convert.GetVal(direction) * spaces
            let newPos = Convert.GetVal(currPos) + movement
            Convert.Position newPos
        else
            raise (ArgumentOutOfRangeException("Can't move off the board"))