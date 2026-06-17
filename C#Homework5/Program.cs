//ყველა მეთოდი გაშვებულია და დაკომენტარებულია რათა სათითაოდ უფრო მარტივად შემოწმდეს

int ReturMethod(int age)
{
    if (age >= 50)
    {
        Console.WriteLine("shemowmeba");
        return 10;
    }
    else if (age < 0)
    {
        Console.WriteLine("Sheiyvane naturaluri ricxvi!");
        return -10;
    }

    return 0;
}

//ReturMethod(50);

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

//StringTrim();

//ამ კოდის გაშვებისას ერორს მიგდებდა და როგორც გავარკვიე ანტივირუსი არ უშვებდა,მაგრამ წესით სწორი უნდა იყოს(ან ინდექსის გაწერის გამო )
//void StringSubstring()
//{
//    string text = "Nirvana metallica crowbar radiohead";

    
//    Console.WriteLine(text.Substring(0, 7));
//    Console.WriteLine(text.Substring(8, 9));
//    Console.WriteLine(text.Substring(0, text.Length - 9));
//    Console.WriteLine(text);
//}

//StringSubstring();


//ვარიანტი 2

void StringSubstring()
{
    string text = "Nirvana metallica crowbar radiohead";


    Console.WriteLine(text.Substring(0, 7));
    Console.WriteLine(text.Substring(8, 9));
    Console.WriteLine(text.Substring(0, 26));
    Console.WriteLine(text);
}

//StringSubstring();

void StringEquals()
{
    string password = "Itstep";

    Console.WriteLine("Gtxovt sheiyvanot paroli:");
    string loginPassword = Console.ReadLine();

    bool isCorrect = password.Equals(loginPassword);

    if (isCorrect)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("warmatebit shexvedit!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("arasworad sheiyvanet!");
    }
}

//StringEquals();

void StringSplit()
{
    string animals = "Lion,Tiger,Wolf,Dog,Sheep,Cat,Pig,Cow";

    string[] animalArray = animals.Split(',');

    foreach (string animal in animalArray)
    {
        Console.WriteLine(animal);
    }
}

//StringSplit();

void StringContains()
{
    string product = "Lenovo ThinkPad T16 G4 21QE0063GX, Intel Core Ultra 5-225U, Intel UHD Graphics, 16GB RAM SSD 512GB, Free Dos, ლეპტოპი";

    string productLower = product.ToLower();
    string productUpper = product.ToUpper();

    Console.WriteLine(productLower);
    Console.WriteLine(productUpper);

    Console.WriteLine("Modzebnet sasurveli nivti:");
    string search = Console.ReadLine();
    string searchLower = search.ToLower();

    bool searched = productLower.Contains(searchLower);

    if (searched)
    {
        Console.WriteLine(product);
    }
    else
    {
        Console.WriteLine("ver moidzebna");
    }
}

//StringContains();