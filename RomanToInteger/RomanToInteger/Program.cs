// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

string roman = Convert.ToString(Console.ReadLine().Trim().ToUpper());

if(roman.Length >= 15)
{
    Console.WriteLine("Invalid Roman numeral");
    return;
}

char[] validRomanChars = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

bool result = roman.All(c => validRomanChars.Contains(c));

if (!result)
{
    return;
} 

 Dictionary<char, int> RomanMap = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

int lastValue = 0;
int resultValue = 0;
for (int i = roman.Length - 1; i >= 0; i--)
{
    char currentSymbol = roman[i];

    int value = RomanMap[currentSymbol];

    if(value < lastValue) {
        resultValue -= value;
    }
    else
    {
        resultValue += value;
    }

    lastValue = value;

}

if (resultValue > 3999)
    return;
