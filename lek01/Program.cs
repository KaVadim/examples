// в тесте пробелы заменить черточками , к на К, С на с

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля.";

// string s = "qwerty"
//             012...
// s[3] // r - будет третьим символом из слова "qwerty"
Console.Clear();

string Replace(string text, char oldVal, char newVal)
{
        string result = String.Empty;

        int length = text.Length;
        for (int i=0; i<length; i++)
        {
            if(text[i] == oldVal) result = result + $"{newVal}";
            else result = result + $"{text[i]}";
        }
        return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
