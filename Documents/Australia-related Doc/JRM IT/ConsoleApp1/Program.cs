List<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e' };
var reversedLetters = letters.AsEnumerable().Reverse();
foreach (var letter in reversedLetters)
{
    Console.WriteLine(letter);
}
