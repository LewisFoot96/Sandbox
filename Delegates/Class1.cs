namespace Delegates;

public class Class1
{
    Func<int, int, int> sumFunc = (a, b) => a + b;

    private Action<string> _returnStringAction = Console.WriteLine;

    public void TestTheDelegate()
    {
        TestDelegate(sumFunc, 1);

        TestDelegate((test, test1) => test + test1, 1);
        
        TestActionDelegate(_returnStringAction);
    }

    private void TestDelegate(Func<int, int, int> mathsFunction, int test)
    {
        var result = mathsFunction(10, 10) + test;
    }

    private void TestActionDelegate(Action<string> testAction)
    {
        testAction("Hello");
    }
}