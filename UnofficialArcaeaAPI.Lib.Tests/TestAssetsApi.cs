using UnofficialArcaeaAPI.Lib.Models;

namespace UnofficialArcaeaAPI.Lib.Tests;

public class TestAssetsApi : TestBase
{
    [Fact]
    public async Task TestAff()
    {
        var affText = await DefaultClient.Assets.GetAffAsync("inkarusi", UaaSongQueryType.SongId);

        Assert.Contains("arctap", affText);
    }
}