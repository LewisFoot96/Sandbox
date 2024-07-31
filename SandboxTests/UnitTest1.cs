using Chill;
using FluentAssertions;

namespace SandboxTests;

[TestClass]
public class UnitTest1 : GivenWhenThen<int>
{
    // [DataTestMethod]
    // [DataRow(1)]
    // [DataRow(2)]
    // [DataRow(3)]
    // [DataRow(4)]

    public UnitTest1()
    {
        int number = default;
        Given(() =>
        {
            number = 2 * 10;
        });
        
        When(() =>
        {
            number -= 10;

            return number;
        });
    }

    [TestMethod]
    public void Then_result_is_correct()
    {
        Result.Should().Be(10);
    }
}