using Exercises;
using src.Services;

namespace ExerciseTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod_Panic()
    {
        string sentence = "The winter is coming";
        string resultado = Challenges.Panic(sentence);
        Assert.AreEqual("THE X WINTER X IS X COMING!", resultado);
    }
    [TestMethod]
    public void TestMethod_Whisper()
    {
        string[] sentences = { Challenges.Whisper("PLEASE STOP SHOUTING."), Challenges.Whisper("MA'M, this is a library!") };

        Assert.AreEqual("shh... please stop shouting.", sentences[0]);
        Assert.AreEqual("shh... ma'm, this is a library", sentences[1]);
    }
    [TestMethod]
    public void TestMethod_AltCaps()
    {
        string sentence = "I'm so happy it's Monday";
        string result = Challenges.AltCaps(sentence);

        Assert.AreEqual("I'M So hApPy iT'S MoNdAy", result);
    }
    [TestMethod]
    public void TestMethod_EmojifyWordWithProperFormat()
    {
        string catWord = ":cat:";
        string dogWord = ":dog:";
        string elephantWord = "elephant";

        string resultCat = Challenges.EmojifyWord(catWord);
        string resultDog = Challenges.EmojifyWord(dogWord);
        string resultElephant = Challenges.EmojifyWord(elephantWord);

        Assert.AreEqual("🐱", resultCat);
        Assert.AreEqual("🐶", resultDog);
        Assert.AreEqual("elephant", resultElephant);
    }
    [TestMethod]
    public void TestMethod_EmojifyPhraseWithProperFormat()
    {
        string test1 = "I :heart: my cat";
        string test2 = "I :heart: the :party: with my :boyfrind:";

        string result1 = Challenges.EmojifyPhrase(test1);
        string result2 = Challenges.EmojifyPhrase(test2);

        Assert.AreEqual("I ♥ my cat",result1);
        Assert.AreEqual("I ♥ the 🥳 with my boyfrind",result2);
    }
    [TestMethod]
    public void Test_TotalSavory()
    {
        double result = Challenges.TotalSavory();

        Assert.AreEqual(9.97, result);
    }
}