namespace SandboxTests;

[TestClass]
public class UnitTest1
{
    [DataTestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(4)]
    public void TestMethod1(int result)
    {
    }
}