using System.Linq.Expressions;

string path = "input.txt";
Dictionary<char,int> freq = new Dictionary<char,int>();
Dictionary<string, int> fr = new Dictionary<string, int>();


foreach (var str in  File.ReadAllLines(path))
{
//    var str = File.ReadAllText(path);
    var words = str.ToLower().Split(new char[]{' ', '.', ',' ,':','-'});
    foreach (var word in words)
    {
        //Console.WriteLine(word);
        if (word.Length > 0)
        {
            var ch = word[0];
            if (char.IsLetter(ch))
            {
                if (freq.Keys.Contains(ch))
                    freq[ch]++;
                else
                    freq[ch] = 1;
            }
        }
    }
}

foreach (var k in freq.Keys.Order())
    Console.WriteLine($"{k} - {freq[k],3}");


//foreach (var elem in freq)
//    Console.WriteLine($"{elem.Key}-{elem.Value}");

Console.WriteLine(freq.Keys.Count);


