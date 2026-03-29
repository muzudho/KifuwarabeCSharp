namespace KifuwarabeCSharp.Tests;

using KifuwarabeCSharp.Core.Usi.Elements;
using Xunit;

public class ElementsTest
{


    // ［手番］


    /// <summary>
    ///     <pre>
    /// データ駆動テスト。
    /// 
    ///     - 複数のケースを一気にやる例。
    ///     </pre>
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="expected"></param>
    [Theory]
    [InlineData(MuzColorType.Black, "b")]
    [InlineData(MuzColorType.White, "w")]
    [InlineData(MuzColorType.None, ".")]
    public void ToString_Color_ReturnsString(MuzColorType color, string expected)
    {
        var actual = new MuzColorModel(color).ToString();
        Assert.Equal(expected, actual);
    }


    // ［手数］


    /// <summary>
    /// 2 と 3 を足したら 5 になることをテストする例。
    /// </summary>
    [Fact]
    public void Value_RadixHalfPlyFive_ReturnsFive()
    {
        var expected = 5;
        int actual = new MuzRadixHalfPlyModel(expected).Value;
        Assert.Equal(expected, actual);
    }
}
