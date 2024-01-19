Console.WriteLine("Enter character to draw a triangle");
string character = Console.ReadLine();
int rows = 7;
for (int i = 0; i < rows; i++){
    for (int j = 0; j < rows - i; j++)    {
        Console.Write(character);
    }
    Console.WriteLine();
}
Console.ReadKey();