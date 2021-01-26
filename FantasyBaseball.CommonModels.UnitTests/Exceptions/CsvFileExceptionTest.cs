using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FantasyBaseball.CommonModels.Exceptions;
using Xunit;

namespace FantasyBaseball.CommonModels.UnitTests.Exceptions
{
    public class CsvFileExceptionTest
    {
        [Fact] public void EqualsMessage() => Assert.Equal("message", new CsvFileException("message").Message);
    }
}