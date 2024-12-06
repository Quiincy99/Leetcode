IList<string> RemoveSubfolders(string[] folder)
{
    List<string> result = new();
    Array.Sort(folder);

    result.Add(folder[0]);

    for (int i = 1; i < folder.Length; i++)
    {
        if (!folder[i].StartsWith(result.Last() + "/"))
        {
            result.Add(folder[i]);
        }
    }

    return result;
}

string[] testCase = ["/a", "/a/b", "/c/d", "/c/d/e", "/c/f"];

var testResult = RemoveSubfolders(testCase);
foreach (string s in testResult)
{
    Console.WriteLine(s);
}

