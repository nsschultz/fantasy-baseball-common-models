using FantasyBaseball.CommonModels.Enums;
using Xunit;
using static FantasyBaseball.CommonModels.Enums.EnumUtility;

namespace FantasyBaseball.CommonModels.UnitTests.Enums
{
    public class EnumUtilityTest
    {
        [Theory]
        [InlineData(StatsType.CMBD, "Combined Stats"    )]
        [InlineData(StatsType.PROJ, "Projected Stats"   )]
        [InlineData( StatsType.YTD, "Year to Date Stats")]
        [InlineData(StatsType.UNKN, "Unknown Stats"     )]
        [InlineData(          null, "Unknown Stats"     )]
        public void GetDescriptionTest(StatsType type, string description) => Assert.Equal(description, GetDescription(type));

        [Theory]
        [InlineData(StatsType.CMBD, "Combined stats"    )]
        [InlineData(StatsType.PROJ, "Projected STATS"   )]
        [InlineData( StatsType.YTD, "Year TO Date Stats")]
        [InlineData(StatsType.UNKN, "Unknown Stats"     )]
        [InlineData(StatsType.UNKN, "Something Else"    )]
        [InlineData(StatsType.UNKN, null                )]
        public void GetFromDescriptionTest(StatsType type, string desc) => Assert.Equal(type, GetFromDescription<StatsType>(desc));

        [Theory]
        [InlineData(StatsType.CMBD, "cmbd"          )]
        [InlineData(StatsType.PROJ, "PROJ"          )]
        [InlineData( StatsType.YTD, "Ytd"           )]
        [InlineData(StatsType.UNKN, "unKN"          )]
        [InlineData(StatsType.UNKN, "Something Else")]
        [InlineData(StatsType.UNKN, null            )]
        public void GetFromKeyTest(StatsType type, string key) => Assert.Equal(type, GetFromKey<StatsType>(key));
    }
}