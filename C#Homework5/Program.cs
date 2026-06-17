void StringLength()
{
    string shortText = "G@M RJob@";
    string longText = "erti ori sami ";

    Console.WriteLine(shortText.Length);

    int Showlength = longText.Length;
    Console.WriteLine(Showlength);

    if (Showlength > 40)
    {
        Console.WriteLine("shecdoma, grdzeli teqstia");
    }
    else
    {
        Console.WriteLine("validacia warmatebit shesrulebulia!");
    }
}

//StringLength();

void StringIndex()
{
    string text = "Gamarjoba,es aris string indexi";

    int textLength = text.Length;
    //int index = textLength - 1;
    

    char character = text[2]; //ან text[index]
    Console.WriteLine(character);
}

//StringIndex();

void StringTrim()
{
    string text = "             C#              ";
    string texti = "$$$$$$$$$$$$C#$$$$$$$$$$";
    Console.WriteLine($"[{texti}]");
    Console.WriteLine($"[{texti.Trim()}]");
    Console.WriteLine($"[{texti.TrimStart()}]");
    Console.WriteLine($"[{texti.TrimEnd()}]");

    string trimmedText = texti.Trim('$');
    Console.WriteLine(texti);
    Console.WriteLine($"[{trimmedText}]");
}

StringTrim();