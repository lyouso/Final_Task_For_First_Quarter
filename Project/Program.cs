string[] array =
{
    "hello",
    "2",
    "world",
    ":-)",
};

string[] result = new string[array.Length];
int rezultSize = 0;

foreach (string value in array)
{
    if (value.Length <= 3)
    {
        result[rezultSize] = value;
        Console.Write(result[rezultSize] + "\t");
        rezultSize++;
    }
}