using System.Text;

Encode encode = new Encode();
// входная строка
string testIn = Console.ReadLine();
byte[] test = encode.ToCP866(testIn);
Console.WriteLine("Исходная строка \'{0}\'", testIn);
Console.WriteLine("Строка в закодированном виде \'{0}\'", test);
File.WriteAllBytes(@"C:\result.txt", test);
Console.ReadLine();

public class Encode
{
    Dictionary<string, byte> dictionaryChar = new Dictionary<string, byte>()
            {
                { "А", 128 },
                { "Б", 129 },
                { "В", 130 },
                { "Г", 131 },
                { "Д", 132 },
                { "Е", 133 },
                { "Ё", 240 },
                { "Ж", 134 },
                { "З", 135 },
                { "И", 136 },
                { "Й", 137 },
                { "К", 138 },
                { "Л", 139 },
                { "М", 140 },
                { "Н", 141 },
                { "О", 142 },
                { "П", 143 },
                { "Р", 144 },
                { "С", 145 },
                { "Т", 146 },
                { "У", 147 },
                { "Ф", 148 },
                { "Х", 149 },
                { "Ц", 150 },
                { "Ч", 151 },
                { "Ш", 152 },
                { "Щ", 153 },
                { "Ъ", 154 },
                { "Ы", 155 },
                { "Ь", 156 },
                { "Э", 157 },
                { "Ю", 158 },
                { "Я", 159 },
                { "а", 160 },
                { "б", 161 },
                { "в", 162 },
                { "г", 163 },
                { "д", 164 },
                { "е", 165 },
                { "ё", 241 },
                { "ж", 166 },
                { "з", 167 },
                { "и", 168 },
                { "й", 169 },
                { "к", 170 },
                { "л", 171 },
                { "м", 172 },
                { "н", 173 },
                { "о", 174 },
                { "п", 175 },
                { "р", 224 },
                { "с", 225 },
                { "т", 226 },
                { "у", 227 },
                { "ф", 228 },
                { "х", 229 },
                { "ц", 230 },
                { "ч", 231 },
                { "ш", 232 },
                { "щ", 233 },
                { "ъ", 234 },
                { "ы", 235 },
                { "ь", 236 },
                { "э", 237 },
                { "ю", 238 },
                { "я", 239 }
            };
    public byte[] ToCP866(string source)
    {
        var result = new List<byte>();
        foreach (char ch in source)
        {
            byte ss;
            if (dictionaryChar.TryGetValue(ch.ToString(), out ss))
            {
                result.Add(ss);
            }

        }
        return result.ToArray();
    }
}