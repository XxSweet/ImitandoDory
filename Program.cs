Console.WriteLine("--- Imitando Dory ---");

Console.Write("O que voce quer falar para amiga baleia...: ");
string frase = Console.ReadLine()!;

string EmBaleies = frase
    .Replace("a", "aaa")
    .Replace("A", "AAA")
    .Replace("e", "eee")
    .Replace("E", "EEE")
    .Replace("i", "iii")
    .Replace("I", "III")
    .Replace("O", "OOO")
    .Replace("u", "uuu")
    .Replace("U", "UUU")
;

Console.WriteLine($"\nEm baleiês:\n\n{EmBaleies}");