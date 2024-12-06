using System.Text;

string MergeAlternately(string word1, string word2)
{

    if (word1.Length == 0) return word2;
    if (word2.Length == 0) return word1;

    StringBuilder stringBuilder = new StringBuilder();
    for (int i = 0; i < word1.Length; i++)
    {
        stringBuilder.Append(word1[i]);
        stringBuilder.Append(word2[i]);

        if (i + 1 == word1.Length)
        {
            stringBuilder.Append(word2.Substring(i + 1));
            break;
        }

        if (i + 1 == word2.Length)
        {
            stringBuilder.Append(word1.Substring(i + 1));
            break;
        }
    }

    return stringBuilder.ToString();
}

Tuple<string, string> testCase = new Tuple<string, string>("abcd", "pqrst");

Console.WriteLine(MergeAlternately(testCase.Item1, testCase.Item2));