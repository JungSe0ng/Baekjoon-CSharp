Dictionary<string, float> gradeDic = new Dictionary<string, float>();
gradeDic.Add("A+", 4.3f);
gradeDic.Add("A0", 4.0f);
gradeDic.Add("A-", 3.7f);
gradeDic.Add("B+", 3.3f);
gradeDic.Add("B0", 3.0f);
gradeDic.Add("B-", 2.7f);
gradeDic.Add("C+", 2.3f);
gradeDic.Add("C0", 2.0f);
gradeDic.Add("C-", 1.7f);
gradeDic.Add("D+", 1.3f);
gradeDic.Add("D0", 1.0f);
gradeDic.Add("D-", 0.7f);
gradeDic.Add("F", 0.0f);

string input = Console.ReadLine();
Console.WriteLine(string.Format("{0:F1}", gradeDic[input]));