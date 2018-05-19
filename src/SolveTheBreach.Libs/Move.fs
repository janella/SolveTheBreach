namespace SolveTheBreach.Libs

module Move =
    let Move (currPos : Position) (direction : Direction) spaces =
        let movement = Convert.GetVal(direction) * spaces
        let newPos = Convert.GetVal(currPos) + movement
        Convert.Position newPos