namespace LongestRepeatingCharacterReplacement.Tests;
using LongestRepeatingCharacterReplacement;

[TestClass]
public class UnitTest1
{
    public CharReplacer _replace = new CharReplacer();
    [TestMethod]
    public void TestMethod1()
    {
        string s = "ABAB";
        int k = 2;
        var result = _replace.CharacterReplacement(s, k);
        Assert.AreEqual(4, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        string s = "AABABBA";
        int k = 1;
        var result = _replace.CharacterReplacement(s, k);
        Assert.AreEqual(4, result);
    }
}