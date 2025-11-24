using Bracket_Checker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bracket_Checker.Tests;

[TestClass]
public class BracketCheckerTest
{

    [TestMethod]
    public void TestCheckSuccess()
    {
        var result = BracketChecker.Check("(hello())");
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckFail()
    {
        var result = BracketChecker.Check("(hello()");
        Assert.IsFalse(result);
    }
}