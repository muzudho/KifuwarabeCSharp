namespace KifuwarabeCSharp.Core.Usi.Models.Position;

using KifuwarabeCSharp.Core.Usi.Models.Position.Elements;

/// <summary>
/// 局面のモデルだぜ（＾～＾）！
/// </summary>
internal class MuzPositionModel
{


    // ========================================
    // 生成／破棄
    // ========================================


    public MuzPositionModel()
    {
        this.HandStandCollection = MuzHandStandCollectionModel.CreateEmpty();
    }


    // ========================================
    // 窓口データメンバー
    // ========================================


    public MuzHandStandCollectionModel HandStandCollection { get; init; }
}
