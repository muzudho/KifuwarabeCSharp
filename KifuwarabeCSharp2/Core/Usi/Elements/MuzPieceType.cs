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
    NoboriFu = 1,   // ▲歩
    NoboriKyo,      // ▲香
    NoboriKei,      // ▲桂
    NoboriGin,      // ▲銀
    NoboriKaku,     // ▲角
    NoboriHisya,    // ▲飛
    NoboriKin,      // ▲金
    NoboriGyoku,    // ▲玉
    NoboriTokin,    // ▲と金
    NoboriNariKyo,  // ▲成香
    NoboriNariKei,  // ▲成桂
    NoboriNariGin,  // ▲成銀
    NoboriUma,      // ▲馬
    NoboriRyu,      // ▲龍
    // BDragon = 14
    KudariFu = 17,  // ▽歩
    KudariKyo,      // ▽香
    KudariKei,      // ▽桂
    KudariGin,      // ▽銀
    KudariKaku,     // ▽角
    KudariHisya,    // ▽飛
    KudariKin,      // ▽金
    KudariGyoku,    // ▽玉
    KudariTokin,    // ▽と金
    KudariNariKyo,  // ▽成香
    KudariNariKei,  // ▽成桂
    KudariNariGin,  // ▽成銀
    KudariUma,      // ▽馬
    KudariRyu,      // ▽龍
    PieceNone // PieceNone = 31  これを 32 にした方が多重配列のときに有利か。
}
