namespace KifuwarabeCSharp.Core.Usi.Elements;

/// <summary>
///		<pre>
/// 駒
///		B* に 16 を加算することで、W* を表す。
///		Promoted を加算することで、成りを表す。
///		</pre>
/// </summary>
internal enum MuzPieceType
{
    Empty = 0,
    UnPromoted = 0,
    Promoted = 8,
    NoboriFu = 1,      // Black Pawn
    NoboriKyo,
    NoboriKei,
    NoboriGin,
    NoboriKaku,
    NoboriHisya,
    NoboriKin,
    NoboriGyoku,
    BProPawn,       // Black Promoted Pawn
    BProLance,
    BProKnight,
    BProSilver,
    BHorse,
    BDragon,
    // BDragon = 14
    KudariFu = 17,     // White Pawn
    KudariKyo,
    KudariKei,
    KudariGin,
    WBishop,
    WRook,
    KudariKin,
    WKing,
    WProPawn,
    WProLance,
    WProKnight,
    WProSilver,
    WHorse,
    WDragon,
    PieceNone // PieceNone = 31  これを 32 にした方が多重配列のときに有利か。
}
