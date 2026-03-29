namespace KifuwarabeCSharp.Core.Usi.Models.Position;

internal class MuzPositionReadonly
{


    // ========================================
    // 生成／破棄
    // ========================================


    public MuzPositionReadonly(MuzPositionModel pposition)
    {
        this._pposition = pposition;
    }


    // ========================================
    // 内部データメンバー
    // ========================================


    private MuzPositionModel _pposition;
}
