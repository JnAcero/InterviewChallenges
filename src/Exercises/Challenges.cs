using Newtonsoft.Json.Linq;
using src.Services;

namespace Exercises;

public class Challenges
{
    public static string Panic(string sentence)
    {
        if (sentence.Contains(" "))
        {
            sentence = sentence.ToUpper().Replace(" ", " X ") + "!";
        }
        else
        {
            sentence = sentence.ToUpper() + "!";
        }
        return sentence;
    }
    public static string Whisper(string sentence)
    {
        sentence = $"shh... {sentence.ToLower()}";
        if (sentence.EndsWith("!"))
        {
            sentence = sentence.Replace("!", "");
        }
        return sentence;
    }
    public static string AltCaps(string sentence)
    {
        string newString = "";
        char[] caracteres = sentence.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            if (i % 2 == 0) newString += caracteres[i].ToString().ToUpper();
            else newString += caracteres[i];
        }
        return newString;
    }
    public static string EmojifyWord(string word)
    {
        Dictionary<string, string> emojis = new()
        {
            {"smile","😁"},
            {"angry","😡"},
            {"party","🥳"},
            {"heart","♥"},
            {"cat","🐱"},
            {"dog","🐶"},
        };
        string copyLower = word.ToLower();
        if (copyLower.StartsWith(":") && copyLower.EndsWith(":")){
            copyLower = copyLower.Replace(":", "");
            if (emojis.ContainsKey(copyLower)) return emojis[copyLower];
            else return copyLower;
        }
        else return word;
    }
    public static string EmojifyPhrase(string phrase)
    {
        var words = phrase.Split(" ").Select(x =>EmojifyWord(x)).ToList();
        string phraseEmojified = string.Join(" ",words);
        Console.WriteLine(phraseEmojified);

        return phraseEmojified;
    }
    public static double TotalSavory(){
        double acumulator = 0;
        JArray array = ChallengeService.ReadAndLoadDataFromFile("../../../../../data.json");
        try{
        foreach(var item in array){
            if(item["type"].ToString() == "savory"){
                acumulator = acumulator + (double)item["price"]; 
            }
        }
        return Math.Round(acumulator,2);
        }catch(Exception e){
            Console.WriteLine(e.Message);
            return 0;
        }
    }
}
