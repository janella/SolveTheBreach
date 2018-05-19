namespace SolveTheBreach.Libs

module Convert =
    let GetVal x = LanguagePrimitives.EnumToValue(x)
    let Position i = enum<Position>(i)
    let Rank i = enum<Rank>(i)
    let File i = enum<File>(i)
    
    let PositionRankFile (rank : Rank) (file : File) =
        let pos = (GetVal(rank) * 8) + GetVal(file)
        Position(pos)
    
    let RankFilePosition (pos : Position) =
        let posVal = GetVal pos
        let file = posVal % 8
        let rank = (posVal - file) / 8
        Rank(rank), File(file)
    